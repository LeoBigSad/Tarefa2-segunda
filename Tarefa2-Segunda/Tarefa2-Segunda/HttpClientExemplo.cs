using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2_Segunda
{
    using System.Net.Http;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using System;

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

        public class HttpClientExemplo
        {
            public static async Task CallRestApiWithHttpClient()
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string apiUrl = "https://viacep.com.br/ws/13024050/json/";
                        HttpResponseMessage response = await client.GetAsync(apiUrl).ConfigureAwait(false);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            ApiResponse? apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonString);

                            if (apiResponse != null)
                            {
                                Console.WriteLine($"\nResposta da API: Rua={apiResponse.Logradouro}, Bairro={apiResponse.Bairro}, Cidade={apiResponse.Localidade}");
                            }
                            else
                            {
                                Console.WriteLine("Erro: A resposta da API veio vazia.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Falha ao obter dados. Código HTTP: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao chamar API: {ex.Message}");
                    }
                }
            }
        }
    }

}
