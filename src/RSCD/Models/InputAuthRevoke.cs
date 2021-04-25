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
    /// Input parameters for auth/revoke method
    /// </summary>
    [DataContract]
    public partial class InputAuthRevoke : IEquatable<InputAuthRevoke>
    { 
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [Required]
        [DataMember(Name="token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets TokenTypeHint
        /// </summary>
        [DataMember(Name="token_type_hint")]
        public string TokenTypeHint { get; set; }

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
            sb.Append("class InputAuthRevoke {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenTypeHint: ").Append(TokenTypeHint).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InputAuthRevoke)obj);
        }

        /// <summary>
        /// Returns true if InputAuthRevoke instances are equal
        /// </summary>
        /// <param name="other">Instance of InputAuthRevoke to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputAuthRevoke other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                ) && 
                (
                    TokenTypeHint == other.TokenTypeHint ||
                    TokenTypeHint != null &&
                    TokenTypeHint.Equals(other.TokenTypeHint)
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
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                    if (TokenTypeHint != null)
                    hashCode = hashCode * 59 + TokenTypeHint.GetHashCode();
                    if (ClientData != null)
                    hashCode = hashCode * 59 + ClientData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InputAuthRevoke left, InputAuthRevoke right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputAuthRevoke left, InputAuthRevoke right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
