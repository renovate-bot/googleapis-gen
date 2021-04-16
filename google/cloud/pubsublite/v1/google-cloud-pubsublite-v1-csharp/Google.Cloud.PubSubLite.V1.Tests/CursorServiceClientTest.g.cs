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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSubLite.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCursorServiceClientTest
    {
        [xunit::FactAttribute]
        public void CommitCursorRequestObject()
        {
            moq::Mock<CursorService.CursorServiceClient> mockGrpcClient = new moq::Mock<CursorService.CursorServiceClient>(moq::MockBehavior.Strict);
            CommitCursorRequest request = new CommitCursorRequest
            {
                Subscription = "subscriptione7138bb4",
                Partition = 6389717982397469552L,
                Cursor = new Cursor(),
            };
            CommitCursorResponse expectedResponse = new CommitCursorResponse { };
            mockGrpcClient.Setup(x => x.CommitCursor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CursorServiceClient client = new CursorServiceClientImpl(mockGrpcClient.Object, null);
            CommitCursorResponse response = client.CommitCursor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitCursorRequestObjectAsync()
        {
            moq::Mock<CursorService.CursorServiceClient> mockGrpcClient = new moq::Mock<CursorService.CursorServiceClient>(moq::MockBehavior.Strict);
            CommitCursorRequest request = new CommitCursorRequest
            {
                Subscription = "subscriptione7138bb4",
                Partition = 6389717982397469552L,
                Cursor = new Cursor(),
            };
            CommitCursorResponse expectedResponse = new CommitCursorResponse { };
            mockGrpcClient.Setup(x => x.CommitCursorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitCursorResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CursorServiceClient client = new CursorServiceClientImpl(mockGrpcClient.Object, null);
            CommitCursorResponse responseCallSettings = await client.CommitCursorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitCursorResponse responseCancellationToken = await client.CommitCursorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
