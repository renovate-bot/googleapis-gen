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
    module Dialogflow
      module Cx
        module V3
          # The request message for {Google::Cloud::Dialogflow::Cx::V3::SecuritySettingsService::GetSecuritySettings SecuritySettingsService::GetSecuritySettings}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Resource name of the settings.
          #     Format: `projects/<Project ID>/locations/<Location
          #     ID>/securitySettings/<security settings ID>`.
          class GetSecuritySettingsRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3::SecuritySettingsService::UpdateSecuritySettings SecuritySettingsService::UpdateSecuritySettings}.
          # @!attribute [rw] security_settings
          #   @return [Google::Cloud::Dialogflow::Cx::V3::SecuritySettings]
          #     Required. [SecuritySettings] object that contains values for each of the
          #     fields to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     Required. The mask to control which fields get updated. If the mask is not present,
          #     all fields will be updated.
          class UpdateSecuritySettingsRequest; end

          # The request message for {SecuritySettings::ListSecuritySettings}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The location to list all security settings for.
          #     Format: `projects/<Project ID>/locations/<Location ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 20 and
          #     at most 100.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListSecuritySettingsRequest; end

          # The response message for {SecuritySettings::ListSecuritySettings}.
          # @!attribute [rw] security_settings
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3::SecuritySettings>]
          #     The list of security settings.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListSecuritySettingsResponse; end

          # The request message for {SecuritySettings::CreateSecuritySettings}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The location to create an {Google::Cloud::Dialogflow::Cx::V3::SecuritySettings SecuritySettings} for.
          #     Format: `projects/<Project ID>/locations/<Location ID>`.
          # @!attribute [rw] security_settings
          #   @return [Google::Cloud::Dialogflow::Cx::V3::SecuritySettings]
          #     Required. The security settings to create.
          class CreateSecuritySettingsRequest; end

          # The request message for {SecuritySettings::DeleteSecuritySettings}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the {Google::Cloud::Dialogflow::Cx::V3::SecuritySettings SecuritySettings} to delete.
          #     Format: `projects/<Project ID>/locations/<Location
          #     ID>/securitySettings/<Security Settings ID>`.
          class DeleteSecuritySettingsRequest; end

          # Represents the settings related to security issues, such as data redaction
          # and data retention. It may take hours for updates on the settings to
          # propagate to all the related components and take effect.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Resource name of the settings.
          #     Format: `projects/<Project ID>/locations/<Location
          #     ID>/securitySettings/<Security Settings ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the security settings, unique within the
          #     location.
          # @!attribute [rw] redaction_strategy
          #   @return [Google::Cloud::Dialogflow::Cx::V3::SecuritySettings::RedactionStrategy]
          #     Strategy that defines how we do redaction.
          # @!attribute [rw] redaction_scope
          #   @return [Google::Cloud::Dialogflow::Cx::V3::SecuritySettings::RedactionScope]
          #     Defines on what data we apply redaction. Note that we don't
          #     redact data to which we don't have access, e.g., Stackdriver logs.
          # @!attribute [rw] inspect_template
          #   @return [String]
          #     DLP inspect template name. Use this template to define inspect base
          #     settings.
          #
          #     If empty, we use the default DLP inspect config.
          #
          #     The template name will have one of the following formats:
          #     `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
          #     `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
          # @!attribute [rw] retention_window_days
          #   @return [Integer]
          #     Retains the data for the specified number of days.
          #     User must Set a value lower than Dialogflow's default 30d TTL. Setting a
          #     value higher than that has no effect.
          #     A missing value or setting to 0 also means we use Dialogflow's default
          #     TTL.
          # @!attribute [rw] purge_data_types
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3::SecuritySettings::PurgeDataType>]
          #     List of types of data to remove when retention settings triggers purge.
          class SecuritySettings
            # Type of data we purge after retention settings triggers purge.
            module PurgeDataType
              # Unspecified. Do not use.
              PURGE_DATA_TYPE_UNSPECIFIED = 0

              # Dialogflow history. This does not include Stackdriver log, which is
              # owned by the user not Dialogflow.
              DIALOGFLOW_HISTORY = 1
            end

            # Defines what types of data to redact.
            module RedactionScope
              # Don't redact any kind of data.
              REDACTION_SCOPE_UNSPECIFIED = 0

              # On data to be written to disk or similar devices that are capable of
              # holding data even if power is disconnected. This includes data that are
              # temporarily saved on disk.
              REDACT_DISK_STORAGE = 2
            end

            # Defines how we redact data.
            module RedactionStrategy
              # Do not redact.
              REDACTION_STRATEGY_UNSPECIFIED = 0

              # Call redaction service to clean up the data to be persisted.
              REDACT_WITH_SERVICE = 1
            end
          end
        end
      end
    end
  end
end