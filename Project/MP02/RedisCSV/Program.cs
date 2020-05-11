using System;
using System.IO;
using StackExchange.Redis;

namespace RedisCSV {
    class Program {
        public static void Main(string[] args) {
            var path = @"C:\CPHBusiness\Databases-for-Developers\Project\MP02\RedisCSV\";
            var lines = File.ReadAllLines(path + "data.csv");
            Console.WriteLine("Writing");
            Console.WriteLine(lines.Length);
            var muxer = ConnectionMultiplexer.Connect("localhost");
            var conn = muxer.GetDatabase(1);


            for (var i = 1; i < lines.Length; i++) {
                var sep = lines[i].Split(',');
                conn.HashSet($"order:{sep[0]}", new HashEntry[] {
                    new HashEntry("StockCode", sep[1]),
                    new HashEntry("Description", sep[2]),
                    new HashEntry("Quantity", sep[3]),
                    new HashEntry("InvoiceDate", sep[4]),
                    new HashEntry("UnitPrice", sep[5]),
                    new HashEntry("CustomerID", sep[6]),
                    new HashEntry("Country", sep[7]),
                });
            }

            Console.WriteLine("Finished");
        }
    }
}