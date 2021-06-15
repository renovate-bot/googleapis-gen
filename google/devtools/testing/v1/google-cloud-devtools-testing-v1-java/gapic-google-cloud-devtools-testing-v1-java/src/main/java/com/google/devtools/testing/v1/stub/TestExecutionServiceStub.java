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

package com.google.devtools.testing.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.devtools.testing.v1.CancelTestMatrixRequest;
import com.google.devtools.testing.v1.CancelTestMatrixResponse;
import com.google.devtools.testing.v1.CreateTestMatrixRequest;
import com.google.devtools.testing.v1.GetTestMatrixRequest;
import com.google.devtools.testing.v1.TestMatrix;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the TestExecutionService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class TestExecutionServiceStub implements BackgroundResource {

  public UnaryCallable<CreateTestMatrixRequest, TestMatrix> createTestMatrixCallable() {
    throw new UnsupportedOperationException("Not implemented: createTestMatrixCallable()");
  }

  public UnaryCallable<GetTestMatrixRequest, TestMatrix> getTestMatrixCallable() {
    throw new UnsupportedOperationException("Not implemented: getTestMatrixCallable()");
  }

  public UnaryCallable<CancelTestMatrixRequest, CancelTestMatrixResponse>
      cancelTestMatrixCallable() {
    throw new UnsupportedOperationException("Not implemented: cancelTestMatrixCallable()");
  }

  @Override
  public abstract void close();
}
