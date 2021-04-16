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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V4.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMediaFileServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMediaFileRequestObject()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile response = client.GetMediaFile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMediaFileRequestObjectAsync()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MediaFile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile responseCallSettings = await client.GetMediaFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::MediaFile responseCancellationToken = await client.GetMediaFileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMediaFile()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile response = client.GetMediaFile(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMediaFileAsync()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MediaFile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile responseCallSettings = await client.GetMediaFileAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::MediaFile responseCancellationToken = await client.GetMediaFileAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMediaFileResourceNames()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile response = client.GetMediaFile(request.ResourceNameAsMediaFileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMediaFileResourceNamesAsync()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
            };
            gagvr::MediaFile expectedResponse = new gagvr::MediaFile
            {
                ResourceNameAsMediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                Id = -6774108720365892680L,
                Image = new gagvr::MediaImage(),
                MediaBundle = new gagvr::MediaBundle(),
                Type = gagve::MediaTypeEnum.Types.MediaType.DynamicImage,
                MimeType = gagve::MimeTypeEnum.Types.MimeType.ImagePng,
                SourceUrl = "source_url5da5c845",
                MediaFileName = gagvr::MediaFileName.FromCustomerMediaFile("[CUSTOMER]", "[MEDIA_FILE]"),
                FileSize = 2493931593823374883L,
                Audio = new gagvr::MediaAudio(),
                Video = new gagvr::MediaVideo(),
            };
            mockGrpcClient.Setup(x => x.GetMediaFileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MediaFile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MediaFile responseCallSettings = await client.GetMediaFileAsync(request.ResourceNameAsMediaFileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::MediaFile responseCancellationToken = await client.GetMediaFileAsync(request.ResourceNameAsMediaFileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateMediaFilesRequestObject()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new MediaFileOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse
            {
                Results =
                {
                    new MutateMediaFileResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateMediaFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse response = client.MutateMediaFiles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateMediaFilesRequestObjectAsync()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new MediaFileOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse
            {
                Results =
                {
                    new MutateMediaFileResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateMediaFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateMediaFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse responseCallSettings = await client.MutateMediaFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateMediaFilesResponse responseCancellationToken = await client.MutateMediaFilesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateMediaFiles()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new MediaFileOperation(),
                },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse
            {
                Results =
                {
                    new MutateMediaFileResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateMediaFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse response = client.MutateMediaFiles(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateMediaFilesAsync()
        {
            moq::Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new moq::Mock<MediaFileService.MediaFileServiceClient>(moq::MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new MediaFileOperation(),
                },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse
            {
                Results =
                {
                    new MutateMediaFileResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateMediaFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateMediaFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse responseCallSettings = await client.MutateMediaFilesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateMediaFilesResponse responseCancellationToken = await client.MutateMediaFilesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
