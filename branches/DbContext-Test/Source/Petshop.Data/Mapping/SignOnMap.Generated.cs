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
    public partial class SignOnMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.SignOn>
    {
        public SignOnMap()
        {
            // table
            ToTable("SignOn", "dbo");

            // keys
            HasKey(t => t.UserName);

            // Properties
            Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.Password)
                .HasColumnName("Password")
                .HasMaxLength(20)
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}

