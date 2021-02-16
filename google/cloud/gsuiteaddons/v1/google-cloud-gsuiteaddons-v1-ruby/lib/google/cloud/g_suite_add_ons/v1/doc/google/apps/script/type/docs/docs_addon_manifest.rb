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
  module Apps
    module Script
      module Type
        module Docs
          # Docs add-on manifest.
          # @!attribute [rw] homepage_trigger
          #   @return [Google::Apps::Script::Type::HomepageExtensionPoint]
          #     If present, this overrides the configuration from
          #     `addOns.common.homepageTrigger`.
          # @!attribute [rw] on_file_scope_granted_trigger
          #   @return [Google::Apps::Script::Type::Docs::DocsExtensionPoint]
          #     Endpoint to execute when file scope authorization is granted
          #     for this document/user pair.
          class DocsAddOnManifest; end

          # Common format for declaring a Docs add-on's triggers.
          # @!attribute [rw] run_function
          #   @return [String]
          #     Required. The endpoint to execute when this extension point is activated.
          class DocsExtensionPoint; end
        end
      end
    end
  end
end