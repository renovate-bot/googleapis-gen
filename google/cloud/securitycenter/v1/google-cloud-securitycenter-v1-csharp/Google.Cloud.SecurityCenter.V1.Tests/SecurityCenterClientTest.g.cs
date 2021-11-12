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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.SecurityCenter.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSecurityCenterClientTest
    {
        [xunit::FactAttribute]
        public void CreateSourceRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.CreateSource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSourceRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.CreateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.CreateSourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSource()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.CreateSource(request.Parent, request.Source);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSourceAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.CreateSourceAsync(request.Parent, request.Source, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.CreateSourceAsync(request.Parent, request.Source, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSourceResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.CreateSource(request.ParentAsOrganizationName, request.Source);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSourceResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.CreateSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.CreateSourceAsync(request.ParentAsOrganizationName, request.Source, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.CreateSourceAsync(request.ParentAsOrganizationName, request.Source, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFindingRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.CreateFinding(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFindingRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.CreateFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.CreateFindingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFinding()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.CreateFinding(request.Parent, request.FindingId, request.Finding);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFindingAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.CreateFindingAsync(request.Parent, request.FindingId, request.Finding, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.CreateFindingAsync(request.Parent, request.FindingId, request.Finding, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFindingResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.CreateFinding(request.ParentAsSourceName, request.FindingId, request.Finding);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFindingResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "finding_idcb48e4ee",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.CreateFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.CreateFindingAsync(request.ParentAsSourceName, request.FindingId, request.Finding, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.CreateFindingAsync(request.ParentAsSourceName, request.FindingId, request.Finding, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig1()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.Parent, request.MuteConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig1Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.Parent, request.MuteConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.Parent, request.MuteConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig1ResourceNames1()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsOrganizationName, request.MuteConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig1ResourceNames1Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsOrganizationName, request.MuteConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsOrganizationName, request.MuteConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig1ResourceNames2()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsFolderName, request.MuteConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig1ResourceNames2Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsFolderName, request.MuteConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsFolderName, request.MuteConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig1ResourceNames3()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsProjectName, request.MuteConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig1ResourceNames3Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsProjectName, request.MuteConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsProjectName, request.MuteConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig2()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.Parent, request.MuteConfig, request.MuteConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig2Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.Parent, request.MuteConfig, request.MuteConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.Parent, request.MuteConfig, request.MuteConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig2ResourceNames1()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsOrganizationName, request.MuteConfig, request.MuteConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig2ResourceNames1Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsOrganizationName, request.MuteConfig, request.MuteConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsOrganizationName, request.MuteConfig, request.MuteConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig2ResourceNames2()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsFolderName, request.MuteConfig, request.MuteConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig2ResourceNames2Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsFolderName, request.MuteConfig, request.MuteConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsFolderName, request.MuteConfig, request.MuteConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMuteConfig2ResourceNames3()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.CreateMuteConfig(request.ParentAsProjectName, request.MuteConfig, request.MuteConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMuteConfig2ResourceNames3Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "mute_config_id3601727e",
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.CreateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.CreateMuteConfigAsync(request.ParentAsProjectName, request.MuteConfig, request.MuteConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.CreateMuteConfigAsync(request.ParentAsProjectName, request.MuteConfig, request.MuteConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.CreateNotificationConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.CreateNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.CreateNotificationConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationConfig1()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.CreateNotificationConfig(request.Parent, request.ConfigId, request.NotificationConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationConfig1Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.CreateNotificationConfigAsync(request.Parent, request.ConfigId, request.NotificationConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.CreateNotificationConfigAsync(request.Parent, request.ConfigId, request.NotificationConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationConfig1ResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.CreateNotificationConfig(request.ParentAsOrganizationName, request.ConfigId, request.NotificationConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationConfig1ResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                ConfigId = "config_id908a73d1",
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.CreateNotificationConfigAsync(request.ParentAsOrganizationName, request.ConfigId, request.NotificationConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.CreateNotificationConfigAsync(request.ParentAsOrganizationName, request.ConfigId, request.NotificationConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationConfig2()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.CreateNotificationConfig(request.Parent, request.NotificationConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationConfig2Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.CreateNotificationConfigAsync(request.Parent, request.NotificationConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.CreateNotificationConfigAsync(request.Parent, request.NotificationConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationConfig2ResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.CreateNotificationConfig(request.ParentAsOrganizationName, request.NotificationConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationConfig2ResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.CreateNotificationConfigAsync(request.ParentAsOrganizationName, request.NotificationConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.CreateNotificationConfigAsync(request.ParentAsOrganizationName, request.NotificationConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMuteConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteMuteConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMuteConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMuteConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMuteConfig()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteMuteConfig(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMuteConfigAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMuteConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMuteConfigAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMuteConfigResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteMuteConfig(request.MuteConfigName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMuteConfigResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMuteConfigAsync(request.MuteConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMuteConfigAsync(request.MuteConfigName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationConfig()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationConfig(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationConfigAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationConfigAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationConfigResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationConfig(request.NotificationConfigName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationConfigResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationConfigAsync(request.NotificationConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationConfigAsync(request.NotificationConfigName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMuteConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.GetMuteConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMuteConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.GetMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.GetMuteConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMuteConfig()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.GetMuteConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMuteConfigAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.GetMuteConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.GetMuteConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMuteConfigResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.GetMuteConfig(request.MuteConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMuteConfigResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.GetMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.GetMuteConfigAsync(request.MuteConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.GetMuteConfigAsync(request.MuteConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.GetNotificationConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.GetNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.GetNotificationConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationConfig()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.GetNotificationConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationConfigAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.GetNotificationConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.GetNotificationConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationConfigResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.GetNotificationConfig(request.NotificationConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationConfigResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.GetNotificationConfigAsync(request.NotificationConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.GetNotificationConfigAsync(request.NotificationConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOrganizationSettingsRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.GetOrganizationSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOrganizationSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OrganizationSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings responseCallSettings = await client.GetOrganizationSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OrganizationSettings responseCancellationToken = await client.GetOrganizationSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOrganizationSettings()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.GetOrganizationSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOrganizationSettingsAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OrganizationSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings responseCallSettings = await client.GetOrganizationSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OrganizationSettings responseCancellationToken = await client.GetOrganizationSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOrganizationSettingsResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.GetOrganizationSettings(request.OrganizationSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOrganizationSettingsResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OrganizationSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings responseCallSettings = await client.GetOrganizationSettingsAsync(request.OrganizationSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OrganizationSettings responseCancellationToken = await client.GetOrganizationSettingsAsync(request.OrganizationSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSourceRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSource()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSourceResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request.SourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request.SourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request.SourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetFindingStateRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingState(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetFindingState(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetFindingStateRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingStateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetFindingStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetFindingStateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetFindingState()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingState(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetFindingState(request.Name, request.State, request.StartTime);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetFindingStateAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingStateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetFindingStateAsync(request.Name, request.State, request.StartTime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetFindingStateAsync(request.Name, request.State, request.StartTime, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetFindingStateResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingState(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetFindingState(request.FindingName, request.State, request.StartTime);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetFindingStateResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new wkt::Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetFindingStateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetFindingStateAsync(request.FindingName, request.State, request.StartTime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetFindingStateAsync(request.FindingName, request.State, request.StartTime, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMuteRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetMute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMuteRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMuteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetMuteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetMuteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMute()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetMute(request.Name, request.Mute);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMuteAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMuteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetMuteAsync(request.Name, request.Mute, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetMuteAsync(request.Name, request.Mute, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMuteResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetMute(request.FindingName, request.Mute);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMuteResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unmuted,
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.SetMuteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.SetMuteAsync(request.FindingName, request.Mute, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.SetMuteAsync(request.FindingName, request.Mute, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFindingRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new wkt::FieldMask(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.UpdateFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.UpdateFinding(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFindingRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new wkt::FieldMask(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.UpdateFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.UpdateFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.UpdateFindingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFinding()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.UpdateFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.UpdateFinding(request.Finding);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFindingAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent7858e4d0",
                ResourceName = "resource_name8cc2e687",
                State = Finding.Types.State.Unspecified,
                Category = "category2f35efc4",
                ExternalUri = "external_uri54bd3365",
                SourceProperties =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
                SecurityMarks = new SecurityMarks(),
                EventTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                Severity = Finding.Types.Severity.Medium,
                CanonicalName = "canonical_name5e3d81e6",
                Mute = Finding.Types.Mute.Unmuted,
                FindingClass = Finding.Types.FindingClass.Observation,
                Indicator = new Indicator(),
                Vulnerability = new Vulnerability(),
                MuteUpdateTime = new wkt::Timestamp(),
                MuteInitiator = "mute_initiator3bd7566e",
            };
            mockGrpcClient.Setup(x => x.UpdateFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding responseCallSettings = await client.UpdateFindingAsync(request.Finding, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.UpdateFindingAsync(request.Finding, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMuteConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.UpdateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.UpdateMuteConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMuteConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.UpdateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.UpdateMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.UpdateMuteConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMuteConfig()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.UpdateMuteConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig response = client.UpdateMuteConfig(request.MuteConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMuteConfigAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            MuteConfig expectedResponse = new MuteConfig
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
#pragma warning disable CS0612
                DisplayName = "display_name137f65c2",
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MostRecentEditor = "most_recent_editor37631565",
            };
            mockGrpcClient.Setup(x => x.UpdateMuteConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MuteConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            MuteConfig responseCallSettings = await client.UpdateMuteConfigAsync(request.MuteConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MuteConfig responseCancellationToken = await client.UpdateMuteConfigAsync(request.MuteConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNotificationConfigRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.UpdateNotificationConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNotificationConfigRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.UpdateNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.UpdateNotificationConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNotificationConfig1()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.UpdateNotificationConfig(request.NotificationConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNotificationConfig1Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.UpdateNotificationConfigAsync(request.NotificationConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.UpdateNotificationConfigAsync(request.NotificationConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNotificationConfig2()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig response = client.UpdateNotificationConfig(request.NotificationConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNotificationConfig2Async()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            NotificationConfig expectedResponse = new NotificationConfig
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationNotificationConfig("[ORGANIZATION]", "[NOTIFICATION_CONFIG]"),
                Description = "description2cf9da67",
                PubsubTopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ServiceAccount = "service_accounta3c1b923",
                StreamingConfig = new NotificationConfig.Types.StreamingConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            NotificationConfig responseCallSettings = await client.UpdateNotificationConfigAsync(request.NotificationConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationConfig responseCancellationToken = await client.UpdateNotificationConfigAsync(request.NotificationConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateOrganizationSettingsRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.UpdateOrganizationSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateOrganizationSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OrganizationSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings responseCallSettings = await client.UpdateOrganizationSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OrganizationSettings responseCancellationToken = await client.UpdateOrganizationSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateOrganizationSettings()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.UpdateOrganizationSettings(request.OrganizationSettings);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateOrganizationSettingsAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
                EnableAssetDiscovery = true,
                AssetDiscoveryConfig = new OrganizationSettings.Types.AssetDiscoveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OrganizationSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings responseCallSettings = await client.UpdateOrganizationSettingsAsync(request.OrganizationSettings, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OrganizationSettings responseCancellationToken = await client.UpdateOrganizationSettingsAsync(request.OrganizationSettings, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSourceRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new wkt::FieldMask(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.UpdateSource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSourceRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new wkt::FieldMask(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.UpdateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.UpdateSourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSource()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.UpdateSource(request.Source);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSourceAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.UpdateSourceAsync(request.Source, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.UpdateSourceAsync(request.Source, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecurityMarksRequestObject()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new wkt::FieldMask(),
                StartTime = new wkt::Timestamp(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                SecurityMarksName = SecurityMarksName.FromOrganizationAsset("[ORGANIZATION]", "[ASSET]"),
                Marks =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks response = client.UpdateSecurityMarks(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecurityMarksRequestObjectAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new wkt::FieldMask(),
                StartTime = new wkt::Timestamp(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                SecurityMarksName = SecurityMarksName.FromOrganizationAsset("[ORGANIZATION]", "[ASSET]"),
                Marks =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityMarks>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks responseCallSettings = await client.UpdateSecurityMarksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityMarks responseCancellationToken = await client.UpdateSecurityMarksAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecurityMarks()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                SecurityMarksName = SecurityMarksName.FromOrganizationAsset("[ORGANIZATION]", "[ASSET]"),
                Marks =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks response = client.UpdateSecurityMarks(request.SecurityMarks);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecurityMarksAsync()
        {
            moq::Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new moq::Mock<SecurityCenter.SecurityCenterClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                SecurityMarksName = SecurityMarksName.FromOrganizationAsset("[ORGANIZATION]", "[ASSET]"),
                Marks =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityMarks>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks responseCallSettings = await client.UpdateSecurityMarksAsync(request.SecurityMarks, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityMarks responseCancellationToken = await client.UpdateSecurityMarksAsync(request.SecurityMarks, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
