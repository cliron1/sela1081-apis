using Grpc.Net.Client;
using GrpcProducts;
using MyApi;
using MyService;
using System.Text.Json;

namespace WcfConsoleClient;

class Program {
    static async Task Main(string[] args) {
        Console.WriteLine("Hello, World!");

        #region Grpc Stuff
        /*
        var channel = GrpcChannel.ForAddress("http://localhost:5193");

        var client = new ProductsManager.ProductsManagerClient(channel);
        var prod = await client.GetProductAsync(new IdReq { Id = 5 });
        Console.WriteLine(prod.Name);
        Console.ReadKey();
        */
        #endregion

        #region RestAPI
        //var client = new MyApiClient("https://localhost:7023", new HttpClient());
        //var items = await client.GetWeatherForecastAsync(3, null, null);
        //foreach (var item in items) {
        //    await Console.Out.WriteLineAsync(item.Summary);
        //};
        //Console.ReadKey();

        var url = "https://localhost:7023/weatherforecast?days=3";

        using HttpClient client = new();
        var json = await client.GetStringAsync(url);

        var items = json.FromJson<List<WeatherForecast>>();

        foreach(var item in items)
            await Console.Out.WriteLineAsync(item.Summary);

        await Console.Out.WriteLineAsync("All done!");
        #endregion

        #region WCF stuff
        /*
        var client = new ServiceClient();

        var result = client.MathSquare(new MathSquareRequest(42));
        Console.WriteLine($"result = {result.MathSquareResult}");

        var prod = new Product { Id = 1, Name = "Keyboard" };

        var result2 = client.AddProduct(new AddProductRequest(prod));
        Console.WriteLine($"result2 = {result2.AddProductResult}");

        var result3 = client.AddProductByFields(new AddProductByFieldsRequest {
            name = "Mouse",
            id = 2,
        });
        Console.WriteLine($"result3 = {result3.AddProductByFieldsResult}");


        // Always close the client.
        client.Close();

        */
        #endregion
    }
}
