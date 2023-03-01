using System;
using WCFSample.Models;

public class Service : IService {
    public int AddProduct(Product prod) {
        // Write to DB
        //return prod.Id;

        return 7;
    }

    public int AddProductByFields(int id, string name) {
        return 77;
    }

    public int MathAdd(int num1, int num2) {
        return num1 + num2;
    }

    public int MathSquare(int num) {
        return num * num;
    }
}
