using System.Collections.Generic;

public class Compectation
{
    private List<ProductData> _products = new List<ProductData>();

    public void Add(ProductData product)
    {
        _products.Add(product);
    }
    public string[] GetPurchaseData()
    {
        string[] data = new string[_products.Count];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = "Name: " + _products[i].Name + " || " + _products[i].Stars.ToString();
        }
        return data;
    }
}
