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

from google.protobuf import any_pb2  # type: ignore
from google.protobuf import duration_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore


__protobuf__ = proto.module(
    package='maps.fleetengine.v1',
    manifest={
        'TripType',
        'WaypointType',
        'PolylineFormatType',
        'NavigationStatus',
        'LocationSensor',
        'TerminalPointId',
        'TerminalLocation',
        'TripWaypoint',
        'Status',
        'FormattedAddress',
        'Address',
        'VehicleAttribute',
        'VehicleLocation',
    },
)


class TripType(proto.Enum):
    r"""The type of a trip."""
    UNKNOWN_TRIP_TYPE = 0
    SHARED = 1
    EXCLUSIVE = 2


class WaypointType(proto.Enum):
    r"""The type of waypoint."""
    UNKNOWN_WAYPOINT_TYPE = 0
    PICKUP_WAYPOINT_TYPE = 1
    DROP_OFF_WAYPOINT_TYPE = 2
    INTERMEDIATE_DESTINATION_WAYPOINT_TYPE = 3


class PolylineFormatType(proto.Enum):
    r"""The type of polyline format."""
    UNKNOWN_FORMAT_TYPE = 0
    LAT_LNG_LIST_TYPE = 1
    ENCODED_POLYLINE_TYPE = 2


class NavigationStatus(proto.Enum):
    r"""A set of values that specify the vehicle's navigation status."""
    UNKNOWN_NAVIGATION_STATUS = 0
    NO_GUIDANCE = 1
    ENROUTE_TO_DESTINATION = 2
    OFF_ROUTE = 3
    ARRIVED_AT_DESTINATION = 4


class LocationSensor(proto.Enum):
    r"""Possible location providers."""
    UNKNOWN_SENSOR = 0
    GPS = 1
    NETWORK = 2
    PASSIVE = 3
    ROAD_SNAPPED_LOCATION_PROVIDER = 4
    FUSED_LOCATION_PROVIDER = 100


class TerminalPointId(proto.Message):
    r"""Identifies a terminal point.

    Attributes:
        place_id (str):
            Deprecated.
        generated_id (str):
            Deprecated.
        value (str):
            Unique ID of the terminal point.
    """

    place_id = proto.Field(
        proto.STRING,
        number=2,
        oneof='Id',
    )
    generated_id = proto.Field(
        proto.STRING,
        number=3,
        oneof='Id',
    )
    value = proto.Field(
        proto.STRING,
        number=4,
    )


class TerminalLocation(proto.Message):
    r"""Describes the location of a pickup or dropoff.

    Attributes:
        point (google.type.latlng_pb2.LatLng):
            Required. Denotes the actual location of a
            pickup or dropoff.
        terminal_point_id (maps.fleetengine_v1.types.TerminalPointId):
            Required. ID of the terminal point.
        access_point_id (str):
            Deprecated.
        trip_id (str):
            Deprecated. Use vehicle.waypoint instead.
        terminal_location_type (maps.fleetengine_v1.types.WaypointType):
            Deprecated. Vehicle.waypoint will have this
            data.
    """

    point = proto.Field(
        proto.MESSAGE,
        number=1,
        message=latlng_pb2.LatLng,
    )
    terminal_point_id = proto.Field(
        proto.MESSAGE,
        number=2,
        message='TerminalPointId',
    )
    access_point_id = proto.Field(
        proto.STRING,
        number=3,
    )
    trip_id = proto.Field(
        proto.STRING,
        number=4,
    )
    terminal_location_type = proto.Field(
        proto.ENUM,
        number=5,
        enum='WaypointType',
    )


class TripWaypoint(proto.Message):
    r"""Describes a stopping point on a vehicle's route or an ending
    point on a vehicle's trip.

    Attributes:
        location (maps.fleetengine_v1.types.TerminalLocation):
            The location where this waypoint is
        trip_id (str):
            The trip this waypoint is part of
        waypoint_type (maps.fleetengine_v1.types.WaypointType):
            The type described the role the waypoint
            plays for this trip such as a pickup or dropoff.
        path_to_waypoint (Sequence[google.type.latlng_pb2.LatLng]):
            The path calculated by Fleet Engine from the
            previous waypoint to the current waypoint.
        distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            The path distance calculated by Fleet Engine from the
            previous waypoint to the current waypoint. If the current
            waypoint is the first waypoint in the list (Vehicle.waypoint
            or Trip.remaining_waypoints), then the starting point is the
            vehicle's location recorded at the time this TripWaypoint
            was added to the list.
        eta (google.protobuf.timestamp_pb2.Timestamp):
            The arrival time to this waypoint calculated
            by Fleet Engine.
        duration (google.protobuf.duration_pb2.Duration):
            The travel time from previous waypoint to this point. If the
            current waypoint is the first waypoint in the list
            (Vehicle.waypoint or Trip.remaining_waypoints), then the
            starting point is the vehicle's location recorded at the
            time that this waypoint was added to the list. This field is
            filled only when returning Trip/Vehicle data.
    """

    location = proto.Field(
        proto.MESSAGE,
        number=1,
        message='TerminalLocation',
    )
    trip_id = proto.Field(
        proto.STRING,
        number=2,
    )
    waypoint_type = proto.Field(
        proto.ENUM,
        number=3,
        enum='WaypointType',
    )
    path_to_waypoint = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=latlng_pb2.LatLng,
    )
    distance_meters = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers_pb2.Int32Value,
    )
    eta = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )
    duration = proto.Field(
        proto.MESSAGE,
        number=8,
        message=duration_pb2.Duration,
    )


class Status(proto.Message):
    r"""The 'Status' defines a FleetEngine custom logical error mode.

    Attributes:
        code (maps.fleetengine_v1.types.Status.Code):
            The error code. It is not possible to have a
            value as 0 if it is explicitly set by the
            server.
        message (str):
            Detailed error message.
        details (Sequence[google.protobuf.any_pb2.Any]):
            A list of messages that carry the error
            details.  There is a common set of message types
            for APIs to use.
    """
    class Code(proto.Enum):
        r"""The canonical error code."""
        UNSPECIFIED = 0
        FAILURE = 1
        ROUTE_NOT_POSSIBLE = 2

    code = proto.Field(
        proto.ENUM,
        number=1,
        enum=Code,
    )
    message = proto.Field(
        proto.STRING,
        number=2,
    )
    details = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=any_pb2.Any,
    )


class FormattedAddress(proto.Message):
    r"""A full, human-readable address for the entity containing this
    message.

    Attributes:
        lines (Sequence[str]):
            The lines of text that describe the address.
            At least one line must be present.
    """

    lines = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


class Address(proto.Message):
    r"""Address of a place.

    Attributes:
        formatted_address (maps.fleetengine_v1.types.FormattedAddress):
            A full, human-readable address for this
            place.
    """

    formatted_address = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FormattedAddress',
    )


class VehicleAttribute(proto.Message):
    r"""Describes a vehicle attribute as a key-value pair.

    Attributes:
        key (str):
            The attribute's key. Keys may not contain the
            colon character (:).
        value (str):
            The attribute's value.
    """

    key = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class VehicleLocation(proto.Message):
    r"""The location, speed, and heading of a vehicle at a point in
    time.

    Attributes:
        location (google.type.latlng_pb2.LatLng):
            The location of the vehicle. When it is sent to FleetEngine,
            the vehicle's location is a GPS location. When you receive
            it in a response, the vehicle's location can be either a GPS
            location or a supplemental location. The source is specified
            in the field 'location_sensor'.
        horizontal_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Deprecated. Use latlng_accuracy instead.
        latlng_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Accuracy of horizontal measurements (lat/lng)
            in meters as a radius.
        heading (google.protobuf.wrappers_pb2.Int32Value):
            Direction the vehicle is moving in degrees. 0 represents
            North. The valid range is [0,360).
        bearing_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Deprecated. Use heading_accuracy instead.
        heading_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Accuracy of heading (bearing) in degrees.
        altitude (google.protobuf.wrappers_pb2.DoubleValue):
            Altitude in meters above WGS84.
        vertical_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Deprecated. Use altitude_accurarcy instead.
        altitude_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Accuracy of altitude measurement in meters.
        speed_kmph (google.protobuf.wrappers_pb2.Int32Value):
            Speed of the vehicle in kilometers per hour.
            Deprecated. Use speed instead.
        speed (google.protobuf.wrappers_pb2.DoubleValue):
            Speed of the vehicle in meters/second
        speed_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Accuracy of speed in meters/second.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when the location was recorded.
        server_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the server
            receives the location information, filled by
            FleetEngine.
        location_sensor (maps.fleetengine_v1.types.LocationSensor):
            Provider of location data (for example,
            "gps").
        is_road_snapped (google.protobuf.wrappers_pb2.BoolValue):
            Whether the vehicle location given by "location" field is
            snapped to a road closest to the location given by
            "raw_location". Driver SDK 1.15.1/2.1.1 and up will always
            set this field. Unset value will be treated as true.
        is_gps_sensor_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Input only. Indicates whether the GPS sensor
            is enabled.
        time_since_update (google.protobuf.wrappers_pb2.Int32Value):
            Input only. Time (in seconds) since this
            location sample was first sent to the server.
            This will be zero for the first update. If the
            time is unknown (for example, when the app
            restarts), this value resets to zero.
        num_stale_updates (google.protobuf.wrappers_pb2.Int32Value):
            Input only. Number of additional attempts to
            send the current location to the server. If this
            value is zero, then it is not stale.
        raw_location (google.type.latlng_pb2.LatLng):
            Raw vehicle location (unprocessed by road-
            napper).
        raw_location_time (google.protobuf.timestamp_pb2.Timestamp):
            Input only. Timestamp associated with the raw
            location.
        raw_location_sensor (maps.fleetengine_v1.types.LocationSensor):
            Input only. Source of the raw location.
        raw_location_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Input only. Accuracy of the raw location
            (lat/lng) as a radius, measured in meters.
        supplemental_location (google.type.latlng_pb2.LatLng):
            Input only. Supplemental location provided by
            the integrating app, such as the location
            provided by Fused Location Provider.
        supplemental_location_time (google.protobuf.timestamp_pb2.Timestamp):
            Input only. Timestamp associated with the
            supplemental location.
        supplemental_location_sensor (maps.fleetengine_v1.types.LocationSensor):
            Input only. Source of the supplemental
            location.
        supplemental_location_accuracy (google.protobuf.wrappers_pb2.DoubleValue):
            Input only. Accuracy of supplemental location
            (lat/lng) as a radius, measured in meters.
        road_snapped (bool):
            Deprecated, use is_road_snapped instead.
    """

    location = proto.Field(
        proto.MESSAGE,
        number=1,
        message=latlng_pb2.LatLng,
    )
    horizontal_accuracy = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers_pb2.DoubleValue,
    )
    latlng_accuracy = proto.Field(
        proto.MESSAGE,
        number=22,
        message=wrappers_pb2.DoubleValue,
    )
    heading = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.Int32Value,
    )
    bearing_accuracy = proto.Field(
        proto.MESSAGE,
        number=10,
        message=wrappers_pb2.DoubleValue,
    )
    heading_accuracy = proto.Field(
        proto.MESSAGE,
        number=23,
        message=wrappers_pb2.DoubleValue,
    )
    altitude = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.DoubleValue,
    )
    vertical_accuracy = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.DoubleValue,
    )
    altitude_accuracy = proto.Field(
        proto.MESSAGE,
        number=24,
        message=wrappers_pb2.DoubleValue,
    )
    speed_kmph = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers_pb2.Int32Value,
    )
    speed = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers_pb2.DoubleValue,
    )
    speed_accuracy = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers_pb2.DoubleValue,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    server_time = proto.Field(
        proto.MESSAGE,
        number=13,
        message=timestamp_pb2.Timestamp,
    )
    location_sensor = proto.Field(
        proto.ENUM,
        number=11,
        enum='LocationSensor',
    )
    is_road_snapped = proto.Field(
        proto.MESSAGE,
        number=27,
        message=wrappers_pb2.BoolValue,
    )
    is_gps_sensor_enabled = proto.Field(
        proto.MESSAGE,
        number=12,
        message=wrappers_pb2.BoolValue,
    )
    time_since_update = proto.Field(
        proto.MESSAGE,
        number=14,
        message=wrappers_pb2.Int32Value,
    )
    num_stale_updates = proto.Field(
        proto.MESSAGE,
        number=15,
        message=wrappers_pb2.Int32Value,
    )
    raw_location = proto.Field(
        proto.MESSAGE,
        number=16,
        message=latlng_pb2.LatLng,
    )
    raw_location_time = proto.Field(
        proto.MESSAGE,
        number=17,
        message=timestamp_pb2.Timestamp,
    )
    raw_location_sensor = proto.Field(
        proto.ENUM,
        number=28,
        enum='LocationSensor',
    )
    raw_location_accuracy = proto.Field(
        proto.MESSAGE,
        number=25,
        message=wrappers_pb2.DoubleValue,
    )
    supplemental_location = proto.Field(
        proto.MESSAGE,
        number=18,
        message=latlng_pb2.LatLng,
    )
    supplemental_location_time = proto.Field(
        proto.MESSAGE,
        number=19,
        message=timestamp_pb2.Timestamp,
    )
    supplemental_location_sensor = proto.Field(
        proto.ENUM,
        number=20,
        enum='LocationSensor',
    )
    supplemental_location_accuracy = proto.Field(
        proto.MESSAGE,
        number=21,
        message=wrappers_pb2.DoubleValue,
    )
    road_snapped = proto.Field(
        proto.BOOL,
        number=26,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
