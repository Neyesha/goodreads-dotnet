using System.Threading.Tasks;
using Goodreads.Endpoints.Implementations;
using Goodreads.Endpoints.Interfaces;
using Goodreads.Http.Tokens;

namespace Goodreads.Clients
{
    /// <summary>
    /// The unauthorized client API class for accessing the Goodreads API.
    /// </summary>
    public sealed class UnauthorizedGoodreadsClient : GoodreadsClient, IGoodreadsClient
    {
        public UnauthorizedGoodreadsClient(string apiKey, string apiSecret, string accessToken, string accessSecret)
            : base(apiKey, apiSecret, accessToken, accessSecret)
        {
            Authors = new AuthorsEnpoint(Connection);
            Books = new BooksEndpoint(Connection);
            Shelves = new ShelvesEndpoint(Connection);
            Users = new UsersEndpoint(Connection);
            Reviews = new ReviewsEndpoint(Connection);
            Series = new SeriesEndpoint(Connection);
            Events = new EventsEndpoint(Connection);
            Groups = new GroupsEndpoint(Connection);
            UserStatuses = new UserStatusesEndpoint(Connection);
            ReadStatuses = new ReadStatusesEndpoint(Connection);
            Comments = new CommentsEndpoint(Connection);
            Topics = new TopicsEndpoint(Connection);
        }

        public IAuthorsEndpoint Authors { get; }

        public IBooksEndpoint Books { get; }

        public IShelvesEndpoint Shelves { get; }

        public IUsersEndpoint Users { get; }

        public IReviewsEndpoint Reviews { get; }

        public ISeriesEndpoint Series { get; }

        public IEventsEndpoint Events { get; }

        public IGroupsEndpoint Groups { get; }

        public IUserStatusesEndpoint UserStatuses { get; }

        public IReadStatusesEndpoint ReadStatuses { get; }

        public ICommentsEndpoint Comments { get; }

        public ITopicsEndpoint Topics { get; }

        public async Task<OAuthRequestToken> AskCredentials(string callbackUrl)
        {
            return await Connection.GetRequestToken(callbackUrl).ConfigureAwait(false);
        }

        public async Task<OAuthAccessToken> GetAccessToken(OAuthRequestToken token)
        {
            return await Connection.GetAccessToken(token).ConfigureAwait(false);
        }

        public async Task<OAuthAccessToken> GetAccessToken(string token, string secret)
        {
            var oAuthRequestToken = new OAuthRequestToken(token, secret);
            return await GetAccessToken(oAuthRequestToken).ConfigureAwait(false);
        }
    }
}
