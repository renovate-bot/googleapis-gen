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
from google.type import date_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.testing.v1',
    manifest={
        'DeviceForm',
        'DeviceFormFactor',
        'DeviceIpBlock',
        'GetTestEnvironmentCatalogRequest',
        'TestEnvironmentCatalog',
        'DeviceIpBlockCatalog',
        'AndroidDeviceCatalog',
        'AndroidRuntimeConfiguration',
        'AndroidModel',
        'AndroidVersion',
        'Distribution',
        'IosDeviceCatalog',
        'IosRuntimeConfiguration',
        'IosModel',
        'IosVersion',
        'Locale',
        'Orientation',
        'XcodeVersion',
        'NetworkConfigurationCatalog',
        'NetworkConfiguration',
        'TrafficRule',
        'ProvidedSoftwareCatalog',
    },
)


class DeviceForm(proto.Enum):
    r"""Whether the device is physical or virtual."""
    DEVICE_FORM_UNSPECIFIED = 0
    VIRTUAL = 1
    PHYSICAL = 2
    EMULATOR = 3


class DeviceFormFactor(proto.Enum):
    r"""The form factor of a device."""
    DEVICE_FORM_FACTOR_UNSPECIFIED = 0
    PHONE = 1
    TABLET = 2
    WEARABLE = 3


class DeviceIpBlock(proto.Message):
    r"""A single device IP block
    Attributes:
        block (str):
            An IP address block in CIDR notation eg:
            34.68.194.64/29
        form (google.devtools.testing_v1.types.DeviceForm):
            Whether this block is used by physical or
            virtual devices
        added_date (google.type.date_pb2.Date):
            The date this block was added to Firebase
            Test Lab
    """

    block = proto.Field(
        proto.STRING,
        number=1,
    )
    form = proto.Field(
        proto.ENUM,
        number=2,
        enum='DeviceForm',
    )
    added_date = proto.Field(
        proto.MESSAGE,
        number=3,
        message=date_pb2.Date,
    )


class GetTestEnvironmentCatalogRequest(proto.Message):
    r"""Request to list the currently supported values for an
    environment type.

    Attributes:
        environment_type (google.devtools.testing_v1.types.GetTestEnvironmentCatalogRequest.EnvironmentType):
            Required. The type of environment that should
            be listed.
        project_id (str):
            For authorization, the cloud project
            requesting the TestEnvironmentCatalog.
    """
    class EnvironmentType(proto.Enum):
        r"""Types of environments the Test API supports."""
        ENVIRONMENT_TYPE_UNSPECIFIED = 0
        ANDROID = 1
        IOS = 3
        NETWORK_CONFIGURATION = 4
        PROVIDED_SOFTWARE = 5
        DEVICE_IP_BLOCKS = 6

    environment_type = proto.Field(
        proto.ENUM,
        number=1,
        enum=EnvironmentType,
    )
    project_id = proto.Field(
        proto.STRING,
        number=2,
    )


class TestEnvironmentCatalog(proto.Message):
    r"""A description of a test environment.
    Attributes:
        android_device_catalog (google.devtools.testing_v1.types.AndroidDeviceCatalog):
            Supported Android devices.
        ios_device_catalog (google.devtools.testing_v1.types.IosDeviceCatalog):
            Supported iOS devices.
        network_configuration_catalog (google.devtools.testing_v1.types.NetworkConfigurationCatalog):
            Supported network configurations.
        software_catalog (google.devtools.testing_v1.types.ProvidedSoftwareCatalog):
            The software test environment provided by
            TestExecutionService.
        device_ip_block_catalog (google.devtools.testing_v1.types.DeviceIpBlockCatalog):
            The IP blocks used by devices in the test
            environment.
    """

    android_device_catalog = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='environment_catalog',
        message='AndroidDeviceCatalog',
    )
    ios_device_catalog = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='environment_catalog',
        message='IosDeviceCatalog',
    )
    network_configuration_catalog = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='environment_catalog',
        message='NetworkConfigurationCatalog',
    )
    software_catalog = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='environment_catalog',
        message='ProvidedSoftwareCatalog',
    )
    device_ip_block_catalog = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='environment_catalog',
        message='DeviceIpBlockCatalog',
    )


class DeviceIpBlockCatalog(proto.Message):
    r"""List of IP blocks used by the Firebase Test Lab
    Attributes:
        ip_blocks (Sequence[google.devtools.testing_v1.types.DeviceIpBlock]):
            The device IP blocks used by Firebase Test
            Lab
    """

    ip_blocks = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='DeviceIpBlock',
    )


class AndroidDeviceCatalog(proto.Message):
    r"""The currently supported Android devices.
    Attributes:
        models (Sequence[google.devtools.testing_v1.types.AndroidModel]):
            The set of supported Android device models.
        versions (Sequence[google.devtools.testing_v1.types.AndroidVersion]):
            The set of supported Android OS versions.
        runtime_configuration (google.devtools.testing_v1.types.AndroidRuntimeConfiguration):
            The set of supported runtime configurations.
    """

    models = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='AndroidModel',
    )
    versions = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='AndroidVersion',
    )
    runtime_configuration = proto.Field(
        proto.MESSAGE,
        number=3,
        message='AndroidRuntimeConfiguration',
    )


class AndroidRuntimeConfiguration(proto.Message):
    r"""Android configuration that can be selected at the time a test
    is run.

    Attributes:
        locales (Sequence[google.devtools.testing_v1.types.Locale]):
            The set of available locales.
        orientations (Sequence[google.devtools.testing_v1.types.Orientation]):
            The set of available orientations.
    """

    locales = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Locale',
    )
    orientations = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Orientation',
    )


class AndroidModel(proto.Message):
    r"""A description of an Android device tests may be run on.
    Attributes:
        id (str):
            The unique opaque id for this model.
            Use this for invoking the TestExecutionService.
        name (str):
            The human-readable marketing name for this
            device model. Examples: "Nexus 5", "Galaxy S5".
        manufacturer (str):
            The manufacturer of this device.
        brand (str):
            The company that this device is branded with.
            Example: "Google", "Samsung".
        codename (str):
            The name of the industrial design.
            This corresponds to android.os.Build.DEVICE.
        form (google.devtools.testing_v1.types.DeviceForm):
            Whether this device is virtual or physical.
        form_factor (google.devtools.testing_v1.types.DeviceFormFactor):
            Whether this device is a phone, tablet,
            wearable, etc.
        screen_x (int):
            Screen size in the horizontal (X) dimension
            measured in pixels.
        screen_y (int):
            Screen size in the vertical (Y) dimension
            measured in pixels.
        screen_density (int):
            Screen density in DPI. This corresponds to ro.sf.lcd_density
        low_fps_video_recording (bool):
            True if and only if tests with this model are recorded by
            stitching together screenshots. See
            use_low_spec_video_recording in device config.
        supported_version_ids (Sequence[str]):
            The set of Android versions this device
            supports.
        supported_abis (Sequence[str]):
            The list of supported ABIs for this device. This corresponds
            to either android.os.Build.SUPPORTED_ABIS (for API level 21
            and above) or android.os.Build.CPU_ABI/CPU_ABI2. The most
            preferred ABI is the first element in the list.

            Elements are optionally prefixed by "version_id:" (where
            version_id is the id of an AndroidVersion), denoting an ABI
            that is supported only on a particular version.
        tags (Sequence[str]):
            Tags for this dimension.
            Examples: "default", "preview", "deprecated".
        thumbnail_url (str):
            URL of a thumbnail image (photo) of the
            device. e.g.
            https://lh3.googleusercontent.com/90WcauuJiCYABEl8U0lcZeuS5STUbf2yW...
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    name = proto.Field(
        proto.STRING,
        number=2,
    )
    manufacturer = proto.Field(
        proto.STRING,
        number=3,
    )
    brand = proto.Field(
        proto.STRING,
        number=9,
    )
    codename = proto.Field(
        proto.STRING,
        number=10,
    )
    form = proto.Field(
        proto.ENUM,
        number=4,
        enum='DeviceForm',
    )
    form_factor = proto.Field(
        proto.ENUM,
        number=16,
        enum='DeviceFormFactor',
    )
    screen_x = proto.Field(
        proto.INT32,
        number=5,
    )
    screen_y = proto.Field(
        proto.INT32,
        number=6,
    )
    screen_density = proto.Field(
        proto.INT32,
        number=12,
    )
    low_fps_video_recording = proto.Field(
        proto.BOOL,
        number=17,
    )
    supported_version_ids = proto.RepeatedField(
        proto.STRING,
        number=7,
    )
    supported_abis = proto.RepeatedField(
        proto.STRING,
        number=11,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=8,
    )
    thumbnail_url = proto.Field(
        proto.STRING,
        number=19,
    )


class AndroidVersion(proto.Message):
    r"""A version of the Android OS.
    Attributes:
        id (str):
            An opaque id for this Android version.
            Use this id to invoke the TestExecutionService.
        version_string (str):
            A string representing this version of the
            Android OS. Examples: "4.3", "4.4".
        api_level (int):
            The API level for this Android version.
            Examples: 18, 19.
        code_name (str):
            The code name for this Android version.
            Examples: "JellyBean", "KitKat".
        release_date (google.type.date_pb2.Date):
            The date this Android version became
            available in the market.
        distribution (google.devtools.testing_v1.types.Distribution):
            Market share for this version.
        tags (Sequence[str]):
            Tags for this dimension.
            Examples: "default", "preview", "deprecated".
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    version_string = proto.Field(
        proto.STRING,
        number=2,
    )
    api_level = proto.Field(
        proto.INT32,
        number=3,
    )
    code_name = proto.Field(
        proto.STRING,
        number=4,
    )
    release_date = proto.Field(
        proto.MESSAGE,
        number=5,
        message=date_pb2.Date,
    )
    distribution = proto.Field(
        proto.MESSAGE,
        number=6,
        message='Distribution',
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=7,
    )


class Distribution(proto.Message):
    r"""Data about the relative number of devices running a
    given configuration of the Android platform.

    Attributes:
        measurement_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this distribution was
            measured.
        market_share (float):
            Output only. The estimated fraction (0-1) of
            the total market with this configuration.
    """

    measurement_time = proto.Field(
        proto.MESSAGE,
        number=1,
        message=timestamp_pb2.Timestamp,
    )
    market_share = proto.Field(
        proto.DOUBLE,
        number=2,
    )


class IosDeviceCatalog(proto.Message):
    r"""The currently supported iOS devices.
    Attributes:
        models (Sequence[google.devtools.testing_v1.types.IosModel]):
            The set of supported iOS device models.
        versions (Sequence[google.devtools.testing_v1.types.IosVersion]):
            The set of supported iOS software versions.
        xcode_versions (Sequence[google.devtools.testing_v1.types.XcodeVersion]):
            The set of supported Xcode versions.
        runtime_configuration (google.devtools.testing_v1.types.IosRuntimeConfiguration):
            The set of supported runtime configurations.
    """

    models = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='IosModel',
    )
    versions = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='IosVersion',
    )
    xcode_versions = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message='XcodeVersion',
    )
    runtime_configuration = proto.Field(
        proto.MESSAGE,
        number=3,
        message='IosRuntimeConfiguration',
    )


class IosRuntimeConfiguration(proto.Message):
    r"""iOS configuration that can be selected at the time a test is
    run.

    Attributes:
        locales (Sequence[google.devtools.testing_v1.types.Locale]):
            The set of available locales.
        orientations (Sequence[google.devtools.testing_v1.types.Orientation]):
            The set of available orientations.
    """

    locales = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Locale',
    )
    orientations = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Orientation',
    )


class IosModel(proto.Message):
    r"""A description of an iOS device tests may be run on.
    Attributes:
        id (str):
            The unique opaque id for this model.
            Use this for invoking the TestExecutionService.
        name (str):
            The human-readable name for this device
            model. Examples: "iPhone 4s", "iPad Mini 2".
        supported_version_ids (Sequence[str]):
            The set of iOS major software versions this
            device supports.
        tags (Sequence[str]):
            Tags for this dimension.
            Examples: "default", "preview", "deprecated".
        device_capabilities (Sequence[str]):
            Device capabilities.
            Copied from
            https://developer.apple.com/library/archive/documentation/DeviceInformation/Reference/iOSDeviceCompatibility/DeviceCompatibilityMatrix/DeviceCompatibilityMatrix.html
        screen_x (int):
            Screen size in the horizontal (X) dimension
            measured in pixels.
        screen_y (int):
            Screen size in the vertical (Y) dimension
            measured in pixels.
        screen_density (int):
            Screen density in DPI.
        form_factor (google.devtools.testing_v1.types.DeviceFormFactor):
            Whether this device is a phone, tablet,
            wearable, etc.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    name = proto.Field(
        proto.STRING,
        number=2,
    )
    supported_version_ids = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    device_capabilities = proto.RepeatedField(
        proto.STRING,
        number=5,
    )
    screen_x = proto.Field(
        proto.INT32,
        number=7,
    )
    screen_y = proto.Field(
        proto.INT32,
        number=8,
    )
    screen_density = proto.Field(
        proto.INT32,
        number=9,
    )
    form_factor = proto.Field(
        proto.ENUM,
        number=6,
        enum='DeviceFormFactor',
    )


class IosVersion(proto.Message):
    r"""An iOS version.
    Attributes:
        id (str):
            An opaque id for this iOS version.
            Use this id to invoke the TestExecutionService.
        major_version (int):
            An integer representing the major iOS
            version. Examples: "8", "9".
        minor_version (int):
            An integer representing the minor iOS
            version. Examples: "1", "2".
        tags (Sequence[str]):
            Tags for this dimension.
            Examples: "default", "preview", "deprecated".
        supported_xcode_version_ids (Sequence[str]):
            The available Xcode versions for this
            version.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    major_version = proto.Field(
        proto.INT32,
        number=2,
    )
    minor_version = proto.Field(
        proto.INT32,
        number=4,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    supported_xcode_version_ids = proto.RepeatedField(
        proto.STRING,
        number=5,
    )


class Locale(proto.Message):
    r"""A location/region designation for language.
    Attributes:
        id (str):
            The id for this locale. Example: "en_US".
        name (str):
            A human-friendly name for this
            language/locale. Example: "English".
        region (str):
            A human-friendly string representing the
            region for this locale. Example: "United
            States". Not present for every locale.
        tags (Sequence[str]):
            Tags for this dimension.
            Example: "default".
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    name = proto.Field(
        proto.STRING,
        number=2,
    )
    region = proto.Field(
        proto.STRING,
        number=3,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class Orientation(proto.Message):
    r"""Screen orientation of the device.
    Attributes:
        id (str):
            The id for this orientation.
            Example: "portrait".
        name (str):
            A human-friendly name for this orientation.
            Example: "portrait".
        tags (Sequence[str]):
            Tags for this dimension.
            Example: "default".
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    name = proto.Field(
        proto.STRING,
        number=2,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class XcodeVersion(proto.Message):
    r"""An Xcode version that an iOS version is compatible with.
    Attributes:
        version (str):
            The id for this version.
            Example: "9.2".
        tags (Sequence[str]):
            Tags for this Xcode version.
            Example: "default".
    """

    version = proto.Field(
        proto.STRING,
        number=1,
    )
    tags = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class NetworkConfigurationCatalog(proto.Message):
    r"""
    Attributes:
        configurations (Sequence[google.devtools.testing_v1.types.NetworkConfiguration]):

    """

    configurations = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='NetworkConfiguration',
    )


class NetworkConfiguration(proto.Message):
    r"""
    Attributes:
        id (str):
            The unique opaque id for this network traffic
            configuration.
        up_rule (google.devtools.testing_v1.types.TrafficRule):
            The emulation rule applying to the upload
            traffic.
        down_rule (google.devtools.testing_v1.types.TrafficRule):
            The emulation rule applying to the download
            traffic.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    up_rule = proto.Field(
        proto.MESSAGE,
        number=2,
        message='TrafficRule',
    )
    down_rule = proto.Field(
        proto.MESSAGE,
        number=3,
        message='TrafficRule',
    )


class TrafficRule(proto.Message):
    r"""Network emulation parameters.
    Attributes:
        delay (google.protobuf.duration_pb2.Duration):
            Packet delay, must be >= 0.
        packet_loss_ratio (float):
            Packet loss ratio (0.0 - 1.0).
        packet_duplication_ratio (float):
            Packet duplication ratio (0.0 - 1.0).
        bandwidth (float):
            Bandwidth in kbits/second.
        burst (float):
            Burst size in kbits.
    """

    delay = proto.Field(
        proto.MESSAGE,
        number=1,
        message=duration_pb2.Duration,
    )
    packet_loss_ratio = proto.Field(
        proto.FLOAT,
        number=2,
    )
    packet_duplication_ratio = proto.Field(
        proto.FLOAT,
        number=3,
    )
    bandwidth = proto.Field(
        proto.FLOAT,
        number=4,
    )
    burst = proto.Field(
        proto.FLOAT,
        number=5,
    )


class ProvidedSoftwareCatalog(proto.Message):
    r"""The currently provided software environment on the devices
    under test.

    Attributes:
        orchestrator_version (str):
            A string representing the current version of
            Android Test Orchestrator that is used in the
            environment. The package is available at
            https://maven.google.com/web/index.html#com.android.support.test:orchestrator.
        androidx_orchestrator_version (str):
            A string representing the current version of
            AndroidX Test Orchestrator that is used in the
            environment. The package is available at
            https://maven.google.com/web/index.html#androidx.test:orchestrator.
    """

    orchestrator_version = proto.Field(
        proto.STRING,
        number=1,
    )
    androidx_orchestrator_version = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
