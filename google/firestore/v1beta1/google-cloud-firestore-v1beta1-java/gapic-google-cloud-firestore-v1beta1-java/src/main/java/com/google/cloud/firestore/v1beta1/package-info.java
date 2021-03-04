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

/**
 * The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= FirestoreClient =======================
 *
 * <p>Service Description: The Cloud Firestore service.
 *
 * <p>This service exposes several types of comparable timestamps:
 *
 * <ul>
 *   <li>`create_time` - The time at which a document was created. Changes only when a document is
 *       deleted, then re-created. Increases in a strict monotonic fashion.
 *   <li>`update_time` - The time at which a document was last updated. Changes every time a
 *       document is modified. Does not change when a write results in no modifications. Increases
 *       in a strict monotonic fashion.
 *   <li>`read_time` - The time at which a particular state was observed. Used to denote a
 *       consistent snapshot of the database or the time at which a Document was observed to not
 *       exist.
 *   <li>`commit_time` - The time at which the writes in a transaction were committed. Any read with
 *       an equal or greater `read_time` is guaranteed to see the effects of the transaction.
 * </ul>
 *
 * <p>Sample for FirestoreClient:
 *
 * <pre>{@code
 * try (FirestoreClient firestoreClient = FirestoreClient.create()) {
 *   GetDocumentRequest request =
 *       GetDocumentRequest.newBuilder()
 *           .setName("name3373707")
 *           .setMask(DocumentMask.newBuilder().build())
 *           .build();
 *   Document response = firestoreClient.getDocument(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.cloud.firestore.v1beta1;

import javax.annotation.Generated;
