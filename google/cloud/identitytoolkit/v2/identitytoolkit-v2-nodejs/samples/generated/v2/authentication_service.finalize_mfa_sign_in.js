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

function main(mfaPendingCredential) {
  // [START identitytoolkit_finalize_mfa_sign_in_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Pending credential from first factor sign-in.
   */
  // const mfaPendingCredential = 'abc123'
  /**
   *  Proof of completion of the SMS based MFA challenge.
   */
  // const phoneVerificationInfo = ''
  /**
   *  The ID of the Identity Platform tenant the user is signing in to. If not
   *  set, the user will sign in to the default Identity Platform project.
   */
  // const tenantId = 'abc123'

  // Imports the Identitytoolkit library
  const {AuthenticationServiceClient} = require('@google-cloud/identitytoolkit').v2;

  // Instantiates a client
  const identitytoolkitClient = new AuthenticationServiceClient();

  async function finalizeMfaSignIn() {
    // Construct request
    const request = {
      mfaPendingCredential,
    };

    // Run request
    const response = await identitytoolkitClient.finalizeMfaSignIn(request);
    console.log(response);
  }

  finalizeMfaSignIn();
  // [END identitytoolkit_finalize_mfa_sign_in_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
