using ProductManagement;
using System;
using System.Collections;

namespace ArrayListDemo;

public class ProductOperations
{
    private List<Object> products = new List<object>();

    public List<Object> Products { get { return products; } }

    public bool AddProduct(Product p)
    {
        Products.Add(p);
        return true;
    }
    public bool RemoveProduct(int prodId)
    {
        Product proToRemove = null;
        foreach (Product item in Products)
        {
            if (item.ProdId == prodId)
            {
                proToRemove = item;
                break;
            }
        }

        if (proToRemove != null)
        {
            Products.Remove(proToRemove);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool UpdateProduct(Product p, int prodId)
    {
        bool ProductFound = false;
        for (int i = 0; i < Products.Count; i++)
        {
            Product item = (Product)Products[i];
            if (item.ProdId == prodId)
            {
                ProductFound = true;
                Products[i] = p;
                break;
            }
        }
        return ProductFound;
    }

    public Product GetProduct(int prodId)
    {
        foreach (Product item in Products)
        {
            if (item.ProdId == prodId)
            {
                return item;
            }
        }
        return null;
    }
}


