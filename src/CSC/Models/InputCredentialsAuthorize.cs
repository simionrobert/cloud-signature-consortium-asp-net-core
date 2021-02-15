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
    /// Input parameters for credentials/authorize method
    /// </summary>
    [DataContract]
    public partial class InputCredentialsAuthorize : IEquatable<InputCredentialsAuthorize>
    { 
        /// <summary>
        /// Gets or Sets CredentialID
        /// </summary>
        [Required]
        [DataMember(Name="credentialID")]
        public string CredentialID { get; set; }

        /// <summary>
        /// Gets or Sets NumSignatures
        /// </summary>
        [Required]
        [DataMember(Name="numSignatures")]
        public int? NumSignatures { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash")]
        public Hash Hash { get; set; }

        /// <summary>
        /// Gets or Sets PIN
        /// </summary>
        [DataMember(Name="PIN")]
        public string PIN { get; set; }

        /// <summary>
        /// Gets or Sets OTP
        /// </summary>
        [DataMember(Name="OTP")]
        public string OTP { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

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
            sb.Append("class InputCredentialsAuthorize {\n");
            sb.Append("  CredentialID: ").Append(CredentialID).Append("\n");
            sb.Append("  NumSignatures: ").Append(NumSignatures).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  PIN: ").Append(PIN).Append("\n");
            sb.Append("  OTP: ").Append(OTP).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputCredentialsAuthorize)obj);
        }

        /// <summary>
        /// Returns true if InputCredentialsAuthorize instances are equal
        /// </summary>
        /// <param name="other">Instance of InputCredentialsAuthorize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputCredentialsAuthorize other)
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
                    NumSignatures == other.NumSignatures ||
                    NumSignatures != null &&
                    NumSignatures.Equals(other.NumSignatures)
                ) && 
                (
                    Hash == other.Hash ||
                    Hash != null &&
                    Hash.Equals(other.Hash)
                ) && 
                (
                    PIN == other.PIN ||
                    PIN != null &&
                    PIN.Equals(other.PIN)
                ) && 
                (
                    OTP == other.OTP ||
                    OTP != null &&
                    OTP.Equals(other.OTP)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (NumSignatures != null)
                    hashCode = hashCode * 59 + NumSignatures.GetHashCode();
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                    if (PIN != null)
                    hashCode = hashCode * 59 + PIN.GetHashCode();
                    if (OTP != null)
                    hashCode = hashCode * 59 + OTP.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputCredentialsAuthorize left, InputCredentialsAuthorize right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputCredentialsAuthorize left, InputCredentialsAuthorize right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
