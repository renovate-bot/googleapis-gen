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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.MetricsScope.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetricsScopesClientTest
    {
        [xunit::FactAttribute]
        public void GetMetricsScopeRequestObject()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScope(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope response = client.GetMetricsScope(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsScopeRequestObjectAsync()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScopeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetricsScope>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope responseCallSettings = await client.GetMetricsScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetricsScope responseCancellationToken = await client.GetMetricsScopeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricsScope()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScope(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope response = client.GetMetricsScope(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsScopeAsync()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScopeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetricsScope>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope responseCallSettings = await client.GetMetricsScopeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetricsScope responseCancellationToken = await client.GetMetricsScopeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricsScopeResourceNames()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScope(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope response = client.GetMetricsScope(request.MetricsScopeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricsScopeResourceNamesAsync()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            MetricsScope expectedResponse = new MetricsScope
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MonitoredProjects =
                {
                    new MonitoredProject(),
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricsScopeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetricsScope>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            MetricsScope responseCallSettings = await client.GetMetricsScopeAsync(request.MetricsScopeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetricsScope responseCancellationToken = await client.GetMetricsScopeAsync(request.MetricsScopeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListMetricsScopesByMonitoredProjectRequestObject()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListMetricsScopesByMonitoredProjectRequest request = new ListMetricsScopesByMonitoredProjectRequest
            {
                MonitoredResourceContainer = "monitored_resource_container3f461cd8",
            };
            ListMetricsScopesByMonitoredProjectResponse expectedResponse = new ListMetricsScopesByMonitoredProjectResponse
            {
                MetricsScopes = { new MetricsScope(), },
            };
            mockGrpcClient.Setup(x => x.ListMetricsScopesByMonitoredProject(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            ListMetricsScopesByMonitoredProjectResponse response = client.ListMetricsScopesByMonitoredProject(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListMetricsScopesByMonitoredProjectRequestObjectAsync()
        {
            moq::Mock<MetricsScopes.MetricsScopesClient> mockGrpcClient = new moq::Mock<MetricsScopes.MetricsScopesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListMetricsScopesByMonitoredProjectRequest request = new ListMetricsScopesByMonitoredProjectRequest
            {
                MonitoredResourceContainer = "monitored_resource_container3f461cd8",
            };
            ListMetricsScopesByMonitoredProjectResponse expectedResponse = new ListMetricsScopesByMonitoredProjectResponse
            {
                MetricsScopes = { new MetricsScope(), },
            };
            mockGrpcClient.Setup(x => x.ListMetricsScopesByMonitoredProjectAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListMetricsScopesByMonitoredProjectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsScopesClient client = new MetricsScopesClientImpl(mockGrpcClient.Object, null);
            ListMetricsScopesByMonitoredProjectResponse responseCallSettings = await client.ListMetricsScopesByMonitoredProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListMetricsScopesByMonitoredProjectResponse responseCancellationToken = await client.ListMetricsScopesByMonitoredProjectAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
