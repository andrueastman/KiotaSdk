using System;
using System.Collections.Generic;
using GraphSdk;
using Azure.Identity;
using System.Threading.Tasks;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Abstractions;
using Microsoft.Graph;
using GraphSdk.Models.Microsoft.Graph;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static async Task Main()
        {
            string[] scopes = new[] { "User.Read", "Mail.ReadWrite", "User.ReadWrite.All" };
            var interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions()
            {
                ClientId = "d662ac70-7482-45af-9dc3-c3cde8eeede4"
            };
            var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);
            //var httpClientRequestAdapter = new HttpClientRequestAdapter(new AzureIdentityAuthenticationProvider(interactiveBrowserCredential, scopes));
            var graphClient = new GraphClient(interactiveBrowserCredential, scopes);

            // Setting headers and query parameters
            // var usersRequestInformation = graphClient.Users.CreateGetRequestInformation();
            // usersRequestInformation.QueryParameters.Add("custom","customValue");
            // await httpClientRequestAdapter.SendAsync<User>(usersRequestInformation);

            var requestOptions = new IRequestOption[] 
            {
                new RedirectHandlerOption
                {
                    MaxRedirect = 1
                }
            };

            // Get users with query parameters
            var messages = await graphClient.Me.Messages.GetAsync(
                parameters => { parameters.Select = new string[] { "id"}; parameters.Top = 1; }, // set parameters
                headers => headers.Add("ConsistencyLevel", "eventual"),                                           // set headers
                requestOptions);                                                                                  // set per request options

            Console.WriteLine(messages.Value.Count);


            List<Message> messagesList = new List<Message>();
            //var pageIterator = PageIterator<Message>.CreatePageIterator(graphClient, messages, (message) => { messagesList.Add(message); return true; });
            //await pageIterator.IterateAsync();
        }
    }
}