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
    module ResourceManager
      module V3
        # A TagBinding represents a connection between a TagValue and a cloud
        # resource (currently project, folder, or organization). Once a TagBinding is
        # created, the TagValue is applied to all the descendants of the cloud
        # resource.
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. The name of the TagBinding. This is a String of the form:
        #     `tagBindings/{full-resource-name}/{tag-value-name}` (e.g.
        #     `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        # @!attribute [rw] parent
        #   @return [::String]
        #     The full resource name of the resource the TagValue is bound to.
        #     E.g. `//cloudresourcemanager.googleapis.com/projects/123`
        # @!attribute [rw] tag_value
        #   @return [::String]
        #     The TagValue of the TagBinding.
        #     Must be of the form `tagValues/456`.
        class TagBinding
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Runtime operation information for creating a TagValue.
        class CreateTagBindingMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message to create a TagBinding.
        # @!attribute [rw] tag_binding
        #   @return [::Google::Cloud::ResourceManager::V3::TagBinding]
        #     Required. The TagBinding to be created.
        # @!attribute [rw] validate_only
        #   @return [::Boolean]
        #     Optional. Set to true to perform the validations necessary for creating the resource,
        #     but not actually perform the action.
        class CreateTagBindingRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Runtime operation information for deleting a TagBinding.
        class DeleteTagBindingMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message to delete a TagBinding.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The name of the TagBinding. This is a String of the form:
        #     `tagBindings/{id}` (e.g.
        #     `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        class DeleteTagBindingRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message to list all TagBindings for a parent.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The full resource name of a resource for which you want to list existing
        #     TagBindings.
        #     E.g. "//cloudresourcemanager.googleapis.com/projects/123"
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     Optional. The maximum number of TagBindings to return in the response. The server
        #     allows a maximum of 300 TagBindings to return. If unspecified, the server
        #     will use 100 as the default.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     Optional. A pagination token returned from a previous call to `ListTagBindings`
        #     that indicates where this listing should continue from.
        class ListTagBindingsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The ListTagBindings response.
        # @!attribute [rw] tag_bindings
        #   @return [::Array<::Google::Cloud::ResourceManager::V3::TagBinding>]
        #     A possibly paginated list of TagBindings for the specified TagValue or
        #     resource.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     Pagination token.
        #
        #     If the result set is too large to fit in a single response, this token
        #     is returned. It encodes the position of the current result cursor.
        #     Feeding this value into a new list request with the `page_token` parameter
        #     gives the next page of the results.
        #
        #     When `next_page_token` is not filled in, there is no next page and
        #     the list returned is the last page in the result set.
        #
        #     Pagination tokens have a limited lifetime.
        class ListTagBindingsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
