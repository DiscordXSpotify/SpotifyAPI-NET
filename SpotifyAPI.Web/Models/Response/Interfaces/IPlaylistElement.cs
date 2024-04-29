using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SpotifyAPI.Web
{
  public enum ItemType
  {
    Track,
    Episode
  }

  public interface IPlayableItem : IUriObject
  {
    [JsonConverter(typeof(StringEnumConverter))]
    ItemType Type { get; }
  }
}

