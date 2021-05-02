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

namespace Google.Home.Enterprise.Sdm.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSmartDeviceManagementServiceClientSnippets
    {
        /// <summary>Snippet for GetDevice</summary>
        public void GetDeviceRequestObject()
        {
            // Snippet: GetDevice(GetDeviceRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            GetDeviceRequest request = new GetDeviceRequest { Name = "", };
            // Make the request
            Device response = smartDeviceManagementServiceClient.GetDevice(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceAsync</summary>
        public async Task GetDeviceRequestObjectAsync()
        {
            // Snippet: GetDeviceAsync(GetDeviceRequest, CallSettings)
            // Additional: GetDeviceAsync(GetDeviceRequest, CancellationToken)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceRequest request = new GetDeviceRequest { Name = "", };
            // Make the request
            Device response = await smartDeviceManagementServiceClient.GetDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDevices</summary>
        public void ListDevicesRequestObject()
        {
            // Snippet: ListDevices(ListDevicesRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            ListDevicesRequest request = new ListDevicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDevicesResponse, Device> response = smartDeviceManagementServiceClient.ListDevices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Device item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevicesAsync</summary>
        public async Task ListDevicesRequestObjectAsync()
        {
            // Snippet: ListDevicesAsync(ListDevicesRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDevicesRequest request = new ListDevicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDevicesResponse, Device> response = smartDeviceManagementServiceClient.ListDevicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Device item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDevicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExecuteDeviceCommand</summary>
        public void ExecuteDeviceCommandRequestObject()
        {
            // Snippet: ExecuteDeviceCommand(ExecuteDeviceCommandRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            ExecuteDeviceCommandRequest request = new ExecuteDeviceCommandRequest
            {
                Name = "",
                Command = "",
                Params = new Struct(),
            };
            // Make the request
            ExecuteDeviceCommandResponse response = smartDeviceManagementServiceClient.ExecuteDeviceCommand(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDeviceCommandAsync</summary>
        public async Task ExecuteDeviceCommandRequestObjectAsync()
        {
            // Snippet: ExecuteDeviceCommandAsync(ExecuteDeviceCommandRequest, CallSettings)
            // Additional: ExecuteDeviceCommandAsync(ExecuteDeviceCommandRequest, CancellationToken)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteDeviceCommandRequest request = new ExecuteDeviceCommandRequest
            {
                Name = "",
                Command = "",
                Params = new Struct(),
            };
            // Make the request
            ExecuteDeviceCommandResponse response = await smartDeviceManagementServiceClient.ExecuteDeviceCommandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStructure</summary>
        public void GetStructureRequestObject()
        {
            // Snippet: GetStructure(GetStructureRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            GetStructureRequest request = new GetStructureRequest { Name = "", };
            // Make the request
            Structure response = smartDeviceManagementServiceClient.GetStructure(request);
            // End snippet
        }

        /// <summary>Snippet for GetStructureAsync</summary>
        public async Task GetStructureRequestObjectAsync()
        {
            // Snippet: GetStructureAsync(GetStructureRequest, CallSettings)
            // Additional: GetStructureAsync(GetStructureRequest, CancellationToken)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStructureRequest request = new GetStructureRequest { Name = "", };
            // Make the request
            Structure response = await smartDeviceManagementServiceClient.GetStructureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListStructures</summary>
        public void ListStructuresRequestObject()
        {
            // Snippet: ListStructures(ListStructuresRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            ListStructuresRequest request = new ListStructuresRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListStructuresResponse, Structure> response = smartDeviceManagementServiceClient.ListStructures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Structure item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStructuresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Structure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Structure> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Structure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStructuresAsync</summary>
        public async Task ListStructuresRequestObjectAsync()
        {
            // Snippet: ListStructuresAsync(ListStructuresRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListStructuresRequest request = new ListStructuresRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStructuresResponse, Structure> response = smartDeviceManagementServiceClient.ListStructuresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Structure item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStructuresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Structure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Structure> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Structure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRoom</summary>
        public void GetRoomRequestObject()
        {
            // Snippet: GetRoom(GetRoomRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            GetRoomRequest request = new GetRoomRequest { Name = "", };
            // Make the request
            Room response = smartDeviceManagementServiceClient.GetRoom(request);
            // End snippet
        }

        /// <summary>Snippet for GetRoomAsync</summary>
        public async Task GetRoomRequestObjectAsync()
        {
            // Snippet: GetRoomAsync(GetRoomRequest, CallSettings)
            // Additional: GetRoomAsync(GetRoomRequest, CancellationToken)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRoomRequest request = new GetRoomRequest { Name = "", };
            // Make the request
            Room response = await smartDeviceManagementServiceClient.GetRoomAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRooms</summary>
        public void ListRoomsRequestObject()
        {
            // Snippet: ListRooms(ListRoomsRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = SmartDeviceManagementServiceClient.Create();
            // Initialize request argument(s)
            ListRoomsRequest request = new ListRoomsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListRoomsResponse, Room> response = smartDeviceManagementServiceClient.ListRooms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Room item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoomsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Room item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Room> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Room item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoomsAsync</summary>
        public async Task ListRoomsRequestObjectAsync()
        {
            // Snippet: ListRoomsAsync(ListRoomsRequest, CallSettings)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRoomsRequest request = new ListRoomsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListRoomsResponse, Room> response = smartDeviceManagementServiceClient.ListRoomsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Room item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoomsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Room item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Room> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Room item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
