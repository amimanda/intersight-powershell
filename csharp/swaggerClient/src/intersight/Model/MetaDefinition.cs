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
    /// Definition of the meta class for a particular version of service. 
    /// </summary>
    [DataContract]
    public partial class MetaDefinition :  IEquatable<MetaDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaDefinition" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="AncestorClasses">An array of parent metaclasses in the class inheritance hierarchy. The first element in the array is the parent class. The next element is the grand-parent, etc. The last element in the array is the mo.BaseMo class.   .</param>
        /// <param name="Properties">Meta definition for the properties in the meta class and from all classes in the inheritance hierarchy.  .</param>
        /// <param name="Relationships">Meta definition for the relationship in the meta class.  .</param>
        public MetaDefinition(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), List<string> AncestorClasses = default(List<string>), List<MetaPropDefinition> Properties = default(List<MetaPropDefinition>), List<MetaRelationshipDefinition> Relationships = default(List<MetaRelationshipDefinition>))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.AncestorClasses = AncestorClasses;
            this.Properties = Properties;
            this.Relationships = Relationships;
        }
        
        /// <summary>
        /// The Account ID for this managed object.  
        /// </summary>
        /// <value>The Account ID for this managed object.  </value>
        [DataMember(Name="AccountMoid", EmitDefaultValue=false)]
        public string AccountMoid { get; private set; }

        /// <summary>
        /// Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. 
        /// </summary>
        /// <value>Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. </value>
        [DataMember(Name="Ancestors", EmitDefaultValue=false)]
        public List<MoBaseMoRef> Ancestors { get; set; }

        /// <summary>
        /// The time when this managed object was created.  
        /// </summary>
        /// <value>The time when this managed object was created.  </value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; private set; }

        /// <summary>
        /// The time when this managed object was last modified.  
        /// </summary>
        /// <value>The time when this managed object was last modified.  </value>
        [DataMember(Name="ModTime", EmitDefaultValue=false)]
        public DateTime? ModTime { get; private set; }

        /// <summary>
        /// A unique identifier of this Managed Object instance.  
        /// </summary>
        /// <value>A unique identifier of this Managed Object instance.  </value>
        [DataMember(Name="Moid", EmitDefaultValue=false)]
        public string Moid { get; set; }

        /// <summary>
        /// The fully-qualified type of this managed object, e.g. the class name.  
        /// </summary>
        /// <value>The fully-qualified type of this managed object, e.g. the class name.  </value>
        [DataMember(Name="ObjectType", EmitDefaultValue=false)]
        public string ObjectType { get; private set; }

        /// <summary>
        /// An array of owners which represent effective ownership of this object.   
        /// </summary>
        /// <value>An array of owners which represent effective ownership of this object.   </value>
        [DataMember(Name="Owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// The direct ancestor of this managed object in the containment hierarchy. 
        /// </summary>
        /// <value>The direct ancestor of this managed object in the containment hierarchy. </value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public MoBaseMoRef Parent { get; set; }

        /// <summary>
        /// An array of tags, which allow to add key, value meta-data to managed objects.   
        /// </summary>
        /// <value>An array of tags, which allow to add key, value meta-data to managed objects.   </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// An array of parent metaclasses in the class inheritance hierarchy. The first element in the array is the parent class. The next element is the grand-parent, etc. The last element in the array is the mo.BaseMo class.   
        /// </summary>
        /// <value>An array of parent metaclasses in the class inheritance hierarchy. The first element in the array is the parent class. The next element is the grand-parent, etc. The last element in the array is the mo.BaseMo class.   </value>
        [DataMember(Name="AncestorClasses", EmitDefaultValue=false)]
        public List<string> AncestorClasses { get; set; }

        /// <summary>
        /// Boolean flag to specify whether the meta class is defined in a separate micro-service.  
        /// </summary>
        /// <value>Boolean flag to specify whether the meta class is defined in a separate micro-service.  </value>
        [DataMember(Name="ExternalType", EmitDefaultValue=false)]
        public bool? ExternalType { get; private set; }

        /// <summary>
        /// Boolean flag to specify whether this class is a concrete class or not.  
        /// </summary>
        /// <value>Boolean flag to specify whether this class is a concrete class or not.  </value>
        [DataMember(Name="IsConcrete", EmitDefaultValue=false)]
        public bool? IsConcrete { get; private set; }

        /// <summary>
        /// The fully-qualified name of the meta class. For example, \&quot;compute:Blade\&quot; where the Managed Object is \&quot;Blade\&quot; and the package is &#39;compute&#39;.  
        /// </summary>
        /// <value>The fully-qualified name of the meta class. For example, \&quot;compute:Blade\&quot; where the Managed Object is \&quot;Blade\&quot; and the package is &#39;compute&#39;.  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Namespace of the meta class.  
        /// </summary>
        /// <value>Namespace of the meta class.  </value>
        [DataMember(Name="Namespace", EmitDefaultValue=false)]
        public string _Namespace { get; private set; }

        /// <summary>
        /// Boolean flag to subscribe for mo change notifications if this meta class is an external type.  
        /// </summary>
        /// <value>Boolean flag to subscribe for mo change notifications if this meta class is an external type.  </value>
        [DataMember(Name="Observe", EmitDefaultValue=false)]
        public bool? Observe { get; private set; }

        /// <summary>
        /// The fully-qualified name of the parent metaclass in the class inheritance hierarchy.  
        /// </summary>
        /// <value>The fully-qualified name of the parent metaclass in the class inheritance hierarchy.  </value>
        [DataMember(Name="ParentClass", EmitDefaultValue=false)]
        public string ParentClass { get; private set; }

        /// <summary>
        /// Meta definition for the properties in the meta class and from all classes in the inheritance hierarchy.  
        /// </summary>
        /// <value>Meta definition for the properties in the meta class and from all classes in the inheritance hierarchy.  </value>
        [DataMember(Name="Properties", EmitDefaultValue=false)]
        public List<MetaPropDefinition> Properties { get; set; }

        /// <summary>
        /// Meta definition for the relationship in the meta class.  
        /// </summary>
        /// <value>Meta definition for the relationship in the meta class.  </value>
        [DataMember(Name="Relationships", EmitDefaultValue=false)]
        public List<MetaRelationshipDefinition> Relationships { get; set; }

        /// <summary>
        /// Restful URL path for the meta class.  
        /// </summary>
        /// <value>Restful URL path for the meta class.  </value>
        [DataMember(Name="RestPath", EmitDefaultValue=false)]
        public string RestPath { get; private set; }

        /// <summary>
        /// Version of the service that defines the meta class.   
        /// </summary>
        /// <value>Version of the service that defines the meta class.   </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaDefinition {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  AncestorClasses: ").Append(AncestorClasses).Append("\n");
            sb.Append("  ExternalType: ").Append(ExternalType).Append("\n");
            sb.Append("  IsConcrete: ").Append(IsConcrete).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
            sb.Append("  Observe: ").Append(Observe).Append("\n");
            sb.Append("  ParentClass: ").Append(ParentClass).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  RestPath: ").Append(RestPath).Append("\n");
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
            return this.Equals(obj as MetaDefinition);
        }

        /// <summary>
        /// Returns true if MetaDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of MetaDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountMoid == other.AccountMoid ||
                    this.AccountMoid != null &&
                    this.AccountMoid.Equals(other.AccountMoid)
                ) && 
                (
                    this.Ancestors == other.Ancestors ||
                    this.Ancestors != null &&
                    this.Ancestors.SequenceEqual(other.Ancestors)
                ) && 
                (
                    this.CreateTime == other.CreateTime ||
                    this.CreateTime != null &&
                    this.CreateTime.Equals(other.CreateTime)
                ) && 
                (
                    this.ModTime == other.ModTime ||
                    this.ModTime != null &&
                    this.ModTime.Equals(other.ModTime)
                ) && 
                (
                    this.Moid == other.Moid ||
                    this.Moid != null &&
                    this.Moid.Equals(other.Moid)
                ) && 
                (
                    this.ObjectType == other.ObjectType ||
                    this.ObjectType != null &&
                    this.ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    this.Owners == other.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(other.Owners)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.AncestorClasses == other.AncestorClasses ||
                    this.AncestorClasses != null &&
                    this.AncestorClasses.SequenceEqual(other.AncestorClasses)
                ) && 
                (
                    this.ExternalType == other.ExternalType ||
                    this.ExternalType != null &&
                    this.ExternalType.Equals(other.ExternalType)
                ) && 
                (
                    this.IsConcrete == other.IsConcrete ||
                    this.IsConcrete != null &&
                    this.IsConcrete.Equals(other.IsConcrete)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this._Namespace == other._Namespace ||
                    this._Namespace != null &&
                    this._Namespace.Equals(other._Namespace)
                ) && 
                (
                    this.Observe == other.Observe ||
                    this.Observe != null &&
                    this.Observe.Equals(other.Observe)
                ) && 
                (
                    this.ParentClass == other.ParentClass ||
                    this.ParentClass != null &&
                    this.ParentClass.Equals(other.ParentClass)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.Relationships == other.Relationships ||
                    this.Relationships != null &&
                    this.Relationships.SequenceEqual(other.Relationships)
                ) && 
                (
                    this.RestPath == other.RestPath ||
                    this.RestPath != null &&
                    this.RestPath.Equals(other.RestPath)
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
                if (this.AccountMoid != null)
                    hash = hash * 59 + this.AccountMoid.GetHashCode();
                if (this.Ancestors != null)
                    hash = hash * 59 + this.Ancestors.GetHashCode();
                if (this.CreateTime != null)
                    hash = hash * 59 + this.CreateTime.GetHashCode();
                if (this.ModTime != null)
                    hash = hash * 59 + this.ModTime.GetHashCode();
                if (this.Moid != null)
                    hash = hash * 59 + this.Moid.GetHashCode();
                if (this.ObjectType != null)
                    hash = hash * 59 + this.ObjectType.GetHashCode();
                if (this.Owners != null)
                    hash = hash * 59 + this.Owners.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.AncestorClasses != null)
                    hash = hash * 59 + this.AncestorClasses.GetHashCode();
                if (this.ExternalType != null)
                    hash = hash * 59 + this.ExternalType.GetHashCode();
                if (this.IsConcrete != null)
                    hash = hash * 59 + this.IsConcrete.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Namespace != null)
                    hash = hash * 59 + this._Namespace.GetHashCode();
                if (this.Observe != null)
                    hash = hash * 59 + this.Observe.GetHashCode();
                if (this.ParentClass != null)
                    hash = hash * 59 + this.ParentClass.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Relationships != null)
                    hash = hash * 59 + this.Relationships.GetHashCode();
                if (this.RestPath != null)
                    hash = hash * 59 + this.RestPath.GetHashCode();
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
