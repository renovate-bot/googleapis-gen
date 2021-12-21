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
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Maps.Fleetengine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVehicleServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateVehicleRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            CreateVehicleRequest request = new CreateVehicleRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                VehicleId = "vehicle_iddc04ec35",
                Vehicle = new Vehicle(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.CreateVehicle(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle response = client.CreateVehicle(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVehicleRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            CreateVehicleRequest request = new CreateVehicleRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                VehicleId = "vehicle_iddc04ec35",
                Vehicle = new Vehicle(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.CreateVehicleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Vehicle>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle responseCallSettings = await client.CreateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Vehicle responseCancellationToken = await client.CreateVehicleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVehicleRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            GetVehicleRequest request = new GetVehicleRequest
            {
                Header = new RequestHeader(),
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.GetVehicle(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle response = client.GetVehicle(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVehicleRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            GetVehicleRequest request = new GetVehicleRequest
            {
                Header = new RequestHeader(),
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.GetVehicleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Vehicle>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle responseCallSettings = await client.GetVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Vehicle responseCancellationToken = await client.GetVehicleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVehicleRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            UpdateVehicleRequest request = new UpdateVehicleRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Vehicle = new Vehicle(),
                UpdateMask = new wkt::FieldMask(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.UpdateVehicle(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle response = client.UpdateVehicle(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVehicleRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            UpdateVehicleRequest request = new UpdateVehicleRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Vehicle = new Vehicle(),
                UpdateMask = new wkt::FieldMask(),
            };
            Vehicle expectedResponse = new Vehicle
            {
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                VehicleState = VehicleState.Online,
                SupportedTripTypes = { TripType.Shared, },
                CurrentTrips =
                {
                    "current_trips7ea0e94c",
                },
                LastLocation = new VehicleLocation(),
                MaximumCapacity = 2118626276,
                Attributes =
                {
                    new VehicleAttribute(),
                },
                VehicleType = new Vehicle.Types.VehicleType(),
                LicensePlate = new LicensePlate(),
#pragma warning disable CS0612
                Route =
#pragma warning restore CS0612
                {
                    new TerminalLocation(),
                },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                WaypointsVersion = new wkt::Timestamp(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                CurrentRouteSegment = "current_route_segment476b3b2e",
                Waypoints = { new TripWaypoint(), },
                BackToBackEnabled = false,
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                RemainingTimeSeconds = 1021251096,
                NavigationStatus = NavigationStatus.OffRoute,
                DeviceSettings = new DeviceSettings(),
                CurrentRouteSegmentTraffic = new TrafficPolylineData(),
            };
            mockGrpcClient.Setup(x => x.UpdateVehicleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Vehicle>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            Vehicle responseCallSettings = await client.UpdateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Vehicle responseCancellationToken = await client.UpdateVehicleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVehicleLocationRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
#pragma warning disable CS0612
            UpdateVehicleLocationRequest request = new UpdateVehicleLocationRequest
#pragma warning restore CS0612
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                CurrentLocation = new VehicleLocation(),
                CurrentState = VehicleState.Offline,
            };
            VehicleLocation expectedResponse = new VehicleLocation
            {
                Location = new gt::LatLng(),
                Heading = -1621929993,
#pragma warning disable CS0612
                SpeedKmph = 2110284881,
#pragma warning restore CS0612
                UpdateTime = new wkt::Timestamp(),
                Altitude = -2.3977527818148378E+17,
                Speed = -4.211475059531833E+17,
                SpeedAccuracy = -16839955398150886,
#pragma warning disable CS0612
                HorizontalAccuracy = -5.926193577923702E+17,
                VerticalAccuracy = 1.6800606599226867E+17,
                BearingAccuracy = -8.516391851475306E+17,
#pragma warning restore CS0612
                LocationSensor = LocationSensor.Network,
                IsGpsSensorEnabled = true,
                ServerTime = new wkt::Timestamp(),
                TimeSinceUpdate = -863789923,
                NumStaleUpdates = -54515722,
                RawLocation = new gt::LatLng(),
                RawLocationTime = new wkt::Timestamp(),
                SupplementalLocation = new gt::LatLng(),
                SupplementalLocationTime = new wkt::Timestamp(),
                SupplementalLocationSensor = LocationSensor.UnknownSensor,
                SupplementalLocationAccuracy = -3.419369069771966E+17,
                LatlngAccuracy = -2.357670779715862E+17,
                HeadingAccuracy = -8.352987672665281E+17,
                AltitudeAccuracy = -2.217728315985186E+17,
                RawLocationAccuracy = 9.981016711906216E+17,
#pragma warning disable CS0612
                RoadSnapped = true,
#pragma warning restore CS0612
                IsRoadSnapped = false,
                RawLocationSensor = LocationSensor.FusedLocationProvider,
            };
            mockGrpcClient.Setup(x => x.UpdateVehicleLocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            VehicleLocation response = client.UpdateVehicleLocation(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVehicleLocationRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
#pragma warning disable CS0612
            UpdateVehicleLocationRequest request = new UpdateVehicleLocationRequest
#pragma warning restore CS0612
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                CurrentLocation = new VehicleLocation(),
                CurrentState = VehicleState.Offline,
            };
            VehicleLocation expectedResponse = new VehicleLocation
            {
                Location = new gt::LatLng(),
                Heading = -1621929993,
#pragma warning disable CS0612
                SpeedKmph = 2110284881,
#pragma warning restore CS0612
                UpdateTime = new wkt::Timestamp(),
                Altitude = -2.3977527818148378E+17,
                Speed = -4.211475059531833E+17,
                SpeedAccuracy = -16839955398150886,
#pragma warning disable CS0612
                HorizontalAccuracy = -5.926193577923702E+17,
                VerticalAccuracy = 1.6800606599226867E+17,
                BearingAccuracy = -8.516391851475306E+17,
#pragma warning restore CS0612
                LocationSensor = LocationSensor.Network,
                IsGpsSensorEnabled = true,
                ServerTime = new wkt::Timestamp(),
                TimeSinceUpdate = -863789923,
                NumStaleUpdates = -54515722,
                RawLocation = new gt::LatLng(),
                RawLocationTime = new wkt::Timestamp(),
                SupplementalLocation = new gt::LatLng(),
                SupplementalLocationTime = new wkt::Timestamp(),
                SupplementalLocationSensor = LocationSensor.UnknownSensor,
                SupplementalLocationAccuracy = -3.419369069771966E+17,
                LatlngAccuracy = -2.357670779715862E+17,
                HeadingAccuracy = -8.352987672665281E+17,
                AltitudeAccuracy = -2.217728315985186E+17,
                RawLocationAccuracy = 9.981016711906216E+17,
#pragma warning disable CS0612
                RoadSnapped = true,
#pragma warning restore CS0612
                IsRoadSnapped = false,
                RawLocationSensor = LocationSensor.FusedLocationProvider,
            };
            mockGrpcClient.Setup(x => x.UpdateVehicleLocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VehicleLocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            VehicleLocation responseCallSettings = await client.UpdateVehicleLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            VehicleLocation responseCancellationToken = await client.UpdateVehicleLocationAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVehicleAttributesRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            UpdateVehicleAttributesRequest request = new UpdateVehicleAttributesRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            UpdateVehicleAttributesResponse expectedResponse = new UpdateVehicleAttributesResponse
            {
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateVehicleAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            UpdateVehicleAttributesResponse response = client.UpdateVehicleAttributes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVehicleAttributesRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            UpdateVehicleAttributesRequest request = new UpdateVehicleAttributesRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            UpdateVehicleAttributesResponse expectedResponse = new UpdateVehicleAttributesResponse
            {
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateVehicleAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UpdateVehicleAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            UpdateVehicleAttributesResponse responseCallSettings = await client.UpdateVehicleAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UpdateVehicleAttributesResponse responseCancellationToken = await client.UpdateVehicleAttributesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchVehiclesRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 312855805,
                Count = 69899490,
                MinimumCapacity = 1060467928,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new wkt::Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = true,
                TripId = "trip_ide5325dc6",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
            };
            SearchVehiclesResponse expectedResponse = new SearchVehiclesResponse
            {
                Matches = { new VehicleMatch(), },
            };
            mockGrpcClient.Setup(x => x.SearchVehicles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            SearchVehiclesResponse response = client.SearchVehicles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchVehiclesRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 312855805,
                Count = 69899490,
                MinimumCapacity = 1060467928,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new wkt::Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = true,
                TripId = "trip_ide5325dc6",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
            };
            SearchVehiclesResponse expectedResponse = new SearchVehiclesResponse
            {
                Matches = { new VehicleMatch(), },
            };
            mockGrpcClient.Setup(x => x.SearchVehiclesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchVehiclesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            SearchVehiclesResponse responseCallSettings = await client.SearchVehiclesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchVehiclesResponse responseCancellationToken = await client.SearchVehiclesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchFuzzedVehiclesRequestObject()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 312855805,
                Count = 69899490,
                MinimumCapacity = 1060467928,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new wkt::Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = true,
                TripId = "trip_ide5325dc6",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
            };
            SearchVehiclesResponse expectedResponse = new SearchVehiclesResponse
            {
                Matches = { new VehicleMatch(), },
            };
            mockGrpcClient.Setup(x => x.SearchFuzzedVehicles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            SearchVehiclesResponse response = client.SearchFuzzedVehicles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchFuzzedVehiclesRequestObjectAsync()
        {
            moq::Mock<VehicleService.VehicleServiceClient> mockGrpcClient = new moq::Mock<VehicleService.VehicleServiceClient>(moq::MockBehavior.Strict);
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "parent7858e4d0",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 312855805,
                Count = 69899490,
                MinimumCapacity = 1060467928,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new wkt::Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = true,
                TripId = "trip_ide5325dc6",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
            };
            SearchVehiclesResponse expectedResponse = new SearchVehiclesResponse
            {
                Matches = { new VehicleMatch(), },
            };
            mockGrpcClient.Setup(x => x.SearchFuzzedVehiclesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchVehiclesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VehicleServiceClient client = new VehicleServiceClientImpl(mockGrpcClient.Object, null);
            SearchVehiclesResponse responseCallSettings = await client.SearchFuzzedVehiclesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchVehiclesResponse responseCancellationToken = await client.SearchFuzzedVehiclesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
