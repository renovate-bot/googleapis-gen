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

namespace Google.Monitoring.Dashboard.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDashboardsServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateDashboardRequestObject()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            CreateDashboardRequest request = new CreateDashboardRequest
            {
                Parent = "parent7858e4d0",
                Dashboard = new Dashboard(),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.CreateDashboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard response = client.CreateDashboard(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDashboardRequestObjectAsync()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            CreateDashboardRequest request = new CreateDashboardRequest
            {
                Parent = "parent7858e4d0",
                Dashboard = new Dashboard(),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.CreateDashboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dashboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard responseCallSettings = await client.CreateDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dashboard responseCancellationToken = await client.CreateDashboardAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDashboardRequestObject()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            GetDashboardRequest request = new GetDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.GetDashboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard response = client.GetDashboard(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDashboardRequestObjectAsync()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            GetDashboardRequest request = new GetDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.GetDashboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dashboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard responseCallSettings = await client.GetDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dashboard responseCancellationToken = await client.GetDashboardAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDashboardRequestObject()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            DeleteDashboardRequest request = new DeleteDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDashboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDashboard(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDashboardRequestObjectAsync()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            DeleteDashboardRequest request = new DeleteDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDashboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDashboardAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDashboardRequestObject()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            UpdateDashboardRequest request = new UpdateDashboardRequest
            {
                Dashboard = new Dashboard(),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.UpdateDashboard(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard response = client.UpdateDashboard(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDashboardRequestObjectAsync()
        {
            moq::Mock<DashboardsService.DashboardsServiceClient> mockGrpcClient = new moq::Mock<DashboardsService.DashboardsServiceClient>(moq::MockBehavior.Strict);
            UpdateDashboardRequest request = new UpdateDashboardRequest
            {
                Dashboard = new Dashboard(),
            };
            Dashboard expectedResponse = new Dashboard
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
                DisplayName = "display_name137f65c2",
                Etag = "etage8ad7218",
                GridLayout = new GridLayout(),
                MosaicLayout = new MosaicLayout(),
                RowLayout = new RowLayout(),
                ColumnLayout = new ColumnLayout(),
            };
            mockGrpcClient.Setup(x => x.UpdateDashboardAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Dashboard>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DashboardsServiceClient client = new DashboardsServiceClientImpl(mockGrpcClient.Object, null);
            Dashboard responseCallSettings = await client.UpdateDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Dashboard responseCancellationToken = await client.UpdateDashboardAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
