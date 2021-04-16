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

namespace Google.Home.Graph.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedHomeGraphApiServiceClientTest
    {
        [xunit::FactAttribute]
        public void RequestSyncDevicesRequestObject()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "agent_user_idda70a254",
                Async = true,
            };
            RequestSyncDevicesResponse expectedResponse = new RequestSyncDevicesResponse { };
            mockGrpcClient.Setup(x => x.RequestSyncDevices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            RequestSyncDevicesResponse response = client.RequestSyncDevices(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RequestSyncDevicesRequestObjectAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "agent_user_idda70a254",
                Async = true,
            };
            RequestSyncDevicesResponse expectedResponse = new RequestSyncDevicesResponse { };
            mockGrpcClient.Setup(x => x.RequestSyncDevicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RequestSyncDevicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            RequestSyncDevicesResponse responseCallSettings = await client.RequestSyncDevicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RequestSyncDevicesResponse responseCancellationToken = await client.RequestSyncDevicesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RequestSyncDevices()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "agent_user_idda70a254",
            };
            RequestSyncDevicesResponse expectedResponse = new RequestSyncDevicesResponse { };
            mockGrpcClient.Setup(x => x.RequestSyncDevices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            RequestSyncDevicesResponse response = client.RequestSyncDevices(request.AgentUserId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RequestSyncDevicesAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "agent_user_idda70a254",
            };
            RequestSyncDevicesResponse expectedResponse = new RequestSyncDevicesResponse { };
            mockGrpcClient.Setup(x => x.RequestSyncDevicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RequestSyncDevicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            RequestSyncDevicesResponse responseCallSettings = await client.RequestSyncDevicesAsync(request.AgentUserId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RequestSyncDevicesResponse responseCancellationToken = await client.RequestSyncDevicesAsync(request.AgentUserId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportStateAndNotificationRequestObject()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Payload = new StateAndNotificationPayload(),
                EventId = "event_idaccf3744",
#pragma warning disable CS0612
                FollowUpToken = "follow_up_token95c59fe2",
#pragma warning restore CS0612
            };
            ReportStateAndNotificationResponse expectedResponse = new ReportStateAndNotificationResponse
            {
                RequestId = "request_id362c8df6",
            };
            mockGrpcClient.Setup(x => x.ReportStateAndNotification(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            ReportStateAndNotificationResponse response = client.ReportStateAndNotification(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportStateAndNotificationRequestObjectAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Payload = new StateAndNotificationPayload(),
                EventId = "event_idaccf3744",
#pragma warning disable CS0612
                FollowUpToken = "follow_up_token95c59fe2",
#pragma warning restore CS0612
            };
            ReportStateAndNotificationResponse expectedResponse = new ReportStateAndNotificationResponse
            {
                RequestId = "request_id362c8df6",
            };
            mockGrpcClient.Setup(x => x.ReportStateAndNotificationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportStateAndNotificationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            ReportStateAndNotificationResponse responseCallSettings = await client.ReportStateAndNotificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportStateAndNotificationResponse responseCancellationToken = await client.ReportStateAndNotificationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportStateAndNotification()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Payload = new StateAndNotificationPayload(),
                EventId = "event_idaccf3744",
            };
            ReportStateAndNotificationResponse expectedResponse = new ReportStateAndNotificationResponse
            {
                RequestId = "request_id362c8df6",
            };
            mockGrpcClient.Setup(x => x.ReportStateAndNotification(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            ReportStateAndNotificationResponse response = client.ReportStateAndNotification(request.RequestId, request.EventId, request.AgentUserId, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportStateAndNotificationAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Payload = new StateAndNotificationPayload(),
                EventId = "event_idaccf3744",
            };
            ReportStateAndNotificationResponse expectedResponse = new ReportStateAndNotificationResponse
            {
                RequestId = "request_id362c8df6",
            };
            mockGrpcClient.Setup(x => x.ReportStateAndNotificationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportStateAndNotificationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            ReportStateAndNotificationResponse responseCallSettings = await client.ReportStateAndNotificationAsync(request.RequestId, request.EventId, request.AgentUserId, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportStateAndNotificationResponse responseCancellationToken = await client.ReportStateAndNotificationAsync(request.RequestId, request.EventId, request.AgentUserId, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentUserRequestObject()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUser(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAgentUser(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentUserRequestObjectAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUserAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAgentUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentUserAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentUser()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUser(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAgentUser(request.RequestId, request.AgentUserId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentUserAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUserAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAgentUserAsync(request.RequestId, request.AgentUserId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentUserAsync(request.RequestId, request.AgentUserId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentUserResourceNames()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUser(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAgentUser(request.RequestId, request.AgentUserIdAsAgentUserPathName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentUserResourceNamesAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentUserAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAgentUserAsync(request.RequestId, request.AgentUserIdAsAgentUserPathName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentUserAsync(request.RequestId, request.AgentUserIdAsAgentUserPathName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryRequestObject()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            QueryRequest request = new QueryRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            QueryResponse expectedResponse = new QueryResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new QueryResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.Query(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            QueryResponse response = client.Query(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryRequestObjectAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            QueryRequest request = new QueryRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            QueryResponse expectedResponse = new QueryResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new QueryResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.QueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<QueryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            QueryResponse responseCallSettings = await client.QueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            QueryResponse responseCancellationToken = await client.QueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Query()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            QueryRequest request = new QueryRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            QueryResponse expectedResponse = new QueryResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new QueryResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.Query(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            QueryResponse response = client.Query(request.RequestId, request.AgentUserId, request.Inputs);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            QueryRequest request = new QueryRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            QueryResponse expectedResponse = new QueryResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new QueryResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.QueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<QueryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            QueryResponse responseCallSettings = await client.QueryAsync(request.RequestId, request.AgentUserId, request.Inputs, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            QueryResponse responseCancellationToken = await client.QueryAsync(request.RequestId, request.AgentUserId, request.Inputs, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SyncRequestObject()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            SyncRequest request = new SyncRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
            };
            SyncResponse expectedResponse = new SyncResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new SyncResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.Sync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            SyncResponse response = client.Sync(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SyncRequestObjectAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            SyncRequest request = new SyncRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
            };
            SyncResponse expectedResponse = new SyncResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new SyncResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.SyncAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SyncResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            SyncResponse responseCallSettings = await client.SyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SyncResponse responseCancellationToken = await client.SyncAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Sync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            SyncRequest request = new SyncRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
            };
            SyncResponse expectedResponse = new SyncResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new SyncResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.Sync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            SyncResponse response = client.Sync(request.RequestId, request.AgentUserId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SyncAsync()
        {
            moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient> mockGrpcClient = new moq::Mock<HomeGraphApiService.HomeGraphApiServiceClient>(moq::MockBehavior.Strict);
            SyncRequest request = new SyncRequest
            {
                RequestId = "request_id362c8df6",
                AgentUserId = "agent_user_idda70a254",
            };
            SyncResponse expectedResponse = new SyncResponse
            {
                RequestId = "request_id362c8df6",
                Payload = new SyncResponsePayload(),
            };
            mockGrpcClient.Setup(x => x.SyncAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SyncResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HomeGraphApiServiceClient client = new HomeGraphApiServiceClientImpl(mockGrpcClient.Object, null);
            SyncResponse responseCallSettings = await client.SyncAsync(request.RequestId, request.AgentUserId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SyncResponse responseCancellationToken = await client.SyncAsync(request.RequestId, request.AgentUserId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
