using System.Collections.Generic;

namespace SpotifyAPI.Web
{
  public class Context : IUriObject
  {
    public Dictionary<string, string> ExternalUrls { get; set; } = default!;
    public string Href { get; set; } = default!;
    public string Type { get; set; } = default!;
    public string Uri { get; set; } = default!;
  }
}

