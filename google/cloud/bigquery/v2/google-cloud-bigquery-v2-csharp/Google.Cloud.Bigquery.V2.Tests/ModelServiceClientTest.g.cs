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

namespace Google.Cloud.Bigquery.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedModelServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetModelRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.GetModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModel()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request.ProjectId, request.DatasetId, request.ModelId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.GetModelAsync(request.ProjectId, request.DatasetId, request.ModelId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.GetModelAsync(request.ProjectId, request.DatasetId, request.ModelId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListModelsRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                MaxResults = 2806814450U,
                PageToken = "page_tokenf09e5538",
            };
            ListModelsResponse expectedResponse = new ListModelsResponse
            {
                Models = { new Model(), },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListModels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ListModelsResponse response = client.ListModels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListModelsRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                MaxResults = 2806814450U,
                PageToken = "page_tokenf09e5538",
            };
            ListModelsResponse expectedResponse = new ListModelsResponse
            {
                Models = { new Model(), },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListModelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListModelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ListModelsResponse responseCallSettings = await client.ListModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListModelsResponse responseCancellationToken = await client.ListModelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListModels()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                MaxResults = 2806814450U,
            };
            ListModelsResponse expectedResponse = new ListModelsResponse
            {
                Models = { new Model(), },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListModels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ListModelsResponse response = client.ListModels(request.ProjectId, request.DatasetId, request.MaxResults);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListModelsAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                MaxResults = 2806814450U,
            };
            ListModelsResponse expectedResponse = new ListModelsResponse
            {
                Models = { new Model(), },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListModelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListModelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ListModelsResponse responseCallSettings = await client.ListModelsAsync(request.ProjectId, request.DatasetId, request.MaxResults, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListModelsResponse responseCancellationToken = await client.ListModelsAsync(request.ProjectId, request.DatasetId, request.MaxResults, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchModelRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
                Model = new Model(),
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.PatchModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.PatchModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchModelRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
                Model = new Model(),
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.PatchModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.PatchModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.PatchModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchModel()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
                Model = new Model(),
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.PatchModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.PatchModel(request.ProjectId, request.DatasetId, request.ModelId, request.Model);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchModelAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
                Model = new Model(),
            };
            Model expectedResponse = new Model
            {
                Etag = "etage8ad7218",
                ModelReference = new ModelReference(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                ModelType = Model.Types.ModelType.LogisticRegression,
                TrainingRuns =
                {
                    new Model.Types.TrainingRun(),
                },
                FeatureColumns =
                {
                    new StandardSqlField(),
                },
                LabelColumns =
                {
                    new StandardSqlField(),
                },
                Description = "description2cf9da67",
                Location = "locatione09d18d5",
                FriendlyName = "friendly_name6171e36b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ExpirationTime = -3281957478759130153L,
                EncryptionConfiguration = new EncryptionConfiguration(),
#pragma warning disable CS0612
                BestTrialId = 2282073587253719259L,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.PatchModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.PatchModelAsync(request.ProjectId, request.DatasetId, request.ModelId, request.Model, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.PatchModelAsync(request.ProjectId, request.DatasetId, request.ModelId, request.Model, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteModelRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteModel(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteModelRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteModelAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteModel()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteModel(request.ProjectId, request.DatasetId, request.ModelId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteModelAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "project_id43ad98b0",
                DatasetId = "dataset_id08d366d3",
                ModelId = "model_id8abf7c47",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteModelAsync(request.ProjectId, request.DatasetId, request.ModelId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteModelAsync(request.ProjectId, request.DatasetId, request.ModelId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
