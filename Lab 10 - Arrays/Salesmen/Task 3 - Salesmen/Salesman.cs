using System;

// use a namespace called Sales
namespace Sales
{
    public class Salesman
    {
        // Use Properties 
        public String[] Names { get; set; }
        public double[] Sales { get; set; }
        public double TotalSales { get; private set; }
        public String BestSalesMan { get; private set; }
        private int NoSalesMen { get; set; }

        // default constructor takes in the number of salesman
        // and initialises the two arrays with the number of salesmen
        public Salesman(int noSalesMen)
        {
            NoSalesMen = noSalesMen;
            Names = new String[NoSalesMen];
            Sales = new double[NoSalesMen];

            TotalSales = 0;
        }

        // Use for each loop to loop through the Sales array and add
        // each sales figure to the total sales
        public void calcTotalSales()
        {
            foreach (var item in Sales)
            {
                TotalSales += item;
            }
        }

        // Using the Sales array find the largest sales figure
        // Store its index and use the Names array with the index 
        // to find the name of the best salesman
        public void bestSalesMan()
        {
            int index = 0;
            double tempSales;

            for (int i = 0; i < NoSalesMen - 1; i++)
            {
                tempSales = Sales[i];
                

                if (Sales[i + 1] > tempSales)
                    index = i + 1;

            }

            BestSalesMan = Names[index];
        }

    }
}