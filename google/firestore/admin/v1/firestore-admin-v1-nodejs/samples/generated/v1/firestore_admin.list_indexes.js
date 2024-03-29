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

function main(parent) {
  // [START firestore_v1_generated_FirestoreAdmin_ListIndexes_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. A parent name of the form
   *  `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
   */
  // const parent = 'abc123'
  /**
   *  The filter to apply to list results.
   */
  // const filter = 'abc123'
  /**
   *  The number of results to return.
   */
  // const pageSize = 1234
  /**
   *  A page token, returned from a previous call to
   *  FirestoreAdmin.ListIndexes google.firestore.admin.v1.FirestoreAdmin.ListIndexes, that may be used to get the next
   *  page of results.
   */
  // const pageToken = 'abc123'

  // Imports the Admin library
  const {FirestoreAdminClient} = require('@google-cloud/firestore-admin').v1;

  // Instantiates a client
  const adminClient = new FirestoreAdminClient();

  async function callListIndexes() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await adminClient.listIndexesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListIndexes();
  // [END firestore_v1_generated_FirestoreAdmin_ListIndexes_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
