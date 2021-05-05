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
        'DesiredState',
        'Package',
        'AptRepository',
        'YumRepository',
        'ZypperRepository',
        'GooRepository',
        'PackageRepository',
        'SoftwareRecipe',
        'LookupEffectiveGuestPolicyRequest',
        'EffectiveGuestPolicy',
    },
)


class DesiredState(proto.Enum):
    r"""The desired state that the OS Config agent will maintain on
    the VM.
    """
    DESIRED_STATE_UNSPECIFIED = 0
    INSTALLED = 1
    UPDATED = 2
    REMOVED = 3


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
            The name of the package. A package is
            uniquely identified for conflict validation by
            checking the package name and the manager(s)
            that the package targets.
        desired_state (google.cloud.osconfig.agentendpoint_v1beta.types.DesiredState):
            The desired_state the agent should maintain for this
            package. The default is to ensure the package is installed.
        manager (google.cloud.osconfig.agentendpoint_v1beta.types.Package.Manager):
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
        archive_type (google.cloud.osconfig.agentendpoint_v1beta.types.AptRepository.ArchiveType):
            Type of archive files in this repository. The
            default behavior is DEB.
        uri (str):
            URI for this repository.
        distribution (str):
            Distribution of this repository.
        components (Sequence[str]):
            List of components for this repository. Must
            contain at least one item.
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
            A one word, unique name for this repository. This is the
            ``repo id`` in the Yum config file and also the
            ``display_name`` if ``display_name`` is omitted. This id is
            also used as the unique identifier when checking for guest
            policy conflicts.
        display_name (str):
            The display name of the repository.
        base_url (str):
            The location of the repository directory.
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
            A one word, unique name for this repository. This is the
            ``repo id`` in the zypper config file and also the
            ``display_name`` if ``display_name`` is omitted. This id is
            also used as the unique identifier when checking for guest
            policy conflicts.
        display_name (str):
            The display name of the repository.
        base_url (str):
            The location of the repository directory.
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
            The name of the repository.
        url (str):
            The url of the repository.
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
        apt (google.cloud.osconfig.agentendpoint_v1beta.types.AptRepository):
            An Apt Repository.
        yum (google.cloud.osconfig.agentendpoint_v1beta.types.YumRepository):
            A Yum Repository.
        zypper (google.cloud.osconfig.agentendpoint_v1beta.types.ZypperRepository):
            A Zypper Repository.
        goo (google.cloud.osconfig.agentendpoint_v1beta.types.GooRepository):
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
            Unique identifier for the recipe. Only one
            recipe with a given name is installed on an
            instance.
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
        artifacts (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Artifact]):
            Resources available to be used in the steps
            in the recipe.
        install_steps (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step]):
            Actions to be taken for installing this
            recipe. On failure it stops executing steps and
            does not attempt another installation. Any steps
            taken (including partially completed steps) are
            not rolled back.  Install steps must be
            specified and are used on first installation.
        update_steps (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step]):
            Actions to be taken for updating this recipe.
            On failure it stops executing steps and  does
            not attempt another update for this recipe. Any
            steps taken (including partially completed
            steps) are not rolled back. Upgrade steps are
            not mandatory and are only used when upgrading.
        desired_state (google.cloud.osconfig.agentendpoint_v1beta.types.DesiredState):
            Default is INSTALLED. The desired state the
            agent should maintain for this recipe.

            INSTALLED: The software recipe is installed on
            the instance but won't be
            updated to new versions. UPDATED: The software
            recipe is installed on the instance. The recipe
            is                         updated to a higher
            version, if a higher version of
            the recipe is assigned to this instance. REMOVE:
            Remove is unsupported for software recipes and
            attempts to         create or update a recipe to
            the REMOVE state is rejected.
    """

    class Artifact(proto.Message):
        r"""Specifies a resource to be used in the recipe.
        Attributes:
            id (str):
                Id of the artifact, which the installation
                and update steps of this recipe can reference.
                Artifacts in a recipe cannot have the same id.
            remote (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Artifact.Remote):
                A generic remote artifact.
            gcs (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Artifact.Gcs):
                A Cloud Storage artifact.
            allow_insecure (bool):
                Defaults to false. When false, recipes are
                subject to validations based on the artifact
                type:
                Remote: A checksum must be specified, and only
                protocols with         transport-layer security
                are permitted. GCS:    An object generation
                number must be specified.
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
            r"""Specifies an artifact available as a Cloud Storage object.
            Attributes:
                bucket (str):
                    Bucket of the Cloud Storage object. Given an example URL:
                    ``https://storage.googleapis.com/my-bucket/foo/bar#1234567``
                    this value would be ``my-bucket``.
                object_ (str):
                    Name of the Cloud Storage object. As specified [here]
                    (https://cloud.google.com/storage/docs/naming#objectnames)
                    Given an example URL:
                    ``https://storage.googleapis.com/my-bucket/foo/bar#1234567``
                    this value would be ``foo/bar``.
                generation (int):
                    Must be provided if allow_insecure is false. Generation
                    number of the Cloud Storage object.
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
            file_copy (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.CopyFile):
                Copies a file onto the instance.
            archive_extraction (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.ExtractArchive):
                Extracts an archive into the specified
                directory.
            msi_installation (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.InstallMsi):
                Installs an MSI file.
            dpkg_installation (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.InstallDpkg):
                Installs a deb file via dpkg.
            rpm_installation (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.InstallRpm):
                Installs an rpm file via the rpm utility.
            file_exec (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.ExecFile):
                Executes an artifact or local file.
            script_run (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.RunScript):
                Runs commands in a shell.
        """

        class CopyFile(proto.Message):
            r"""Copies the artifact to the specified path on the instance.
            Attributes:
                artifact_id (str):
                    The id of the relevant artifact in the
                    recipe.
                destination (str):
                    The absolute path on the instance to put the
                    file.
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
                    The id of the relevant artifact in the
                    recipe.
                destination (str):
                    Directory to extract archive to. Defaults to ``/`` on Linux
                    or ``C:\`` on Windows.
                type_ (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.ExtractArchive.ArchiveType):
                    The type of the archive to extract.
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
                    The id of the relevant artifact in the
                    recipe.
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
                    The id of the relevant artifact in the
                    recipe.
            """

            artifact_id = proto.Field(
                proto.STRING,
                number=1,
            )

        class InstallRpm(proto.Message):
            r"""Installs an rpm file via the rpm utility.
            Attributes:
                artifact_id (str):
                    The id of the relevant artifact in the
                    recipe.
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
                    The shell script to be executed.
                allowed_exit_codes (Sequence[int]):
                    Return codes that indicate that the software installed or
                    updated successfully. Behaviour defaults to [0]
                interpreter (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe.Step.RunScript.Interpreter):
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


class LookupEffectiveGuestPolicyRequest(proto.Message):
    r"""A request message for getting effective policy assigned to
    the instance.

    Attributes:
        instance_id_token (str):
            Required. This is the GCE instance identity
            token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        os_short_name (str):
            Short name of the OS running on the instance.
            The OS Config agent only provideS this field for
            targeting if OS Inventory is enabled for that
            instance.
        os_version (str):
            Version of the OS running on the instance.
            The OS Config agent only provide this field for
            targeting if OS Inventory is enabled for that VM
            instance.
        os_architecture (str):
            Architecture of OS running on the instance.
            The OS Config agent only provide this field for
            targeting if OS Inventory is enabled for that
            instance.
    """

    instance_id_token = proto.Field(
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
    r"""The effective guest policy assigned to the instance.
    Attributes:
        packages (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.EffectiveGuestPolicy.SourcedPackage]):
            List of package configurations assigned to
            the VM instance.
        package_repositories (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.EffectiveGuestPolicy.SourcedPackageRepository]):
            List of package repository configurations
            assigned to the VM instance.
        software_recipes (Sequence[google.cloud.osconfig.agentendpoint_v1beta.types.EffectiveGuestPolicy.SourcedSoftwareRecipe]):
            List of recipes assigned to the VM instance.
    """

    class SourcedPackage(proto.Message):
        r"""A guest policy package including its source.
        Attributes:
            source (str):
                Name of the guest policy providing this
                config.
            package (google.cloud.osconfig.agentendpoint_v1beta.types.Package):
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
            package_repository (google.cloud.osconfig.agentendpoint_v1beta.types.PackageRepository):
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
            software_recipe (google.cloud.osconfig.agentendpoint_v1beta.types.SoftwareRecipe):
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
