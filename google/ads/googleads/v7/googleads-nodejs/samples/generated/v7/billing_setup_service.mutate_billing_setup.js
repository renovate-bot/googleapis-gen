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

function main(customerId, operation) {
  // [START googleads_mutate_billing_setup_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Id of the customer to apply the billing setup mutate operation to.
   */
  // const customerId = 'abc123'
  /**
   *  Required. The operation to perform.
   */
  // const operation = ''

  // Imports the Googleads library
  const {BillingSetupServiceClient} = require('google-ads').v7;

  // Instantiates a client
  const googleadsClient = new BillingSetupServiceClient();

  async function mutateBillingSetup() {
    // Construct request
    const request = {
      customerId,
      operation,
    };

    // Run request
    const response = await googleadsClient.mutateBillingSetup(request);
    console.log(response);
  }

  mutateBillingSetup();
  // [END googleads_mutate_billing_setup_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
