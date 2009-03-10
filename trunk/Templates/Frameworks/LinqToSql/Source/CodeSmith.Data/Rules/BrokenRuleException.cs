﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace CodeSmith.Data.Rules
{
    /// <summary>
    /// An exception class for broken rules.
    /// </summary>
    [Serializable]
    public class BrokenRuleException : ValidationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrokenRuleException"/> class.
        /// </summary>
        /// <param name="brokenRules">The broken rules.</param>
        public BrokenRuleException(BrokenRuleCollection brokenRules)
        {
            BrokenRules = brokenRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrokenRuleException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected BrokenRuleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {}

        /// <summary>
        /// Gets the broken rules.
        /// </summary>
        /// <value>The broken rules.</value>
        public BrokenRuleCollection BrokenRules { get; private set; }

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        /// <value></value>
        /// <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
        public override string Message
        {
            get { return ToString(); }
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="CodeSmith.Data.Rules.BrokenRuleException"/> to <see cref="System.String"/>.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(BrokenRuleException ex)
        {
            return ex.ToString();
        }

        /// <summary>
        /// Creates and returns a string representation of the current exception.
        /// </summary>
        /// <returns>
        /// A string representation of the current exception.
        /// </returns>
        /// <PermissionSet>
        /// 	<IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*"/>
        /// </PermissionSet>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (BrokenRules.Count == 1)
                sb.Append("1 broken rule.");
            else
                sb.AppendFormat("{0} broken rules.", BrokenRules.Count);

            sb.AppendLine();

            foreach (BrokenRule rule in BrokenRules)
            {
                sb.AppendFormat("  - {0}", rule.Message);
                sb.AppendLine();
                sb.AppendLine(rule.Context.TrackedObject.Current.ToString());
            }

            return sb.ToString();
        }
    }
}