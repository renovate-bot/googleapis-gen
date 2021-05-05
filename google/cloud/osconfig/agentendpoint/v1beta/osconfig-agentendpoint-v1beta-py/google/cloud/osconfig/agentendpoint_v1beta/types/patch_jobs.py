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
    package='google.cloud.osconfig.agentendpoint.v1beta',
    manifest={
        'PatchConfig',
        'AptSettings',
        'YumSettings',
        'GooSettings',
        'ZypperSettings',
        'WindowsUpdateSettings',
        'RetryStrategy',
        'ExecStep',
        'ExecStepConfig',
        'GcsObject',
    },
)


class PatchConfig(proto.Message):
    r"""Patch configuration specifications. Contains details on how
    to apply patches to a VM instance.

    Attributes:
        reboot_config (google.cloud.osconfig.agentendpoint_v1beta.types.PatchConfig.RebootConfig):
            Post-patch reboot settings.
        retry_strategy (google.cloud.osconfig.agentendpoint_v1beta.types.RetryStrategy):
            Retry strategy can be defined to have the
            agent retry patching during the window if
            patching fails. If omitted, the agent will use
            its default retry strategy.
        apt (google.cloud.osconfig.agentendpoint_v1beta.types.AptSettings):
            Apt update settings. Use this override the
            default apt patch rules.
        yum (google.cloud.osconfig.agentendpoint_v1beta.types.YumSettings):
            Yum update settings. Use this override the
            default yum patch rules.
        goo (google.cloud.osconfig.agentendpoint_v1beta.types.GooSettings):
            Goo update settings. Use this override the
            default goo patch rules.
        zypper (google.cloud.osconfig.agentendpoint_v1beta.types.ZypperSettings):
            Zypper update settings. Use this override the
            default zypper patch rules.
        windows_update (google.cloud.osconfig.agentendpoint_v1beta.types.WindowsUpdateSettings):
            Windows update settings. Use this override
            the default windows patch rules.
        pre_step (google.cloud.osconfig.agentendpoint_v1beta.types.ExecStep):
            The ExecStep to run before the patch update.
        post_step (google.cloud.osconfig.agentendpoint_v1beta.types.ExecStep):
            The ExecStep to run after the patch update.
    """
    class RebootConfig(proto.Enum):
        r"""Post-patch reboot settings."""
        REBOOT_CONFIG_UNSPECIFIED = 0
        DEFAULT = 1
        ALWAYS = 2
        NEVER = 3

    reboot_config = proto.Field(
        proto.ENUM,
        number=1,
        enum=RebootConfig,
    )
    retry_strategy = proto.Field(
        proto.MESSAGE,
        number=2,
        message='RetryStrategy',
    )
    apt = proto.Field(
        proto.MESSAGE,
        number=3,
        message='AptSettings',
    )
    yum = proto.Field(
        proto.MESSAGE,
        number=4,
        message='YumSettings',
    )
    goo = proto.Field(
        proto.MESSAGE,
        number=5,
        message='GooSettings',
    )
    zypper = proto.Field(
        proto.MESSAGE,
        number=6,
        message='ZypperSettings',
    )
    windows_update = proto.Field(
        proto.MESSAGE,
        number=7,
        message='WindowsUpdateSettings',
    )
    pre_step = proto.Field(
        proto.MESSAGE,
        number=8,
        message='ExecStep',
    )
    post_step = proto.Field(
        proto.MESSAGE,
        number=9,
        message='ExecStep',
    )


class AptSettings(proto.Message):
    r"""Apt patching will be performed by executing
    ``apt-get update && apt-get upgrade``. Additional options can be set
    to control how this is executed.

    Attributes:
        type_ (google.cloud.osconfig.agentendpoint_v1beta.types.AptSettings.Type):
            By changing the type to DIST, the patching will be performed
            using ``apt-get dist-upgrade`` instead.
        excludes (Sequence[str]):
            List of packages to exclude from update.
        exclusive_packages (Sequence[str]):
            An exclusive list of packages to be updated.
            These are the only packages that will be
            updated. If these packages are not installed,
            they will be ignored. This field cannot be
            specified with any other patch configuration
            fields.
    """
    class Type(proto.Enum):
        r"""Apt patch type."""
        TYPE_UNSPECIFIED = 0
        DIST = 1
        UPGRADE = 2

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )
    excludes = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    exclusive_packages = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class YumSettings(proto.Message):
    r"""Yum patching will be performed by executing ``yum update``.
    Additional options can be set to control how this is executed.

    Note that not all settings are supported on all platforms.

    Attributes:
        security (bool):
            Adds the ``--security`` flag to ``yum update``. Not
            supported on all platforms.
        minimal (bool):
            Will cause patch to run ``yum update-minimal`` instead.
        excludes (Sequence[str]):
            List of packages to exclude from update. These packages will
            be excluded by using the yum ``--exclude`` flag.
        exclusive_packages (Sequence[str]):
            An exclusive list of packages to be updated.
            These are the only packages that will be
            updated. If these packages are not installed,
            they will be ignored. This field must not be
            specified with any other patch configuration
            fields.
    """

    security = proto.Field(
        proto.BOOL,
        number=1,
    )
    minimal = proto.Field(
        proto.BOOL,
        number=2,
    )
    excludes = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    exclusive_packages = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class GooSettings(proto.Message):
    r"""Googet patching is performed by running ``googet update``.    """


class ZypperSettings(proto.Message):
    r"""Zypper patching is performed by running ``zypper patch``. See also
    https://en.opensuse.org/SDB:Zypper_manual.

    Attributes:
        with_optional (bool):
            Adds the ``--with-optional`` flag to ``zypper patch``.
        with_update (bool):
            Adds the ``--with-update`` flag, to ``zypper patch``.
        categories (Sequence[str]):
            Install only patches with these categories.
            Common categories include security, recommended,
            and feature.
        severities (Sequence[str]):
            Install only patches with these severities.
            Common severities include critical, important,
            moderate, and low.
        excludes (Sequence[str]):
            List of patches to exclude from update.
        exclusive_patches (Sequence[str]):
            An exclusive list of patches to be updated. These are the
            only patches that will be installed using 'zypper patch
            patch:<patch_name>' command. This field must not be used
            with any other patch configuration fields.
    """

    with_optional = proto.Field(
        proto.BOOL,
        number=1,
    )
    with_update = proto.Field(
        proto.BOOL,
        number=2,
    )
    categories = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    severities = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    excludes = proto.RepeatedField(
        proto.STRING,
        number=5,
    )
    exclusive_patches = proto.RepeatedField(
        proto.STRING,
        number=6,
    )


class WindowsUpdateSettings(proto.Message):
    r"""Windows patching is performed using the Windows Update Agent.
    Attributes:
        classifications (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.WindowsUpdateSettings.Classification]):
            Only apply updates of these windows update
            classifications. If empty, all updates will be
            applied.
        excludes (Sequence[str]):
            List of KBs to exclude from update.
        exclusive_patches (Sequence[str]):
            An exclusive list of kbs to be updated. These
            are the only patches that will be updated. This
            field must not be used with other patch
            configurations.
    """
    class Classification(proto.Enum):
        r"""Microsoft Windows update classifications as defined in [1]
        https://support.microsoft.com/en-us/help/824684/description-of-the-standard-terminology-that-is-used-to-describe-micro
        """
        CLASSIFICATION_UNSPECIFIED = 0
        CRITICAL = 1
        SECURITY = 2
        DEFINITION = 3
        DRIVER = 4
        FEATURE_PACK = 5
        SERVICE_PACK = 6
        TOOL = 7
        UPDATE_ROLLUP = 8
        UPDATE = 9

    classifications = proto.RepeatedField(
        proto.ENUM,
        number=1,
        enum=Classification,
    )
    excludes = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    exclusive_patches = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class RetryStrategy(proto.Message):
    r"""The strategy for retrying failed patches during the patch
    window.

    Attributes:
        enabled (bool):
            If true, the agent will continue to try and
            patch until the window has ended.
    """

    enabled = proto.Field(
        proto.BOOL,
        number=1,
    )


class ExecStep(proto.Message):
    r"""A step that runs an executable for a PatchJob.
    Attributes:
        linux_exec_step_config (google.cloud.osconfig.agentendpoint_v1beta.types.ExecStepConfig):
            The ExecStepConfig for all Linux VMs targeted
            by the PatchJob.
        windows_exec_step_config (google.cloud.osconfig.agentendpoint_v1beta.types.ExecStepConfig):
            The ExecStepConfig for all Windows VMs
            targeted by the PatchJob.
    """

    linux_exec_step_config = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ExecStepConfig',
    )
    windows_exec_step_config = proto.Field(
        proto.MESSAGE,
        number=2,
        message='ExecStepConfig',
    )


class ExecStepConfig(proto.Message):
    r"""Common configurations for an ExecStep.
    Attributes:
        local_path (str):
            An absolute path to the executable on the VM.
        gcs_object (google.cloud.osconfig.agentendpoint_v1beta.types.GcsObject):
            A GCS object containing the executable.
        allowed_success_codes (Sequence[int]):
            Defaults to [0]. A list of possible return values that the
            execution can return to indicate a success.
        interpreter (google.cloud.osconfig.agentendpoint_v1beta.types.ExecStepConfig.Interpreter):
            The script interpreter to use to run the script. If no
            interpreter is specified the script will be executed
            directly, which will likely only succeed for scripts with
            shebang lines. `Wikipedia
            shebang <https://en.wikipedia.org/wiki/Shebang_(Unix)>`__.
    """
    class Interpreter(proto.Enum):
        r"""The interpreter used to execute the a file."""
        INTERPRETER_UNSPECIFIED = 0
        SHELL = 1
        POWERSHELL = 2

    local_path = proto.Field(
        proto.STRING,
        number=1,
        oneof='executable',
    )
    gcs_object = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='executable',
        message='GcsObject',
    )
    allowed_success_codes = proto.RepeatedField(
        proto.INT32,
        number=3,
    )
    interpreter = proto.Field(
        proto.ENUM,
        number=4,
        enum=Interpreter,
    )


class GcsObject(proto.Message):
    r"""GCS object representation.
    Attributes:
        bucket (str):
            Bucket of the GCS object.
        object_ (str):
            Name of the GCS object.
        generation_number (int):
            Generation number of the GCS object. This is
            used to ensure that the ExecStep specified by
            this PatchJob does not change.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation_number = proto.Field(
        proto.INT64,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
