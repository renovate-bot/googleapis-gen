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

package com.google.cloud.identitytoolkit.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest;
import com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse;
import com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest;
import com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse;
import com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest;
import com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the AccountManagementService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class AccountManagementServiceStub implements BackgroundResource {

  public UnaryCallable<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
      finalizeMfaEnrollmentCallable() {
    throw new UnsupportedOperationException("Not implemented: finalizeMfaEnrollmentCallable()");
  }

  public UnaryCallable<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
      startMfaEnrollmentCallable() {
    throw new UnsupportedOperationException("Not implemented: startMfaEnrollmentCallable()");
  }

  public UnaryCallable<WithdrawMfaRequest, WithdrawMfaResponse> withdrawMfaCallable() {
    throw new UnsupportedOperationException("Not implemented: withdrawMfaCallable()");
  }

  @Override
  public abstract void close();
}
