namespace WheatDepot.Common
{
    public class OutsideDepot : Depot
    {
        static int Counter = 0;
        public int Id { get; } = ++Counter;
        /// <summary>
        /// Indicates the distance to the pipeline.
        /// </summary>
        public int Distance { get; init; }
    }
}