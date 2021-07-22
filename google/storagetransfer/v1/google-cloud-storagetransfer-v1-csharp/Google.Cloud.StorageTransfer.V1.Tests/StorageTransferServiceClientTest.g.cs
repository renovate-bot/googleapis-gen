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

namespace Google.Cloud.StorageTransfer.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedStorageTransferServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGoogleServiceAccountRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGoogleServiceAccountRequest request = new GetGoogleServiceAccountRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            GoogleServiceAccount expectedResponse = new GoogleServiceAccount
            {
                AccountEmail = "account_email01cc68b0",
                SubjectId = "subject_idd1a1abff",
            };
            mockGrpcClient.Setup(x => x.GetGoogleServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            GoogleServiceAccount response = client.GetGoogleServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGoogleServiceAccountRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGoogleServiceAccountRequest request = new GetGoogleServiceAccountRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            GoogleServiceAccount expectedResponse = new GoogleServiceAccount
            {
                AccountEmail = "account_email01cc68b0",
                SubjectId = "subject_idd1a1abff",
            };
            mockGrpcClient.Setup(x => x.GetGoogleServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            GoogleServiceAccount responseCallSettings = await client.GetGoogleServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleServiceAccount responseCancellationToken = await client.GetGoogleServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransferJobRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTransferJobRequest request = new CreateTransferJobRequest
            {
                TransferJob = new TransferJob(),
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.CreateTransferJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob response = client.CreateTransferJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransferJobRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTransferJobRequest request = new CreateTransferJobRequest
            {
                TransferJob = new TransferJob(),
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.CreateTransferJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob responseCallSettings = await client.CreateTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferJob responseCancellationToken = await client.CreateTransferJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTransferJobRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTransferJobRequest request = new UpdateTransferJobRequest
            {
                JobName = "job_namedc176648",
                ProjectId = "project_id43ad98b0",
                TransferJob = new TransferJob(),
                UpdateTransferJobFieldMask = new wkt::FieldMask(),
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob response = client.UpdateTransferJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTransferJobRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTransferJobRequest request = new UpdateTransferJobRequest
            {
                JobName = "job_namedc176648",
                ProjectId = "project_id43ad98b0",
                TransferJob = new TransferJob(),
                UpdateTransferJobFieldMask = new wkt::FieldMask(),
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob responseCallSettings = await client.UpdateTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferJob responseCancellationToken = await client.UpdateTransferJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferJobRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTransferJobRequest request = new GetTransferJobRequest
            {
                JobName = "job_namedc176648",
                ProjectId = "project_id43ad98b0",
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.GetTransferJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob response = client.GetTransferJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferJobRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTransferJobRequest request = new GetTransferJobRequest
            {
                JobName = "job_namedc176648",
                ProjectId = "project_id43ad98b0",
            };
            TransferJob expectedResponse = new TransferJob
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                ProjectId = "project_id43ad98b0",
                TransferSpec = new TransferSpec(),
                Schedule = new Schedule(),
                Status = TransferJob.Types.Status.Disabled,
                CreationTime = new wkt::Timestamp(),
                LastModificationTime = new wkt::Timestamp(),
                DeletionTime = new wkt::Timestamp(),
                NotificationConfig = new NotificationConfig(),
                LatestOperationName = "latest_operation_namef5a455e9",
            };
            mockGrpcClient.Setup(x => x.GetTransferJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferJob responseCallSettings = await client.GetTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferJob responseCancellationToken = await client.GetTransferJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseTransferOperationRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseTransferOperationRequest request = new PauseTransferOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseTransferOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.PauseTransferOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseTransferOperationRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PauseTransferOperationRequest request = new PauseTransferOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.PauseTransferOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.PauseTransferOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.PauseTransferOperationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeTransferOperationRequestObject()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeTransferOperationRequest request = new ResumeTransferOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeTransferOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.ResumeTransferOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeTransferOperationRequestObjectAsync()
        {
            moq::Mock<StorageTransferService.StorageTransferServiceClient> mockGrpcClient = new moq::Mock<StorageTransferService.StorageTransferServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResumeTransferOperationRequest request = new ResumeTransferOperationRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResumeTransferOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StorageTransferServiceClient client = new StorageTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResumeTransferOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResumeTransferOperationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
