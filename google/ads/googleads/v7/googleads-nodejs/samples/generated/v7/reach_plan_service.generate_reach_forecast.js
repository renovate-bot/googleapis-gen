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

function main(customerId, campaignDuration, plannedProducts) {
  // [START googleads_v7_generated_ReachPlanService_GenerateReachForecast_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The ID of the customer.
   */
  // const customerId = 'abc123'
  /**
   *  The currency code.
   *  Three-character ISO 4217 currency code.
   */
  // const currencyCode = 'abc123'
  /**
   *  Required. Campaign duration.
   */
  // const campaignDuration = ''
  /**
   *  Desired cookie frequency cap that will be applied to each planned product.
   *  This is equivalent to the frequency cap exposed in Google Ads when creating
   *  a campaign, it represents the maximum number of times an ad can be shown to
   *  the same user.
   *  If not specified no cap is applied.
   *  This field is deprecated in v4 and will eventually be removed.
   *  Please use cookie_frequency_cap_setting instead.
   */
  // const cookieFrequencyCap = 1234
  /**
   *  Desired cookie frequency cap that will be applied to each planned product.
   *  This is equivalent to the frequency cap exposed in Google Ads when creating
   *  a campaign, it represents the maximum number of times an ad can be shown to
   *  the same user during a specified time interval.
   *  If not specified, no cap is applied.
   *  This field replaces the deprecated cookie_frequency_cap field.
   */
  // const cookieFrequencyCapSetting = ''
  /**
   *  Desired minimum effective frequency (the number of times a person was
   *  exposed to the ad) for the reported reach metrics [1-10].
   *  This won't affect the targeting, but just the reporting.
   *  If not specified, a default of 1 is applied.
   */
  // const minEffectiveFrequency = 1234
  /**
   *  The targeting to be applied to all products selected in the product mix.
   *  This is planned targeting: execution details might vary based on the
   *  advertising product, please consult an implementation specialist.
   *  See specific metrics for details on how targeting affects them.
   *  In some cases, targeting may be overridden using the
   *  PlannedProduct.advanced_product_targeting field.
   */
  // const targeting = ''
  /**
   *  Required. The products to be forecast.
   *  The max number of allowed planned products is 15.
   */
  // const plannedProducts = 1234

  // Imports the Googleads library
  const {ReachPlanServiceClient} = require('google-ads').v7;

  // Instantiates a client
  const googleadsClient = new ReachPlanServiceClient();

  async function generateReachForecast() {
    // Construct request
    const request = {
      customerId,
      campaignDuration,
      plannedProducts,
    };

    // Run request
    const response = await googleadsClient.generateReachForecast(request);
    console.log(response);
  }

  generateReachForecast();
  // [END googleads_v7_generated_ReachPlanService_GenerateReachForecast_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
