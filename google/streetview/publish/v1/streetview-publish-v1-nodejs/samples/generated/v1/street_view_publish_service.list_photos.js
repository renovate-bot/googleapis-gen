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
  // [START streetviewpublish_v1_generated_StreetViewPublishService_ListPhotos_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Specifies if a download URL for the photos bytes should be returned in the
   *  Photos response.
   */
  // const view = ''
  /**
   *  The maximum number of photos to return.
   *  `pageSize` must be non-negative. If `pageSize` is zero or is not provided,
   *  the default page size of 100 is used.
   *  The number of photos returned in the response may be less than `pageSize`
   *  if the number of photos that belong to the user is less than `pageSize`.
   */
  // const pageSize = 1234
  /**
   *  The
   *  [nextPageToken][google.streetview.publish.v1.ListPhotosResponse.next_page_token]
   *  value returned from a previous
   *  [ListPhotos][google.streetview.publish.v1.StreetViewPublishService.ListPhotos]
   *  request, if any.
   */
  // const pageToken = 'abc123'
  /**
   *  The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
   *  The only filter supported at the moment is `placeId`.
   */
  // const filter = 'abc123'
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

  async function listPhotos() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await publishClient.listPhotosAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listPhotos();
  // [END streetviewpublish_v1_generated_StreetViewPublishService_ListPhotos_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
