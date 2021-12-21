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

from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from maps.fleetengine_v1.types import fleetengine


__protobuf__ = proto.module(
    package='maps.fleetengine.v1',
    manifest={
        'VehicleState',
        'LocationPowerSaveMode',
        'BatteryStatus',
        'PowerSource',
        'Vehicle',
        'BatteryInfo',
        'DeviceSettings',
        'LicensePlate',
        'VisualTrafficReportPolylineRendering',
        'TrafficPolylineData',
    },
)


class VehicleState(proto.Enum):
    r"""The state of a ``Vehicle``."""
    UNKNOWN_VEHICLE_STATE = 0
    OFFLINE = 1
    ONLINE = 2


class LocationPowerSaveMode(proto.Enum):
    r"""How location features are configured to behave on the mobile
    device when the devices "battery saver" feature is on.
    (https://developer.android.com/reference/android/os/PowerManager#getLocationPowerSaveMode())
    """
    UNKNOWN_LOCATION_POWER_SAVE_MODE = 0
    LOCATION_MODE_NO_CHANGE = 1
    LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFF = 2
    LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFF = 3
    LOCATION_MODE_FOREGROUND_ONLY = 4
    LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFF = 5


class BatteryStatus(proto.Enum):
    r"""Status of the battery, whether full or charging etc."""
    UNKNOWN_BATTERY_STATUS = 0
    BATTERY_STATUS_CHARGING = 1
    BATTERY_STATUS_DISCHARGING = 2
    BATTERY_STATUS_FULL = 3
    BATTERY_STATUS_NOT_CHARGING = 4
    BATTERY_STATUS_POWER_LOW = 5


class PowerSource(proto.Enum):
    r"""Type of the charger being used to charge the battery."""
    UNKNOWN_POWER_SOURCE = 0
    POWER_SOURCE_AC = 1
    POWER_SOURCE_USB = 2
    POWER_SOURCE_WIRELESS = 3
    POWER_SOURCE_UNPLUGGED = 4


class Vehicle(proto.Message):
    r"""Vehicle metadata.

    Attributes:
        name (str):
            Output only. The unique name for this vehicle. The format is
            ``providers/{provider}/vehicles/{vehicle}``.
        vehicle_state (maps.fleetengine_v1.types.VehicleState):
            The vehicle state.
        supported_trip_types (Sequence[maps.fleetengine_v1.types.TripType]):
            Supported trip types.
        current_trips (Sequence[str]):
            Output only. List of ``trip_id``'s for trips currently
            assigned to this vehicle.
        last_location (maps.fleetengine_v1.types.VehicleLocation):
            Last reported location of the vehicle.
        maximum_capacity (int):
            The total numbers of riders this vehicle can
            carry.  The driver is not considered in this
            value. This value must be greater than or equal
            to one.
        attributes (Sequence[maps.fleetengine_v1.types.VehicleAttribute]):
            List of vehicle attributes. A vehicle can
            have at most 50 attributes.
        vehicle_type (maps.fleetengine_v1.types.Vehicle.VehicleType):
            The type of this vehicle. Can be used to filter vehicles in
            ``SearchVehicles`` results. Also influences ETA and route
            calculations.
        license_plate (maps.fleetengine_v1.types.LicensePlate):
            License plate information for the vehicle.
        route (Sequence[maps.fleetengine_v1.types.TerminalLocation]):
            Deprecated: Use ``Vehicle.waypoints`` instead.
        current_route_segment (str):
            The polyline specifying the route the driver app intends to
            take to the next waypoint. Your driver app updates this
            every time a waypoint is passed or the driver reroutes. This
            list is also returned in ``Trip.current_route_segment`` for
            all active trips assigned to the vehicle. Note: This field
            is intended only for use by the Driver SDK.
        current_route_segment_traffic (maps.fleetengine_v1.types.TrafficPolylineData):
            Input only. Fleet Engine uses this
            information to improve its understanding of a
            Trip, but does not populate the field in its
            responses. Note: This field is intended only for
            use by the Driver SDK.
        current_route_segment_version (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Time when ``current_route_segment`` was set. It
            should be stored by the client and passed in future
            ``GetVehicle`` requests to prevent returning routes that
            haven't changed.
        current_route_segment_end_point (maps.fleetengine_v1.types.TripWaypoint):
            The waypoint where ``current_route_segment`` ends. This can
            be supplied by drivers on ``UpdateVehicle`` calls either as
            a full trip waypoint, a waypoint ``LatLng``, or as the last
            ``LatLng`` of the ``current_route_segment``. Fleet Engine
            will then do its best to interpolate to an actual waypoint
            if it is not fully specified. This field is ignored in
            ``UpdateVehicle`` calls unless ``current_route_segment`` is
            also specified.
        remaining_distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            The remaining driving distance for the
            ``current_route_segment``. This field facilitates journey
            sharing between the Driver app and the Consumer app. This
            value is provided by the Driver SDK. This field is also
            returned in ``Trip.remaining_distance_meters`` for all
            active trips assigned to the vehicle. The value is
            unspecified if the ``current_route_segment`` field is empty,
            or if the Driver app has not updated its value.
        eta_to_first_waypoint (google.protobuf.timestamp_pb2.Timestamp):
            The ETA to the first entry in the ``waypoints`` field. This
            field facilitates journey sharing between a Driver app and a
            Consumer app. Is is provided by the Driver SDK. This field
            is also returned in ``Trip.eta_to_first_waypoint`` for all
            active trips assigned to the vehicle. The value is
            unspecified if the ``waypoints`` field is empty, or the
            Driver app has not updated its value.
        remaining_time_seconds (google.protobuf.wrappers_pb2.Int32Value):
            Input only. The remaining driving time for the
            ``current_route_segment``. This field facilitates journey
            sharing between the Driver app and the Consumer app. This
            value is updated by the Driver SDK. Fleet Engine does not
            update it. The value is unspecified if the
            ``Vehicle.current_route_segment`` field is empty, or if the
            Driver app has not updated its value. This value should
            match ``eta_to_first_waypoint`` - ``current_time`` if all
            parties are using the same clock. When updating a vehicle,
            if you update both ``eta_to_first_waypoint`` and
            ``remaining_time_seconds`` in the same request,
            ``remaining_time_seconds`` takes precedence.
        waypoints (Sequence[maps.fleetengine_v1.types.TripWaypoint]):
            The remaining waypoints assigned to this
            Vehicle.
        waypoints_version (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Last time the ``waypoints`` field was updated.
            Clients should cache this value and pass it in
            ``GetVehicleRequest`` to ensure the ``waypoints`` field is
            only returned if it is updated.
        back_to_back_enabled (bool):
            Indicates if the driver accepts back-to-back trips. If
            ``true``, ``SearchVehicles`` may include the vehicle even if
            it is currently assigned to a trip. The default value is
            ``false``.
        navigation_status (maps.fleetengine_v1.types.NavigationStatus):
            The vehicle's navigation status.
        device_settings (maps.fleetengine_v1.types.DeviceSettings):
            Input only. Information about settings in the
            mobile device being used by the driver.
    """

    class VehicleType(proto.Message):
        r"""The type of vehicle.

        Attributes:
            category (maps.fleetengine_v1.types.Vehicle.VehicleType.Category):
                Vehicle type category
        """
        class Category(proto.Enum):
            r"""Vehicle type categories"""
            UNKNOWN = 0
            AUTO = 1
            TAXI = 2
            TRUCK = 3
            TWO_WHEELER = 4

        category = proto.Field(
            proto.ENUM,
            number=1,
            enum='Vehicle.VehicleType.Category',
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    vehicle_state = proto.Field(
        proto.ENUM,
        number=2,
        enum='VehicleState',
    )
    supported_trip_types = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=fleetengine.TripType,
    )
    current_trips = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    last_location = proto.Field(
        proto.MESSAGE,
        number=5,
        message=fleetengine.VehicleLocation,
    )
    maximum_capacity = proto.Field(
        proto.INT32,
        number=6,
    )
    attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=8,
        message=fleetengine.VehicleAttribute,
    )
    vehicle_type = proto.Field(
        proto.MESSAGE,
        number=9,
        message=VehicleType,
    )
    license_plate = proto.Field(
        proto.MESSAGE,
        number=10,
        message='LicensePlate',
    )
    route = proto.RepeatedField(
        proto.MESSAGE,
        number=12,
        message=fleetengine.TerminalLocation,
    )
    current_route_segment = proto.Field(
        proto.STRING,
        number=20,
    )
    current_route_segment_traffic = proto.Field(
        proto.MESSAGE,
        number=28,
        message='TrafficPolylineData',
    )
    current_route_segment_version = proto.Field(
        proto.MESSAGE,
        number=15,
        message=timestamp_pb2.Timestamp,
    )
    current_route_segment_end_point = proto.Field(
        proto.MESSAGE,
        number=24,
        message=fleetengine.TripWaypoint,
    )
    remaining_distance_meters = proto.Field(
        proto.MESSAGE,
        number=18,
        message=wrappers_pb2.Int32Value,
    )
    eta_to_first_waypoint = proto.Field(
        proto.MESSAGE,
        number=19,
        message=timestamp_pb2.Timestamp,
    )
    remaining_time_seconds = proto.Field(
        proto.MESSAGE,
        number=25,
        message=wrappers_pb2.Int32Value,
    )
    waypoints = proto.RepeatedField(
        proto.MESSAGE,
        number=22,
        message=fleetengine.TripWaypoint,
    )
    waypoints_version = proto.Field(
        proto.MESSAGE,
        number=16,
        message=timestamp_pb2.Timestamp,
    )
    back_to_back_enabled = proto.Field(
        proto.BOOL,
        number=23,
    )
    navigation_status = proto.Field(
        proto.ENUM,
        number=26,
        enum=fleetengine.NavigationStatus,
    )
    device_settings = proto.Field(
        proto.MESSAGE,
        number=27,
        message='DeviceSettings',
    )


class BatteryInfo(proto.Message):
    r"""Information about the device's battery.

    Attributes:
        battery_status (maps.fleetengine_v1.types.BatteryStatus):
            Status of the battery, whether full or
            charging etc.
        power_source (maps.fleetengine_v1.types.PowerSource):
            Status of battery power source.
        battery_percentage (float):
            Current battery percentage [0-100].
    """

    battery_status = proto.Field(
        proto.ENUM,
        number=1,
        enum='BatteryStatus',
    )
    power_source = proto.Field(
        proto.ENUM,
        number=2,
        enum='PowerSource',
    )
    battery_percentage = proto.Field(
        proto.FLOAT,
        number=3,
    )


class DeviceSettings(proto.Message):
    r"""Information about various settings on the mobile device.

    Attributes:
        location_power_save_mode (maps.fleetengine_v1.types.LocationPowerSaveMode):
            How location features are set to behave on
            the device when battery saver is on.
        is_power_save_mode (bool):
            Whether the device is currently in power save
            mode.
        is_interactive (bool):
            Whether the device is in an interactive
            state.
        battery_info (maps.fleetengine_v1.types.BatteryInfo):
            Information about the battery state.
    """

    location_power_save_mode = proto.Field(
        proto.ENUM,
        number=1,
        enum='LocationPowerSaveMode',
    )
    is_power_save_mode = proto.Field(
        proto.BOOL,
        number=2,
    )
    is_interactive = proto.Field(
        proto.BOOL,
        number=3,
    )
    battery_info = proto.Field(
        proto.MESSAGE,
        number=4,
        message='BatteryInfo',
    )


class LicensePlate(proto.Message):
    r"""The license plate information of the Vehicle.  To avoid
    storing personally-identifiable information, only the minimum
    information about the license plate is stored as part of the
    entity.

    Attributes:
        country_code (str):
            Required. CLDR Country/Region Code. For example, ``US`` for
            United States, or ``IN`` for India.
        last_character (str):
            The last digit of the license plate or "-1" to denote no
            numeric value is present in the license plate.

            -  "ABC 1234" -> "4"
            -  "AB 123 CD" -> "3"
            -  "ABCDEF" -> "-1".
    """

    country_code = proto.Field(
        proto.STRING,
        number=1,
    )
    last_character = proto.Field(
        proto.STRING,
        number=2,
    )


class VisualTrafficReportPolylineRendering(proto.Message):
    r"""Describes how clients should color one portion of the
    polyline along the route.

    Attributes:
        road_stretch (Sequence[maps.fleetengine_v1.types.VisualTrafficReportPolylineRendering.RoadStretch]):
            Optional. Road stretches that should be
            rendered along the polyline. Note that the
            stretches are guaranteed to not overlap, and
            that they do not necessarily span the full
            route. In the absence of a road stretch to
            style, the client should apply the default for
            the route.
    """

    class RoadStretch(proto.Message):
        r"""One road stretch that should be rendered.

        Attributes:
            style (maps.fleetengine_v1.types.VisualTrafficReportPolylineRendering.RoadStretch.Style):
                Required. The style to apply.
            offset_meters (int):
                Required. The style should be applied between
                ``[offset_meters, offset_meters + length_meters)``.
            length_meters (int):
                Required. The length of the path where to
                apply the style.
        """
        class Style(proto.Enum):
            r"""The traffic style, indicating traffic speed."""
            STYLE_UNSPECIFIED = 0
            SLOWER_TRAFFIC = 1
            TRAFFIC_JAM = 2

        style = proto.Field(
            proto.ENUM,
            number=1,
            enum='VisualTrafficReportPolylineRendering.RoadStretch.Style',
        )
        offset_meters = proto.Field(
            proto.INT32,
            number=2,
        )
        length_meters = proto.Field(
            proto.INT32,
            number=3,
        )

    road_stretch = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=RoadStretch,
    )


class TrafficPolylineData(proto.Message):
    r"""Traffic conditions along the expected vehicle route.

    Attributes:
        traffic_rendering (maps.fleetengine_v1.types.VisualTrafficReportPolylineRendering):
            A polyline rendering of how fast traffic is
            for all regions along one stretch of a customer
            ride.
    """

    traffic_rendering = proto.Field(
        proto.MESSAGE,
        number=1,
        message='VisualTrafficReportPolylineRendering',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
