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

function main(buildEvent, projectId) {
  // [START buildeventservice_v1_generated_PublishBuildEvent_PublishLifecycleEvent_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The interactivity of this build.
   */
  // const serviceLevel = ''
  /**
   *  Required. The lifecycle build event. If this is a build tool event, the RPC
   *  will fail with INVALID_REQUEST.
   */
  // const buildEvent = ''
  /**
   *  If the next event for this build or invocation (depending on the event
   *  type) hasn't been published after this duration from when {build_event}
   *  is written to BES, consider this stream expired. If this field is not set,
   *  BES backend will use its own default value.
   */
  // const streamTimeout = ''
  /**
   *  Additional information about a build request. These are define by the event
   *  publishers, and the Build Event Service does not validate or interpret
   *  them. They are used while notifying internal systems of new builds and
   *  invocations if the OrderedBuildEvent.event type is
   *  BuildEnqueued/InvocationAttemptStarted.
   */
  // const notificationKeywords = 'abc123'
  /**
   *  Required. The project this build is associated with.
   *  This should match the project used for the initial call to
   *  PublishLifecycleEvent (containing a BuildEnqueued message).
   */
  // const projectId = 'abc123'

  // Imports the Build library
  const {PublishBuildEventClient} = require('build').v1;

  // Instantiates a client
  const buildClient = new PublishBuildEventClient();

  async function publishLifecycleEvent() {
    // Construct request
    const request = {
      buildEvent,
      projectId,
    };

    // Run request
    const response = await buildClient.publishLifecycleEvent(request);
    console.log(response);
  }

  publishLifecycleEvent();
  // [END buildeventservice_v1_generated_PublishBuildEvent_PublishLifecycleEvent_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
