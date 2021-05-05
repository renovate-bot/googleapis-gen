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

from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.osconfig.v1beta',
    manifest={
        'DesiredState',
        'GuestPolicy',
        'Assignment',
        'Package',
        'AptRepository',
        'YumRepository',
        'ZypperRepository',
        'GooRepository',
        'PackageRepository',
        'SoftwareRecipe',
        'CreateGuestPolicyRequest',
        'GetGuestPolicyRequest',
        'ListGuestPoliciesRequest',
        'ListGuestPoliciesResponse',
        'UpdateGuestPolicyRequest',
        'DeleteGuestPolicyRequest',
        'LookupEffectiveGuestPolicyRequest',
        'EffectiveGuestPolicy',
    },
)


class DesiredState(proto.Enum):
    r"""The desired state that the OS Config agent maintains on the
    VM instance.
    """
    DESIRED_STATE_UNSPECIFIED = 0
    INSTALLED = 1
    UPDATED = 2
    REMOVED = 3


class GuestPolicy(proto.Message):
    r"""An OS Config resource representing a guest configuration
    policy. These policies represent the desired state for VM
    instance guest environments including packages to install or
    remove, package repository configurations, and software to
    install.

    Attributes:
        name (str):
            Required. Unique name of the resource in this project using
            one of the following forms:
            ``projects/{project_number}/guestPolicies/{guest_policy_id}``.
        description (str):
            Description of the guest policy. Length of
            the description is limited to 1024 characters.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Time this guest policy was
            created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Last time this guest policy was
            updated.
        assignment (google.cloud.osconfig_v1beta.types.Assignment):
            Required. Specifies the VM instances that are assigned to
            this policy. This allows you to target sets or groups of VM
            instances by different parameters such as labels, names, OS,
            or zones.

            If left empty, all VM instances underneath this policy are
            targeted.

            At the same level in the resource hierarchy (that is within
            a project), the service prevents the creation of multiple
            policies that conflict with each other. For more
            information, see how the service `handles assignment
            conflicts </compute/docs/os-config-management/create-guest-policy#handle-conflicts>`__.
        packages (Sequence[google.cloud.osconfig_v1beta.types.Package]):
            The software packages to be managed by this
            policy.
        package_repositories (Sequence[google.cloud.osconfig_v1beta.types.PackageRepository]):
            A list of package repositories to configure
            on the VM instance. This is done before any
            other configs are applied so they can use these
            repos. Package repositories are only configured
            if the corresponding package manager(s) are
            available.
        recipes (Sequence[google.cloud.osconfig_v1beta.types.SoftwareRecipe]):
            A list of Recipes to install on the VM
            instance.
        etag (str):
            The etag for this guest policy.
            If this is provided on update, it must match the
            server's etag.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    description = proto.Field(
        proto.STRING,
        number=2,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    assignment = proto.Field(
        proto.MESSAGE,
        number=6,
        message='Assignment',
    )
    packages = proto.RepeatedField(
        proto.MESSAGE,
        number=7,
        message='Package',
    )
    package_repositories = proto.RepeatedField(
        proto.MESSAGE,
        number=8,
        message='PackageRepository',
    )
    recipes = proto.RepeatedField(
        proto.MESSAGE,
        number=9,
        message='SoftwareRecipe',
    )
    etag = proto.Field(
        proto.STRING,
        number=10,
    )


class Assignment(proto.Message):
    r"""An assignment represents the group or groups of VM instances
    that the policy applies to.

    If an assignment is empty, it applies to all VM instances.
    Otherwise, the targeted VM instances must meet all the criteria
    specified. So if both labels and zones are specified, the policy
    applies to VM instances with those labels and in those zones.

    Attributes:
        group_labels (Sequence[google.cloud.osconfig_v1beta.types.Assignment.GroupLabel]):
            Targets instances matching at least one of
            these label sets. This allows an assignment to
            target disparate groups, for example "env=prod
            or env=staging".
        zones (Sequence[str]):
            Targets instances in any of these zones.
            Leave empty to target instances in any zone.

            Zonal targeting is uncommon and is supported to
            facilitate the management of changes by zone.
        instances (Sequence[str]):
            Targets any of the instances specified. Instances are
            specified by their URI in the form
            ``zones/[ZONE]/instances/[INSTANCE_NAME]``.

            Instance targeting is uncommon and is supported to
            facilitate the management of changes by the instance or to
            target specific VM instances for development and testing.

            Only supported for project-level policies and must reference
            instances within this project.
        instance_name_prefixes (Sequence[str]):
            Targets VM instances whose name starts with
            one of these prefixes.
            Like labels, this is another way to group VM
            instances when targeting configs, for example
            prefix="prod-".

            Only supported for project-level policies.
        os_types (Sequence[google.cloud.osconfig_v1beta.types.Assignment.OsType]):
            Targets VM instances matching at least one of
            the following OS types.
            VM instances must match all supplied criteria
            for a given OsType to be included.
    """

    class GroupLabel(proto.Message):
        r"""Represents a group of VM intances that can be identified as
        having all these labels, for example "env=prod and app=web".

        Attributes:
            labels (Sequence[google.cloud.osconfig_v1beta.types.Assignment.GroupLabel.LabelsEntry]):
                Google Compute Engine instance labels that
                must be present for an instance to be included
                in this assignment group.
        """

        labels = proto.MapField(
            proto.STRING,
            proto.STRING,
            number=1,
        )

    class OsType(proto.Message):
        r"""Defines the criteria for selecting VM Instances by OS type.
        Attributes:
            os_short_name (str):
                Targets VM instances with OS Inventory
                enabled and having the following OS short name,
                for example "debian" or "windows".
            os_version (str):
                Targets VM instances with OS Inventory
                enabled and having the following following OS
                version.
            os_architecture (str):
                Targets VM instances with OS Inventory
                enabled and having the following OS
                architecture.
        """

        os_short_name = proto.Field(
            proto.STRING,
            number=1,
        )
        os_version = proto.Field(
            proto.STRING,
            number=2,
        )
        os_architecture = proto.Field(
            proto.STRING,
            number=3,
        )

    group_labels = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=GroupLabel,
    )
    zones = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    instances = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    instance_name_prefixes = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    os_types = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message=OsType,
    )


class Package(proto.Message):
    r"""Package is a reference to the software package to be installed or
    removed. The agent on the VM instance uses the system package
    manager to apply the config.

    These are the commands that the agent uses to install or remove
    packages.

    Apt install:
    ``apt-get update && apt-get -y install package1 package2 package3``
    remove: ``apt-get -y remove package1 package2 package3``

    Yum install: ``yum -y install package1 package2 package3`` remove:
    ``yum -y remove package1 package2 package3``

    Zypper install: ``zypper install package1 package2 package3``
    remove: ``zypper rm package1 package2``

    Googet install:
    ``googet -noconfirm install package1 package2 package3`` remove:
    ``googet -noconfirm remove package1 package2 package3``

    Attributes:
        name (str):
            Required. The name of the package. A package
            is uniquely identified for conflict validation
            by checking the package name and the manager(s)
            that the package targets.
        desired_state (google.cloud.osconfig_v1beta.types.DesiredState):
            The desired_state the agent should maintain for this
            package. The default is to ensure the package is installed.
        manager (google.cloud.osconfig_v1beta.types.Package.Manager):
            Type of package manager that can be used to install this
            package. If a system does not have the package manager, the
            package is not installed or removed no error message is
            returned. By default, or if you specify ``ANY``, the agent
            attempts to install and remove this package using the
            default package manager. This is useful when creating a
            policy that applies to different types of systems.

            The default behavior is ANY.
    """
    class Manager(proto.Enum):
        r"""Types of package managers that may be used to manage this
        package.
        """
        MANAGER_UNSPECIFIED = 0
        ANY = 1
        APT = 2
        YUM = 3
        ZYPPER = 4
        GOO = 5

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    desired_state = proto.Field(
        proto.ENUM,
        number=2,
        enum='DesiredState',
    )
    manager = proto.Field(
        proto.ENUM,
        number=3,
        enum=Manager,
    )


class AptRepository(proto.Message):
    r"""Represents a single Apt package repository. This repository is added
    to a repo file that is stored at
    ``/etc/apt/sources.list.d/google_osconfig.list``.

    Attributes:
        archive_type (google.cloud.osconfig_v1beta.types.AptRepository.ArchiveType):
            Type of archive files in this repository. The
            default behavior is DEB.
        uri (str):
            Required. URI for this repository.
        distribution (str):
            Required. Distribution of this repository.
        components (Sequence[str]):
            Required. List of components for this
            repository. Must contain at least one item.
        gpg_key (str):
            URI of the key file for this repository. The agent maintains
            a keyring at
            ``/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg``
            containing all the keys in any applied guest policy.
    """
    class ArchiveType(proto.Enum):
        r"""Type of archive."""
        ARCHIVE_TYPE_UNSPECIFIED = 0
        DEB = 1
        DEB_SRC = 2

    archive_type = proto.Field(
        proto.ENUM,
        number=1,
        enum=ArchiveType,
    )
    uri = proto.Field(
        proto.STRING,
        number=2,
    )
    distribution = proto.Field(
        proto.STRING,
        number=3,
    )
    components = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    gpg_key = proto.Field(
        proto.STRING,
        number=5,
    )


class YumRepository(proto.Message):
    r"""Represents a single Yum package repository. This repository is added
    to a repo file that is stored at
    ``/etc/yum.repos.d/google_osconfig.repo``.

    Attributes:
        id (str):
            Required. A one word, unique name for this repository. This
            is the ``repo id`` in the Yum config file and also the
            ``display_name`` if ``display_name`` is omitted. This id is
            also used as the unique identifier when checking for guest
            policy conflicts.
        display_name (str):
            The display name of the repository.
        base_url (str):
            Required. The location of the repository
            directory.
        gpg_keys (Sequence[str]):
            URIs of GPG keys.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )
    base_url = proto.Field(
        proto.STRING,
        number=3,
    )
    gpg_keys = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class ZypperRepository(proto.Message):
    r"""Represents a single Zypper package repository. This repository is
    added to a repo file that is stored at
    ``/etc/zypp/repos.d/google_osconfig.repo``.

    Attributes:
        id (str):
            Required. A one word, unique name for this repository. This
            is the ``repo id`` in the zypper config file and also the
            ``display_name`` if ``display_name`` is omitted. This id is
            also used as the unique identifier when checking for guest
            policy conflicts.
        display_name (str):
            The display name of the repository.
        base_url (str):
            Required. The location of the repository
            directory.
        gpg_keys (Sequence[str]):
            URIs of GPG keys.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )
    base_url = proto.Field(
        proto.STRING,
        number=3,
    )
    gpg_keys = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


class GooRepository(proto.Message):
    r"""Represents a Goo package repository. These is added to a repo file
    that is stored at C:/ProgramData/GooGet/repos/google_osconfig.repo.

    Attributes:
        name (str):
            Required. The name of the repository.
        url (str):
            Required. The url of the repository.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    url = proto.Field(
        proto.STRING,
        number=2,
    )


class PackageRepository(proto.Message):
    r"""A package repository.
    Attributes:
        apt (google.cloud.osconfig_v1beta.types.AptRepository):
            An Apt Repository.
        yum (google.cloud.osconfig_v1beta.types.YumRepository):
            A Yum Repository.
        zypper (google.cloud.osconfig_v1beta.types.ZypperRepository):
            A Zypper Repository.
        goo (google.cloud.osconfig_v1beta.types.GooRepository):
            A Goo Repository.
    """

    apt = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='repository',
        message='AptRepository',
    )
    yum = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='repository',
        message='YumRepository',
    )
    zypper = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='repository',
        message='ZypperRepository',
    )
    goo = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='repository',
        message='GooRepository',
    )


class SoftwareRecipe(proto.Message):
    r"""A software recipe is a set of instructions for installing and
    configuring a piece of software. It consists of a set of artifacts
    that are downloaded, and a set of steps that install, configure,
    and/or update the software.

    Recipes support installing and updating software from artifacts in
    the following formats: Zip archive, Tar archive, Windows MSI, Debian
    package, and RPM package.

    Additionally, recipes support executing a script (either defined in
    a file or directly in this api) in bash, sh, cmd, and powershell.

    Updating a software recipe

    If a recipe is assigned to an instance and there is a recipe with
    the same name but a lower version already installed and the assigned
    state of the recipe is ``INSTALLED_KEEP_UPDATED``, then the recipe
    is updated to the new version.

    Script Working Directories

    Each script or execution step is run in its own temporary directory
    which is deleted after completing the step.

    Attributes:
        name (str):
            Required. Unique identifier for the recipe.
            Only one recipe with a given name is installed
            on an instance.
            Names are also used to identify resources which
            helps to determine whether guest policies have
            conflicts. This means that requests to create
            multiple recipes with the same name and version
            are rejected since they could potentially have
            conflicting assignments.
        version (str):
            The version of this software recipe. Version
            can be up to 4 period separated numbers (e.g.
            12.34.56.78).
        artifacts (Sequence[google.cloud.osconfig_v1beta.types.SoftwareRecipe.Artifact]):
            Resources available to be used in the steps
            in the recipe.
        install_steps (Sequence[google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step]):
            Actions to be taken for installing this
            recipe. On failure it stops executing steps and
            does not attempt another installation. Any steps
            taken (including partially completed steps) are
            not rolled back.
        update_steps (Sequence[google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step]):
            Actions to be taken for updating this recipe.
            On failure it stops executing steps and  does
            not attempt another update for this recipe. Any
            steps taken (including partially completed
            steps) are not rolled back.
        desired_state (google.cloud.osconfig_v1beta.types.DesiredState):
            Default is INSTALLED. The desired state the agent should
            maintain for this recipe.

            INSTALLED: The software recipe is installed on the instance
            but won't be updated to new versions.
            INSTALLED_KEEP_UPDATED: The software recipe is installed on
            the instance. The recipe is updated to a higher version, if
            a higher version of the recipe is assigned to this instance.
            REMOVE: Remove is unsupported for software recipes and
            attempts to create or update a recipe to the REMOVE state is
            rejected.
    """

    class Artifact(proto.Message):
        r"""Specifies a resource to be used in the recipe.
        Attributes:
            id (str):
                Required. Id of the artifact, which the
                installation and update steps of this recipe can
                reference. Artifacts in a recipe cannot have the
                same id.
            remote (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Artifact.Remote):
                A generic remote artifact.
            gcs (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Artifact.Gcs):
                A Google Cloud Storage artifact.
            allow_insecure (bool):
                Defaults to false. When false, recipes are
                subject to validations based on the artifact
                type:
                Remote: A checksum must be specified, and only
                protocols with transport-layer security are
                permitted.
                GCS:    An object generation number must be
                specified.
        """

        class Remote(proto.Message):
            r"""Specifies an artifact available via some URI.
            Attributes:
                uri (str):
                    URI from which to fetch the object. It should
                    contain both the protocol and path following the
                    format {protocol}://{location}.
                checksum (str):
                    Must be provided if ``allow_insecure`` is ``false``. SHA256
                    checksum in hex format, to compare to the checksum of the
                    artifact. If the checksum is not empty and it doesn't match
                    the artifact then the recipe installation fails before
                    running any of the steps.
            """

            uri = proto.Field(
                proto.STRING,
                number=1,
            )
            checksum = proto.Field(
                proto.STRING,
                number=2,
            )

        class Gcs(proto.Message):
            r"""Specifies an artifact available as a Google Cloud Storage
            object.

            Attributes:
                bucket (str):
                    Bucket of the Google Cloud Storage object. Given an example
                    URL:
                    ``https://storage.googleapis.com/my-bucket/foo/bar#1234567``
                    this value would be ``my-bucket``.
                object_ (str):
                    Name of the Google Cloud Storage object. As specified [here]
                    (https://cloud.google.com/storage/docs/naming#objectnames)
                    Given an example URL:
                    ``https://storage.googleapis.com/my-bucket/foo/bar#1234567``
                    this value would be ``foo/bar``.
                generation (int):
                    Must be provided if allow_insecure is false. Generation
                    number of the Google Cloud Storage object.
                    ``https://storage.googleapis.com/my-bucket/foo/bar#1234567``
                    this value would be ``1234567``.
            """

            bucket = proto.Field(
                proto.STRING,
                number=1,
            )
            object_ = proto.Field(
                proto.STRING,
                number=2,
            )
            generation = proto.Field(
                proto.INT64,
                number=3,
            )

        id = proto.Field(
            proto.STRING,
            number=1,
        )
        remote = proto.Field(
            proto.MESSAGE,
            number=2,
            oneof='artifact',
            message='SoftwareRecipe.Artifact.Remote',
        )
        gcs = proto.Field(
            proto.MESSAGE,
            number=3,
            oneof='artifact',
            message='SoftwareRecipe.Artifact.Gcs',
        )
        allow_insecure = proto.Field(
            proto.BOOL,
            number=4,
        )

    class Step(proto.Message):
        r"""An action that can be taken as part of installing or updating
        a recipe.

        Attributes:
            file_copy (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.CopyFile):
                Copies a file onto the instance.
            archive_extraction (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.ExtractArchive):
                Extracts an archive into the specified
                directory.
            msi_installation (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.InstallMsi):
                Installs an MSI file.
            dpkg_installation (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.InstallDpkg):
                Installs a deb file via dpkg.
            rpm_installation (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.InstallRpm):
                Installs an rpm file via the rpm utility.
            file_exec (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.ExecFile):
                Executes an artifact or local file.
            script_run (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.RunScript):
                Runs commands in a shell.
        """

        class CopyFile(proto.Message):
            r"""Copies the artifact to the specified path on the instance.
            Attributes:
                artifact_id (str):
                    Required. The id of the relevant artifact in
                    the recipe.
                destination (str):
                    Required. The absolute path on the instance
                    to put the file.
                overwrite (bool):
                    Whether to allow this step to overwrite
                    existing files. If this is false and the file
                    already exists the file is not overwritten and
                    the step is considered a success. Defaults to
                    false.
                permissions (str):
                    Consists of three octal digits which
                    represent, in order, the permissions of the
                    owner, group, and other users for the file
                    (similarly to the numeric mode used in the linux
                    chmod utility). Each digit represents a three
                    bit number with the 4 bit corresponding to the
                    read permissions, the 2 bit corresponds to the
                    write bit, and the one bit corresponds to the
                    execute permission. Default behavior is 755.

                    Below are some examples of permissions and their
                    associated values: read, write, and execute: 7
                    read and execute: 5
                    read and write: 6
                    read only: 4
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )
            destination = proto.Field(
                proto.STRING,
                number=2,
            )
            overwrite = proto.Field(
                proto.BOOL,
                number=3,
            )
            permissions = proto.Field(
                proto.STRING,
                number=4,
            )

        class ExtractArchive(proto.Message):
            r"""Extracts an archive of the type specified in the specified
            directory.

            Attributes:
                artifact_id (str):
                    Required. The id of the relevant artifact in
                    the recipe.
                destination (str):
                    Directory to extract archive to. Defaults to ``/`` on Linux
                    or ``C:\`` on Windows.
                type_ (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.ExtractArchive.ArchiveType):
                    Required. The type of the archive to extract.
            """
            class ArchiveType(proto.Enum):
                r"""Specifying the type of archive."""
                ARCHIVE_TYPE_UNSPECIFIED = 0
                TAR = 1
                TAR_GZIP = 2
                TAR_BZIP = 3
                TAR_LZMA = 4
                TAR_XZ = 5
                ZIP = 11

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )
            destination = proto.Field(
                proto.STRING,
                number=2,
            )
            type_ = proto.Field(
                proto.ENUM,
                number=3,
                enum='SoftwareRecipe.Step.ExtractArchive.ArchiveType',
            )

        class InstallMsi(proto.Message):
            r"""Installs an MSI file.
            Attributes:
                artifact_id (str):
                    Required. The id of the relevant artifact in
                    the recipe.
                flags (Sequence[str]):
                    The flags to use when installing the MSI defaults to ["/i"]
                    (i.e. the install flag).
                allowed_exit_codes (Sequence[int]):
                    Return codes that indicate that the software installed or
                    updated successfully. Behaviour defaults to [0]
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )
            flags = proto.RepeatedField(
                proto.STRING,
                number=2,
            )
            allowed_exit_codes = proto.RepeatedField(
                proto.INT32,
                number=3,
            )

        class InstallDpkg(proto.Message):
            r"""Installs a deb via dpkg.
            Attributes:
                artifact_id (str):
                    Required. The id of the relevant artifact in
                    the recipe.
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )

        class InstallRpm(proto.Message):
            r"""Installs an rpm file via the rpm utility.
            Attributes:
                artifact_id (str):
                    Required. The id of the relevant artifact in
                    the recipe.
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )

        class ExecFile(proto.Message):
            r"""Executes an artifact or local file.
            Attributes:
                artifact_id (str):
                    The id of the relevant artifact in the
                    recipe.
                local_path (str):
                    The absolute path of the file on the local
                    filesystem.
                args (Sequence[str]):
                    Arguments to be passed to the provided
                    executable.
                allowed_exit_codes (Sequence[int]):
                    Defaults to [0]. A list of possible return values that the
                    program can return to indicate a success.
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
                oneof='location_type',
            )
            local_path = proto.Field(
                proto.STRING,
                number=2,
                oneof='location_type',
            )
            args = proto.RepeatedField(
                proto.STRING,
                number=3,
            )
            allowed_exit_codes = proto.RepeatedField(
                proto.INT32,
                number=4,
            )

        class RunScript(proto.Message):
            r"""Runs a script through an interpreter.
            Attributes:
                script (str):
                    Required. The shell script to be executed.
                allowed_exit_codes (Sequence[int]):
                    Return codes that indicate that the software installed or
                    updated successfully. Behaviour defaults to [0]
                interpreter (google.cloud.osconfig_v1beta.types.SoftwareRecipe.Step.RunScript.Interpreter):
                    The script interpreter to use to run the script. If no
                    interpreter is specified the script is executed directly,
                    which likely only succeed for scripts with `shebang
                    lines <https://en.wikipedia.org/wiki/Shebang_(Unix)>`__.
            """
            class Interpreter(proto.Enum):
                r"""The interpreter used to execute a script."""
                INTERPRETER_UNSPECIFIED = 0
                SHELL = 1
                POWERSHELL = 3

            script = proto.Field(
                proto.STRING,
                number=1,
            )
            allowed_exit_codes = proto.RepeatedField(
                proto.INT32,
                number=2,
            )
            interpreter = proto.Field(
                proto.ENUM,
                number=3,
                enum='SoftwareRecipe.Step.RunScript.Interpreter',
            )

        file_copy = proto.Field(
            proto.MESSAGE,
            number=1,
            oneof='step',
            message='SoftwareRecipe.Step.CopyFile',
        )
        archive_extraction = proto.Field(
            proto.MESSAGE,
            number=2,
            oneof='step',
            message='SoftwareRecipe.Step.ExtractArchive',
        )
        msi_installation = proto.Field(
            proto.MESSAGE,
            number=3,
            oneof='step',
            message='SoftwareRecipe.Step.InstallMsi',
        )
        dpkg_installation = proto.Field(
            proto.MESSAGE,
            number=4,
            oneof='step',
            message='SoftwareRecipe.Step.InstallDpkg',
        )
        rpm_installation = proto.Field(
            proto.MESSAGE,
            number=5,
            oneof='step',
            message='SoftwareRecipe.Step.InstallRpm',
        )
        file_exec = proto.Field(
            proto.MESSAGE,
            number=6,
            oneof='step',
            message='SoftwareRecipe.Step.ExecFile',
        )
        script_run = proto.Field(
            proto.MESSAGE,
            number=7,
            oneof='step',
            message='SoftwareRecipe.Step.RunScript',
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    version = proto.Field(
        proto.STRING,
        number=2,
    )
    artifacts = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=Artifact,
    )
    install_steps = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=Step,
    )
    update_steps = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message=Step,
    )
    desired_state = proto.Field(
        proto.ENUM,
        number=6,
        enum='DesiredState',
    )


class CreateGuestPolicyRequest(proto.Message):
    r"""A request message for creating a guest policy.
    Attributes:
        parent (str):
            Required. The resource name of the parent using one of the
            following forms: ``projects/{project_number}``.
        guest_policy_id (str):
            Required. The logical name of the guest policy in the
            project with the following restrictions:

            -  Must contain only lowercase letters, numbers, and
               hyphens.
            -  Must start with a letter.
            -  Must be between 1-63 characters.
            -  Must end with a number or a letter.
            -  Must be unique within the project.
        guest_policy (google.cloud.osconfig_v1beta.types.GuestPolicy):
            Required. The GuestPolicy to create.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    guest_policy_id = proto.Field(
        proto.STRING,
        number=2,
    )
    guest_policy = proto.Field(
        proto.MESSAGE,
        number=3,
        message='GuestPolicy',
    )


class GetGuestPolicyRequest(proto.Message):
    r"""A request message for retrieving a guest policy.
    Attributes:
        name (str):
            Required. The resource name of the guest policy using one of
            the following forms:
            ``projects/{project_number}/guestPolicies/{guest_policy_id}``.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListGuestPoliciesRequest(proto.Message):
    r"""A request message for listing guest policies.
    Attributes:
        parent (str):
            Required. The resource name of the parent using one of the
            following forms: ``projects/{project_number}``.
        page_size (int):
            The maximum number of guest policies to
            return.
        page_token (str):
            A pagination token returned from a previous call to
            ``ListGuestPolicies`` that indicates where this listing
            should continue from.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ListGuestPoliciesResponse(proto.Message):
    r"""A response message for listing guest policies.
    Attributes:
        guest_policies (Sequence[google.cloud.osconfig_v1beta.types.GuestPolicy]):
            The list of GuestPolicies.
        next_page_token (str):
            A pagination token that can be used to get
            the next page of guest policies.
    """

    @property
    def raw_page(self):
        return self

    guest_policies = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='GuestPolicy',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class UpdateGuestPolicyRequest(proto.Message):
    r"""A request message for updating a guest policy.
    Attributes:
        guest_policy (google.cloud.osconfig_v1beta.types.GuestPolicy):
            Required. The updated GuestPolicy.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Field mask that controls which fields of the
            guest policy should be updated.
    """

    guest_policy = proto.Field(
        proto.MESSAGE,
        number=1,
        message='GuestPolicy',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class DeleteGuestPolicyRequest(proto.Message):
    r"""A request message for deleting a guest policy.
    Attributes:
        name (str):
            Required. The resource name of the guest policy using one of
            the following forms:
            ``projects/{project_number}/guestPolicies/{guest_policy_id}``.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class LookupEffectiveGuestPolicyRequest(proto.Message):
    r"""A request message for getting the effective guest policy
    assigned to the instance.

    Attributes:
        instance (str):
            Required. The VM instance whose policies are
            being looked up.
        os_short_name (str):
            Short name of the OS running on the instance.
            The OS Config agent only provides this field for
            targeting if OS Inventory is enabled for that
            instance.
        os_version (str):
            Version of the OS running on the instance.
            The OS Config agent only provides this field for
            targeting if OS Inventory is enabled for that VM
            instance.
        os_architecture (str):
            Architecture of OS running on the instance.
            The OS Config agent only provides this field for
            targeting if OS Inventory is enabled for that
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    os_short_name = proto.Field(
        proto.STRING,
        number=2,
    )
    os_version = proto.Field(
        proto.STRING,
        number=3,
    )
    os_architecture = proto.Field(
        proto.STRING,
        number=4,
    )


class EffectiveGuestPolicy(proto.Message):
    r"""The effective guest policy that applies to a VM instance.
    Attributes:
        packages (Sequence[google.cloud.osconfig_v1beta.types.EffectiveGuestPolicy.SourcedPackage]):
            List of package configurations assigned to
            the VM instance.
        package_repositories (Sequence[google.cloud.osconfig_v1beta.types.EffectiveGuestPolicy.SourcedPackageRepository]):
            List of package repository configurations
            assigned to the VM instance.
        software_recipes (Sequence[google.cloud.osconfig_v1beta.types.EffectiveGuestPolicy.SourcedSoftwareRecipe]):
            List of recipes assigned to the VM instance.
    """

    class SourcedPackage(proto.Message):
        r"""A guest policy package including its source.
        Attributes:
            source (str):
                Name of the guest policy providing this
                config.
            package (google.cloud.osconfig_v1beta.types.Package):
                A software package to configure on the VM
                instance.
        """

        source = proto.Field(
            proto.STRING,
            number=1,
        )
        package = proto.Field(
            proto.MESSAGE,
            number=2,
            message='Package',
        )

    class SourcedPackageRepository(proto.Message):
        r"""A guest policy package repository including its source.
        Attributes:
            source (str):
                Name of the guest policy providing this
                config.
            package_repository (google.cloud.osconfig_v1beta.types.PackageRepository):
                A software package repository to configure on
                the VM instance.
        """

        source = proto.Field(
            proto.STRING,
            number=1,
        )
        package_repository = proto.Field(
            proto.MESSAGE,
            number=2,
            message='PackageRepository',
        )

    class SourcedSoftwareRecipe(proto.Message):
        r"""A guest policy recipe including its source.
        Attributes:
            source (str):
                Name of the guest policy providing this
                config.
            software_recipe (google.cloud.osconfig_v1beta.types.SoftwareRecipe):
                A software recipe to configure on the VM
                instance.
        """

        source = proto.Field(
            proto.STRING,
            number=1,
        )
        software_recipe = proto.Field(
            proto.MESSAGE,
            number=2,
            message='SoftwareRecipe',
        )

    packages = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=SourcedPackage,
    )
    package_repositories = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=SourcedPackageRepository,
    )
    software_recipes = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=SourcedSoftwareRecipe,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
