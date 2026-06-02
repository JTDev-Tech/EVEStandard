using System;
using System.Text.Json.Serialization;

namespace EVEStandard.Models
{
    /// <summary>
    /// Corporation project information
    /// </summary>
    public class CorporationProject : ModelBase<CorporationProject>
    {
        public class _Reward
        {
            [JsonPropertyName("initial")]
            public double Initial { get; set; }

            [JsonPropertyName("remaining")]
            public double Remaining { get; set; }
        }

        public class _Progress
        {
            [JsonPropertyName("current")]
            public long Current { get; set; }

            [JsonPropertyName("desired")]
            public long Desired { get; set; }
        }

        #region Properties

        /// <summary>
        /// Unique identifier for this project
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("last_modified")]
        public DateTime LastModified { get; set; }

        [JsonPropertyName("progress")]
        public _Progress Progress { get; set; }

        [JsonPropertyName("reward")]
        public _Reward Reward { get; set; }

        #endregion Properties
    }
}
