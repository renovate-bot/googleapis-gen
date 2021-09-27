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
  // [START streetviewpublish_v1_generated_StreetViewPublishService_UpdatePhoto_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. [Photo][google.streetview.publish.v1.Photo] object containing the
   *  new metadata.
   */
  // const photo = ''
  /**
   *  Mask that identifies fields on the photo metadata to update.
   *  If not present, the old [Photo][google.streetview.publish.v1.Photo]
   *  metadata is entirely replaced with the
   *  new [Photo][google.streetview.publish.v1.Photo] metadata in this request.
   *  The update fails if invalid fields are specified. Multiple fields can be
   *  specified in a comma-delimited list.
   *  The following fields are valid:
   *  * `pose.heading`
   *  * `pose.latLngPair`
   *  * `pose.pitch`
   *  * `pose.roll`
   *  * `pose.level`
   *  * `pose.altitude`
   *  * `connections`
   *  * `places`
   *  <aside class="note"><b>Note:</b>  When
   *  [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
   *  contains repeated fields, the entire set of repeated values get replaced
   *  with the new contents. For example, if
   *  [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
   *  contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
   *  all connections are removed.</aside>
   */
  // const updateMask = ''

  // Imports the Publish library
  const {StreetViewPublishServiceClient} = require('publish').v1;

  // Instantiates a client
  const publishClient = new StreetViewPublishServiceClient();

  async function updatePhoto() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await publishClient.updatePhoto(request);
    console.log(response);
  }

  updatePhoto();
  // [END streetviewpublish_v1_generated_StreetViewPublishService_UpdatePhoto_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
