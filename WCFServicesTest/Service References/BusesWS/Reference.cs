﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServicesTest.BusesWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movilidad", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Movilidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AsientosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AñoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FeInscripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MotorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlacaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PuertasField;
        
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
        public int Asientos {
            get {
                return this.AsientosField;
            }
            set {
                if ((this.AsientosField.Equals(value) != true)) {
                    this.AsientosField = value;
                    this.RaisePropertyChanged("Asientos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Año {
            get {
                return this.AñoField;
            }
            set {
                if ((object.ReferenceEquals(this.AñoField, value) != true)) {
                    this.AñoField = value;
                    this.RaisePropertyChanged("Año");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Clase {
            get {
                return this.ClaseField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaseField, value) != true)) {
                    this.ClaseField = value;
                    this.RaisePropertyChanged("Clase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FeInscripcion {
            get {
                return this.FeInscripcionField;
            }
            set {
                if ((this.FeInscripcionField.Equals(value) != true)) {
                    this.FeInscripcionField = value;
                    this.RaisePropertyChanged("FeInscripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Motor {
            get {
                return this.MotorField;
            }
            set {
                if ((this.MotorField.Equals(value) != true)) {
                    this.MotorField = value;
                    this.RaisePropertyChanged("Motor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Placa {
            get {
                return this.PlacaField;
            }
            set {
                if ((object.ReferenceEquals(this.PlacaField, value) != true)) {
                    this.PlacaField = value;
                    this.RaisePropertyChanged("Placa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Puertas {
            get {
                return this.PuertasField;
            }
            set {
                if ((this.PuertasField.Equals(value) != true)) {
                    this.PuertasField = value;
                    this.RaisePropertyChanged("Puertas");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusesWS.IBuses")]
    public interface IBuses {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/CrearMovilidad", ReplyAction="http://tempuri.org/IBuses/CrearMovilidadResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServicesTest.BusesWS.RepetidoException), Action="http://tempuri.org/IBuses/CrearMovilidadRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
        WCFServicesTest.BusesWS.Movilidad CrearMovilidad(WCFServicesTest.BusesWS.Movilidad movilidadACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/CrearMovilidad", ReplyAction="http://tempuri.org/IBuses/CrearMovilidadResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> CrearMovilidadAsync(WCFServicesTest.BusesWS.Movilidad movilidadACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ObtenerMovilidad", ReplyAction="http://tempuri.org/IBuses/ObtenerMovilidadResponse")]
        WCFServicesTest.BusesWS.Movilidad ObtenerMovilidad(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ObtenerMovilidad", ReplyAction="http://tempuri.org/IBuses/ObtenerMovilidadResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> ObtenerMovilidadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ModificarMovilidad", ReplyAction="http://tempuri.org/IBuses/ModificarMovilidadResponse")]
        WCFServicesTest.BusesWS.Movilidad ModificarMovilidad(WCFServicesTest.BusesWS.Movilidad movilidadAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ModificarMovilidad", ReplyAction="http://tempuri.org/IBuses/ModificarMovilidadResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> ModificarMovilidadAsync(WCFServicesTest.BusesWS.Movilidad movilidadAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/EliminarMovilidad", ReplyAction="http://tempuri.org/IBuses/EliminarMovilidadResponse")]
        string EliminarMovilidad(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/EliminarMovilidad", ReplyAction="http://tempuri.org/IBuses/EliminarMovilidadResponse")]
        System.Threading.Tasks.Task<string> EliminarMovilidadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ListarMovilidad", ReplyAction="http://tempuri.org/IBuses/ListarMovilidadResponse")]
        WCFServicesTest.BusesWS.Movilidad[] ListarMovilidad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuses/ListarMovilidad", ReplyAction="http://tempuri.org/IBuses/ListarMovilidadResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad[]> ListarMovilidadAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBusesChannel : WCFServicesTest.BusesWS.IBuses, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BusesClient : System.ServiceModel.ClientBase<WCFServicesTest.BusesWS.IBuses>, WCFServicesTest.BusesWS.IBuses {
        
        public BusesClient() {
        }
        
        public BusesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BusesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServicesTest.BusesWS.Movilidad CrearMovilidad(WCFServicesTest.BusesWS.Movilidad movilidadACrear) {
            return base.Channel.CrearMovilidad(movilidadACrear);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> CrearMovilidadAsync(WCFServicesTest.BusesWS.Movilidad movilidadACrear) {
            return base.Channel.CrearMovilidadAsync(movilidadACrear);
        }
        
        public WCFServicesTest.BusesWS.Movilidad ObtenerMovilidad(int id) {
            return base.Channel.ObtenerMovilidad(id);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> ObtenerMovilidadAsync(int id) {
            return base.Channel.ObtenerMovilidadAsync(id);
        }
        
        public WCFServicesTest.BusesWS.Movilidad ModificarMovilidad(WCFServicesTest.BusesWS.Movilidad movilidadAModificar) {
            return base.Channel.ModificarMovilidad(movilidadAModificar);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad> ModificarMovilidadAsync(WCFServicesTest.BusesWS.Movilidad movilidadAModificar) {
            return base.Channel.ModificarMovilidadAsync(movilidadAModificar);
        }
        
        public string EliminarMovilidad(int id) {
            return base.Channel.EliminarMovilidad(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarMovilidadAsync(int id) {
            return base.Channel.EliminarMovilidadAsync(id);
        }
        
        public WCFServicesTest.BusesWS.Movilidad[] ListarMovilidad() {
            return base.Channel.ListarMovilidad();
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.BusesWS.Movilidad[]> ListarMovilidadAsync() {
            return base.Channel.ListarMovilidadAsync();
        }
    }
}
