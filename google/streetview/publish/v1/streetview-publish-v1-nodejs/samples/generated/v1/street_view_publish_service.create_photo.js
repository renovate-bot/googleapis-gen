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
  // [START publish_create_photo_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Photo to create.
   */
  // const photo = ''

  // Imports the Publish library
  const {StreetViewPublishServiceClient} = require('publish').v1;

  // Instantiates a client
  const publishClient = new StreetViewPublishServiceClient();

  async function createPhoto() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await publishClient.createPhoto(request);
    console.log(response);
  }

  createPhoto();
  // [END publish_create_photo_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
