using Newtonsoft.Json;

namespace BasicClient
{
    public record ApiResult<T>
    {
        public int Count { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("results")]
        public T Data { get; set; }
    }
}
