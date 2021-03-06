﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("cloudtalkModel", "FK_CloudTalk_History_CloudTalk_Client", "Client", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Com.Dover.Web.Areas.CloudTalkModule.Models.Client), "History", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Com.Dover.Web.Areas.CloudTalkModule.Models.History), true)]

#endregion

namespace Com.Dover.Web.Areas.CloudTalkModule.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CloudTalkEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CloudTalkEntities object using the connection string found in the 'CloudTalkEntities' section of the application configuration file.
        /// </summary>
        public CloudTalkEntities() : base("name=CloudTalkEntities", "CloudTalkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CloudTalkEntities object.
        /// </summary>
        public CloudTalkEntities(string connectionString) : base(connectionString, "CloudTalkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CloudTalkEntities object.
        /// </summary>
        public CloudTalkEntities(EntityConnection connection) : base(connection, "CloudTalkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<History> History
        {
            get
            {
                if ((_History == null))
                {
                    _History = base.CreateObjectSet<History>("History");
                }
                return _History;
            }
        }
        private ObjectSet<History> _History;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Client> Client
        {
            get
            {
                if ((_Client == null))
                {
                    _Client = base.CreateObjectSet<Client>("Client");
                }
                return _Client;
            }
        }
        private ObjectSet<Client> _Client;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the History EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHistory(History history)
        {
            base.AddObject("History", history);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Client EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClient(Client client)
        {
            base.AddObject("Client", client);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cloudtalkModel", Name="Client")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Client : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Client object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        public static Client CreateClient(global::System.Int32 id, global::System.String name, global::System.String email)
        {
            Client client = new Client();
            client.Id = id;
            client.Name = name;
            client.Email = email;
            return client;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Logo
        {
            get
            {
                return _Logo;
            }
            set
            {
                OnLogoChanging(value);
                ReportPropertyChanging("Logo");
                _Logo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Logo");
                OnLogoChanged();
            }
        }
        private global::System.String _Logo;
        partial void OnLogoChanging(global::System.String value);
        partial void OnLogoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("cloudtalkModel", "FK_CloudTalk_History_CloudTalk_Client", "History")]
        public EntityCollection<History> CloudTalk_History
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<History>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "History");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<History>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "History", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cloudtalkModel", Name="History")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class History : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new History object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="text">Initial value of the Text property.</param>
        /// <param name="timestamp">Initial value of the Timestamp property.</param>
        /// <param name="sender">Initial value of the Sender property.</param>
        public static History CreateHistory(global::System.Int32 id, global::System.String text, global::System.String timestamp, global::System.String sender)
        {
            History history = new History();
            history.ID = id;
            history.Text = text;
            history.Timestamp = timestamp;
            history.Sender = sender;
            return history;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Timestamp
        {
            get
            {
                return _Timestamp;
            }
            set
            {
                OnTimestampChanging(value);
                ReportPropertyChanging("Timestamp");
                _Timestamp = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Timestamp");
                OnTimestampChanged();
            }
        }
        private global::System.String _Timestamp;
        partial void OnTimestampChanging(global::System.String value);
        partial void OnTimestampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Room
        {
            get
            {
                return _Room;
            }
            set
            {
                OnRoomChanging(value);
                ReportPropertyChanging("Room");
                _Room = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Room");
                OnRoomChanged();
            }
        }
        private global::System.String _Room;
        partial void OnRoomChanging(global::System.String value);
        partial void OnRoomChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Sender
        {
            get
            {
                return _Sender;
            }
            set
            {
                OnSenderChanging(value);
                ReportPropertyChanging("Sender");
                _Sender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Sender");
                OnSenderChanged();
            }
        }
        private global::System.String _Sender;
        partial void OnSenderChanging(global::System.String value);
        partial void OnSenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ClientId
        {
            get
            {
                return _ClientId;
            }
            set
            {
                OnClientIdChanging(value);
                ReportPropertyChanging("ClientId");
                _ClientId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ClientId");
                OnClientIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ClientId;
        partial void OnClientIdChanging(Nullable<global::System.Int32> value);
        partial void OnClientIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("cloudtalkModel", "FK_CloudTalk_History_CloudTalk_Client", "Client")]
        public Client CloudTalk_Client
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "Client").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "Client").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Client> CloudTalk_ClientReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "Client");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Client>("cloudtalkModel.FK_CloudTalk_History_CloudTalk_Client", "Client", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
