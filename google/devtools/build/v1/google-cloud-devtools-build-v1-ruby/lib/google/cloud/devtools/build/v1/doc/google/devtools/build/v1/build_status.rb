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
    module Build
      module V1
        # Status used for both invocation attempt and overall build completion.
        # @!attribute [rw] result
        #   @return [Google::Devtools::Build::V1::BuildStatus::Result]
        #     The end result.
        # @!attribute [rw] final_invocation_id
        #   @return [String]
        #     Final invocation ID of the build, if there was one.
        #     This field is only set on a status in BuildFinished event.
        # @!attribute [rw] build_tool_exit_code
        #   @return [Google::Protobuf::Int32Value]
        #     Build tool exit code. Integer value returned by the executed build tool.
        #     Might not be available in some cases, e.g., a build timeout.
        # @!attribute [rw] details
        #   @return [Google::Protobuf::Any]
        #     Fine-grained diagnostic information to complement the status.
        class BuildStatus
          # The end result of the Build.
          module Result
            # Unspecified or unknown.
            UNKNOWN_STATUS = 0

            # Build was successful and tests (if requested) all pass.
            COMMAND_SUCCEEDED = 1

            # Build error and/or test failure.
            COMMAND_FAILED = 2

            # Unable to obtain a result due to input provided by the user.
            USER_ERROR = 3

            # Unable to obtain a result due to a failure within the build system.
            SYSTEM_ERROR = 4

            # Build required too many resources, such as build tool RAM.
            RESOURCE_EXHAUSTED = 5

            # An invocation attempt time exceeded its deadline.
            INVOCATION_DEADLINE_EXCEEDED = 6

            # Build request time exceeded the request_deadline
            REQUEST_DEADLINE_EXCEEDED = 8

            # The build was cancelled by a call to CancelBuild.
            CANCELLED = 7
          end
        end
      end
    end
  end
end