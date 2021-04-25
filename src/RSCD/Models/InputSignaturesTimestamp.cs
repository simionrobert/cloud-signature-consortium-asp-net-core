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
    /// Input parameters for signatures/timestamp method
    /// </summary>
    [DataContract]
    public partial class InputSignaturesTimestamp : IEquatable<InputSignaturesTimestamp>
    { 
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [Required]
        [DataMember(Name="hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets HashAlgo
        /// </summary>
        [Required]
        [DataMember(Name="hashAlgo")]
        public string HashAlgo { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name="nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets ClientData
        /// </summary>
        [DataMember(Name="clientData")]
        public string ClientData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputSignaturesTimestamp {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  HashAlgo: ").Append(HashAlgo).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  ClientData: ").Append(ClientData).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputSignaturesTimestamp)obj);
        }

        /// <summary>
        /// Returns true if InputSignaturesTimestamp instances are equal
        /// </summary>
        /// <param name="other">Instance of InputSignaturesTimestamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSignaturesTimestamp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Hash == other.Hash ||
                    Hash != null &&
                    Hash.Equals(other.Hash)
                ) && 
                (
                    HashAlgo == other.HashAlgo ||
                    HashAlgo != null &&
                    HashAlgo.Equals(other.HashAlgo)
                ) && 
                (
                    Nonce == other.Nonce ||
                    Nonce != null &&
                    Nonce.Equals(other.Nonce)
                ) && 
                (
                    ClientData == other.ClientData ||
                    ClientData != null &&
                    ClientData.Equals(other.ClientData)
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
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                    if (HashAlgo != null)
                    hashCode = hashCode * 59 + HashAlgo.GetHashCode();
                    if (Nonce != null)
                    hashCode = hashCode * 59 + Nonce.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputSignaturesTimestamp left, InputSignaturesTimestamp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputSignaturesTimestamp left, InputSignaturesTimestamp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
