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
    /// The Root Schema
    /// </summary>
    [DataContract]
    public partial class InputCredentialsSendOTP : IEquatable<InputCredentialsSendOTP>
    { 
        /// <summary>
        /// Gets or Sets CredentialID
        /// </summary>
        [Required]
        [DataMember(Name="credentialID")]
        public string CredentialID { get; set; }

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
            sb.Append("class InputCredentialsSendOTP {\n");
            sb.Append("  CredentialID: ").Append(CredentialID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputCredentialsSendOTP)obj);
        }

        /// <summary>
        /// Returns true if InputCredentialsSendOTP instances are equal
        /// </summary>
        /// <param name="other">Instance of InputCredentialsSendOTP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputCredentialsSendOTP other)
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
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputCredentialsSendOTP left, InputCredentialsSendOTP right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputCredentialsSendOTP left, InputCredentialsSendOTP right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
