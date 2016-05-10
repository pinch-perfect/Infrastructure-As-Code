﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace InfrastructureAsCode.Core.com.sharepoint.useralerts {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AlertsSoap", Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public partial class Alerts : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAlertsOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteAlertsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Alerts() {
            this.Url = global::InfrastructureAsCode.Core.Properties.Settings.Default.IaC_Core_com_sharepoint_useralerts_Alerts;
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
        public event GetAlertsCompletedEventHandler GetAlertsCompleted;
        
        /// <remarks/>
        public event DeleteAlertsCompletedEventHandler DeleteAlertsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/GetAlerts", RequestNamespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/", ResponseNamespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AlertInfo GetAlerts() {
            object[] results = this.Invoke("GetAlerts", new object[0]);
            return ((AlertInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetAlertsAsync() {
            this.GetAlertsAsync(null);
        }
        
        /// <remarks/>
        public void GetAlertsAsync(object userState) {
            if ((this.GetAlertsOperationCompleted == null)) {
                this.GetAlertsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAlertsOperationCompleted);
            }
            this.InvokeAsync("GetAlerts", new object[0], this.GetAlertsOperationCompleted, userState);
        }
        
        private void OnGetAlertsOperationCompleted(object arg) {
            if ((this.GetAlertsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAlertsCompleted(this, new GetAlertsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/DeleteAlerts", RequestNamespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/", ResponseNamespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public DeleteFailure[] DeleteAlerts(string[] IDs) {
            object[] results = this.Invoke("DeleteAlerts", new object[] {
                        IDs});
            return ((DeleteFailure[])(results[0]));
        }
        
        /// <remarks/>
        public void DeleteAlertsAsync(string[] IDs) {
            this.DeleteAlertsAsync(IDs, null);
        }
        
        /// <remarks/>
        public void DeleteAlertsAsync(string[] IDs, object userState) {
            if ((this.DeleteAlertsOperationCompleted == null)) {
                this.DeleteAlertsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteAlertsOperationCompleted);
            }
            this.InvokeAsync("DeleteAlerts", new object[] {
                        IDs}, this.DeleteAlertsOperationCompleted, userState);
        }
        
        private void OnDeleteAlertsOperationCompleted(object arg) {
            if ((this.DeleteAlertsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteAlertsCompleted(this, new DeleteAlertsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public partial class AlertInfo {
        
        private string currentUserField;
        
        private string alertServerNameField;
        
        private string alertServerUrlField;
        
        private string alertServerTypeField;
        
        private string alertsManagementUrlField;
        
        private string alertWebTitleField;
        
        private string newAlertUrlField;
        
        private string alertWebIdField;
        
        private Alert[] alertsField;
        
        /// <remarks/>
        public string CurrentUser {
            get {
                return this.currentUserField;
            }
            set {
                this.currentUserField = value;
            }
        }
        
        /// <remarks/>
        public string AlertServerName {
            get {
                return this.alertServerNameField;
            }
            set {
                this.alertServerNameField = value;
            }
        }
        
        /// <remarks/>
        public string AlertServerUrl {
            get {
                return this.alertServerUrlField;
            }
            set {
                this.alertServerUrlField = value;
            }
        }
        
        /// <remarks/>
        public string AlertServerType {
            get {
                return this.alertServerTypeField;
            }
            set {
                this.alertServerTypeField = value;
            }
        }
        
        /// <remarks/>
        public string AlertsManagementUrl {
            get {
                return this.alertsManagementUrlField;
            }
            set {
                this.alertsManagementUrlField = value;
            }
        }
        
        /// <remarks/>
        public string AlertWebTitle {
            get {
                return this.alertWebTitleField;
            }
            set {
                this.alertWebTitleField = value;
            }
        }
        
        /// <remarks/>
        public string NewAlertUrl {
            get {
                return this.newAlertUrlField;
            }
            set {
                this.newAlertUrlField = value;
            }
        }
        
        /// <remarks/>
        public string AlertWebId {
            get {
                return this.alertWebIdField;
            }
            set {
                this.alertWebIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Alert[] Alerts {
            get {
                return this.alertsField;
            }
            set {
                this.alertsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public partial class Alert {
        
        private string idField;
        
        private string titleField;
        
        private bool activeField;
        
        private string eventTypeField;
        
        private string alertForTitleField;
        
        private string alertForUrlField;
        
        private string editAlertUrlField;
        
        private DeliveryChannel[] deliveryChannelsField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public bool Active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
            }
        }
        
        /// <remarks/>
        public string EventType {
            get {
                return this.eventTypeField;
            }
            set {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        public string AlertForTitle {
            get {
                return this.alertForTitleField;
            }
            set {
                this.alertForTitleField = value;
            }
        }
        
        /// <remarks/>
        public string AlertForUrl {
            get {
                return this.alertForUrlField;
            }
            set {
                this.alertForUrlField = value;
            }
        }
        
        /// <remarks/>
        public string EditAlertUrl {
            get {
                return this.editAlertUrlField;
            }
            set {
                this.editAlertUrlField = value;
            }
        }
        
        /// <remarks/>
        public DeliveryChannel[] DeliveryChannels {
            get {
                return this.deliveryChannelsField;
            }
            set {
                this.deliveryChannelsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailChannel))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public abstract partial class DeliveryChannel {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public partial class DeleteFailure {
        
        private string idField;
        
        private ErrorType errorField;
        
        /// <remarks/>
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public ErrorType Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public enum ErrorType {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        AccessDenied,
        
        /// <remarks/>
        ServerError,
        
        /// <remarks/>
        TooManyErrors,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/2002/1/alerts/")]
    public partial class EmailChannel : DeliveryChannel {
        
        private string frequencyField;
        
        private string addressField;
        
        /// <remarks/>
        public string Frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetAlertsCompletedEventHandler(object sender, GetAlertsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAlertsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAlertsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AlertInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AlertInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void DeleteAlertsCompletedEventHandler(object sender, DeleteAlertsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteAlertsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteAlertsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DeleteFailure[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DeleteFailure[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591