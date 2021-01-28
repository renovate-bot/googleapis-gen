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
    module Pubsublite
      module V1
        # The first streaming request that must be sent on a newly-opened stream. The
        # client must wait for the response before sending subsequent requests on the
        # stream.
        # @!attribute [rw] subscription
        #   @return [String]
        #     The subscription for which to manage committed cursors.
        # @!attribute [rw] partition
        #   @return [Integer]
        #     The partition for which to manage committed cursors. Partitions are zero
        #     indexed, so `partition` must be in the range [0, topic.num_partitions).
        class InitialCommitCursorRequest; end

        # Response to an InitialCommitCursorRequest.
        class InitialCommitCursorResponse; end

        # Streaming request to update the committed cursor. Subsequent
        # SequencedCommitCursorRequests override outstanding ones.
        # @!attribute [rw] cursor
        #   @return [Google::Cloud::Pubsublite::V1::Cursor]
        #     The new value for the committed cursor.
        class SequencedCommitCursorRequest; end

        # Response to a SequencedCommitCursorRequest.
        # @!attribute [rw] acknowledged_commits
        #   @return [Integer]
        #     The number of outstanding SequencedCommitCursorRequests acknowledged by
        #     this response. Note that SequencedCommitCursorRequests are acknowledged in
        #     the order that they are received.
        class SequencedCommitCursorResponse; end

        # A request sent from the client to the server on a stream.
        # @!attribute [rw] initial
        #   @return [Google::Cloud::Pubsublite::V1::InitialCommitCursorRequest]
        #     Initial request on the stream.
        # @!attribute [rw] commit
        #   @return [Google::Cloud::Pubsublite::V1::SequencedCommitCursorRequest]
        #     Request to commit a new cursor value.
        class StreamingCommitCursorRequest; end

        # Response to a StreamingCommitCursorRequest.
        # @!attribute [rw] initial
        #   @return [Google::Cloud::Pubsublite::V1::InitialCommitCursorResponse]
        #     Initial response on the stream.
        # @!attribute [rw] commit
        #   @return [Google::Cloud::Pubsublite::V1::SequencedCommitCursorResponse]
        #     Response to committing a new cursor value.
        class StreamingCommitCursorResponse; end

        # Request for CommitCursor.
        # @!attribute [rw] subscription
        #   @return [String]
        #     The subscription for which to update the cursor.
        # @!attribute [rw] partition
        #   @return [Integer]
        #     The partition for which to update the cursor. Partitions are zero indexed,
        #     so `partition` must be in the range [0, topic.num_partitions).
        # @!attribute [rw] cursor
        #   @return [Google::Cloud::Pubsublite::V1::Cursor]
        #     The new value for the committed cursor.
        class CommitCursorRequest; end

        # Response for CommitCursor.
        class CommitCursorResponse; end

        # Request for ListPartitionCursors.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The subscription for which to retrieve cursors.
        #     Structured like
        #     `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of cursors to return. The service may return fewer than
        #     this value.
        #     If unset or zero, all cursors for the parent will be returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListPartitionCursors` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListPartitionCursors`
        #     must match the call that provided the page token.
        class ListPartitionCursorsRequest; end

        # A pair of a Cursor and the partition it is for.
        # @!attribute [rw] partition
        #   @return [Integer]
        #     The partition this is for.
        # @!attribute [rw] cursor
        #   @return [Google::Cloud::Pubsublite::V1::Cursor]
        #     The value of the cursor.
        class PartitionCursor; end

        # Response for ListPartitionCursors
        # @!attribute [rw] partition_cursors
        #   @return [Array<Google::Cloud::Pubsublite::V1::PartitionCursor>]
        #     The partition cursors from this request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListPartitionCursorsResponse; end
      end
    end
  end
end