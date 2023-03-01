﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WCFSample.Models")]
    public partial class Product : object
    {
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
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
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MathSquare", ReplyAction="http://tempuri.org/IService/MathSquareResponse")]
        MyService.MathSquareResponse MathSquare(MyService.MathSquareRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MathSquare", ReplyAction="http://tempuri.org/IService/MathSquareResponse")]
        System.Threading.Tasks.Task<MyService.MathSquareResponse> MathSquareAsync(MyService.MathSquareRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MathAdd", ReplyAction="http://tempuri.org/IService/MathAddResponse")]
        MyService.MathAddResponse MathAdd(MyService.MathAddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MathAdd", ReplyAction="http://tempuri.org/IService/MathAddResponse")]
        System.Threading.Tasks.Task<MyService.MathAddResponse> MathAddAsync(MyService.MathAddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProduct", ReplyAction="http://tempuri.org/IService/AddProductResponse")]
        MyService.AddProductResponse AddProduct(MyService.AddProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProduct", ReplyAction="http://tempuri.org/IService/AddProductResponse")]
        System.Threading.Tasks.Task<MyService.AddProductResponse> AddProductAsync(MyService.AddProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProductByFields", ReplyAction="http://tempuri.org/IService/AddProductByFieldsResponse")]
        MyService.AddProductByFieldsResponse AddProductByFields(MyService.AddProductByFieldsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProductByFields", ReplyAction="http://tempuri.org/IService/AddProductByFieldsResponse")]
        System.Threading.Tasks.Task<MyService.AddProductByFieldsResponse> AddProductByFieldsAsync(MyService.AddProductByFieldsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MathSquare", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MathSquareRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int num;
        
        public MathSquareRequest()
        {
        }
        
        public MathSquareRequest(int num)
        {
            this.num = num;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MathSquareResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MathSquareResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int MathSquareResult;
        
        public MathSquareResponse()
        {
        }
        
        public MathSquareResponse(int MathSquareResult)
        {
            this.MathSquareResult = MathSquareResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MathAdd", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MathAddRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int num2;
        
        public MathAddRequest()
        {
        }
        
        public MathAddRequest(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MathAddResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MathAddResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int MathAddResult;
        
        public MathAddResponse()
        {
        }
        
        public MathAddResponse(int MathAddResult)
        {
            this.MathAddResult = MathAddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProduct", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddProductRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public MyService.Product prod;
        
        public AddProductRequest()
        {
        }
        
        public AddProductRequest(MyService.Product prod)
        {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProductResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddProductResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int AddProductResult;
        
        public AddProductResponse()
        {
        }
        
        public AddProductResponse(int AddProductResult)
        {
            this.AddProductResult = AddProductResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProductByFields", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddProductByFieldsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string name;
        
        public AddProductByFieldsRequest()
        {
        }
        
        public AddProductByFieldsRequest(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProductByFieldsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddProductByFieldsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int AddProductByFieldsResult;
        
        public AddProductByFieldsResponse()
        {
        }
        
        public AddProductByFieldsResponse(int AddProductByFieldsResult)
        {
            this.AddProductByFieldsResult = AddProductByFieldsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IServiceChannel : MyService.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MyService.IService>, MyService.IService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public MyService.MathSquareResponse MathSquare(MyService.MathSquareRequest request)
        {
            return base.Channel.MathSquare(request);
        }
        
        public System.Threading.Tasks.Task<MyService.MathSquareResponse> MathSquareAsync(MyService.MathSquareRequest request)
        {
            return base.Channel.MathSquareAsync(request);
        }
        
        public MyService.MathAddResponse MathAdd(MyService.MathAddRequest request)
        {
            return base.Channel.MathAdd(request);
        }
        
        public System.Threading.Tasks.Task<MyService.MathAddResponse> MathAddAsync(MyService.MathAddRequest request)
        {
            return base.Channel.MathAddAsync(request);
        }
        
        public MyService.AddProductResponse AddProduct(MyService.AddProductRequest request)
        {
            return base.Channel.AddProduct(request);
        }
        
        public System.Threading.Tasks.Task<MyService.AddProductResponse> AddProductAsync(MyService.AddProductRequest request)
        {
            return base.Channel.AddProductAsync(request);
        }
        
        public MyService.AddProductByFieldsResponse AddProductByFields(MyService.AddProductByFieldsRequest request)
        {
            return base.Channel.AddProductByFields(request);
        }
        
        public System.Threading.Tasks.Task<MyService.AddProductByFieldsResponse> AddProductByFieldsAsync(MyService.AddProductByFieldsRequest request)
        {
            return base.Channel.AddProductByFieldsAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:62236/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}