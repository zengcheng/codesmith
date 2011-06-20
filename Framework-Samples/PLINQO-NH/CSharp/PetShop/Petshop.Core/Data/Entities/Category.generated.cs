#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using Petshop.Data;

namespace Petshop.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("CategoryId: {CategoryId}")]
    public partial class Category : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Category()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Category()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _categoryId;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String CategoryId
        {
            get { return _categoryId; }
            set
            {
                OnCategoryIdChanging(value, _categoryId);
                SendPropertyChanging("CategoryId");
                _categoryId = value;
                SendPropertyChanged("CategoryId");
                OnCategoryIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _name;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Name
        {
            get { return _name; }
            set
            {
                OnNameChanging(value, _name);
                SendPropertyChanging("Name");
                _name = value;
                SendPropertyChanged("Name");
                OnNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _description;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Descn
        {
            get { return _description; }
            set
            {
                OnDescnChanging(value, _description);
                SendPropertyChanging("Descn");
                _description = value;
                SendPropertyChanged("Descn");
                OnDescnChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IList<Product> _productList;
        
        [System.Runtime.Serialization.DataMember(Order = 4, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual IList<Product> ProductList
        {
            get { return _productList; }
            set
            {
                OnProductListChanging(value, _productList);
                SendPropertyChanging("ProductList");
                _productList = value;
                SendPropertyChanged("ProductList");
                OnProductListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnCategoryIdChanging(System.String newValue, System.String oldValue);
        
        partial void OnCategoryIdChanged(System.String value);
        
        partial void OnNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnNameChanged(System.String value);
        
        partial void OnDescnChanging(System.String newValue, System.String oldValue);
        
        partial void OnDescnChanged(System.String value);
        
        
        partial void OnProductListChanging(IList<Product> newValue, IList<Product> oldValue);
        
        partial void OnProductListChanged(IList<Product> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Category Clone()
        {
            return (Category)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Category FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Category));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Category;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Category FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Category));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Category;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414
