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
    module Securitycenter
      module V1beta1
        # Security Command Center representation of a Google Cloud
        # resource.
        #
        # The Asset is a Security Command Center resource that captures information
        # about a single Google Cloud resource. All modifications to an Asset are only
        # within the context of Security Command Center and don't affect the referenced
        # Google Cloud resource.
        # @!attribute [rw] name
        #   @return [String]
        #     The relative resource name of this asset. See:
        #     https://cloud.google.com/apis/design/resource_names#relative_resource_name
        #     Example:
        #     "organizations/{organization_id}/assets/{asset_id}".
        # @!attribute [rw] security_center_properties
        #   @return [Google::Cloud::Securitycenter::V1beta1::Asset::SecurityCenterProperties]
        #     Security Command Center managed properties. These properties are managed by
        #     Security Command Center and cannot be modified by the user.
        # @!attribute [rw] resource_properties
        #   @return [Hash{String => Google::Protobuf::Value}]
        #     Resource managed properties. These properties are managed and defined by
        #     the Google Cloud resource and cannot be modified by the user.
        # @!attribute [rw] security_marks
        #   @return [Google::Cloud::Securitycenter::V1beta1::SecurityMarks]
        #     User specified security marks. These marks are entirely managed by the user
        #     and come from the SecurityMarks resource that belongs to the asset.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which the asset was created in Security Command Center.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which the asset was last updated, added, or deleted in Security
        #     Command Center.
        class Asset
          # Security Command Center managed properties. These properties are managed by
          # Security Command Center and cannot be modified by the user.
          # @!attribute [rw] resource_name
          #   @return [String]
          #     Immutable. The full resource name of the Google Cloud resource this asset
          #     represents. This field is immutable after create time. See:
          #     https://cloud.google.com/apis/design/resource_names#full_resource_name
          # @!attribute [rw] resource_type
          #   @return [String]
          #     The type of the Google Cloud resource. Examples include: APPLICATION,
          #     PROJECT, and ORGANIZATION. This is a case insensitive field defined by
          #     Security Command Center and/or the producer of the resource and is
          #     immutable after create time.
          # @!attribute [rw] resource_parent
          #   @return [String]
          #     The full resource name of the immediate parent of the resource. See:
          #     https://cloud.google.com/apis/design/resource_names#full_resource_name
          # @!attribute [rw] resource_project
          #   @return [String]
          #     The full resource name of the project the resource belongs to. See:
          #     https://cloud.google.com/apis/design/resource_names#full_resource_name
          # @!attribute [rw] resource_owners
          #   @return [Array<String>]
          #     Owners of the Google Cloud resource.
          class SecurityCenterProperties; end
        end
      end
    end
  end
end