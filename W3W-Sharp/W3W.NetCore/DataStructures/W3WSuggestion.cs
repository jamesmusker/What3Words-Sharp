namespace W3W.NetCore.DataStructures
{
    public class W3WSuggestion
    {
        /// <summary>
        /// The country the suggestion is located in.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The nearest place the suggestion is located to.
        /// </summary>
        public string NearestPlace { get; set; }

        /// <summary>
        /// The words for the suggestion.
        /// </summary>
        public string Words { get; set; }

        /// <summary>
        /// The distance to the focus in Kilometres.
        /// </summary>
        public int DistanceToFocusKm { get; set; }

        /// <summary>
        /// The rank of the suggestion.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// The language of the suggestion.
        /// </summary>
        public string Language { get; set; }
    }
}