using System.Threading.Tasks;

namespace GAuth_CSharp
{
    public interface GAuth
    {
        Task<GAuthToken> GenerateToken(string email, string password, string clientId, string clientSecret, string redirectUri);

        Task<GAuthToken> GenerateToken(string code, string clientId, string clientSecret, string redirectUri);

        Task<GAuthCode> GenerateCode(string email, string password);

        Task<GAuthToken> Refresh(string refreshToken);

        Task<GAuthUserInfo> GetUserInfo(string accessToken);
    }
}