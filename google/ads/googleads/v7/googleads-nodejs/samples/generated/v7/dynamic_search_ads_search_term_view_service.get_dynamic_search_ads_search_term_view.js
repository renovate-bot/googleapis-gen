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
  // [START googleads_v7_generated_DynamicSearchAdsSearchTermViewService_GetDynamicSearchAdsSearchTermView_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the dynamic search ads search term view to fetch.
   */
  // const resourceName = 'abc123'

  // Imports the Googleads library
  const {DynamicSearchAdsSearchTermViewServiceClient} = require('google-ads').v7;

  // Instantiates a client
  const googleadsClient = new DynamicSearchAdsSearchTermViewServiceClient();

  async function callGetDynamicSearchAdsSearchTermView() {
    // Construct request
    const request = {
      resourceName,
    };

    // Run request
    const response = await googleadsClient.getDynamicSearchAdsSearchTermView(request);
    console.log(response);
  }

  callGetDynamicSearchAdsSearchTermView();
  // [END googleads_v7_generated_DynamicSearchAdsSearchTermViewService_GetDynamicSearchAdsSearchTermView_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
