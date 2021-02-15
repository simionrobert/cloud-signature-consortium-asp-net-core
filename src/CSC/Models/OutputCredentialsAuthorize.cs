/*
 * CSC Api
 *
 * This document contains the API descriprion
 *
 * OpenAPI spec version: 1.0.3.0
 * Contact: info@cloudsignatureconsortium.org

 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CSC.Models
{ 
    /// <summary>
    /// Output parameters for credentials/authorize method
    /// </summary>
    [DataContract]
    public partial class OutputCredentialsAuthorize : IEquatable<OutputCredentialsAuthorize>
    { 
        /// <summary>
        /// Gets or Sets SAD
        /// </summary>
        [Required]
        [DataMember(Name="SAD")]
        public string SAD { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expiresIn")]
        public decimal? ExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputCredentialsAuthorize {\n");
            sb.Append("  SAD: ").Append(SAD).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((OutputCredentialsAuthorize)obj);
        }

        /// <summary>
        /// Returns true if OutputCredentialsAuthorize instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputCredentialsAuthorize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputCredentialsAuthorize other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SAD == other.SAD ||
                    SAD != null &&
                    SAD.Equals(other.SAD)
                ) && 
                (
                    ExpiresIn == other.ExpiresIn ||
                    ExpiresIn != null &&
                    ExpiresIn.Equals(other.ExpiresIn)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (SAD != null)
                    hashCode = hashCode * 59 + SAD.GetHashCode();
                    if (ExpiresIn != null)
                    hashCode = hashCode * 59 + ExpiresIn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OutputCredentialsAuthorize left, OutputCredentialsAuthorize right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OutputCredentialsAuthorize left, OutputCredentialsAuthorize right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
