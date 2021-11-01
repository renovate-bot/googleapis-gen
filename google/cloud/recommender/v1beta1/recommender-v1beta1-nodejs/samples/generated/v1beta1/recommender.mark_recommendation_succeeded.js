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

function main(name, etag) {
  // [START recommender_v1beta1_generated_Recommender_MarkRecommendationSucceeded_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the recommendation.
   */
  // const name = 'abc123'
  /**
   *  State properties to include with this state. Overwrites any existing
   *  `state_metadata`.
   *  Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
   *  Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
   */
  // const stateMetadata = 1234
  /**
   *  Required. Fingerprint of the Recommendation. Provides optimistic locking.
   */
  // const etag = 'abc123'

  // Imports the Recommender library
  const {RecommenderClient} = require('recommender').v1beta1;

  // Instantiates a client
  const recommenderClient = new RecommenderClient();

  async function markRecommendationSucceeded() {
    // Construct request
    const request = {
      name,
      etag,
    };

    // Run request
    const response = await recommenderClient.markRecommendationSucceeded(request);
    console.log(response);
  }

  markRecommendationSucceeded();
  // [END recommender_v1beta1_generated_Recommender_MarkRecommendationSucceeded_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
