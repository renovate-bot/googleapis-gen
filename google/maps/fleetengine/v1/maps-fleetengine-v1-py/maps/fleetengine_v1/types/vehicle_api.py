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
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore
from maps.fleetengine_v1.types import fleetengine
from maps.fleetengine_v1.types import header as mf_header
from maps.fleetengine_v1.types import vehicles as mf_vehicles


__protobuf__ = proto.module(
    package='maps.fleetengine.v1',
    manifest={
        'CreateVehicleRequest',
        'GetVehicleRequest',
        'UpdateVehicleRequest',
        'UpdateVehicleLocationRequest',
        'UpdateVehicleAttributesRequest',
        'UpdateVehicleAttributesResponse',
        'SearchVehiclesRequest',
        'SearchVehiclesResponse',
        'ListVehiclesRequest',
        'ListVehiclesResponse',
        'Waypoint',
        'VehicleMatch',
        'VehicleAttributeList',
    },
)


class CreateVehicleRequest(proto.Message):
    r"""``CreateVehicle`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        parent (str):
            Required. Must be in the format ``providers/{provider}``.
            The provider must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        vehicle_id (str):
            Required. Unique Vehicle ID; must be unique
            per provider. Subject to the following
            normalization and restrictions:
            1. IDs must be valid Unicode strings.
            2. IDs are limited to a maximum length of 64
            characters. 3. IDs will be normalized according
            to Unicode Normalization Form C
            (http://www.unicode.org/reports/tr15/).
            4. IDs may not contain any of the following
            ASCII characters: '/', ':', '\\', '?', or '#'.
        vehicle (maps.fleetengine_v1.types.Vehicle):
            Required. The Vehicle entity to create. When creating a
            Vehicle, the following fields are required:

            -  ``vehicleState``
            -  ``supportedTripTypes``
            -  ``maximumCapacity``
            -  ``vehicleType``

            When creating a Vehicle, the following fields are ignored:

            -  ``name``
            -  ``currentTrips``
            -  ``availableCapacity``
            -  ``current_route_segment``
            -  ``current_route_segment_end_point``
            -  ``current_route_segment_version``
            -  ``current_route_segment_traffic``
            -  ``route``
            -  ``waypoints``
            -  ``waypoints_version``
            -  ``remaining_distance_meters``
            -  ``remaining_time_seconds``
            -  ``eta_to_next_waypoint``
            -  ``navigation_status``

            All other fields are optional and used if provided.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    parent = proto.Field(
        proto.STRING,
        number=3,
    )
    vehicle_id = proto.Field(
        proto.STRING,
        number=4,
    )
    vehicle = proto.Field(
        proto.MESSAGE,
        number=5,
        message=mf_vehicles.Vehicle,
    )


class GetVehicleRequest(proto.Message):
    r"""``GetVehicle`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        name (str):
            Required. Must be in the format
            ``providers/{provider}/vehicles/{vehicle}``. The provider
            must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        current_route_segment_version (google.protobuf.timestamp_pb2.Timestamp):
            Indicates the minimum timestamp (exclusive) for which
            ``Vehicle.current_route_segment`` is retrieved. If the route
            is unchanged since this timestamp, the
            ``current_route_segment`` field is not set in the response.
            If a minimum is unspecified, the ``current_route_segment``
            is always retrieved.
        waypoints_version (google.protobuf.timestamp_pb2.Timestamp):
            Indicates the minimum timestamp (exclusive) for which
            ``Vehicle.waypoints`` data is retrieved. If the waypoints
            are unchanged since this timestamp, the
            ``vehicle.waypoints`` data is not set in the response. If
            this field is unspecified, ``vehicle.waypoints`` is always
            retrieved.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    current_route_segment_version = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    waypoints_version = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )


class UpdateVehicleRequest(proto.Message):
    r"""\`UpdateVehicle request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        name (str):
            Required. Must be in the format
            ``providers/{provider}/vehicles/{vehicle}``. The {provider}
            must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        vehicle (maps.fleetengine_v1.types.Vehicle):
            Required. The ``Vehicle`` entity values to apply. When
            updating a ``Vehicle``, the following fields may not be
            updated as they are managed by the server.

            -  ``current_trips``
            -  ``available_capacity``
            -  ``current_route_segment_version``
            -  ``waypoints_version``

            Furthermore, the vehicle ``name`` cannot be updated.

            If the ``attributes`` field is updated, **all** the
            vehicle's attributes are replaced with the attributes
            provided in the request. If you want to update only some
            attributes, see the ``UpdateVehicleAttributes`` method.
            Likewise, the ``waypoints`` field can be updated, but must
            contain all the waypoints. currently on the vehicle, and no
            other waypoints.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. A field mask indicating which fields of the
            ``Vehicle`` to update. At least one field name must be
            provided.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    vehicle = proto.Field(
        proto.MESSAGE,
        number=4,
        message=mf_vehicles.Vehicle,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=5,
        message=field_mask_pb2.FieldMask,
    )


class UpdateVehicleLocationRequest(proto.Message):
    r"""``UpdateVehicleLocation`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        name (str):
            Required. Must be in the format
            ``providers/{provider}/vehicles/{vehicle}``. The {provider}
            must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        current_location (maps.fleetengine_v1.types.VehicleLocation):
            Required. The vehicle's most recent location. The
            ``location`` and ``update_time`` subfields are required.
        current_state (maps.fleetengine_v1.types.VehicleState):
            Set the vehicle's state to either ``ONLINE`` or ``OFFLINE``.
            If set to ``UNKNOWN_VEHICLE_STATE``, the vehicle's state
            will not be altered.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    current_location = proto.Field(
        proto.MESSAGE,
        number=4,
        message=fleetengine.VehicleLocation,
    )
    current_state = proto.Field(
        proto.ENUM,
        number=5,
        enum=mf_vehicles.VehicleState,
    )


class UpdateVehicleAttributesRequest(proto.Message):
    r"""``UpdateVehicleAttributes`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        name (str):
            Required. Must be in the format
            ``providers/{provider}/vehicles/{vehicle}``. The provider
            must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        attributes (Sequence[maps.fleetengine_v1.types.VehicleAttribute]):
            Required. The vehicle attributes to update.
            Unmentioned attributes will not be altered or
            removed.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=fleetengine.VehicleAttribute,
    )


class UpdateVehicleAttributesResponse(proto.Message):
    r"""``UpdateVehicleAttributes`` response message.

    Attributes:
        attributes (Sequence[maps.fleetengine_v1.types.VehicleAttribute]):
            Required. The updated full list of vehicle
            attributes, including new, altered and untouched
            attributes.
    """

    attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=fleetengine.VehicleAttribute,
    )


class SearchVehiclesRequest(proto.Message):
    r"""``SearchVehicles`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        parent (str):
            Required. Must be in the format ``providers/{provider}``.
            The provider must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        pickup_point (maps.fleetengine_v1.types.TerminalLocation):
            Required. The pickup point to search near.
        dropoff_point (maps.fleetengine_v1.types.TerminalLocation):
            The customer's intended dropoff location. The field is
            required if ``trip_types`` contains ``TripType.SHARED``.
        pickup_radius_meters (int):
            Required. Defines the vehicle search radius
            around the pickup point. Only vehicles within
            the search radius will be returned. Value must
            be between 400 and 10000 meters (inclusive).
        count (int):
            Required. Specifies the maximum number of
            vehicles to return. The value must be between 1
            and 50 (inclusive).
        minimum_capacity (int):
            Required. Specifies the number of passengers
            being considered for a trip. The value must be
            greater than or equal to one. The driver is not
            considered in the capacity value.
        trip_types (Sequence[maps.fleetengine_v1.types.TripType]):
            Required. Restricts the search to only those vehicles that
            support at least one of the specified trip types.

            At the present time, only ``EXCLUSIVE`` is supported.
        maximum_staleness (google.protobuf.duration_pb2.Duration):
            Restricts the search to only those vehicles
            that have updated their locations within the
            specified duration. If this field is not set,
            the server uses five minutes as the default
            value.
        vehicle_types (Sequence[maps.fleetengine_v1.types.Vehicle.VehicleType]):
            Required. Restricts the search to vehicles
            with one of the specified types. At least one
            vehicle type must be specified.
        required_attributes (Sequence[maps.fleetengine_v1.types.VehicleAttribute]):
            Callers can form complex logical operations using any
            combination of the ``required_attributes``,
            ``required_one_of_attributes``, and
            ``required_one_of_attribute_sets`` fields.

            ``required_attributes`` is a list;
            ``required_one_of_attributes`` uses a message which allows a
            list of lists. In combination, the two fields allow the
            composition of this expression:

            ::

               (required_attributes[0] AND required_attributes[1] AND ...)
               AND
               (required_one_of_attributes[0][0] OR required_one_of_attributes[0][1] OR
               ...)
               AND
               (required_one_of_attributes[1][0] OR required_one_of_attributes[1][1] OR
               ...)

            Restricts the search to only those vehicles with the
            specified attributes. This field is a conjunction/AND
            operation. Your app can specify up to 100 attributes;
            however, the combined key:value string length cannot exceed
            1024 characters.
        required_one_of_attributes (Sequence[maps.fleetengine_v1.types.VehicleAttributeList]):
            Restricts the search to only those vehicles with at least
            one of the specified attributes in each
            ``VehicleAttributeList``. Within each list, a vehicle must
            match at least one of the attributes. This field is an
            inclusive disjunction/OR operation in each
            ``VehicleAttributeList`` and a conjunction/AND operation
            across the collection of ``VehicleAttributeList``.
        required_one_of_attribute_sets (Sequence[maps.fleetengine_v1.types.VehicleAttributeList]):
            ``required_one_of_attribute_sets`` provides additional
            functionality.

            Similar to ``required_one_of_attributes``,
            ``required_one_of_attribute_sets`` uses a message which
            allows a list of lists, allowing expressions such as this
            one:

            ::

               (required_attributes[0] AND required_attributes[1] AND ...)
               AND
               (required_one_of_attributes[0][0] AND required_one_of_attributes[0][1] AND
               ...)
               OR
               (required_one_of_attributes[1][0] AND required_one_of_attributes[1][1] AND
               ...)

            Restricts the search to only those vehicles with all the
            attributes in a ``VehicleAttributeList``. Within each list,
            a vehicle must match all of the attributes. This field is a
            conjunction/AND operation in each ``VehicleAttributeList``
            and inclusive disjunction/OR operation across the collection
            of ``VehicleAttributeList``.
        order_by (maps.fleetengine_v1.types.SearchVehiclesRequest.VehicleMatchOrder):
            Required. Specifies the desired ordering
            criterion for results.
        include_back_to_back (bool):
            Indicates if a vehicle with a single active trip is eligible
            for another match. If ``false``, vehicles with assigned
            trips are excluded from the search results. If ``true``,
            search results include vehicles with ``TripStatus`` of
            ``ENROUTE_TO_DROPOFF``.

            This field is only considered if a single ``trip_type`` of
            ``EXCLUSIVE`` is specified.

            The default value is ``false``.
        trip_id (str):
            Indicates the trip associated with this
            ``SearchVehicleRequest``. Unique Trip ID; must be unique per
            provider. Subject to the following normalization and
            restrictions:

            1. IDs must be valid Unicode strings.
            2. IDs are limited to a maximum length of 64 characters.
            3. IDs will be normalized according to Unicode Normalization
               Form C (http://www.unicode.org/reports/tr15/).
            4. IDs may not contain any of the following ASCII
               characters: '/', ':', '\', '?', or '#'.
    """
    class VehicleMatchOrder(proto.Enum):
        r"""Specifies the order of the vehicle matches in the response."""
        UNKNOWN_VEHICLE_MATCH_ORDER = 0
        PICKUP_POINT_ETA = 1
        PICKUP_POINT_DISTANCE = 2
        DROPOFF_POINT_ETA = 3
        PICKUP_POINT_STRAIGHT_DISTANCE = 4
        COST = 5

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_header.RequestHeader,
    )
    parent = proto.Field(
        proto.STRING,
        number=3,
    )
    pickup_point = proto.Field(
        proto.MESSAGE,
        number=4,
        message=fleetengine.TerminalLocation,
    )
    dropoff_point = proto.Field(
        proto.MESSAGE,
        number=5,
        message=fleetengine.TerminalLocation,
    )
    pickup_radius_meters = proto.Field(
        proto.INT32,
        number=6,
    )
    count = proto.Field(
        proto.INT32,
        number=7,
    )
    minimum_capacity = proto.Field(
        proto.INT32,
        number=8,
    )
    trip_types = proto.RepeatedField(
        proto.ENUM,
        number=9,
        enum=fleetengine.TripType,
    )
    maximum_staleness = proto.Field(
        proto.MESSAGE,
        number=10,
        message=duration_pb2.Duration,
    )
    vehicle_types = proto.RepeatedField(
        proto.MESSAGE,
        number=14,
        message=mf_vehicles.Vehicle.VehicleType,
    )
    required_attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=12,
        message=fleetengine.VehicleAttribute,
    )
    required_one_of_attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=15,
        message='VehicleAttributeList',
    )
    required_one_of_attribute_sets = proto.RepeatedField(
        proto.MESSAGE,
        number=20,
        message='VehicleAttributeList',
    )
    order_by = proto.Field(
        proto.ENUM,
        number=13,
        enum=VehicleMatchOrder,
    )
    include_back_to_back = proto.Field(
        proto.BOOL,
        number=18,
    )
    trip_id = proto.Field(
        proto.STRING,
        number=19,
    )


class SearchVehiclesResponse(proto.Message):
    r"""``SearchVehicles`` response message.

    Attributes:
        matches (Sequence[maps.fleetengine_v1.types.VehicleMatch]):
            List of vehicles that match the ``SearchVehiclesRequest``
            criteria, ordered according to
            ``SearchVehiclesRequest.order_by`` field.
    """

    matches = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='VehicleMatch',
    )


class ListVehiclesRequest(proto.Message):
    r"""``ListVehicles`` request message.

    Attributes:
        header (maps.fleetengine_v1.types.RequestHeader):
            The standard Fleet Engine request header.
        parent (str):
            Required. Must be in the format ``providers/{provider}``.
            The provider must be the Project ID (for example,
            ``sample-cloud-project``) of the Google Cloud Project of
            which the service account making this call is a member.
        page_size (int):
            The maximum number of vehicles to return.
            Default value: 100.
        page_token (str):
            The ``next_page_token`` value returned from a previous call
            to ``ListVehicles``. Functionality is undefined if the
            filter criteria of this request don't match the criteria in
            the request that produced this ``page_token``.
        minimum_capacity (google.protobuf.wrappers_pb2.Int32Value):
            Specifies the required minimum capacity of the vehicle. All
            vehicles returned will have a ``maximum_capacity`` greater
            than or equal to this value. If set, must be greater or
            equal to 0.
        trip_types (Sequence[maps.fleetengine_v1.types.TripType]):
            Restrict the response to vehicles that
            support at least one of the specified trip
            types.
        maximum_staleness (google.protobuf.duration_pb2.Duration):
            Restrict the response to vehicles that have
            updated their locations within the specified
            duration back from now. If present, must be a
            valid positive duration.
        vehicle_type_categories (Sequence[maps.fleetengine_v1.types.Vehicle.VehicleType.Category]):
            Required. Restrict the response to vehicles
            with one of the specified type categories.
        required_attributes (Sequence[str]):
            Callers can form complex logical operations using any
            combination of the ``required_attributes``,
            ``required_one_of_attributes``, and
            ``required_one_of_attribute_sets`` fields.

            ``required_attributes`` is a list;
            ``required_one_of_attributes`` uses a message which allows a
            list of lists. In combination, the two fields allow the
            composition of this expression:

            ::

               (required_attributes[0] AND required_attributes[1] AND ...)
               AND
               (required_one_of_attributes[0][0] OR required_one_of_attributes[0][1] OR
               ...)
               AND
               (required_one_of_attributes[1][0] OR required_one_of_attributes[1][1] OR
               ...)

            Restrict the response to vehicles with the specified
            attributes. This field is a conjunction/AND operation. Your
            app can specify up to 100 attributes; however, the combined
            key:value string length cannot exceed 1024 characters.
        required_one_of_attributes (Sequence[str]):
            Restrict the response to vehicles with at least one of the
            specified attributes in each ``VehicleAttributeList``.
            Within each list, a vehicle must match at least one of the
            attributes. This field is an inclusive disjunction/OR
            operation in each ``VehicleAttributeList`` and a
            conjunction/AND operation across the collection of
            ``VehicleAttributeList``. Format:
            key1:value1|key2:value2|key3:value3...
        required_one_of_attribute_sets (Sequence[str]):
            ``required_one_of_attribute_sets`` provides additional
            functionality.

            Similar to ``required_one_of_attributes``,
            ``required_one_of_attribute_sets`` uses a message which
            allows a list of lists, allowing expressions such as this
            one:

            ::

               (required_attributes[0] AND required_attributes[1] AND ...)
               AND
               (required_one_of_attributes[0][0] AND required_one_of_attributes[0][1] AND
               ...)
               OR
               (required_one_of_attributes[1][0] AND required_one_of_attributes[1][1] AND
               ...)

            Restrict the response to vehicles that match all the
            attributes in a ``VehicleAttributeList``. Within each list,
            a vehicle must match all of the attributes. This field is a
            conjunction/AND operation in each ``VehicleAttributeList``
            and inclusive disjunction/OR operation across the collection
            of ``VehicleAttributeList``. Format:
            key1:value1|key2:value2|key3:value3...
        vehicle_state (maps.fleetengine_v1.types.VehicleState):
            Restrict the response to vehicles that have
            this vehicle state.
        on_trip_only (bool):
            Only return the vehicles with current
            trip(s).
    """

    header = proto.Field(
        proto.MESSAGE,
        number=12,
        message=mf_header.RequestHeader,
    )
    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=3,
    )
    page_token = proto.Field(
        proto.STRING,
        number=4,
    )
    minimum_capacity = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers_pb2.Int32Value,
    )
    trip_types = proto.RepeatedField(
        proto.ENUM,
        number=7,
        enum=fleetengine.TripType,
    )
    maximum_staleness = proto.Field(
        proto.MESSAGE,
        number=8,
        message=duration_pb2.Duration,
    )
    vehicle_type_categories = proto.RepeatedField(
        proto.ENUM,
        number=9,
        enum=mf_vehicles.Vehicle.VehicleType.Category,
    )
    required_attributes = proto.RepeatedField(
        proto.STRING,
        number=10,
    )
    required_one_of_attributes = proto.RepeatedField(
        proto.STRING,
        number=13,
    )
    required_one_of_attribute_sets = proto.RepeatedField(
        proto.STRING,
        number=15,
    )
    vehicle_state = proto.Field(
        proto.ENUM,
        number=11,
        enum=mf_vehicles.VehicleState,
    )
    on_trip_only = proto.Field(
        proto.BOOL,
        number=14,
    )


class ListVehiclesResponse(proto.Message):
    r"""``ListVehicles`` response message.

    Attributes:
        vehicles (Sequence[maps.fleetengine_v1.types.Vehicle]):
            Vehicles matching the criteria in the request. The maximum
            number of vehicles returned is determined by the
            ``page_size`` field in the request.
        next_page_token (str):
            Token to retrieve the next page of vehicles,
            or empty if there are no more vehicles that meet
            the request criteria.
        total_size (int):
            Required. Total number of vehicles matching
            the request criteria across all pages.
    """

    @property
    def raw_page(self):
        return self

    vehicles = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=mf_vehicles.Vehicle,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    total_size = proto.Field(
        proto.INT64,
        number=3,
    )


class Waypoint(proto.Message):
    r"""Describes intermediate points along a route.

    Attributes:
        lat_lng (google.type.latlng_pb2.LatLng):
            The location of this waypoint.
        eta (google.protobuf.timestamp_pb2.Timestamp):
            The estimated time that the vehicle will
            arrive at this waypoint.
    """

    lat_lng = proto.Field(
        proto.MESSAGE,
        number=1,
        message=latlng_pb2.LatLng,
    )
    eta = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )


class VehicleMatch(proto.Message):
    r"""Contains the vehicle and related estimates for a vehicle that match
    the points of active trips for the vehicle
    ``SearchVehiclesRequest``.

    Attributes:
        vehicle (maps.fleetengine_v1.types.Vehicle):
            Required. A vehicle that matches the request.
        vehicle_pickup_eta (google.protobuf.timestamp_pb2.Timestamp):
            The vehicle's driving ETA to the pickup point specified in
            the request. An empty value indicates a failure in
            calculating ETA for the vehicle. If
            ``SearchVehiclesRequest.include_back_to_back`` was ``true``
            and this vehicle has an active trip, ``vehicle_pickup_eta``
            includes the time required to complete the current active
            trip.
        vehicle_pickup_distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            The distance from the Vehicle's current
            location to the pickup point specified in the
            request, including any intermediate pickup or
            dropoff points for existing trips. This distance
            comprises the calculated driving (route)
            distance, plus the straight line distance
            between the navigation end point and the
            requested pickup point. (The distance between
            the navigation end point and the requested
            pickup point is typically small.) An empty value
            indicates an error in calculating the distance.
        vehicle_pickup_straight_line_distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            Required. The straight-line distance between
            the vehicle and the pickup point specified in
            the request.
        vehicle_dropoff_eta (google.protobuf.timestamp_pb2.Timestamp):
            The complete vehicle's driving ETA to the drop off point
            specified in the request. The ETA includes stopping at any
            waypoints before the ``dropoff_point`` specified in the
            request. The value will only be populated when a drop off
            point is specified in the request. An empty value indicates
            an error calculating the ETA.
        vehicle_pickup_to_dropoff_distance_meters (google.protobuf.wrappers_pb2.Int32Value):
            The vehicle's driving distance (in meters) from the pickup
            point to the drop off point specified in the request. The
            distance is only between the two points and does not include
            the vehicle location or any other points that must be
            visited before the vehicle visits either the pickup point or
            dropoff point. The value will only be populated when a
            ``dropoff_point`` is specified in the request. An empty
            value indicates a failure in calculating the distance from
            the pickup to drop off point specified in the request.
        trip_type (maps.fleetengine_v1.types.TripType):
            Required. The trip type of the request that
            was used to calculate the ETA to the pickup
            point.
        vehicle_trips_waypoints (Sequence[maps.fleetengine_v1.types.Waypoint]):
            The ordered list of waypoints used to
            calculate the ETA. The list includes vehicle
            location, the pickup/drop off points of active
            trips for the vehicle, and the pickup/drop off
            points provided in the request. An empty list
            indicates a failure in calculating ETA for the
            vehicle.
        vehicle_match_type (maps.fleetengine_v1.types.VehicleMatch.VehicleMatchType):
            Type of the vehicle match.
        requested_ordered_by (maps.fleetengine_v1.types.SearchVehiclesRequest.VehicleMatchOrder):
            The order requested for sorting vehicle
            matches.
        ordered_by (maps.fleetengine_v1.types.SearchVehiclesRequest.VehicleMatchOrder):
            The actual order that was used for this vehicle. Normally
            this will match the 'order_by' field from the request;
            however, in certain circumstances such as an internal server
            error, a different method may be used (such as
            ``PICKUP_POINT_STRAIGHT_DISTANCE``).
    """
    class VehicleMatchType(proto.Enum):
        r"""Type of vehicle match."""
        UNKNOWN = 0
        EXCLUSIVE = 1
        BACK_TO_BACK = 2
        CARPOOL = 3
        CARPOOL_BACK_TO_BACK = 4

    vehicle = proto.Field(
        proto.MESSAGE,
        number=1,
        message=mf_vehicles.Vehicle,
    )
    vehicle_pickup_eta = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    vehicle_pickup_distance_meters = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers_pb2.Int32Value,
    )
    vehicle_pickup_straight_line_distance_meters = proto.Field(
        proto.MESSAGE,
        number=11,
        message=wrappers_pb2.Int32Value,
    )
    vehicle_dropoff_eta = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    vehicle_pickup_to_dropoff_distance_meters = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.Int32Value,
    )
    trip_type = proto.Field(
        proto.ENUM,
        number=6,
        enum=fleetengine.TripType,
    )
    vehicle_trips_waypoints = proto.RepeatedField(
        proto.MESSAGE,
        number=7,
        message='Waypoint',
    )
    vehicle_match_type = proto.Field(
        proto.ENUM,
        number=8,
        enum=VehicleMatchType,
    )
    requested_ordered_by = proto.Field(
        proto.ENUM,
        number=9,
        enum='SearchVehiclesRequest.VehicleMatchOrder',
    )
    ordered_by = proto.Field(
        proto.ENUM,
        number=10,
        enum='SearchVehiclesRequest.VehicleMatchOrder',
    )


class VehicleAttributeList(proto.Message):
    r"""A list-of-lists datatype for vehicle attributes.

    Attributes:
        attributes (Sequence[maps.fleetengine_v1.types.VehicleAttribute]):
            A list of attributes in this collection.
    """

    attributes = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=fleetengine.VehicleAttribute,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
