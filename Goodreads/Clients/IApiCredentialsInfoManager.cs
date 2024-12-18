﻿using Goodreads.Http;

namespace Goodreads.Clients
{
    /// <summary>
    /// Provide info about current API Goodreads credentials.
    /// </summary>
    public interface IApiCredentialsInfoManager
    {
        /// <summary>
        /// Get API Goodreads credentials.
        /// </summary>
        /// <returns></returns>
        ApiCredentials GetCredentials();
    }
}
