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


from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.rpc import status_pb2 as gr_status  # type: ignore
from google.streetview.publish_v1.types import resources


__protobuf__ = proto.module(
    package='google.streetview.publish.v1',
    manifest={
        'PhotoView',
        'CreatePhotoRequest',
        'GetPhotoRequest',
        'BatchGetPhotosRequest',
        'BatchGetPhotosResponse',
        'PhotoResponse',
        'ListPhotosRequest',
        'ListPhotosResponse',
        'UpdatePhotoRequest',
        'BatchUpdatePhotosRequest',
        'BatchUpdatePhotosResponse',
        'DeletePhotoRequest',
        'BatchDeletePhotosRequest',
        'BatchDeletePhotosResponse',
    },
)


class PhotoView(proto.Enum):
    r"""Specifies which view of the
    [Photo][google.streetview.publish.v1.Photo] to include in the
    response.
    """
    BASIC = 0
    INCLUDE_DOWNLOAD_URL = 1


class CreatePhotoRequest(proto.Message):
    r"""Request to create a [Photo][google.streetview.publish.v1.Photo].

    Attributes:
        photo (google.streetview.publish_v1.types.Photo):
            Required. Photo to create.
    """

    photo = proto.Field(proto.MESSAGE, number=1,
        message=resources.Photo,
    )


class GetPhotoRequest(proto.Message):
    r"""Request to get a [Photo][google.streetview.publish.v1.Photo].

    By default

    -  does not return the download URL for the photo bytes.

    Parameters:

    -  ``view`` controls if the download URL for the photo bytes is
       returned.

    Attributes:
        photo_id (str):
            Required. ID of the
            [Photo][google.streetview.publish.v1.Photo].
        view (google.streetview.publish_v1.types.PhotoView):
            Specifies if a download URL for the photo bytes should be
            returned in the [Photo][google.streetview.publish.v1.Photo]
            response.
        language_code (str):
            The BCP-47 language code, such as "en-US" or "sr-Latn". For
            more information, see
            http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
            If language_code is unspecified, the user's language
            preference for Google services is used.
    """

    photo_id = proto.Field(proto.STRING, number=1)

    view = proto.Field(proto.ENUM, number=2,
        enum='PhotoView',
    )

    language_code = proto.Field(proto.STRING, number=3)


class BatchGetPhotosRequest(proto.Message):
    r"""Request to get one or more
    [Photos][google.streetview.publish.v1.Photo]. By default

    -  does not return the download URL for the photo bytes.

    Parameters:

    -  ``view`` controls if the download URL for the photo bytes is
       returned.

    Attributes:
        photo_ids (Sequence[str]):
            Required. IDs of the
            [Photos][google.streetview.publish.v1.Photo]. HTTP GET
            requests require the following syntax for the URL query
            parameter: ``photoIds=<id1>&photoIds=<id2>&...``.
        view (google.streetview.publish_v1.types.PhotoView):
            Specifies if a download URL for the photo
            bytes should be returned in the Photo response.
        language_code (str):
            The BCP-47 language code, such as "en-US" or "sr-Latn". For
            more information, see
            http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
            If language_code is unspecified, the user's language
            preference for Google services is used.
    """

    photo_ids = proto.RepeatedField(proto.STRING, number=1)

    view = proto.Field(proto.ENUM, number=2,
        enum='PhotoView',
    )

    language_code = proto.Field(proto.STRING, number=3)


class BatchGetPhotosResponse(proto.Message):
    r"""Response to batch get of
    [Photos][google.streetview.publish.v1.Photo].

    Attributes:
        results (Sequence[google.streetview.publish_v1.types.PhotoResponse]):
            List of results for each individual
            [Photo][google.streetview.publish.v1.Photo] requested, in
            the same order as the requests in
            [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos].
    """

    results = proto.RepeatedField(proto.MESSAGE, number=1,
        message='PhotoResponse',
    )


class PhotoResponse(proto.Message):
    r"""Response payload for a single
    [Photo][google.streetview.publish.v1.Photo] in batch operations
    including
    [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
    and
    [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos].

    Attributes:
        status (google.rpc.status_pb2.Status):
            The status for the operation to get or update
            a single photo in the batch request.
        photo (google.streetview.publish_v1.types.Photo):
            The [Photo][google.streetview.publish.v1.Photo] resource, if
            the request was successful.
    """

    status = proto.Field(proto.MESSAGE, number=1,
        message=gr_status.Status,
    )

    photo = proto.Field(proto.MESSAGE, number=2,
        message=resources.Photo,
    )


class ListPhotosRequest(proto.Message):
    r"""Request to list all photos that belong to the user sending the
    request.

    By default

    -  does not return the download URL for the photo bytes.

    Parameters:

    -  ``view`` controls if the download URL for the photo bytes is
       returned.
    -  ``pageSize`` determines the maximum number of photos to return.
    -  ``pageToken`` is the next page token value returned from a
       previous
       [ListPhotos][google.streetview.publish.v1.StreetViewPublishService.ListPhotos]
       request, if any.
    -  ``filter`` allows filtering by a given parameter. 'placeId' is
       the only parameter supported at the moment.

    Attributes:
        view (google.streetview.publish_v1.types.PhotoView):
            Specifies if a download URL for the photos
            bytes should be returned in the Photos response.
        page_size (int):
            The maximum number of photos to return. ``pageSize`` must be
            non-negative. If ``pageSize`` is zero or is not provided,
            the default page size of 100 is used. The number of photos
            returned in the response may be less than ``pageSize`` if
            the number of photos that belong to the user is less than
            ``pageSize``.
        page_token (str):
            The
            [nextPageToken][google.streetview.publish.v1.ListPhotosResponse.next_page_token]
            value returned from a previous
            [ListPhotos][google.streetview.publish.v1.StreetViewPublishService.ListPhotos]
            request, if any.
        filter (str):
            The filter expression. For example:
            ``placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw``.

            The only filter supported at the moment is ``placeId``.
        language_code (str):
            The BCP-47 language code, such as "en-US" or "sr-Latn". For
            more information, see
            http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
            If language_code is unspecified, the user's language
            preference for Google services is used.
    """

    view = proto.Field(proto.ENUM, number=1,
        enum='PhotoView',
    )

    page_size = proto.Field(proto.INT32, number=2)

    page_token = proto.Field(proto.STRING, number=3)

    filter = proto.Field(proto.STRING, number=4)

    language_code = proto.Field(proto.STRING, number=5)


class ListPhotosResponse(proto.Message):
    r"""Response to list all photos that belong to a user.

    Attributes:
        photos (Sequence[google.streetview.publish_v1.types.Photo]):
            List of photos. The
            [pageSize][google.streetview.publish.v1.ListPhotosRequest.page_size]
            field in the request determines the number of items
            returned.
        next_page_token (str):
            Token to retrieve the next page of results,
            or empty if there are no more results in the
            list.
    """

    @property
    def raw_page(self):
        return self

    photos = proto.RepeatedField(proto.MESSAGE, number=1,
        message=resources.Photo,
    )

    next_page_token = proto.Field(proto.STRING, number=2)


class UpdatePhotoRequest(proto.Message):
    r"""Request to update the metadata of a
    [Photo][google.streetview.publish.v1.Photo]. Updating the pixels of
    a photo is not supported.

    Attributes:
        photo (google.streetview.publish_v1.types.Photo):
            Required. [Photo][google.streetview.publish.v1.Photo] object
            containing the new metadata.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Mask that identifies fields on the photo metadata to update.
            If not present, the old
            [Photo][google.streetview.publish.v1.Photo] metadata is
            entirely replaced with the new
            [Photo][google.streetview.publish.v1.Photo] metadata in this
            request. The update fails if invalid fields are specified.
            Multiple fields can be specified in a comma-delimited list.

            The following fields are valid:

            -  ``pose.heading``
            -  ``pose.latLngPair``
            -  ``pose.pitch``
            -  ``pose.roll``
            -  ``pose.level``
            -  ``pose.altitude``
            -  ``connections``
            -  ``places``

            .. raw:: html

                <aside class="note"><b>Note:</b>  When
                [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
                contains repeated fields, the entire set of repeated values get replaced
                with the new contents. For example, if
                [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
                contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
                all connections are removed.</aside>
    """

    photo = proto.Field(proto.MESSAGE, number=1,
        message=resources.Photo,
    )

    update_mask = proto.Field(proto.MESSAGE, number=2,
        message=field_mask.FieldMask,
    )


class BatchUpdatePhotosRequest(proto.Message):
    r"""Request to update the metadata of photos.
    Updating the pixels of photos is not supported.

    Attributes:
        update_photo_requests (Sequence[google.streetview.publish_v1.types.UpdatePhotoRequest]):
            Required. List of
            [UpdatePhotoRequests][google.streetview.publish.v1.UpdatePhotoRequest].
    """

    update_photo_requests = proto.RepeatedField(proto.MESSAGE, number=1,
        message='UpdatePhotoRequest',
    )


class BatchUpdatePhotosResponse(proto.Message):
    r"""Response to batch update of metadata of one or more
    [Photos][google.streetview.publish.v1.Photo].

    Attributes:
        results (Sequence[google.streetview.publish_v1.types.PhotoResponse]):
            List of results for each individual
            [Photo][google.streetview.publish.v1.Photo] updated, in the
            same order as the request.
    """

    results = proto.RepeatedField(proto.MESSAGE, number=1,
        message='PhotoResponse',
    )


class DeletePhotoRequest(proto.Message):
    r"""Request to delete a [Photo][google.streetview.publish.v1.Photo].

    Attributes:
        photo_id (str):
            Required. ID of the
            [Photo][google.streetview.publish.v1.Photo].
    """

    photo_id = proto.Field(proto.STRING, number=1)


class BatchDeletePhotosRequest(proto.Message):
    r"""Request to delete multiple
    [Photos][google.streetview.publish.v1.Photo].

    Attributes:
        photo_ids (Sequence[str]):
            Required. IDs of the
            [Photos][google.streetview.publish.v1.Photo]. HTTP GET
            requests require the following syntax for the URL query
            parameter: ``photoIds=<id1>&photoIds=<id2>&...``.
    """

    photo_ids = proto.RepeatedField(proto.STRING, number=1)


class BatchDeletePhotosResponse(proto.Message):
    r"""Response to batch delete of one or more
    [Photos][google.streetview.publish.v1.Photo].

    Attributes:
        status (Sequence[google.rpc.status_pb2.Status]):
            The status for the operation to delete a single
            [Photo][google.streetview.publish.v1.Photo] in the batch
            request.
    """

    status = proto.RepeatedField(proto.MESSAGE, number=1,
        message=gr_status.Status,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
