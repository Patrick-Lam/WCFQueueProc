using System;
using System.Collections.Generic;
using System.ServiceModel;


namespace ExcelServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Excel" in both code and config file together. 
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ExcelExportState : IExcelExportState
    {
        private static readonly object lock_on = new object();

        private static string stateCacheName = "";

        private Dictionary<Guid, ExportParam> _state = null;

        private Dictionary<Guid, ExportParam> state { get { return this.dic(); } set { this._state = value; } }

        private Dictionary<Guid, ExportParam> dic()
        {
            if (this._state != null) return this._state;

            lock (ExcelExportState.lock_on)
            {
                if (this._state != null) return this._state;

                var cacheContent = System.Web.HttpContext.Current.Application[ExcelExportState.stateCacheName];

                if (cacheContent == null)
                {
                    this._state = new Dictionary<Guid, ExportParam>();

                    System.Web.HttpContext.Current.Application[ExcelExportState.stateCacheName] = this._state;
                }
                else
                {
                    this._state = (Dictionary<Guid, ExportParam>)System.Web.HttpContext.Current.Application[ExcelExportState.stateCacheName];
                }

                return this._state;
            }
        }

        public ExcelExportState()
        {
            ExcelExportState.stateCacheName = "ExcelExportStateServiceBaseCache";
        }

        public ExcelExportState(string _stateCacheName)
        {
            ExcelExportState.stateCacheName = _stateCacheName;
        }

        public Guid NewGuid()
        {
            return Guid.NewGuid();
        }

        public void SetStateCacheName(string _name)
        {
            ExcelExportState.stateCacheName = _name;
        }

        public string GetStateCacheName()
        {
            return ExcelExportState.stateCacheName;
        }

        public void RemoveTimeoutCache(int _minute)
        {
            lock (ExcelExportState.lock_on)
            {
                DateTime nMinuteBefore = DateTime.Now;

                nMinuteBefore = nMinuteBefore.AddMinutes(-1 * _minute);

                List<Guid> timeOutItems = new List<Guid>();

                foreach (Guid key in state.Keys)
                {
                    ExportParam ep = state[key];

                    if (ep.CreateDateTime < nMinuteBefore)
                    {
                        timeOutItems.Add(key);
                    }
                }

                foreach (Guid key in timeOutItems)
                {
                    state.Remove(key);
                }
            }
        }

        public void SetSessionData(ExportParam _exportParam)
        {
            lock (ExcelExportState.lock_on)
            {
                if (state.ContainsKey(_exportParam.Guid))
                {
                    state[_exportParam.Guid] = _exportParam;
                }
                else
                {
                    state.Add(_exportParam.Guid, _exportParam);
                }
            }
        }

        public void ChangeExportState(Guid _guid, ExportState _exportState)
        {
            lock (ExcelExportState.lock_on)
            {
                if (!state.ContainsKey(_guid))
                {
                    throw new FaultException(string.Format("Session GUID [{0}] Not Found", _guid.ToString()));
                }
                else
                {
                    state[_guid].ExportState = _exportState;
                }
            }
        }

        public ExportParam GetSessionData(Guid _guid)
        {
            lock (ExcelExportState.lock_on)
            {
                if (!state.ContainsKey(_guid))
                {
                    throw new FaultException(string.Format("Session GUID [{0}] Not Found", _guid.ToString()));
                }
                else
                {
                    return state[_guid];
                }
            }
        }

        public bool IsSessionDataStateCompleted(Guid _guid)
        {
            lock (ExcelExportState.lock_on)
            {
                if (!state.ContainsKey(_guid))
                {
                    throw new FaultException(string.Format("Session GUID [{0}] Not Found", _guid.ToString()));
                }
                else
                {
                    return (state[_guid].ExportState == ExportState.Completed);
                }
            }
        }

        public ExportParam Pop()
        {
            foreach (Guid key in state.Keys)
            {
                ExportParam ep = state[key];

                if (ep.ExportState == ExportState.Wait)
                {
                    return ep;
                }
            }

            return null;
        }
    }

    public class ExportParam
    {
        public ExportParam()
        {

        }

        public ExportParam(Guid _guid, string _templateFileName, string _jsonSettingData)
        {
            this.Guid = _guid;
            this.ExportState = ExcelServiceLibrary.ExportState.Wait;
            this.JsonSettingData = _jsonSettingData;
            this.CreateDateTime = DateTime.Now;
            this.TemplateFileName = _templateFileName;
        }

        public Guid Guid { get; set; }

        public ExportState ExportState { get; set; }

        public string JsonSettingData { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string TemplateFileName { get; set; }

        public string FolderRootPath { get; set; }
    }

    public enum ExportState
    {
        Wait = 0,
        Completed,
        Failed
    }
}

