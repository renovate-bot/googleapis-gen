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
  module Cloud
    module Eventarc
      module V1
        # The request message for the GetTrigger method.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The name of the trigger to get.
        class GetTriggerRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for the ListTriggers method.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent collection to list triggers on.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of triggers to return on each page.
        #     Note: The service may send fewer.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     The page token; provide the value from the `next_page_token` field in a
        #     previous `ListTriggers` call to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListTriggers` must match
        #     the call that provided the page token.
        # @!attribute [rw] order_by
        #   @return [::String]
        #     The sorting order of the resources returned. Value should be a comma
        #     separated list of fields. The default sorting oder is ascending. To specify
        #     descending order for a field, append a ` desc` suffix; for example:
        #     `name desc, trigger_id`.
        class ListTriggersRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The response message for the ListTriggers method.
        # @!attribute [rw] triggers
        #   @return [::Array<::Google::Cloud::Eventarc::V1::Trigger>]
        #     The requested triggers, up to the number specified in `page_size`.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     A page token that can be sent to ListTriggers to request the next page.
        #     If this is empty, then there are no more pages.
        # @!attribute [rw] unreachable
        #   @return [::Array<::String>]
        #     Unreachable resources, if any.
        class ListTriggersResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for the CreateTrigger method.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent collection in which to add this trigger.
        # @!attribute [rw] trigger
        #   @return [::Google::Cloud::Eventarc::V1::Trigger]
        #     Required. The trigger to create.
        # @!attribute [rw] trigger_id
        #   @return [::String]
        #     Required. The user-provided ID to be assigned to the trigger.
        # @!attribute [rw] validate_only
        #   @return [::Boolean]
        #     Required. If set, validate the request and preview the review, but do not actually
        #     post it.
        class CreateTriggerRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for the UpdateTrigger method.
        # @!attribute [rw] trigger
        #   @return [::Google::Cloud::Eventarc::V1::Trigger]
        #     The trigger to be updated.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     The fields to be updated; only fields explicitly provided will be updated.
        #     If no field mask is provided, all provided fields in the request will be
        #     updated. To update all fields, provide a field mask of "*".
        # @!attribute [rw] allow_missing
        #   @return [::Boolean]
        #     If set to true, and the trigger is not found, a new trigger will be
        #     created. In this situation, `update_mask` is ignored.
        # @!attribute [rw] validate_only
        #   @return [::Boolean]
        #     Required. If set, validate the request and preview the review, but do not actually
        #     post it.
        class UpdateTriggerRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for the DeleteTrigger method.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The name of the trigger to be deleted.
        # @!attribute [rw] etag
        #   @return [::String]
        #     If provided, the trigger will only be deleted if the etag matches the
        #     current etag on the resource.
        # @!attribute [rw] allow_missing
        #   @return [::Boolean]
        #     If set to true, and the trigger is not found, the request will succeed
        #     but no action will be taken on the server.
        # @!attribute [rw] validate_only
        #   @return [::Boolean]
        #     Required. If set, validate the request and preview the review, but do not actually
        #     post it.
        class DeleteTriggerRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Represents the metadata of the long-running operation.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the operation was created.
        # @!attribute [r] end_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the operation finished running.
        # @!attribute [r] target
        #   @return [::String]
        #     Output only. Server-defined resource path for the target of the operation.
        # @!attribute [r] verb
        #   @return [::String]
        #     Output only. Name of the verb executed by the operation.
        # @!attribute [r] status_message
        #   @return [::String]
        #     Output only. Human-readable status of the operation, if any.
        # @!attribute [r] requested_cancellation
        #   @return [::Boolean]
        #     Output only. Identifies whether the user has requested cancellation
        #     of the operation. Operations that have successfully been cancelled
        #     have [Operation.error][] value with a {::Google::Rpc::Status#code google.rpc.Status.code} of 1,
        #     corresponding to `Code.CANCELLED`.
        # @!attribute [r] api_version
        #   @return [::String]
        #     Output only. API version used to start the operation.
        class OperationMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
