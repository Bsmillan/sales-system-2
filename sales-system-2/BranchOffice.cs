using System;
using System.Collections.Generic;
using System.Text;
using sales_system_2;

namespace sales_system_2
{
    class BranchOffice
    {
        Product[] Product = new Product[10];
        int ProductCount = 0;

        Sale[] Sale = new Sale[10];
        int SaleCount = 0;

        Seller[] Seller = new Seller[10];
        int SellerCount = 0;
        
        public void AddProduct(Product NewProduct)
        {
            Product[ProductCount] = NewProduct;
            ProductCount++;
        }

        public void AddSale(Sale NewSale)
        {
            Sale[SaleCount] = NewSale;
            SaleCount++;
        }

        public void AddSeller(Seller NewSeller)
        {
            Seller[SellerCount] = NewSeller;
            SellerCount++;
        }

        //Who's the seller (sales man name), who has sold the cheapest product.
        public String NameSellerCheapest()
        {
            int count = 0;
            float PriceCheapest = 500000;
            String NameSeller = "";
            for (int i = 0; i < SaleCount; i++){
                
                if(Sale[i].Product.Price < PriceCheapest)
                    {
                    PriceCheapest = Sale[i].Product.Price;
                    NameSeller = Sale[i].Seller.Name;
                }
            }            
            return NameSeller;
        }

        //Products price average.
        public float PriceAverage()
        {
            int count = 0;
            float total = 0;
            float average = 0;
            for (int i = 0; i < ProductCount; i++)
            {
                count++;
                total = total + Product[i].Price;
                average = total / count;

            }
            return average;
        }

        //How many unit of the product has been sold.
        public int QuantitySoldProductsUnit()
        {
            int count = 0;
            String productName = "Xiaomi A5";
            for (int i = 0; i < SaleCount; i++)
            {
                if (Sale[i].Product.Name == productName)
                {
                    count++;
                }

            }
            return count;
        }

        //What's the most expensive product.
        public String MostExpensiveProduct()
        {
            int count = 0;
            float Price = 0;
            String NameProduct = "";
            for (int i = 0; i < ProductCount; i++)
            {
                if (Product[i].Price > Price)
                {
                    Price = Sale[i].Product.Price;
                    NameProduct = Product[i].Name;
                }
            }
            return NameProduct;
        }
    }
}
