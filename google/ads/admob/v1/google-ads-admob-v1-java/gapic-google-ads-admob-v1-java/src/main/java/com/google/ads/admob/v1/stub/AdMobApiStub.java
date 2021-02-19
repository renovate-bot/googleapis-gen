/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.ads.admob.v1.stub;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.AdMobApiProto;
import com.google.ads.admob.v1.AdMobResourcesProto;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the AdMobApi service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class AdMobApiStub implements BackgroundResource {

  public UnaryCallable<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountCallable() {
    throw new UnsupportedOperationException("Not implemented: getPublisherAccountCallable()");
  }

  public UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: listPublisherAccountsPagedCallable()");
  }

  public UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
      listPublisherAccountsCallable() {
    throw new UnsupportedOperationException("Not implemented: listPublisherAccountsCallable()");
  }

  public ServerStreamingCallable<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportCallable() {
    throw new UnsupportedOperationException("Not implemented: generateNetworkReportCallable()");
  }

  public ServerStreamingCallable<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportCallable() {
    throw new UnsupportedOperationException("Not implemented: generateMediationReportCallable()");
  }

  @Override
  public abstract void close();
}
