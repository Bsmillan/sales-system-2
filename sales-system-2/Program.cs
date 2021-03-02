using System;
using sales_system_2;

namespace sales_system_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BranchOffice
            BranchOffice BranchOffice = new BranchOffice();


            //Sellers
            Seller s1 = new Seller();
            s1.Name = "Juan";
            s1.Age = 35;
            BranchOffice.AddSeller(s1);

            Seller s2 = new Seller();
            s2.Name = "Andrea";
            s2.Age = 28;
            BranchOffice.AddSeller(s2);

            Seller s3 = new Seller();
            s3.Name = "Felipe";
            s3.Age = 45;
            BranchOffice.AddSeller(s3);

            //Products
            Product p1 = new Product();
            p1.Name = "Samsung P10";
            p1.Price = 500f;
            BranchOffice.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "Xiaomi A5";
            p2.Price = 300f;
            BranchOffice.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "Battery 4000Ma";
            p3.Price = 150f;
            BranchOffice.AddProduct(p3);

            //Sales
            Sale Sale1 = new Sale();
            Sale1.Product = p1;
            Sale1.Seller = s1;
            Sale1.Comments = "Phone Samsung P10, 1 year warranty, cash payment.";
            BranchOffice.AddSale(Sale1);

            Sale Sale2 = new Sale();
            Sale2.Product = p2;
            Sale2.Seller = s2;
            Sale1.Comments = "Phone Xiaomi A5, 1 year warranty, credit payment, deferred 4 dues.";
            BranchOffice.AddSale(Sale2);

            Sale Sale3 = new Sale();
            Sale3.Product = p3;
            Sale3.Seller = s3;
            Sale3.Comments = "Battery 4000Ma for Nokia S850, 3 months warranty, cash payment.";
            BranchOffice.AddSale(Sale3);

            //Print of seller whit the sale cheapest 
            String NameSeller = BranchOffice.NameSellerCheapest();
            System.Console.WriteLine("The name of seller whit the sale cheapest is: " + NameSeller);

            //Print products price average 
            float PriceAverage = BranchOffice.PriceAverage();
            System.Console.WriteLine("The products price average is: $" + PriceAverage);

            //Print How many unit of the product has been sold. 
            int ManyUnits = BranchOffice.QuantitySoldProductsUnit();
            System.Console.WriteLine("The many unit of the product has been sold is: " + ManyUnits);

            //Print of most expensive product
            String NameProduct = BranchOffice.MostExpensiveProduct();
            System.Console.WriteLine("The most expensive product is: " + NameProduct);
        }
    }
}