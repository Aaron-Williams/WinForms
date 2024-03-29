// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace CustomerService.Model
{
    [DataContract(IsReference = false)]
    [KnownType(typeof(Address))]
    [KnownType(typeof(Customer))]
    public partial class CustomerAddress: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int CustomerID
        {
            get { return _customerID; }
            set
            {
                if (_customerID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'CustomerID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    if (!IsDeserializing)
                    {
                        if (Customer != null && Customer.CustomerID != value)
                        {
                            Customer = null;
                        }
                    }
                    _customerID = value;
                    OnPropertyChanged("CustomerID");
                }
            }
        }
        private int _customerID;
    
        [DataMember]
        public int AddressID
        {
            get { return _addressID; }
            set
            {
                if (_addressID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'AddressID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    if (!IsDeserializing)
                    {
                        if (Address != null && Address.AddressID != value)
                        {
                            Address = null;
                        }
                    }
                    _addressID = value;
                    OnPropertyChanged("AddressID");
                }
            }
        }
        private int _addressID;
    
        [DataMember]
        public string AddressType
        {
            get { return _addressType; }
            set
            {
                if (_addressType != value)
                {
                    _addressType = value;
                    OnPropertyChanged("AddressType");
                }
            }
        }
        private string _addressType;
    
        [DataMember]
        public System.Guid rowguid
        {
            get { return _rowguid; }
            set
            {
                if (_rowguid != value)
                {
                    _rowguid = value;
                    OnPropertyChanged("rowguid");
                }
            }
        }
        private System.Guid _rowguid;
    
        [DataMember]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    _modifiedDate = value;
                    OnPropertyChanged("ModifiedDate");
                }
            }
        }
        private System.DateTime _modifiedDate;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Address Address
        {
            get { return _address; }
            set
            {
                if (!ReferenceEquals(_address, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (AddressID != value.AddressID)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _address;
                    _address = value;
                    FixupAddress(previousValue);
                    OnNavigationPropertyChanged("Address");
                }
            }
        }
        private Address _address;
    
        [DataMember]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (!ReferenceEquals(_customer, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (CustomerID != value.CustomerID)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _customer;
                    _customer = value;
                    FixupCustomer(previousValue);
                    OnNavigationPropertyChanged("Customer");
                }
            }
        }
        private Customer _customer;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        // This entity type is the dependent end in at least one association that performs cascade deletes.
        // This event handler will process notifications that occur when the principal end is deleted.
        internal void HandleCascadeDelete(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                this.MarkAsDeleted();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Address = null;
            Customer = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupAddress(Address previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.CustomerAddresses.Contains(this))
            {
                previousValue.CustomerAddresses.Remove(this);
            }
    
            if (Address != null)
            {
                if (!Address.CustomerAddresses.Contains(this))
                {
                    Address.CustomerAddresses.Add(this);
                }
    
                AddressID = Address.AddressID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Address")
                    && (ChangeTracker.OriginalValues["Address"] == Address))
                {
                    ChangeTracker.OriginalValues.Remove("Address");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Address", previousValue);
                }
                if (Address != null && !Address.ChangeTracker.ChangeTrackingEnabled)
                {
                    Address.StartTracking();
                }
            }
        }
    
        private void FixupCustomer(Customer previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.CustomerAddresses.Contains(this))
            {
                previousValue.CustomerAddresses.Remove(this);
            }
    
            if (Customer != null)
            {
                if (!Customer.CustomerAddresses.Contains(this))
                {
                    Customer.CustomerAddresses.Add(this);
                }
    
                CustomerID = Customer.CustomerID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Customer")
                    && (ChangeTracker.OriginalValues["Customer"] == Customer))
                {
                    ChangeTracker.OriginalValues.Remove("Customer");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Customer", previousValue);
                }
                if (Customer != null && !Customer.ChangeTracker.ChangeTrackingEnabled)
                {
                    Customer.StartTracking();
                }
            }
        }

        #endregion
    }
}