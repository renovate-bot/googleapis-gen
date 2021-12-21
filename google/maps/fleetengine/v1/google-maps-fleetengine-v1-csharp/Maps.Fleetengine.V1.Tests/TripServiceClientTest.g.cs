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
    public sealed class GeneratedTripServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateTripRequestObject()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            CreateTripRequest request = new CreateTripRequest
            {
                Header = new RequestHeader(),
                ParentAsTripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                Trip = new Trip(),
                TripId = "trip_ide5325dc6",
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.CreateTrip(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip response = client.CreateTrip(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTripRequestObjectAsync()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            CreateTripRequest request = new CreateTripRequest
            {
                Header = new RequestHeader(),
                ParentAsTripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                Trip = new Trip(),
                TripId = "trip_ide5325dc6",
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.CreateTripAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trip>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip responseCallSettings = await client.CreateTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trip responseCancellationToken = await client.CreateTripAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTripRequestObject()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                RouteFormatType = PolylineFormatType.LatLngListType,
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.GetTrip(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip response = client.GetTrip(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTripRequestObjectAsync()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                RouteFormatType = PolylineFormatType.LatLngListType,
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.GetTripAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trip>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip responseCallSettings = await client.GetTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trip responseCancellationToken = await client.GetTripAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportBillableTripRequestObject()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            ReportBillableTripRequest request = new ReportBillableTripRequest
            {
                Name = "name1c9368b0",
                CountryCode = "country_code8debec55",
                Platform = BillingPlatformIdentifier.Unspecified,
                RelatedIds =
                {
                    "related_idse25c5a0e",
                },
                SolutionType = ReportBillableTripRequest.Types.SolutionType.OnDemandRidesharingAndDeliveries,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ReportBillableTrip(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            client.ReportBillableTrip(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportBillableTripRequestObjectAsync()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            ReportBillableTripRequest request = new ReportBillableTripRequest
            {
                Name = "name1c9368b0",
                CountryCode = "country_code8debec55",
                Platform = BillingPlatformIdentifier.Unspecified,
                RelatedIds =
                {
                    "related_idse25c5a0e",
                },
                SolutionType = ReportBillableTripRequest.Types.SolutionType.OnDemandRidesharingAndDeliveries,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ReportBillableTripAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            await client.ReportBillableTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ReportBillableTripAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTripRequestObject()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            UpdateTripRequest request = new UpdateTripRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Trip = new Trip(),
                UpdateMask = new wkt::FieldMask(),
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.UpdateTrip(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip response = client.UpdateTrip(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTripRequestObjectAsync()
        {
            moq::Mock<TripService.TripServiceClient> mockGrpcClient = new moq::Mock<TripService.TripServiceClient>(moq::MockBehavior.Strict);
            UpdateTripRequest request = new UpdateTripRequest
            {
                Header = new RequestHeader(),
                Name = "name1c9368b0",
                Trip = new Trip(),
                UpdateMask = new wkt::FieldMask(),
            };
            Trip expectedResponse = new Trip
            {
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                VehicleId = "vehicle_iddc04ec35",
                TripStatus = TripStatus.Complete,
                TripType = TripType.Shared,
                PickupPoint = new TerminalLocation(),
                PickupTime = new wkt::Timestamp(),
                DropoffPoint = new TerminalLocation(),
                DropoffTime = new wkt::Timestamp(),
                Route = { new gt::LatLng(), },
                NumberOfPassengers = -799333534,
                LastLocation = new VehicleLocation(),
                RemainingDistanceMeters = -1788939204,
                EtaToFirstWaypoint = new wkt::Timestamp(),
                IntermediateDestinations =
                {
                    new TerminalLocation(),
                },
                IntermediateDestinationIndex = -810788659,
                RemainingWaypoints = { new TripWaypoint(), },
                CurrentRouteSegmentVersion = new wkt::Timestamp(),
                RemainingWaypointsVersion = new wkt::Timestamp(),
                VehicleWaypoints = { new TripWaypoint(), },
                CurrentRouteSegment = "current_route_segment476b3b2e",
                ActualPickupPoint = new StopLocation(),
                ActualDropoffPoint = new StopLocation(),
                CurrentRouteSegmentEndPoint = new TripWaypoint(),
                IntermediateDestinationsVersion = new wkt::Timestamp(),
                LastLocationSnappable = true,
                RemainingTimeToFirstWaypoint = new wkt::Duration(),
                CurrentRouteSegmentTraffic = new ConsumableTrafficPolyline(),
                RemainingWaypointsRouteVersion = new wkt::Timestamp(),
                CurrentRouteSegmentTrafficVersion = new wkt::Timestamp(),
                View = TripView.Sdk,
                ActualPickupArrivalPoint = new StopLocation(),
                ActualIntermediateDestinationArrivalPoints = { new StopLocation(), },
                ActualIntermediateDestinations = { new StopLocation(), },
            };
            mockGrpcClient.Setup(x => x.UpdateTripAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trip>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TripServiceClient client = new TripServiceClientImpl(mockGrpcClient.Object, null);
            Trip responseCallSettings = await client.UpdateTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trip responseCancellationToken = await client.UpdateTripAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
