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

function main(backup, updateMask) {
  // [START file_v1_generated_CloudFilestoreManager_UpdateBackup_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. A backup resource google.cloud.filestore.v1.Backup 
   */
  // const backup = {}
  /**
   *  Required. Mask of fields to update.  At least one path must be supplied in
   *  this field.
   */
  // const updateMask = {}

  // Imports the Filestore library
  const {CloudFilestoreManagerClient} = require('@google-cloud/filestore').v1;

  // Instantiates a client
  const filestoreClient = new CloudFilestoreManagerClient();

  async function callUpdateBackup() {
    // Construct request
    const request = {
      backup,
      updateMask,
    };

    // Run request
    const [operation] = await filestoreClient.updateBackup(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callUpdateBackup();
  // [END file_v1_generated_CloudFilestoreManager_UpdateBackup_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
