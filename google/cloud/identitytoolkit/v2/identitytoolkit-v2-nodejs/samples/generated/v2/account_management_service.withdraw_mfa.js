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

function main(idToken, mfaEnrollmentId) {
  // [START identitytoolkit_withdraw_mfa_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. User's ID token.
   */
  // const idToken = 'abc123'
  /**
   *  Required. MFA enrollment id from a current MFA enrollment.
   */
  // const mfaEnrollmentId = 'abc123'
  /**
   *  The ID of the Identity Platform tenant that the user unenrolling MFA
   *  belongs to. If not set, the user belongs to the default Identity Platform
   *  project.
   */
  // const tenantId = 'abc123'

  // Imports the Identitytoolkit library
  const {AccountManagementServiceClient} = require('@google-cloud/identitytoolkit').v2;

  // Instantiates a client
  const identitytoolkitClient = new AccountManagementServiceClient();

  async function withdrawMfa() {
    // Construct request
    const request = {
      idToken,
      mfaEnrollmentId,
    };

    // Run request
    const response = await identitytoolkitClient.withdrawMfa(request);
    console.log(response);
  }

  withdrawMfa();
  // [END identitytoolkit_withdraw_mfa_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
