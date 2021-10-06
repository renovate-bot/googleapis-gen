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


__protobuf__ = proto.module(
    package='google.devtools.testing.v1',
    manifest={
        'OrchestratorOption',
        'RoboActionType',
        'InvalidMatrixDetails',
        'TestState',
        'OutcomeSummary',
        'TestMatrix',
        'TestExecution',
        'TestSpecification',
        'SystraceSetup',
        'TestSetup',
        'IosTestSetup',
        'EnvironmentVariable',
        'Account',
        'GoogleAuto',
        'Apk',
        'AppBundle',
        'DeviceFile',
        'ObbFile',
        'RegularFile',
        'IosDeviceFile',
        'AndroidTestLoop',
        'IosXcTest',
        'IosTestLoop',
        'AndroidInstrumentationTest',
        'AndroidRoboTest',
        'RoboDirective',
        'RoboStartingIntent',
        'LauncherActivityIntent',
        'StartActivityIntent',
        'EnvironmentMatrix',
        'AndroidDeviceList',
        'IosDeviceList',
        'AndroidMatrix',
        'ClientInfo',
        'ClientInfoDetail',
        'ResultStorage',
        'ToolResultsHistory',
        'ToolResultsExecution',
        'ToolResultsStep',
        'GoogleCloudStorage',
        'FileReference',
        'Environment',
        'AndroidDevice',
        'IosDevice',
        'TestDetails',
        'InvalidRequestDetail',
        'ShardingOption',
        'UniformSharding',
        'ManualSharding',
        'TestTargetsForShard',
        'Shard',
        'CreateTestMatrixRequest',
        'GetTestMatrixRequest',
        'CancelTestMatrixRequest',
        'CancelTestMatrixResponse',
    },
)


class OrchestratorOption(proto.Enum):
    r"""Specifies how to execute the test."""
    ORCHESTRATOR_OPTION_UNSPECIFIED = 0
    USE_ORCHESTRATOR = 1
    DO_NOT_USE_ORCHESTRATOR = 2


class RoboActionType(proto.Enum):
    r"""Actions which Robo can perform on UI elements."""
    ACTION_TYPE_UNSPECIFIED = 0
    SINGLE_CLICK = 1
    ENTER_TEXT = 2
    IGNORE = 3


class InvalidMatrixDetails(proto.Enum):
    r"""The detailed reason that a Matrix was deemed INVALID."""
    INVALID_MATRIX_DETAILS_UNSPECIFIED = 0
    DETAILS_UNAVAILABLE = 1
    MALFORMED_APK = 2
    MALFORMED_TEST_APK = 3
    NO_MANIFEST = 4
    NO_PACKAGE_NAME = 5
    INVALID_PACKAGE_NAME = 31
    TEST_SAME_AS_APP = 6
    NO_INSTRUMENTATION = 7
    NO_SIGNATURE = 20
    INSTRUMENTATION_ORCHESTRATOR_INCOMPATIBLE = 18
    NO_TEST_RUNNER_CLASS = 19
    NO_LAUNCHER_ACTIVITY = 8
    FORBIDDEN_PERMISSIONS = 9
    INVALID_ROBO_DIRECTIVES = 10
    INVALID_RESOURCE_NAME = 33
    INVALID_DIRECTIVE_ACTION = 34
    TEST_LOOP_INTENT_FILTER_NOT_FOUND = 12
    SCENARIO_LABEL_NOT_DECLARED = 13
    SCENARIO_LABEL_MALFORMED = 14
    SCENARIO_NOT_DECLARED = 15
    DEVICE_ADMIN_RECEIVER = 17
    MALFORMED_XC_TEST_ZIP = 11
    BUILT_FOR_IOS_SIMULATOR = 24
    NO_TESTS_IN_XC_TEST_ZIP = 25
    USE_DESTINATION_ARTIFACTS = 26
    TEST_NOT_APP_HOSTED = 28
    PLIST_CANNOT_BE_PARSED = 30
    TEST_ONLY_APK = 21
    MALFORMED_IPA = 22
    MISSING_URL_SCHEME = 35
    MALFORMED_APP_BUNDLE = 36
    NO_CODE_APK = 23
    INVALID_INPUT_APK = 27
    INVALID_APK_PREVIEW_SDK = 29


class TestState(proto.Enum):
    r"""The state (i.e., progress) of a test execution or matrix."""
    TEST_STATE_UNSPECIFIED = 0
    VALIDATING = 8
    PENDING = 1
    RUNNING = 2
    FINISHED = 3
    ERROR = 4
    UNSUPPORTED_ENVIRONMENT = 5
    INCOMPATIBLE_ENVIRONMENT = 9
    INCOMPATIBLE_ARCHITECTURE = 10
    CANCELLED = 6
    INVALID = 7


class OutcomeSummary(proto.Enum):
    r"""Outcome summary for a finished test matrix."""
    OUTCOME_SUMMARY_UNSPECIFIED = 0
    SUCCESS = 1
    FAILURE = 2
    INCONCLUSIVE = 3
    SKIPPED = 4


class TestMatrix(proto.Message):
    r"""TestMatrix captures all details about a test. It contains the
    environment configuration, test specification, test executions
    and overall state and outcome.

    Attributes:
        test_matrix_id (str):
            Output only. Unique id set by the service.
        project_id (str):
            The cloud project that owns the test matrix.
        client_info (google.devtools.testing_v1.types.ClientInfo):
            Information about the client which invoked
            the test.
        test_specification (google.devtools.testing_v1.types.TestSpecification):
            Required. How to run the test.
        environment_matrix (google.devtools.testing_v1.types.EnvironmentMatrix):
            Required. The devices the tests are being
            executed on.
        test_executions (Sequence[google.devtools.testing_v1.types.TestExecution]):
            Output only. The list of test executions that
            the service creates for this matrix.
        result_storage (google.devtools.testing_v1.types.ResultStorage):
            Required. Where the results for the matrix
            are written.
        state (google.devtools.testing_v1.types.TestState):
            Output only. Indicates the current progress
            of the test matrix.
        timestamp (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this test matrix was
            initially created.
        invalid_matrix_details (google.devtools.testing_v1.types.InvalidMatrixDetails):
            Output only. Describes why the matrix is
            considered invalid. Only useful for matrices in
            the INVALID state.
        flaky_test_attempts (int):
            The number of times a TestExecution should be
            re-attempted if one or more of its test cases
            fail for any reason. The maximum number of
            reruns allowed is 10.

            Default is 0, which implies no reruns.
        outcome_summary (google.devtools.testing_v1.types.OutcomeSummary):
            Output Only. The overall outcome of the test.
            Only set when the test matrix state is FINISHED.
        fail_fast (bool):
            If true, only a single attempt at most will
            be made to run each execution/shard in the
            matrix. Flaky test attempts are not affected.
            Normally, 2 or more attempts are made if a
            potential infrastructure issue is detected.

            This feature is for latency sensitive workloads.
            The incidence of execution failures may be
            significantly greater for fail-fast matrices and
            support is more limited because of that
            expectation.
    """

    test_matrix_id = proto.Field(
        proto.STRING,
        number=1,
    )
    project_id = proto.Field(
        proto.STRING,
        number=7,
    )
    client_info = proto.Field(
        proto.MESSAGE,
        number=10,
        message='ClientInfo',
    )
    test_specification = proto.Field(
        proto.MESSAGE,
        number=3,
        message='TestSpecification',
    )
    environment_matrix = proto.Field(
        proto.MESSAGE,
        number=4,
        message='EnvironmentMatrix',
    )
    test_executions = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message='TestExecution',
    )
    result_storage = proto.Field(
        proto.MESSAGE,
        number=6,
        message='ResultStorage',
    )
    state = proto.Field(
        proto.ENUM,
        number=8,
        enum='TestState',
    )
    timestamp = proto.Field(
        proto.MESSAGE,
        number=9,
        message=timestamp_pb2.Timestamp,
    )
    invalid_matrix_details = proto.Field(
        proto.ENUM,
        number=11,
        enum='InvalidMatrixDetails',
    )
    flaky_test_attempts = proto.Field(
        proto.INT32,
        number=13,
    )
    outcome_summary = proto.Field(
        proto.ENUM,
        number=14,
        enum='OutcomeSummary',
    )
    fail_fast = proto.Field(
        proto.BOOL,
        number=17,
    )


class TestExecution(proto.Message):
    r"""A single test executed in a single environment.

    Attributes:
        id (str):
            Output only. Unique id set by the service.
        matrix_id (str):
            Output only. Id of the containing TestMatrix.
        project_id (str):
            Output only. The cloud project that owns the
            test execution.
        test_specification (google.devtools.testing_v1.types.TestSpecification):
            Output only. How to run the test.
        shard (google.devtools.testing_v1.types.Shard):
            Output only. Details about the shard.
        environment (google.devtools.testing_v1.types.Environment):
            Output only. How the host machine(s) are
            configured.
        state (google.devtools.testing_v1.types.TestState):
            Output only. Indicates the current progress
            of the test execution (e.g., FINISHED).
        tool_results_step (google.devtools.testing_v1.types.ToolResultsStep):
            Output only. Where the results for this
            execution are written.
        timestamp (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this test execution was
            initially created.
        test_details (google.devtools.testing_v1.types.TestDetails):
            Output only. Additional details about the
            running test.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    matrix_id = proto.Field(
        proto.STRING,
        number=9,
    )
    project_id = proto.Field(
        proto.STRING,
        number=10,
    )
    test_specification = proto.Field(
        proto.MESSAGE,
        number=3,
        message='TestSpecification',
    )
    shard = proto.Field(
        proto.MESSAGE,
        number=12,
        message='Shard',
    )
    environment = proto.Field(
        proto.MESSAGE,
        number=4,
        message='Environment',
    )
    state = proto.Field(
        proto.ENUM,
        number=5,
        enum='TestState',
    )
    tool_results_step = proto.Field(
        proto.MESSAGE,
        number=11,
        message='ToolResultsStep',
    )
    timestamp = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )
    test_details = proto.Field(
        proto.MESSAGE,
        number=8,
        message='TestDetails',
    )


class TestSpecification(proto.Message):
    r"""A description of how to run the test.

    Attributes:
        test_timeout (google.protobuf.duration_pb2.Duration):
            Max time a test execution is allowed to run
            before it is automatically cancelled.
            The default value is 5 min.
        test_setup (google.devtools.testing_v1.types.TestSetup):
            Test setup requirements for Android e.g.
            files to install, bootstrap scripts.
        ios_test_setup (google.devtools.testing_v1.types.IosTestSetup):
            Test setup requirements for iOS.
        android_instrumentation_test (google.devtools.testing_v1.types.AndroidInstrumentationTest):
            An Android instrumentation test.
        android_robo_test (google.devtools.testing_v1.types.AndroidRoboTest):
            An Android robo test.
        android_test_loop (google.devtools.testing_v1.types.AndroidTestLoop):
            An Android Application with a Test Loop.
        ios_xc_test (google.devtools.testing_v1.types.IosXcTest):
            An iOS XCTest, via an .xctestrun file.
        ios_test_loop (google.devtools.testing_v1.types.IosTestLoop):
            An iOS application with a test loop.
        disable_video_recording (bool):
            Disables video recording. May reduce test
            latency.
        disable_performance_metrics (bool):
            Disables performance metrics recording. May
            reduce test latency.
    """

    test_timeout = proto.Field(
        proto.MESSAGE,
        number=1,
        message=duration_pb2.Duration,
    )
    test_setup = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='setup',
        message='TestSetup',
    )
    ios_test_setup = proto.Field(
        proto.MESSAGE,
        number=14,
        oneof='setup',
        message='IosTestSetup',
    )
    android_instrumentation_test = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='test',
        message='AndroidInstrumentationTest',
    )
    android_robo_test = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='test',
        message='AndroidRoboTest',
    )
    android_test_loop = proto.Field(
        proto.MESSAGE,
        number=9,
        oneof='test',
        message='AndroidTestLoop',
    )
    ios_xc_test = proto.Field(
        proto.MESSAGE,
        number=13,
        oneof='test',
        message='IosXcTest',
    )
    ios_test_loop = proto.Field(
        proto.MESSAGE,
        number=15,
        oneof='test',
        message='IosTestLoop',
    )
    disable_video_recording = proto.Field(
        proto.BOOL,
        number=10,
    )
    disable_performance_metrics = proto.Field(
        proto.BOOL,
        number=11,
    )


class SystraceSetup(proto.Message):
    r"""

    Attributes:
        duration_seconds (int):
            Systrace duration in seconds.
            Should be between 1 and 30 seconds. 0 disables
            systrace.
    """

    duration_seconds = proto.Field(
        proto.INT32,
        number=1,
    )


class TestSetup(proto.Message):
    r"""A description of how to set up the Android device prior to
    running the test.

    Attributes:
        files_to_push (Sequence[google.devtools.testing_v1.types.DeviceFile]):
            List of files to push to the device before
            starting the test.
        directories_to_pull (Sequence[str]):
            List of directories on the device to upload to GCS at the
            end of the test; they must be absolute paths under /sdcard,
            /storage or /data/local/tmp. Path names are restricted to
            characters a-z A-Z 0-9 \_ - . + and /

            Note: The paths /sdcard and /data will be made available and
            treated as implicit path substitutions. E.g. if /sdcard on a
            particular device does not map to external storage, the
            system will replace it with the external storage path prefix
            for that device.
        additional_apks (Sequence[google.devtools.testing_v1.types.Apk]):
            APKs to install in addition to those being
            directly tested. Currently capped at 100.
        account (google.devtools.testing_v1.types.Account):
            The device will be logged in on this account
            for the duration of the test.
        network_profile (str):
            The network traffic profile used for running the test.
            Available network profiles can be queried by using the
            NETWORK_CONFIGURATION environment type when calling
            TestEnvironmentDiscoveryService.GetTestEnvironmentCatalog.
        environment_variables (Sequence[google.devtools.testing_v1.types.EnvironmentVariable]):
            Environment variables to set for the test
            (only applicable for instrumentation tests).
        systrace (google.devtools.testing_v1.types.SystraceSetup):
            Systrace configuration for the run.
            If set a systrace will be taken, starting on
            test start and lasting for the configured
            duration. The systrace file thus obtained is put
            in the results bucket together with the other
            artifacts from the run.
        dont_autogrant_permissions (bool):
            Whether to prevent all runtime permissions to
            be granted at app install
    """

    files_to_push = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='DeviceFile',
    )
    directories_to_pull = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    additional_apks = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='Apk',
    )
    account = proto.Field(
        proto.MESSAGE,
        number=4,
        message='Account',
    )
    network_profile = proto.Field(
        proto.STRING,
        number=5,
    )
    environment_variables = proto.RepeatedField(
        proto.MESSAGE,
        number=6,
        message='EnvironmentVariable',
    )
    systrace = proto.Field(
        proto.MESSAGE,
        number=9,
        message='SystraceSetup',
    )
    dont_autogrant_permissions = proto.Field(
        proto.BOOL,
        number=23,
    )


class IosTestSetup(proto.Message):
    r"""A description of how to set up an iOS device prior to running
    the test.

    Attributes:
        network_profile (str):
            The network traffic profile used for running the test.
            Available network profiles can be queried by using the
            NETWORK_CONFIGURATION environment type when calling
            TestEnvironmentDiscoveryService.GetTestEnvironmentCatalog.
        additional_ipas (Sequence[google.devtools.testing_v1.types.FileReference]):
            iOS apps to install in addition to those
            being directly tested.
        push_files (Sequence[google.devtools.testing_v1.types.IosDeviceFile]):
            List of files to push to the device before
            starting the test.
        pull_directories (Sequence[google.devtools.testing_v1.types.IosDeviceFile]):
            List of directories on the device to upload
            to Cloud Storage at the end of the test.

            Directories should either be in a shared
            directory (e.g. /private/var/mobile/Media) or
            within an accessible directory inside the app's
            filesystem (e.g. /Documents) by specifying the
            bundle id.
    """

    network_profile = proto.Field(
        proto.STRING,
        number=1,
    )
    additional_ipas = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='FileReference',
    )
    push_files = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='IosDeviceFile',
    )
    pull_directories = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message='IosDeviceFile',
    )


class EnvironmentVariable(proto.Message):
    r"""A key-value pair passed as an environment variable to the
    test.

    Attributes:
        key (str):
            Key for the environment variable.
        value (str):
            Value for the environment variable.
    """

    key = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class Account(proto.Message):
    r"""Identifies an account and how to log into it.

    Attributes:
        google_auto (google.devtools.testing_v1.types.GoogleAuto):
            An automatic google login account.
    """

    google_auto = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='account_type',
        message='GoogleAuto',
    )


class GoogleAuto(proto.Message):
    r"""Enables automatic Google account login.
    If set, the service automatically generates a Google test
    account and adds it to the device, before executing the test.
    Note that test accounts might be reused.
    Many applications show their full set of functionalities when an
    account is present on the device. Logging into the device with
    these generated accounts allows testing more functionalities.

    """


class Apk(proto.Message):
    r"""An Android package file to install.

    Attributes:
        location (google.devtools.testing_v1.types.FileReference):
            The path to an APK to be installed on the
            device before the test begins.
        package_name (str):
            The java package for the APK to be installed.
            Value is determined by examining the
            application's manifest.
    """

    location = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FileReference',
    )
    package_name = proto.Field(
        proto.STRING,
        number=2,
    )


class AppBundle(proto.Message):
    r"""An Android App Bundle file format, containing a
    BundleConfig.pb file, a base module directory, zero or more
    dynamic feature module directories. <p>See
    https://developer.android.com/guide/app-bundle/build for
    guidance on building App Bundles.

    Attributes:
        bundle_location (google.devtools.testing_v1.types.FileReference):
            .aab file representing the app bundle under
            test.
    """

    bundle_location = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='bundle',
        message='FileReference',
    )


class DeviceFile(proto.Message):
    r"""A single device file description.

    Attributes:
        obb_file (google.devtools.testing_v1.types.ObbFile):
            A reference to an opaque binary blob file.
        regular_file (google.devtools.testing_v1.types.RegularFile):
            A reference to a regular file.
    """

    obb_file = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='device_file',
        message='ObbFile',
    )
    regular_file = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='device_file',
        message='RegularFile',
    )


class ObbFile(proto.Message):
    r"""An opaque binary blob file to install on the device before
    the test starts.

    Attributes:
        obb_file_name (str):
            Required. OBB file name which must conform to the format as
            specified by Android e.g.
            [main|patch].0300110.com.example.android.obb which will be
            installed into <shared-storage>/Android/obb/<package-name>/
            on the device.
        obb (google.devtools.testing_v1.types.FileReference):
            Required. Opaque Binary Blob (OBB) file(s) to
            install on the device.
    """

    obb_file_name = proto.Field(
        proto.STRING,
        number=1,
    )
    obb = proto.Field(
        proto.MESSAGE,
        number=2,
        message='FileReference',
    )


class RegularFile(proto.Message):
    r"""A file or directory to install on the device before the test
    starts.

    Attributes:
        content (google.devtools.testing_v1.types.FileReference):
            Required. The source file.
        device_path (str):
            Required. Where to put the content on the device. Must be an
            absolute, allowlisted path. If the file exists, it will be
            replaced. The following device-side directories and any of
            their subdirectories are allowlisted:

            .. raw:: html

                <p>${EXTERNAL_STORAGE}, /sdcard, or /storage</p>
                <p>${ANDROID_DATA}/local/tmp, or /data/local/tmp</p>
                <p>Specifying a path outside of these directory trees is invalid.

            .. raw:: html

                <p> The paths /sdcard and /data will be made available and treated as
                implicit path substitutions. E.g. if /sdcard on a particular device does
                not map to external storage, the system will replace it with the external
                storage path prefix for that device and copy the file there.

            .. raw:: html

                <p> It is strongly advised to use the <a href=
                "http://developer.android.com/reference/android/os/Environment.html">
                Environment API</a> in app and test code to access files on the device in a
                portable way.
    """

    content = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FileReference',
    )
    device_path = proto.Field(
        proto.STRING,
        number=2,
    )


class IosDeviceFile(proto.Message):
    r"""A file or directory to install on the device before the test
    starts.

    Attributes:
        content (google.devtools.testing_v1.types.FileReference):
            The source file
        bundle_id (str):
            The bundle id of the app where this file
            lives.
            iOS apps sandbox their own filesystem, so app
            files must specify which app installed on the
            device.
        device_path (str):
            Location of the file on the device, inside
            the app's sandboxed filesystem
    """

    content = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FileReference',
    )
    bundle_id = proto.Field(
        proto.STRING,
        number=2,
    )
    device_path = proto.Field(
        proto.STRING,
        number=3,
    )


class AndroidTestLoop(proto.Message):
    r"""A test of an Android Application with a Test Loop.
    The intent \<intent-name\> will be implicitly added, since Games
    is the only user of this api, for the time being.

    Attributes:
        app_apk (google.devtools.testing_v1.types.FileReference):
            The APK for the application under test.
        app_bundle (google.devtools.testing_v1.types.AppBundle):
            A multi-apk app bundle for the application
            under test.
        app_package_id (str):
            The java package for the application under
            test. The default is determined by examining the
            application's manifest.
        scenarios (Sequence[int]):
            The list of scenarios that should be run
            during the test. The default is all test loops,
            derived from the application's manifest.
        scenario_labels (Sequence[str]):
            The list of scenario labels that should be run during the
            test. The scenario labels should map to labels defined in
            the application's manifest. For example, player_experience
            and com.google.test.loops.player_experience add all of the
            loops labeled in the manifest with the
            com.google.test.loops.player_experience name to the
            execution. Scenarios can also be specified in the scenarios
            field.
    """

    app_apk = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='app_under_test',
        message='FileReference',
    )
    app_bundle = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='app_under_test',
        message='AppBundle',
    )
    app_package_id = proto.Field(
        proto.STRING,
        number=2,
    )
    scenarios = proto.RepeatedField(
        proto.INT32,
        number=3,
    )
    scenario_labels = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class IosXcTest(proto.Message):
    r"""A test of an iOS application that uses the XCTest framework.
    Xcode supports the option to "build for testing", which
    generates an .xctestrun file that contains a test specification
    (arguments, test methods, etc). This test type accepts a zip
    file containing the .xctestrun file and the corresponding
    contents of the Build/Products directory that contains all the
    binaries needed to run the tests.

    Attributes:
        tests_zip (google.devtools.testing_v1.types.FileReference):
            Required. The .zip containing the .xctestrun
            file and the contents of the
            DerivedData/Build/Products directory. The
            .xctestrun file in this zip is ignored if the
            xctestrun field is specified.
        xctestrun (google.devtools.testing_v1.types.FileReference):
            An .xctestrun file that will override the
            .xctestrun file in the tests zip. Because the
            .xctestrun file contains environment variables
            along with test methods to run and/or ignore,
            this can be useful for sharding tests. Default
            is taken from the tests zip.
        xcode_version (str):
            The Xcode version that should be used for the
            test. Use the TestEnvironmentDiscoveryService to
            get supported options. Defaults to the latest
            Xcode version Firebase Test Lab supports.
        app_bundle_id (str):
            Output only. The bundle id for the
            application under test.
        test_special_entitlements (bool):
            The option to test special app entitlements.
            Setting this would re-sign the app having
            special entitlements with an explicit
            application-identifier. Currently supports
            testing aps-environment entitlement.
    """

    tests_zip = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FileReference',
    )
    xctestrun = proto.Field(
        proto.MESSAGE,
        number=2,
        message='FileReference',
    )
    xcode_version = proto.Field(
        proto.STRING,
        number=3,
    )
    app_bundle_id = proto.Field(
        proto.STRING,
        number=4,
    )
    test_special_entitlements = proto.Field(
        proto.BOOL,
        number=6,
    )


class IosTestLoop(proto.Message):
    r"""A test of an iOS application that implements one or more game
    loop scenarios. This test type accepts an archived application
    (.ipa file) and a list of integer scenarios that will be
    executed on the app sequentially.

    Attributes:
        app_ipa (google.devtools.testing_v1.types.FileReference):
            Required. The .ipa of the application to
            test.
        scenarios (Sequence[int]):
            The list of scenarios that should be run
            during the test. Defaults to the single scenario
            0 if unspecified.
        app_bundle_id (str):
            Output only. The bundle id for the
            application under test.
    """

    app_ipa = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FileReference',
    )
    scenarios = proto.RepeatedField(
        proto.INT32,
        number=2,
    )
    app_bundle_id = proto.Field(
        proto.STRING,
        number=3,
    )


class AndroidInstrumentationTest(proto.Message):
    r"""A test of an Android application that can control an Android
    component independently of its normal lifecycle. Android
    instrumentation tests run an application APK and test APK inside the
    same process on a virtual or physical AndroidDevice. They also
    specify a test runner class, such as com.google.GoogleTestRunner,
    which can vary on the specific instrumentation framework chosen.

    See http://developer.android.com/tools/testing/testing_android.html
    for more information on types of Android tests.

    Attributes:
        app_apk (google.devtools.testing_v1.types.FileReference):
            The APK for the application under test.
        app_bundle (google.devtools.testing_v1.types.AppBundle):
            A multi-apk app bundle for the application
            under test.
        test_apk (google.devtools.testing_v1.types.FileReference):
            Required. The APK containing the test code to
            be executed.
        app_package_id (str):
            The java package for the application under
            test. The default value is determined by
            examining the application's manifest.
        test_package_id (str):
            The java package for the test to be executed.
            The default value is determined by examining the
            application's manifest.
        test_runner_class (str):
            The InstrumentationTestRunner class.
            The default value is determined by examining the
            application's manifest.
        test_targets (Sequence[str]):
            Each target must be fully qualified with the package name or
            class name, in one of these formats:

            -  "package package_name"
            -  "class package_name.class_name"
            -  "class package_name.class_name#method_name"

            If empty, all targets in the module will be run.
        orchestrator_option (google.devtools.testing_v1.types.OrchestratorOption):
            The option of whether running each test within its own
            invocation of instrumentation with Android Test Orchestrator
            or not. \*\* Orchestrator is only compatible with
            AndroidJUnitRunner version 1.0 or higher! \*\* Orchestrator
            offers the following benefits:

            -  No shared state
            -  Crashes are isolated
            -  Logs are scoped per test

            See
            https://developer.android.com/training/testing/junit-runner.html#using-android-test-orchestrator
            for more information about Android Test Orchestrator.

            If not set, the test will be run without the orchestrator.
        sharding_option (google.devtools.testing_v1.types.ShardingOption):
            The option to run tests in multiple shards in
            parallel.
    """

    app_apk = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='app_under_test',
        message='FileReference',
    )
    app_bundle = proto.Field(
        proto.MESSAGE,
        number=8,
        oneof='app_under_test',
        message='AppBundle',
    )
    test_apk = proto.Field(
        proto.MESSAGE,
        number=2,
        message='FileReference',
    )
    app_package_id = proto.Field(
        proto.STRING,
        number=3,
    )
    test_package_id = proto.Field(
        proto.STRING,
        number=4,
    )
    test_runner_class = proto.Field(
        proto.STRING,
        number=5,
    )
    test_targets = proto.RepeatedField(
        proto.STRING,
        number=6,
    )
    orchestrator_option = proto.Field(
        proto.ENUM,
        number=7,
        enum='OrchestratorOption',
    )
    sharding_option = proto.Field(
        proto.MESSAGE,
        number=9,
        message='ShardingOption',
    )


class AndroidRoboTest(proto.Message):
    r"""A test of an android application that explores the
    application on a virtual or physical Android Device, finding
    culprits and crashes as it goes. Next tag: 30

    Attributes:
        app_apk (google.devtools.testing_v1.types.FileReference):
            The APK for the application under test.
        app_bundle (google.devtools.testing_v1.types.AppBundle):
            A multi-apk app bundle for the application
            under test.
        app_package_id (str):
            The java package for the application under
            test. The default value is determined by
            examining the application's manifest.
        app_initial_activity (str):
            The initial activity that should be used to
            start the app.
        max_depth (int):
            The max depth of the traversal stack Robo can
            explore. Needs to be at least 2 to make Robo
            explore the app beyond the first activity.
            Default is 50.
        max_steps (int):
            The max number of steps Robo can execute.
            Default is no limit.
        robo_directives (Sequence[google.devtools.testing_v1.types.RoboDirective]):
            A set of directives Robo should apply during
            the crawl. This allows users to customize the
            crawl. For example, the username and password
            for a test account can be provided.
        robo_script (google.devtools.testing_v1.types.FileReference):
            A JSON file with a sequence of actions Robo
            should perform as a prologue for the crawl.
        starting_intents (Sequence[google.devtools.testing_v1.types.RoboStartingIntent]):
            The intents used to launch the app for the
            crawl. If none are provided, then the main
            launcher activity is launched. If some are
            provided, then only those provided are launched
            (the main launcher activity must be provided
            explicitly).
    """

    app_apk = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='app_under_test',
        message='FileReference',
    )
    app_bundle = proto.Field(
        proto.MESSAGE,
        number=16,
        oneof='app_under_test',
        message='AppBundle',
    )
    app_package_id = proto.Field(
        proto.STRING,
        number=2,
    )
    app_initial_activity = proto.Field(
        proto.STRING,
        number=3,
    )
    max_depth = proto.Field(
        proto.INT32,
        number=7,
    )
    max_steps = proto.Field(
        proto.INT32,
        number=8,
    )
    robo_directives = proto.RepeatedField(
        proto.MESSAGE,
        number=11,
        message='RoboDirective',
    )
    robo_script = proto.Field(
        proto.MESSAGE,
        number=13,
        message='FileReference',
    )
    starting_intents = proto.RepeatedField(
        proto.MESSAGE,
        number=15,
        message='RoboStartingIntent',
    )


class RoboDirective(proto.Message):
    r"""Directs Robo to interact with a specific UI element if it is
    encountered during the crawl. Currently, Robo can perform text
    entry or element click.

    Attributes:
        resource_name (str):
            Required. The android resource name of the
            target UI element. For example,
               in Java: R.string.foo
               in xml: @string/foo
            Only the "foo" part is needed.
            Reference doc:
            https://developer.android.com/guide/topics/resources/accessing-
            resources.html
        input_text (str):
            The text that Robo is directed to set. If left empty, the
            directive will be treated as a CLICK on the element matching
            the resource_name.
        action_type (google.devtools.testing_v1.types.RoboActionType):
            Required. The type of action that Robo should
            perform on the specified element.
    """

    resource_name = proto.Field(
        proto.STRING,
        number=1,
    )
    input_text = proto.Field(
        proto.STRING,
        number=2,
    )
    action_type = proto.Field(
        proto.ENUM,
        number=3,
        enum='RoboActionType',
    )


class RoboStartingIntent(proto.Message):
    r"""Message for specifying the start activities to crawl.

    Attributes:
        launcher_activity (google.devtools.testing_v1.types.LauncherActivityIntent):
            An intent that starts the main launcher
            activity.
        start_activity (google.devtools.testing_v1.types.StartActivityIntent):
            An intent that starts an activity with
            specific details.
        timeout (google.protobuf.duration_pb2.Duration):
            Timeout in seconds for each intent.
    """

    launcher_activity = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='starting_intent',
        message='LauncherActivityIntent',
    )
    start_activity = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='starting_intent',
        message='StartActivityIntent',
    )
    timeout = proto.Field(
        proto.MESSAGE,
        number=3,
        message=duration_pb2.Duration,
    )


class LauncherActivityIntent(proto.Message):
    r"""Specifies an intent that starts the main launcher activity.
    """


class StartActivityIntent(proto.Message):
    r"""A starting intent specified by an action, uri, and
    categories.

    Attributes:
        action (str):
            Action name. Required for START_ACTIVITY.
        uri (str):
            URI for the action.
        categories (Sequence[str]):
            Intent categories to set on the intent.
    """

    action = proto.Field(
        proto.STRING,
        number=2,
    )
    uri = proto.Field(
        proto.STRING,
        number=3,
    )
    categories = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class EnvironmentMatrix(proto.Message):
    r"""The matrix of environments in which the test is to be
    executed.

    Attributes:
        android_matrix (google.devtools.testing_v1.types.AndroidMatrix):
            A matrix of Android devices.
        android_device_list (google.devtools.testing_v1.types.AndroidDeviceList):
            A list of Android devices; the test will be
            run only on the specified devices.
        ios_device_list (google.devtools.testing_v1.types.IosDeviceList):
            A list of iOS devices.
    """

    android_matrix = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='environment_matrix',
        message='AndroidMatrix',
    )
    android_device_list = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='environment_matrix',
        message='AndroidDeviceList',
    )
    ios_device_list = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='environment_matrix',
        message='IosDeviceList',
    )


class AndroidDeviceList(proto.Message):
    r"""A list of Android device configurations in which the test is
    to be executed.

    Attributes:
        android_devices (Sequence[google.devtools.testing_v1.types.AndroidDevice]):
            Required. A list of Android devices.
    """

    android_devices = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='AndroidDevice',
    )


class IosDeviceList(proto.Message):
    r"""A list of iOS device configurations in which the test is to
    be executed.

    Attributes:
        ios_devices (Sequence[google.devtools.testing_v1.types.IosDevice]):
            Required. A list of iOS devices.
    """

    ios_devices = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='IosDevice',
    )


class AndroidMatrix(proto.Message):
    r"""A set of Android device configuration permutations is defined
    by the the cross-product of the given axes. Internally, the
    given AndroidMatrix will be expanded into a set of
    AndroidDevices.

    Only supported permutations will be instantiated.  Invalid
    permutations (e.g., incompatible models/versions) are ignored.

    Attributes:
        android_model_ids (Sequence[str]):
            Required. The ids of the set of Android
            device to be used. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
        android_version_ids (Sequence[str]):
            Required. The ids of the set of Android OS
            version to be used. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
        locales (Sequence[str]):
            Required. The set of locales the test device
            will enable for testing. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
        orientations (Sequence[str]):
            Required. The set of orientations to test
            with. Use the TestEnvironmentDiscoveryService to
            get supported options.
    """

    android_model_ids = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    android_version_ids = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    locales = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    orientations = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class ClientInfo(proto.Message):
    r"""Information about the client which invoked the test.

    Attributes:
        name (str):
            Required. Client name, such as gcloud.
        client_info_details (Sequence[google.devtools.testing_v1.types.ClientInfoDetail]):
            The list of detailed information about
            client.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    client_info_details = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='ClientInfoDetail',
    )


class ClientInfoDetail(proto.Message):
    r"""Key-value pair of detailed information about the client which
    invoked the test. Examples: {'Version', '1.0'}, {'Release
    Track', 'BETA'}.

    Attributes:
        key (str):
            Required. The key of detailed client
            information.
        value (str):
            Required. The value of detailed client
            information.
    """

    key = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class ResultStorage(proto.Message):
    r"""Locations where the results of running the test are stored.

    Attributes:
        google_cloud_storage (google.devtools.testing_v1.types.GoogleCloudStorage):
            Required.
        tool_results_history (google.devtools.testing_v1.types.ToolResultsHistory):
            The tool results history that contains the
            tool results execution that results are written
            to.
            If not provided, the service will choose an
            appropriate value.
        tool_results_execution (google.devtools.testing_v1.types.ToolResultsExecution):
            Output only. The tool results execution that
            results are written to.
        results_url (str):
            Output only. URL to the results in the
            Firebase Web Console.
    """

    google_cloud_storage = proto.Field(
        proto.MESSAGE,
        number=1,
        message='GoogleCloudStorage',
    )
    tool_results_history = proto.Field(
        proto.MESSAGE,
        number=5,
        message='ToolResultsHistory',
    )
    tool_results_execution = proto.Field(
        proto.MESSAGE,
        number=6,
        message='ToolResultsExecution',
    )
    results_url = proto.Field(
        proto.STRING,
        number=7,
    )


class ToolResultsHistory(proto.Message):
    r"""Represents a tool results history resource.

    Attributes:
        project_id (str):
            Required. The cloud project that owns the
            tool results history.
        history_id (str):
            Required. A tool results history ID.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    history_id = proto.Field(
        proto.STRING,
        number=2,
    )


class ToolResultsExecution(proto.Message):
    r"""Represents a tool results execution resource.
    This has the results of a TestMatrix.

    Attributes:
        project_id (str):
            Output only. The cloud project that owns the
            tool results execution.
        history_id (str):
            Output only. A tool results history ID.
        execution_id (str):
            Output only. A tool results execution ID.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    history_id = proto.Field(
        proto.STRING,
        number=2,
    )
    execution_id = proto.Field(
        proto.STRING,
        number=3,
    )


class ToolResultsStep(proto.Message):
    r"""Represents a tool results step resource.
    This has the results of a TestExecution.

    Attributes:
        project_id (str):
            Output only. The cloud project that owns the
            tool results step.
        history_id (str):
            Output only. A tool results history ID.
        execution_id (str):
            Output only. A tool results execution ID.
        step_id (str):
            Output only. A tool results step ID.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    history_id = proto.Field(
        proto.STRING,
        number=2,
    )
    execution_id = proto.Field(
        proto.STRING,
        number=3,
    )
    step_id = proto.Field(
        proto.STRING,
        number=4,
    )


class GoogleCloudStorage(proto.Message):
    r"""A storage location within Google cloud storage (GCS).

    Attributes:
        gcs_path (str):
            Required. The path to a directory in GCS that
            will eventually contain the results for this
            test. The requesting user must have write access
            on the bucket in the supplied path.
    """

    gcs_path = proto.Field(
        proto.STRING,
        number=1,
    )


class FileReference(proto.Message):
    r"""A reference to a file, used for user inputs.

    Attributes:
        gcs_path (str):
            A path to a file in Google Cloud Storage.
            Example: gs://build-
            app-1414623860166/app%40debug-unaligned.apk
            These paths are expected to be url encoded
            (percent encoding)
    """

    gcs_path = proto.Field(
        proto.STRING,
        number=1,
        oneof='file',
    )


class Environment(proto.Message):
    r"""The environment in which the test is run.

    Attributes:
        android_device (google.devtools.testing_v1.types.AndroidDevice):
            An Android device which must be used with an
            Android test.
        ios_device (google.devtools.testing_v1.types.IosDevice):
            An iOS device which must be used with an iOS
            test.
    """

    android_device = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='environment',
        message='AndroidDevice',
    )
    ios_device = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='environment',
        message='IosDevice',
    )


class AndroidDevice(proto.Message):
    r"""A single Android device.

    Attributes:
        android_model_id (str):
            Required. The id of the Android device to be
            used. Use the TestEnvironmentDiscoveryService to
            get supported options.
        android_version_id (str):
            Required. The id of the Android OS version to
            be used. Use the TestEnvironmentDiscoveryService
            to get supported options.
        locale (str):
            Required. The locale the test device used for
            testing. Use the TestEnvironmentDiscoveryService
            to get supported options.
        orientation (str):
            Required. How the device is oriented during
            the test. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
    """

    android_model_id = proto.Field(
        proto.STRING,
        number=1,
    )
    android_version_id = proto.Field(
        proto.STRING,
        number=2,
    )
    locale = proto.Field(
        proto.STRING,
        number=3,
    )
    orientation = proto.Field(
        proto.STRING,
        number=4,
    )


class IosDevice(proto.Message):
    r"""A single iOS device.

    Attributes:
        ios_model_id (str):
            Required. The id of the iOS device to be
            used. Use the TestEnvironmentDiscoveryService to
            get supported options.
        ios_version_id (str):
            Required. The id of the iOS major software
            version to be used. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
        locale (str):
            Required. The locale the test device used for
            testing. Use the TestEnvironmentDiscoveryService
            to get supported options.
        orientation (str):
            Required. How the device is oriented during
            the test. Use the
            TestEnvironmentDiscoveryService to get supported
            options.
    """

    ios_model_id = proto.Field(
        proto.STRING,
        number=1,
    )
    ios_version_id = proto.Field(
        proto.STRING,
        number=2,
    )
    locale = proto.Field(
        proto.STRING,
        number=3,
    )
    orientation = proto.Field(
        proto.STRING,
        number=4,
    )


class TestDetails(proto.Message):
    r"""Additional details about the progress of the running test.

    Attributes:
        progress_messages (Sequence[str]):
            Output only. Human-readable, detailed descriptions of the
            test's progress. For example: "Provisioning a device",
            "Starting Test".

            During the course of execution new data may be appended to
            the end of progress_messages.
        error_message (str):
            Output only. If the TestState is ERROR, then
            this string will contain human-readable details
            about the error.
    """

    progress_messages = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    error_message = proto.Field(
        proto.STRING,
        number=4,
    )


class InvalidRequestDetail(proto.Message):
    r"""Details behind an invalid request.

    Attributes:
        reason (google.devtools.testing_v1.types.InvalidRequestDetail.Reason):
            The reason behind the error.
    """
    class Reason(proto.Enum):
        r"""Possible invalid request reasons."""
        REASON_UNSPECIFIED = 0
        REQUEST_INVALID = 1
        RESOURCE_TOO_BIG = 2
        RESOURCE_NOT_FOUND = 3
        UNSUPPORTED = 4
        NOT_IMPLEMENTED = 5

    reason = proto.Field(
        proto.ENUM,
        number=1,
        enum=Reason,
    )


class ShardingOption(proto.Message):
    r"""Options for enabling sharding.

    Attributes:
        uniform_sharding (google.devtools.testing_v1.types.UniformSharding):
            Uniformly shards test cases given a total
            number of shards.
        manual_sharding (google.devtools.testing_v1.types.ManualSharding):
            Shards test cases into the specified groups
            of packages, classes, and/or methods.
    """

    uniform_sharding = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='option',
        message='UniformSharding',
    )
    manual_sharding = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='option',
        message='ManualSharding',
    )


class UniformSharding(proto.Message):
    r"""Uniformly shards test cases given a total number of shards.

    For Instrumentation test, it will be translated to "-e numShard" "-e
    shardIndex" AndroidJUnitRunner arguments. With uniform sharding
    enabled, specifying these sharding arguments via
    environment_variables is invalid.

    Attributes:
        num_shards (int):
            Required. Total number of shards. When any
            physical devices are selected, the number must
            be >= 1 and <= 50. When no physical devices are
            selected, the number must be >= 1 and <= 500.
    """

    num_shards = proto.Field(
        proto.INT32,
        number=1,
    )


class ManualSharding(proto.Message):
    r"""Shards test cases into the specified groups of packages, classes,
    and/or methods.

    With manual sharding enabled, specifying test targets via
    environment_variables or in InstrumentationTest is invalid.

    Attributes:
        test_targets_for_shard (Sequence[google.devtools.testing_v1.types.TestTargetsForShard]):
            Required. Group of packages, classes, and/or test methods to
            be run for each shard. When any physical devices are
            selected, the number of test_targets_for_shard must be >= 1
            and <= 50. When no physical devices are selected, the number
            must be >= 1 and <= 500.
    """

    test_targets_for_shard = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='TestTargetsForShard',
    )


class TestTargetsForShard(proto.Message):
    r"""Test targets for a shard.

    Attributes:
        test_targets (Sequence[str]):
            Group of packages, classes, and/or test methods to be run
            for each shard. The targets need to be specified in
            AndroidJUnitRunner argument format. For example, "package
            com.my.packages" "class com.my.package.MyClass".

            The number of shard_test_targets must be greater than 0.
    """

    test_targets = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


class Shard(proto.Message):
    r"""Output only. Details about the shard.

    Attributes:
        shard_index (int):
            Output only. The index of the shard among all
            the shards.
        num_shards (int):
            Output only. The total number of shards.
        test_targets_for_shard (google.devtools.testing_v1.types.TestTargetsForShard):
            Output only. Test targets for each shard.
    """

    shard_index = proto.Field(
        proto.INT32,
        number=1,
    )
    num_shards = proto.Field(
        proto.INT32,
        number=2,
    )
    test_targets_for_shard = proto.Field(
        proto.MESSAGE,
        number=3,
        message='TestTargetsForShard',
    )


class CreateTestMatrixRequest(proto.Message):
    r"""Request to submit a matrix of tests for execution.

    Attributes:
        project_id (str):
            The GCE project under which this job will
            run.
        test_matrix (google.devtools.testing_v1.types.TestMatrix):
            The matrix of tests that the user wants to
            run.
        request_id (str):
            A string id used to detect duplicated
            requests. Ids are automatically scoped to a
            project, so users should ensure the ID is unique
            per-project. A UUID is recommended.

            Optional, but strongly recommended.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    test_matrix = proto.Field(
        proto.MESSAGE,
        number=2,
        message='TestMatrix',
    )
    request_id = proto.Field(
        proto.STRING,
        number=3,
    )


class GetTestMatrixRequest(proto.Message):
    r"""Request to get the Test Matrix with the given id.

    Attributes:
        project_id (str):
            Cloud project that owns the test matrix.
        test_matrix_id (str):
            Unique test matrix id which was assigned by
            the service.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    test_matrix_id = proto.Field(
        proto.STRING,
        number=2,
    )


class CancelTestMatrixRequest(proto.Message):
    r"""Request to stop running all of the tests in the specified
    matrix.

    Attributes:
        project_id (str):
            Cloud project that owns the test.
        test_matrix_id (str):
            Test matrix that will be canceled.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    test_matrix_id = proto.Field(
        proto.STRING,
        number=2,
    )


class CancelTestMatrixResponse(proto.Message):
    r"""Response containing the current state of the specified test
    matrix.

    Attributes:
        test_state (google.devtools.testing_v1.types.TestState):
            The current rolled-up state of the test
            matrix. If this state is already final, then the
            cancelation request will have no effect.
    """

    test_state = proto.Field(
        proto.ENUM,
        number=1,
        enum='TestState',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
