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

function main(parent, previewSettings) {
  // [START actions_v2_generated_ActionsSdk_WritePreview_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent resource name in the format `projects/{project}`. The
   *  `{project}` is the cloud project ID associated with the project.
   */
  // const parent = 'abc123'
  /**
   *  List of files sent to the server at a time. This is a list of config
   *  files or data files.
   *  1. The first request must be a ConfigFiles.
   *  2. The first request must have a ConfigFile with 'settings'.
   *  3. The first request must have a ConfigFile with 'manifest'.
   *  4. The webhook ConfigFile corresponding to inline cloud function must be
   *     streamed before the DataFile corresponding to its source code.
   */
  // const files = ''
  /**
   *  Content sourced from the project draft.
   */
  // const draft = ''
  /**
   *  Content sourced from the an exiting version.
   */
  // const submittedVersion = ''
  /**
   *  Required. The settings for updating the user's preview.
   */
  // const previewSettings = ''

  // Imports the Sdk library
  const {ActionsSdkClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsSdkClient();

  async function writePreview() {
    // Construct request
    const request = {
      parent,
      previewSettings,
    };

    // Run request
    const stream = await sdkClient.writePreview((response) => console.log(response));
    stream.write(request);
    stream.end();
  }

  writePreview();
  // [END actions_v2_generated_ActionsSdk_WritePreview_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
