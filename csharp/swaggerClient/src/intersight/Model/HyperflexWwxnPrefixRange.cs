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
    /// WWxN range 
    /// </summary>
    [DataContract]
    public partial class HyperflexWwxnPrefixRange :  IEquatable<HyperflexWwxnPrefixRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexWwxnPrefixRange" /> class.
        /// </summary>
        /// <param name="EndAddr">End WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX  .</param>
        /// <param name="StartAddr">Start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX   .</param>
        public HyperflexWwxnPrefixRange(string EndAddr = default(string), string StartAddr = default(string))
        {
            this.EndAddr = EndAddr;
            this.StartAddr = StartAddr;
        }
        
        /// <summary>
        /// End WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX  
        /// </summary>
        /// <value>End WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX  </value>
        [DataMember(Name="EndAddr", EmitDefaultValue=false)]
        public string EndAddr { get; set; }

        /// <summary>
        /// Start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX   
        /// </summary>
        /// <value>Start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX   </value>
        [DataMember(Name="StartAddr", EmitDefaultValue=false)]
        public string StartAddr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexWwxnPrefixRange {\n");
            sb.Append("  EndAddr: ").Append(EndAddr).Append("\n");
            sb.Append("  StartAddr: ").Append(StartAddr).Append("\n");
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
            return this.Equals(obj as HyperflexWwxnPrefixRange);
        }

        /// <summary>
        /// Returns true if HyperflexWwxnPrefixRange instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexWwxnPrefixRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexWwxnPrefixRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndAddr == other.EndAddr ||
                    this.EndAddr != null &&
                    this.EndAddr.Equals(other.EndAddr)
                ) && 
                (
                    this.StartAddr == other.StartAddr ||
                    this.StartAddr != null &&
                    this.StartAddr.Equals(other.StartAddr)
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
                if (this.EndAddr != null)
                    hash = hash * 59 + this.EndAddr.GetHashCode();
                if (this.StartAddr != null)
                    hash = hash * 59 + this.StartAddr.GetHashCode();
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
