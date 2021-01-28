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
      module Settings
        module V1beta1
          # Common configuration settings for all of Security Center.
          # @!attribute [rw] name
          #   @return [String]
          #     The relative resource name of the settings resource.
          #     Formats:
          #     * `organizations/{organization}/settings`
          #       * `folders/{folder}/settings`
          #     * `projects/{project}/settings`
          #       * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
          #     * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
          #       * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
          # @!attribute [rw] billing_settings
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::BillingSettings]
          #     Billing settings
          # @!attribute [rw] state
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::Settings::OnboardingState]
          #     An enum representing the current on boarding state of SCC.
          # @!attribute [rw] org_service_account
          #   @return [String]
          #     Output only. The organization-level service account to be used for security center
          #     components. The component must have permission to "act as" the service
          #     account.
          # @!attribute [rw] sink_settings
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::SinkSettings]
          #     Sink settings.
          # @!attribute [rw] component_settings
          #   @return [Hash{String => Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings}]
          #     The settings for detectors and/or scanners.
          # @!attribute [rw] detector_group_settings
          #   @return [Hash{String => Google::Cloud::Securitycenter::Settings::V1beta1::Settings::DetectorGroupSettings}]
          #     Detector group settings for all Security Center components.
          #     The key is the name of the detector group and the value is the settings for
          #     that group.
          # @!attribute [rw] etag
          #   @return [String]
          #     A fingerprint used for optimistic concurrency. If none is provided
          #     on updates then the existing metadata will be blindly overwritten.
          # @!attribute [rw] update_time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. The time these settings were last updated.
          class Settings
            # The DetectorGroupSettings define the configuration for a detector group.
            # @!attribute [rw] state
            #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentEnablementState]
            #     The state determines if the group is enabled or not.
            class DetectorGroupSettings; end

            # Defines the onboarding states for SCC
            #
            # Potentially is just an indicator that a user has reviewed some subset of
            # our configuration surface, even if it's still currently set to its
            # API-default state.
            module OnboardingState
              # No onboarding state has been set. Should not be seen in practice, but
              # should be functionally equivalent to DISABLED.
              ONBOARDING_STATE_UNSPECIFIED = 0

              # SCC is fully on boarded
              ENABLED = 1

              # SCC has been disabled after being on boarded
              DISABLED = 2

              # SCC's onboarding tier has been explicitly set
              BILLING_SELECTED = 3

              # SCC's CTD FindingsProviders have been chosen
              PROVIDERS_SELECTED = 4

              # SCC's Service-Resource mappings have been set
              RESOURCES_SELECTED = 5

              # SCC's core Service Account was created
              ORG_SERVICE_ACCOUNT_CREATED = 6
            end
          end
        end
      end
    end
  end
end