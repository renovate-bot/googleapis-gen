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
    module Websecurityscanner
      module V1alpha
        # A ScanRun is a output-only resource representing an actual run of the scan.
        # @!attribute [rw] name
        #   @return [::String]
        #     The resource name of the ScanRun. The name follows the format of
        #     'projects/\\{projectId}/scanConfigs/\\{scanConfigId}/scanRuns/\\{scanRunId}'.
        #     The ScanRun IDs are generated by the system.
        # @!attribute [rw] execution_state
        #   @return [::Google::Cloud::Websecurityscanner::V1alpha::ScanRun::ExecutionState]
        #     The execution state of the ScanRun.
        # @!attribute [rw] result_state
        #   @return [::Google::Cloud::Websecurityscanner::V1alpha::ScanRun::ResultState]
        #     The result state of the ScanRun. This field is only available after the
        #     execution state reaches "FINISHED".
        # @!attribute [rw] start_time
        #   @return [::Google::Protobuf::Timestamp]
        #     The time at which the ScanRun started.
        # @!attribute [rw] end_time
        #   @return [::Google::Protobuf::Timestamp]
        #     The time at which the ScanRun reached termination state - that the ScanRun
        #     is either finished or stopped by user.
        # @!attribute [rw] urls_crawled_count
        #   @return [::Integer]
        #     The number of URLs crawled during this ScanRun. If the scan is in progress,
        #     the value represents the number of URLs crawled up to now.
        # @!attribute [rw] urls_tested_count
        #   @return [::Integer]
        #     The number of URLs tested during this ScanRun. If the scan is in progress,
        #     the value represents the number of URLs tested up to now. The number of
        #     URLs tested is usually larger than the number URLS crawled because
        #     typically a crawled URL is tested with multiple test payloads.
        # @!attribute [rw] has_vulnerabilities
        #   @return [::Boolean]
        #     Whether the scan run has found any vulnerabilities.
        # @!attribute [rw] progress_percent
        #   @return [::Integer]
        #     The percentage of total completion ranging from 0 to 100.
        #     If the scan is in queue, the value is 0.
        #     If the scan is running, the value ranges from 0 to 100.
        #     If the scan is finished, the value is 100.
        class ScanRun
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # Types of ScanRun execution state.
          module ExecutionState
            # Represents an invalid state caused by internal server error. This value
            # should never be returned.
            EXECUTION_STATE_UNSPECIFIED = 0

            # The scan is waiting in the queue.
            QUEUED = 1

            # The scan is in progress.
            SCANNING = 2

            # The scan is either finished or stopped by user.
            FINISHED = 3
          end

          # Types of ScanRun result state.
          module ResultState
            # Default value. This value is returned when the ScanRun is not yet
            # finished.
            RESULT_STATE_UNSPECIFIED = 0

            # The scan finished without errors.
            SUCCESS = 1

            # The scan finished with errors.
            ERROR = 2

            # The scan was terminated by user.
            KILLED = 3
          end
        end
      end
    end
  end
end
