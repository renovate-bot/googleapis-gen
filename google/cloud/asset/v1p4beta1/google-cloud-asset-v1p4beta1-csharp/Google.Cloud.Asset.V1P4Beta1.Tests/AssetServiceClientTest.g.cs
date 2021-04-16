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

namespace Google.Cloud.Asset.V1P4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetServiceClientTest
    {
        [xunit::FactAttribute]
        public void AnalyzeIamPolicyRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                Options = new AnalyzeIamPolicyRequest.Types.Options(),
            };
            AnalyzeIamPolicyResponse expectedResponse = new AnalyzeIamPolicyResponse
            {
                MainAnalysis = new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                ServiceAccountImpersonationAnalysis =
                {
                    new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                },
                FullyExplored = false,
                NonCriticalErrors =
                {
                    new IamPolicyAnalysisResult.Types.AnalysisState(),
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeIamPolicyResponse response = client.AnalyzeIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeIamPolicyRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                Options = new AnalyzeIamPolicyRequest.Types.Options(),
            };
            AnalyzeIamPolicyResponse expectedResponse = new AnalyzeIamPolicyResponse
            {
                MainAnalysis = new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                ServiceAccountImpersonationAnalysis =
                {
                    new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                },
                FullyExplored = false,
                NonCriticalErrors =
                {
                    new IamPolicyAnalysisResult.Types.AnalysisState(),
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeIamPolicyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeIamPolicyResponse responseCallSettings = await client.AnalyzeIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeIamPolicyResponse responseCancellationToken = await client.AnalyzeIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
