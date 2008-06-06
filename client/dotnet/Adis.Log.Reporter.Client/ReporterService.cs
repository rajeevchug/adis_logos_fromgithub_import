﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adis.Log.Contract
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestFilter", Namespace="http://schemas.datacontract.org/2004/07/Adis.Log.Contract")]
    public partial class RequestFilter : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ApplicationField;
        
        private bool ApplicationExactMatchField;
        
        private string CategoryField;
        
        private bool CategoryExactMatchField;
        
        private System.Nullable<System.DateTime> EndTimeField;
        
        private System.Nullable<int> IdField;
        
        private string InstanceField;
        
        private bool InstanceExactMatchField;
        
        private string MachineField;
        
        private bool MachineExactMatchField;
        
        private string MessageField;
        
        private bool MessageExactMatchField;
        
        private string SeverityField;
        
        private System.Nullable<System.DateTime> StartTimeField;
        
        private string UserField;
        
        private bool UserExactMatchField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Application
        {
            get
            {
                return this.ApplicationField;
            }
            set
            {
                this.ApplicationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ApplicationExactMatch
        {
            get
            {
                return this.ApplicationExactMatchField;
            }
            set
            {
                this.ApplicationExactMatchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CategoryExactMatch
        {
            get
            {
                return this.CategoryExactMatchField;
            }
            set
            {
                this.CategoryExactMatchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EndTime
        {
            get
            {
                return this.EndTimeField;
            }
            set
            {
                this.EndTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Instance
        {
            get
            {
                return this.InstanceField;
            }
            set
            {
                this.InstanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InstanceExactMatch
        {
            get
            {
                return this.InstanceExactMatchField;
            }
            set
            {
                this.InstanceExactMatchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Machine
        {
            get
            {
                return this.MachineField;
            }
            set
            {
                this.MachineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MachineExactMatch
        {
            get
            {
                return this.MachineExactMatchField;
            }
            set
            {
                this.MachineExactMatchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MessageExactMatch
        {
            get
            {
                return this.MessageExactMatchField;
            }
            set
            {
                this.MessageExactMatchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Severity
        {
            get
            {
                return this.SeverityField;
            }
            set
            {
                this.SeverityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartTime
        {
            get
            {
                return this.StartTimeField;
            }
            set
            {
                this.StartTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool UserExactMatch
        {
            get
            {
                return this.UserExactMatchField;
            }
            set
            {
                this.UserExactMatchField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Log", Namespace="http://schemas.datacontract.org/2004/07/Adis.Log.Contract")]
    public partial class Log : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int EventIdField;
        
        private string CategoryField;
        
        private string ApplicationField;
        
        private string InstanceField;
        
        private string UserField;
        
        private string MachineField;
        
        private string SeverityField;
        
        private string MessageField;
        
        private System.DateTime TimeField;
        
        private string ExtraInfoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EventId
        {
            get
            {
                return this.EventIdField;
            }
            set
            {
                this.EventIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Application
        {
            get
            {
                return this.ApplicationField;
            }
            set
            {
                this.ApplicationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Instance
        {
            get
            {
                return this.InstanceField;
            }
            set
            {
                this.InstanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Machine
        {
            get
            {
                return this.MachineField;
            }
            set
            {
                this.MachineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string Severity
        {
            get
            {
                return this.SeverityField;
            }
            set
            {
                this.SeverityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public System.DateTime Time
        {
            get
            {
                return this.TimeField;
            }
            set
            {
                this.TimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string ExtraInfo
        {
            get
            {
                return this.ExtraInfoField;
            }
            set
            {
                this.ExtraInfoField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IReporterContract")]
public interface IReporterContract
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReporterContract/GetRecords", ReplyAction="http://tempuri.org/IReporterContract/GetRecordsResponse")]
    Adis.Log.Contract.Log[] GetRecords(Adis.Log.Contract.RequestFilter filter, int skipFirst, int maxRecords);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IReporterContractChannel : IReporterContract, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class ReporterContractClient : System.ServiceModel.ClientBase<IReporterContract>, IReporterContract
{
    
    public ReporterContractClient()
    {
    }
    
    public ReporterContractClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ReporterContractClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ReporterContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ReporterContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Adis.Log.Contract.Log[] GetRecords(Adis.Log.Contract.RequestFilter filter, int skipFirst, int maxRecords)
    {
        return base.Channel.GetRecords(filter, skipFirst, maxRecords);
    }
}
