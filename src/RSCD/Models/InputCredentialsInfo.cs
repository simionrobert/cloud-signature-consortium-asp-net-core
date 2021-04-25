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
    /// Input parameters for credentials/info method
    /// </summary>
    [DataContract]
    public partial class InputCredentialsInfo : IEquatable<InputCredentialsInfo>
    { 
        /// <summary>
        /// Gets or Sets CredentialID
        /// </summary>
        [Required]
        [DataMember(Name="credentialID")]
        public string CredentialID { get; set; }

        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [DataMember(Name="certificates")]
        public string Certificates { get; set; }

        /// <summary>
        /// Gets or Sets CertInfo
        /// </summary>
        [DataMember(Name="certInfo")]
        public bool? CertInfo { get; set; }

        /// <summary>
        /// Gets or Sets AuthInfo
        /// </summary>
        [DataMember(Name="authInfo")]
        public bool? AuthInfo { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name="lang")]
        public string Lang { get; set; }

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
            sb.Append("class InputCredentialsInfo {\n");
            sb.Append("  CredentialID: ").Append(CredentialID).Append("\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
            sb.Append("  CertInfo: ").Append(CertInfo).Append("\n");
            sb.Append("  AuthInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputCredentialsInfo)obj);
        }

        /// <summary>
        /// Returns true if InputCredentialsInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of InputCredentialsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputCredentialsInfo other)
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
                    Certificates == other.Certificates ||
                    Certificates != null &&
                    Certificates.Equals(other.Certificates)
                ) && 
                (
                    CertInfo == other.CertInfo ||
                    CertInfo != null &&
                    CertInfo.Equals(other.CertInfo)
                ) && 
                (
                    AuthInfo == other.AuthInfo ||
                    AuthInfo != null &&
                    AuthInfo.Equals(other.AuthInfo)
                ) && 
                (
                    Lang == other.Lang ||
                    Lang != null &&
                    Lang.Equals(other.Lang)
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
                    if (Certificates != null)
                    hashCode = hashCode * 59 + Certificates.GetHashCode();
                    if (CertInfo != null)
                    hashCode = hashCode * 59 + CertInfo.GetHashCode();
                    if (AuthInfo != null)
                    hashCode = hashCode * 59 + AuthInfo.GetHashCode();
                    if (Lang != null)
                    hashCode = hashCode * 59 + Lang.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputCredentialsInfo left, InputCredentialsInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputCredentialsInfo left, InputCredentialsInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
