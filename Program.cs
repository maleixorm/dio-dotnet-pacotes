using dio_dotnet_pacotes.Models;
using System.Globalization;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1);

Console.WriteLine(serializado);