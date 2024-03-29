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

function main(resourceName) {
  // [START googleads_v8_generated_MediaFileService_GetMediaFile_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the media file to fetch.
   */
  // const resourceName = 'abc123'

  // Imports the Googleads library
  const {MediaFileServiceClient} = require('google-ads').v8;

  // Instantiates a client
  const googleadsClient = new MediaFileServiceClient();

  async function callGetMediaFile() {
    // Construct request
    const request = {
      resourceName,
    };

    // Run request
    const response = await googleadsClient.getMediaFile(request);
    console.log(response);
  }

  callGetMediaFile();
  // [END googleads_v8_generated_MediaFileService_GetMediaFile_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
