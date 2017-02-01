/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// Advanced options for &#x60;thumbnail&#x60; type.
    /// </summary>
    [DataContract]
    public partial class JobThumbnailOutputPayloadAdvanced :  IEquatable<JobThumbnailOutputPayloadAdvanced>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobThumbnailOutputPayloadAdvanced" /> class.
        /// </summary>
        /// <param name="Width">Set the width. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;..</param>
        /// <param name="Height">Set the height. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;..</param>
        public JobThumbnailOutputPayloadAdvanced(int? Width = null, int? Height = null)
        {
            this.Width = Width;
            this.Height = Height;
        }
        
        /// <summary>
        /// Set the width. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;.
        /// </summary>
        /// <value>Set the width. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
        /// <summary>
        /// Set the height. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;.
        /// </summary>
        /// <value>Set the height. Possible values are &#x60;100&#x60;, &#x60;200&#x60; and &#x60;400&#x60;.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobThumbnailOutputPayloadAdvanced {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(obj as JobThumbnailOutputPayloadAdvanced);
        }

        /// <summary>
        /// Returns true if JobThumbnailOutputPayloadAdvanced instances are equal
        /// </summary>
        /// <param name="other">Instance of JobThumbnailOutputPayloadAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobThumbnailOutputPayloadAdvanced other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
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
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                return hash;
            }
        }
    }

}
