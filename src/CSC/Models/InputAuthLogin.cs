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
    /// Input parameters for auth/login method
    /// </summary>
    [DataContract]
    public partial class InputAuthLogin : IEquatable<InputAuthLogin>
    { 
        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets RememberMe
        /// </summary>
        [Required]
        [DataMember(Name="rememberMe")]
        public bool? RememberMe { get; set; }

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
            sb.Append("class InputAuthLogin {\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  RememberMe: ").Append(RememberMe).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputAuthLogin)obj);
        }

        /// <summary>
        /// Returns true if InputAuthLogin instances are equal
        /// </summary>
        /// <param name="other">Instance of InputAuthLogin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputAuthLogin other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RefreshToken == other.RefreshToken ||
                    RefreshToken != null &&
                    RefreshToken.Equals(other.RefreshToken)
                ) && 
                (
                    RememberMe == other.RememberMe ||
                    RememberMe != null &&
                    RememberMe.Equals(other.RememberMe)
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
                    if (RefreshToken != null)
                    hashCode = hashCode * 59 + RefreshToken.GetHashCode();
                    if (RememberMe != null)
                    hashCode = hashCode * 59 + RememberMe.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputAuthLogin left, InputAuthLogin right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputAuthLogin left, InputAuthLogin right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
