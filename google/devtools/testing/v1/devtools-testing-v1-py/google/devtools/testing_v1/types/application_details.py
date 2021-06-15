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

from google.devtools.testing_v1.types import test_execution


__protobuf__ = proto.module(
    package='google.devtools.testing.v1',
    manifest={
        'ApkDetail',
        'ApkManifest',
        'IntentFilter',
        'GetApkDetailsRequest',
        'GetApkDetailsResponse',
    },
)


class ApkDetail(proto.Message):
    r"""Android application details based on application manifest and
    apk archive contents.

    Attributes:
        apk_manifest (google.devtools.testing_v1.types.ApkManifest):

    """

    apk_manifest = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ApkManifest',
    )


class ApkManifest(proto.Message):
    r"""An Android app manifest. See
    http://developer.android.com/guide/topics/manifest/manifest-
    intro.html

    Attributes:
        package_name (str):
            Full Java-style package name for this
            application, e.g. "com.example.foo".
        min_sdk_version (int):
            Minimum API level required for the
            application to run.
        max_sdk_version (int):
            Maximum API level on which the application is
            designed to run.
        target_sdk_version (int):
            Specifies the API Level on which the
            application is designed to run.
        application_label (str):
            User-readable name for the application.
        intent_filters (Sequence[google.devtools.testing_v1.types.IntentFilter]):

        uses_permission (Sequence[str]):
            Permissions declared to be used by the
            application
    """

    package_name = proto.Field(
        proto.STRING,
        number=1,
    )
    min_sdk_version = proto.Field(
        proto.INT32,
        number=2,
    )
    max_sdk_version = proto.Field(
        proto.INT32,
        number=3,
    )
    target_sdk_version = proto.Field(
        proto.INT32,
        number=6,
    )
    application_label = proto.Field(
        proto.STRING,
        number=4,
    )
    intent_filters = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message='IntentFilter',
    )
    uses_permission = proto.RepeatedField(
        proto.STRING,
        number=7,
    )


class IntentFilter(proto.Message):
    r"""The <intent-filter> section of an <activity> tag.
    https://developer.android.com/guide/topics/manifest/intent-
    filter-element.html

    Attributes:
        action_names (Sequence[str]):
            The android:name value of the <action> tag.
        category_names (Sequence[str]):
            The android:name value of the <category> tag.
        mime_type (str):
            The android:mimeType value of the <data> tag.
    """

    action_names = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    category_names = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    mime_type = proto.Field(
        proto.STRING,
        number=3,
    )


class GetApkDetailsRequest(proto.Message):
    r"""A request to get the details of an Android application APK.
    Attributes:
        location (google.devtools.testing_v1.types.FileReference):
            The APK to be parsed for details.
    """

    location = proto.Field(
        proto.MESSAGE,
        number=1,
        message=test_execution.FileReference,
    )


class GetApkDetailsResponse(proto.Message):
    r"""Response containing the details of the specified Android
    application APK.

    Attributes:
        apk_detail (google.devtools.testing_v1.types.ApkDetail):
            Details of the Android APK.
    """

    apk_detail = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ApkDetail',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
