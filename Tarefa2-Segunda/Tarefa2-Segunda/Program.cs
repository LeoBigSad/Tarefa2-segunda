using System.Text.Json;
using Tarefa2_Segunda;
using Tarefa2_Segunda.Tarefa2_Segunda;
using BibliotecaDeClassesTeste;
class Program
{
    static async Task Main()
    {
        #region  1 - Serialização de classes em JSON 

        Pessoa NovaPessoa = new Pessoa("Leonardo Tristao", 20, "Vagabundo");
        string JsonPessoa = JsonSerializer.Serialize(NovaPessoa, new JsonSerializerOptions { WriteIndented = true });
        if (JsonPessoa != null)
        {
            Console.WriteLine("\nObjeto Serializado:");
            Console.WriteLine(JsonPessoa);
        }
        else
        {
            Console.WriteLine("Falha na serialização do objeto.");
        }

        #endregion

        #region  2 - Deserialização de JSON em classes

        Pessoa? pessoaDeserializada = JsonSerializer.Deserialize<Pessoa>(JsonPessoa);
        if (pessoaDeserializada != null)
        {
            Console.WriteLine("\nObjeto Desserializado:");
            Console.WriteLine($"Nome: {pessoaDeserializada.Nome}, Idade: {pessoaDeserializada.Idade}, Profissao: {pessoaDeserializada.Profissao}");
        }
        else
        {
            Console.WriteLine("Falha na desserialização do JSON.");
        }

        #endregion

        #region 3 - DTO e Mapper

        PessoaDTO pessoaDto = ExemploMapper.MapToDto(NovaPessoa);
        Console.WriteLine($"\nDTO Mapeado: NomeCompleto={pessoaDto.NomeCompleto}, IdadeEmTexto={pessoaDto.IdadeEmTexto}, Profissao={pessoaDto.Profissao}");

        #endregion

        #region  4 - Chamada REST - HttpClient

        await HttpClientExemplo.CallRestApiWithHttpClient();

        #endregion

        #region  5 - Chamada REST - RestClient

        await RestClientExemplo.CallRestApiWithRestClient();

        #endregion

        #region 6 - Conversão de Data

        ManipularData.ConvertDate();

        #endregion

        #region 7 - Calculos Data

        ManipularData.CalculateDateDifference();

        #endregion

        #region 8 - Biblioteca de classes

        Console.WriteLine("Apos adicionar a biblioteca de classes, o arquivo .csproj foi alterado para incluir a referencia da biblioteca de classes.");

        #endregion

    }
}