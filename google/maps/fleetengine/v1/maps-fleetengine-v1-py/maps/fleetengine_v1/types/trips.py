# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
import proto  # type: ignore

from google.protobuf import duration_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore
from maps.fleetengine_v1.types import fleetengine


__protobuf__ = proto.module(
    package='maps.fleetengine.v1',
    manifest={
        'TripStatus',
        'BillingPlatformIdentifier',
        'TripView',
        'Trip',
        'StopLocation',
    },
)


class TripStatus(proto.Enum):
    r"""The status of a trip indicating its progression."""
    UNKNOWN_TRIP_STATUS = 0
    NEW = 1
    ENROUTE_TO_PICKUP = 2
    ARRIVED_AT_PICKUP = 3
    ARRIVED_AT_INTERMEDIATE_DESTINATION = 7
    ENROUTE_TO_INTERMEDIATE_DESTINATION = 8
    ENROUTE_TO_DROPOFF = 4
    COMPLETE = 5
    CANCELED = 6


class BillingPlatformIdentifier(proto.Enum):
    r"""A set of values that indicate upon which platform the request
    was issued.
    """
    BILLING_PLATFORM_IDENTIFIER_UNSPECIFIED = 0
    SERVER = 1
    WEB = 2
    ANDROID = 3
    IOS = 4
    OTHERS = 5


class TripView(proto.Enum):
    r"""Selector for different sets of Trip fields in a ``GetTrip``
    response. See `AIP-157 <https://google.aip.dev/157>`__ for context.
    Additional views are likely to be added.
    """
    TRIP_VIEW_UNSPECIFIED = 0
    SDK = 1
    JOURNEY_SHARING_V1S = 2


class Trip(proto.Message):
    r"""Trip metadata.

    Attributes:
        name (str):
            In the format
            "providers/{provider}/trips/{trip}".
        vehicle_id (str):
            ID of the vehicle making this trip.
        trip_status (maps.fleetengine_v1.types.TripStatus):
            Current status of the trip.
        trip_type (maps.fleetengine_v1.types.TripType):
            The type of the trip.
        pickup_point (maps.fleetengine_v1.types.TerminalLocation):
            Location where customer indicates they will
            be picked up.
        actual_pickup_point (maps.fleetengine_v1.types.StopLocation):
            Input only. The actual location when and
            where customer was picked up. This field is for
            provider to provide feedback on actual pickup
            information.
        actual_pickup_arrival_point (maps.fleetengine_v1.types.StopLocation):
            Input only. The actual time and location of
            the driver arrival at the pickup point.
            This field is for provider to provide feedback
            on actual arrival information at the pickup
            point.
        pickup_time (google.protobuf.timestamp_pb2.Timestamp):
            Either the estimated future time when the
            rider(s) will be picked up, or the actual time
            when they were picked up.
        intermediate_destinations (Sequence[maps.fleetengine_v1.types.TerminalLocation]):
            Intermediate stops in order that the trip
            requests (in addition to pickup and dropoff).
            Initially this will not be supported for shared
            trips.
        intermediate_destinations_version (google.protobuf.timestamp_pb2.Timestamp):
            Indicates the last time the Trip.intermediate_destinations
            was modified. Your server should cache this value and pass
            it in UpdateTripRequest when update
            Trip.intermediate_destination_index to ensure the
            Trip.intermediate_destinations is not changed.
        intermediate_destination_index (int):
            When TripStatus is ENROUTE_TO_INTERMEDIATE_DESTINATION, a
            number between [0..N-1] indicating which intermediate
            destination the vehicle will cross next. When TripStatus is
            ARRIVED_AT_INTERMEDIATE_DESTINATION, a number between
            [0..N-1] indicating which intermediate destination the
            vehicle is at. The provider sets this value. If there are no
            intermediate_destinations, this field is ignored.
        actual_intermediate_destination_arrival_points (Sequence[maps.fleetengine_v1.types.StopLocation]):
            Input only. The actual time and location of
            the driver's arrival at an intermediate
            destination. This field is for provider to
            provide feedback on actual arriaval information
            at intermediate destinations.
        actual_intermediate_destinations (Sequence[maps.fleetengine_v1.types.StopLocation]):
            Input only. The actual time and location when
            and where the customer was picked up from an
            intermediate destination. This field is for
            provider to provide feedback on actual pickup
            information at intermediate destinations.
        dropoff_point (maps.fleetengine_v1.types.TerminalLocation):
            Location where customer indicates they will
            be dropped off.
        actual_dropoff_point (maps.fleetengine_v1.types.StopLocation):
            Input only. The actual time and location when
            and where customer was dropped off. This field
            is for provider to provide feedback on actual
            dropoff information.
        dropoff_time (google.protobuf.timestamp_pb2.Timestamp):
            Either the estimated future time when the
            rider(s) will be dropped off at the final
            destination, or the actual time when they were
            dropped off.
        remaining_waypoints (Sequence[maps.fleetengine_v1.types.TripWaypoint]):
            Output only. The full path from the current
            location to the dropoff point, inclusive. If
            this is a shared ride, this path could include
            waypoints from other trips.
        vehicle_waypoints (Sequence[maps.fleetengine_v1.types.TripWaypoint]):
            This field supports manual ordering of the
            waypoints for the trip. It contains all of the
            remaining waypoints of vehicle assigned, as well
            as the pickup and drop-off waypoints for this
            trip. If the trip hasn't been assigned to a
            vehicle, then this field is ignored. For privacy
            reasons, this field is only populated by the
            server on UpdateTrip and CreateTrip calls, and
            NOT on GetTrip calls.
        route (Sequence[google.type.latlng_pb2.LatLng]):
            Anticipated route for this trip to the first entry in
            remaining_waypoints. If back_to_back or shared trips are
            enabled, the waypoint may belong to a different trip.
        current_route_segment_end_point (maps.fleetengine_v1.types.TripWaypoint):
            The waypoint where current_route_segment ends. This can be
            supplied by drivers on UpdateVehicle calls either as a full
            trip waypoint, a waypoint latlng, or as a the last latlng of
            the current_route_segment. FleetEngine will then do its best
            to interpolate to an actual waypoint if it is not fully
            specified. It will be returned in GetTrip calls. It is not
            respected in Create/Update Trip calls.
        remaining_distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            The remaining driving distance in Trip.current_route_segment
            field. This field facilitates journey sharing between a
            driver and rider and Fleet Engine does not update it. Your
            driver app is responsible for setting field on all of its
            current trips by passing Vehicle.remaining_distance_meters
            to an Vehicle.update call. The value is unspecified if the
            trip is not assigned to a vehicle, or the trip is inactive
            (completed or cancelled), or driver hasn't updated this
            value.
        eta_to_first_waypoint (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The ETA to the next waypoint (the first entry
            in the Trip.remaining_waypoints field). This field
            facilitates journey sharing between a driver and a consumer.
            Fleet Engine does not update this value. Your driver app is
            responsible for setting this field by passing
            Vehicle.remaining_time_seconds in a call to Vehicle.update.
            FleetEngine converts the Vehicle.remaining_time_seconds to
            Trip.eta_to_first_waypoint, and returns it to the rider. The
            value is unspecified if the trip is not assigned to a
            vehicle, or the trip is inactive (completed or cancelled),
            or driver hasn't updated this value.
        remaining_time_to_first_waypoint (google.protobuf.duration_pb2.Duration):
            Output only. The duration from when the Trip data is
            returned to the time in Trip.eta_to_first_waypoint.
        remaining_waypoints_version (google.protobuf.timestamp_pb2.Timestamp):
            Indicates the last time that ``remaining_waypoints`` was
            changed (a waypoint was added, removed, or changed).
        remaining_waypoints_route_version (google.protobuf.timestamp_pb2.Timestamp):
            Indicates the last time the
            remaining_waypoints.path_to_waypoint and
            remaining_waypoints.traffic_to_waypoint were modified. Your
            client app should cache this value and pass it in
            GetTripRequest to ensure the paths and traffic for
            remaining_waypoints are only returned if updated.
        number_of_passengers (int):
            Indicates the number of passengers on this trip and does not
            include the driver. A vehicle must have available_capacity
            to be returned in SearchTrips.
        last_location (maps.fleetengine_v1.types.VehicleLocation):
            Indicates the last reported location of the
            vehicle along the route.
        last_location_snappable (bool):
            Indicates whether the vehicle's last_location can be snapped
            to the current_route_segment. False if last_location or
            current_route_segment doesn't exist. It is computed by Fleet
            Engine. Any update from clients will be ignored.
        view (maps.fleetengine_v1.types.TripView):
            The subset of Trip fields that are populated
            and how they should be interpreted.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    vehicle_id = proto.Field(
        proto.STRING,
        number=2,
    )
    trip_status = proto.Field(
        proto.ENUM,
        number=3,
        enum='TripStatus',
    )
    trip_type = proto.Field(
        proto.ENUM,
        number=4,
        enum=fleetengine.TripType,
    )
    pickup_point = proto.Field(
        proto.MESSAGE,
        number=5,
        message=fleetengine.TerminalLocation,
    )
    actual_pickup_point = proto.Field(
        proto.MESSAGE,
        number=22,
        message='StopLocation',
    )
    actual_pickup_arrival_point = proto.Field(
        proto.MESSAGE,
        number=32,
        message='StopLocation',
    )
    pickup_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    intermediate_destinations = proto.RepeatedField(
        proto.MESSAGE,
        number=14,
        message=fleetengine.TerminalLocation,
    )
    intermediate_destinations_version = proto.Field(
        proto.MESSAGE,
        number=25,
        message=timestamp_pb2.Timestamp,
    )
    intermediate_destination_index = proto.Field(
        proto.INT32,
        number=15,
    )
    actual_intermediate_destination_arrival_points = proto.RepeatedField(
        proto.MESSAGE,
        number=33,
        message='StopLocation',
    )
    actual_intermediate_destinations = proto.RepeatedField(
        proto.MESSAGE,
        number=34,
        message='StopLocation',
    )
    dropoff_point = proto.Field(
        proto.MESSAGE,
        number=7,
        message=fleetengine.TerminalLocation,
    )
    actual_dropoff_point = proto.Field(
        proto.MESSAGE,
        number=23,
        message='StopLocation',
    )
    dropoff_time = proto.Field(
        proto.MESSAGE,
        number=8,
        message=timestamp_pb2.Timestamp,
    )
    remaining_waypoints = proto.RepeatedField(
        proto.MESSAGE,
        number=16,
        message=fleetengine.TripWaypoint,
    )
    vehicle_waypoints = proto.RepeatedField(
        proto.MESSAGE,
        number=20,
        message=fleetengine.TripWaypoint,
    )
    route = proto.RepeatedField(
        proto.MESSAGE,
        number=9,
        message=latlng_pb2.LatLng,
    )
    current_route_segment_end_point = proto.Field(
        proto.MESSAGE,
        number=24,
        message=fleetengine.TripWaypoint,
    )
    remaining_distance_meters = proto.Field(
        proto.MESSAGE,
        number=12,
        message=wrappers_pb2.Int32Value,
    )
    eta_to_first_waypoint = proto.Field(
        proto.MESSAGE,
        number=13,
        message=timestamp_pb2.Timestamp,
    )
    remaining_time_to_first_waypoint = proto.Field(
        proto.MESSAGE,
        number=27,
        message=duration_pb2.Duration,
    )
    remaining_waypoints_version = proto.Field(
        proto.MESSAGE,
        number=19,
        message=timestamp_pb2.Timestamp,
    )
    remaining_waypoints_route_version = proto.Field(
        proto.MESSAGE,
        number=29,
        message=timestamp_pb2.Timestamp,
    )
    number_of_passengers = proto.Field(
        proto.INT32,
        number=10,
    )
    last_location = proto.Field(
        proto.MESSAGE,
        number=11,
        message=fleetengine.VehicleLocation,
    )
    last_location_snappable = proto.Field(
        proto.BOOL,
        number=26,
    )
    view = proto.Field(
        proto.ENUM,
        number=31,
        enum='TripView',
    )


class StopLocation(proto.Message):
    r"""The actual location where a stop (pickup/dropoff) happened.

    Attributes:
        point (google.type.latlng_pb2.LatLng):
            Required. Denotes the actual location.
        timestamp (google.protobuf.timestamp_pb2.Timestamp):
            The timestamp when the location was measured.
        stop_time (google.protobuf.timestamp_pb2.Timestamp):
            Indicates when the stop actually happened.
    """

    point = proto.Field(
        proto.MESSAGE,
        number=1,
        message=latlng_pb2.LatLng,
    )
    timestamp = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    stop_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
