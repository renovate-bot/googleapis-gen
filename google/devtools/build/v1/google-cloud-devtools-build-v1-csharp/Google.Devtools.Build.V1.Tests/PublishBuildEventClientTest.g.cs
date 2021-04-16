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

namespace Google.Devtools.Build.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPublishBuildEventClientTest
    {
        [xunit::FactAttribute]
        public void PublishLifecycleEventRequestObject()
        {
            moq::Mock<PublishBuildEvent.PublishBuildEventClient> mockGrpcClient = new moq::Mock<PublishBuildEvent.PublishBuildEventClient>(moq::MockBehavior.Strict);
            PublishLifecycleEventRequest request = new PublishLifecycleEventRequest
            {
                ServiceLevel = PublishLifecycleEventRequest.Types.ServiceLevel.Interactive,
                BuildEvent = new OrderedBuildEvent(),
                StreamTimeout = new wkt::Duration(),
                NotificationKeywords =
                {
                    "notification_keywordsa0d30c72",
                },
                ProjectId = "project_id43ad98b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PublishLifecycleEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublishBuildEventClient client = new PublishBuildEventClientImpl(mockGrpcClient.Object, null);
            client.PublishLifecycleEvent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishLifecycleEventRequestObjectAsync()
        {
            moq::Mock<PublishBuildEvent.PublishBuildEventClient> mockGrpcClient = new moq::Mock<PublishBuildEvent.PublishBuildEventClient>(moq::MockBehavior.Strict);
            PublishLifecycleEventRequest request = new PublishLifecycleEventRequest
            {
                ServiceLevel = PublishLifecycleEventRequest.Types.ServiceLevel.Interactive,
                BuildEvent = new OrderedBuildEvent(),
                StreamTimeout = new wkt::Duration(),
                NotificationKeywords =
                {
                    "notification_keywordsa0d30c72",
                },
                ProjectId = "project_id43ad98b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PublishLifecycleEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublishBuildEventClient client = new PublishBuildEventClientImpl(mockGrpcClient.Object, null);
            await client.PublishLifecycleEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PublishLifecycleEventAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
