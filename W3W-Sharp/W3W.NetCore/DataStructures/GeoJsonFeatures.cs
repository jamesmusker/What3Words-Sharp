namespace W3W.NetCore.DataStructures
{
    public class GeoJsonFeatures
    {
        /// <summary>
        /// The Bounding Box for the result.
        /// </summary>
        public BoundingBox Bbox { get; set; }

        /// <summary>
        /// The Geometry of the result.
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// The type of result.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The properties of the result.
        /// </summary>
        public W3WProperties Properties { get; set; }
    }
}