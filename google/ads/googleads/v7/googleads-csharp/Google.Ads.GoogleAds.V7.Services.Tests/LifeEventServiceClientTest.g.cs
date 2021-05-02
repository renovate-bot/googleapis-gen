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

using gagvc = Google.Ads.GoogleAds.V7.Common;
using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V7.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLifeEventServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetLifeEventRequestObject()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent response = client.GetLifeEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLifeEventRequestObjectAsync()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LifeEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent responseCallSettings = await client.GetLifeEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::LifeEvent responseCancellationToken = await client.GetLifeEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLifeEvent()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent response = client.GetLifeEvent(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLifeEventAsync()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LifeEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent responseCallSettings = await client.GetLifeEventAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::LifeEvent responseCancellationToken = await client.GetLifeEventAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLifeEventResourceNames()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent response = client.GetLifeEvent(request.ResourceNameAsLifeEventName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLifeEventResourceNamesAsync()
        {
            moq::Mock<LifeEventService.LifeEventServiceClient> mockGrpcClient = new moq::Mock<LifeEventService.LifeEventServiceClient>(moq::MockBehavior.Strict);
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            gagvr::LifeEvent expectedResponse = new gagvr::LifeEvent
            {
                ResourceNameAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                Id = -6774108720365892680L,
                LifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                ParentAsLifeEventName = gagvr::LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetLifeEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LifeEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LifeEventServiceClient client = new LifeEventServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LifeEvent responseCallSettings = await client.GetLifeEventAsync(request.ResourceNameAsLifeEventName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::LifeEvent responseCancellationToken = await client.GetLifeEventAsync(request.ResourceNameAsLifeEventName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
