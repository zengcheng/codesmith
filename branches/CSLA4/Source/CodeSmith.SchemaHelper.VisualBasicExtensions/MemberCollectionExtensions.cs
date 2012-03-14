﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CodeSmith.SchemaHelper
{
    /// <summary>
    /// Extension Methods for MemberCollectionExtensions
    /// </summary>
    public static class MemberCollectionExtensions
    {
        public static string BuildObjectInitializer(this List<IProperty> members)
        {
            return members.BuildObjectInitializer(false);
        }

        public static string BuildObjectInitializer(this List<IProperty> members, bool isObjectFactory)
        {
            return members.BuildObjectInitializer(isObjectFactory, false);
        }

        public static string BuildObjectInitializer(this List<IProperty> members, bool isObjectFactory, bool usePropertyName)
        {
            return members.BuildObjectInitializer(isObjectFactory, usePropertyName, false);
        }

        public static string BuildObjectInitializer(this List<IProperty> members, bool isObjectFactory, bool usePropertyName, bool includeOriginal)
        {
            return members.BuildObjectInitializer(isObjectFactory, usePropertyName, includeOriginal, "criteria.");
        }

        public static string BuildObjectInitializer(this List<IProperty> members, bool isObjectFactory, bool usePropertyName, bool includeOriginal, string prefix)
        {
            string parameters = string.Empty;

            foreach (var property in members)
            {
                var propertyName = isObjectFactory ? 
                                String.Format("item.{0}", property.Name) : 
                                usePropertyName ? property.Name : property.VariableName;

                if (includeOriginal && property.IsType(PropertyType.Key) && !property.IsType(PropertyType.Identity))
                    propertyName = isObjectFactory ? String.Format("item.Original{0}", property.Name) : String.Format("Original{0}", property.Name);
                parameters += string.Format("\r\n\t\t\t{3}{0} = {1}{2}", property.Name, propertyName, property.IsNullable && property.SystemType != "System.String" && property.SystemType != "System.Byte()" ? ".Value" : string.Empty, prefix);
            }

            return parameters.TrimStart(new[] { '\r', '\n', '\t', ',', ' ' });
        }

        public static string BuildParametersVariables(this List<IProperty> members)
        {
            return members.BuildParametersVariables(true);
        }

        public static string BuildParametersVariables(this List<IProperty> members, bool isNullable)
        {
            string parameters = string.Empty;

            foreach (var property in members)
            {
                string systemType = isNullable ? property.SystemType : property.SystemType.TrimEnd(new[] { '?' });
                parameters += string.Format(", ByVal {0} As {1}", property.VariableName, systemType);
            }

            return parameters.TrimStart(new[] { ',', ' ' });
        }

        public static string BuildCommandParameters(this List<IProperty> members)
        {
            return BuildCommandParameters(members, false);
        }

        public static string BuildCommandParameters(this List<IProperty> members, bool isObjectFactory)
        {
            return BuildCommandParameters(members, isObjectFactory, false);
        }

        public static string BuildCommandParameters(this List<IProperty> members, bool isObjectFactory, bool usePropertyName)
        {
            return BuildCommandParameters(members, isObjectFactory, usePropertyName, false);
        }

        public static string BuildCommandParameters(this List<IProperty> members, bool isObjectFactory, bool usePropertyName, bool isChildInsertUpdate)
        {
            return members.BuildCommandParameters(isObjectFactory, usePropertyName, isChildInsertUpdate, false);
        }

        public static string BuildCommandParameters(this List<IProperty> members, bool isObjectFactory, bool usePropertyName, bool isChildInsertUpdate, bool includeOutPutParameters)
        {
            return members.BuildCommandParameters(isObjectFactory, usePropertyName, isChildInsertUpdate, includeOutPutParameters, false);
        }

        public static string BuildCommandParameters(this List<IProperty> members, bool isObjectFactory, bool usePropertyName, bool isChildInsertUpdate, bool includeOutPutParameters, bool isUpdateStatement)
        {
            string commandParameters = string.Empty;
            string castPrefix = isObjectFactory ? "item." : string.Empty;

            foreach (var property in members)
            {
                string className = string.Empty;
                string includeThisPrefix = !isObjectFactory ? "Me." : string.Empty;
                string propertyName = property.Name;
                string originalPropertyName = String.Format("Original{0}", property.Name);
                
                // Resolve property Name from relationship.
                if (isChildInsertUpdate && property.IsType(PropertyType.Foreign))
                {
                    foreach (Association association in property.Entity.Associations.Where(a => a.AssociationType == AssociationType.ManyToOne))
                    {
                        foreach (AssociationProperty associationProperty in association.Properties)
                        {
                            if (property.KeyName == associationProperty.ForeignProperty.KeyName)// && property.ForeignProperty == associationProperty.ForeignProperty.ForeignProperty)
                            {
                                propertyName = String.Format("{0}.{1}", Util.NamingConventions.VariableName(associationProperty.Property.Name), associationProperty.Property.Name);

                                var format = associationProperty.Property.IsType(PropertyType.Key) && !associationProperty.Property.IsType(PropertyType.Identity) ? "{0}.Original{1}" : "{0}.{1}";
                                originalPropertyName = String.Format(format, Util.NamingConventions.VariableName(associationProperty.Property.Name), associationProperty.Property.Name);

                                className = Util.NamingConventions.VariableName(associationProperty.Property.Name);
                                includeThisPrefix = String.Empty;
                                break;
                            }
                        }   
                    }
                }

                var nullableType = String.Format("{0}{1}", !isObjectFactory ? "Me." : string.Empty, property.Name);
                var originalNullableType = String.Format("{0}Original{1}", !isObjectFactory ? "Me." : string.Empty, property.Name);
                //var nullableType = string.Format("New {0}()", property.SystemType);
                //if (property.SystemType == "System.String" || property.SystemType == "System.Byte()")
                //    nullableType = "Nothing";

                string originalCast;
                string cast;
                if (property.IsNullable && property.SystemType != "System.Byte()")
                {
                    //includeThisPrefix = this.
                    //castprefix = item.
                    //propertyName = bo.propertyname or propertyname
                    if (!string.IsNullOrEmpty(className))
                    {
                        cast = string.Format("ADOHelper.NullCheck(If(Not({3} Is Nothing), {0}{1}{2}, {4})))", includeThisPrefix, castPrefix, propertyName, className, nullableType);
                        originalCast = string.Format("ADOHelper.NullCheck(If(Not({3} Is Nothing), {0}{1}{2}, {4})))", includeThisPrefix, castPrefix, originalPropertyName, className, originalNullableType);
                    }
                    else
                    {
                        cast = string.Format("ADOHelper.NullCheck({0}{1}{2}))", includeThisPrefix, castPrefix, propertyName);
                        originalCast = string.Format("ADOHelper.NullCheck({0}{1}{2}))", includeThisPrefix, castPrefix, originalPropertyName);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(className))
                    {
                        cast = string.Format("If(Not({3} Is Nothing), {0}{1}{2}, {4}))", includeThisPrefix, castPrefix, propertyName, className, nullableType);
                        originalCast = string.Format("If(Not({3} Is Nothing), {0}{1}{2}, {4}))", includeThisPrefix, castPrefix, originalPropertyName, className, originalNullableType);
                    }
                    else
                    {
                        cast = string.Format("{0}{1}{2})", includeThisPrefix, castPrefix, propertyName);
                        originalCast = string.Format("{0}{1}{2})", includeThisPrefix, castPrefix, originalPropertyName);
                    }
                }

                bool includeOriginalPropertyName = isUpdateStatement && property.IsType(PropertyType.Key) && !property.IsType(PropertyType.Identity);
                if (isUpdateStatement && includeOriginalPropertyName)
                    commandParameters += String.Format(Environment.NewLine + "\t\t\t\tcommand.Parameters.AddWithValue(\"{0}Original{1}\", {2}", Configuration.Instance.ParameterPrefix, property.KeyName, originalCast);

                commandParameters += String.Format(Environment.NewLine + "\t\t\t\tcommand.Parameters.AddWithValue(\"{0}{1}\", {2}", Configuration.Instance.ParameterPrefix, property.KeyName, cast);

                if ((property.IsType(PropertyType.Identity) || (property.IsDbType(DbType.Guid) && property.IsType(PropertyType.Key) && !property.IsType(PropertyType.Foreign))) && includeOutPutParameters)
                {
                    if(isUpdateStatement)
                        commandParameters += String.Format(Environment.NewLine + "\t\t\t\tcommand.Parameters(\"{0}{1}\").Direction = ParameterDirection.Input", Configuration.Instance.ParameterPrefix, property.KeyName);
                    else
                        commandParameters += String.Format(Environment.NewLine + "\t\t\t\tcommand.Parameters(\"{0}{1}\").Direction = ParameterDirection.Output", Configuration.Instance.ParameterPrefix, property.KeyName);
                }
            }

            return commandParameters.TrimStart(new[] { '\t', '\r', '\n' });
        }

        public static string BuildHasValueCommandParameters(this List<IProperty> members)
        {
            string commandParameters = string.Empty;

            foreach (var property in members)
            {
                if (property.IsNullable)
                    commandParameters += String.Format(Environment.NewLine + "\t\t\t\t\tcommand.Parameters.AddWithValue(\"{0}{1}HasValue\", criteria.{2}HasValue)", Configuration.Instance.ParameterPrefix, property.KeyName, property.Name);
            }

            return commandParameters.TrimStart(new[] { '\t', '\r', '\n' });
        }

        public static string BuildIdentityKeyEqualityStatements(this List<IProperty> members)
        {
            return members.BuildIdentityKeyEqualityStatements("");
        }

        public static string BuildIdentityKeyEqualityStatements(this List<IProperty> members, string prefix)
        {
            if (members == null || members.Count == 0) return string.Empty;

            string statement = string.Empty;

            foreach (var property in members)
            {
                if (property.IsType(PropertyType.Key) && !property.IsType(PropertyType.Identity))
                    statement += string.Format(" Or Not {1}Original{0} = {1}{0}", property.Name, prefix);
            }

            return statement.Substring(3, statement.Length - 3).TrimStart(new[] { ' ' });
        }
    }
}