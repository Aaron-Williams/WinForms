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
    [KnownType(typeof(Product))]
    [KnownType(typeof(ProductCategory))]
    public partial class ProductCategory: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int ProductCategoryID
        {
            get { return _productCategoryID; }
            set
            {
                if (_productCategoryID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ProductCategoryID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _productCategoryID = value;
                    OnPropertyChanged("ProductCategoryID");
                }
            }
        }
        private int _productCategoryID;
    
        [DataMember]
        public Nullable<int> ParentProductCategoryID
        {
            get { return _parentProductCategoryID; }
            set
            {
                if (_parentProductCategoryID != value)
                {
                    ChangeTracker.RecordOriginalValue("ParentProductCategoryID", _parentProductCategoryID);
                    if (!IsDeserializing)
                    {
                        if (ProductCategory2 != null && ProductCategory2.ProductCategoryID != value)
                        {
                            ProductCategory2 = null;
                        }
                    }
                    _parentProductCategoryID = value;
                    OnPropertyChanged("ParentProductCategoryID");
                }
            }
        }
        private Nullable<int> _parentProductCategoryID;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
    
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
        public TrackableCollection<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new TrackableCollection<Product>();
                    _products.CollectionChanged += FixupProducts;
                }
                return _products;
            }
            set
            {
                if (!ReferenceEquals(_products, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_products != null)
                    {
                        _products.CollectionChanged -= FixupProducts;
                    }
                    _products = value;
                    if (_products != null)
                    {
                        _products.CollectionChanged += FixupProducts;
                    }
                    OnNavigationPropertyChanged("Products");
                }
            }
        }
        private TrackableCollection<Product> _products;
    
        [DataMember]
        public TrackableCollection<ProductCategory> ProductCategory1
        {
            get
            {
                if (_productCategory1 == null)
                {
                    _productCategory1 = new TrackableCollection<ProductCategory>();
                    _productCategory1.CollectionChanged += FixupProductCategory1;
                }
                return _productCategory1;
            }
            set
            {
                if (!ReferenceEquals(_productCategory1, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_productCategory1 != null)
                    {
                        _productCategory1.CollectionChanged -= FixupProductCategory1;
                    }
                    _productCategory1 = value;
                    if (_productCategory1 != null)
                    {
                        _productCategory1.CollectionChanged += FixupProductCategory1;
                    }
                    OnNavigationPropertyChanged("ProductCategory1");
                }
            }
        }
        private TrackableCollection<ProductCategory> _productCategory1;
    
        [DataMember]
        public ProductCategory ProductCategory2
        {
            get { return _productCategory2; }
            set
            {
                if (!ReferenceEquals(_productCategory2, value))
                {
                    var previousValue = _productCategory2;
                    _productCategory2 = value;
                    FixupProductCategory2(previousValue);
                    OnNavigationPropertyChanged("ProductCategory2");
                }
            }
        }
        private ProductCategory _productCategory2;

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
            Products.Clear();
            ProductCategory1.Clear();
            ProductCategory2 = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupProductCategory2(ProductCategory previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.ProductCategory1.Contains(this))
            {
                previousValue.ProductCategory1.Remove(this);
            }
    
            if (ProductCategory2 != null)
            {
                if (!ProductCategory2.ProductCategory1.Contains(this))
                {
                    ProductCategory2.ProductCategory1.Add(this);
                }
    
                ParentProductCategoryID = ProductCategory2.ProductCategoryID;
            }
            else if (!skipKeys)
            {
                ParentProductCategoryID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("ProductCategory2")
                    && (ChangeTracker.OriginalValues["ProductCategory2"] == ProductCategory2))
                {
                    ChangeTracker.OriginalValues.Remove("ProductCategory2");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("ProductCategory2", previousValue);
                }
                if (ProductCategory2 != null && !ProductCategory2.ChangeTracker.ChangeTrackingEnabled)
                {
                    ProductCategory2.StartTracking();
                }
            }
        }
    
        private void FixupProducts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Product item in e.NewItems)
                {
                    item.ProductCategory = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Products", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Product item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory, this))
                    {
                        item.ProductCategory = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Products", item);
                    }
                }
            }
        }
    
        private void FixupProductCategory1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProductCategory item in e.NewItems)
                {
                    item.ProductCategory2 = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ProductCategory1", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductCategory item in e.OldItems)
                {
                    if (ReferenceEquals(item.ProductCategory2, this))
                    {
                        item.ProductCategory2 = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ProductCategory1", item);
                    }
                }
            }
        }

        #endregion
    }
}