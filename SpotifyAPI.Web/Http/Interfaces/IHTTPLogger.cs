namespace SpotifyAPI.Web.Http
{
  public interface IHTTPLogger
  {
    void OnRequest(IRequest request);
    void OnResponse(IRequest request, IResponse response);
  }
}
