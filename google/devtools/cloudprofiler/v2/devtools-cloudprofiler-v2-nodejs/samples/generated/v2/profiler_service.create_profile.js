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
  // [START cloudprofiler_v2_generated_ProfilerService_CreateProfile_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Parent project to create the profile in.
   */
  // const parent = 'abc123'
  /**
   *  Deployment details.
   */
  // const deployment = {}
  /**
   *  One or more profile types that the agent is capable of providing.
   */
  // const profileType = 1234

  // Imports the Cloudprofiler library
  const {ProfilerServiceClient} = require('@google-cloud/cloudprofiler').v2;

  // Instantiates a client
  const cloudprofilerClient = new ProfilerServiceClient();

  async function callCreateProfile() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await cloudprofilerClient.createProfile(request);
    console.log(response);
  }

  callCreateProfile();
  // [END cloudprofiler_v2_generated_ProfilerService_CreateProfile_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
