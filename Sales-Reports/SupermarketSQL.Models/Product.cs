﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSQL.Models
{
    public class Product
    {
        private int _id;
        public virtual int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        private int _vendorId;
        public virtual int VendorId
        {
            get
            {
                return this._vendorId;
            }
            set
            {
                this._vendorId = value;
            }
        }

        private int? _taxId;
        public virtual int? TaxId
        {
            get
            {
                return this._taxId;
            }
            set
            {
                this._taxId = value;
            }
        }

        private string _productName;
        public virtual string ProductName
        {
            get
            {
                return this._productName;
            }
            set
            {
                this._productName = value;
            }
        }

        private int _measureId;
        public virtual int MeasureId
        {
            get
            {
                return this._measureId;
            }
            set
            {
                this._measureId = value;
            }
        }

        private decimal? _basePrice;
        public virtual decimal? BasePrice
        {
            get
            {
                return this._basePrice;
            }
            set
            {
                this._basePrice = value;
            }
        }

        private Measure _measure;
        public virtual Measure Measure
        {
            get
            {
                return this._measure;
            }
            set
            {
                this._measure = value;
            }
        }

        private Vendor _vendor;
        public virtual Vendor Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
            }
        }

        private TaxTable _tax;
        public virtual TaxTable Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
    }
}
