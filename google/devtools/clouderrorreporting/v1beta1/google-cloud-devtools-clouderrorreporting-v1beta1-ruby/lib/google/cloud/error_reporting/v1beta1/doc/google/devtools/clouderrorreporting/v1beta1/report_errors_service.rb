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
        # A request for reporting an individual error event.
        # @!attribute [rw] project_name
        #   @return [String]
        #     Required. The resource name of the Google Cloud Platform project. Written
        #     as `projects/{projectId}`, where `{projectId}` is the
        #     [Google Cloud Platform project
        #     ID](https://support.google.com/cloud/answer/6158840).
        #
        #     Example: // `projects/my-project-123`.
        # @!attribute [rw] event
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ReportedErrorEvent]
        #     Required. The error event to be reported.
        class ReportErrorEventRequest; end

        # Response for reporting an individual error event.
        # Data may be added to this message in the future.
        class ReportErrorEventResponse; end

        # An error event which is reported to the Error Reporting system.
        # @!attribute [rw] event_time
        #   @return [Google::Protobuf::Timestamp]
        #     Optional. Time when the event occurred.
        #     If not provided, the time when the event was received by the
        #     Error Reporting system will be used.
        # @!attribute [rw] service_context
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ServiceContext]
        #     Required. The service context in which this error has occurred.
        # @!attribute [rw] message
        #   @return [String]
        #     Required. The error message.
        #     If no `context.reportLocation` is provided, the message must contain a
        #     header (typically consisting of the exception type name and an error
        #     message) and an exception stack trace in one of the supported programming
        #     languages and formats.
        #     Supported languages are Java, Python, JavaScript, Ruby, C#, PHP, and Go.
        #     Supported stack trace formats are:
        #
        #     * **Java**: Must be the return value of
        #       [`Throwable.printStackTrace()`](https://docs.oracle.com/javase/7/docs/api/java/lang/Throwable.html#printStackTrace%28%29).
        #     * **Python**: Must be the return value of
        #       [`traceback.format_exc()`](https://docs.python.org/2/library/traceback.html#traceback.format_exc).
        #     * **JavaScript**: Must be the value of
        #       [`error.stack`](https://github.com/v8/v8/wiki/Stack-Trace-API) as returned
        #       by V8.
        #     * **Ruby**: Must contain frames returned by
        #       [`Exception.backtrace`](https://ruby-doc.org/core-2.2.0/Exception.html#method-i-backtrace).
        #     * **C#**: Must be the return value of
        #       [`Exception.ToString()`](https://msdn.microsoft.com/en-us/library/system.exception.tostring.aspx).
        #     * **PHP**: Must start with `PHP (Notice|Parse error|Fatal error|Warning)`
        #       and contain the result of
        #       [`(string)$exception`](http://php.net/manual/en/exception.tostring.php).
        #     * **Go**: Must be the return value of
        #       [`runtime.Stack()`](https://golang.org/pkg/runtime/debug/#Stack).
        # @!attribute [rw] context
        #   @return [Google::Devtools::Clouderrorreporting::V1beta1::ErrorContext]
        #     Optional. A description of the context in which the error occurred.
        class ReportedErrorEvent; end
      end
    end
  end
end