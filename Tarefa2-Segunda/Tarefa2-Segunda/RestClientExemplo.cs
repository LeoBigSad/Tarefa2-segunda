using RestSharp;

namespace Tarefa2_Segunda
{
    public class RestClientExemplo
    {
        public static async Task CallRestApiWithRestClient()
        {
            var client = new RestClient("https://viacep.com.br/ws/13024050/json/");
            var request = new RestRequest();
            var response = await client.ExecuteAsync<ApiResponse>(request);

            if (response.IsSuccessful)
            {
                ApiResponse apiResponse = response.Data;
                Console.WriteLine($"Resposta do RestClient: Rua={apiResponse.Logradouro}, Bairro={apiResponse.Bairro}, Cidade={apiResponse.Localidade}");
            }
            else
            {
                Console.WriteLine("Falha ao pegar dados RestClient.");
            }
        }
    }
}
