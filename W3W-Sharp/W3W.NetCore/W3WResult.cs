using W3W.NetCore.DataStructures;

namespace W3W.NetCore
{
    public class W3WResult
    {
        /// <summary>
        /// The country the result is located in.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The Grid Section the result is located in.
        /// </summary>
        public GridSection Square { get; set; }

        /// <summary>
        /// The nearest place to the result.
        /// </summary>
        public string NearestPlace { get; set; }

        /// <summary>
        /// The coordinates of the result.
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// The words associated with the result.
        /// </summary>
        public string Words { get; set; }

        /// <summary>
        /// The language for the result.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// URL to the map for the result.
        /// </summary>
        public string Map { get; set; }
    }
}