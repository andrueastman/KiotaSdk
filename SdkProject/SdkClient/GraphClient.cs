using Azure.Core;
using Microsoft.Graph;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Collections.Generic;
using System.Linq;

namespace GraphSdk
{
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public partial class GraphClient : BaseClient
    {
        /// <summary>
        /// Constructs a new <see cref="BaseClient"/>.
        /// </summary>
        /// <param name="tokenCredential">The <see cref="TokenCredential"/> for authenticating request messages.</param>
        /// <param name="scopes">List of scopes for the authentication context.</param>
        public GraphClient(
            TokenCredential tokenCredential,
            IEnumerable<string> scopes = null): this(new HttpClientRequestAdapter(new AzureIdentityAuthenticationProvider(tokenCredential, scopes?.ToArray() ?? new[] { "https://graph.microsoft.com/.default" })))
        {
        }
    }
}
