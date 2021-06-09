// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedMediaFileServiceClientSnippets
    {
        /// <summary>Snippet for GetMediaFile</summary>
        public void GetMediaFileRequestObject()
        {
            // Snippet: GetMediaFile(GetMediaFileRequest, CallSettings)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = MediaFileServiceClient.Create();
            // Initialize request argument(s)
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = MediaFileName.FromCustomerMediaFile("[CUSTOMER_ID]", "[MEDIA_FILE_ID]"),
            };
            // Make the request
            MediaFile response = mediaFileServiceClient.GetMediaFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetMediaFileAsync</summary>
        public async Task GetMediaFileRequestObjectAsync()
        {
            // Snippet: GetMediaFileAsync(GetMediaFileRequest, CallSettings)
            // Additional: GetMediaFileAsync(GetMediaFileRequest, CancellationToken)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = await MediaFileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = MediaFileName.FromCustomerMediaFile("[CUSTOMER_ID]", "[MEDIA_FILE_ID]"),
            };
            // Make the request
            MediaFile response = await mediaFileServiceClient.GetMediaFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMediaFile</summary>
        public void GetMediaFile()
        {
            // Snippet: GetMediaFile(string, CallSettings)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = MediaFileServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/mediaFiles/[MEDIA_FILE_ID]";
            // Make the request
            MediaFile response = mediaFileServiceClient.GetMediaFile(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMediaFileAsync</summary>
        public async Task GetMediaFileAsync()
        {
            // Snippet: GetMediaFileAsync(string, CallSettings)
            // Additional: GetMediaFileAsync(string, CancellationToken)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = await MediaFileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/mediaFiles/[MEDIA_FILE_ID]";
            // Make the request
            MediaFile response = await mediaFileServiceClient.GetMediaFileAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMediaFile</summary>
        public void GetMediaFileResourceNames()
        {
            // Snippet: GetMediaFile(MediaFileName, CallSettings)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = MediaFileServiceClient.Create();
            // Initialize request argument(s)
            MediaFileName resourceName = MediaFileName.FromCustomerMediaFile("[CUSTOMER_ID]", "[MEDIA_FILE_ID]");
            // Make the request
            MediaFile response = mediaFileServiceClient.GetMediaFile(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMediaFileAsync</summary>
        public async Task GetMediaFileResourceNamesAsync()
        {
            // Snippet: GetMediaFileAsync(MediaFileName, CallSettings)
            // Additional: GetMediaFileAsync(MediaFileName, CancellationToken)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = await MediaFileServiceClient.CreateAsync();
            // Initialize request argument(s)
            MediaFileName resourceName = MediaFileName.FromCustomerMediaFile("[CUSTOMER_ID]", "[MEDIA_FILE_ID]");
            // Make the request
            MediaFile response = await mediaFileServiceClient.GetMediaFileAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateMediaFiles</summary>
        public void MutateMediaFilesRequestObject()
        {
            // Snippet: MutateMediaFiles(MutateMediaFilesRequest, CallSettings)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = MediaFileServiceClient.Create();
            // Initialize request argument(s)
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new MediaFileOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateMediaFilesResponse response = mediaFileServiceClient.MutateMediaFiles(request);
            // End snippet
        }

        /// <summary>Snippet for MutateMediaFilesAsync</summary>
        public async Task MutateMediaFilesRequestObjectAsync()
        {
            // Snippet: MutateMediaFilesAsync(MutateMediaFilesRequest, CallSettings)
            // Additional: MutateMediaFilesAsync(MutateMediaFilesRequest, CancellationToken)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = await MediaFileServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new MediaFileOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateMediaFilesResponse response = await mediaFileServiceClient.MutateMediaFilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateMediaFiles</summary>
        public void MutateMediaFiles()
        {
            // Snippet: MutateMediaFiles(string, IEnumerable<MediaFileOperation>, CallSettings)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = MediaFileServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<MediaFileOperation> operations = new MediaFileOperation[]
            {
                new MediaFileOperation(),
            };
            // Make the request
            MutateMediaFilesResponse response = mediaFileServiceClient.MutateMediaFiles(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateMediaFilesAsync</summary>
        public async Task MutateMediaFilesAsync()
        {
            // Snippet: MutateMediaFilesAsync(string, IEnumerable<MediaFileOperation>, CallSettings)
            // Additional: MutateMediaFilesAsync(string, IEnumerable<MediaFileOperation>, CancellationToken)
            // Create client
            MediaFileServiceClient mediaFileServiceClient = await MediaFileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<MediaFileOperation> operations = new MediaFileOperation[]
            {
                new MediaFileOperation(),
            };
            // Make the request
            MutateMediaFilesResponse response = await mediaFileServiceClient.MutateMediaFilesAsync(customerId, operations);
            // End snippet
        }
    }
}
