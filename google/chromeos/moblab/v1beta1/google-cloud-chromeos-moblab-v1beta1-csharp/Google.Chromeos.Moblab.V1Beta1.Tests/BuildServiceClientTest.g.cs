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

namespace Google.Chromeos.Moblab.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBuildServiceClientTest
    {
        [xunit::FactAttribute]
        public void CheckBuildStageStatusRequestObject()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
                Filter = "filtere47ac9b2",
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse response = client.CheckBuildStageStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckBuildStageStatusRequestObjectAsync()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
                Filter = "filtere47ac9b2",
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckBuildStageStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse responseCallSettings = await client.CheckBuildStageStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckBuildStageStatusResponse responseCancellationToken = await client.CheckBuildStageStatusAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckBuildStageStatus()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse response = client.CheckBuildStageStatus(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckBuildStageStatusAsync()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckBuildStageStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse responseCallSettings = await client.CheckBuildStageStatusAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckBuildStageStatusResponse responseCancellationToken = await client.CheckBuildStageStatusAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckBuildStageStatusResourceNames()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse response = client.CheckBuildStageStatus(request.BuildArtifactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckBuildStageStatusResourceNamesAsync()
        {
            moq::Mock<BuildService.BuildServiceClient> mockGrpcClient = new moq::Mock<BuildService.BuildServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            CheckBuildStageStatusResponse expectedResponse = new CheckBuildStageStatusResponse
            {
                IsBuildStaged = false,
                StagedBuildArtifact = new BuildArtifact(),
                SourceBuildArtifact = new BuildArtifact(),
            };
            mockGrpcClient.Setup(x => x.CheckBuildStageStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckBuildStageStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BuildServiceClient client = new BuildServiceClientImpl(mockGrpcClient.Object, null);
            CheckBuildStageStatusResponse responseCallSettings = await client.CheckBuildStageStatusAsync(request.BuildArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckBuildStageStatusResponse responseCancellationToken = await client.CheckBuildStageStatusAsync(request.BuildArtifactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
