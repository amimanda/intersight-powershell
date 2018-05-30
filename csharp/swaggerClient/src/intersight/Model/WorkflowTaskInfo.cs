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
    /// This MO contains information for a task instance 
    /// </summary>
    [DataContract]
    public partial class WorkflowTaskInfo :  IEquatable<WorkflowTaskInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskInfo" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="Descr">The task description  .</param>
        /// <param name="EndTime">The task starts time  .</param>
        /// <param name="FailureReason">The reason for failure  .</param>
        /// <param name="Input">The input of the task  .</param>
        /// <param name="InstId">The current running task instance Id  .</param>
        /// <param name="Name">A task type  .</param>
        /// <param name="Output">The output of the task  .</param>
        /// <param name="RefName">The task reference name to ensure its unique inside a workflow  .</param>
        /// <param name="RetryCount">A counter for number of retries  .</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="Status">The status of the task  .</param>
        /// <param name="TaskInstIdList">The list keeps a list of retried task instances   .</param>
        /// <param name="WorkflowInfo">WorkflowInfo.</param>
        public WorkflowTaskInfo(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), string Descr = default(string), DateTime? EndTime = default(DateTime?), string FailureReason = default(string), Object Input = default(Object), string InstId = default(string), string Name = default(string), Object Output = default(Object), string RefName = default(string), long? RetryCount = default(long?), DateTime? StartTime = default(DateTime?), string Status = default(string), List<WorkflowTaskRetryInfo> TaskInstIdList = default(List<WorkflowTaskRetryInfo>), WorkflowWorkflowInfoRef WorkflowInfo = default(WorkflowWorkflowInfoRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.Descr = Descr;
            this.EndTime = EndTime;
            this.FailureReason = FailureReason;
            this.Input = Input;
            this.InstId = InstId;
            this.Name = Name;
            this.Output = Output;
            this.RefName = RefName;
            this.RetryCount = RetryCount;
            this.StartTime = StartTime;
            this.Status = Status;
            this.TaskInstIdList = TaskInstIdList;
            this.WorkflowInfo = WorkflowInfo;
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
        /// The task description  
        /// </summary>
        /// <value>The task description  </value>
        [DataMember(Name="Descr", EmitDefaultValue=false)]
        public string Descr { get; set; }

        /// <summary>
        /// The task starts time  
        /// </summary>
        /// <value>The task starts time  </value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The reason for failure  
        /// </summary>
        /// <value>The reason for failure  </value>
        [DataMember(Name="FailureReason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }

        /// <summary>
        /// The input of the task  
        /// </summary>
        /// <value>The input of the task  </value>
        [DataMember(Name="Input", EmitDefaultValue=false)]
        public Object Input { get; set; }

        /// <summary>
        /// The current running task instance Id  
        /// </summary>
        /// <value>The current running task instance Id  </value>
        [DataMember(Name="InstId", EmitDefaultValue=false)]
        public string InstId { get; set; }

        /// <summary>
        /// A task type  
        /// </summary>
        /// <value>A task type  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The output of the task  
        /// </summary>
        /// <value>The output of the task  </value>
        [DataMember(Name="Output", EmitDefaultValue=false)]
        public Object Output { get; set; }

        /// <summary>
        /// The task reference name to ensure its unique inside a workflow  
        /// </summary>
        /// <value>The task reference name to ensure its unique inside a workflow  </value>
        [DataMember(Name="RefName", EmitDefaultValue=false)]
        public string RefName { get; set; }

        /// <summary>
        /// A counter for number of retries  
        /// </summary>
        /// <value>A counter for number of retries  </value>
        [DataMember(Name="RetryCount", EmitDefaultValue=false)]
        public long? RetryCount { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The status of the task  
        /// </summary>
        /// <value>The status of the task  </value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The list keeps a list of retried task instances   
        /// </summary>
        /// <value>The list keeps a list of retried task instances   </value>
        [DataMember(Name="TaskInstIdList", EmitDefaultValue=false)]
        public List<WorkflowTaskRetryInfo> TaskInstIdList { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInfo
        /// </summary>
        [DataMember(Name="WorkflowInfo", EmitDefaultValue=false)]
        public WorkflowWorkflowInfoRef WorkflowInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTaskInfo {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Descr: ").Append(Descr).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  RefName: ").Append(RefName).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskInstIdList: ").Append(TaskInstIdList).Append("\n");
            sb.Append("  WorkflowInfo: ").Append(WorkflowInfo).Append("\n");
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
            return this.Equals(obj as WorkflowTaskInfo);
        }

        /// <summary>
        /// Returns true if WorkflowTaskInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowTaskInfo other)
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
                    this.Descr == other.Descr ||
                    this.Descr != null &&
                    this.Descr.Equals(other.Descr)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) && 
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) && 
                (
                    this.InstId == other.InstId ||
                    this.InstId != null &&
                    this.InstId.Equals(other.InstId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
                ) && 
                (
                    this.RefName == other.RefName ||
                    this.RefName != null &&
                    this.RefName.Equals(other.RefName)
                ) && 
                (
                    this.RetryCount == other.RetryCount ||
                    this.RetryCount != null &&
                    this.RetryCount.Equals(other.RetryCount)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TaskInstIdList == other.TaskInstIdList ||
                    this.TaskInstIdList != null &&
                    this.TaskInstIdList.SequenceEqual(other.TaskInstIdList)
                ) && 
                (
                    this.WorkflowInfo == other.WorkflowInfo ||
                    this.WorkflowInfo != null &&
                    this.WorkflowInfo.Equals(other.WorkflowInfo)
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
                if (this.Descr != null)
                    hash = hash * 59 + this.Descr.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                if (this.InstId != null)
                    hash = hash * 59 + this.InstId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
                if (this.RefName != null)
                    hash = hash * 59 + this.RefName.GetHashCode();
                if (this.RetryCount != null)
                    hash = hash * 59 + this.RetryCount.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TaskInstIdList != null)
                    hash = hash * 59 + this.TaskInstIdList.GetHashCode();
                if (this.WorkflowInfo != null)
                    hash = hash * 59 + this.WorkflowInfo.GetHashCode();
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
