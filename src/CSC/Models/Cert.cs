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
    /// Contains information about the signature certificate
    /// </summary>
    [DataContract]
    public partial class Cert : IEquatable<Cert>
    { 
        /// <summary>
        /// The Status Schema
        /// </summary>
        /// <value>The Status Schema</value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Contains one or more Base64-encoded X.509v3 certificates from the certificate chain
        /// </summary>
        /// <value>Contains one or more Base64-encoded X.509v3 certificates from the certificate chain</value>
        [DataMember(Name="certificates")]
        public List<string> Certificates { get; set; }

        /// <summary>
        /// The Issuer Subject Distinguished Name from the X.509v3 end entity certificate in printable string format
        /// </summary>
        /// <value>The Issuer Subject Distinguished Name from the X.509v3 end entity certificate in printable string format</value>
        [DataMember(Name="issuerDN")]
        public string IssuerDN { get; set; }

        /// <summary>
        /// The Serial Number from the X.509v3 certificate in hex encoded format
        /// </summary>
        /// <value>The Serial Number from the X.509v3 certificate in hex encoded format</value>
        [DataMember(Name="serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The Distinguished Name from the X.509v3 certificate in printable string format
        /// </summary>
        /// <value>The Distinguished Name from the X.509v3 certificate in printable string format</value>
        [DataMember(Name="subjectDN")]
        public string SubjectDN { get; set; }

        /// <summary>
        /// The validity start date from the X.509v3 certificate in printable string format
        /// </summary>
        /// <value>The validity start date from the X.509v3 certificate in printable string format</value>
        [DataMember(Name="validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// The validity end date from the X.509v3 certificate in printable string format
        /// </summary>
        /// <value>The validity end date from the X.509v3 certificate in printable string format</value>
        [DataMember(Name="validTo")]
        public string ValidTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cert {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
            sb.Append("  IssuerDN: ").Append(IssuerDN).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SubjectDN: ").Append(SubjectDN).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Cert)obj);
        }

        /// <summary>
        /// Returns true if Cert instances are equal
        /// </summary>
        /// <param name="other">Instance of Cert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cert other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Certificates == other.Certificates ||
                    Certificates != null &&
                    Certificates.SequenceEqual(other.Certificates)
                ) && 
                (
                    IssuerDN == other.IssuerDN ||
                    IssuerDN != null &&
                    IssuerDN.Equals(other.IssuerDN)
                ) && 
                (
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    SubjectDN == other.SubjectDN ||
                    SubjectDN != null &&
                    SubjectDN.Equals(other.SubjectDN)
                ) && 
                (
                    ValidFrom == other.ValidFrom ||
                    ValidFrom != null &&
                    ValidFrom.Equals(other.ValidFrom)
                ) && 
                (
                    ValidTo == other.ValidTo ||
                    ValidTo != null &&
                    ValidTo.Equals(other.ValidTo)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Certificates != null)
                    hashCode = hashCode * 59 + Certificates.GetHashCode();
                    if (IssuerDN != null)
                    hashCode = hashCode * 59 + IssuerDN.GetHashCode();
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (SubjectDN != null)
                    hashCode = hashCode * 59 + SubjectDN.GetHashCode();
                    if (ValidFrom != null)
                    hashCode = hashCode * 59 + ValidFrom.GetHashCode();
                    if (ValidTo != null)
                    hashCode = hashCode * 59 + ValidTo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Cert left, Cert right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Cert left, Cert right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
