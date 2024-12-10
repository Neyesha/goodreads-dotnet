using Goodreads.Endpoints.Implementations;
using Goodreads.Endpoints.Interfaces;

namespace Goodreads.Clients
{
    /// <summary>
    /// The authorized client API class for accessing the OAuth Goodreads API.
    /// </summary>
    public sealed class OAuthGoodreadsClient : GoodreadsClient, IOAuthGoodreadsClient
    {
        public OAuthGoodreadsClient(string apiKey, string apiSecret, string accessToken, string accessSecret)
            : base(apiKey, apiSecret, accessToken, accessSecret)
        {
            Authors = new AuthorsEnpoint(Connection);
            AuthorsFollowing = new AuthorsFollowingEndpoint(Connection);
            Books = new BooksEndpoint(Connection);
            Comments = new CommentsEndpoint(Connection);
            Events = new EventsEndpoint(Connection);
            Followers = new FollowersEndpoint(Connection);
            Friends = new FriendsEndpoint(Connection);
            Groups = new GroupsEndpoint(Connection);
            Notifications = new NotificationsEndpoint(Connection);
            OwnedBooks = new OwnedBooksEndpoint(Connection);
            Quotes = new QuotesEndpoint(Connection);
            ReadStatuses = new ReadStatusesEndpoint(Connection);
            Recommendations = new RecommendationsEndpoint(Connection);
            Reviews = new ReviewsEndpoint(Connection);
            Series = new SeriesEndpoint(Connection);
            Shelves = new ShelvesEndpoint(Connection);
            Topics = new TopicsEndpoint(Connection);
            Updates = new UpdatesEndpoint(Connection);
            Users = new UsersEndpoint(Connection);
            UserStatuses = new UserStatusesEndpoint(Connection);
        }

        public IOAuthAuthorsEndpoint Authors { get; }

        public IOAuthAuthorsFollowingEndpoint AuthorsFollowing { get; }

        public IOAuthBooksEndpoint Books { get; }

        public IOAuthCommentsEndpoint Comments { get; }

        public IOAuthEventsEndpoint Events { get; }

        public IOAuthFollowersEndpoint Followers { get; }

        public IOAuthFriendsEndpoint Friends { get; }

        public IOAuthGroupsEndpoint Groups { get; }

        public IOAuthNotificationsEndpoint Notifications { get; }

        public IOAuthOwnedBooksEndpoint OwnedBooks { get; }

        public IOAuthQuotesEndpoint Quotes { get; }

        public IOAuthReadStatusesEndpoint ReadStatuses { get; }

        public IOAuthRecommendationsEndpoint Recommendations { get; }

        public IOAuthReviewsEndpoint Reviews { get; }

        public IOAuthSeriesEndpoint Series { get; }

        public IOAuthShelvesEndpoint Shelves { get; }

        public IOAuthTopicsEndpoint Topics { get; }

        public IOAuthUpdatesEndpoint Updates { get; }

        public IOAuthUsersEndpoint Users { get; }

        public IOAuthUserStatusesEndpoint UserStatuses { get; }
    }
}
