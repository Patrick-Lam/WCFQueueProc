using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExcelServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExcel" in both code and config file together. 
    [ServiceContract(SessionMode=SessionMode.Allowed)]
    public interface IExcelExportState
    {
        [OperationContract]
        void SetStateCacheName(string _name);

        [OperationContract]
        string GetStateCacheName();

        [OperationContract]
        void RemoveTimeoutCache(int _minute);

        [OperationContract]
        void SetSessionData(ExportParam _state);

        [OperationContract]
        void ChangeExportState(Guid _guid, ExportState _exportState);

        [OperationContract]
        ExportParam GetSessionData(Guid _guid);

        [OperationContract]
        bool IsSessionDataStateCompleted(Guid _guid);

        [OperationContract]
        ExportParam Pop();

        [OperationContract]
        Guid NewGuid();
    }
}
