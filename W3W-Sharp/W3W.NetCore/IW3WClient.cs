using System.Collections.Generic;
using System.Threading.Tasks;
using W3W.NetCore.DataStructures;

namespace W3W.NetCore
{
    public interface IW3WClient
    {
        Task<W3WResult> ConvertTo3WordAddress(Coordinates coords);
        Task<W3WGeoJsonResult> ConvertTo3WordAddressGeoJson(Coordinates coords);

        Task<W3WResult> ConvertToCoordinates(string words);
        Task<W3WGeoJsonResult> ConvertToCoordinatesGeoJson(string words);

        Task<W3WSuggestionsResult> Autosuggest(string words);
        Task<W3WSuggestionsResult> Autosuggest(string words, int numResults);
        Task<W3WSuggestionsResult> Autosuggest(string words, params string[] countries);
        Task<W3WSuggestionsResult> Autosuggest(string words, CircleClip clip);
        Task<W3WSuggestionsResult> Autosuggest(string words, params double[] polygonClip);
        Task<W3WSuggestionsResult> Autosuggest(string words, BoundingBox box);
        Task<W3WSuggestionsResult> Autosuggest(string words, Coordinates focus);

        Task<List<Language>> AvailableLanguages();
    }
}