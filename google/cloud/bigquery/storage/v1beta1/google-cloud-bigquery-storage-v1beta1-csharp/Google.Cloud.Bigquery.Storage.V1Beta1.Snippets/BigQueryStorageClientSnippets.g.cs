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

namespace Google.Cloud.Bigquery.Storage.V1Beta1.Snippets
{
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBigQueryStorageClientSnippets
    {
        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSessionRequestObject()
        {
            // Snippet: CreateReadSession(CreateReadSessionRequest, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                RequestedStreams = 0,
                ReadOptions = new TableReadOptions(),
                Format = DataFormat.Unspecified,
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShardingStrategy = ShardingStrategy.Unspecified,
            };
            // Make the request
            ReadSession response = bigQueryStorageClient.CreateReadSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionRequestObjectAsync()
        {
            // Snippet: CreateReadSessionAsync(CreateReadSessionRequest, CallSettings)
            // Additional: CreateReadSessionAsync(CreateReadSessionRequest, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                RequestedStreams = 0,
                ReadOptions = new TableReadOptions(),
                Format = DataFormat.Unspecified,
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShardingStrategy = ShardingStrategy.Unspecified,
            };
            // Make the request
            ReadSession response = await bigQueryStorageClient.CreateReadSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSession()
        {
            // Snippet: CreateReadSession(TableReference, string, int, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            TableReference tableReference = new TableReference();
            string parent = "projects/[PROJECT]";
            int requestedStreams = 0;
            // Make the request
            ReadSession response = bigQueryStorageClient.CreateReadSession(tableReference, parent, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionAsync()
        {
            // Snippet: CreateReadSessionAsync(TableReference, string, int, CallSettings)
            // Additional: CreateReadSessionAsync(TableReference, string, int, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            TableReference tableReference = new TableReference();
            string parent = "projects/[PROJECT]";
            int requestedStreams = 0;
            // Make the request
            ReadSession response = await bigQueryStorageClient.CreateReadSessionAsync(tableReference, parent, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSessionResourceNames()
        {
            // Snippet: CreateReadSession(TableReference, ProjectName, int, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            TableReference tableReference = new TableReference();
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            int requestedStreams = 0;
            // Make the request
            ReadSession response = bigQueryStorageClient.CreateReadSession(tableReference, parent, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionResourceNamesAsync()
        {
            // Snippet: CreateReadSessionAsync(TableReference, ProjectName, int, CallSettings)
            // Additional: CreateReadSessionAsync(TableReference, ProjectName, int, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            TableReference tableReference = new TableReference();
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            int requestedStreams = 0;
            // Make the request
            ReadSession response = await bigQueryStorageClient.CreateReadSessionAsync(tableReference, parent, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRowsRequestObject()
        {
            // Snippet: ReadRows(ReadRowsRequest, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            ReadRowsRequest request = new ReadRowsRequest
            {
                ReadPosition = new StreamPosition(),
            };
            // Make the request, returning a streaming response
            BigQueryStorageClient.ReadRowsStream response = bigQueryStorageClient.ReadRows(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows()
        {
            // Snippet: ReadRows(StreamPosition, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            StreamPosition readPosition = new StreamPosition();
            // Make the request, returning a streaming response
            BigQueryStorageClient.ReadRowsStream response = bigQueryStorageClient.ReadRows(readPosition);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BatchCreateReadSessionStreams</summary>
        public void BatchCreateReadSessionStreamsRequestObject()
        {
            // Snippet: BatchCreateReadSessionStreams(BatchCreateReadSessionStreamsRequest, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = 0,
            };
            // Make the request
            BatchCreateReadSessionStreamsResponse response = bigQueryStorageClient.BatchCreateReadSessionStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateReadSessionStreamsAsync</summary>
        public async Task BatchCreateReadSessionStreamsRequestObjectAsync()
        {
            // Snippet: BatchCreateReadSessionStreamsAsync(BatchCreateReadSessionStreamsRequest, CallSettings)
            // Additional: BatchCreateReadSessionStreamsAsync(BatchCreateReadSessionStreamsRequest, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = 0,
            };
            // Make the request
            BatchCreateReadSessionStreamsResponse response = await bigQueryStorageClient.BatchCreateReadSessionStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateReadSessionStreams</summary>
        public void BatchCreateReadSessionStreams()
        {
            // Snippet: BatchCreateReadSessionStreams(ReadSession, int, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            ReadSession session = new ReadSession();
            int requestedStreams = 0;
            // Make the request
            BatchCreateReadSessionStreamsResponse response = bigQueryStorageClient.BatchCreateReadSessionStreams(session, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateReadSessionStreamsAsync</summary>
        public async Task BatchCreateReadSessionStreamsAsync()
        {
            // Snippet: BatchCreateReadSessionStreamsAsync(ReadSession, int, CallSettings)
            // Additional: BatchCreateReadSessionStreamsAsync(ReadSession, int, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            ReadSession session = new ReadSession();
            int requestedStreams = 0;
            // Make the request
            BatchCreateReadSessionStreamsResponse response = await bigQueryStorageClient.BatchCreateReadSessionStreamsAsync(session, requestedStreams);
            // End snippet
        }

        /// <summary>Snippet for FinalizeStream</summary>
        public void FinalizeStreamRequestObject()
        {
            // Snippet: FinalizeStream(FinalizeStreamRequest, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            // Make the request
            bigQueryStorageClient.FinalizeStream(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeStreamAsync</summary>
        public async Task FinalizeStreamRequestObjectAsync()
        {
            // Snippet: FinalizeStreamAsync(FinalizeStreamRequest, CallSettings)
            // Additional: FinalizeStreamAsync(FinalizeStreamRequest, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            // Make the request
            await bigQueryStorageClient.FinalizeStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeStream</summary>
        public void FinalizeStream()
        {
            // Snippet: FinalizeStream(Stream, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            Stream stream = new Stream();
            // Make the request
            bigQueryStorageClient.FinalizeStream(stream);
            // End snippet
        }

        /// <summary>Snippet for FinalizeStreamAsync</summary>
        public async Task FinalizeStreamAsync()
        {
            // Snippet: FinalizeStreamAsync(Stream, CallSettings)
            // Additional: FinalizeStreamAsync(Stream, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            Stream stream = new Stream();
            // Make the request
            await bigQueryStorageClient.FinalizeStreamAsync(stream);
            // End snippet
        }

        /// <summary>Snippet for SplitReadStream</summary>
        public void SplitReadStreamRequestObject()
        {
            // Snippet: SplitReadStream(SplitReadStreamRequest, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
                Fraction = 0F,
            };
            // Make the request
            SplitReadStreamResponse response = bigQueryStorageClient.SplitReadStream(request);
            // End snippet
        }

        /// <summary>Snippet for SplitReadStreamAsync</summary>
        public async Task SplitReadStreamRequestObjectAsync()
        {
            // Snippet: SplitReadStreamAsync(SplitReadStreamRequest, CallSettings)
            // Additional: SplitReadStreamAsync(SplitReadStreamRequest, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
                Fraction = 0F,
            };
            // Make the request
            SplitReadStreamResponse response = await bigQueryStorageClient.SplitReadStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SplitReadStream</summary>
        public void SplitReadStream()
        {
            // Snippet: SplitReadStream(Stream, CallSettings)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = BigQueryStorageClient.Create();
            // Initialize request argument(s)
            Stream originalStream = new Stream();
            // Make the request
            SplitReadStreamResponse response = bigQueryStorageClient.SplitReadStream(originalStream);
            // End snippet
        }

        /// <summary>Snippet for SplitReadStreamAsync</summary>
        public async Task SplitReadStreamAsync()
        {
            // Snippet: SplitReadStreamAsync(Stream, CallSettings)
            // Additional: SplitReadStreamAsync(Stream, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            Stream originalStream = new Stream();
            // Make the request
            SplitReadStreamResponse response = await bigQueryStorageClient.SplitReadStreamAsync(originalStream);
            // End snippet
        }
    }
}
