﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebOperaciones.ConductorWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Conductor", Namespace="http://schemas.datacontract.org/2004/07/WcfConductor.Dominio")]
    [System.SerializableAttribute()]
    public partial class Conductor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoria_licenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string des_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string des_nombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string direccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int dni_conductorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecha_ingresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nro_licenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tx_estadoField;
        
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
        public string categoria_licencia {
            get {
                return this.categoria_licenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.categoria_licenciaField, value) != true)) {
                    this.categoria_licenciaField = value;
                    this.RaisePropertyChanged("categoria_licencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string des_apellido {
            get {
                return this.des_apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.des_apellidoField, value) != true)) {
                    this.des_apellidoField = value;
                    this.RaisePropertyChanged("des_apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string des_nombres {
            get {
                return this.des_nombresField;
            }
            set {
                if ((object.ReferenceEquals(this.des_nombresField, value) != true)) {
                    this.des_nombresField = value;
                    this.RaisePropertyChanged("des_nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                if ((object.ReferenceEquals(this.direccionField, value) != true)) {
                    this.direccionField = value;
                    this.RaisePropertyChanged("direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int dni_conductor {
            get {
                return this.dni_conductorField;
            }
            set {
                if ((this.dni_conductorField.Equals(value) != true)) {
                    this.dni_conductorField = value;
                    this.RaisePropertyChanged("dni_conductor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha_ingreso {
            get {
                return this.fecha_ingresoField;
            }
            set {
                if ((this.fecha_ingresoField.Equals(value) != true)) {
                    this.fecha_ingresoField = value;
                    this.RaisePropertyChanged("fecha_ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nro_licencia {
            get {
                return this.nro_licenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.nro_licenciaField, value) != true)) {
                    this.nro_licenciaField = value;
                    this.RaisePropertyChanged("nro_licencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tx_estado {
            get {
                return this.tx_estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.tx_estadoField, value) != true)) {
                    this.tx_estadoField = value;
                    this.RaisePropertyChanged("tx_estado");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfConductor.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
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
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((object.ReferenceEquals(this.codigoField, value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConductorWS.IConductores")]
    public interface IConductores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/CrearConductor", ReplyAction="http://tempuri.org/IConductores/CrearConductorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebOperaciones.ConductorWS.RepetidoException), Action="http://tempuri.org/IConductores/CrearConductorRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfConductor.Errores")]
        WebOperaciones.ConductorWS.Conductor CrearConductor(WebOperaciones.ConductorWS.Conductor conductorACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/CrearConductor", ReplyAction="http://tempuri.org/IConductores/CrearConductorResponse")]
        System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> CrearConductorAsync(WebOperaciones.ConductorWS.Conductor conductorACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ObtenerConductor", ReplyAction="http://tempuri.org/IConductores/ObtenerConductorResponse")]
        WebOperaciones.ConductorWS.Conductor ObtenerConductor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ObtenerConductor", ReplyAction="http://tempuri.org/IConductores/ObtenerConductorResponse")]
        System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> ObtenerConductorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ModificarConductor", ReplyAction="http://tempuri.org/IConductores/ModificarConductorResponse")]
        WebOperaciones.ConductorWS.Conductor ModificarConductor(WebOperaciones.ConductorWS.Conductor conductorAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ModificarConductor", ReplyAction="http://tempuri.org/IConductores/ModificarConductorResponse")]
        System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> ModificarConductorAsync(WebOperaciones.ConductorWS.Conductor conductorAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/EliminarConductor", ReplyAction="http://tempuri.org/IConductores/EliminarConductorResponse")]
        void EliminarConductor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/EliminarConductor", ReplyAction="http://tempuri.org/IConductores/EliminarConductorResponse")]
        System.Threading.Tasks.Task EliminarConductorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/EliminarInactivos", ReplyAction="http://tempuri.org/IConductores/EliminarInactivosResponse")]
        void EliminarInactivos(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/EliminarInactivos", ReplyAction="http://tempuri.org/IConductores/EliminarInactivosResponse")]
        System.Threading.Tasks.Task EliminarInactivosAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ListarConductor", ReplyAction="http://tempuri.org/IConductores/ListarConductorResponse")]
        WebOperaciones.ConductorWS.Conductor[] ListarConductor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConductores/ListarConductor", ReplyAction="http://tempuri.org/IConductores/ListarConductorResponse")]
        System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor[]> ListarConductorAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConductoresChannel : WebOperaciones.ConductorWS.IConductores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConductoresClient : System.ServiceModel.ClientBase<WebOperaciones.ConductorWS.IConductores>, WebOperaciones.ConductorWS.IConductores {
        
        public ConductoresClient() {
        }
        
        public ConductoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConductoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConductoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConductoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebOperaciones.ConductorWS.Conductor CrearConductor(WebOperaciones.ConductorWS.Conductor conductorACrear) {
            return base.Channel.CrearConductor(conductorACrear);
        }
        
        public System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> CrearConductorAsync(WebOperaciones.ConductorWS.Conductor conductorACrear) {
            return base.Channel.CrearConductorAsync(conductorACrear);
        }
        
        public WebOperaciones.ConductorWS.Conductor ObtenerConductor(int id) {
            return base.Channel.ObtenerConductor(id);
        }
        
        public System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> ObtenerConductorAsync(int id) {
            return base.Channel.ObtenerConductorAsync(id);
        }
        
        public WebOperaciones.ConductorWS.Conductor ModificarConductor(WebOperaciones.ConductorWS.Conductor conductorAModificar) {
            return base.Channel.ModificarConductor(conductorAModificar);
        }
        
        public System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor> ModificarConductorAsync(WebOperaciones.ConductorWS.Conductor conductorAModificar) {
            return base.Channel.ModificarConductorAsync(conductorAModificar);
        }
        
        public void EliminarConductor(int id) {
            base.Channel.EliminarConductor(id);
        }
        
        public System.Threading.Tasks.Task EliminarConductorAsync(int id) {
            return base.Channel.EliminarConductorAsync(id);
        }
        
        public void EliminarInactivos(int id) {
            base.Channel.EliminarInactivos(id);
        }
        
        public System.Threading.Tasks.Task EliminarInactivosAsync(int id) {
            return base.Channel.EliminarInactivosAsync(id);
        }
        
        public WebOperaciones.ConductorWS.Conductor[] ListarConductor() {
            return base.Channel.ListarConductor();
        }
        
        public System.Threading.Tasks.Task<WebOperaciones.ConductorWS.Conductor[]> ListarConductorAsync() {
            return base.Channel.ListarConductorAsync();
        }
    }
}
