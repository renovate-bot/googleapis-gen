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
  // [START artifactregistry_v1beta2_generated_ArtifactRegistry_CreateRepository_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The name of the parent resource where the repository will be created.
   */
  // const parent = 'abc123'
  /**
   *  The repository id to use for this repository.
   */
  // const repositoryId = 'abc123'
  /**
   *  The repository to be created.
   */
  // const repository = {}

  // Imports the Artifactregistry library
  const {ArtifactRegistryClient} = require('@google-cloud/artifact-registry').v1beta2;

  // Instantiates a client
  const artifactregistryClient = new ArtifactRegistryClient();

  async function callCreateRepository() {
    // Construct request
    const request = {
    };

    // Run request
    const [operation] = await artifactregistryClient.createRepository(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callCreateRepository();
  // [END artifactregistry_v1beta2_generated_ArtifactRegistry_CreateRepository_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
