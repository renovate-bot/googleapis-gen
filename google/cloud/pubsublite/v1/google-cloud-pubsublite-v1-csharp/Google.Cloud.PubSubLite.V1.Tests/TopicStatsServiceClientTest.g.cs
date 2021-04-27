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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSubLite.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTopicStatsServiceClientTest
    {
        [xunit::FactAttribute]
        public void ComputeMessageStatsRequestObject()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeMessageStatsRequest request = new ComputeMessageStatsRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
                StartCursor = new Cursor(),
                EndCursor = new Cursor(),
            };
            ComputeMessageStatsResponse expectedResponse = new ComputeMessageStatsResponse
            {
                MessageCount = 1562514399579181631L,
                MessageBytes = -6873709759487480412L,
                MinimumPublishTime = new wkt::Timestamp(),
                MinimumEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.ComputeMessageStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeMessageStatsResponse response = client.ComputeMessageStats(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeMessageStatsRequestObjectAsync()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeMessageStatsRequest request = new ComputeMessageStatsRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
                StartCursor = new Cursor(),
                EndCursor = new Cursor(),
            };
            ComputeMessageStatsResponse expectedResponse = new ComputeMessageStatsResponse
            {
                MessageCount = 1562514399579181631L,
                MessageBytes = -6873709759487480412L,
                MinimumPublishTime = new wkt::Timestamp(),
                MinimumEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.ComputeMessageStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeMessageStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeMessageStatsResponse responseCallSettings = await client.ComputeMessageStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeMessageStatsResponse responseCancellationToken = await client.ComputeMessageStatsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ComputeHeadCursorRequestObject()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeHeadCursorRequest request = new ComputeHeadCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
            };
            ComputeHeadCursorResponse expectedResponse = new ComputeHeadCursorResponse
            {
                HeadCursor = new Cursor(),
            };
            mockGrpcClient.Setup(x => x.ComputeHeadCursor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeHeadCursorResponse response = client.ComputeHeadCursor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeHeadCursorRequestObjectAsync()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeHeadCursorRequest request = new ComputeHeadCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
            };
            ComputeHeadCursorResponse expectedResponse = new ComputeHeadCursorResponse
            {
                HeadCursor = new Cursor(),
            };
            mockGrpcClient.Setup(x => x.ComputeHeadCursorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeHeadCursorResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeHeadCursorResponse responseCallSettings = await client.ComputeHeadCursorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeHeadCursorResponse responseCancellationToken = await client.ComputeHeadCursorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ComputeTimeCursorRequestObject()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeTimeCursorRequest request = new ComputeTimeCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
                Target = new TimeTarget(),
            };
            ComputeTimeCursorResponse expectedResponse = new ComputeTimeCursorResponse
            {
                Cursor = new Cursor(),
            };
            mockGrpcClient.Setup(x => x.ComputeTimeCursor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeTimeCursorResponse response = client.ComputeTimeCursor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeTimeCursorRequestObjectAsync()
        {
            moq::Mock<TopicStatsService.TopicStatsServiceClient> mockGrpcClient = new moq::Mock<TopicStatsService.TopicStatsServiceClient>(moq::MockBehavior.Strict);
            ComputeTimeCursorRequest request = new ComputeTimeCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 6389717982397469552L,
                Target = new TimeTarget(),
            };
            ComputeTimeCursorResponse expectedResponse = new ComputeTimeCursorResponse
            {
                Cursor = new Cursor(),
            };
            mockGrpcClient.Setup(x => x.ComputeTimeCursorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeTimeCursorResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicStatsServiceClient client = new TopicStatsServiceClientImpl(mockGrpcClient.Object, null);
            ComputeTimeCursorResponse responseCallSettings = await client.ComputeTimeCursorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeTimeCursorResponse responseCancellationToken = await client.ComputeTimeCursorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
