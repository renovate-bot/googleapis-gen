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
  module Devtools
    module Clouderrorreporting
      module V1beta1
        # Specifies a set of `ErrorGroupStats` to return.
        # @!attribute [rw] project_name
        #   @return [String]
        #     Required. The resource name of the Google Cloud Platform project. Written
        #     as `projects/{projectID}` or `projects/{projectNumber}`, where `{projectID}`
        #     and `{projectNumber}` can be found in the
        #     [Google Cloud Console](https://support.google.com/cloud/answer/6158840).
        #
        #     Examples: `projects/my-project-123`, `projects/5551234`.
        # @!attribute [rw] group_id
        #   @return [Array<String>]
        #     Optional. List all <code>ErrorGroupStats</code> with these IDs.
        # @!attribute [rw] service_filter
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ServiceContextFilter]
        #     Optional. List only <code>ErrorGroupStats</code> which belong to a service
        #     context that matches the filter.
        #     Data for all service contexts is returned if this field is not specified.
        # @!attribute [rw] time_range
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::QueryTimeRange]
        #     Optional. List data for the given time range.
        #     If not set, a default time range is used. The field
        #     <code>time_range_begin</code> in the response will specify the beginning
        #     of this time range.
        #     Only <code>ErrorGroupStats</code> with a non-zero count in the given time
        #     range are returned, unless the request contains an explicit
        #     <code>group_id</code> list. If a <code>group_id</code> list is given, also
        #     <code>ErrorGroupStats</code> with zero occurrences are returned.
        # @!attribute [rw] timed_count_duration
        #   @return [Google::Protobuf::Duration]
        #     Optional. The preferred duration for a single returned `TimedCount`.
        #     If not set, no timed counts are returned.
        # @!attribute [rw] alignment
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::TimedCountAlignment]
        #     Optional. The alignment of the timed counts to be returned.
        #     Default is `ALIGNMENT_EQUAL_AT_END`.
        # @!attribute [rw] alignment_time
        #   @return [Google::Protobuf::Timestamp]
        #     Optional. Time where the timed counts shall be aligned if rounded
        #     alignment is chosen. Default is 00:00 UTC.
        # @!attribute [rw] order
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ErrorGroupOrder]
        #     Optional. The sort order in which the results are returned.
        #     Default is `COUNT_DESC`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of results to return per response.
        #     Default is 20.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A `next_page_token` provided by a previous response. To view
        #     additional results, pass this token along with the identical query
        #     parameters as the first request.
        class ListGroupStatsRequest; end

        # Contains a set of requested error group stats.
        # @!attribute [rw] error_group_stats
        #   @return [Array<Google::Devtools::Clouderrorreporting::V1beta1::ErrorGroupStats>]
        #     The error group stats which match the given request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     If non-empty, more results are available.
        #     Pass this token, along with the same query parameters as the first
        #     request, to view the next page of results.
        # @!attribute [rw] time_range_begin
        #   @return [Google::Protobuf::Timestamp]
        #     The timestamp specifies the start time to which the request was restricted.
        #     The start time is set based on the requested time range. It may be adjusted
        #     to a later time if a project has exceeded the storage quota and older data
        #     has been deleted.
        class ListGroupStatsResponse; end

        # Data extracted for a specific group based on certain filter criteria,
        # such as a given time period and/or service filter.
        # @!attribute [rw] group
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ErrorGroup]
        #     Group data that is independent of the filter criteria.
        # @!attribute [rw] count
        #   @return [Integer]
        #     Approximate total number of events in the given group that match
        #     the filter criteria.
        # @!attribute [rw] affected_users_count
        #   @return [Integer]
        #     Approximate number of affected users in the given group that
        #     match the filter criteria.
        #     Users are distinguished by data in the `ErrorContext` of the
        #     individual error events, such as their login name or their remote
        #     IP address in case of HTTP requests.
        #     The number of affected users can be zero even if the number of
        #     errors is non-zero if no data was provided from which the
        #     affected user could be deduced.
        #     Users are counted based on data in the request
        #     context that was provided in the error report. If more users are
        #     implicitly affected, such as due to a crash of the whole service,
        #     this is not reflected here.
        # @!attribute [rw] timed_counts
        #   @return [Array<Google::Devtools::Clouderrorreporting::V1beta1::TimedCount>]
        #     Approximate number of occurrences over time.
        #     Timed counts returned by ListGroups are guaranteed to be:
        #
        #     * Inside the requested time interval
        #     * Non-overlapping, and
        #     * Ordered by ascending time.
        # @!attribute [rw] first_seen_time
        #   @return [Google::Protobuf::Timestamp]
        #     Approximate first occurrence that was ever seen for this group
        #     and which matches the given filter criteria, ignoring the
        #     time_range that was specified in the request.
        # @!attribute [rw] last_seen_time
        #   @return [Google::Protobuf::Timestamp]
        #     Approximate last occurrence that was ever seen for this group and
        #     which matches the given filter criteria, ignoring the time_range
        #     that was specified in the request.
        # @!attribute [rw] affected_services
        #   @return [Array<Google::Devtools::Clouderrorreporting::V1beta1::ServiceContext>]
        #     Service contexts with a non-zero error count for the given filter
        #     criteria. This list can be truncated if multiple services are affected.
        #     Refer to `num_affected_services` for the total count.
        # @!attribute [rw] num_affected_services
        #   @return [Integer]
        #     The total number of services with a non-zero error count for the given
        #     filter criteria.
        # @!attribute [rw] representative
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ErrorEvent]
        #     An arbitrary event that is chosen as representative for the whole group.
        #     The representative event is intended to be used as a quick preview for
        #     the whole group. Events in the group are usually sufficiently similar
        #     to each other such that showing an arbitrary representative provides
        #     insight into the characteristics of the group as a whole.
        class ErrorGroupStats; end

        # The number of errors in a given time period.
        # All numbers are approximate since the error events are sampled
        # before counting them.
        # @!attribute [rw] count
        #   @return [Integer]
        #     Approximate number of occurrences in the given time period.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     Start of the time period to which `count` refers (included).
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     End of the time period to which `count` refers (excluded).
        class TimedCount; end

        # Specifies a set of error events to return.
        # @!attribute [rw] project_name
        #   @return [String]
        #     Required. The resource name of the Google Cloud Platform project. Written
        #     as `projects/{projectID}`, where `{projectID}` is the
        #     [Google Cloud Platform project
        #     ID](https://support.google.com/cloud/answer/6158840).
        #
        #     Example: `projects/my-project-123`.
        # @!attribute [rw] group_id
        #   @return [String]
        #     Required. The group for which events shall be returned.
        # @!attribute [rw] service_filter
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ServiceContextFilter]
        #     Optional. List only ErrorGroups which belong to a service context that
        #     matches the filter.
        #     Data for all service contexts is returned if this field is not specified.
        # @!attribute [rw] time_range
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::QueryTimeRange]
        #     Optional. List only data for the given time range.
        #     If not set a default time range is used. The field time_range_begin
        #     in the response will specify the beginning of this time range.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of results to return per response.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A `next_page_token` provided by a previous response.
        class ListEventsRequest; end

        # Contains a set of requested error events.
        # @!attribute [rw] error_events
        #   @return [Array<Google::Devtools::Clouderrorreporting::V1beta1::ErrorEvent>]
        #     The error events which match the given request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     If non-empty, more results are available.
        #     Pass this token, along with the same query parameters as the first
        #     request, to view the next page of results.
        # @!attribute [rw] time_range_begin
        #   @return [Google::Protobuf::Timestamp]
        #     The timestamp specifies the start time to which the request was restricted.
        class ListEventsResponse; end

        # Requests might be rejected or the resulting timed count durations might be
        # adjusted for lower durations.
        # @!attribute [rw] period
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::QueryTimeRange::Period]
        #     Restricts the query to the specified time range.
        class QueryTimeRange
          # The supported time ranges.
          module Period
            # Do not use.
            PERIOD_UNSPECIFIED = 0

            # Retrieve data for the last hour.
            # Recommended minimum timed count duration: 1 min.
            PERIOD_1_HOUR = 1

            # Retrieve data for the last 6 hours.
            # Recommended minimum timed count duration: 10 min.
            PERIOD_6_HOURS = 2

            # Retrieve data for the last day.
            # Recommended minimum timed count duration: 1 hour.
            PERIOD_1_DAY = 3

            # Retrieve data for the last week.
            # Recommended minimum timed count duration: 6 hours.
            PERIOD_1_WEEK = 4

            # Retrieve data for the last 30 days.
            # Recommended minimum timed count duration: 1 day.
            PERIOD_30_DAYS = 5
          end
        end

        # Specifies criteria for filtering a subset of service contexts.
        # The fields in the filter correspond to the fields in `ServiceContext`.
        # Only exact, case-sensitive matches are supported.
        # If a field is unset or empty, it matches arbitrary values.
        # @!attribute [rw] service
        #   @return [String]
        #     Optional. The exact value to match against
        #     [`ServiceContext.service`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.service).
        # @!attribute [rw] version
        #   @return [String]
        #     Optional. The exact value to match against
        #     [`ServiceContext.version`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.version).
        # @!attribute [rw] resource_type
        #   @return [String]
        #     Optional. The exact value to match against
        #     [`ServiceContext.resource_type`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.resource_type).
        class ServiceContextFilter; end

        # Deletes all events in the project.
        # @!attribute [rw] project_name
        #   @return [String]
        #     Required. The resource name of the Google Cloud Platform project. Written
        #     as `projects/{projectID}`, where `{projectID}` is the
        #     [Google Cloud Platform project
        #     ID](https://support.google.com/cloud/answer/6158840).
        #
        #     Example: `projects/my-project-123`.
        class DeleteEventsRequest; end

        # Response message for deleting error events.
        class DeleteEventsResponse; end

        # A sorting order of error groups.
        module ErrorGroupOrder
          # No group order specified.
          GROUP_ORDER_UNSPECIFIED = 0

          # Total count of errors in the given time window in descending order.
          COUNT_DESC = 1

          # Timestamp when the group was last seen in the given time window
          # in descending order.
          LAST_SEEN_DESC = 2

          # Timestamp when the group was created in descending order.
          CREATED_DESC = 3

          # Number of affected users in the given time window in descending order.
          AFFECTED_USERS_DESC = 4
        end

        # Specifies how the time periods of error group counts are aligned.
        module TimedCountAlignment
          # No alignment specified.
          ERROR_COUNT_ALIGNMENT_UNSPECIFIED = 0

          # The time periods shall be consecutive, have width equal to the
          # requested duration, and be aligned at the `alignment_time` provided in
          # the request.
          # The `alignment_time` does not have to be inside the query period but
          # even if it is outside, only time periods are returned which overlap
          # with the query period.
          # A rounded alignment will typically result in a
          # different size of the first or the last time period.
          ALIGNMENT_EQUAL_ROUNDED = 1

          # The time periods shall be consecutive, have width equal to the
          # requested duration, and be aligned at the end of the requested time
          # period. This can result in a different size of the
          # first time period.
          ALIGNMENT_EQUAL_AT_END = 2
        end
      end
    end
  end
end