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

function main(customerId, operations) {
  // [START googleads_v7_generated_CampaignSharedSetService_MutateCampaignSharedSets_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The ID of the customer whose campaign shared sets are being modified.
   */
  // const customerId = 'abc123'
  /**
   *  Required. The list of operations to perform on individual campaign shared sets.
   */
  // const operations = 1234
  /**
   *  If true, successful operations will be carried out and invalid
   *  operations will return errors. If false, all operations will be carried
   *  out in one transaction if and only if they are all valid.
   *  Default is false.
   */
  // const partialFailure = true
  /**
   *  If true, the request is validated but not executed. Only errors are
   *  returned, not results.
   */
  // const validateOnly = true
  /**
   *  The response content type setting. Determines whether the mutable resource
   *  or just the resource name should be returned post mutation.
   */
  // const responseContentType = {}

  // Imports the Googleads library
  const {CampaignSharedSetServiceClient} = require('google-ads').v7;

  // Instantiates a client
  const googleadsClient = new CampaignSharedSetServiceClient();

  async function callMutateCampaignSharedSets() {
    // Construct request
    const request = {
      customerId,
      operations,
    };

    // Run request
    const response = await googleadsClient.mutateCampaignSharedSets(request);
    console.log(response);
  }

  callMutateCampaignSharedSets();
  // [END googleads_v7_generated_CampaignSharedSetService_MutateCampaignSharedSets_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
