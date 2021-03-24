# frozen_string_literal: true

# Copyright 2021 Google LLC
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
    module Apigeeconnect
      module V1
        # The request for [ListConnections][Management.ListConnections].
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. Parent name of the form:
        #         `projects/{project_number or project_id}/endpoints/{endpoint}`.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of connections to return. The service may return fewer
        #     than this value. If unspecified, at most 100 connections will be returned.
        #     The maximum value is 1000; values above 1000 will be coerced to 1000.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     A page token, received from a previous `ListConnections` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListConnections` must
        #     match the call that provided the page token.
        class ListConnectionsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The response for
        # [ListConnections][Management.ListConnections].
        # @!attribute [rw] connections
        #   @return [::Array<::Google::Cloud::Apigeeconnect::V1::Connection>]
        #     A list of clients.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     A token that can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListConnectionsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # @!attribute [rw] endpoint
        #   @return [::String]
        #     The endpoint that the connection is made against.
        #     Format: `projects/{project_number}/endpoints/{endpoint}`
        # @!attribute [rw] cluster
        #   @return [::Google::Cloud::Apigeeconnect::V1::Cluster]
        #     Cluster information.
        # @!attribute [rw] stream_count
        #   @return [::Integer]
        #     The count of streams.
        class Connection
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # @!attribute [rw] name
        #   @return [::String]
        #     The name of the cluster.
        # @!attribute [rw] region
        #   @return [::String]
        #     The region of the cluster.
        class Cluster
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
