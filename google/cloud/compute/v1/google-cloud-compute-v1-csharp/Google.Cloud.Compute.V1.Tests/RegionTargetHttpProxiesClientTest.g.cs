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

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegionTargetHttpProxiesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy response = client.Get(request.Project, request.Region, request.TargetHttpProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetHttpProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxy responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetHttpProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
