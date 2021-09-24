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

function main() {
  // [START sdk_v2_generated_ActionsSdk_ListSampleProjects_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Optional. The maximum number of sample projects to return. The service may return
   *  fewer than this value.
   *  If unspecified, at most 1000 sample projects will be returned. Values above
   *  1000 will be coerced to 1000.
   */
  // const pageSize = 1234
  /**
   *  Optional. A page token, received from a previous 'ListSampleProjects' call.
   *  Provide this to retrieve the subsequent page.
   */
  // const pageToken = 'abc123'

  // Imports the Sdk library
  const {ActionsSdkClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsSdkClient();

  async function listSampleProjects() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await sdkClient.listSampleProjectsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listSampleProjects();
  // [END sdk_v2_generated_ActionsSdk_ListSampleProjects_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
