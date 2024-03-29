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
          # {::Google::Ads::GoogleAds::V9::Services::ConversionCustomVariableService::Client#get_conversion_custom_variable ConversionCustomVariableService.GetConversionCustomVariable}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the conversion custom variable to fetch.
          class GetConversionCustomVariableRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for
          # {::Google::Ads::GoogleAds::V9::Services::ConversionCustomVariableService::Client#mutate_conversion_custom_variables ConversionCustomVariableService.MutateConversionCustomVariables}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose conversion custom variables are being
          #     modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::ConversionCustomVariableOperation>]
          #     Required. The list of operations to perform on individual conversion custom
          #     variables.
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
          class MutateConversionCustomVariablesRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (create, update) on a conversion custom variable.
          # @!attribute [rw] update_mask
          #   @return [::Google::Protobuf::FieldMask]
          #     FieldMask that determines which resource fields are modified in an update.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V9::Resources::ConversionCustomVariable]
          #     Create operation: No resource name is expected for the new conversion
          #     custom variable.
          # @!attribute [rw] update
          #   @return [::Google::Ads::GoogleAds::V9::Resources::ConversionCustomVariable]
          #     Update operation: The conversion custom variable is expected to have a
          #     valid resource name.
          class ConversionCustomVariableOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for
          # {::Google::Ads::GoogleAds::V9::Services::ConversionCustomVariableService::Client#mutate_conversion_custom_variables ConversionCustomVariableService.MutateConversionCustomVariables}.
          # @!attribute [rw] partial_failure_error
          #   @return [::Google::Rpc::Status]
          #     Errors that pertain to operation failures in the partial failure mode.
          #     Returned only when partial_failure = true and all errors occur inside the
          #     operations. If any errors occur outside the operations (e.g. auth errors),
          #     we return an RPC level error.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::MutateConversionCustomVariableResult>]
          #     All results for the mutate.
          class MutateConversionCustomVariablesResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the conversion custom variable mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          # @!attribute [rw] conversion_custom_variable
          #   @return [::Google::Ads::GoogleAds::V9::Resources::ConversionCustomVariable]
          #     The mutated conversion custom variable with only mutable fields after
          #     mutate. The field will only be returned when response_content_type is set
          #     to "MUTABLE_RESOURCE".
          class MutateConversionCustomVariableResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
