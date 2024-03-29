# frozen_string_literal: true

# Copyright 2022 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Apps
    module Script
      module Type
        module Drive
          # Drive add-on manifest.
          # @!attribute [rw] homepage_trigger
          #   @return [::Google::Apps::Script::Type::HomepageExtensionPoint]
          #     If present, this overrides the configuration from
          #     `addOns.common.homepageTrigger`.
          # @!attribute [rw] on_items_selected_trigger
          #   @return [::Google::Apps::Script::Type::Drive::DriveExtensionPoint]
          #     Corresponds to behvior that should execute when items are selected
          #     in relevant Drive view (e.g. the My Drive Doclist).
          class DriveAddOnManifest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A generic extension point with common features, e.g. something that simply
          # needs a corresponding run function to work.
          # @!attribute [rw] run_function
          #   @return [::String]
          #     Required. The endpoint to execute when this extension point is
          #     activated.
          class DriveExtensionPoint
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
