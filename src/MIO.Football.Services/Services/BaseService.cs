using MIO.Football.Domain.Interfaces.IServices;

namespace MIO.Football.Services.Services
{
    public class BaseService : IBaseService
    {
        public string Token { get; } = "819301e0302f4a03b064974efe268705";
        public string UrlBase { get; } = "http://api.football-data.org/v2/";
    }
}