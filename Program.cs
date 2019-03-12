using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GE", "General Electric");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("SBUX", "Starbucks");
            stocks.Add("FB", "FaceBook");
            stocks.Add("SFIX", "Stitch Fix");


            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>() { { "GE", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 450.98 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 200.34 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 229.34 } });

            //          Define a new Dictionary to hold the aggregated purchase information.
            // - The key should be a string that is the full company name.
            // - The value will be the total valuation of each stock


            //     From the three purchases above, one of the entries
            //     in this new dictionary will be...
            //         {"General Electric", 1217.53}

            //     Replace the questions marks below with the correct types.
            // */
            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            { 
                // Console.WriteLine($"purchase is ---- {purchase}");
                {
                    foreach (KeyValuePair<string, double> stock in purchase)
                    {

                        if (stockReport.ContainsKey(stocks[stock.Key]))
                        // if (stockReport.ContainsKey(stock.Key))
                        {   
                            stockReport[stocks[stock.Key]] += stock.Value;

                            // another way:
                            // stockReport[stock.Key] += stock.Value;
                            // stockReport[stock.Key] =  stockReport[stock.Key] + stock.Value;

                            /*
                               If not, add the new key and set its value.
                               You have the value of "GE", so how can you look
                               the value of "GE" in the `stocks` dictionary
                               to get the value of "General Electric"?
                           */
                        }
                        else
                        {   
                            Console.WriteLine($"------Now adding {stocks[stock.Key]} stocks--------");
                            stockReport.Add(stocks[stock.Key], stock.Value);
                            // stockReport.Add(stock.Key,stock.Value);
                        }

                        // Console Write each stock within the newly created report
                         foreach (KeyValuePair<string, double> kvp in stockReport) {
                        Console.WriteLine($"The position in {kvp.Key} is worth {kvp.Value}");
                        }




                    }
                }

            }
        }
    }
}






