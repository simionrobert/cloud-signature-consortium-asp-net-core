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
    /// Input parameters for credentials/list method
    /// </summary>
    [DataContract]
    public partial class InputCredentialsList : IEquatable<InputCredentialsList>
    { 
        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name="userID")]
        public string UserID { get; set; }

        /// <summary>
        /// Gets or Sets MaxResults
        /// </summary>
        [DataMember(Name="maxResults")]
        public decimal? MaxResults { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name="pageToken")]
        public string PageToken { get; set; }

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
            sb.Append("class InputCredentialsList {\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputCredentialsList)obj);
        }

        /// <summary>
        /// Returns true if InputCredentialsList instances are equal
        /// </summary>
        /// <param name="other">Instance of InputCredentialsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputCredentialsList other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserID == other.UserID ||
                    UserID != null &&
                    UserID.Equals(other.UserID)
                ) && 
                (
                    MaxResults == other.MaxResults ||
                    MaxResults != null &&
                    MaxResults.Equals(other.MaxResults)
                ) && 
                (
                    PageToken == other.PageToken ||
                    PageToken != null &&
                    PageToken.Equals(other.PageToken)
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
                    if (UserID != null)
                    hashCode = hashCode * 59 + UserID.GetHashCode();
                    if (MaxResults != null)
                    hashCode = hashCode * 59 + MaxResults.GetHashCode();
                    if (PageToken != null)
                    hashCode = hashCode * 59 + PageToken.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputCredentialsList left, InputCredentialsList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputCredentialsList left, InputCredentialsList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
