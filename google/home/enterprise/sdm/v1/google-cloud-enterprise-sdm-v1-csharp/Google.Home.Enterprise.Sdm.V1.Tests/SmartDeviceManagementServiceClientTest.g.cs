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

namespace Google.Home.Enterprise.Sdm.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSmartDeviceManagementServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetDeviceRequestObject()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                Name = "name1c9368b0",
            };
            Device expectedResponse = new Device
            {
                DeviceName = DeviceName.FromEnterpriseDevice("[ENTERPRISE]", "[DEVICE]"),
                Type = "typee2cc9d59",
                Traits = new wkt::Struct(),
                ParentRelations =
                {
                    new ParentRelation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Device response = client.GetDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceRequestObjectAsync()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                Name = "name1c9368b0",
            };
            Device expectedResponse = new Device
            {
                DeviceName = DeviceName.FromEnterpriseDevice("[ENTERPRISE]", "[DEVICE]"),
                Type = "typee2cc9d59",
                Traits = new wkt::Struct(),
                ParentRelations =
                {
                    new ParentRelation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.GetDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.GetDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExecuteDeviceCommandRequestObject()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            ExecuteDeviceCommandRequest request = new ExecuteDeviceCommandRequest
            {
                Name = "name1c9368b0",
                Command = "commandfeadcc1d",
                Params = new wkt::Struct(),
            };
            ExecuteDeviceCommandResponse expectedResponse = new ExecuteDeviceCommandResponse
            {
                Results = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.ExecuteDeviceCommand(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            ExecuteDeviceCommandResponse response = client.ExecuteDeviceCommand(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteDeviceCommandRequestObjectAsync()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            ExecuteDeviceCommandRequest request = new ExecuteDeviceCommandRequest
            {
                Name = "name1c9368b0",
                Command = "commandfeadcc1d",
                Params = new wkt::Struct(),
            };
            ExecuteDeviceCommandResponse expectedResponse = new ExecuteDeviceCommandResponse
            {
                Results = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.ExecuteDeviceCommandAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExecuteDeviceCommandResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            ExecuteDeviceCommandResponse responseCallSettings = await client.ExecuteDeviceCommandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExecuteDeviceCommandResponse responseCancellationToken = await client.ExecuteDeviceCommandAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStructureRequestObject()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetStructureRequest request = new GetStructureRequest
            {
                Name = "name1c9368b0",
            };
            Structure expectedResponse = new Structure
            {
                StructureName = StructureName.FromEnterpriseStructure("[ENTERPRISE]", "[STRUCTURE]"),
                Traits = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetStructure(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Structure response = client.GetStructure(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStructureRequestObjectAsync()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetStructureRequest request = new GetStructureRequest
            {
                Name = "name1c9368b0",
            };
            Structure expectedResponse = new Structure
            {
                StructureName = StructureName.FromEnterpriseStructure("[ENTERPRISE]", "[STRUCTURE]"),
                Traits = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetStructureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Structure>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Structure responseCallSettings = await client.GetStructureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Structure responseCancellationToken = await client.GetStructureAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRoomRequestObject()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetRoomRequest request = new GetRoomRequest
            {
                Name = "name1c9368b0",
            };
            Room expectedResponse = new Room
            {
                RoomName = RoomName.FromEnterpriseStructureRoom("[ENTERPRISE]", "[STRUCTURE]", "[ROOM]"),
                Traits = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetRoom(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Room response = client.GetRoom(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRoomRequestObjectAsync()
        {
            moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient> mockGrpcClient = new moq::Mock<SmartDeviceManagementService.SmartDeviceManagementServiceClient>(moq::MockBehavior.Strict);
            GetRoomRequest request = new GetRoomRequest
            {
                Name = "name1c9368b0",
            };
            Room expectedResponse = new Room
            {
                RoomName = RoomName.FromEnterpriseStructureRoom("[ENTERPRISE]", "[STRUCTURE]", "[ROOM]"),
                Traits = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetRoomAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Room>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartDeviceManagementServiceClient client = new SmartDeviceManagementServiceClientImpl(mockGrpcClient.Object, null);
            Room responseCallSettings = await client.GetRoomAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Room responseCancellationToken = await client.GetRoomAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
