﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationGail.GailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cdssgailmodel.com/webservice", ConfigurationName="GailService.GailModelSoap")]
    public interface GailModelSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalcPorb", ReplyAction="*")]
        double CalcPorb(double RR, int agecat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalcPorb", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalcPorbAsync(double RR, int agecat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalculateProbability", ReplyAction="*")]
        double CalculateProbability(double a, double tau, double r1, double r2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalculateProbability", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateProbabilityAsync(double a, double tau, double r1, double r2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalculateRelativeRisk", ReplyAction="*")]
        double CalculateRelativeRisk(int agecat, int agemen, int ageflb, int nbiops, int numrel, int ah);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/CalculateRelativeRisk", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateRelativeRiskAsync(int agecat, int agemen, int ageflb, int nbiops, int numrel, int ah);
        
        // CODEGEN: Generating message contract since element name agecat from namespace http://cdssgailmodel.com/webservice is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/ReadForm", ReplyAction="*")]
        WebApplicationGail.GailService.ReadFormResponse ReadForm(WebApplicationGail.GailService.ReadFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdssgailmodel.com/webservice/ReadForm", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationGail.GailService.ReadFormResponse> ReadFormAsync(WebApplicationGail.GailService.ReadFormRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadFormRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadForm", Namespace="http://cdssgailmodel.com/webservice", Order=0)]
        public WebApplicationGail.GailService.ReadFormRequestBody Body;
        
        public ReadFormRequest() {
        }
        
        public ReadFormRequest(WebApplicationGail.GailService.ReadFormRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cdssgailmodel.com/webservice")]
    public partial class ReadFormRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agecat;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agemen;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ageflb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string nbiops;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string numrel;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ah;
        
        public ReadFormRequestBody() {
        }
        
        public ReadFormRequestBody(string agecat, string agemen, string ageflb, string nbiops, string numrel, string ah) {
            this.agecat = agecat;
            this.agemen = agemen;
            this.ageflb = ageflb;
            this.nbiops = nbiops;
            this.numrel = numrel;
            this.ah = ah;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadFormResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadFormResponse", Namespace="http://cdssgailmodel.com/webservice", Order=0)]
        public WebApplicationGail.GailService.ReadFormResponseBody Body;
        
        public ReadFormResponse() {
        }
        
        public ReadFormResponse(WebApplicationGail.GailService.ReadFormResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cdssgailmodel.com/webservice")]
    public partial class ReadFormResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ReadFormResult;
        
        public ReadFormResponseBody() {
        }
        
        public ReadFormResponseBody(double ReadFormResult) {
            this.ReadFormResult = ReadFormResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GailModelSoapChannel : WebApplicationGail.GailService.GailModelSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GailModelSoapClient : System.ServiceModel.ClientBase<WebApplicationGail.GailService.GailModelSoap>, WebApplicationGail.GailService.GailModelSoap {
        
        public GailModelSoapClient() {
        }
        
        public GailModelSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GailModelSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GailModelSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GailModelSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalcPorb(double RR, int agecat) {
            return base.Channel.CalcPorb(RR, agecat);
        }
        
        public System.Threading.Tasks.Task<double> CalcPorbAsync(double RR, int agecat) {
            return base.Channel.CalcPorbAsync(RR, agecat);
        }
        
        public double CalculateProbability(double a, double tau, double r1, double r2) {
            return base.Channel.CalculateProbability(a, tau, r1, r2);
        }
        
        public System.Threading.Tasks.Task<double> CalculateProbabilityAsync(double a, double tau, double r1, double r2) {
            return base.Channel.CalculateProbabilityAsync(a, tau, r1, r2);
        }
        
        public double CalculateRelativeRisk(int agecat, int agemen, int ageflb, int nbiops, int numrel, int ah) {
            return base.Channel.CalculateRelativeRisk(agecat, agemen, ageflb, nbiops, numrel, ah);
        }
        
        public System.Threading.Tasks.Task<double> CalculateRelativeRiskAsync(int agecat, int agemen, int ageflb, int nbiops, int numrel, int ah) {
            return base.Channel.CalculateRelativeRiskAsync(agecat, agemen, ageflb, nbiops, numrel, ah);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationGail.GailService.ReadFormResponse WebApplicationGail.GailService.GailModelSoap.ReadForm(WebApplicationGail.GailService.ReadFormRequest request) {
            return base.Channel.ReadForm(request);
        }
        
        public double ReadForm(string agecat, string agemen, string ageflb, string nbiops, string numrel, string ah) {
            WebApplicationGail.GailService.ReadFormRequest inValue = new WebApplicationGail.GailService.ReadFormRequest();
            inValue.Body = new WebApplicationGail.GailService.ReadFormRequestBody();
            inValue.Body.agecat = agecat;
            inValue.Body.agemen = agemen;
            inValue.Body.ageflb = ageflb;
            inValue.Body.nbiops = nbiops;
            inValue.Body.numrel = numrel;
            inValue.Body.ah = ah;
            WebApplicationGail.GailService.ReadFormResponse retVal = ((WebApplicationGail.GailService.GailModelSoap)(this)).ReadForm(inValue);
            return retVal.Body.ReadFormResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationGail.GailService.ReadFormResponse> WebApplicationGail.GailService.GailModelSoap.ReadFormAsync(WebApplicationGail.GailService.ReadFormRequest request) {
            return base.Channel.ReadFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationGail.GailService.ReadFormResponse> ReadFormAsync(string agecat, string agemen, string ageflb, string nbiops, string numrel, string ah) {
            WebApplicationGail.GailService.ReadFormRequest inValue = new WebApplicationGail.GailService.ReadFormRequest();
            inValue.Body = new WebApplicationGail.GailService.ReadFormRequestBody();
            inValue.Body.agecat = agecat;
            inValue.Body.agemen = agemen;
            inValue.Body.ageflb = ageflb;
            inValue.Body.nbiops = nbiops;
            inValue.Body.numrel = numrel;
            inValue.Body.ah = ah;
            return ((WebApplicationGail.GailService.GailModelSoap)(this)).ReadFormAsync(inValue);
        }
    }
}