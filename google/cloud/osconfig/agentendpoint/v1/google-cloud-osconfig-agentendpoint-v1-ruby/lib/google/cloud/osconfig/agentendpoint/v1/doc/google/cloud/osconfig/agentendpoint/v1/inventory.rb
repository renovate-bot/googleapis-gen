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
      module Agentendpoint
        module V1
          # The inventory details of a VM.
          # @!attribute [rw] os_info
          #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::OsInfo]
          #     Base level operating system information for the VM.
          # @!attribute [rw] installed_packages
          #   @return [Array<Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::SoftwarePackage>]
          #     A list of installed packages currently on the VM.
          # @!attribute [rw] available_packages
          #   @return [Array<Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::SoftwarePackage>]
          #     A list of software updates available for the VM as reported by the update
          #     managers.
          class Inventory
            # Operating system information for the VM.
            # @!attribute [rw] hostname
            #   @return [String]
            #     The VM hostname.
            # @!attribute [rw] long_name
            #   @return [String]
            #     The operating system long name.
            #     For example 'Debian GNU/Linux 9' or 'Microsoft Window Server 2019
            #     Datacenter'.
            # @!attribute [rw] short_name
            #   @return [String]
            #     The operating system short name.
            #     For example, 'windows' or 'debian'.
            # @!attribute [rw] version
            #   @return [String]
            #     The version of the operating system.
            # @!attribute [rw] architecture
            #   @return [String]
            #     The system architecture of the operating system.
            # @!attribute [rw] kernel_version
            #   @return [String]
            #     The kernel version of the operating system.
            # @!attribute [rw] kernel_release
            #   @return [String]
            #     The kernel release of the operating system.
            # @!attribute [rw] osconfig_agent_version
            #   @return [String]
            #     The current version of the OS Config agent running on the VM.
            class OsInfo; end

            # Software package information of the operating system.
            # @!attribute [rw] yum_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::VersionedPackage]
            #     Yum package info.
            #     For details about the yum package manager, see
            #     https://access.redhat.com/documentation/en-us/red_hat_enterprise_linux/6/html/deployment_guide/ch-yum.
            # @!attribute [rw] apt_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::VersionedPackage]
            #     Details of an APT package.
            #     For details about the apt package manager, see
            #     https://wiki.debian.org/Apt.
            # @!attribute [rw] zypper_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::VersionedPackage]
            #     Details of a Zypper package.
            #     For details about the Zypper package manager, see
            #     https://en.opensuse.org/SDB:Zypper_manual.
            # @!attribute [rw] googet_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::VersionedPackage]
            #     Details of a Googet package.
            #      For details about the googet package manager, see
            #      https://github.com/google/googet.
            # @!attribute [rw] zypper_patch
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::ZypperPatch]
            #     Details of a Zypper patch.
            #     For details about the Zypper package manager, see
            #     https://en.opensuse.org/SDB:Zypper_manual.
            # @!attribute [rw] wua_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::WindowsUpdatePackage]
            #     Details of a Windows Update package.
            #     See https://docs.microsoft.com/en-us/windows/win32/api/_wua/ for
            #     information about Windows Update.
            # @!attribute [rw] qfe_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::WindowsQuickFixEngineeringPackage]
            #     Details of a Windows Quick Fix engineering package.
            #     See
            #     https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering
            #     for info in Windows Quick Fix Engineering.
            # @!attribute [rw] cos_package
            #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::VersionedPackage]
            #     Details of a COS package.
            class SoftwarePackage; end

            # Information related to the a standard versioned package.  This includes
            # package info for APT, Yum, Zypper, and Googet package managers.
            # @!attribute [rw] package_name
            #   @return [String]
            #     The name of the package.
            # @!attribute [rw] architecture
            #   @return [String]
            #     The system architecture this package is intended for.
            # @!attribute [rw] version
            #   @return [String]
            #     The version of the package.
            class VersionedPackage; end

            # Details related to a Zypper Patch.
            # @!attribute [rw] patch_name
            #   @return [String]
            #     The name of the patch.
            # @!attribute [rw] category
            #   @return [String]
            #     The category of the patch.
            # @!attribute [rw] severity
            #   @return [String]
            #     The severity specified for this patch
            # @!attribute [rw] summary
            #   @return [String]
            #     Any summary information provided about this patch.
            class ZypperPatch; end

            # Details related to a Windows Update package.
            # Field data and names are taken from Windows Update API IUpdate Interface:
            # https://docs.microsoft.com/en-us/windows/win32/api/_wua/
            # Descriptive fields like title, and description are localized based on
            # the locale of the VM being updated.
            # @!attribute [rw] title
            #   @return [String]
            #     The localized title of the update package.
            # @!attribute [rw] description
            #   @return [String]
            #     The localized description of the update package.
            # @!attribute [rw] categories
            #   @return [Array<Google::Cloud::Osconfig::Agentendpoint::V1::Inventory::WindowsUpdatePackage::WindowsUpdateCategory>]
            #     The categories that are associated with this update package.
            # @!attribute [rw] kb_article_ids
            #   @return [Array<String>]
            #     A collection of Microsoft Knowledge Base article IDs that are associated
            #     with the update package.
            # @!attribute [rw] support_url
            #   @return [String]
            #     A hyperlink to the language-specific support information for the update.
            # @!attribute [rw] more_info_urls
            #   @return [Array<String>]
            #     A collection of URLs that provide more information about the update
            #     package.
            # @!attribute [rw] update_id
            #   @return [String]
            #     Gets the identifier of an update package.  Stays the same across
            #     revisions.
            # @!attribute [rw] revision_number
            #   @return [Integer]
            #     The revision number of this update package.
            # @!attribute [rw] last_deployment_change_time
            #   @return [Google::Protobuf::Timestamp]
            #     The last published date of the update, in (UTC) date and time.
            class WindowsUpdatePackage
              # Categories specified by the Windows Update.
              # @!attribute [rw] id
              #   @return [String]
              #     The identifier of the windows update category.
              # @!attribute [rw] name
              #   @return [String]
              #     The name of the windows update category.
              class WindowsUpdateCategory; end
            end

            # Information related to a Quick Fix Engineering package.
            # Fields are taken from Windows QuickFixEngineering Interface and match
            # the source names:
            # https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering
            # @!attribute [rw] caption
            #   @return [String]
            #     A short textual description of the QFE update.
            # @!attribute [rw] description
            #   @return [String]
            #     A textual description of the QFE update.
            # @!attribute [rw] hot_fix_id
            #   @return [String]
            #     Unique identifier associated with a particular QFE update.
            # @!attribute [rw] install_time
            #   @return [Google::Protobuf::Timestamp]
            #     Date that the QFE update was installed.  Mapped from installed_on field.
            class WindowsQuickFixEngineeringPackage; end
          end
        end
      end
    end
  end
end