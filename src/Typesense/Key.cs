using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Typesense
{
    public record Key
    {
        [JsonPropertyName("description")]
        public string Description { get; init; }
        [JsonPropertyName("actions")]
        public IEnumerable<string> Actions { get; init; }
        [JsonPropertyName("collections")]
        public IEnumerable<string> Collections { get; init; }
        [JsonPropertyName("value")]
        public string Value { get; init; }
        [JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; init; }
    }
}