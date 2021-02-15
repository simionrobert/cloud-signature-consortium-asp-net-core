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
    /// One or more credentialID associated with the provided or implicit userID
    /// </summary>
    [DataContract]
    public partial class CredentialIDs : List<string>, IEquatable<CredentialIDs>
    {
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialIDs {\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
        public new string ToJson()
#pragma warning restore CS0109 // Member does not hide an inherited member; new keyword is not required
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
            return obj.GetType() == GetType() && Equals((CredentialIDs)obj);
        }

        /// <summary>
        /// Returns true if CredentialIDs instances are equal
        /// </summary>
        /// <param name="other">Instance of CredentialIDs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialIDs other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return false;
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
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CredentialIDs left, CredentialIDs right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CredentialIDs left, CredentialIDs right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
