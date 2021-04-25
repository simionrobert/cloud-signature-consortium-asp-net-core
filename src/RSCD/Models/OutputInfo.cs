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
    /// Output parameters for info method
    /// </summary>
    [DataContract]
    public partial class OutputInfo : IEquatable<OutputInfo>
    { 
        /// <summary>
        /// Gets or Sets Specs
        /// </summary>
        [Required]
        [DataMember(Name="specs")]
        public string Specs { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [Required]
        [DataMember(Name="logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [Required]
        [DataMember(Name="region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [Required]
        [DataMember(Name="lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [Required]
        [DataMember(Name="authType")]
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Gets or Sets Oauth2
        /// </summary>
        [DataMember(Name="oauth2")]
        public string Oauth2 { get; set; }

        /// <summary>
        /// Gets or Sets Methods
        /// </summary>
        [Required]
        [DataMember(Name="methods")]
        public Methods Methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputInfo {\n");
            sb.Append("  Specs: ").Append(Specs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  Oauth2: ").Append(Oauth2).Append("\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OutputInfo)obj);
        }

        /// <summary>
        /// Returns true if OutputInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Specs == other.Specs ||
                    Specs != null &&
                    Specs.Equals(other.Specs)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Logo == other.Logo ||
                    Logo != null &&
                    Logo.Equals(other.Logo)
                ) && 
                (
                    Region == other.Region ||
                    Region != null &&
                    Region.Equals(other.Region)
                ) && 
                (
                    Lang == other.Lang ||
                    Lang != null &&
                    Lang.Equals(other.Lang)
                ) && 
                (
                    AuthType == other.AuthType ||
                    AuthType != null &&
                    AuthType.Equals(other.AuthType)
                ) && 
                (
                    Oauth2 == other.Oauth2 ||
                    Oauth2 != null &&
                    Oauth2.Equals(other.Oauth2)
                ) && 
                (
                    Methods == other.Methods ||
                    Methods != null &&
                    Methods.Equals(other.Methods)
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
                    if (Specs != null)
                    hashCode = hashCode * 59 + Specs.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Logo != null)
                    hashCode = hashCode * 59 + Logo.GetHashCode();
                    if (Region != null)
                    hashCode = hashCode * 59 + Region.GetHashCode();
                    if (Lang != null)
                    hashCode = hashCode * 59 + Lang.GetHashCode();
                    if (AuthType != null)
                    hashCode = hashCode * 59 + AuthType.GetHashCode();
                    if (Oauth2 != null)
                    hashCode = hashCode * 59 + Oauth2.GetHashCode();
                    if (Methods != null)
                    hashCode = hashCode * 59 + Methods.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OutputInfo left, OutputInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OutputInfo left, OutputInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
