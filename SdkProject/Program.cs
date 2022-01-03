using System;
using System.Collections.Generic;
using GraphSdk;
using Azure.Identity;
using System.Threading.Tasks;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Abstractions;
using Microsoft.Graph;
using GraphSdk.Models.Microsoft.Graph;
using System.Text.Json;
using GraphSdk.Users;
using GraphSdk.Me.Messages.Item.Attachments.CreateUploadSession;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static async Task Main()
        {
            string[] scopes = new[] { "Mail.Read", "Mail.ReadWrite", "Mail.ReadBasic" };
            var interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions()
            {
                ClientId = "d662ac70-7482-45af-9dc3-c3cde8eeede4"
            };
            var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);
            var graphClient = new GraphClient(interactiveBrowserCredential, scopes);

            await TestUpload(graphClient);
        }


        public static async Task TestUpload(GraphClient graphClient)
        {
            using var fileStream = System.IO.File.OpenRead("");
            // Use properties to specify the conflict behavior
            // in this case, replace
            var uploadSessionProps = new CreateUploadSessionRequestBody 
            {
                AttachmentItem = new AttachmentItem { }
            };

            // Create the upload session
            // itemPath does not need to be a path to an existing item
            var uploadSession = await graphClient.Me.Messages[""].Attachments.CreateUploadSession.PostAsync(uploadSessionProps);

            // Max slice size must be a multiple of 320 KiB
            int maxSliceSize = 320 * 1024;
            var fileUploadTask = new LargeFileUploadTask<DriveItem>(uploadSession, fileStream, maxSliceSize);

            // Create a callback that is invoked after each slice is uploaded
            IProgress<long> progress = new Progress<long>(prog =>
            {
                Console.WriteLine($"Uploaded {prog} bytes of {fileStream.Length} bytes");
            });

            try
            {
                // Upload the file
                var uploadResult = await fileUploadTask.UploadAsync(progress);

                if (uploadResult.UploadSucceeded)
                {
                    // The ItemResponse object in the result represents the
                    // created item.
                    Console.WriteLine($"Upload complete, item ID: {uploadResult.ItemResponse.Id}");
                }
                else
                {
                    Console.WriteLine("Upload failed");
                }
            }
            catch (ServiceException ex)
            {
                Console.WriteLine($"Error uploading: {ex}");
            }
        }
    }

}