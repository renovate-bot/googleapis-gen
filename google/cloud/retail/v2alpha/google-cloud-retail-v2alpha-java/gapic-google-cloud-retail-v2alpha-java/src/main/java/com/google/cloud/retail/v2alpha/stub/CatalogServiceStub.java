/*
 * Copyright 2021 Google LLC
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

package com.google.cloud.retail.v2alpha.stub;

import static com.google.cloud.retail.v2alpha.CatalogServiceClient.ListCatalogsPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.retail.v2alpha.Catalog;
import com.google.cloud.retail.v2alpha.ListCatalogsRequest;
import com.google.cloud.retail.v2alpha.ListCatalogsResponse;
import com.google.cloud.retail.v2alpha.UpdateCatalogRequest;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the CatalogService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public abstract class CatalogServiceStub implements BackgroundResource {

  public UnaryCallable<ListCatalogsRequest, ListCatalogsPagedResponse> listCatalogsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listCatalogsPagedCallable()");
  }

  public UnaryCallable<ListCatalogsRequest, ListCatalogsResponse> listCatalogsCallable() {
    throw new UnsupportedOperationException("Not implemented: listCatalogsCallable()");
  }

  public UnaryCallable<UpdateCatalogRequest, Catalog> updateCatalogCallable() {
    throw new UnsupportedOperationException("Not implemented: updateCatalogCallable()");
  }

  @Override
  public abstract void close();
}
