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

namespace Google.Cloud.BaremetalSolution.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBareMetalSolutionClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume response = client.GetVolume(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolume()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume response = client.GetVolume(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume response = client.GetVolume(request.VolumeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                SnapshotSchedulePolicyAsSnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request.VolumeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request.VolumeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetworkRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network response = client.GetNetwork(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network responseCallSettings = await client.GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetwork()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network response = client.GetNetwork(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network responseCallSettings = await client.GetNetworkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetworkResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network response = client.GetNetwork(request.NetworkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Network_ = "networkd22ce091",
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Network responseCallSettings = await client.GetNetworkAsync(request.NetworkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request.NetworkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotSchedulePolicyRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.GetSnapshotSchedulePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotSchedulePolicyRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.GetSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.GetSnapshotSchedulePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotSchedulePolicy()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.GetSnapshotSchedulePolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotSchedulePolicyAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.GetSnapshotSchedulePolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.GetSnapshotSchedulePolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotSchedulePolicyResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.GetSnapshotSchedulePolicy(request.SnapshotSchedulePolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotSchedulePolicyResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.GetSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.GetSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshotSchedulePolicyRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.CreateSnapshotSchedulePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotSchedulePolicyRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.CreateSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.CreateSnapshotSchedulePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshotSchedulePolicy()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.CreateSnapshotSchedulePolicy(request.Parent, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotSchedulePolicyAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.CreateSnapshotSchedulePolicyAsync(request.Parent, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.CreateSnapshotSchedulePolicyAsync(request.Parent, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshotSchedulePolicyResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.CreateSnapshotSchedulePolicy(request.ParentAsLocationName, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotSchedulePolicyResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "snapshot_schedule_policy_id69b86cbb",
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.CreateSnapshotSchedulePolicyAsync(request.ParentAsLocationName, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.CreateSnapshotSchedulePolicyAsync(request.ParentAsLocationName, request.SnapshotSchedulePolicy, request.SnapshotSchedulePolicyId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSnapshotSchedulePolicyRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.UpdateSnapshotSchedulePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSnapshotSchedulePolicyRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.UpdateSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.UpdateSnapshotSchedulePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSnapshotSchedulePolicy()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy response = client.UpdateSnapshotSchedulePolicy(request.SnapshotSchedulePolicy, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSnapshotSchedulePolicyAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            SnapshotSchedulePolicy expectedResponse = new SnapshotSchedulePolicy
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
                Description = "description2cf9da67",
                Schedules =
                {
                    new SnapshotSchedulePolicy.Types.Schedule(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotSchedulePolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            SnapshotSchedulePolicy responseCallSettings = await client.UpdateSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicy, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotSchedulePolicy responseCancellationToken = await client.UpdateSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicy, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotSchedulePolicyRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshotSchedulePolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotSchedulePolicyRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotSchedulePolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotSchedulePolicy()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshotSchedulePolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotSchedulePolicyAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotSchedulePolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotSchedulePolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotSchedulePolicyResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshotSchedulePolicy(request.SnapshotSchedulePolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotSchedulePolicyResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotSchedulePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotSchedulePolicyAsync(request.SnapshotSchedulePolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVolumeSnapshotRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.CreateVolumeSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVolumeSnapshotRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.CreateVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.CreateVolumeSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVolumeSnapshot()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.CreateVolumeSnapshot(request.Parent, request.VolumeSnapshot);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVolumeSnapshotAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.CreateVolumeSnapshotAsync(request.Parent, request.VolumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.CreateVolumeSnapshotAsync(request.Parent, request.VolumeSnapshot, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVolumeSnapshotResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.CreateVolumeSnapshot(request.ParentAsVolumeName, request.VolumeSnapshot);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVolumeSnapshotResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.CreateVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.CreateVolumeSnapshotAsync(request.ParentAsVolumeName, request.VolumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.CreateVolumeSnapshotAsync(request.ParentAsVolumeName, request.VolumeSnapshot, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVolumeSnapshotRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteVolumeSnapshot(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVolumeSnapshotRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVolumeSnapshotAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVolumeSnapshot()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteVolumeSnapshot(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVolumeSnapshotAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVolumeSnapshotAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVolumeSnapshotAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVolumeSnapshotResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            client.DeleteVolumeSnapshot(request.VolumeSnapshotName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVolumeSnapshotResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVolumeSnapshotAsync(request.VolumeSnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVolumeSnapshotAsync(request.VolumeSnapshotName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeSnapshotRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.GetVolumeSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeSnapshotRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.GetVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.GetVolumeSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeSnapshot()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.GetVolumeSnapshot(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeSnapshotAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.GetVolumeSnapshotAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.GetVolumeSnapshotAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeSnapshotResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot response = client.GetVolumeSnapshot(request.VolumeSnapshotName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeSnapshotResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            VolumeSnapshot expectedResponse = new VolumeSnapshot
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
                Description = "description2cf9da67",
                SizeBytes = 4628423819757039038L,
                CreateTime = new wkt::Timestamp(),
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            mockGrpcClient.Setup(x => x.GetVolumeSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeSnapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            VolumeSnapshot responseCallSettings = await client.GetVolumeSnapshotAsync(request.VolumeSnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeSnapshot responseCancellationToken = await client.GetVolumeSnapshotAsync(request.VolumeSnapshotName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLunRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun response = client.GetLun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun responseCallSettings = await client.GetLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLun()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun response = client.GetLun(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun responseCallSettings = await client.GetLunAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLunResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun response = client.GetLun(request.LunName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null);
            Lun responseCallSettings = await client.GetLunAsync(request.LunName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request.LunName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
