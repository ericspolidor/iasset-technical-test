﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IAsset.Service_References.ServiceReferenceGlobalWeather {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET", ConfigurationName="ServiceReferenceGlobalWeather.GlobalWeatherSoap")]
    public interface GlobalWeatherSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetWeather", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GetWeatherResponse GetWeather(GetWeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetWeather", ReplyAction="*")]
        System.Threading.Tasks.Task<GetWeatherResponse> GetWeatherAsync(GetWeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetCitiesByCountry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GetCitiesByCountryResponse GetCitiesByCountry(GetCitiesByCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetCitiesByCountry", ReplyAction="*")]
        System.Threading.Tasks.Task<GetCitiesByCountryResponse> GetCitiesByCountryAsync(GetCitiesByCountryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWeather", WrapperNamespace="http://www.webserviceX.NET", IsWrapped=true)]
    public partial class GetWeatherRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.webserviceX.NET", Order=0)]
        public string CityName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.webserviceX.NET", Order=1)]
        public string CountryName;
        
        public GetWeatherRequest() {
        }
        
        public GetWeatherRequest(string CityName, string CountryName) {
            this.CityName = CityName;
            this.CountryName = CountryName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWeatherResponse", WrapperNamespace="http://www.webserviceX.NET", IsWrapped=true)]
    public partial class GetWeatherResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.webserviceX.NET", Order=0)]
        public string GetWeatherResult;
        
        public GetWeatherResponse() {
        }
        
        public GetWeatherResponse(string GetWeatherResult) {
            this.GetWeatherResult = GetWeatherResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCitiesByCountry", WrapperNamespace="http://www.webserviceX.NET", IsWrapped=true)]
    public partial class GetCitiesByCountryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.webserviceX.NET", Order=0)]
        public string CountryName;
        
        public GetCitiesByCountryRequest() {
        }
        
        public GetCitiesByCountryRequest(string CountryName) {
            this.CountryName = CountryName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCitiesByCountryResponse", WrapperNamespace="http://www.webserviceX.NET", IsWrapped=true)]
    public partial class GetCitiesByCountryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.webserviceX.NET", Order=0)]
        public string GetCitiesByCountryResult;
        
        public GetCitiesByCountryResponse() {
        }
        
        public GetCitiesByCountryResponse(string GetCitiesByCountryResult) {
            this.GetCitiesByCountryResult = GetCitiesByCountryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GlobalWeatherSoapChannel : GlobalWeatherSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GlobalWeatherSoapClient : System.ServiceModel.ClientBase<GlobalWeatherSoap>, GlobalWeatherSoap {
        
        public GlobalWeatherSoapClient() {
        }
        
        public GlobalWeatherSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GlobalWeatherSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GlobalWeatherSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GlobalWeatherSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GetWeatherResponse GetWeather(GetWeatherRequest request) {
            return base.Channel.GetWeather(request);
        }
        
        public System.Threading.Tasks.Task<GetWeatherResponse> GetWeatherAsync(GetWeatherRequest request) {
            return base.Channel.GetWeatherAsync(request);
        }
        
        public GetCitiesByCountryResponse GetCitiesByCountry(GetCitiesByCountryRequest request) {
            return base.Channel.GetCitiesByCountry(request);
        }
        
        public System.Threading.Tasks.Task<GetCitiesByCountryResponse> GetCitiesByCountryAsync(GetCitiesByCountryRequest request) {
            return base.Channel.GetCitiesByCountryAsync(request);
        }
    }
}
