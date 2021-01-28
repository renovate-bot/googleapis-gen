# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Cloud
    module Osconfig
      module V1beta
        # An OS Config resource representing a guest configuration policy. These
        # policies represent the desired state for VM instance guest environments
        # including packages to install or remove, package repository configurations,
        # and software to install.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Unique name of the resource in this project using one of the following
        #     forms:
        #     `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        # @!attribute [rw] description
        #   @return [String]
        #     Description of the guest policy. Length of the description is limited
        #     to 1024 characters.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time this guest policy was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Last time this guest policy was updated.
        # @!attribute [rw] assignment
        #   @return [Google::Cloud::Osconfig::V1beta::Assignment]
        #     Required. Specifies the VM instances that are assigned to this policy. This allows
        #     you to target sets or groups of VM instances by different parameters such
        #     as labels, names, OS, or zones.
        #
        #     If left empty, all VM instances underneath this policy are targeted.
        #
        #     At the same level in the resource hierarchy (that is within a project), the
        #     service prevents the creation of multiple policies that conflict with
        #     each other. For more information, see how the service [handles assignment
        #     conflicts](/compute/docs/os-config-management/create-guest-policy#handle-conflicts).
        # @!attribute [rw] packages
        #   @return [Array<Google::Cloud::Osconfig::V1beta::Package>]
        #     The software packages to be managed by this policy.
        # @!attribute [rw] package_repositories
        #   @return [Array<Google::Cloud::Osconfig::V1beta::PackageRepository>]
        #     A list of package repositories to configure on the VM instance. This is
        #     done before any other configs are applied so they can use these repos.
        #     Package repositories are only configured if the corresponding package
        #     manager(s) are available.
        # @!attribute [rw] recipes
        #   @return [Array<Google::Cloud::Osconfig::V1beta::SoftwareRecipe>]
        #     A list of Recipes to install on the VM instance.
        # @!attribute [rw] etag
        #   @return [String]
        #     The etag for this guest policy.
        #     If this is provided on update, it must match the server's etag.
        class GuestPolicy; end

        # An assignment represents the group or groups of VM instances that the policy
        # applies to.
        #
        # If an assignment is empty, it applies to all VM instances. Otherwise, the
        # targeted VM instances must meet all the criteria specified. So if both
        # labels and zones are specified, the policy applies to VM instances with those
        # labels and in those zones.
        # @!attribute [rw] group_labels
        #   @return [Array<Google::Cloud::Osconfig::V1beta::Assignment::GroupLabel>]
        #     Targets instances matching at least one of these label sets. This allows
        #     an assignment to target disparate groups, for example "env=prod or
        #     env=staging".
        # @!attribute [rw] zones
        #   @return [Array<String>]
        #     Targets instances in any of these zones. Leave empty to target instances
        #     in any zone.
        #
        #     Zonal targeting is uncommon and is supported to facilitate the management
        #     of changes by zone.
        # @!attribute [rw] instances
        #   @return [Array<String>]
        #     Targets any of the instances specified. Instances are specified by their
        #     URI in the form `zones/[ZONE]/instances/[INSTANCE_NAME]`.
        #
        #     Instance targeting is uncommon and is supported to facilitate the
        #     management of changes by the instance or to target specific VM instances
        #     for development and testing.
        #
        #     Only supported for project-level policies and must reference instances
        #     within this project.
        # @!attribute [rw] instance_name_prefixes
        #   @return [Array<String>]
        #     Targets VM instances whose name starts with one of these prefixes.
        #
        #     Like labels, this is another way to group VM instances when targeting
        #     configs, for example prefix="prod-".
        #
        #     Only supported for project-level policies.
        # @!attribute [rw] os_types
        #   @return [Array<Google::Cloud::Osconfig::V1beta::Assignment::OsType>]
        #     Targets VM instances matching at least one of the following OS types.
        #
        #     VM instances must match all supplied criteria for a given OsType to be
        #     included.
        class Assignment
          # Represents a group of VM intances that can be identified as having all
          # these labels, for example "env=prod and app=web".
          # @!attribute [rw] labels
          #   @return [Hash{String => String}]
          #     Google Compute Engine instance labels that must be present for an
          #     instance to be included in this assignment group.
          class GroupLabel; end

          # Defines the criteria for selecting VM Instances by OS type.
          # @!attribute [rw] os_short_name
          #   @return [String]
          #     Targets VM instances with OS Inventory enabled and having the following
          #     OS short name, for example "debian" or "windows".
          # @!attribute [rw] os_version
          #   @return [String]
          #     Targets VM instances with OS Inventory enabled and having the following
          #     following OS version.
          # @!attribute [rw] os_architecture
          #   @return [String]
          #     Targets VM instances with OS Inventory enabled and having the following
          #     OS architecture.
          class OsType; end
        end

        # Package is a reference to the software package to be installed or removed.
        # The agent on the VM instance uses the system package manager to apply the
        # config.
        #
        #
        # These are the commands that the agent uses to install or remove
        # packages.
        #
        # Apt
        # install: `apt-get update && apt-get -y install package1 package2 package3`
        # remove: `apt-get -y remove package1 package2 package3`
        #
        # Yum
        # install: `yum -y install package1 package2 package3`
        # remove: `yum -y remove package1 package2 package3`
        #
        # Zypper
        # install: `zypper install package1 package2 package3`
        # remove: `zypper rm package1 package2`
        #
        # Googet
        # install: `googet -noconfirm install package1 package2 package3`
        # remove: `googet -noconfirm remove package1 package2 package3`
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the package. A package is uniquely identified for conflict
        #     validation by checking the package name and the manager(s) that the
        #     package targets.
        # @!attribute [rw] desired_state
        #   @return [Google::Cloud::Osconfig::V1beta::DesiredState]
        #     The desired_state the agent should maintain for this package. The
        #     default is to ensure the package is installed.
        # @!attribute [rw] manager
        #   @return [Google::Cloud::Osconfig::V1beta::Package::Manager]
        #     Type of package manager that can be used to install this package.
        #     If a system does not have the package manager, the package is not
        #     installed or removed no error message is returned. By default,
        #     or if you specify `ANY`,
        #     the agent attempts to install and remove this package using the default
        #     package manager. This is useful when creating a policy that applies to
        #     different types of systems.
        #
        #     The default behavior is ANY.
        class Package
          # Types of package managers that may be used to manage this package.
          module Manager
            # The default behavior is ANY.
            MANAGER_UNSPECIFIED = 0

            # Apply this package config using the default system package manager.
            ANY = 1

            # Apply this package config only if Apt is available on the system.
            APT = 2

            # Apply this package config only if Yum is available on the system.
            YUM = 3

            # Apply this package config only if Zypper is available on the system.
            ZYPPER = 4

            # Apply this package config only if GooGet is available on the system.
            GOO = 5
          end
        end

        # Represents a single Apt package repository. This repository is added to
        # a repo file that is stored at
        # `/etc/apt/sources.list.d/google_osconfig.list`.
        # @!attribute [rw] archive_type
        #   @return [Google::Cloud::Osconfig::V1beta::AptRepository::ArchiveType]
        #     Type of archive files in this repository. The default behavior is DEB.
        # @!attribute [rw] uri
        #   @return [String]
        #     Required. URI for this repository.
        # @!attribute [rw] distribution
        #   @return [String]
        #     Required. Distribution of this repository.
        # @!attribute [rw] components
        #   @return [Array<String>]
        #     Required. List of components for this repository. Must contain at least one item.
        # @!attribute [rw] gpg_key
        #   @return [String]
        #     URI of the key file for this repository. The agent maintains
        #     a keyring at `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg` containing
        #     all the keys in any applied guest policy.
        class AptRepository
          # Type of archive.
          module ArchiveType
            # Unspecified.
            ARCHIVE_TYPE_UNSPECIFIED = 0

            # DEB indicates that the archive contains binary files.
            DEB = 1

            # DEB_SRC indicates that the archive contains source files.
            DEB_SRC = 2
          end
        end

        # Represents a single Yum package repository. This repository is added to a
        # repo file that is stored at `/etc/yum.repos.d/google_osconfig.repo`.
        # @!attribute [rw] id
        #   @return [String]
        #     Required. A one word, unique name for this repository. This is
        #     the `repo id` in the Yum config file and also the `display_name` if
        #     `display_name` is omitted. This id is also used as the unique identifier
        #     when checking for guest policy conflicts.
        # @!attribute [rw] display_name
        #   @return [String]
        #     The display name of the repository.
        # @!attribute [rw] base_url
        #   @return [String]
        #     Required. The location of the repository directory.
        # @!attribute [rw] gpg_keys
        #   @return [Array<String>]
        #     URIs of GPG keys.
        class YumRepository; end

        # Represents a single Zypper package repository. This repository is added to a
        # repo file that is stored at `/etc/zypp/repos.d/google_osconfig.repo`.
        # @!attribute [rw] id
        #   @return [String]
        #     Required. A one word, unique name for this repository. This is
        #     the `repo id` in the zypper config file and also the `display_name` if
        #     `display_name` is omitted. This id is also used as the unique identifier
        #     when checking for guest policy conflicts.
        # @!attribute [rw] display_name
        #   @return [String]
        #     The display name of the repository.
        # @!attribute [rw] base_url
        #   @return [String]
        #     Required. The location of the repository directory.
        # @!attribute [rw] gpg_keys
        #   @return [Array<String>]
        #     URIs of GPG keys.
        class ZypperRepository; end

        # Represents a Goo package repository. These is added to a repo file
        # that is stored at C:/ProgramData/GooGet/repos/google_osconfig.repo.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the repository.
        # @!attribute [rw] url
        #   @return [String]
        #     Required. The url of the repository.
        class GooRepository; end

        # A package repository.
        # @!attribute [rw] apt
        #   @return [Google::Cloud::Osconfig::V1beta::AptRepository]
        #     An Apt Repository.
        # @!attribute [rw] yum
        #   @return [Google::Cloud::Osconfig::V1beta::YumRepository]
        #     A Yum Repository.
        # @!attribute [rw] zypper
        #   @return [Google::Cloud::Osconfig::V1beta::ZypperRepository]
        #     A Zypper Repository.
        # @!attribute [rw] goo
        #   @return [Google::Cloud::Osconfig::V1beta::GooRepository]
        #     A Goo Repository.
        class PackageRepository; end

        # A software recipe is a set of instructions for installing and configuring a
        # piece of software. It consists of a set of artifacts that are
        # downloaded, and a set of steps that install, configure, and/or update the
        # software.
        #
        # Recipes support installing and updating software from artifacts in the
        # following formats:
        # Zip archive, Tar archive, Windows MSI, Debian package, and RPM package.
        #
        # Additionally, recipes support executing a script (either defined in a file or
        # directly in this api) in bash, sh, cmd, and powershell.
        #
        # Updating a software recipe
        #
        # If a recipe is assigned to an instance and there is a recipe with the same
        # name but a lower version already installed and the assigned state
        # of the recipe is `INSTALLED_KEEP_UPDATED`, then the recipe is updated to
        # the new version.
        #
        # Script Working Directories
        #
        # Each script or execution step is run in its own temporary directory which
        # is deleted after completing the step.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Unique identifier for the recipe. Only one recipe with a given name is
        #     installed on an instance.
        #
        #     Names are also used to identify resources which helps to determine whether
        #     guest policies have conflicts. This means that requests to create multiple
        #     recipes with the same name and version are rejected since they
        #     could potentially have conflicting assignments.
        # @!attribute [rw] version
        #   @return [String]
        #     The version of this software recipe. Version can be up to 4 period
        #     separated numbers (e.g. 12.34.56.78).
        # @!attribute [rw] artifacts
        #   @return [Array<Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Artifact>]
        #     Resources available to be used in the steps in the recipe.
        # @!attribute [rw] install_steps
        #   @return [Array<Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step>]
        #     Actions to be taken for installing this recipe. On failure it stops
        #     executing steps and does not attempt another installation. Any steps taken
        #     (including partially completed steps) are not rolled back.
        # @!attribute [rw] update_steps
        #   @return [Array<Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step>]
        #     Actions to be taken for updating this recipe. On failure it stops
        #     executing steps and  does not attempt another update for this recipe. Any
        #     steps taken (including partially completed steps) are not rolled back.
        # @!attribute [rw] desired_state
        #   @return [Google::Cloud::Osconfig::V1beta::DesiredState]
        #     Default is INSTALLED. The desired state the agent should maintain for this
        #     recipe.
        #
        #     INSTALLED: The software recipe is installed on the instance but
        #                won't be updated to new versions.
        #     INSTALLED_KEEP_UPDATED: The software recipe is installed on the
        #                             instance. The recipe is updated to a higher
        #                             version, if a higher version of the recipe is
        #                             assigned to this instance.
        #     REMOVE: Remove is unsupported for software recipes and attempts to
        #             create or update a recipe to the REMOVE state is rejected.
        class SoftwareRecipe
          # Specifies a resource to be used in the recipe.
          # @!attribute [rw] id
          #   @return [String]
          #     Required. Id of the artifact, which the installation and update steps of this
          #     recipe can reference. Artifacts in a recipe cannot have the same id.
          # @!attribute [rw] remote
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Artifact::Remote]
          #     A generic remote artifact.
          # @!attribute [rw] gcs
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Artifact::Gcs]
          #     A Google Cloud Storage artifact.
          # @!attribute [rw] allow_insecure
          #   @return [true, false]
          #     Defaults to false. When false, recipes are subject to validations
          #     based on the artifact type:
          #
          #     Remote: A checksum must be specified, and only protocols with
          #     transport-layer security are permitted.
          #     GCS:    An object generation number must be specified.
          class Artifact
            # Specifies an artifact available via some URI.
            # @!attribute [rw] uri
            #   @return [String]
            #     URI from which to fetch the object. It should contain both the protocol
            #     and path following the format {protocol}://{location}.
            # @!attribute [rw] checksum
            #   @return [String]
            #     Must be provided if `allow_insecure` is `false`.
            #     SHA256 checksum in hex format, to compare to the checksum of the
            #     artifact. If the checksum is not empty and it doesn't match the
            #     artifact then the recipe installation fails before running any of the
            #     steps.
            class Remote; end

            # Specifies an artifact available as a Google Cloud Storage object.
            # @!attribute [rw] bucket
            #   @return [String]
            #     Bucket of the Google Cloud Storage object.
            #     Given an example URL:
            #     `https://storage.googleapis.com/my-bucket/foo/bar#1234567`
            #     this value would be `my-bucket`.
            # @!attribute [rw] object
            #   @return [String]
            #     Name of the Google Cloud Storage object.
            #     As specified [here]
            #     (https://cloud.google.com/storage/docs/naming#objectnames)
            #     Given an example URL:
            #     `https://storage.googleapis.com/my-bucket/foo/bar#1234567`
            #     this value would be `foo/bar`.
            # @!attribute [rw] generation
            #   @return [Integer]
            #     Must be provided if allow_insecure is false.
            #     Generation number of the Google Cloud Storage object.
            #     `https://storage.googleapis.com/my-bucket/foo/bar#1234567`
            #     this value would be `1234567`.
            class Gcs; end
          end

          # An action that can be taken as part of installing or updating a recipe.
          # @!attribute [rw] file_copy
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::CopyFile]
          #     Copies a file onto the instance.
          # @!attribute [rw] archive_extraction
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::ExtractArchive]
          #     Extracts an archive into the specified directory.
          # @!attribute [rw] msi_installation
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::InstallMsi]
          #     Installs an MSI file.
          # @!attribute [rw] dpkg_installation
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::InstallDpkg]
          #     Installs a deb file via dpkg.
          # @!attribute [rw] rpm_installation
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::InstallRpm]
          #     Installs an rpm file via the rpm utility.
          # @!attribute [rw] file_exec
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::ExecFile]
          #     Executes an artifact or local file.
          # @!attribute [rw] script_run
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::RunScript]
          #     Runs commands in a shell.
          class Step
            # Copies the artifact to the specified path on the instance.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     Required. The id of the relevant artifact in the recipe.
            # @!attribute [rw] destination
            #   @return [String]
            #     Required. The absolute path on the instance to put the file.
            # @!attribute [rw] overwrite
            #   @return [true, false]
            #     Whether to allow this step to overwrite existing files. If this is
            #     false and the file already exists the file is not overwritten
            #     and the step is considered a success. Defaults to false.
            # @!attribute [rw] permissions
            #   @return [String]
            #     Consists of three octal digits which represent, in
            #     order, the permissions of the owner, group, and other users for the
            #     file (similarly to the numeric mode used in the linux chmod utility).
            #     Each digit represents a three bit number with the 4 bit
            #     corresponding to the read permissions, the 2 bit corresponds to the
            #     write bit, and the one bit corresponds to the execute permission.
            #     Default behavior is 755.
            #
            #     Below are some examples of permissions and their associated values:
            #     read, write, and execute: 7
            #     read and execute: 5
            #     read and write: 6
            #     read only: 4
            class CopyFile; end

            # Extracts an archive of the type specified in the specified directory.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     Required. The id of the relevant artifact in the recipe.
            # @!attribute [rw] destination
            #   @return [String]
            #     Directory to extract archive to.
            #     Defaults to `/` on Linux or `C:\` on Windows.
            # @!attribute [rw] type
            #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::ExtractArchive::ArchiveType]
            #     Required. The type of the archive to extract.
            class ExtractArchive
              # Specifying the type of archive.
              module ArchiveType
                # Indicates that the archive type isn't specified.
                ARCHIVE_TYPE_UNSPECIFIED = 0

                # Indicates that the archive is a tar archive with no encryption.
                TAR = 1

                # Indicates that the archive is a tar archive with gzip encryption.
                TAR_GZIP = 2

                # Indicates that the archive is a tar archive with bzip encryption.
                TAR_BZIP = 3

                # Indicates that the archive is a tar archive with lzma encryption.
                TAR_LZMA = 4

                # Indicates that the archive is a tar archive with xz encryption.
                TAR_XZ = 5

                # Indicates that the archive is a zip archive.
                ZIP = 11
              end
            end

            # Installs an MSI file.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     Required. The id of the relevant artifact in the recipe.
            # @!attribute [rw] flags
            #   @return [Array<String>]
            #     The flags to use when installing the MSI
            #     defaults to ["/i"] (i.e. the install flag).
            # @!attribute [rw] allowed_exit_codes
            #   @return [Array<Integer>]
            #     Return codes that indicate that the software installed or updated
            #     successfully. Behaviour defaults to [0]
            class InstallMsi; end

            # Installs a deb via dpkg.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     Required. The id of the relevant artifact in the recipe.
            class InstallDpkg; end

            # Installs an rpm file via the rpm utility.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     Required. The id of the relevant artifact in the recipe.
            class InstallRpm; end

            # Executes an artifact or local file.
            # @!attribute [rw] artifact_id
            #   @return [String]
            #     The id of the relevant artifact in the recipe.
            # @!attribute [rw] local_path
            #   @return [String]
            #     The absolute path of the file on the local filesystem.
            # @!attribute [rw] args
            #   @return [Array<String>]
            #     Arguments to be passed to the provided executable.
            # @!attribute [rw] allowed_exit_codes
            #   @return [Array<Integer>]
            #     Defaults to [0]. A list of possible return values that the program
            #     can return to indicate a success.
            class ExecFile; end

            # Runs a script through an interpreter.
            # @!attribute [rw] script
            #   @return [String]
            #     Required. The shell script to be executed.
            # @!attribute [rw] allowed_exit_codes
            #   @return [Array<Integer>]
            #     Return codes that indicate that the software installed or updated
            #     successfully. Behaviour defaults to [0]
            # @!attribute [rw] interpreter
            #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe::Step::RunScript::Interpreter]
            #     The script interpreter to use to run the script. If no interpreter is
            #     specified the script is executed directly, which likely
            #     only succeed for scripts with
            #     [shebang lines](https://en.wikipedia.org/wiki/Shebang_\(Unix\)).
            class RunScript
              # The interpreter used to execute a script.
              module Interpreter
                # Default value for ScriptType.
                INTERPRETER_UNSPECIFIED = 0

                # Indicates that the script is run with `/bin/sh` on Linux and `cmd`
                # on windows.
                SHELL = 1

                # Indicates that the script is run with powershell.
                POWERSHELL = 3
              end
            end
          end
        end

        # A request message for creating a guest policy.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the parent using one of the following forms:
        #     `projects/{project_number}`.
        # @!attribute [rw] guest_policy_id
        #   @return [String]
        #     Required. The logical name of the guest policy in the project
        #     with the following restrictions:
        #
        #     * Must contain only lowercase letters, numbers, and hyphens.
        #     * Must start with a letter.
        #     * Must be between 1-63 characters.
        #     * Must end with a number or a letter.
        #     * Must be unique within the project.
        # @!attribute [rw] guest_policy
        #   @return [Google::Cloud::Osconfig::V1beta::GuestPolicy]
        #     Required. The GuestPolicy to create.
        class CreateGuestPolicyRequest; end

        # A request message for retrieving a guest policy.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the guest policy using one of the following forms:
        #     `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        class GetGuestPolicyRequest; end

        # A request message for listing guest policies.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the parent using one of the following forms:
        #     `projects/{project_number}`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of guest policies to return.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A pagination token returned from a previous call to `ListGuestPolicies`
        #     that indicates where this listing should continue from.
        class ListGuestPoliciesRequest; end

        # A response message for listing guest policies.
        # @!attribute [rw] guest_policies
        #   @return [Array<Google::Cloud::Osconfig::V1beta::GuestPolicy>]
        #     The list of GuestPolicies.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A pagination token that can be used to get the next page
        #     of guest policies.
        class ListGuestPoliciesResponse; end

        # A request message for updating a guest policy.
        # @!attribute [rw] guest_policy
        #   @return [Google::Cloud::Osconfig::V1beta::GuestPolicy]
        #     Required. The updated GuestPolicy.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Field mask that controls which fields of the guest policy should be
        #     updated.
        class UpdateGuestPolicyRequest; end

        # A request message for deleting a guest policy.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the guest policy  using one of the following forms:
        #     `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        class DeleteGuestPolicyRequest; end

        # A request message for getting the effective guest policy assigned to the
        # instance.
        # @!attribute [rw] instance
        #   @return [String]
        #     Required. The VM instance whose policies are being looked up.
        # @!attribute [rw] os_short_name
        #   @return [String]
        #     Short name of the OS running on the instance. The OS Config agent only
        #     provides this field for targeting if OS Inventory is enabled for that
        #     instance.
        # @!attribute [rw] os_version
        #   @return [String]
        #     Version of the OS running on the instance. The OS Config agent only
        #     provides this field for targeting if OS Inventory is enabled for that
        #     VM instance.
        # @!attribute [rw] os_architecture
        #   @return [String]
        #     Architecture of OS running on the instance. The OS Config agent only
        #     provides this field for targeting if OS Inventory is enabled for that
        #     instance.
        class LookupEffectiveGuestPolicyRequest; end

        # The effective guest policy that applies to a VM instance.
        # @!attribute [rw] packages
        #   @return [Array<Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy::SourcedPackage>]
        #     List of package configurations assigned to the VM instance.
        # @!attribute [rw] package_repositories
        #   @return [Array<Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy::SourcedPackageRepository>]
        #     List of package repository configurations assigned to the VM instance.
        # @!attribute [rw] software_recipes
        #   @return [Array<Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy::SourcedSoftwareRecipe>]
        #     List of recipes assigned to the VM instance.
        class EffectiveGuestPolicy
          # A guest policy package including its source.
          # @!attribute [rw] source
          #   @return [String]
          #     Name of the guest policy providing this config.
          # @!attribute [rw] package
          #   @return [Google::Cloud::Osconfig::V1beta::Package]
          #     A software package to configure on the VM instance.
          class SourcedPackage; end

          # A guest policy package repository including its source.
          # @!attribute [rw] source
          #   @return [String]
          #     Name of the guest policy providing this config.
          # @!attribute [rw] package_repository
          #   @return [Google::Cloud::Osconfig::V1beta::PackageRepository]
          #     A software package repository to configure on the VM instance.
          class SourcedPackageRepository; end

          # A guest policy recipe including its source.
          # @!attribute [rw] source
          #   @return [String]
          #     Name of the guest policy providing this config.
          # @!attribute [rw] software_recipe
          #   @return [Google::Cloud::Osconfig::V1beta::SoftwareRecipe]
          #     A software recipe to configure on the VM instance.
          class SourcedSoftwareRecipe; end
        end

        # The desired state that the OS Config agent maintains on the VM instance.
        module DesiredState
          # The default is to ensure the package is installed.
          DESIRED_STATE_UNSPECIFIED = 0

          # The agent ensures that the package is installed.
          INSTALLED = 1

          # The agent ensures that the package is installed and
          # periodically checks for and install any updates.
          UPDATED = 2

          # The agent ensures that the package is not installed and uninstall it
          # if detected.
          REMOVED = 3
        end
      end
    end
  end
end