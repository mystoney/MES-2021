﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES.module.BLL.PService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PService.PServiceSoap")]
    public interface PServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 rail1 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWORKPLACE", ReplyAction="*")]
        MES.module.BLL.PService.GetWORKPLACEResponse GetWORKPLACE(MES.module.BLL.PService.GetWORKPLACERequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWORKPLACE", ReplyAction="*")]
        System.Threading.Tasks.Task<MES.module.BLL.PService.GetWORKPLACEResponse> GetWORKPLACEAsync(MES.module.BLL.PService.GetWORKPLACERequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 order_no 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ToMes", ReplyAction="*")]
        MES.module.BLL.PService.ToMesResponse ToMes(MES.module.BLL.PService.ToMesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ToMes", ReplyAction="*")]
        System.Threading.Tasks.Task<MES.module.BLL.PService.ToMesResponse> ToMesAsync(MES.module.BLL.PService.ToMesRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 order_no 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ToGX", ReplyAction="*")]
        MES.module.BLL.PService.ToGXResponse ToGX(MES.module.BLL.PService.ToGXRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ToGX", ReplyAction="*")]
        System.Threading.Tasks.Task<MES.module.BLL.PService.ToGXResponse> ToGXAsync(MES.module.BLL.PService.ToGXRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWORKPLACERequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWORKPLACE", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.GetWORKPLACERequestBody Body;
        
        public GetWORKPLACERequest() {
        }
        
        public GetWORKPLACERequest(MES.module.BLL.PService.GetWORKPLACERequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWORKPLACERequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rail1;
        
        public GetWORKPLACERequestBody() {
        }
        
        public GetWORKPLACERequestBody(string rail1) {
            this.rail1 = rail1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWORKPLACEResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWORKPLACEResponse", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.GetWORKPLACEResponseBody Body;
        
        public GetWORKPLACEResponse() {
        }
        
        public GetWORKPLACEResponse(MES.module.BLL.PService.GetWORKPLACEResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWORKPLACEResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetWORKPLACEResult;
        
        public GetWORKPLACEResponseBody() {
        }
        
        public GetWORKPLACEResponseBody(string GetWORKPLACEResult) {
            this.GetWORKPLACEResult = GetWORKPLACEResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToMesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToMes", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.ToMesRequestBody Body;
        
        public ToMesRequest() {
        }
        
        public ToMesRequest(MES.module.BLL.PService.ToMesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ToMesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string order_no;
        
        public ToMesRequestBody() {
        }
        
        public ToMesRequestBody(string order_no) {
            this.order_no = order_no;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToMesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToMesResponse", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.ToMesResponseBody Body;
        
        public ToMesResponse() {
        }
        
        public ToMesResponse(MES.module.BLL.PService.ToMesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ToMesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ToMesResult;
        
        public ToMesResponseBody() {
        }
        
        public ToMesResponseBody(string ToMesResult) {
            this.ToMesResult = ToMesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToGXRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToGX", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.ToGXRequestBody Body;
        
        public ToGXRequest() {
        }
        
        public ToGXRequest(MES.module.BLL.PService.ToGXRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ToGXRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string order_no;
        
        public ToGXRequestBody() {
        }
        
        public ToGXRequestBody(string order_no) {
            this.order_no = order_no;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToGXResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToGXResponse", Namespace="http://tempuri.org/", Order=0)]
        public MES.module.BLL.PService.ToGXResponseBody Body;
        
        public ToGXResponse() {
        }
        
        public ToGXResponse(MES.module.BLL.PService.ToGXResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ToGXResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ToGXResult;
        
        public ToGXResponseBody() {
        }
        
        public ToGXResponseBody(bool ToGXResult) {
            this.ToGXResult = ToGXResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PServiceSoapChannel : MES.module.BLL.PService.PServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PServiceSoapClient : System.ServiceModel.ClientBase<MES.module.BLL.PService.PServiceSoap>, MES.module.BLL.PService.PServiceSoap {
        
        public PServiceSoapClient() {
        }
        
        public PServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MES.module.BLL.PService.GetWORKPLACEResponse MES.module.BLL.PService.PServiceSoap.GetWORKPLACE(MES.module.BLL.PService.GetWORKPLACERequest request) {
            return base.Channel.GetWORKPLACE(request);
        }
        
        public string GetWORKPLACE(string rail1) {
            MES.module.BLL.PService.GetWORKPLACERequest inValue = new MES.module.BLL.PService.GetWORKPLACERequest();
            inValue.Body = new MES.module.BLL.PService.GetWORKPLACERequestBody();
            inValue.Body.rail1 = rail1;
            MES.module.BLL.PService.GetWORKPLACEResponse retVal = ((MES.module.BLL.PService.PServiceSoap)(this)).GetWORKPLACE(inValue);
            return retVal.Body.GetWORKPLACEResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MES.module.BLL.PService.GetWORKPLACEResponse> MES.module.BLL.PService.PServiceSoap.GetWORKPLACEAsync(MES.module.BLL.PService.GetWORKPLACERequest request) {
            return base.Channel.GetWORKPLACEAsync(request);
        }
        
        public System.Threading.Tasks.Task<MES.module.BLL.PService.GetWORKPLACEResponse> GetWORKPLACEAsync(string rail1) {
            MES.module.BLL.PService.GetWORKPLACERequest inValue = new MES.module.BLL.PService.GetWORKPLACERequest();
            inValue.Body = new MES.module.BLL.PService.GetWORKPLACERequestBody();
            inValue.Body.rail1 = rail1;
            return ((MES.module.BLL.PService.PServiceSoap)(this)).GetWORKPLACEAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MES.module.BLL.PService.ToMesResponse MES.module.BLL.PService.PServiceSoap.ToMes(MES.module.BLL.PService.ToMesRequest request) {
            return base.Channel.ToMes(request);
        }
        
        public string ToMes(string order_no) {
            MES.module.BLL.PService.ToMesRequest inValue = new MES.module.BLL.PService.ToMesRequest();
            inValue.Body = new MES.module.BLL.PService.ToMesRequestBody();
            inValue.Body.order_no = order_no;
            MES.module.BLL.PService.ToMesResponse retVal = ((MES.module.BLL.PService.PServiceSoap)(this)).ToMes(inValue);
            return retVal.Body.ToMesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MES.module.BLL.PService.ToMesResponse> MES.module.BLL.PService.PServiceSoap.ToMesAsync(MES.module.BLL.PService.ToMesRequest request) {
            return base.Channel.ToMesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MES.module.BLL.PService.ToMesResponse> ToMesAsync(string order_no) {
            MES.module.BLL.PService.ToMesRequest inValue = new MES.module.BLL.PService.ToMesRequest();
            inValue.Body = new MES.module.BLL.PService.ToMesRequestBody();
            inValue.Body.order_no = order_no;
            return ((MES.module.BLL.PService.PServiceSoap)(this)).ToMesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MES.module.BLL.PService.ToGXResponse MES.module.BLL.PService.PServiceSoap.ToGX(MES.module.BLL.PService.ToGXRequest request) {
            return base.Channel.ToGX(request);
        }
        
        public bool ToGX(string order_no) {
            MES.module.BLL.PService.ToGXRequest inValue = new MES.module.BLL.PService.ToGXRequest();
            inValue.Body = new MES.module.BLL.PService.ToGXRequestBody();
            inValue.Body.order_no = order_no;
            MES.module.BLL.PService.ToGXResponse retVal = ((MES.module.BLL.PService.PServiceSoap)(this)).ToGX(inValue);
            return retVal.Body.ToGXResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MES.module.BLL.PService.ToGXResponse> MES.module.BLL.PService.PServiceSoap.ToGXAsync(MES.module.BLL.PService.ToGXRequest request) {
            return base.Channel.ToGXAsync(request);
        }
        
        public System.Threading.Tasks.Task<MES.module.BLL.PService.ToGXResponse> ToGXAsync(string order_no) {
            MES.module.BLL.PService.ToGXRequest inValue = new MES.module.BLL.PService.ToGXRequest();
            inValue.Body = new MES.module.BLL.PService.ToGXRequestBody();
            inValue.Body.order_no = order_no;
            return ((MES.module.BLL.PService.PServiceSoap)(this)).ToGXAsync(inValue);
        }
    }
}