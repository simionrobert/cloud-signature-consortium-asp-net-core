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
    /// Output parameters for credentials/info method
    /// </summary>
    [DataContract]
    public partial class OutputCredentialsInfo : IEquatable<OutputCredentialsInfo>
    { 
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [Required]
        [DataMember(Name="key")]
        public Key Key { get; set; }

        /// <summary>
        /// Gets or Sets Cert
        /// </summary>
        [Required]
        [DataMember(Name="cert")]
        public Cert Cert { get; set; }

        /// <summary>
        /// Gets or Sets AuthMode
        /// </summary>
        [Required]
        [DataMember(Name="authMode")]
        public string AuthMode { get; set; }

        /// <summary>
        /// Gets or Sets SCAL
        /// </summary>
        [DataMember(Name="SCAL")]
        public string SCAL { get; set; }

        /// <summary>
        /// Gets or Sets PIN
        /// </summary>
        [Required]
        [DataMember(Name="PIN")]
        public PININFO PIN { get; set; }

        /// <summary>
        /// Gets or Sets OTP
        /// </summary>
        [Required]
        [DataMember(Name="OTP")]
        public OTPINFO OTP { get; set; }

        /// <summary>
        /// Gets or Sets Multisign
        /// </summary>
        [Required]
        [DataMember(Name="multisign")]
        public bool? Multisign { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [Required]
        [DataMember(Name="lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputCredentialsInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Cert: ").Append(Cert).Append("\n");
            sb.Append("  AuthMode: ").Append(AuthMode).Append("\n");
            sb.Append("  SCAL: ").Append(SCAL).Append("\n");
            sb.Append("  PIN: ").Append(PIN).Append("\n");
            sb.Append("  OTP: ").Append(OTP).Append("\n");
            sb.Append("  Multisign: ").Append(Multisign).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OutputCredentialsInfo)obj);
        }

        /// <summary>
        /// Returns true if OutputCredentialsInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputCredentialsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputCredentialsInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Key == other.Key ||
                    Key != null &&
                    Key.Equals(other.Key)
                ) && 
                (
                    Cert == other.Cert ||
                    Cert != null &&
                    Cert.Equals(other.Cert)
                ) && 
                (
                    AuthMode == other.AuthMode ||
                    AuthMode != null &&
                    AuthMode.Equals(other.AuthMode)
                ) && 
                (
                    SCAL == other.SCAL ||
                    SCAL != null &&
                    SCAL.Equals(other.SCAL)
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
                    Multisign == other.Multisign ||
                    Multisign != null &&
                    Multisign.Equals(other.Multisign)
                ) && 
                (
                    Lang == other.Lang ||
                    Lang != null &&
                    Lang.Equals(other.Lang)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                    if (Cert != null)
                    hashCode = hashCode * 59 + Cert.GetHashCode();
                    if (AuthMode != null)
                    hashCode = hashCode * 59 + AuthMode.GetHashCode();
                    if (SCAL != null)
                    hashCode = hashCode * 59 + SCAL.GetHashCode();
                    if (PIN != null)
                    hashCode = hashCode * 59 + PIN.GetHashCode();
                    if (OTP != null)
                    hashCode = hashCode * 59 + OTP.GetHashCode();
                    if (Multisign != null)
                    hashCode = hashCode * 59 + Multisign.GetHashCode();
                    if (Lang != null)
                    hashCode = hashCode * 59 + Lang.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OutputCredentialsInfo left, OutputCredentialsInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OutputCredentialsInfo left, OutputCredentialsInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
