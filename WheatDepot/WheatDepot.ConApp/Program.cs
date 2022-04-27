using System.Diagnostics;

namespace WheatDepot.ConApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Delivery to common depot...");
            Console.WriteLine();
            var watch = new Stopwatch();
            watch.Start();
            var depots = await Logic.DeliveryService.DeliveryAsync();
            watch.Stop();

            Console.WriteLine();
            Console.WriteLine($"The deliveries took {watch.ElapsedMilliseconds / 1000} seconds");

            foreach (var depot in depots)
            {
                Console.WriteLine($"{depot.GetType().Name}");
                Console.WriteLine($"\tCapacity:       {depot.Capacity} ");
                Console.WriteLine($"\tCurrentContent: {depot.CurrentContent} ");
            }
        }
    }
}