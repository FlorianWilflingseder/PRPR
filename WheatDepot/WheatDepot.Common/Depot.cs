namespace WheatDepot.Common
{
    public abstract class Depot
    {
        private int currentContent;

        /// <summary>
        /// Indicates the maximum capacity.
        /// </summary>
        public int Capacity { get; init; }
        /// <summary>
        /// Gets or sets the current content.
        /// </summary>
        public int CurrentContent 
        {
            get
            {
                lock (this)
                {
                    return currentContent;
                }
            }
            set
            {
                lock (this)
                {
                    currentContent = value;
                }
            }
        }
    }
}
