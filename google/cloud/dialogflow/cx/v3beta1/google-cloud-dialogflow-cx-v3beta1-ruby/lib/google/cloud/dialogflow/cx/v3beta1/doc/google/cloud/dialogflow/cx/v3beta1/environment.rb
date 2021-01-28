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
        module V3beta1
          # Represents an environment for an agent. You can create multiple versions
          # of your agent and publish them to separate environments. When you edit an
          # agent, you are editing the draft agent. At any point, you can save the draft
          # agent as an agent version, which is an immutable snapshot of your agent. When
          # you save the draft agent, it is published to the default environment. When
          # you create agent versions, you can publish them to custom environments. You
          # can create a variety of custom environments for testing, development,
          # production, etc.
          # @!attribute [rw] name
          #   @return [String]
          #     The name of the environment.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/environments/<Environment ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the environment (unique in an agent). Limit of
          #     64 characters.
          # @!attribute [rw] description
          #   @return [String]
          #     The human-readable description of the environment. The maximum length is
          #     500 characters. If exceeded, the request is rejected.
          # @!attribute [rw] version_configs
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Environment::VersionConfig>]
          #     Required. A list of configurations for flow versions. You should include version
          #     configs for all flows that are reachable from [`Start
          #     Flow`][Agent.start_flow] in the agent. Otherwise, an error will be
          #     returned.
          # @!attribute [rw] update_time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. Update time of this environment.
          class Environment
            # Configuration for the version.
            # @!attribute [rw] version
            #   @return [String]
            #     Required. Format: projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #     ID>/flows/<Flow ID>/versions/<Version ID>.
            class VersionConfig; end
          end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::ListEnvironments Environments::ListEnvironments}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The {Google::Cloud::Dialogflow::Cx::V3beta1::Agent Agent} to list all environments for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 20 and
          #     at most 100.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListEnvironmentsRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::ListEnvironments Environments::ListEnvironments}.
          # @!attribute [rw] environments
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Environment>]
          #     The list of environments. There will be a maximum number of items
          #     returned based on the page_size field in the request. The list may in some
          #     cases be empty or contain fewer entries than page_size even if this isn't
          #     the last page.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListEnvironmentsResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::GetEnvironment Environments::GetEnvironment}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::Environment Environment}.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/environments/<Environment ID>`.
          class GetEnvironmentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::CreateEnvironment Environments::CreateEnvironment}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The {Google::Cloud::Dialogflow::Cx::V3beta1::Agent Agent} to create an {Google::Cloud::Dialogflow::Cx::V3beta1::Environment Environment} for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] environment
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Environment]
          #     Required. The environment to create.
          class CreateEnvironmentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::UpdateEnvironment Environments::UpdateEnvironment}.
          # @!attribute [rw] environment
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Environment]
          #     Required. The environment to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     Required. The mask to control which fields get updated.
          class UpdateEnvironmentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::DeleteEnvironment Environments::DeleteEnvironment}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::Environment Environment} to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/environments/<Environment ID>`.
          class DeleteEnvironmentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::LookupEnvironmentHistory Environments::LookupEnvironmentHistory}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Resource name of the environment to look up the history for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/environments/<Environment ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class LookupEnvironmentHistoryRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Environments::LookupEnvironmentHistory Environments::LookupEnvironmentHistory}.
          # @!attribute [rw] environments
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Environment>]
          #     Represents a list of snapshots for an environment. Time of the snapshots is
          #     stored in {Google::Cloud::Dialogflow::Cx::V3beta1::Environment#update_time `update_time`}.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class LookupEnvironmentHistoryResponse; end
        end
      end
    end
  end
end