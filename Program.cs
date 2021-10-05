using System;
using Microsoft.Kiota.Http.HttpClientLibrary;
using ApiSdk;
using Azure.Identity;
using Microsoft.Kiota.Authentication.Azure;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string[] scopes = new[] { "User.Read", "User.ReadWrite" };
            InteractiveBrowserCredentialOptions interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions()
            {
                ClientId = "INSERT_CLIENT_ID"
            };
            var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);
            var httpClientRequestAdapter = new HttpClientRequestAdapter(new AzureIdentityAuthenticationProvider(interactiveBrowserCredential, scopes));
            var graphClient = new GraphClient(httpClientRequestAdapter);
            var user = await graphClient.Me.GetAsync();

            Console.WriteLine(user.DisplayName);
        }
    }
}