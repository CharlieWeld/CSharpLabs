using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        private int productCode;
        private string ProductName { get; set; }
        private double sellingPrice;
        private double costPrice;
        private int StockLevel { get; set; }
        private double profit;

        public Product() : this(0, "", 0, 0) { }

        public Product(int productCode, string productName, double sellingPrice, double costPrice)
        {
            this.productCode = productCode;
            ProductName = productName;
            this.sellingPrice = sellingPrice;
            this.costPrice = costPrice;
            StockLevel = 0;
            profit = 0;
        }

        public void RenewalStockLevel(int quantity)
        {
            StockLevel += quantity;
        }

        public bool Sell(int quantity)
        {
            double tempStock = StockLevel - quantity;
            if (tempStock < 0)
            {
                return false;
            }
            else
            {
                StockLevel -= quantity;
                profit += quantity * (sellingPrice - costPrice);
                return true;
            }
        }

        public void printProfit()
        {
            Console.WriteLine(String.Format("The accumulated profit is {0:0.00}\n", profit));
        }
        public void printProduct()
        {
            Console.WriteLine(productCode);
            Console.WriteLine(ProductName);
            Console.WriteLine(sellingPrice);
            Console.WriteLine(costPrice);
            Console.WriteLine(StockLevel);
            Console.WriteLine(profit);
        }
    }
}
