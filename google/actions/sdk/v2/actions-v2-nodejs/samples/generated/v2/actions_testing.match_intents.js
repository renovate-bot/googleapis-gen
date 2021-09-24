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

function main(project, query, locale) {
  // [START sdk_v2_generated_ActionsTesting_MatchIntents_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project being tested, indicated by the Project ID.
   *  Format: projects/{project}
   */
  // const project = 'my-project'
  /**
   *  Required. User query as plain text.
   */
  // const query = 'abc123'
  /**
   *  Required. Locale to use to evaluate the query, such as "en".
   *  The format should follow BCP 47: https://tools.ietf.org/html/bcp47
   *  See the list of supported languages in
   *  https://developers.google.com/assistant/console/languages-locales
   */
  // const locale = 'abc123'

  // Imports the Sdk library
  const {ActionsTestingClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsTestingClient();

  async function matchIntents() {
    // Construct request
    const request = {
      project,
      query,
      locale,
    };

    // Run request
    const response = await sdkClient.matchIntents(request);
    console.log(response);
  }

  matchIntents();
  // [END sdk_v2_generated_ActionsTesting_MatchIntents_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
