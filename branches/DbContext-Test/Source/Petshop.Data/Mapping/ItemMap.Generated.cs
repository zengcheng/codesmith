﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Data.Mapping
{
    public partial class ItemMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.Item>
    {
        public ItemMap()
        {
            // table
            ToTable("Item", "dbo");

            // keys
            HasKey(t => t.ItemId);

            // Properties
            Property(t => t.ItemId)
                .HasColumnName("ItemId")
                .HasMaxLength(10)
                .IsRequired();
            Property(t => t.ProductId)
                .HasColumnName("ProductId")
                .HasMaxLength(10)
                .IsRequired();
            Property(t => t.ListPrice)
                .HasColumnName("ListPrice")
                .HasPrecision(10, 2)
                .IsOptional();
            Property(t => t.UnitCost)
                .HasColumnName("UnitCost")
                .HasPrecision(10, 2)
                .IsOptional();
            Property(t => t.SupplierId)
                .HasColumnName("Supplier")
                .IsOptional();
            Property(t => t.Status)
                .HasColumnName("Status")
                .HasMaxLength(2)
                .IsOptional();
            Property(t => t.Attribute1)
                .HasColumnName("Attr1")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Attribute2)
                .HasColumnName("Attr2")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Attribute3)
                .HasColumnName("Attr3")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Attribute4)
                .HasColumnName("Attr4")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Attribute5)
                .HasColumnName("Attr5")
                .HasMaxLength(80)
                .IsOptional();

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.ItemList)
                .HasForeignKey(d => d.ProductId);
            HasOptional(t => t.Supplier)
                .WithMany(t => t.ItemList)
                .HasForeignKey(d => d.SupplierId);

            InitializeMapping();
        }
    }
}
