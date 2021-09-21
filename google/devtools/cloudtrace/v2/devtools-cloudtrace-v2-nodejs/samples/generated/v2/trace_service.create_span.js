// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


'use strict';

function main(name, spanId, displayName, startTime, endTime) {
  // [START cloudtrace_create_span_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the span in the following format:
   *      projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
   *  [TRACE_ID] is a unique identifier for a trace within a project;
   *  it is a 32-character hexadecimal encoding of a 16-byte array.
   *  [SPAN_ID] is a unique identifier for a span within a trace; it
   *  is a 16-character hexadecimal encoding of an 8-byte array.
   */
  // const name = 'abc123'
  /**
   *  Required. The [SPAN_ID] portion of the span's resource name.
   */
  // const spanId = 'abc123'
  /**
   *  The [SPAN_ID] of this span's parent span. If this is a root span,
   *  then this field must be empty.
   */
  // const parentSpanId = 'abc123'
  /**
   *  Required. A description of the span's operation (up to 128 bytes).
   *  Stackdriver Trace displays the description in the
   *  Google Cloud Platform Console.
   *  For example, the display name can be a qualified method name or a file name
   *  and a line number where the operation is called. A best practice is to use
   *  the same display name within an application and at the same call point.
   *  This makes it easier to correlate spans in different traces.
   */
  // const displayName = ''
  /**
   *  Required. The start time of the span. On the client side, this is the time kept by
   *  the local machine where the span execution starts. On the server side, this
   *  is the time when the server's application handler starts running.
   */
  // const startTime = ''
  /**
   *  Required. The end time of the span. On the client side, this is the time kept by
   *  the local machine where the span execution ends. On the server side, this
   *  is the time when the server application handler stops running.
   */
  // const endTime = ''
  /**
   *  A set of attributes on the span. You can have up to 32 attributes per
   *  span.
   */
  // const attributes = ''
  /**
   *  Stack trace captured at the start of the span.
   */
  // const stackTrace = ''
  /**
   *  A set of time events. You can have up to 32 annotations and 128 message
   *  events per span.
   */
  // const timeEvents = ''
  /**
   *  Links associated with the span. You can have up to 128 links per Span.
   */
  // const links = ''
  /**
   *  Optional. The final status for this span.
   */
  // const status = ''
  /**
   *  Optional. Set this parameter to indicate whether this span is in
   *  the same process as its parent. If you do not set this parameter,
   *  Stackdriver Trace is unable to take advantage of this helpful
   *  information.
   */
  // const sameProcessAsParentSpan = ''
  /**
   *  Optional. The number of child spans that were generated while this span
   *  was active. If set, allows implementation to detect missing child spans.
   */
  // const childSpanCount = ''
  /**
   *  Optional. Distinguishes between spans generated in a particular context. For example,
   *  two spans with the same name may be distinguished using `CLIENT` (caller)
   *  and `SERVER` (callee) to identify an RPC call.
   */
  // const spanKind = ''

  // Imports the Cloudtrace library
  const {TraceServiceClient} = require('cloudtrace').v2;

  // Instantiates a client
  const cloudtraceClient = new TraceServiceClient();

  async function createSpan() {
    // Construct request
    const request = {
      name,
      spanId,
      displayName,
      startTime,
      endTime,
    };

    // Run request
    const response = await cloudtraceClient.createSpan(request);
    console.log(response);
  }

  createSpan();
  // [END cloudtrace_create_span_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
