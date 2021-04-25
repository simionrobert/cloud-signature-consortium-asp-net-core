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

namespace  RSCD.Models
{ 
    /// <summary>
    /// Information about the key
    /// </summary>
    [DataContract]
    public partial class Key : IEquatable<Key>
    { 
        /// <summary>
        /// The status of enablement of the signing key of the credential
        /// </summary>
        /// <value>The status of enablement of the signing key of the credential</value>
        [Required]
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// The list of OIDs of the supported key algorithms
        /// </summary>
        /// <value>The list of OIDs of the supported key algorithms</value>
        [Required]
        [DataMember(Name="algo")]
        public List<string> Algo { get; set; }

        /// <summary>
        /// The length of the cryptographic key in bits
        /// </summary>
        /// <value>The length of the cryptographic key in bits</value>
        [Required]
        [DataMember(Name="len")]
        public int? Len { get; set; }

        /// <summary>
        /// The OID of the ECDSA curve
        /// </summary>
        /// <value>The OID of the ECDSA curve</value>
        [DataMember(Name="curve")]
        public int? Curve { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Key {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Algo: ").Append(Algo).Append("\n");
            sb.Append("  Len: ").Append(Len).Append("\n");
            sb.Append("  Curve: ").Append(Curve).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Key)obj);
        }

        /// <summary>
        /// Returns true if Key instances are equal
        /// </summary>
        /// <param name="other">Instance of Key to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Key other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Algo == other.Algo ||
                    Algo != null &&
                    Algo.SequenceEqual(other.Algo)
                ) && 
                (
                    Len == other.Len ||
                    Len != null &&
                    Len.Equals(other.Len)
                ) && 
                (
                    Curve == other.Curve ||
                    Curve != null &&
                    Curve.Equals(other.Curve)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Algo != null)
                    hashCode = hashCode * 59 + Algo.GetHashCode();
                    if (Len != null)
                    hashCode = hashCode * 59 + Len.GetHashCode();
                    if (Curve != null)
                    hashCode = hashCode * 59 + Curve.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Key left, Key right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Key left, Key right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
