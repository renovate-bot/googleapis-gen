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
    module Bigquery
      module Storage
        module V1beta1
          # Information about a single data stream within a read session.
          # @!attribute [rw] name
          #   @return [String]
          #     Name of the stream, in the form
          #     `projects/{project_id}/locations/{location}/streams/{stream_id}`.
          class Stream; end

          # Expresses a point within a given stream using an offset position.
          # @!attribute [rw] stream
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Stream]
          #     Identifier for a given Stream.
          # @!attribute [rw] offset
          #   @return [Integer]
          #     Position in the stream.
          class StreamPosition; end

          # Information returned from a `CreateReadSession` request.
          # @!attribute [rw] name
          #   @return [String]
          #     Unique identifier for the session, in the form
          #     `projects/{project_id}/locations/{location}/sessions/{session_id}`.
          # @!attribute [rw] expire_time
          #   @return [Google::Protobuf::Timestamp]
          #     Time at which the session becomes invalid. After this time, subsequent
          #     requests to read this Session will return errors.
          # @!attribute [rw] avro_schema
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::AvroSchema]
          #     Avro schema.
          # @!attribute [rw] arrow_schema
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ArrowSchema]
          #     Arrow schema.
          # @!attribute [rw] streams
          #   @return [Array<Google::Cloud::Bigquery::Storage::V1beta1::Stream>]
          #     Streams associated with this session.
          # @!attribute [rw] table_reference
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::TableReference]
          #     Table that this ReadSession is reading from.
          # @!attribute [rw] table_modifiers
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::TableModifiers]
          #     Any modifiers which are applied when reading from the specified table.
          # @!attribute [rw] sharding_strategy
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ShardingStrategy]
          #     The strategy to use for distributing data among the streams.
          class ReadSession; end

          # Creates a new read session, which may include additional options such as
          # requested parallelism, projection filters and constraints.
          # @!attribute [rw] table_reference
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::TableReference]
          #     Required. Reference to the table to read.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. String of the form `projects/{project_id}` indicating the
          #     project this ReadSession is associated with. This is the project that will
          #     be billed for usage.
          # @!attribute [rw] table_modifiers
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::TableModifiers]
          #     Any modifiers to the Table (e.g. snapshot timestamp).
          # @!attribute [rw] requested_streams
          #   @return [Integer]
          #     Initial number of streams. If unset or 0, we will
          #     provide a value of streams so as to produce reasonable throughput. Must be
          #     non-negative. The number of streams may be lower than the requested number,
          #     depending on the amount parallelism that is reasonable for the table and
          #     the maximum amount of parallelism allowed by the system.
          #
          #     Streams must be read starting from offset 0.
          # @!attribute [rw] read_options
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::TableReadOptions]
          #     Read options for this session (e.g. column selection, filters).
          # @!attribute [rw] format
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::DataFormat]
          #     Data output format. Currently default to Avro.
          # @!attribute [rw] sharding_strategy
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ShardingStrategy]
          #     The strategy to use for distributing data among multiple streams. Currently
          #     defaults to liquid sharding.
          class CreateReadSessionRequest; end

          # Requesting row data via `ReadRows` must provide Stream position information.
          # @!attribute [rw] read_position
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::StreamPosition]
          #     Required. Identifier of the position in the stream to start reading from.
          #     The offset requested must be less than the last row read from ReadRows.
          #     Requesting a larger offset is undefined.
          class ReadRowsRequest; end

          # Progress information for a given Stream.
          # @!attribute [rw] estimated_row_count
          #   @return [Integer]
          #     Number of estimated rows in the current stream. May change over time as
          #     different readers in the stream progress at rates which are relatively fast
          #     or slow.
          # @!attribute [rw] fraction_consumed
          #   @return [Float]
          #     A value in the range [0.0, 1.0] that represents the fraction of rows
          #     assigned to this stream that have been processed by the server. In the
          #     presence of read filters, the server may process more rows than it returns,
          #     so this value reflects progress through the pre-filtering rows.
          #
          #     This value is only populated for sessions created through the BALANCED
          #     sharding strategy.
          # @!attribute [rw] progress
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Progress]
          #     Represents the progress of the current stream.
          # @!attribute [rw] is_splittable
          #   @return [true, false]
          #     Whether this stream can be split. For sessions that use the LIQUID sharding
          #     strategy, this value is always false. For BALANCED sessions, this value is
          #     false when enough data have been read such that no more splits are possible
          #     at that point or beyond. For small tables or streams that are the result of
          #     a chain of splits, this value may never be true.
          class StreamStatus; end

          # @!attribute [rw] at_response_start
          #   @return [Float]
          #     The fraction of rows assigned to the stream that have been processed by the
          #     server so far, not including the rows in the current response message.
          #
          #     This value, along with `at_response_end`, can be used to interpolate the
          #     progress made as the rows in the message are being processed using the
          #     following formula: `at_response_start + (at_response_end -
          #     at_response_start) * rows_processed_from_response / rows_in_response`.
          #
          #     Note that if a filter is provided, the `at_response_end` value of the
          #     previous response may not necessarily be equal to the `at_response_start`
          #     value of the current response.
          # @!attribute [rw] at_response_end
          #   @return [Float]
          #     Similar to `at_response_start`, except that this value includes the rows in
          #     the current response.
          class Progress; end

          # Information on if the current connection is being throttled.
          # @!attribute [rw] throttle_percent
          #   @return [Integer]
          #     How much this connection is being throttled.
          #     0 is no throttling, 100 is completely throttled.
          class ThrottleStatus; end

          # Response from calling `ReadRows` may include row data, progress and
          # throttling information.
          # @!attribute [rw] avro_rows
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::AvroRows]
          #     Serialized row data in AVRO format.
          # @!attribute [rw] arrow_record_batch
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ArrowRecordBatch]
          #     Serialized row data in Arrow RecordBatch format.
          # @!attribute [rw] row_count
          #   @return [Integer]
          #     Number of serialized rows in the rows block. This value is recorded here,
          #     in addition to the row_count values in the output-specific messages in
          #     `rows`, so that code which needs to record progress through the stream can
          #     do so in an output format-independent way.
          # @!attribute [rw] status
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::StreamStatus]
          #     Estimated stream statistics.
          # @!attribute [rw] throttle_status
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ThrottleStatus]
          #     Throttling status. If unset, the latest response still describes
          #     the current throttling status.
          class ReadRowsResponse; end

          # Information needed to request additional streams for an established read
          # session.
          # @!attribute [rw] session
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::ReadSession]
          #     Required. Must be a non-expired session obtained from a call to
          #     CreateReadSession. Only the name field needs to be set.
          # @!attribute [rw] requested_streams
          #   @return [Integer]
          #     Required. Number of new streams requested. Must be positive.
          #     Number of added streams may be less than this, see CreateReadSessionRequest
          #     for more information.
          class BatchCreateReadSessionStreamsRequest; end

          # The response from `BatchCreateReadSessionStreams` returns the stream
          # identifiers for the newly created streams.
          # @!attribute [rw] streams
          #   @return [Array<Google::Cloud::Bigquery::Storage::V1beta1::Stream>]
          #     Newly added streams.
          class BatchCreateReadSessionStreamsResponse; end

          # Request information for invoking `FinalizeStream`.
          # @!attribute [rw] stream
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Stream]
          #     Required. Stream to finalize.
          class FinalizeStreamRequest; end

          # Request information for `SplitReadStream`.
          # @!attribute [rw] original_stream
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Stream]
          #     Required. Stream to split.
          # @!attribute [rw] fraction
          #   @return [Float]
          #     A value in the range (0.0, 1.0) that specifies the fractional point at
          #     which the original stream should be split. The actual split point is
          #     evaluated on pre-filtered rows, so if a filter is provided, then there is
          #     no guarantee that the division of the rows between the new child streams
          #     will be proportional to this fractional value. Additionally, because the
          #     server-side unit for assigning data is collections of rows, this fraction
          #     will always map to to a data storage boundary on the server side.
          class SplitReadStreamRequest; end

          # Response from `SplitReadStream`.
          # @!attribute [rw] primary_stream
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Stream]
          #     Primary stream, which contains the beginning portion of
          #     |original_stream|. An empty value indicates that the original stream can no
          #     longer be split.
          # @!attribute [rw] remainder_stream
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::Stream]
          #     Remainder stream, which contains the tail of |original_stream|. An empty
          #     value indicates that the original stream can no longer be split.
          class SplitReadStreamResponse; end

          # Data format for input or output data.
          module DataFormat
            # Data format is unspecified.
            DATA_FORMAT_UNSPECIFIED = 0

            # Avro is a standard open source row based file format.
            # See https://avro.apache.org/ for more details.
            AVRO = 1

            ARROW = 3
          end

          # Strategy for distributing data among multiple streams in a read session.
          module ShardingStrategy
            # Same as LIQUID.
            SHARDING_STRATEGY_UNSPECIFIED = 0

            # Assigns data to each stream based on the client's read rate. The faster the
            # client reads from a stream, the more data is assigned to the stream. In
            # this strategy, it's possible to read all data from a single stream even if
            # there are other streams present.
            LIQUID = 1

            # Assigns data to each stream such that roughly the same number of rows can
            # be read from each stream. Because the server-side unit for assigning data
            # is collections of rows, the API does not guarantee that each stream will
            # return the same number or rows. Additionally, the limits are enforced based
            # on the number of pre-filtering rows, so some filters can lead to lopsided
            # assignments.
            BALANCED = 2
          end
        end
      end
    end
  end
end