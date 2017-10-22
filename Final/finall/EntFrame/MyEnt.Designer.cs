﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace mess.EntFrame
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MyDataEntities3 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MyDataEntities3 object using the connection string found in the 'MyDataEntities3' section of the application configuration file.
        /// </summary>
        public MyDataEntities3() : base("name=MyDataEntities3", "MyDataEntities3")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyDataEntities3 object.
        /// </summary>
        public MyDataEntities3(string connectionString) : base(connectionString, "MyDataEntities3")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyDataEntities3 object.
        /// </summary>
        public MyDataEntities3(EntityConnection connection) : base(connection, "MyDataEntities3")
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
        public ObjectSet<My_Table> My_Table
        {
            get
            {
                if ((_My_Table == null))
                {
                    _My_Table = base.CreateObjectSet<My_Table>("My_Table");
                }
                return _My_Table;
            }
        }
        private ObjectSet<My_Table> _My_Table;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the My_Table EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMy_Table(My_Table my_Table)
        {
            base.AddObject("My_Table", my_Table);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyDataModel", Name="My_Table")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class My_Table : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new My_Table object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="fname">Initial value of the fname property.</param>
        /// <param name="lname">Initial value of the lname property.</param>
        /// <param name="gender">Initial value of the gender property.</param>
        /// <param name="contact">Initial value of the contact property.</param>
        /// <param name="email">Initial value of the email property.</param>
        /// <param name="uname">Initial value of the Uname property.</param>
        /// <param name="pword">Initial value of the Pword property.</param>
        /// <param name="date">Initial value of the date property.</param>
        /// <param name="time">Initial value of the time property.</param>
        public static My_Table CreateMy_Table(global::System.Int32 id, global::System.String fname, global::System.String lname, global::System.String gender, global::System.String contact, global::System.String email, global::System.String uname, global::System.String pword, global::System.DateTime date, global::System.TimeSpan time)
        {
            My_Table my_Table = new My_Table();
            my_Table.ID = id;
            my_Table.fname = fname;
            my_Table.lname = lname;
            my_Table.gender = gender;
            my_Table.contact = contact;
            my_Table.email = email;
            my_Table.Uname = uname;
            my_Table.Pword = pword;
            my_Table.date = date;
            my_Table.time = time;
            return my_Table;
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
        public global::System.String fname
        {
            get
            {
                return _fname;
            }
            set
            {
                OnfnameChanging(value);
                ReportPropertyChanging("fname");
                _fname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("fname");
                OnfnameChanged();
            }
        }
        private global::System.String _fname;
        partial void OnfnameChanging(global::System.String value);
        partial void OnfnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String lname
        {
            get
            {
                return _lname;
            }
            set
            {
                OnlnameChanging(value);
                ReportPropertyChanging("lname");
                _lname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("lname");
                OnlnameChanged();
            }
        }
        private global::System.String _lname;
        partial void OnlnameChanging(global::System.String value);
        partial void OnlnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String gender
        {
            get
            {
                return _gender;
            }
            set
            {
                OngenderChanging(value);
                ReportPropertyChanging("gender");
                _gender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("gender");
                OngenderChanged();
            }
        }
        private global::System.String _gender;
        partial void OngenderChanging(global::System.String value);
        partial void OngenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String contact
        {
            get
            {
                return _contact;
            }
            set
            {
                OncontactChanging(value);
                ReportPropertyChanging("contact");
                _contact = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("contact");
                OncontactChanged();
            }
        }
        private global::System.String _contact;
        partial void OncontactChanging(global::System.String value);
        partial void OncontactChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Uname
        {
            get
            {
                return _Uname;
            }
            set
            {
                OnUnameChanging(value);
                ReportPropertyChanging("Uname");
                _Uname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Uname");
                OnUnameChanged();
            }
        }
        private global::System.String _Uname;
        partial void OnUnameChanging(global::System.String value);
        partial void OnUnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Pword
        {
            get
            {
                return _Pword;
            }
            set
            {
                OnPwordChanging(value);
                ReportPropertyChanging("Pword");
                _Pword = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Pword");
                OnPwordChanged();
            }
        }
        private global::System.String _Pword;
        partial void OnPwordChanging(global::System.String value);
        partial void OnPwordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.DateTime _date;
        partial void OndateChanging(global::System.DateTime value);
        partial void OndateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.TimeSpan time
        {
            get
            {
                return _time;
            }
            set
            {
                OntimeChanging(value);
                ReportPropertyChanging("time");
                _time = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("time");
                OntimeChanged();
            }
        }
        private global::System.TimeSpan _time;
        partial void OntimeChanging(global::System.TimeSpan value);
        partial void OntimeChanged();

        #endregion

    
    }

    #endregion

    
}
