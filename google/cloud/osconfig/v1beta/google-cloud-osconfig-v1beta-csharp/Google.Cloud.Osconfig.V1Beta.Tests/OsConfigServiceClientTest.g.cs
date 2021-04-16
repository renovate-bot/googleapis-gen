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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Osconfig.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOsConfigServiceClientTest
    {
        [xunit::FactAttribute]
        public void ExecutePatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                Parent = "parent7858e4d0",
                Description = "description2cf9da67",
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                DryRun = true,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.ExecutePatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.ExecutePatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecutePatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                Parent = "parent7858e4d0",
                Description = "description2cf9da67",
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                DryRun = true,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.ExecutePatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.ExecutePatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.ExecutePatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                Name = "name1c9368b0",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.GetPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.GetPatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                Name = "name1c9368b0",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.GetPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.GetPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.GetPatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelPatchJobRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                Name = "name1c9368b0",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.CancelPatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob response = client.CancelPatchJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelPatchJobRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                Name = "name1c9368b0",
            };
            PatchJob expectedResponse = new PatchJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = PatchJob.Types.State.Canceled,
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                InstanceDetailsSummary = new PatchJob.Types.InstanceDetailsSummary(),
                DryRun = true,
                ErrorMessage = "error_messaged73952bd",
                PercentComplete = 67289115664290224,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "display_name137f65c2",
                PatchDeployment = "patch_deploymentf74a6fd0",
            };
            mockGrpcClient.Setup(x => x.CancelPatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchJob responseCallSettings = await client.CancelPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchJob responseCancellationToken = await client.CancelPatchJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                Parent = "parent7858e4d0",
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.CreatePatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                Parent = "parent7858e4d0",
                PatchDeploymentId = "patch_deployment_id084ea38b",
                PatchDeployment = new PatchDeployment(),
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.CreatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.CreatePatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                Name = "name1c9368b0",
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment response = client.GetPatchDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                Name = "name1c9368b0",
            };
            PatchDeployment expectedResponse = new PatchDeployment
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InstanceFilter = new PatchInstanceFilter(),
                PatchConfig = new PatchConfig(),
                Duration = new wkt::Duration(),
                OneTimeSchedule = new OneTimeSchedule(),
                RecurringSchedule = new RecurringSchedule(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastExecuteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PatchDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            PatchDeployment responseCallSettings = await client.GetPatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PatchDeployment responseCancellationToken = await client.GetPatchDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePatchDeploymentRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePatchDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePatchDeploymentRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePatchDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePatchDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGuestPolicyRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicyId = "guest_policy_id698c9881",
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.CreateGuestPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGuestPolicyRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicyId = "guest_policy_id698c9881",
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.CreateGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.CreateGuestPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGuestPolicy()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.CreateGuestPolicy(request.Parent, request.GuestPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGuestPolicyAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.CreateGuestPolicyAsync(request.Parent, request.GuestPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.CreateGuestPolicyAsync(request.Parent, request.GuestPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGuestPolicyResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.CreateGuestPolicy(request.ParentAsProjectName, request.GuestPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGuestPolicyResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                GuestPolicy = new GuestPolicy(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.CreateGuestPolicyAsync(request.ParentAsProjectName, request.GuestPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.CreateGuestPolicyAsync(request.ParentAsProjectName, request.GuestPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestPolicyRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.GetGuestPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestPolicyRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.GetGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.GetGuestPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestPolicy()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.GetGuestPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestPolicyAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.GetGuestPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.GetGuestPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestPolicyResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.GetGuestPolicy(request.GuestPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestPolicyResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.GetGuestPolicyAsync(request.GuestPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.GetGuestPolicyAsync(request.GuestPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGuestPolicyRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.UpdateGuestPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGuestPolicyRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.UpdateGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.UpdateGuestPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGuestPolicy()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy response = client.UpdateGuestPolicy(request.GuestPolicy, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGuestPolicyAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            GuestPolicy expectedResponse = new GuestPolicy
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Assignment = new Assignment(),
                Packages = { new Package(), },
                PackageRepositories =
                {
                    new PackageRepository(),
                },
                Recipes =
                {
                    new SoftwareRecipe(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            GuestPolicy responseCallSettings = await client.UpdateGuestPolicyAsync(request.GuestPolicy, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestPolicy responseCancellationToken = await client.UpdateGuestPolicyAsync(request.GuestPolicy, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGuestPolicyRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGuestPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGuestPolicyRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGuestPolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGuestPolicy()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGuestPolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGuestPolicyAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGuestPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGuestPolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGuestPolicyResourceNames()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGuestPolicy(request.GuestPolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGuestPolicyResourceNamesAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGuestPolicyAsync(request.GuestPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGuestPolicyAsync(request.GuestPolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupEffectiveGuestPolicyRequestObject()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            LookupEffectiveGuestPolicyRequest request = new LookupEffectiveGuestPolicyRequest
            {
                Instance = "instance99a62371",
                OsShortName = "os_short_name9fb1ea45",
                OsVersion = "os_versionc4976daf",
                OsArchitecture = "os_architecture40da382d",
            };
            EffectiveGuestPolicy expectedResponse = new EffectiveGuestPolicy
            {
                Packages =
                {
                    new EffectiveGuestPolicy.Types.SourcedPackage(),
                },
                PackageRepositories =
                {
                    new EffectiveGuestPolicy.Types.SourcedPackageRepository(),
                },
                SoftwareRecipes =
                {
                    new EffectiveGuestPolicy.Types.SourcedSoftwareRecipe(),
                },
            };
            mockGrpcClient.Setup(x => x.LookupEffectiveGuestPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            EffectiveGuestPolicy response = client.LookupEffectiveGuestPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupEffectiveGuestPolicyRequestObjectAsync()
        {
            moq::Mock<OsConfigService.OsConfigServiceClient> mockGrpcClient = new moq::Mock<OsConfigService.OsConfigServiceClient>(moq::MockBehavior.Strict);
            LookupEffectiveGuestPolicyRequest request = new LookupEffectiveGuestPolicyRequest
            {
                Instance = "instance99a62371",
                OsShortName = "os_short_name9fb1ea45",
                OsVersion = "os_versionc4976daf",
                OsArchitecture = "os_architecture40da382d",
            };
            EffectiveGuestPolicy expectedResponse = new EffectiveGuestPolicy
            {
                Packages =
                {
                    new EffectiveGuestPolicy.Types.SourcedPackage(),
                },
                PackageRepositories =
                {
                    new EffectiveGuestPolicy.Types.SourcedPackageRepository(),
                },
                SoftwareRecipes =
                {
                    new EffectiveGuestPolicy.Types.SourcedSoftwareRecipe(),
                },
            };
            mockGrpcClient.Setup(x => x.LookupEffectiveGuestPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EffectiveGuestPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigServiceClient client = new OsConfigServiceClientImpl(mockGrpcClient.Object, null);
            EffectiveGuestPolicy responseCallSettings = await client.LookupEffectiveGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EffectiveGuestPolicy responseCancellationToken = await client.LookupEffectiveGuestPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
