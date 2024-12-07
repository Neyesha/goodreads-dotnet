namespace Goodreads.Http.Tokens
{
    public class OAuthAccessToken : OAuthToken
    {
        public OAuthAccessToken(string token, string secret)
            : base(token, secret)
        {
        }
    }
}
