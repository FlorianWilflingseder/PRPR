namespace WheatDepot.Common
{
    public class DeliveryTruck
    {
        static int Counter = 0;
        public int Id { get; } = ++Counter;
        /// <summary>
        /// Indicates the maximum capacity.
        /// </summary>
        public int Capacity { get; init; }
        /// <summary>
        /// Shows whether the truck is filled.
        /// </summary>
        public bool IsFull { get; private set; }
        /// <summary>
        /// Indicates whether the truck is being filled.
        /// </summary>
        public bool FillUp { get; set; }
        /// <summary>
        /// Indicates whether the truck is delivering.
        /// </summary>
        public bool Delivers { get; private set; }

        /// <summary>
        /// Fill up the truck. The duration is 5 seconds.
        /// </summary>
        /// <param name="depot">The depot</param>
        /// <returns>Task</returns>
        public async Task FillAsync(OutsideDepot depot)
        {
            FillUp = true;
            
            if(depot.CurrentContent > 0)
            {
                depot.CurrentContent -= this.Capacity;
                await Task.Delay(5000);
                this.IsFull = true;
                Console.WriteLine("Is Full");
            }
            FillUp = false;
          
        }
        /// <summary>
        /// Delivery to common depot and return to the outside depot.
        /// </summary>
        /// <param name="commonDepot">The common depot</param>
        /// <param name="outsideDepot">The outside depot</param>
        /// <returns>Task</returns>
        public async Task DeliveryAndReturnAsync(CommonDepot commonDepot, OutsideDepot outsideDepot)
        {
            
            this.Delivers = true;
            Console.WriteLine("Is delievering...");
            await Task.Delay(outsideDepot.Distance * 1000);
            commonDepot.CurrentContent += this.Capacity;
            this.IsFull = false;
            await Task.Delay(outsideDepot.Distance * 1000);      
            this.Delivers = false;
            Console.WriteLine("Done!");
            
        }
    }
}
