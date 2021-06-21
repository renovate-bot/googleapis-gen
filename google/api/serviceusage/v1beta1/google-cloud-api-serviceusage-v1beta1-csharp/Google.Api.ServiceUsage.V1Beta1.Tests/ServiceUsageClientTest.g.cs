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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Api.ServiceUsage.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServiceUsageClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                Name = "name1c9368b0",
            };
            Service expectedResponse = new Service
            {
                Name = "name1c9368b0",
                Config = new ServiceConfig(),
                State = State.Unspecified,
                Parent = "parent7858e4d0",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            Service response = client.GetService(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                Name = "name1c9368b0",
            };
            Service expectedResponse = new Service
            {
                Name = "name1c9368b0",
                Config = new ServiceConfig(),
                State = State.Unspecified,
                Parent = "parent7858e4d0",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConsumerQuotaMetricRequestObject()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConsumerQuotaMetricRequest request = new GetConsumerQuotaMetricRequest
            {
                Name = "name1c9368b0",
                View = QuotaView.Basic,
            };
            ConsumerQuotaMetric expectedResponse = new ConsumerQuotaMetric
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                ConsumerQuotaLimits =
                {
                    new ConsumerQuotaLimit(),
                },
                Metric = "metric5283bc2c",
                Unit = "unitebbd343e",
                DescendantConsumerQuotaLimits =
                {
                    new ConsumerQuotaLimit(),
                },
            };
            mockGrpcClient.Setup(x => x.GetConsumerQuotaMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
            ConsumerQuotaMetric response = client.GetConsumerQuotaMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConsumerQuotaMetricRequestObjectAsync()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConsumerQuotaMetricRequest request = new GetConsumerQuotaMetricRequest
            {
                Name = "name1c9368b0",
                View = QuotaView.Basic,
            };
            ConsumerQuotaMetric expectedResponse = new ConsumerQuotaMetric
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                ConsumerQuotaLimits =
                {
                    new ConsumerQuotaLimit(),
                },
                Metric = "metric5283bc2c",
                Unit = "unitebbd343e",
                DescendantConsumerQuotaLimits =
                {
                    new ConsumerQuotaLimit(),
                },
            };
            mockGrpcClient.Setup(x => x.GetConsumerQuotaMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConsumerQuotaMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
            ConsumerQuotaMetric responseCallSettings = await client.GetConsumerQuotaMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConsumerQuotaMetric responseCancellationToken = await client.GetConsumerQuotaMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConsumerQuotaLimitRequestObject()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConsumerQuotaLimitRequest request = new GetConsumerQuotaLimitRequest
            {
                Name = "name1c9368b0",
                View = QuotaView.Basic,
            };
            ConsumerQuotaLimit expectedResponse = new ConsumerQuotaLimit
            {
                Name = "name1c9368b0",
                Unit = "unitebbd343e",
                IsPrecise = true,
                AllowsAdminOverrides = true,
                Metric = "metric5283bc2c",
                QuotaBuckets = { new QuotaBucket(), },
            };
            mockGrpcClient.Setup(x => x.GetConsumerQuotaLimit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
            ConsumerQuotaLimit response = client.GetConsumerQuotaLimit(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConsumerQuotaLimitRequestObjectAsync()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConsumerQuotaLimitRequest request = new GetConsumerQuotaLimitRequest
            {
                Name = "name1c9368b0",
                View = QuotaView.Basic,
            };
            ConsumerQuotaLimit expectedResponse = new ConsumerQuotaLimit
            {
                Name = "name1c9368b0",
                Unit = "unitebbd343e",
                IsPrecise = true,
                AllowsAdminOverrides = true,
                Metric = "metric5283bc2c",
                QuotaBuckets = { new QuotaBucket(), },
            };
            mockGrpcClient.Setup(x => x.GetConsumerQuotaLimitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConsumerQuotaLimit>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null);
            ConsumerQuotaLimit responseCallSettings = await client.GetConsumerQuotaLimitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConsumerQuotaLimit responseCancellationToken = await client.GetConsumerQuotaLimitAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
