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

namespace Google.Streetview.Publish.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedStreetViewPublishServiceClientSnippets
    {
        /// <summary>Snippet for StartUpload</summary>
        public void StartUploadRequestObject()
        {
            // Snippet: StartUpload(Empty, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            Empty request = new Empty { };
            // Make the request
            UploadRef response = streetViewPublishServiceClient.StartUpload(request);
            // End snippet
        }

        /// <summary>Snippet for StartUploadAsync</summary>
        public async Task StartUploadRequestObjectAsync()
        {
            // Snippet: StartUploadAsync(Empty, CallSettings)
            // Additional: StartUploadAsync(Empty, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            Empty request = new Empty { };
            // Make the request
            UploadRef response = await streetViewPublishServiceClient.StartUploadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoto</summary>
        public void CreatePhotoRequestObject()
        {
            // Snippet: CreatePhoto(CreatePhotoRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            // Make the request
            Photo response = streetViewPublishServiceClient.CreatePhoto(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhotoAsync</summary>
        public async Task CreatePhotoRequestObjectAsync()
        {
            // Snippet: CreatePhotoAsync(CreatePhotoRequest, CallSettings)
            // Additional: CreatePhotoAsync(CreatePhotoRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            // Make the request
            Photo response = await streetViewPublishServiceClient.CreatePhotoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoto</summary>
        public void CreatePhoto()
        {
            // Snippet: CreatePhoto(Photo, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            Photo photo = new Photo();
            // Make the request
            Photo response = streetViewPublishServiceClient.CreatePhoto(photo);
            // End snippet
        }

        /// <summary>Snippet for CreatePhotoAsync</summary>
        public async Task CreatePhotoAsync()
        {
            // Snippet: CreatePhotoAsync(Photo, CallSettings)
            // Additional: CreatePhotoAsync(Photo, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            Photo photo = new Photo();
            // Make the request
            Photo response = await streetViewPublishServiceClient.CreatePhotoAsync(photo);
            // End snippet
        }

        /// <summary>Snippet for GetPhoto</summary>
        public void GetPhotoRequestObject()
        {
            // Snippet: GetPhoto(GetPhotoRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "",
                View = PhotoView.Basic,
                LanguageCode = "",
            };
            // Make the request
            Photo response = streetViewPublishServiceClient.GetPhoto(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoAsync</summary>
        public async Task GetPhotoRequestObjectAsync()
        {
            // Snippet: GetPhotoAsync(GetPhotoRequest, CallSettings)
            // Additional: GetPhotoAsync(GetPhotoRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "",
                View = PhotoView.Basic,
                LanguageCode = "",
            };
            // Make the request
            Photo response = await streetViewPublishServiceClient.GetPhotoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoto</summary>
        public void GetPhoto()
        {
            // Snippet: GetPhoto(string, PhotoView, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            string photoId = "";
            PhotoView view = PhotoView.Basic;
            // Make the request
            Photo response = streetViewPublishServiceClient.GetPhoto(photoId, view);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoAsync</summary>
        public async Task GetPhotoAsync()
        {
            // Snippet: GetPhotoAsync(string, PhotoView, CallSettings)
            // Additional: GetPhotoAsync(string, PhotoView, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            string photoId = "";
            PhotoView view = PhotoView.Basic;
            // Make the request
            Photo response = await streetViewPublishServiceClient.GetPhotoAsync(photoId, view);
            // End snippet
        }

        /// <summary>Snippet for BatchGetPhotos</summary>
        public void BatchGetPhotosRequestObject()
        {
            // Snippet: BatchGetPhotos(BatchGetPhotosRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds = { "", },
                View = PhotoView.Basic,
                LanguageCode = "",
            };
            // Make the request
            BatchGetPhotosResponse response = streetViewPublishServiceClient.BatchGetPhotos(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetPhotosAsync</summary>
        public async Task BatchGetPhotosRequestObjectAsync()
        {
            // Snippet: BatchGetPhotosAsync(BatchGetPhotosRequest, CallSettings)
            // Additional: BatchGetPhotosAsync(BatchGetPhotosRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds = { "", },
                View = PhotoView.Basic,
                LanguageCode = "",
            };
            // Make the request
            BatchGetPhotosResponse response = await streetViewPublishServiceClient.BatchGetPhotosAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetPhotos</summary>
        public void BatchGetPhotos()
        {
            // Snippet: BatchGetPhotos(IEnumerable<string>, PhotoView, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            IEnumerable<string> photoIds = new string[] { "", };
            PhotoView view = PhotoView.Basic;
            // Make the request
            BatchGetPhotosResponse response = streetViewPublishServiceClient.BatchGetPhotos(photoIds, view);
            // End snippet
        }

        /// <summary>Snippet for BatchGetPhotosAsync</summary>
        public async Task BatchGetPhotosAsync()
        {
            // Snippet: BatchGetPhotosAsync(IEnumerable<string>, PhotoView, CallSettings)
            // Additional: BatchGetPhotosAsync(IEnumerable<string>, PhotoView, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<string> photoIds = new string[] { "", };
            PhotoView view = PhotoView.Basic;
            // Make the request
            BatchGetPhotosResponse response = await streetViewPublishServiceClient.BatchGetPhotosAsync(photoIds, view);
            // End snippet
        }

        /// <summary>Snippet for ListPhotos</summary>
        public void ListPhotosRequestObject()
        {
            // Snippet: ListPhotos(ListPhotosRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            ListPhotosRequest request = new ListPhotosRequest
            {
                View = PhotoView.Basic,
                Filter = "",
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListPhotosResponse, Photo> response = streetViewPublishServiceClient.ListPhotos(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Photo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhotosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Photo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Photo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Photo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhotosAsync</summary>
        public async Task ListPhotosRequestObjectAsync()
        {
            // Snippet: ListPhotosAsync(ListPhotosRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPhotosRequest request = new ListPhotosRequest
            {
                View = PhotoView.Basic,
                Filter = "",
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPhotosResponse, Photo> response = streetViewPublishServiceClient.ListPhotosAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Photo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhotosResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Photo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Photo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Photo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhotos</summary>
        public void ListPhotos()
        {
            // Snippet: ListPhotos(PhotoView, string, string, int?, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            PhotoView view = PhotoView.Basic;
            string filter = "";
            // Make the request
            PagedEnumerable<ListPhotosResponse, Photo> response = streetViewPublishServiceClient.ListPhotos(view, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Photo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhotosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Photo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Photo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Photo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhotosAsync</summary>
        public async Task ListPhotosAsync()
        {
            // Snippet: ListPhotosAsync(PhotoView, string, string, int?, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            PhotoView view = PhotoView.Basic;
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListPhotosResponse, Photo> response = streetViewPublishServiceClient.ListPhotosAsync(view, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Photo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhotosResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Photo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Photo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Photo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoto</summary>
        public void UpdatePhotoRequestObject()
        {
            // Snippet: UpdatePhoto(UpdatePhotoRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Photo response = streetViewPublishServiceClient.UpdatePhoto(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhotoAsync</summary>
        public async Task UpdatePhotoRequestObjectAsync()
        {
            // Snippet: UpdatePhotoAsync(UpdatePhotoRequest, CallSettings)
            // Additional: UpdatePhotoAsync(UpdatePhotoRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Photo response = await streetViewPublishServiceClient.UpdatePhotoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoto</summary>
        public void UpdatePhoto()
        {
            // Snippet: UpdatePhoto(Photo, FieldMask, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            Photo photo = new Photo();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Photo response = streetViewPublishServiceClient.UpdatePhoto(photo, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhotoAsync</summary>
        public async Task UpdatePhotoAsync()
        {
            // Snippet: UpdatePhotoAsync(Photo, FieldMask, CallSettings)
            // Additional: UpdatePhotoAsync(Photo, FieldMask, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            Photo photo = new Photo();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Photo response = await streetViewPublishServiceClient.UpdatePhotoAsync(photo, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePhotos</summary>
        public void BatchUpdatePhotosRequestObject()
        {
            // Snippet: BatchUpdatePhotos(BatchUpdatePhotosRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            // Make the request
            BatchUpdatePhotosResponse response = streetViewPublishServiceClient.BatchUpdatePhotos(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePhotosAsync</summary>
        public async Task BatchUpdatePhotosRequestObjectAsync()
        {
            // Snippet: BatchUpdatePhotosAsync(BatchUpdatePhotosRequest, CallSettings)
            // Additional: BatchUpdatePhotosAsync(BatchUpdatePhotosRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            // Make the request
            BatchUpdatePhotosResponse response = await streetViewPublishServiceClient.BatchUpdatePhotosAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePhotos</summary>
        public void BatchUpdatePhotos()
        {
            // Snippet: BatchUpdatePhotos(IEnumerable<UpdatePhotoRequest>, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            IEnumerable<UpdatePhotoRequest> updatePhotoRequests = new UpdatePhotoRequest[]
            {
                new UpdatePhotoRequest(),
            };
            // Make the request
            BatchUpdatePhotosResponse response = streetViewPublishServiceClient.BatchUpdatePhotos(updatePhotoRequests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePhotosAsync</summary>
        public async Task BatchUpdatePhotosAsync()
        {
            // Snippet: BatchUpdatePhotosAsync(IEnumerable<UpdatePhotoRequest>, CallSettings)
            // Additional: BatchUpdatePhotosAsync(IEnumerable<UpdatePhotoRequest>, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<UpdatePhotoRequest> updatePhotoRequests = new UpdatePhotoRequest[]
            {
                new UpdatePhotoRequest(),
            };
            // Make the request
            BatchUpdatePhotosResponse response = await streetViewPublishServiceClient.BatchUpdatePhotosAsync(updatePhotoRequests);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoto</summary>
        public void DeletePhotoRequestObject()
        {
            // Snippet: DeletePhoto(DeletePhotoRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            DeletePhotoRequest request = new DeletePhotoRequest { PhotoId = "", };
            // Make the request
            streetViewPublishServiceClient.DeletePhoto(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhotoAsync</summary>
        public async Task DeletePhotoRequestObjectAsync()
        {
            // Snippet: DeletePhotoAsync(DeletePhotoRequest, CallSettings)
            // Additional: DeletePhotoAsync(DeletePhotoRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhotoRequest request = new DeletePhotoRequest { PhotoId = "", };
            // Make the request
            await streetViewPublishServiceClient.DeletePhotoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoto</summary>
        public void DeletePhoto()
        {
            // Snippet: DeletePhoto(string, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            string photoId = "";
            // Make the request
            streetViewPublishServiceClient.DeletePhoto(photoId);
            // End snippet
        }

        /// <summary>Snippet for DeletePhotoAsync</summary>
        public async Task DeletePhotoAsync()
        {
            // Snippet: DeletePhotoAsync(string, CallSettings)
            // Additional: DeletePhotoAsync(string, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            string photoId = "";
            // Make the request
            await streetViewPublishServiceClient.DeletePhotoAsync(photoId);
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePhotos</summary>
        public void BatchDeletePhotosRequestObject()
        {
            // Snippet: BatchDeletePhotos(BatchDeletePhotosRequest, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest { PhotoIds = { "", }, };
            // Make the request
            BatchDeletePhotosResponse response = streetViewPublishServiceClient.BatchDeletePhotos(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePhotosAsync</summary>
        public async Task BatchDeletePhotosRequestObjectAsync()
        {
            // Snippet: BatchDeletePhotosAsync(BatchDeletePhotosRequest, CallSettings)
            // Additional: BatchDeletePhotosAsync(BatchDeletePhotosRequest, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest { PhotoIds = { "", }, };
            // Make the request
            BatchDeletePhotosResponse response = await streetViewPublishServiceClient.BatchDeletePhotosAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePhotos</summary>
        public void BatchDeletePhotos()
        {
            // Snippet: BatchDeletePhotos(IEnumerable<string>, CallSettings)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = StreetViewPublishServiceClient.Create();
            // Initialize request argument(s)
            IEnumerable<string> photoIds = new string[] { "", };
            // Make the request
            BatchDeletePhotosResponse response = streetViewPublishServiceClient.BatchDeletePhotos(photoIds);
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePhotosAsync</summary>
        public async Task BatchDeletePhotosAsync()
        {
            // Snippet: BatchDeletePhotosAsync(IEnumerable<string>, CallSettings)
            // Additional: BatchDeletePhotosAsync(IEnumerable<string>, CancellationToken)
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<string> photoIds = new string[] { "", };
            // Make the request
            BatchDeletePhotosResponse response = await streetViewPublishServiceClient.BatchDeletePhotosAsync(photoIds);
            // End snippet
        }
    }
}
