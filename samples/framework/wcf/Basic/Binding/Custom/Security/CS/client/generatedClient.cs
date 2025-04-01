﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.Samples.Security
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Samples.Security", ConfigurationName="Microsoft.Samples.Security.ICalculatorDuplex", CallbackContract=typeof(Microsoft.Samples.Security.ICalculatorDuplexCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICalculatorDuplex
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/Clear")]
        void Clear();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/AddTo")]
        void AddTo(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/SubtractFrom")]
        void SubtractFrom(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/MultiplyBy")]
        void MultiplyBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/DivideBy")]
        void DivideBy(double n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICalculatorDuplexCallback
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/Result")]
        void Result(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.Security/ICalculatorDuplex/Equation")]
        void Equation(string eqn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICalculatorDuplexChannel : Microsoft.Samples.Security.ICalculatorDuplex, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CalculatorDuplexClient : System.ServiceModel.DuplexClientBase<Microsoft.Samples.Security.ICalculatorDuplex>, Microsoft.Samples.Security.ICalculatorDuplex
    {
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress)
        {
        }
        
        public void Clear()
        {
            base.Channel.Clear();
        }
        
        public void AddTo(double n)
        {
            base.Channel.AddTo(n);
        }
        
        public void SubtractFrom(double n)
        {
            base.Channel.SubtractFrom(n);
        }
        
        public void MultiplyBy(double n)
        {
            base.Channel.MultiplyBy(n);
        }
        
        public void DivideBy(double n)
        {
            base.Channel.DivideBy(n);
        }
    }
}
