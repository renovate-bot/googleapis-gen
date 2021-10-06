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

from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.maps.roads.v1op',
    manifest={
        'TravelMode',
        'SnapToRoadsRequest',
        'SnappedPoint',
        'SnapToRoadsResponse',
        'ListNearestRoadsRequest',
        'ListNearestRoadsResponse',
    },
)


class TravelMode(proto.Enum):
    r"""An enum representing the mode of travel used for snapping."""
    TRAVEL_MODE_UNSPECIFIED = 0
    DRIVING = 1
    CYCLING = 2
    WALKING = 3


class SnapToRoadsRequest(proto.Message):
    r"""A request to the SnapToRoads method, requesting that a
    sequence of points be snapped to road segments.

    Attributes:
        path (str):
            The path to be snapped as a series of lat, lng points.
            Specified as a string of the format: lat,lng|lat,lng|...
        interpolate (bool):
            Whether to interpolate the points to return
            full road geometry.
        asset_id (str):
            The asset ID of the asset to which this path
            relates. This is used for abuse detection
            purposes for clients with asset-based SKUs.
        travel_mode (google.maps.roads_v1.types.TravelMode):
            The type of travel being tracked. This will
            constrain the paths we snap to.
    """

    path = proto.Field(
        proto.STRING,
        number=1,
    )
    interpolate = proto.Field(
        proto.BOOL,
        number=2,
    )
    asset_id = proto.Field(
        proto.STRING,
        number=3,
    )
    travel_mode = proto.Field(
        proto.ENUM,
        number=4,
        enum='TravelMode',
    )


class SnappedPoint(proto.Message):
    r"""A snapped point object, representing the result of snapping.

    Attributes:
        location (google.type.latlng_pb2.LatLng):
            The lat,lng of the snapped location.
        original_index (google.protobuf.wrappers_pb2.UInt32Value):
            The index into the original path of the
            equivalent pre-snapped point. This allows for
            identification of points which have been
            interpolated if this index is missing.
        place_id (str):
            The place ID for this snapped location (road
            segment). These are the same as are currently
            used by the Places API.
    """

    location = proto.Field(
        proto.MESSAGE,
        number=1,
        message=latlng_pb2.LatLng,
    )
    original_index = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.UInt32Value,
    )
    place_id = proto.Field(
        proto.STRING,
        number=3,
    )


class SnapToRoadsResponse(proto.Message):
    r"""The response from the SnapToRoads method, returning a
    sequence of snapped points.

    Attributes:
        snapped_points (Sequence[google.maps.roads_v1.types.SnappedPoint]):
            A list of snapped points.
        warning_message (str):
            User-visible warning message, if any, which
            can be shown alongside a valid result.
    """

    snapped_points = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='SnappedPoint',
    )
    warning_message = proto.Field(
        proto.STRING,
        number=2,
    )


class ListNearestRoadsRequest(proto.Message):
    r"""A request to the ListNearestRoads method, requesting that a
    sequence of points be snapped individually to the road segment
    that each is closest to.

    Attributes:
        points (str):
            The points to be snapped as a series of lat, lng points.
            Specified as a string of the format: lat,lng|lat,lng|...
        travel_mode (google.maps.roads_v1.types.TravelMode):
            The type of travel being tracked. This will
            constrain the roads we snap to.
    """

    points = proto.Field(
        proto.STRING,
        number=1,
    )
    travel_mode = proto.Field(
        proto.ENUM,
        number=2,
        enum='TravelMode',
    )


class ListNearestRoadsResponse(proto.Message):
    r"""The response from the ListNearestRoads method, returning a
    list of snapped points.

    Attributes:
        snapped_points (Sequence[google.maps.roads_v1.types.SnappedPoint]):
            A list of snapped points.
    """

    snapped_points = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='SnappedPoint',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
