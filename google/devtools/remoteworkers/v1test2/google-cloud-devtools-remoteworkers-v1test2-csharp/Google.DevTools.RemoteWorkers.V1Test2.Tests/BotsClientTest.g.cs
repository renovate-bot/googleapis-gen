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

namespace Google.DevTools.RemoteWorkers.V1Test2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBotsClientTest
    {
        [xunit::FactAttribute]
        public void CreateBotSessionRequestObject()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "parent7858e4d0",
                BotSession = new BotSession(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateBotSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession response = client.CreateBotSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBotSessionRequestObjectAsync()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "parent7858e4d0",
                BotSession = new BotSession(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateBotSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BotSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession responseCallSettings = await client.CreateBotSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BotSession responseCancellationToken = await client.CreateBotSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBotSession()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "parent7858e4d0",
                BotSession = new BotSession(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateBotSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession response = client.CreateBotSession(request.Parent, request.BotSession);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBotSessionAsync()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "parent7858e4d0",
                BotSession = new BotSession(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.CreateBotSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BotSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession responseCallSettings = await client.CreateBotSessionAsync(request.Parent, request.BotSession, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BotSession responseCancellationToken = await client.CreateBotSessionAsync(request.Parent, request.BotSession, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBotSessionRequestObject()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession response = client.UpdateBotSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBotSessionRequestObjectAsync()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BotSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession responseCallSettings = await client.UpdateBotSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BotSession responseCancellationToken = await client.UpdateBotSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBotSession()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession response = client.UpdateBotSession(request.Name, request.BotSession, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBotSessionAsync()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BotSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession responseCallSettings = await client.UpdateBotSessionAsync(request.Name, request.BotSession, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BotSession responseCancellationToken = await client.UpdateBotSessionAsync(request.Name, request.BotSession, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBotSessionResourceNames()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession response = client.UpdateBotSession(request.BotSessionName, request.BotSession, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBotSessionResourceNamesAsync()
        {
            moq::Mock<Bots.BotsClient> mockGrpcClient = new moq::Mock<Bots.BotsClient>(moq::MockBehavior.Strict);
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new wkt::FieldMask(),
            };
            BotSession expectedResponse = new BotSession
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotId = "bot_idc2c995d1",
                Status = BotStatus.Unhealthy,
                Worker = new Worker(),
                Leases = { new Lease(), },
                ExpireTime = new wkt::Timestamp(),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.UpdateBotSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BotSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BotsClient client = new BotsClientImpl(mockGrpcClient.Object, null);
            BotSession responseCallSettings = await client.UpdateBotSessionAsync(request.BotSessionName, request.BotSession, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BotSession responseCancellationToken = await client.UpdateBotSessionAsync(request.BotSessionName, request.BotSession, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
