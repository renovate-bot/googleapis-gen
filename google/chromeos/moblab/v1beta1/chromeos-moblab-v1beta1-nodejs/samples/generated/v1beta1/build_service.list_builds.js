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
  // [START moblab_v1beta1_generated_BuildService_ListBuilds_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The full resource name of the model. The model id is the same as
   *  the build target id for non-unified builds.
   *  For example,
   *  'buildTargets/octopus/models/bobba'.
   */
  // const parent = 'abc123'
  /**
   *  Optional. The number of builds to return in a page.
   */
  // const pageSize = 1234
  /**
   *  Optional. A page token, received from a previous `ListBuilds` call. Provide this to
   *  retrieve the subsequent page.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional. Filter that specifies value constraints of fields. For example, the
   *  filter can be set as "filter='milestone=milestones/80'" to only select
   *  builds in milestone 80.
   */
  // const filter = 'abc123'
  /**
   *  Optional. Read mask that specifies which Build fields to return. If empty, all Build
   *  fields will be returned.
   *  Valid fields: name, milestone, build_version.
   *  For example, if the read_mask is set as "read_mask='milestone'", the
   *  ListBuilds will return a list of Builds object with only the milestone
   *  field.
   */
  // const readMask = ''
  /**
   *  Optional. The operation that groups by all the Build fields specified in the read
   *  mask. The group_by field should be the same as the read_mask field in
   *  convention of SQL.
   */
  // const groupBy = ''

  // Imports the Moblab library
  const {BuildServiceClient} = require('@google-cloud/moblab').v1beta1;

  // Instantiates a client
  const moblabClient = new BuildServiceClient();

  async function listBuilds() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await moblabClient.listBuildsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listBuilds();
  // [END moblab_v1beta1_generated_BuildService_ListBuilds_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
