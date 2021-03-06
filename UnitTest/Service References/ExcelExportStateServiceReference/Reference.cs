﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest.ExcelExportStateServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExportParam", Namespace="http://schemas.datacontract.org/2004/07/ExcelServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ExportParam : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UnitTest.ExcelExportStateServiceReference.ExportState ExportStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FolderRootPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid GuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JsonSettingDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemplateFileNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDateTime {
            get {
                return this.CreateDateTimeField;
            }
            set {
                if ((this.CreateDateTimeField.Equals(value) != true)) {
                    this.CreateDateTimeField = value;
                    this.RaisePropertyChanged("CreateDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UnitTest.ExcelExportStateServiceReference.ExportState ExportState {
            get {
                return this.ExportStateField;
            }
            set {
                if ((this.ExportStateField.Equals(value) != true)) {
                    this.ExportStateField = value;
                    this.RaisePropertyChanged("ExportState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FolderRootPath {
            get {
                return this.FolderRootPathField;
            }
            set {
                if ((object.ReferenceEquals(this.FolderRootPathField, value) != true)) {
                    this.FolderRootPathField = value;
                    this.RaisePropertyChanged("FolderRootPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Guid {
            get {
                return this.GuidField;
            }
            set {
                if ((this.GuidField.Equals(value) != true)) {
                    this.GuidField = value;
                    this.RaisePropertyChanged("Guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JsonSettingData {
            get {
                return this.JsonSettingDataField;
            }
            set {
                if ((object.ReferenceEquals(this.JsonSettingDataField, value) != true)) {
                    this.JsonSettingDataField = value;
                    this.RaisePropertyChanged("JsonSettingData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TemplateFileName {
            get {
                return this.TemplateFileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TemplateFileNameField, value) != true)) {
                    this.TemplateFileNameField = value;
                    this.RaisePropertyChanged("TemplateFileName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExportState", Namespace="http://schemas.datacontract.org/2004/07/ExcelServiceLibrary")]
    public enum ExportState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Wait = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExcelExportStateServiceReference.IExcelExportState")]
    public interface IExcelExportState {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/SetStateCacheName", ReplyAction="http://tempuri.org/IExcelExportState/SetStateCacheNameResponse")]
        void SetStateCacheName(string _name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/SetStateCacheName", ReplyAction="http://tempuri.org/IExcelExportState/SetStateCacheNameResponse")]
        System.Threading.Tasks.Task SetStateCacheNameAsync(string _name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/GetStateCacheName", ReplyAction="http://tempuri.org/IExcelExportState/GetStateCacheNameResponse")]
        string GetStateCacheName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/GetStateCacheName", ReplyAction="http://tempuri.org/IExcelExportState/GetStateCacheNameResponse")]
        System.Threading.Tasks.Task<string> GetStateCacheNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/RemoveTimeoutCache", ReplyAction="http://tempuri.org/IExcelExportState/RemoveTimeoutCacheResponse")]
        void RemoveTimeoutCache(int _minute);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/RemoveTimeoutCache", ReplyAction="http://tempuri.org/IExcelExportState/RemoveTimeoutCacheResponse")]
        System.Threading.Tasks.Task RemoveTimeoutCacheAsync(int _minute);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/SetSessionData", ReplyAction="http://tempuri.org/IExcelExportState/SetSessionDataResponse")]
        void SetSessionData(UnitTest.ExcelExportStateServiceReference.ExportParam _state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/SetSessionData", ReplyAction="http://tempuri.org/IExcelExportState/SetSessionDataResponse")]
        System.Threading.Tasks.Task SetSessionDataAsync(UnitTest.ExcelExportStateServiceReference.ExportParam _state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/ChangeExportState", ReplyAction="http://tempuri.org/IExcelExportState/ChangeExportStateResponse")]
        void ChangeExportState(System.Guid _guid, UnitTest.ExcelExportStateServiceReference.ExportState _exportState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/ChangeExportState", ReplyAction="http://tempuri.org/IExcelExportState/ChangeExportStateResponse")]
        System.Threading.Tasks.Task ChangeExportStateAsync(System.Guid _guid, UnitTest.ExcelExportStateServiceReference.ExportState _exportState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/GetSessionData", ReplyAction="http://tempuri.org/IExcelExportState/GetSessionDataResponse")]
        UnitTest.ExcelExportStateServiceReference.ExportParam GetSessionData(System.Guid _guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/GetSessionData", ReplyAction="http://tempuri.org/IExcelExportState/GetSessionDataResponse")]
        System.Threading.Tasks.Task<UnitTest.ExcelExportStateServiceReference.ExportParam> GetSessionDataAsync(System.Guid _guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/IsSessionDataStateCompleted", ReplyAction="http://tempuri.org/IExcelExportState/IsSessionDataStateCompletedResponse")]
        bool IsSessionDataStateCompleted(System.Guid _guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/IsSessionDataStateCompleted", ReplyAction="http://tempuri.org/IExcelExportState/IsSessionDataStateCompletedResponse")]
        System.Threading.Tasks.Task<bool> IsSessionDataStateCompletedAsync(System.Guid _guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/Pop", ReplyAction="http://tempuri.org/IExcelExportState/PopResponse")]
        UnitTest.ExcelExportStateServiceReference.ExportParam Pop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/Pop", ReplyAction="http://tempuri.org/IExcelExportState/PopResponse")]
        System.Threading.Tasks.Task<UnitTest.ExcelExportStateServiceReference.ExportParam> PopAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/NewGuid", ReplyAction="http://tempuri.org/IExcelExportState/NewGuidResponse")]
        System.Guid NewGuid();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExcelExportState/NewGuid", ReplyAction="http://tempuri.org/IExcelExportState/NewGuidResponse")]
        System.Threading.Tasks.Task<System.Guid> NewGuidAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExcelExportStateChannel : UnitTest.ExcelExportStateServiceReference.IExcelExportState, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExcelExportStateClient : System.ServiceModel.ClientBase<UnitTest.ExcelExportStateServiceReference.IExcelExportState>, UnitTest.ExcelExportStateServiceReference.IExcelExportState {
        
        public ExcelExportStateClient() {
        }
        
        public ExcelExportStateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExcelExportStateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExcelExportStateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExcelExportStateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetStateCacheName(string _name) {
            base.Channel.SetStateCacheName(_name);
        }
        
        public System.Threading.Tasks.Task SetStateCacheNameAsync(string _name) {
            return base.Channel.SetStateCacheNameAsync(_name);
        }
        
        public string GetStateCacheName() {
            return base.Channel.GetStateCacheName();
        }
        
        public System.Threading.Tasks.Task<string> GetStateCacheNameAsync() {
            return base.Channel.GetStateCacheNameAsync();
        }
        
        public void RemoveTimeoutCache(int _minute) {
            base.Channel.RemoveTimeoutCache(_minute);
        }
        
        public System.Threading.Tasks.Task RemoveTimeoutCacheAsync(int _minute) {
            return base.Channel.RemoveTimeoutCacheAsync(_minute);
        }
        
        public void SetSessionData(UnitTest.ExcelExportStateServiceReference.ExportParam _state) {
            base.Channel.SetSessionData(_state);
        }
        
        public System.Threading.Tasks.Task SetSessionDataAsync(UnitTest.ExcelExportStateServiceReference.ExportParam _state) {
            return base.Channel.SetSessionDataAsync(_state);
        }
        
        public void ChangeExportState(System.Guid _guid, UnitTest.ExcelExportStateServiceReference.ExportState _exportState) {
            base.Channel.ChangeExportState(_guid, _exportState);
        }
        
        public System.Threading.Tasks.Task ChangeExportStateAsync(System.Guid _guid, UnitTest.ExcelExportStateServiceReference.ExportState _exportState) {
            return base.Channel.ChangeExportStateAsync(_guid, _exportState);
        }
        
        public UnitTest.ExcelExportStateServiceReference.ExportParam GetSessionData(System.Guid _guid) {
            return base.Channel.GetSessionData(_guid);
        }
        
        public System.Threading.Tasks.Task<UnitTest.ExcelExportStateServiceReference.ExportParam> GetSessionDataAsync(System.Guid _guid) {
            return base.Channel.GetSessionDataAsync(_guid);
        }
        
        public bool IsSessionDataStateCompleted(System.Guid _guid) {
            return base.Channel.IsSessionDataStateCompleted(_guid);
        }
        
        public System.Threading.Tasks.Task<bool> IsSessionDataStateCompletedAsync(System.Guid _guid) {
            return base.Channel.IsSessionDataStateCompletedAsync(_guid);
        }
        
        public UnitTest.ExcelExportStateServiceReference.ExportParam Pop() {
            return base.Channel.Pop();
        }
        
        public System.Threading.Tasks.Task<UnitTest.ExcelExportStateServiceReference.ExportParam> PopAsync() {
            return base.Channel.PopAsync();
        }
        
        public System.Guid NewGuid() {
            return base.Channel.NewGuid();
        }
        
        public System.Threading.Tasks.Task<System.Guid> NewGuidAsync() {
            return base.Channel.NewGuidAsync();
        }
    }
}
