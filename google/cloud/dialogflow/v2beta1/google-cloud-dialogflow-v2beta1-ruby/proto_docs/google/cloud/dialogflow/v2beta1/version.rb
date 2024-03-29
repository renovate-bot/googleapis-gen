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
    module Dialogflow
      module V2beta1
        # You can create multiple versions of your agent and publish them to separate
        # environments.
        #
        # When you edit an agent, you are editing the draft agent. At any point, you
        # can save the draft agent as an agent version, which is an immutable snapshot
        # of your agent.
        #
        # When you save the draft agent, it is published to the default environment.
        # When you create agent versions, you can publish them to custom environments.
        # You can create a variety of custom environments for:
        #
        # - testing
        # - development
        # - production
        # - etc.
        #
        # For more information, see the [versions and environments
        # guide](https://cloud.google.com/dialogflow/docs/agents-versions).
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. The unique identifier of this agent version.
        #     Supported formats:
        #     - `projects/<Project ID>/agent/versions/<Version ID>`
        #     - `projects/<Project ID>/locations/<Location ID>/agent/versions/<Version
        #       ID>`
        # @!attribute [rw] description
        #   @return [::String]
        #     Optional. The developer-provided description of this version.
        # @!attribute [r] version_number
        #   @return [::Integer]
        #     Output only. The sequential number of this version. This field is read-only which means
        #     it cannot be set by create and update methods.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The creation time of this version. This field is read-only, i.e., it cannot
        #     be set by create and update methods.
        # @!attribute [r] status
        #   @return [::Google::Cloud::Dialogflow::V2beta1::Version::VersionStatus]
        #     Output only. The status of this version. This field is read-only and cannot be set by
        #     create and update methods.
        class Version
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # The status of a version.
          module VersionStatus
            # Not specified. This value is not used.
            VERSION_STATUS_UNSPECIFIED = 0

            # Version is not ready to serve (e.g. training is in progress).
            IN_PROGRESS = 1

            # Version is ready to serve.
            READY = 2

            # Version training failed.
            FAILED = 3
          end
        end

        # The request message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#list_versions Versions.ListVersions}.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The agent to list all versions from.
        #     Supported formats:
        #     - `projects/<Project ID>/agent`
        #     - `projects/<Project ID>/locations/<Location ID>/agent`
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     Optional. The maximum number of items to return in a single page. By default 100 and
        #     at most 1000.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     Optional. The next_page_token value returned from a previous list request.
        class ListVersionsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The response message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#list_versions Versions.ListVersions}.
        # @!attribute [rw] versions
        #   @return [::Array<::Google::Cloud::Dialogflow::V2beta1::Version>]
        #     The list of agent versions. There will be a maximum number of items
        #     returned based on the page_size field in the request.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListVersionsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#get_version Versions.GetVersion}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The name of the version.
        #     Supported formats:
        #     - `projects/<Project ID>/agent/versions/<Version ID>`
        #     - `projects/<Project ID>/locations/<Location ID>/agent/versions/<Version
        #       ID>`
        class GetVersionRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#create_version Versions.CreateVersion}.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The agent to create a version for.
        #     Supported formats:
        #     - `projects/<Project ID>/agent`
        #     - `projects/<Project ID>/locations/<Location ID>/agent`
        # @!attribute [rw] version
        #   @return [::Google::Cloud::Dialogflow::V2beta1::Version]
        #     Required. The version to create.
        class CreateVersionRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#update_version Versions.UpdateVersion}.
        # @!attribute [rw] version
        #   @return [::Google::Cloud::Dialogflow::V2beta1::Version]
        #     Required. The version to update.
        #     Supported formats:
        #     - `projects/<Project ID>/agent/versions/<Version ID>`
        #     - `projects/<Project ID>/locations/<Location ID>/agent/versions/<Version
        #       ID>`
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. The mask to control which fields get updated.
        class UpdateVersionRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request message for {::Google::Cloud::Dialogflow::V2beta1::Versions::Client#delete_version Versions.DeleteVersion}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The name of the version to delete.
        #     Supported formats:
        #     - `projects/<Project ID>/agent/versions/<Version ID>`
        #     - `projects/<Project ID>/locations/<Location ID>/agent/versions/<Version
        #       ID>`
        class DeleteVersionRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
