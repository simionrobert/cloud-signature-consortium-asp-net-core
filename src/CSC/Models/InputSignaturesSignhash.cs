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
    /// Input parameters for signatures/signHash method
    /// </summary>
    [DataContract]
    public partial class InputSignaturesSignhash : IEquatable<InputSignaturesSignhash>
    { 
        /// <summary>
        /// Gets or Sets CredentialID
        /// </summary>
        [Required]
        [DataMember(Name="credentialID")]
        public string CredentialID { get; set; }

        /// <summary>
        /// Gets or Sets SAD
        /// </summary>
        [Required]
        [DataMember(Name="SAD")]
        public string SAD { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [Required]
        [DataMember(Name="hash")]
        public Hash Hash { get; set; }

        /// <summary>
        /// Gets or Sets HashAlgo
        /// </summary>
        [DataMember(Name="hashAlgo")]
        public string HashAlgo { get; set; }

        /// <summary>
        /// Gets or Sets SignAlgo
        /// </summary>
        [Required]
        [DataMember(Name="signAlgo")]
        public string SignAlgo { get; set; }

        /// <summary>
        /// Gets or Sets SignAlgoParams
        /// </summary>
        [DataMember(Name="signAlgoParams")]
        public string SignAlgoParams { get; set; }

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
            sb.Append("class InputSignaturesSignhash {\n");
            sb.Append("  CredentialID: ").Append(CredentialID).Append("\n");
            sb.Append("  SAD: ").Append(SAD).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  HashAlgo: ").Append(HashAlgo).Append("\n");
            sb.Append("  SignAlgo: ").Append(SignAlgo).Append("\n");
            sb.Append("  SignAlgoParams: ").Append(SignAlgoParams).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputSignaturesSignhash)obj);
        }

        /// <summary>
        /// Returns true if InputSignaturesSignhash instances are equal
        /// </summary>
        /// <param name="other">Instance of InputSignaturesSignhash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSignaturesSignhash other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CredentialID == other.CredentialID ||
                    CredentialID != null &&
                    CredentialID.Equals(other.CredentialID)
                ) && 
                (
                    SAD == other.SAD ||
                    SAD != null &&
                    SAD.Equals(other.SAD)
                ) && 
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
                    SignAlgo == other.SignAlgo ||
                    SignAlgo != null &&
                    SignAlgo.Equals(other.SignAlgo)
                ) && 
                (
                    SignAlgoParams == other.SignAlgoParams ||
                    SignAlgoParams != null &&
                    SignAlgoParams.Equals(other.SignAlgoParams)
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
                    if (CredentialID != null)
                    hashCode = hashCode * 59 + CredentialID.GetHashCode();
                    if (SAD != null)
                    hashCode = hashCode * 59 + SAD.GetHashCode();
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                    if (HashAlgo != null)
                    hashCode = hashCode * 59 + HashAlgo.GetHashCode();
                    if (SignAlgo != null)
                    hashCode = hashCode * 59 + SignAlgo.GetHashCode();
                    if (SignAlgoParams != null)
                    hashCode = hashCode * 59 + SignAlgoParams.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputSignaturesSignhash left, InputSignaturesSignhash right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputSignaturesSignhash left, InputSignaturesSignhash right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
