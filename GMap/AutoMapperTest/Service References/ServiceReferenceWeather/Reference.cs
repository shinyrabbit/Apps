﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoMapperTest.ServiceReferenceWeather {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="ServiceReferenceWeather.WeatherWSSoap")]
    public interface WeatherWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionDataset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getRegionDataset();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getRegionDataset", ReplyAction="*")]
        System.IAsyncResult BegingetRegionDataset(System.AsyncCallback callback, object asyncState);
        
        System.Data.DataSet EndgetRegionDataset(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionProvince", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getRegionProvince();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getRegionProvince", ReplyAction="*")]
        System.IAsyncResult BegingetRegionProvince(System.AsyncCallback callback, object asyncState);
        
        string[] EndgetRegionProvince(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionCountry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getRegionCountry();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getRegionCountry", ReplyAction="*")]
        System.IAsyncResult BegingetRegionCountry(System.AsyncCallback callback, object asyncState);
        
        string[] EndgetRegionCountry(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityDataset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getSupportCityDataset(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getSupportCityDataset", ReplyAction="*")]
        System.IAsyncResult BegingetSupportCityDataset(string theRegionCode, System.AsyncCallback callback, object asyncState);
        
        System.Data.DataSet EndgetSupportCityDataset(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getSupportCityString(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getSupportCityString", ReplyAction="*")]
        System.IAsyncResult BegingetSupportCityString(string theRegionCode, System.AsyncCallback callback, object asyncState);
        
        string[] EndgetSupportCityString(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getWeather", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getWeather(string theCityCode, string theUserID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://WebXml.com.cn/getWeather", ReplyAction="*")]
        System.IAsyncResult BegingetWeather(string theCityCode, string theUserID, System.AsyncCallback callback, object asyncState);
        
        string[] EndgetWeather(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WeatherWSSoapChannel : AutoMapperTest.ServiceReferenceWeather.WeatherWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getRegionDatasetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getRegionDatasetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Data.DataSet Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getRegionProvinceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getRegionProvinceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getRegionCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getRegionCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getSupportCityDatasetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getSupportCityDatasetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Data.DataSet Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getSupportCityStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getSupportCityStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getWeatherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getWeatherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherWSSoapClient : System.ServiceModel.ClientBase<AutoMapperTest.ServiceReferenceWeather.WeatherWSSoap>, AutoMapperTest.ServiceReferenceWeather.WeatherWSSoap {
        
        private BeginOperationDelegate onBegingetRegionDatasetDelegate;
        
        private EndOperationDelegate onEndgetRegionDatasetDelegate;
        
        private System.Threading.SendOrPostCallback ongetRegionDatasetCompletedDelegate;
        
        private BeginOperationDelegate onBegingetRegionProvinceDelegate;
        
        private EndOperationDelegate onEndgetRegionProvinceDelegate;
        
        private System.Threading.SendOrPostCallback ongetRegionProvinceCompletedDelegate;
        
        private BeginOperationDelegate onBegingetRegionCountryDelegate;
        
        private EndOperationDelegate onEndgetRegionCountryDelegate;
        
        private System.Threading.SendOrPostCallback ongetRegionCountryCompletedDelegate;
        
        private BeginOperationDelegate onBegingetSupportCityDatasetDelegate;
        
        private EndOperationDelegate onEndgetSupportCityDatasetDelegate;
        
        private System.Threading.SendOrPostCallback ongetSupportCityDatasetCompletedDelegate;
        
        private BeginOperationDelegate onBegingetSupportCityStringDelegate;
        
        private EndOperationDelegate onEndgetSupportCityStringDelegate;
        
        private System.Threading.SendOrPostCallback ongetSupportCityStringCompletedDelegate;
        
        private BeginOperationDelegate onBegingetWeatherDelegate;
        
        private EndOperationDelegate onEndgetWeatherDelegate;
        
        private System.Threading.SendOrPostCallback ongetWeatherCompletedDelegate;
        
        public WeatherWSSoapClient() {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<getRegionDatasetCompletedEventArgs> getRegionDatasetCompleted;
        
        public event System.EventHandler<getRegionProvinceCompletedEventArgs> getRegionProvinceCompleted;
        
        public event System.EventHandler<getRegionCountryCompletedEventArgs> getRegionCountryCompleted;
        
        public event System.EventHandler<getSupportCityDatasetCompletedEventArgs> getSupportCityDatasetCompleted;
        
        public event System.EventHandler<getSupportCityStringCompletedEventArgs> getSupportCityStringCompleted;
        
        public event System.EventHandler<getWeatherCompletedEventArgs> getWeatherCompleted;
        
        public System.Data.DataSet getRegionDataset() {
            return base.Channel.getRegionDataset();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetRegionDataset(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetRegionDataset(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataSet EndgetRegionDataset(System.IAsyncResult result) {
            return base.Channel.EndgetRegionDataset(result);
        }
        
        private System.IAsyncResult OnBegingetRegionDataset(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BegingetRegionDataset(callback, asyncState);
        }
        
        private object[] OnEndgetRegionDataset(System.IAsyncResult result) {
            System.Data.DataSet retVal = this.EndgetRegionDataset(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetRegionDatasetCompleted(object state) {
            if ((this.getRegionDatasetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getRegionDatasetCompleted(this, new getRegionDatasetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getRegionDatasetAsync() {
            this.getRegionDatasetAsync(null);
        }
        
        public void getRegionDatasetAsync(object userState) {
            if ((this.onBegingetRegionDatasetDelegate == null)) {
                this.onBegingetRegionDatasetDelegate = new BeginOperationDelegate(this.OnBegingetRegionDataset);
            }
            if ((this.onEndgetRegionDatasetDelegate == null)) {
                this.onEndgetRegionDatasetDelegate = new EndOperationDelegate(this.OnEndgetRegionDataset);
            }
            if ((this.ongetRegionDatasetCompletedDelegate == null)) {
                this.ongetRegionDatasetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetRegionDatasetCompleted);
            }
            base.InvokeAsync(this.onBegingetRegionDatasetDelegate, null, this.onEndgetRegionDatasetDelegate, this.ongetRegionDatasetCompletedDelegate, userState);
        }
        
        public string[] getRegionProvince() {
            return base.Channel.getRegionProvince();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetRegionProvince(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetRegionProvince(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndgetRegionProvince(System.IAsyncResult result) {
            return base.Channel.EndgetRegionProvince(result);
        }
        
        private System.IAsyncResult OnBegingetRegionProvince(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BegingetRegionProvince(callback, asyncState);
        }
        
        private object[] OnEndgetRegionProvince(System.IAsyncResult result) {
            string[] retVal = this.EndgetRegionProvince(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetRegionProvinceCompleted(object state) {
            if ((this.getRegionProvinceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getRegionProvinceCompleted(this, new getRegionProvinceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getRegionProvinceAsync() {
            this.getRegionProvinceAsync(null);
        }
        
        public void getRegionProvinceAsync(object userState) {
            if ((this.onBegingetRegionProvinceDelegate == null)) {
                this.onBegingetRegionProvinceDelegate = new BeginOperationDelegate(this.OnBegingetRegionProvince);
            }
            if ((this.onEndgetRegionProvinceDelegate == null)) {
                this.onEndgetRegionProvinceDelegate = new EndOperationDelegate(this.OnEndgetRegionProvince);
            }
            if ((this.ongetRegionProvinceCompletedDelegate == null)) {
                this.ongetRegionProvinceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetRegionProvinceCompleted);
            }
            base.InvokeAsync(this.onBegingetRegionProvinceDelegate, null, this.onEndgetRegionProvinceDelegate, this.ongetRegionProvinceCompletedDelegate, userState);
        }
        
        public string[] getRegionCountry() {
            return base.Channel.getRegionCountry();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetRegionCountry(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetRegionCountry(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndgetRegionCountry(System.IAsyncResult result) {
            return base.Channel.EndgetRegionCountry(result);
        }
        
        private System.IAsyncResult OnBegingetRegionCountry(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BegingetRegionCountry(callback, asyncState);
        }
        
        private object[] OnEndgetRegionCountry(System.IAsyncResult result) {
            string[] retVal = this.EndgetRegionCountry(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetRegionCountryCompleted(object state) {
            if ((this.getRegionCountryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getRegionCountryCompleted(this, new getRegionCountryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getRegionCountryAsync() {
            this.getRegionCountryAsync(null);
        }
        
        public void getRegionCountryAsync(object userState) {
            if ((this.onBegingetRegionCountryDelegate == null)) {
                this.onBegingetRegionCountryDelegate = new BeginOperationDelegate(this.OnBegingetRegionCountry);
            }
            if ((this.onEndgetRegionCountryDelegate == null)) {
                this.onEndgetRegionCountryDelegate = new EndOperationDelegate(this.OnEndgetRegionCountry);
            }
            if ((this.ongetRegionCountryCompletedDelegate == null)) {
                this.ongetRegionCountryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetRegionCountryCompleted);
            }
            base.InvokeAsync(this.onBegingetRegionCountryDelegate, null, this.onEndgetRegionCountryDelegate, this.ongetRegionCountryCompletedDelegate, userState);
        }
        
        public System.Data.DataSet getSupportCityDataset(string theRegionCode) {
            return base.Channel.getSupportCityDataset(theRegionCode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetSupportCityDataset(string theRegionCode, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetSupportCityDataset(theRegionCode, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataSet EndgetSupportCityDataset(System.IAsyncResult result) {
            return base.Channel.EndgetSupportCityDataset(result);
        }
        
        private System.IAsyncResult OnBegingetSupportCityDataset(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string theRegionCode = ((string)(inValues[0]));
            return this.BegingetSupportCityDataset(theRegionCode, callback, asyncState);
        }
        
        private object[] OnEndgetSupportCityDataset(System.IAsyncResult result) {
            System.Data.DataSet retVal = this.EndgetSupportCityDataset(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetSupportCityDatasetCompleted(object state) {
            if ((this.getSupportCityDatasetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getSupportCityDatasetCompleted(this, new getSupportCityDatasetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getSupportCityDatasetAsync(string theRegionCode) {
            this.getSupportCityDatasetAsync(theRegionCode, null);
        }
        
        public void getSupportCityDatasetAsync(string theRegionCode, object userState) {
            if ((this.onBegingetSupportCityDatasetDelegate == null)) {
                this.onBegingetSupportCityDatasetDelegate = new BeginOperationDelegate(this.OnBegingetSupportCityDataset);
            }
            if ((this.onEndgetSupportCityDatasetDelegate == null)) {
                this.onEndgetSupportCityDatasetDelegate = new EndOperationDelegate(this.OnEndgetSupportCityDataset);
            }
            if ((this.ongetSupportCityDatasetCompletedDelegate == null)) {
                this.ongetSupportCityDatasetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetSupportCityDatasetCompleted);
            }
            base.InvokeAsync(this.onBegingetSupportCityDatasetDelegate, new object[] {
                        theRegionCode}, this.onEndgetSupportCityDatasetDelegate, this.ongetSupportCityDatasetCompletedDelegate, userState);
        }
        
        public string[] getSupportCityString(string theRegionCode) {
            return base.Channel.getSupportCityString(theRegionCode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetSupportCityString(string theRegionCode, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetSupportCityString(theRegionCode, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndgetSupportCityString(System.IAsyncResult result) {
            return base.Channel.EndgetSupportCityString(result);
        }
        
        private System.IAsyncResult OnBegingetSupportCityString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string theRegionCode = ((string)(inValues[0]));
            return this.BegingetSupportCityString(theRegionCode, callback, asyncState);
        }
        
        private object[] OnEndgetSupportCityString(System.IAsyncResult result) {
            string[] retVal = this.EndgetSupportCityString(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetSupportCityStringCompleted(object state) {
            if ((this.getSupportCityStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getSupportCityStringCompleted(this, new getSupportCityStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getSupportCityStringAsync(string theRegionCode) {
            this.getSupportCityStringAsync(theRegionCode, null);
        }
        
        public void getSupportCityStringAsync(string theRegionCode, object userState) {
            if ((this.onBegingetSupportCityStringDelegate == null)) {
                this.onBegingetSupportCityStringDelegate = new BeginOperationDelegate(this.OnBegingetSupportCityString);
            }
            if ((this.onEndgetSupportCityStringDelegate == null)) {
                this.onEndgetSupportCityStringDelegate = new EndOperationDelegate(this.OnEndgetSupportCityString);
            }
            if ((this.ongetSupportCityStringCompletedDelegate == null)) {
                this.ongetSupportCityStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetSupportCityStringCompleted);
            }
            base.InvokeAsync(this.onBegingetSupportCityStringDelegate, new object[] {
                        theRegionCode}, this.onEndgetSupportCityStringDelegate, this.ongetSupportCityStringCompletedDelegate, userState);
        }
        
        public string[] getWeather(string theCityCode, string theUserID) {
            return base.Channel.getWeather(theCityCode, theUserID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetWeather(string theCityCode, string theUserID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetWeather(theCityCode, theUserID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndgetWeather(System.IAsyncResult result) {
            return base.Channel.EndgetWeather(result);
        }
        
        private System.IAsyncResult OnBegingetWeather(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string theCityCode = ((string)(inValues[0]));
            string theUserID = ((string)(inValues[1]));
            return this.BegingetWeather(theCityCode, theUserID, callback, asyncState);
        }
        
        private object[] OnEndgetWeather(System.IAsyncResult result) {
            string[] retVal = this.EndgetWeather(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetWeatherCompleted(object state) {
            if ((this.getWeatherCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getWeatherCompleted(this, new getWeatherCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getWeatherAsync(string theCityCode, string theUserID) {
            this.getWeatherAsync(theCityCode, theUserID, null);
        }
        
        public void getWeatherAsync(string theCityCode, string theUserID, object userState) {
            if ((this.onBegingetWeatherDelegate == null)) {
                this.onBegingetWeatherDelegate = new BeginOperationDelegate(this.OnBegingetWeather);
            }
            if ((this.onEndgetWeatherDelegate == null)) {
                this.onEndgetWeatherDelegate = new EndOperationDelegate(this.OnEndgetWeather);
            }
            if ((this.ongetWeatherCompletedDelegate == null)) {
                this.ongetWeatherCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetWeatherCompleted);
            }
            base.InvokeAsync(this.onBegingetWeatherDelegate, new object[] {
                        theCityCode,
                        theUserID}, this.onEndgetWeatherDelegate, this.ongetWeatherCompletedDelegate, userState);
        }
    }
}