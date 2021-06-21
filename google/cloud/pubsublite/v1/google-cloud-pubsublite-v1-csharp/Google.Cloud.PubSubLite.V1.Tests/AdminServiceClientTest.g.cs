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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSubLite.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdminServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateTopicRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTopic()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request.Parent, request.Topic, request.TopicId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request.Parent, request.Topic, request.TopicId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request.Parent, request.Topic, request.TopicId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTopicResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request.ParentAsLocationName, request.Topic, request.TopicId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "topic_id27d7b419",
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request.ParentAsLocationName, request.Topic, request.TopicId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request.ParentAsLocationName, request.Topic, request.TopicId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopic()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request.TopicName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request.TopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request.TopicName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicPartitionsRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions response = client.GetTopicPartitions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicPartitionsRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TopicPartitions>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions responseCallSettings = await client.GetTopicPartitionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TopicPartitions responseCancellationToken = await client.GetTopicPartitionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicPartitions()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions response = client.GetTopicPartitions(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicPartitionsAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TopicPartitions>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions responseCallSettings = await client.GetTopicPartitionsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TopicPartitions responseCancellationToken = await client.GetTopicPartitionsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicPartitionsResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions response = client.GetTopicPartitions(request.TopicName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicPartitionsResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            TopicPartitions expectedResponse = new TopicPartitions
            {
                PartitionCount = -9019320840296901773L,
            };
            mockGrpcClient.Setup(x => x.GetTopicPartitionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TopicPartitions>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            TopicPartitions responseCallSettings = await client.GetTopicPartitionsAsync(request.TopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TopicPartitions responseCancellationToken = await client.GetTopicPartitionsAsync(request.TopicName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTopicRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.UpdateTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTopicRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.UpdateTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTopic()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic response = client.UpdateTopic(request.Topic, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTopicAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                PartitionConfig = new Topic.Types.PartitionConfig(),
                RetentionConfig = new Topic.Types.RetentionConfig(),
                ReservationConfig = new Topic.Types.ReservationConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.UpdateTopicAsync(request.Topic, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.UpdateTopicAsync(request.Topic, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopicRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopic()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopicResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request.TopicName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request.TopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request.TopicName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubscriptionRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
                SkipBacklog = false,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
                SkipBacklog = false,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubscription()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request.Parent, request.Subscription, request.SubscriptionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request.Parent, request.Subscription, request.SubscriptionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request.Parent, request.Subscription, request.SubscriptionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubscriptionResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request.ParentAsLocationName, request.Subscription, request.SubscriptionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "subscription_id3f6742ef",
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request.ParentAsLocationName, request.Subscription, request.SubscriptionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request.ParentAsLocationName, request.Subscription, request.SubscriptionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscriptionRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscription()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscriptionResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request.SubscriptionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request.SubscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request.SubscriptionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSubscriptionRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.UpdateSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSubscriptionRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.UpdateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.UpdateSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSubscription()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.UpdateSubscription(request.Subscription, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSubscriptionAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                DeliveryConfig = new Subscription.Types.DeliveryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.UpdateSubscriptionAsync(request.Subscription, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.UpdateSubscriptionAsync(request.Subscription, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscriptionRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscription()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscriptionResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request.SubscriptionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request.SubscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request.SubscriptionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReservationRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReservation()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request.Parent, request.Reservation, request.ReservationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request.Parent, request.Reservation, request.ReservationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request.Parent, request.Reservation, request.ReservationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReservationResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request.ParentAsLocationName, request.Reservation, request.ReservationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "reservation_id4ff109fe",
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request.ParentAsLocationName, request.Reservation, request.ReservationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request.ParentAsLocationName, request.Reservation, request.ReservationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservationRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservation()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservationResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request.ReservationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request.ReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request.ReservationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateReservationRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.UpdateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.UpdateReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateReservationRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.UpdateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.UpdateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.UpdateReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateReservation()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.UpdateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.UpdateReservation(request.Reservation, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateReservationAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                ThroughputCapacity = 9118872543832748091L,
            };
            mockGrpcClient.Setup(x => x.UpdateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.UpdateReservationAsync(request.Reservation, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.UpdateReservationAsync(request.Reservation, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservationRequestObject()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationRequestObjectAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservation()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservationResourceNames()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request.ReservationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationResourceNamesAsync()
        {
            moq::Mock<AdminService.AdminServiceClient> mockGrpcClient = new moq::Mock<AdminService.AdminServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdminServiceClient client = new AdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request.ReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request.ReservationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
