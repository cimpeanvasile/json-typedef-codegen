
using System.Text.Json.Serialization;

namespace JtdCodegenE2E
{
    /// <summary>

    /// </summary>

    public class RootBar : Root
    {
        [JsonPropertyName("foo")]
        public string Foo { get => "bar"; }

        /// <summary>

        /// </summary>

        [JsonPropertyName("baz")]
        public string Baz { get; set; }

    }
}
