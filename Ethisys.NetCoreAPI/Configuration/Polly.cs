using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;

namespace Ethisys.NetCoreAPI.Configuration
{
    public static class Polly
    {
        /// <summary>
        /// This is implementing a retry policy, this is the basic one copied from Microsoft website, but it could be implemented to perform as wanted.
        /// In this example will retry 6 times and waiting the pow of 2 between each time
        /// </summary>
        /// <returns></returns>
        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }
    }
}