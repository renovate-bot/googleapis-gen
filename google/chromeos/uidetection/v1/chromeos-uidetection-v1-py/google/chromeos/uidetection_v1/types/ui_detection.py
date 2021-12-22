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


__protobuf__ = proto.module(
    package='google.chromeos.uidetection.v1',
    manifest={
        'UiDetectionRequest',
        'DetectionRequest',
        'WordDetectionRequest',
        'TextBlockDetectionRequest',
        'CustomIconDetectionRequest',
        'UiDetectionResponse',
        'BoundingBox',
    },
)


class UiDetectionRequest(proto.Message):
    r"""Request message for UI detection.

    Attributes:
        image_png (bytes):
            Required. Required field that represents a
            PNG image.
        request (google.chromeos.uidetection_v1.types.DetectionRequest):
            Required. Required field that indicates the
            detection type.
    """

    image_png = proto.Field(
        proto.BYTES,
        number=1,
    )
    request = proto.Field(
        proto.MESSAGE,
        number=2,
        message='DetectionRequest',
    )


class DetectionRequest(proto.Message):
    r"""Detection type specifies what to detect in the image.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        word_detection_request (google.chromeos.uidetection_v1.types.WordDetectionRequest):
            Detection type for word detection.

            This field is a member of `oneof`_ ``detection_request_type``.
        text_block_detection_request (google.chromeos.uidetection_v1.types.TextBlockDetectionRequest):
            Detection type for text block detection.

            This field is a member of `oneof`_ ``detection_request_type``.
        custom_icon_detection_request (google.chromeos.uidetection_v1.types.CustomIconDetectionRequest):
            Detection type for custom icon detection.

            This field is a member of `oneof`_ ``detection_request_type``.
    """

    word_detection_request = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='detection_request_type',
        message='WordDetectionRequest',
    )
    text_block_detection_request = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='detection_request_type',
        message='TextBlockDetectionRequest',
    )
    custom_icon_detection_request = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='detection_request_type',
        message='CustomIconDetectionRequest',
    )


class WordDetectionRequest(proto.Message):
    r"""Detection type for word detection.

    Attributes:
        word (str):
            Required. The word to locate in the image.
    """

    word = proto.Field(
        proto.STRING,
        number=1,
    )


class TextBlockDetectionRequest(proto.Message):
    r"""Detection type for text block detection.

    Attributes:
        words (Sequence[str]):
            Required. The text block consisting a list of
            words to locate im the image.
    """

    words = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


class CustomIconDetectionRequest(proto.Message):
    r"""Detection type for custom icon detection.

    Attributes:
        icon_png (bytes):
            Required. Required field that represents an
            icon in PNG format.
    """

    icon_png = proto.Field(
        proto.BYTES,
        number=1,
    )


class UiDetectionResponse(proto.Message):
    r"""Response message for UI detection.

    Attributes:
        bounding_boxes (Sequence[google.chromeos.uidetection_v1.types.BoundingBox]):
            Locations of matching UI elements.
    """

    bounding_boxes = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='BoundingBox',
    )


class BoundingBox(proto.Message):
    r"""The location of a UI element. A bounding box is reprensented by its
    top-left point [left, top] and its bottom-right point [right,
    bottom].

    Attributes:
        text (str):
            The text found in the bounding box.
        top (int):
            The y-coordinate of the top-left point.
        left (int):
            The x-coordinate of the top-left point.
        bottom (int):
            The y-coordinate of the bottom-right point.
        right (int):
            The x-coordinate of the bottom-right point.
    """

    text = proto.Field(
        proto.STRING,
        number=1,
    )
    top = proto.Field(
        proto.INT32,
        number=2,
    )
    left = proto.Field(
        proto.INT32,
        number=3,
    )
    bottom = proto.Field(
        proto.INT32,
        number=4,
    )
    right = proto.Field(
        proto.INT32,
        number=5,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
