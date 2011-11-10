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
    public partial class AccountMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.Account>
    {
        public AccountMap()
        {
            // table
            ToTable("Account", "dbo");

            // keys
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.Email)
                .HasColumnName("Email")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .HasMaxLength(2)
                .IsOptional();
            Property(t => t.Address1)
                .HasColumnName("Addr1")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.Address2)
                .HasColumnName("Addr2")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.City)
                .HasColumnName("City")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.State)
                .HasColumnName("State")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.Zip)
                .HasColumnName("Zip")
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.Country)
                .HasColumnName("Country")
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(20)
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}

