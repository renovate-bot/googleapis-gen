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
  // [START publish_batch_get_photos_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP GET
   *  requests require the following syntax for the URL query parameter:
   *  `photoIds=<id1>&photoIds=<id2>&...`.
   */
  // const photoIds = 'abc123'
  /**
   *  Specifies if a download URL for the photo bytes should be returned in the
   *  Photo response.
   */
  // const view = ''
  /**
   *  The BCP-47 language code, such as "en-US" or "sr-Latn". For more
   *  information, see
   *  http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
   *  If language_code is unspecified, the user's language preference for Google
   *  services is used.
   */
  // const languageCode = 'abc123'

  // Imports the Publish library
  const {StreetViewPublishServiceClient} = require('publish').v1;

  // Instantiates a client
  const publishClient = new StreetViewPublishServiceClient();

  async function batchGetPhotos() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await publishClient.batchGetPhotos(request);
    console.log(response);
  }

  batchGetPhotos();
  // [END publish_batch_get_photos_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
