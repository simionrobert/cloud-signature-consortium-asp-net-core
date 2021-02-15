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
    /// Output parameters for signatures/signHash method
    /// </summary>
    [DataContract]
    public partial class OutputSignaturesSignhash : IEquatable<OutputSignaturesSignhash>
    { 
        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [Required]
        [DataMember(Name="signatures")]
        public Signatures Signatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputSignaturesSignhash {\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OutputSignaturesSignhash)obj);
        }

        /// <summary>
        /// Returns true if OutputSignaturesSignhash instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputSignaturesSignhash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputSignaturesSignhash other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Signatures == other.Signatures ||
                    Signatures != null &&
                    Signatures.Equals(other.Signatures)
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
                    if (Signatures != null)
                    hashCode = hashCode * 59 + Signatures.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OutputSignaturesSignhash left, OutputSignaturesSignhash right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OutputSignaturesSignhash left, OutputSignaturesSignhash right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
