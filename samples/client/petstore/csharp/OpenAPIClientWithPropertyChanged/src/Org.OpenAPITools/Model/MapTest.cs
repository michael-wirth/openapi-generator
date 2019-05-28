/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MapTest
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class MapTest :  IEquatable<MapTest>, IValidatableObject
    {
        /// <summary>
        /// Defines Inner
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InnerEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower = 2

        }


        /// <summary>
        /// Gets or Sets MapOfEnumString
        /// </summary>
        [DataMember(Name="map_of_enum_string", EmitDefaultValue=false)]
        public Dictionary<string, InnerEnum> MapOfEnumString { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapTest" /> class.
        /// </summary>
        /// <param name="mapMapOfString">mapMapOfString.</param>
        /// <param name="mapOfEnumString">mapOfEnumString.</param>
        /// <param name="directMap">directMap.</param>
        /// <param name="indirectMap">indirectMap.</param>
        public MapTest(Dictionary<string, Dictionary<string, string>> mapMapOfString = default(Dictionary<string, Dictionary<string, string>>), Dictionary<string, InnerEnum> mapOfEnumString = default(Dictionary<string, InnerEnum>), Dictionary<string, bool?> directMap = default(Dictionary<string, bool?>), Dictionary<string, bool?> indirectMap = default(Dictionary<string, bool?>))
        {
            this.MapMapOfString = mapMapOfString;
            this.MapOfEnumString = mapOfEnumString;
            this.DirectMap = directMap;
            this.IndirectMap = indirectMap;
        }
        
        /// <summary>
        /// Gets or Sets MapMapOfString
        /// </summary>
        [DataMember(Name="map_map_of_string", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> MapMapOfString { get; set; }


        /// <summary>
        /// Gets or Sets DirectMap
        /// </summary>
        [DataMember(Name="direct_map", EmitDefaultValue=false)]
        public Dictionary<string, bool?> DirectMap { get; set; }

        /// <summary>
        /// Gets or Sets IndirectMap
        /// </summary>
        [DataMember(Name="indirect_map", EmitDefaultValue=false)]
        public Dictionary<string, bool?> IndirectMap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapTest {\n");
            sb.Append("  MapMapOfString: ").Append(MapMapOfString).Append("\n");
            sb.Append("  MapOfEnumString: ").Append(MapOfEnumString).Append("\n");
            sb.Append("  DirectMap: ").Append(DirectMap).Append("\n");
            sb.Append("  IndirectMap: ").Append(IndirectMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MapTest);
        }

        /// <summary>
        /// Returns true if MapTest instances are equal
        /// </summary>
        /// <param name="input">Instance of MapTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapTest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MapMapOfString == input.MapMapOfString ||
                    this.MapMapOfString != null &&
                    input.MapMapOfString != null &&
                    this.MapMapOfString.SequenceEqual(input.MapMapOfString)
                ) && 
                (
                    this.MapOfEnumString == input.MapOfEnumString ||
                    this.MapOfEnumString != null &&
                    input.MapOfEnumString != null &&
                    this.MapOfEnumString.SequenceEqual(input.MapOfEnumString)
                ) && 
                (
                    this.DirectMap == input.DirectMap ||
                    this.DirectMap != null &&
                    input.DirectMap != null &&
                    this.DirectMap.SequenceEqual(input.DirectMap)
                ) && 
                (
                    this.IndirectMap == input.IndirectMap ||
                    this.IndirectMap != null &&
                    input.IndirectMap != null &&
                    this.IndirectMap.SequenceEqual(input.IndirectMap)
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
                int hashCode = 41;
                if (this.MapMapOfString != null)
                    hashCode = hashCode * 59 + this.MapMapOfString.GetHashCode();
                if (this.MapOfEnumString != null)
                    hashCode = hashCode * 59 + this.MapOfEnumString.GetHashCode();
                if (this.DirectMap != null)
                    hashCode = hashCode * 59 + this.DirectMap.GetHashCode();
                if (this.IndirectMap != null)
                    hashCode = hashCode * 59 + this.IndirectMap.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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