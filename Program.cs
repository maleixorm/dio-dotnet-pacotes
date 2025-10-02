using dio_dotnet_pacotes.Models;
using System.Globalization;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

string conteudoArquivo = File.ReadAllText("Arquivos/compras.json");

List<Compra> listaCompra = JsonConvert.DeserializeObject<List<Compra>>(conteudoArquivo);

foreach (Compra compra in listaCompra)
{
    Console.WriteLine($"Id: {compra.Id}, Produto: {compra.Produto}, Preço: {compra.Preco}, Data: {compra.DataCompra.ToString("dd/MM/yyyy HH:mm")}");
}