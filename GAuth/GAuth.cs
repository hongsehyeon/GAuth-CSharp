using System.Threading.Tasks;

namespace GAuth_CSharp
{
    public interface GAuth
    {
        Task<GAuthToken> GenerateTokenAsync(string email, string password, string clientId, string clientSecret, string redirectUri);

        Task<GAuthToken> GenerateTokenAsync(string code, string clientId, string clientSecret, string redirectUri);

        Task<GAuthCode> GenerateCodeAsync(string email, string password);

        Task<GAuthToken> RefreshAsync(string refreshToken);

        Task<GAuthUserInfo> GetUserInfoAsync(string accessToken);

        GAuthToken GenerateToken(string email, string password, string clientId, string clientSecret, string redirectUri);

        GAuthToken GenerateToken(string code, string clientId, string clientSecret, string redirectUri);

        GAuthCode GenerateCode(string email, string password);

        GAuthToken Refresh(string refreshToken);

        GAuthUserInfo GetUserInfo(string accessToken);
    }
}