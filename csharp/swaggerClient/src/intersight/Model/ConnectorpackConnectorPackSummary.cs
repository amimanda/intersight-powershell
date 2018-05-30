/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 0.1.0-559
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = intersight.Client.SwaggerDateConverter;

namespace intersight.Model
{
    /// <summary>
    /// ConnectorpackConnectorPackSummary
    /// </summary>
    [DataContract]
    public partial class ConnectorpackConnectorPackSummary :  IEquatable<ConnectorpackConnectorPackSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorpackConnectorPackSummary" /> class.
        /// </summary>
        /// <param name="DownloadedVersion">Downloaded version of connector pack image in UCS Director  .</param>
        /// <param name="Name">Name of connector pack running in UCS Director  .</param>
        /// <param name="Version">Running connector pack version in UCS Director   .</param>
        public ConnectorpackConnectorPackSummary(string DownloadedVersion = default(string), string Name = default(string), string Version = default(string))
        {
            this.DownloadedVersion = DownloadedVersion;
            this.Name = Name;
            this.Version = Version;
        }
        
        /// <summary>
        /// Downloaded version of connector pack image in UCS Director  
        /// </summary>
        /// <value>Downloaded version of connector pack image in UCS Director  </value>
        [DataMember(Name="DownloadedVersion", EmitDefaultValue=false)]
        public string DownloadedVersion { get; set; }

        /// <summary>
        /// Name of connector pack running in UCS Director  
        /// </summary>
        /// <value>Name of connector pack running in UCS Director  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Running connector pack version in UCS Director   
        /// </summary>
        /// <value>Running connector pack version in UCS Director   </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorpackConnectorPackSummary {\n");
            sb.Append("  DownloadedVersion: ").Append(DownloadedVersion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConnectorpackConnectorPackSummary);
        }

        /// <summary>
        /// Returns true if ConnectorpackConnectorPackSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectorpackConnectorPackSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorpackConnectorPackSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DownloadedVersion == other.DownloadedVersion ||
                    this.DownloadedVersion != null &&
                    this.DownloadedVersion.Equals(other.DownloadedVersion)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DownloadedVersion != null)
                    hash = hash * 59 + this.DownloadedVersion.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}