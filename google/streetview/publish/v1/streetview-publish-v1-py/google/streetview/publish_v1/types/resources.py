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


from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from google.type import latlng_pb2 as latlng  # type: ignore


__protobuf__ = proto.module(
    package='google.streetview.publish.v1',
    manifest={
        'UploadRef',
        'PhotoId',
        'Level',
        'Pose',
        'Place',
        'Connection',
        'Photo',
    },
)


class UploadRef(proto.Message):
    r"""Upload reference for media files.

    Attributes:
        upload_url (str):
            Required. An upload reference should be unique for each
            user. It follows the form:
            "https://streetviewpublish.googleapis.com/media/user/{account_id}/photo/{upload_reference}".
    """

    upload_url = proto.Field(proto.STRING, number=1)


class PhotoId(proto.Message):
    r"""Identifier for a [Photo][google.streetview.publish.v1.Photo].

    Attributes:
        id (str):
            Required. A unique identifier for a photo.
    """

    id = proto.Field(proto.STRING, number=1)


class Level(proto.Message):
    r"""Level information containing level number and its
    corresponding name.

    Attributes:
        number (float):
            Floor number, used for ordering. 0 indicates
            the ground level, 1 indicates the first level
            above ground level, -1 indicates the first level
            under ground level. Non-integer values are OK.
        name (str):
            Required. A name assigned to this Level,
            restricted to 3 characters. Consider how the
            elevator buttons would be labeled for this level
            if there was an elevator.
    """

    number = proto.Field(proto.DOUBLE, number=1)

    name = proto.Field(proto.STRING, number=2)


class Pose(proto.Message):
    r"""Raw pose measurement for an entity.

    Attributes:
        lat_lng_pair (google.type.latlng_pb2.LatLng):
            Latitude and longitude pair of the pose, as explained here:
            https://cloud.google.com/datastore/docs/reference/rest/Shared.Types/LatLng
            When creating a [Photo][google.streetview.publish.v1.Photo],
            if the latitude and longitude pair are not provided, the
            geolocation from the exif header is used. A latitude and
            longitude pair not provided in the photo or exif header
            causes the create photo process to fail.
        altitude (float):
            Altitude of the pose in meters above WGS84
            ellipsoid. NaN indicates an unmeasured quantity.
        heading (float):
            Compass heading, measured at the center of
            the photo in degrees clockwise from North. Value
            must be >=0 and <360. NaN indicates an
            unmeasured quantity.
        pitch (float):
            Pitch, measured at the center of the photo in
            degrees. Value must be >=-90 and <= 90. A value
            of -90 means looking directly down, and a value
            of 90 means looking directly up.
            NaN indicates an unmeasured quantity.
        roll (float):
            Roll, measured in degrees. Value must be >= 0
            and <360. A value of 0 means level with the
            horizon. NaN indicates an unmeasured quantity.
        level (google.streetview.publish_v1.types.Level):
            Level (the floor in a building) used to
            configure vertical navigation.
        accuracy_meters (float):
            The estimated horizontal accuracy of this
            pose in meters with 68% confidence (one standard
            deviation). For example, on Android, this value
            is available from this method:
            https://developer.android.com/reference/android/location/Location#getAccuracy().
            Other platforms have different methods of
            obtaining similar accuracy estimations.
    """

    lat_lng_pair = proto.Field(proto.MESSAGE, number=1,
        message=latlng.LatLng,
    )

    altitude = proto.Field(proto.DOUBLE, number=2)

    heading = proto.Field(proto.DOUBLE, number=3)

    pitch = proto.Field(proto.DOUBLE, number=4)

    roll = proto.Field(proto.DOUBLE, number=5)

    level = proto.Field(proto.MESSAGE, number=7,
        message='Level',
    )

    accuracy_meters = proto.Field(proto.FLOAT, number=9)


class Place(proto.Message):
    r"""Place metadata for an entity.

    Attributes:
        place_id (str):
            Place identifier, as described in
            https://developers.google.com/places/place-id.
        name (str):
            Output-only. The name of the place, localized to the
            language_code.
        language_code (str):
            Output-only. The language_code that the name is localized
            with. This should be the language_code specified in the
            request, but may be a fallback.
    """

    place_id = proto.Field(proto.STRING, number=1)

    name = proto.Field(proto.STRING, number=2)

    language_code = proto.Field(proto.STRING, number=3)


class Connection(proto.Message):
    r"""A connection is the link from a source photo to a destination
    photo.

    Attributes:
        target (google.streetview.publish_v1.types.PhotoId):
            Required. The destination of the connection
            from the containing photo to another photo.
    """

    target = proto.Field(proto.MESSAGE, number=1,
        message='PhotoId',
    )


class Photo(proto.Message):
    r"""Photo is used to store 360 photos along with photo metadata.

    Attributes:
        photo_id (google.streetview.publish_v1.types.PhotoId):
            Required when updating a photo. Output only
            when creating a photo. Identifier for the photo,
            which is unique among all photos in Google.
        upload_reference (google.streetview.publish_v1.types.UploadRef):
            Required when creating a photo. Input only.
            The resource URL where the photo bytes are
            uploaded to.
        download_url (str):
            Output only. The download URL for the photo bytes. This
            field is set only when
            [GetPhotoRequest.view][google.streetview.publish.v1.GetPhotoRequest.view]
            is set to
            [PhotoView.INCLUDE_DOWNLOAD_URL][google.streetview.publish.v1.PhotoView.INCLUDE_DOWNLOAD_URL].
        thumbnail_url (str):
            Output only. The thumbnail URL for showing a
            preview of the given photo.
        share_link (str):
            Output only. The share link for the photo.
        pose (google.streetview.publish_v1.types.Pose):
            Pose of the photo.
        connections (Sequence[google.streetview.publish_v1.types.Connection]):
            Connections to other photos. A connection
            represents the link from this photo to another
            photo.
        capture_time (google.protobuf.timestamp_pb2.Timestamp):
            Absolute time when the photo was captured.
            When the photo has no exif timestamp, this is
            used to set a timestamp in the photo metadata.
        places (Sequence[google.streetview.publish_v1.types.Place]):
            Places where this photo belongs.
        view_count (int):
            Output only. View count of the photo.
        transfer_status (google.streetview.publish_v1.types.Photo.TransferStatus):
            Output only. Status of rights transfer on
            this photo.
        maps_publish_status (google.streetview.publish_v1.types.Photo.MapsPublishStatus):
            Output only. Status in Google Maps, whether
            this photo was published or rejected.
    """
    class TransferStatus(proto.Enum):
        r"""Status of rights transfer."""
        TRANSFER_STATUS_UNKNOWN = 0
        NEVER_TRANSFERRED = 1
        PENDING = 2
        COMPLETED = 3
        REJECTED = 4
        EXPIRED = 5
        CANCELLED = 6
        RECEIVED_VIA_TRANSFER = 7

    class MapsPublishStatus(proto.Enum):
        r"""Publication status of the photo in Google Maps."""
        UNSPECIFIED_MAPS_PUBLISH_STATUS = 0
        PUBLISHED = 1
        REJECTED_UNKNOWN = 2

    photo_id = proto.Field(proto.MESSAGE, number=1,
        message='PhotoId',
    )

    upload_reference = proto.Field(proto.MESSAGE, number=2,
        message='UploadRef',
    )

    download_url = proto.Field(proto.STRING, number=3)

    thumbnail_url = proto.Field(proto.STRING, number=9)

    share_link = proto.Field(proto.STRING, number=11)

    pose = proto.Field(proto.MESSAGE, number=4,
        message='Pose',
    )

    connections = proto.RepeatedField(proto.MESSAGE, number=5,
        message='Connection',
    )

    capture_time = proto.Field(proto.MESSAGE, number=6,
        message=timestamp.Timestamp,
    )

    places = proto.RepeatedField(proto.MESSAGE, number=7,
        message='Place',
    )

    view_count = proto.Field(proto.INT64, number=10)

    transfer_status = proto.Field(proto.ENUM, number=12,
        enum=TransferStatus,
    )

    maps_publish_status = proto.Field(proto.ENUM, number=13,
        enum=MapsPublishStatus,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
