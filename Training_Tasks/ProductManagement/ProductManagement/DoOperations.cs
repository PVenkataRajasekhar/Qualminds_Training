using ProductManagement;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace ArrayListDemo;

public class DoOperations
{
    ProductOperations p = new ProductOperations();
    static int CreateId(List<Object> Products)
    {
        // EmployeeOperations employees = new EmployeeOperations();
        return Products.Count + 1;
    }

    public void Add()
    {
        Console.WriteLine("Enter product Id : ");
        int id =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Enter Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter price :");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter image");
        string image = Console.ReadLine();
        Product product = new Product( id, description,price,image);
        if (p.AddProduct(product))
        {
            Console.WriteLine("Added successfully.");
        }
    }
    public void Remove()
    {
        Console.WriteLine("Enter Product Id : ");
        int prodId = Convert.ToInt32(Console.ReadLine());
        if (p.RemoveProduct(prodId))
        {
            Console.WriteLine("Removed successfully.");
        }
        else
        {
            Console.WriteLine("Failed to Remove");
        }
    }
    public void UserOption()
    {
        Console.WriteLine("Enter 1 to update only Product Id");
        Console.WriteLine("Enter 2 to update only Description");
        Console.WriteLine("Enter 3 to update only Price");
        Console.WriteLine("Enter 4 to update only Image");
        Console.WriteLine("Enter 5 to update All");
    }
    public void Update()
    {

        UserOption();
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 5)
        {
            Console.WriteLine("Enter Product Id : ");
            int prodId = Convert.ToInt32(Console.ReadLine());

            Product prevProduct = p.GetProduct(prodId);
            if (prevProduct == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            else
            {
                Console.WriteLine("Enter new Product Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Description : ");
                string Description = Console.ReadLine();
                Console.WriteLine("Enter Product price : ");
                decimal Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Product Image : ");
                string Image = Console.ReadLine();


                Product newProduct = new Product(Id, Description, Price, Image);
                if (p.UpdateProduct(newProduct, prodId))
                {
                    Console.WriteLine("Updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
        }
        else if(n == 1)
        {
            Console.WriteLine("Enter Product Id : ");
            int prodId = Convert.ToInt32(Console.ReadLine());
            Product prevProduct = p.GetProduct(prodId);
            if (prevProduct == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            Console.WriteLine("Enter new Product Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            string Description = prevProduct.Description;
            decimal Price = prevProduct.Price;
            string Image = prevProduct.Image;
            Product newProduct = new Product(Id, Description, Price, Image);
            if (p.UpdateProduct(newProduct, prodId))
            {
                Console.WriteLine("Updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update");
            }
        }
        else if (n == 2)
        {
            Console.WriteLine("Enter Product Id : ");
            int prodId = Convert.ToInt32(Console.ReadLine());
            Product prevProduct = p.GetProduct(prodId);
            if (prevProduct == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            int Id = prevProduct.ProdId;
            Console.WriteLine("enter description to Update");
            string Description = Console.ReadLine();
            decimal Price = prevProduct.Price;
            string Image = prevProduct.Image;
            Product newProduct = new Product(Id, Description, Price, Image);
            if (p.UpdateProduct(newProduct, prodId))
            {
                Console.WriteLine("Updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update");
            }
        }
        else if (n == 3)
        {
            Console.WriteLine("Enter Product Id : ");
            int prodId = Convert.ToInt32(Console.ReadLine());
            Product prevProduct = p.GetProduct(prodId);
            if (prevProduct == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            int Id = prevProduct.ProdId;
            string Description = prevProduct.Description;
            Console.WriteLine("enter new price to update");
            decimal Price = Convert.ToDecimal(Console.ReadLine());
            string Image = prevProduct.Image;
            Product newProduct = new Product(Id, Description, Price, Image);
            if (p.UpdateProduct(newProduct, prodId))
            {
                Console.WriteLine("Updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update");
            }
        }
        else if (n == 4)
        {
            Console.WriteLine("Enter Product Id : ");
            int prodId = Convert.ToInt32(Console.ReadLine());
            Product prevProduct = p.GetProduct(prodId);
            if (prevProduct == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            int Id = prevProduct.ProdId;
            string Description = prevProduct.Description;
            decimal Price = prevProduct.Price;
            Console.WriteLine("Enter new Image to Update");
            string Image = Console.ReadLine();
            Product newProduct = new Product(Id, Description, Price, Image);
            if (p.UpdateProduct(newProduct, prodId))
            {
                Console.WriteLine("Updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update");
            }
        }
    }
    public void GetAll()
    {
        foreach (Product product in p.Products)
        {
            Console.WriteLine($"Product Id : {product.ProdId}");
            Console.WriteLine($"Description : {product.Description}");
            Console.WriteLine($"Product Price : {product.Price}");
            Console.WriteLine($"Product Image :{product.Image}");
            Console.WriteLine("--------------------------------------");
        }
    }
}

