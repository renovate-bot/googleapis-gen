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

function main(name, bucket, updateMask) {
  // [START logging_v2_generated_ConfigServiceV2_UpdateBucket_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The full resource name of the bucket to update.
   *      "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
   *      "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
   *      "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
   *      "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
   *  Example:
   *  `"projects/my-project-id/locations/my-location/buckets/my-bucket-id"`. Also
   *  requires permission "resourcemanager.projects.updateLiens" to set the
   *  locked property
   */
  // const name = 'abc123'
  /**
   *  Required. The updated bucket.
   */
  // const bucket = {}
  /**
   *  Required. Field mask that specifies the fields in `bucket` that need an update. A
   *  bucket field will be overwritten if, and only if, it is in the update
   *  mask. `name` and output only fields cannot be updated.
   *  For a detailed `FieldMask` definition, see
   *  https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
   *  Example: `updateMask=retention_days`.
   */
  // const updateMask = {}

  // Imports the Logging library
  const {ConfigServiceV2Client} = require('@google-cloud/logging').v2;

  // Instantiates a client
  const loggingClient = new ConfigServiceV2Client();

  async function callUpdateBucket() {
    // Construct request
    const request = {
      name,
      bucket,
      updateMask,
    };

    // Run request
    const response = await loggingClient.updateBucket(request);
    console.log(response);
  }

  callUpdateBucket();
  // [END logging_v2_generated_ConfigServiceV2_UpdateBucket_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
