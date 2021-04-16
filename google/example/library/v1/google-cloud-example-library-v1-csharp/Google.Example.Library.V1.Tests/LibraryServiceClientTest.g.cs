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

namespace Google.Example.Library.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLibraryServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateShelfRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.CreateShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.CreateShelf(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateShelfRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.CreateShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.CreateShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.CreateShelfAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateShelf()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.CreateShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.CreateShelf(request.Shelf);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateShelfAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.CreateShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.CreateShelfAsync(request.Shelf, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.CreateShelfAsync(request.Shelf, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShelfRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.GetShelf(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShelfRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.GetShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.GetShelfAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShelf()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.GetShelf(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShelfAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.GetShelfAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.GetShelfAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShelfResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.GetShelf(request.ShelfName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShelfResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.GetShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.GetShelfAsync(request.ShelfName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.GetShelfAsync(request.ShelfName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteShelfRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteShelf(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteShelfRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteShelfAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteShelf()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteShelf(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteShelfAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteShelfAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteShelfAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteShelfResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelf(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteShelf(request.ShelfName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteShelfResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteShelfAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteShelfAsync(request.ShelfName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteShelfAsync(request.ShelfName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeShelvesRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelves(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.MergeShelves(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeShelvesRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelvesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.MergeShelvesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.MergeShelvesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeShelves()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelves(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.MergeShelves(request.Name, request.OtherShelf);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeShelvesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelvesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.MergeShelvesAsync(request.Name, request.OtherShelf, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.MergeShelvesAsync(request.Name, request.OtherShelf, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeShelvesResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelves(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf response = client.MergeShelves(request.ShelfName, request.OtherShelfAsShelfName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeShelvesResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Shelf expectedResponse = new Shelf
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Theme = "theme0d5784f4",
            };
            mockGrpcClient.Setup(x => x.MergeShelvesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Shelf>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Shelf responseCallSettings = await client.MergeShelvesAsync(request.ShelfName, request.OtherShelfAsShelfName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Shelf responseCancellationToken = await client.MergeShelvesAsync(request.ShelfName, request.OtherShelfAsShelfName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBookRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.CreateBook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBookRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.CreateBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.CreateBookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBook()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.CreateBook(request.Parent, request.Book);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBookAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.CreateBookAsync(request.Parent, request.Book, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.CreateBookAsync(request.Parent, request.Book, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBookResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.CreateBook(request.ParentAsShelfName, request.Book);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBookResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.CreateBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.CreateBookAsync(request.ParentAsShelfName, request.Book, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.CreateBookAsync(request.ParentAsShelfName, request.Book, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBookRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.GetBook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBookRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.GetBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.GetBookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBook()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.GetBook(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBookAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.GetBookAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.GetBookAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBookResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.GetBook(request.BookName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBookResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.GetBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.GetBookAsync(request.BookName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.GetBookAsync(request.BookName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBookRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteBook(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBookRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBookAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBook()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteBook(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBookAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBookAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBookAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBookResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteBook(request.BookName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBookResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBookAsync(request.BookName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBookAsync(request.BookName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBookRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new wkt::FieldMask(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.UpdateBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.UpdateBook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBookRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new wkt::FieldMask(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.UpdateBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.UpdateBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.UpdateBookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBook()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new wkt::FieldMask(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.UpdateBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.UpdateBook(request.Book, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBookAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new wkt::FieldMask(),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.UpdateBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.UpdateBookAsync(request.Book, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.UpdateBookAsync(request.Book, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveBookRequestObject()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.MoveBook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveBookRequestObjectAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.MoveBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.MoveBookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveBook()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.MoveBook(request.Name, request.OtherShelfName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveBookAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.MoveBookAsync(request.Name, request.OtherShelfName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.MoveBookAsync(request.Name, request.OtherShelfName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveBookResourceNames()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book response = client.MoveBook(request.BookName, request.OtherShelfNameAsShelfName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveBookResourceNamesAsync()
        {
            moq::Mock<LibraryService.LibraryServiceClient> mockGrpcClient = new moq::Mock<LibraryService.LibraryServiceClient>(moq::MockBehavior.Strict);
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            Book expectedResponse = new Book
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                Author = "authorfa92bd02",
                Title = "title17dbd3d5",
                Read = true,
            };
            mockGrpcClient.Setup(x => x.MoveBookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Book>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LibraryServiceClient client = new LibraryServiceClientImpl(mockGrpcClient.Object, null);
            Book responseCallSettings = await client.MoveBookAsync(request.BookName, request.OtherShelfNameAsShelfName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Book responseCancellationToken = await client.MoveBookAsync(request.BookName, request.OtherShelfNameAsShelfName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
