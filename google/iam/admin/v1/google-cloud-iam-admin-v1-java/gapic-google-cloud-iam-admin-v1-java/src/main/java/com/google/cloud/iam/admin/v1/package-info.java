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

/**
 * The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= IAMClient =======================
 *
 * <p>Service Description: Creates and manages service account objects.
 *
 * <p>Service account is an account that belongs to your project instead of to an individual end
 * user. It is used to authenticate calls to a Google API.
 *
 * <p>To create a service account, specify the `project_id` and `account_id` for the account. The
 * `account_id` is unique within the project, and used to generate the service account email address
 * and a stable `unique_id`.
 *
 * <p>All other methods can identify accounts using the format
 * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`
 * will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
 * `unique_id` of the service account.
 *
 * <p>Sample for IAMClient:
 */
@Generated("by gapic-generator-java")
package com.google.cloud.iam.admin.v1;

import javax.annotation.Generated;
