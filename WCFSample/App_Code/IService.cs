using System.ServiceModel;
using WCFSample.Models;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService {

    [OperationContract]
    int MathSquare(int num);

    [OperationContract]
    int MathAdd(int num1, int num2);

    [OperationContract]
    int AddProduct(Product prod);

    [OperationContract]
    int AddProductByFields(int id, string name);
}