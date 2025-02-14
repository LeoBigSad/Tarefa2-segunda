using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tarefa2_Segunda
{
    public class ApiResponse
    {
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }
    }

}
