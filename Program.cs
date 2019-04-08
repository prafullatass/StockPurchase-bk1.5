using System;
using System.Collections.Generic;


namespace StockPurchaseBk1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple inc.");
            stocks.Add("MSFT", "Microsoft inc.");

            //To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.
            string GM = stocks["GM"];   //<--- "General Motors"
            string apple =stocks["AAPL"];

            //create a list to hold stock purchases by an investor.
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 406.34} });

            //purchases.Add(new Dictionary<string, double>() { {"AAPL", 1200.09} });
            //purchases.Add(new Dictionary<string, double>() { {"AAPL", 1200.09} });
            List<Dictionary<string, double>> stockReport = new List<Dictionary<string, double>>();
            stockReport.Add(new Dictionary<string, double>() { "General Motors", 0});

            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?
                    string FullName = stocks[stock.Key];
                    if(stockReport.ContainsKey(FullName))
                        stockReport[FullName].Value += stock.Value;
                            Console.WriteLine(stockReport);
                    // if(stockReport.Contains(stock.Value)) {
                    //     Dictionary<string, double> st = new Dictionary<string, double>() {
                    //         stockReport.find(s => s.Value == stock.Value)};
                    //     Console.WriteLine(st);
                    // }
                    // If it does, update the total valuation

                    /*
                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                }
            }
        }
        }
    }
