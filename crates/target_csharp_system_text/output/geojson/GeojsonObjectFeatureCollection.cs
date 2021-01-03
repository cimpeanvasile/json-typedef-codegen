
using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace JtdCodegenE2E
{
    /// <summary>
    /// A GeoJSON object with the type "FeatureCollection" is a
    /// FeatureCollection object.  A FeatureCollection object has a member
    /// with the name "features".  The value of "features" is a JSON array.
    /// Each element of the array is a Feature object as defined above.  It
    /// is possible for this array to be empty.
    /// </summary>

    public class GeojsonObjectFeatureCollection : GeojsonObject
    {
        [JsonPropertyName("type")]
        public string Type_ { get => "FeatureCollection"; }

        /// <summary>

        /// </summary>

        [JsonPropertyName("features")]
        public IList<GeojsonObject> Features { get; set; }

    }
}