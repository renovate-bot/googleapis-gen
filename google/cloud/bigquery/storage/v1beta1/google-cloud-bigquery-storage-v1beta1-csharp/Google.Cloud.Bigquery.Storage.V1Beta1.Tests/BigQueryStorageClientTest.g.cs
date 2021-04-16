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

using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Bigquery.Storage.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigQueryStorageClientTest
    {
        [xunit::FactAttribute]
        public void CreateReadSessionRequestObject()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                RequestedStreams = -1338971660,
                ReadOptions = new TableReadOptions(),
                Format = DataFormat.Arrow,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionRequestObjectAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                RequestedStreams = -1338971660,
                ReadOptions = new TableReadOptions(),
                Format = DataFormat.Arrow,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReadSession()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                RequestedStreams = -1338971660,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request.TableReference, request.Parent, request.RequestedStreams);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                RequestedStreams = -1338971660,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request.TableReference, request.Parent, request.RequestedStreams, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request.TableReference, request.Parent, request.RequestedStreams, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReadSessionResourceNames()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                RequestedStreams = -1338971660,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request.TableReference, request.ParentAsProjectName, request.RequestedStreams);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionResourceNamesAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                TableReference = new TableReference(),
                RequestedStreams = -1338971660,
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                Streams = { new Stream(), },
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableReference = new TableReference(),
                TableModifiers = new TableModifiers(),
                ShardingStrategy = ShardingStrategy.Balanced,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request.TableReference, request.ParentAsProjectName, request.RequestedStreams, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request.TableReference, request.ParentAsProjectName, request.RequestedStreams, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateReadSessionStreamsRequestObject()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = -1338971660,
            };
            BatchCreateReadSessionStreamsResponse expectedResponse = new BatchCreateReadSessionStreamsResponse
            {
                Streams = { new Stream(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateReadSessionStreams(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            BatchCreateReadSessionStreamsResponse response = client.BatchCreateReadSessionStreams(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateReadSessionStreamsRequestObjectAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = -1338971660,
            };
            BatchCreateReadSessionStreamsResponse expectedResponse = new BatchCreateReadSessionStreamsResponse
            {
                Streams = { new Stream(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateReadSessionStreamsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateReadSessionStreamsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            BatchCreateReadSessionStreamsResponse responseCallSettings = await client.BatchCreateReadSessionStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateReadSessionStreamsResponse responseCancellationToken = await client.BatchCreateReadSessionStreamsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateReadSessionStreams()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = -1338971660,
            };
            BatchCreateReadSessionStreamsResponse expectedResponse = new BatchCreateReadSessionStreamsResponse
            {
                Streams = { new Stream(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateReadSessionStreams(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            BatchCreateReadSessionStreamsResponse response = client.BatchCreateReadSessionStreams(request.Session, request.RequestedStreams);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateReadSessionStreamsAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            BatchCreateReadSessionStreamsRequest request = new BatchCreateReadSessionStreamsRequest
            {
                Session = new ReadSession(),
                RequestedStreams = -1338971660,
            };
            BatchCreateReadSessionStreamsResponse expectedResponse = new BatchCreateReadSessionStreamsResponse
            {
                Streams = { new Stream(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateReadSessionStreamsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateReadSessionStreamsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            BatchCreateReadSessionStreamsResponse responseCallSettings = await client.BatchCreateReadSessionStreamsAsync(request.Session, request.RequestedStreams, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateReadSessionStreamsResponse responseCancellationToken = await client.BatchCreateReadSessionStreamsAsync(request.Session, request.RequestedStreams, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinalizeStreamRequestObject()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinalizeStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            client.FinalizeStream(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinalizeStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            await client.FinalizeStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.FinalizeStreamAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinalizeStream()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinalizeStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            client.FinalizeStream(request.Stream);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeStreamAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinalizeStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            await client.FinalizeStreamAsync(request.Stream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.FinalizeStreamAsync(request.Stream, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitReadStreamRequestObject()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
                Fraction = 6.953526E+17F,
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new Stream(),
                RemainderStream = new Stream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse response = client.SplitReadStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitReadStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
                Fraction = 6.953526E+17F,
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new Stream(),
                RemainderStream = new Stream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitReadStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse responseCallSettings = await client.SplitReadStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitReadStreamResponse responseCancellationToken = await client.SplitReadStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitReadStream()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new Stream(),
                RemainderStream = new Stream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse response = client.SplitReadStream(request.OriginalStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitReadStreamAsync()
        {
            moq::Mock<BigQueryStorage.BigQueryStorageClient> mockGrpcClient = new moq::Mock<BigQueryStorage.BigQueryStorageClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                OriginalStream = new Stream(),
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new Stream(),
                RemainderStream = new Stream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitReadStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryStorageClient client = new BigQueryStorageClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse responseCallSettings = await client.SplitReadStreamAsync(request.OriginalStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitReadStreamResponse responseCancellationToken = await client.SplitReadStreamAsync(request.OriginalStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
