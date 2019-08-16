namespace W3W.NetCore.DataStructures
{
    /// <summary>
    /// Represents a language used by What3Words.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// The name of the Language in the native tongue.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// The code for the language.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The name of the language in English.
        /// </summary>
        public string Name { get; set; }
    }
}