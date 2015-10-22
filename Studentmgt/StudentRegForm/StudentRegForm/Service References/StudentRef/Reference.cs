﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentRegForm.StudentRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/StudentManagement")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string educationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int mobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contact {
            get {
                return this.contactField;
            }
            set {
                if ((object.ReferenceEquals(this.contactField, value) != true)) {
                    this.contactField = value;
                    this.RaisePropertyChanged("contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string education {
            get {
                return this.educationField;
            }
            set {
                if ((object.ReferenceEquals(this.educationField, value) != true)) {
                    this.educationField = value;
                    this.RaisePropertyChanged("education");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int mobile {
            get {
                return this.mobileField;
            }
            set {
                if ((this.mobileField.Equals(value) != true)) {
                    this.mobileField = value;
                    this.RaisePropertyChanged("mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentRef.IStudentMgt")]
    public interface IStudentMgt {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/getStudent", ReplyAction="http://tempuri.org/IStudentMgt/getStudentResponse")]
        StudentRegForm.StudentRef.Student getStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/getStudent", ReplyAction="http://tempuri.org/IStudentMgt/getStudentResponse")]
        System.Threading.Tasks.Task<StudentRegForm.StudentRef.Student> getStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/setStudent", ReplyAction="http://tempuri.org/IStudentMgt/setStudentResponse")]
        void setStudent(StudentRegForm.StudentRef.Student std);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/setStudent", ReplyAction="http://tempuri.org/IStudentMgt/setStudentResponse")]
        System.Threading.Tasks.Task setStudentAsync(StudentRegForm.StudentRef.Student std);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/DeleteStudent", ReplyAction="http://tempuri.org/IStudentMgt/DeleteStudentResponse")]
        void DeleteStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentMgt/DeleteStudent", ReplyAction="http://tempuri.org/IStudentMgt/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentMgtChannel : StudentRegForm.StudentRef.IStudentMgt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentMgtClient : System.ServiceModel.ClientBase<StudentRegForm.StudentRef.IStudentMgt>, StudentRegForm.StudentRef.IStudentMgt {
        
        public StudentMgtClient() {
        }
        
        public StudentMgtClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentMgtClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentMgtClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentMgtClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StudentRegForm.StudentRef.Student getStudent(int id) {
            return base.Channel.getStudent(id);
        }
        
        public System.Threading.Tasks.Task<StudentRegForm.StudentRef.Student> getStudentAsync(int id) {
            return base.Channel.getStudentAsync(id);
        }
        
        public void setStudent(StudentRegForm.StudentRef.Student std) {
            base.Channel.setStudent(std);
        }
        
        public System.Threading.Tasks.Task setStudentAsync(StudentRegForm.StudentRef.Student std) {
            return base.Channel.setStudentAsync(std);
        }
        
        public void DeleteStudent(int id) {
            base.Channel.DeleteStudent(id);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(int id) {
            return base.Channel.DeleteStudentAsync(id);
        }
    }
}