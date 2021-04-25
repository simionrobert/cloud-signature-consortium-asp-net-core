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
    /// Contains information about the credential&#x27;s OTP
    /// </summary>
    [DataContract]
    public partial class OTPINFO : IEquatable<OTPINFO>
    { 
        /// <summary>
        /// Specifies if a text-based OTP is required or not, or optional
        /// </summary>
        /// <value>Specifies if a text-based OTP is required or not, or optional</value>
        [DataMember(Name="presence")]
        public string Presence { get; set; }

        /// <summary>
        /// Specifies if a text-based OTP is required or not, or optional
        /// </summary>
        /// <value>Specifies if a text-based OTP is required or not, or optional</value>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the data format of the OTP
        /// </summary>
        /// <value>Specifies the data format of the OTP</value>
        [DataMember(Name="format")]
        public string Format { get; set; }

        /// <summary>
        /// Specifies an optional label for the data field used to collect the OTP in the user interface
        /// </summary>
        /// <value>Specifies an optional label for the data field used to collect the OTP in the user interface</value>
        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Optionally specifies a free form description of the OTP mechanism in the language specified in the lang parameter
        /// </summary>
        /// <value>Optionally specifies a free form description of the OTP mechanism in the language specified in the lang parameter</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the identifier of the OTP device or application
        /// </summary>
        /// <value>Specifies the identifier of the OTP device or application</value>
        [DataMember(Name="ID")]
        public string ID { get; set; }

        /// <summary>
        /// Optionally specifies the provider of the OTP device or application.
        /// </summary>
        /// <value>Optionally specifies the provider of the OTP device or application.</value>
        [DataMember(Name="provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OTPINFO {\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OTPINFO)obj);
        }

        /// <summary>
        /// Returns true if OTPINFO instances are equal
        /// </summary>
        /// <param name="other">Instance of OTPINFO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OTPINFO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Presence == other.Presence ||
                    Presence != null &&
                    Presence.Equals(other.Presence)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Format == other.Format ||
                    Format != null &&
                    Format.Equals(other.Format)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ID == other.ID ||
                    ID != null &&
                    ID.Equals(other.ID)
                ) && 
                (
                    Provider == other.Provider ||
                    Provider != null &&
                    Provider.Equals(other.Provider)
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
                    if (Presence != null)
                    hashCode = hashCode * 59 + Presence.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Format != null)
                    hashCode = hashCode * 59 + Format.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ID != null)
                    hashCode = hashCode * 59 + ID.GetHashCode();
                    if (Provider != null)
                    hashCode = hashCode * 59 + Provider.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OTPINFO left, OTPINFO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OTPINFO left, OTPINFO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
