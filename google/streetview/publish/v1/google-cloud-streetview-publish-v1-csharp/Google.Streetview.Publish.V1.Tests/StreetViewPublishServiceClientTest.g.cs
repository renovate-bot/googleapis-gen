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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Streetview.Publish.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedStreetViewPublishServiceClientTest
    {
        [xunit::FactAttribute]
        public void StartUploadRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            wkt::Empty request = new wkt::Empty { };
            UploadRef expectedResponse = new UploadRef
            {
                UploadUrl = "upload_url333fbc45",
            };
            mockGrpcClient.Setup(x => x.StartUpload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            UploadRef response = client.StartUpload(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartUploadRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            wkt::Empty request = new wkt::Empty { };
            UploadRef expectedResponse = new UploadRef
            {
                UploadUrl = "upload_url333fbc45",
            };
            mockGrpcClient.Setup(x => x.StartUploadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadRef>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            UploadRef responseCallSettings = await client.StartUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UploadRef responseCancellationToken = await client.StartUploadAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhotoRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.CreatePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.CreatePhoto(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhotoRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.CreatePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.CreatePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.CreatePhotoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhoto()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.CreatePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.CreatePhoto(request.Photo);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhotoAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            CreatePhotoRequest request = new CreatePhotoRequest { Photo = new Photo(), };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.CreatePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.CreatePhotoAsync(request.Photo, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.CreatePhotoAsync(request.Photo, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhotoRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
                View = PhotoView.IncludeDownloadUrl,
                LanguageCode = "language_code2f6c7160",
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.GetPhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.GetPhoto(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhotoRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
                View = PhotoView.IncludeDownloadUrl,
                LanguageCode = "language_code2f6c7160",
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.GetPhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.GetPhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.GetPhotoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhoto()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
                View = PhotoView.IncludeDownloadUrl,
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.GetPhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.GetPhoto(request.PhotoId, request.View);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhotoAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            GetPhotoRequest request = new GetPhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
                View = PhotoView.IncludeDownloadUrl,
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.GetPhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.GetPhotoAsync(request.PhotoId, request.View, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.GetPhotoAsync(request.PhotoId, request.View, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetPhotosRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
                View = PhotoView.IncludeDownloadUrl,
                LanguageCode = "language_code2f6c7160",
            };
            BatchGetPhotosResponse expectedResponse = new BatchGetPhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetPhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetPhotosResponse response = client.BatchGetPhotos(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetPhotosRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
                View = PhotoView.IncludeDownloadUrl,
                LanguageCode = "language_code2f6c7160",
            };
            BatchGetPhotosResponse expectedResponse = new BatchGetPhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetPhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetPhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetPhotosResponse responseCallSettings = await client.BatchGetPhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetPhotosResponse responseCancellationToken = await client.BatchGetPhotosAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetPhotos()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
                View = PhotoView.IncludeDownloadUrl,
            };
            BatchGetPhotosResponse expectedResponse = new BatchGetPhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetPhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetPhotosResponse response = client.BatchGetPhotos(request.PhotoIds, request.View);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetPhotosAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchGetPhotosRequest request = new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
                View = PhotoView.IncludeDownloadUrl,
            };
            BatchGetPhotosResponse expectedResponse = new BatchGetPhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetPhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetPhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetPhotosResponse responseCallSettings = await client.BatchGetPhotosAsync(request.PhotoIds, request.View, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetPhotosResponse responseCancellationToken = await client.BatchGetPhotosAsync(request.PhotoIds, request.View, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhotoRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new wkt::FieldMask(),
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.UpdatePhoto(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhotoRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new wkt::FieldMask(),
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.UpdatePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.UpdatePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.UpdatePhotoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhoto()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new wkt::FieldMask(),
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo response = client.UpdatePhoto(request.Photo, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhotoAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            UpdatePhotoRequest request = new UpdatePhotoRequest
            {
                Photo = new Photo(),
                UpdateMask = new wkt::FieldMask(),
            };
            Photo expectedResponse = new Photo
            {
                PhotoId = new PhotoId(),
                UploadReference = new UploadRef(),
                DownloadUrl = "download_url0ffcbc1c",
                Pose = new Pose(),
                Connections = { new Connection(), },
                CaptureTime = new wkt::Timestamp(),
                Places = { new Place(), },
                ThumbnailUrl = "thumbnail_url01e4d8ae",
                ViewCount = -6868900447039116286L,
                ShareLink = "share_link720d8fe7",
                TransferStatus = Photo.Types.TransferStatus.Cancelled,
                MapsPublishStatus = Photo.Types.MapsPublishStatus.Published,
            };
            mockGrpcClient.Setup(x => x.UpdatePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Photo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            Photo responseCallSettings = await client.UpdatePhotoAsync(request.Photo, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Photo responseCancellationToken = await client.UpdatePhotoAsync(request.Photo, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchUpdatePhotosRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            BatchUpdatePhotosResponse expectedResponse = new BatchUpdatePhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchUpdatePhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdatePhotosResponse response = client.BatchUpdatePhotos(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchUpdatePhotosRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            BatchUpdatePhotosResponse expectedResponse = new BatchUpdatePhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchUpdatePhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchUpdatePhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdatePhotosResponse responseCallSettings = await client.BatchUpdatePhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchUpdatePhotosResponse responseCancellationToken = await client.BatchUpdatePhotosAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchUpdatePhotos()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            BatchUpdatePhotosResponse expectedResponse = new BatchUpdatePhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchUpdatePhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdatePhotosResponse response = client.BatchUpdatePhotos(request.UpdatePhotoRequests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchUpdatePhotosAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchUpdatePhotosRequest request = new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    new UpdatePhotoRequest(),
                },
            };
            BatchUpdatePhotosResponse expectedResponse = new BatchUpdatePhotosResponse
            {
                Results =
                {
                    new PhotoResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchUpdatePhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchUpdatePhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdatePhotosResponse responseCallSettings = await client.BatchUpdatePhotosAsync(request.UpdatePhotoRequests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchUpdatePhotosResponse responseCancellationToken = await client.BatchUpdatePhotosAsync(request.UpdatePhotoRequests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhotoRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            DeletePhotoRequest request = new DeletePhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePhoto(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhotoRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            DeletePhotoRequest request = new DeletePhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhotoAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhoto()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            DeletePhotoRequest request = new DeletePhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhoto(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePhoto(request.PhotoId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhotoAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            DeletePhotoRequest request = new DeletePhotoRequest
            {
                PhotoId = "photo_id235ee7b4",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhotoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhotoAsync(request.PhotoId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhotoAsync(request.PhotoId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeletePhotosRequestObject()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
            };
            BatchDeletePhotosResponse expectedResponse = new BatchDeletePhotosResponse
            {
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchDeletePhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchDeletePhotosResponse response = client.BatchDeletePhotos(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeletePhotosRequestObjectAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
            };
            BatchDeletePhotosResponse expectedResponse = new BatchDeletePhotosResponse
            {
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchDeletePhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchDeletePhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchDeletePhotosResponse responseCallSettings = await client.BatchDeletePhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchDeletePhotosResponse responseCancellationToken = await client.BatchDeletePhotosAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeletePhotos()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
            };
            BatchDeletePhotosResponse expectedResponse = new BatchDeletePhotosResponse
            {
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchDeletePhotos(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchDeletePhotosResponse response = client.BatchDeletePhotos(request.PhotoIds);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeletePhotosAsync()
        {
            moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient> mockGrpcClient = new moq::Mock<StreetViewPublishService.StreetViewPublishServiceClient>(moq::MockBehavior.Strict);
            BatchDeletePhotosRequest request = new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    "photo_ids7043353b",
                },
            };
            BatchDeletePhotosResponse expectedResponse = new BatchDeletePhotosResponse
            {
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchDeletePhotosAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchDeletePhotosResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            StreetViewPublishServiceClient client = new StreetViewPublishServiceClientImpl(mockGrpcClient.Object, null);
            BatchDeletePhotosResponse responseCallSettings = await client.BatchDeletePhotosAsync(request.PhotoIds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchDeletePhotosResponse responseCancellationToken = await client.BatchDeletePhotosAsync(request.PhotoIds, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
