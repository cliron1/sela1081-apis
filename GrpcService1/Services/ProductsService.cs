using Grpc.Core;
using GrpcProducts;

namespace GrpcService1.Services;

public class ProductsService: ProductsManager.ProductsManagerBase {
    private readonly ILogger<ProductsService> logger;

    public ProductsService(ILogger<ProductsService> logger) {
        this.logger = logger;
    }

    public override Task<Product> GetProduct(IdReq request, ServerCallContext context) {
        //var item = data.Find(request.Id);
        return Task.FromResult(new Product {
            ID = request.Id,
            Name = "Keyboard",
            Price = 60
        });
    }
}
