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
  module Ads
    module GoogleAds
      module V9
        module Services
          # Request message for
          # {::Google::Ads::GoogleAds::V9::Services::CustomerExtensionSettingService::Client#get_customer_extension_setting CustomerExtensionSettingService.GetCustomerExtensionSetting}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the customer extension setting to fetch.
          class GetCustomerExtensionSettingRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for
          # {::Google::Ads::GoogleAds::V9::Services::CustomerExtensionSettingService::Client#mutate_customer_extension_settings CustomerExtensionSettingService.MutateCustomerExtensionSettings}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose customer extension settings are being
          #     modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::CustomerExtensionSettingOperation>]
          #     Required. The list of operations to perform on individual customer extension
          #     settings.
          # @!attribute [rw] partial_failure
          #   @return [::Boolean]
          #     If true, successful operations will be carried out and invalid
          #     operations will return errors. If false, all operations will be carried
          #     out in one transaction if and only if they are all valid.
          #     Default is false.
          # @!attribute [rw] validate_only
          #   @return [::Boolean]
          #     If true, the request is validated but not executed. Only errors are
          #     returned, not results.
          # @!attribute [rw] response_content_type
          #   @return [::Google::Ads::GoogleAds::V9::Enums::ResponseContentTypeEnum::ResponseContentType]
          #     The response content type setting. Determines whether the mutable resource
          #     or just the resource name should be returned post mutation.
          class MutateCustomerExtensionSettingsRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (create, update, remove) on a customer extension setting.
          # @!attribute [rw] update_mask
          #   @return [::Google::Protobuf::FieldMask]
          #     FieldMask that determines which resource fields are modified in an update.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomerExtensionSetting]
          #     Create operation: No resource name is expected for the new customer
          #     extension setting.
          # @!attribute [rw] update
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomerExtensionSetting]
          #     Update operation: The customer extension setting is expected to have a
          #     valid resource name.
          # @!attribute [rw] remove
          #   @return [::String]
          #     Remove operation: A resource name for the removed customer extension
          #     setting is expected, in this format:
          #
          #     `customers/{customer_id}/customerExtensionSettings/{extension_type}`
          class CustomerExtensionSettingOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for a customer extension setting mutate.
          # @!attribute [rw] partial_failure_error
          #   @return [::Google::Rpc::Status]
          #     Errors that pertain to operation failures in the partial failure mode.
          #     Returned only when partial_failure = true and all errors occur inside the
          #     operations. If any errors occur outside the operations (e.g. auth errors),
          #     we return an RPC level error.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::MutateCustomerExtensionSettingResult>]
          #     All results for the mutate.
          class MutateCustomerExtensionSettingsResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the customer extension setting mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          # @!attribute [rw] customer_extension_setting
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomerExtensionSetting]
          #     The mutated CustomerExtensionSetting with only mutable fields after mutate.
          #     The field will only be returned when response_content_type is set to
          #     "MUTABLE_RESOURCE".
          class MutateCustomerExtensionSettingResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
