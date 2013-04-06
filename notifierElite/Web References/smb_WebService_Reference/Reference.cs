﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18034.
// 
#pragma warning disable 1591

namespace notifierElite.smb_WebService_Reference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SMBServiceSoap", Namespace="http://tempuri.org/")]
    public partial class SMBService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertSystemInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertSMBStatusLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyMacIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSystemInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckAgentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetClientOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SMBService() {
            this.Url = global::notifierElite.Properties.Settings.Default.notifierElite_smb_WebService_Reference_SMBService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertSystemInfoCompletedEventHandler InsertSystemInfoCompleted;
        
        /// <remarks/>
        public event InsertSMBStatusLogCompletedEventHandler InsertSMBStatusLogCompleted;
        
        /// <remarks/>
        public event VerifyMacIDCompletedEventHandler VerifyMacIDCompleted;
        
        /// <remarks/>
        public event GetSystemInfoCompletedEventHandler GetSystemInfoCompleted;
        
        /// <remarks/>
        public event CheckAgentCompletedEventHandler CheckAgentCompleted;
        
        /// <remarks/>
        public event GetClientCompletedEventHandler GetClientCompleted;
        
        /// <remarks/>
        public event CreateUserCompletedEventHandler CreateUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertSystemInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertSystemInfo(
                    string pUserName, 
                    string pUserAccessRights, 
                    string pMacID, 
                    string pIPAddress, 
                    string pProcessorAndClockSpeed, 
                    string pRAM, 
                    string pDefaultBrowser, 
                    string pSystemBootupTime, 
                    string pDefaultPrinter, 
                    string pOSArchitecture, 
                    string pVideoCard, 
                    string pSoundCard, 
                    string pDXVersion, 
                    string pSystemPartition, 
                    string pNumberOfPartitions, 
                    string pSystemManufacturer, 
                    string pAgentID, 
                    string pPCName, 
                    string OS, 
                    string pAppVersion) {
            object[] results = this.Invoke("InsertSystemInfo", new object[] {
                        pUserName,
                        pUserAccessRights,
                        pMacID,
                        pIPAddress,
                        pProcessorAndClockSpeed,
                        pRAM,
                        pDefaultBrowser,
                        pSystemBootupTime,
                        pDefaultPrinter,
                        pOSArchitecture,
                        pVideoCard,
                        pSoundCard,
                        pDXVersion,
                        pSystemPartition,
                        pNumberOfPartitions,
                        pSystemManufacturer,
                        pAgentID,
                        pPCName,
                        OS,
                        pAppVersion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertSystemInfoAsync(
                    string pUserName, 
                    string pUserAccessRights, 
                    string pMacID, 
                    string pIPAddress, 
                    string pProcessorAndClockSpeed, 
                    string pRAM, 
                    string pDefaultBrowser, 
                    string pSystemBootupTime, 
                    string pDefaultPrinter, 
                    string pOSArchitecture, 
                    string pVideoCard, 
                    string pSoundCard, 
                    string pDXVersion, 
                    string pSystemPartition, 
                    string pNumberOfPartitions, 
                    string pSystemManufacturer, 
                    string pAgentID, 
                    string pPCName, 
                    string OS, 
                    string pAppVersion) {
            this.InsertSystemInfoAsync(pUserName, pUserAccessRights, pMacID, pIPAddress, pProcessorAndClockSpeed, pRAM, pDefaultBrowser, pSystemBootupTime, pDefaultPrinter, pOSArchitecture, pVideoCard, pSoundCard, pDXVersion, pSystemPartition, pNumberOfPartitions, pSystemManufacturer, pAgentID, pPCName, OS, pAppVersion, null);
        }
        
        /// <remarks/>
        public void InsertSystemInfoAsync(
                    string pUserName, 
                    string pUserAccessRights, 
                    string pMacID, 
                    string pIPAddress, 
                    string pProcessorAndClockSpeed, 
                    string pRAM, 
                    string pDefaultBrowser, 
                    string pSystemBootupTime, 
                    string pDefaultPrinter, 
                    string pOSArchitecture, 
                    string pVideoCard, 
                    string pSoundCard, 
                    string pDXVersion, 
                    string pSystemPartition, 
                    string pNumberOfPartitions, 
                    string pSystemManufacturer, 
                    string pAgentID, 
                    string pPCName, 
                    string OS, 
                    string pAppVersion, 
                    object userState) {
            if ((this.InsertSystemInfoOperationCompleted == null)) {
                this.InsertSystemInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertSystemInfoOperationCompleted);
            }
            this.InvokeAsync("InsertSystemInfo", new object[] {
                        pUserName,
                        pUserAccessRights,
                        pMacID,
                        pIPAddress,
                        pProcessorAndClockSpeed,
                        pRAM,
                        pDefaultBrowser,
                        pSystemBootupTime,
                        pDefaultPrinter,
                        pOSArchitecture,
                        pVideoCard,
                        pSoundCard,
                        pDXVersion,
                        pSystemPartition,
                        pNumberOfPartitions,
                        pSystemManufacturer,
                        pAgentID,
                        pPCName,
                        OS,
                        pAppVersion}, this.InsertSystemInfoOperationCompleted, userState);
        }
        
        private void OnInsertSystemInfoOperationCompleted(object arg) {
            if ((this.InsertSystemInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertSystemInfoCompleted(this, new InsertSystemInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertSMBStatusLog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertSMBStatusLog(string pIssueDate, string pIssueTime, string pPCName, string pUserName, string pMacID, string pIPAddress, string pEventName, string pFunctionRunStatus, string pIssueStatus) {
            object[] results = this.Invoke("InsertSMBStatusLog", new object[] {
                        pIssueDate,
                        pIssueTime,
                        pPCName,
                        pUserName,
                        pMacID,
                        pIPAddress,
                        pEventName,
                        pFunctionRunStatus,
                        pIssueStatus});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertSMBStatusLogAsync(string pIssueDate, string pIssueTime, string pPCName, string pUserName, string pMacID, string pIPAddress, string pEventName, string pFunctionRunStatus, string pIssueStatus) {
            this.InsertSMBStatusLogAsync(pIssueDate, pIssueTime, pPCName, pUserName, pMacID, pIPAddress, pEventName, pFunctionRunStatus, pIssueStatus, null);
        }
        
        /// <remarks/>
        public void InsertSMBStatusLogAsync(string pIssueDate, string pIssueTime, string pPCName, string pUserName, string pMacID, string pIPAddress, string pEventName, string pFunctionRunStatus, string pIssueStatus, object userState) {
            if ((this.InsertSMBStatusLogOperationCompleted == null)) {
                this.InsertSMBStatusLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertSMBStatusLogOperationCompleted);
            }
            this.InvokeAsync("InsertSMBStatusLog", new object[] {
                        pIssueDate,
                        pIssueTime,
                        pPCName,
                        pUserName,
                        pMacID,
                        pIPAddress,
                        pEventName,
                        pFunctionRunStatus,
                        pIssueStatus}, this.InsertSMBStatusLogOperationCompleted, userState);
        }
        
        private void OnInsertSMBStatusLogOperationCompleted(object arg) {
            if ((this.InsertSMBStatusLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertSMBStatusLogCompleted(this, new InsertSMBStatusLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VerifyMacID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string VerifyMacID(string strMacID) {
            object[] results = this.Invoke("VerifyMacID", new object[] {
                        strMacID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyMacIDAsync(string strMacID) {
            this.VerifyMacIDAsync(strMacID, null);
        }
        
        /// <remarks/>
        public void VerifyMacIDAsync(string strMacID, object userState) {
            if ((this.VerifyMacIDOperationCompleted == null)) {
                this.VerifyMacIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyMacIDOperationCompleted);
            }
            this.InvokeAsync("VerifyMacID", new object[] {
                        strMacID}, this.VerifyMacIDOperationCompleted, userState);
        }
        
        private void OnVerifyMacIDOperationCompleted(object arg) {
            if ((this.VerifyMacIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyMacIDCompleted(this, new VerifyMacIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSystemInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSystemInfo(string strMacID, string mode) {
            object[] results = this.Invoke("GetSystemInfo", new object[] {
                        strMacID,
                        mode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSystemInfoAsync(string strMacID, string mode) {
            this.GetSystemInfoAsync(strMacID, mode, null);
        }
        
        /// <remarks/>
        public void GetSystemInfoAsync(string strMacID, string mode, object userState) {
            if ((this.GetSystemInfoOperationCompleted == null)) {
                this.GetSystemInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemInfoOperationCompleted);
            }
            this.InvokeAsync("GetSystemInfo", new object[] {
                        strMacID,
                        mode}, this.GetSystemInfoOperationCompleted, userState);
        }
        
        private void OnGetSystemInfoOperationCompleted(object arg) {
            if ((this.GetSystemInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemInfoCompleted(this, new GetSystemInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckAgent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckAgent(string agentID, string agentPassword) {
            object[] results = this.Invoke("CheckAgent", new object[] {
                        agentID,
                        agentPassword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CheckAgentAsync(string agentID, string agentPassword) {
            this.CheckAgentAsync(agentID, agentPassword, null);
        }
        
        /// <remarks/>
        public void CheckAgentAsync(string agentID, string agentPassword, object userState) {
            if ((this.CheckAgentOperationCompleted == null)) {
                this.CheckAgentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckAgentOperationCompleted);
            }
            this.InvokeAsync("CheckAgent", new object[] {
                        agentID,
                        agentPassword}, this.CheckAgentOperationCompleted, userState);
        }
        
        private void OnCheckAgentOperationCompleted(object arg) {
            if ((this.CheckAgentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckAgentCompleted(this, new CheckAgentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetClient", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetClient(string clientName) {
            object[] results = this.Invoke("GetClient", new object[] {
                        clientName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetClientAsync(string clientName) {
            this.GetClientAsync(clientName, null);
        }
        
        /// <remarks/>
        public void GetClientAsync(string clientName, object userState) {
            if ((this.GetClientOperationCompleted == null)) {
                this.GetClientOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetClientOperationCompleted);
            }
            this.InvokeAsync("GetClient", new object[] {
                        clientName}, this.GetClientOperationCompleted, userState);
        }
        
        private void OnGetClientOperationCompleted(object arg) {
            if ((this.GetClientCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetClientCompleted(this, new GetClientCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateUser(string smbID, string businessName, string eMail, string clientId) {
            object[] results = this.Invoke("CreateUser", new object[] {
                        smbID,
                        businessName,
                        eMail,
                        clientId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateUserAsync(string smbID, string businessName, string eMail, string clientId) {
            this.CreateUserAsync(smbID, businessName, eMail, clientId, null);
        }
        
        /// <remarks/>
        public void CreateUserAsync(string smbID, string businessName, string eMail, string clientId, object userState) {
            if ((this.CreateUserOperationCompleted == null)) {
                this.CreateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateUserOperationCompleted);
            }
            this.InvokeAsync("CreateUser", new object[] {
                        smbID,
                        businessName,
                        eMail,
                        clientId}, this.CreateUserOperationCompleted, userState);
        }
        
        private void OnCreateUserOperationCompleted(object arg) {
            if ((this.CreateUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateUserCompleted(this, new CreateUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void InsertSystemInfoCompletedEventHandler(object sender, InsertSystemInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertSystemInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertSystemInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void InsertSMBStatusLogCompletedEventHandler(object sender, InsertSMBStatusLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertSMBStatusLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertSMBStatusLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void VerifyMacIDCompletedEventHandler(object sender, VerifyMacIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyMacIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyMacIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetSystemInfoCompletedEventHandler(object sender, GetSystemInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSystemInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void CheckAgentCompletedEventHandler(object sender, CheckAgentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckAgentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckAgentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetClientCompletedEventHandler(object sender, GetClientCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetClientCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetClientCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void CreateUserCompletedEventHandler(object sender, CreateUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591