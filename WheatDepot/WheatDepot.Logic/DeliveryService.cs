using WheatDepot.Common;

namespace WheatDepot.Logic
{
    public class DeliveryService
    {
        /// <summary>
        /// This method simulates the delivery of liquid gas to the external storage facilities.
        /// </summary>
        /// <returns>PipelineDepot and all OutsideDepots</returns>
        public static async Task<Depot[]> DeliveryAsync()
        {
            var commonDepot = new CommonDepot() { Capacity = 1_000_000, CurrentContent = 0 };
            var truckA = new DeliveryTruck() { Capacity = 1_00 };
            var truckB = new DeliveryTruck() { Capacity = 1_00 };
            var truckC = new DeliveryTruck() { Capacity = 1_00 };
            var truckD = new DeliveryTruck() { Capacity = 1_00 };
            var depotA = new OutsideDepot() { Capacity = 1_000, CurrentContent = 1_000, Distance = 1 };
            var depotB = new OutsideDepot() { Capacity = 1_000, CurrentContent = 9_00, Distance = 2 };
            var depotC = new OutsideDepot() { Capacity = 1_000, CurrentContent = 8_00, Distance = 4 };
            var depotD = new OutsideDepot() { Capacity = 1_000, CurrentContent = 7_00, Distance = 4 };
            var trucks = new List<DeliveryTruck>() { truckA, truckB, truckC };
            var outsideDepots = new List<OutsideDepot> { depotA, depotB, depotC, depotD };
            var tasklist = new List<Task>();

            while (GetDepotNotEmpty(outsideDepots) != null)
            {
                foreach (var i in GetAvailableTrucks(trucks))
                {
                    var depot = GetDepotNotEmpty(outsideDepots);
                    if(depot == null)
                    {
                        break;
                    }
                    tasklist.Add(Task.Run(async () =>
                    {
                        await i.FillAsync(depot);
                        await i.DeliveryAndReturnAsync(commonDepot, depot);

                    }));
                }
            }
            await Task.WhenAll(tasklist);
            return outsideDepots.ToArray();
        }

        public static IEnumerable<DeliveryTruck>GetAvailableTrucks(List<DeliveryTruck> deliveryTrucks)
        {
            return deliveryTrucks.Where(a => !a.IsFull && !a.Delivers && !a.FillUp);
        }
        public static OutsideDepot? GetDepotNotEmpty(List<OutsideDepot> outsideDepots)
        {
            return outsideDepots.Find(d => d.CurrentContent > 0);
        }

    }
}
