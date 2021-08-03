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

package com.google.chromeos.moblab.v1beta1;

import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.longrunning.OperationFuture;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.chromeos.moblab.v1beta1.stub.BuildServiceStub;
import com.google.chromeos.moblab.v1beta1.stub.BuildServiceStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Manages Chrome OS build services.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
 *   BuildArtifactName name =
 *       BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
 *   CheckBuildStageStatusResponse response = buildServiceClient.checkBuildStageStatus(name);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the BuildServiceClient object to clean up resources such
 * as threads. In the example above, try-with-resources is used, which automatically calls close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li> A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li> A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li> A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of BuildServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * BuildServiceSettings buildServiceSettings =
 *     BuildServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * BuildServiceClient buildServiceClient = BuildServiceClient.create(buildServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * BuildServiceSettings buildServiceSettings =
 *     BuildServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * BuildServiceClient buildServiceClient = BuildServiceClient.create(buildServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class BuildServiceClient implements BackgroundResource {
  private final BuildServiceSettings settings;
  private final BuildServiceStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of BuildServiceClient with default settings. */
  public static final BuildServiceClient create() throws IOException {
    return create(BuildServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of BuildServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final BuildServiceClient create(BuildServiceSettings settings) throws IOException {
    return new BuildServiceClient(settings);
  }

  /**
   * Constructs an instance of BuildServiceClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(BuildServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final BuildServiceClient create(BuildServiceStub stub) {
    return new BuildServiceClient(stub);
  }

  /**
   * Constructs an instance of BuildServiceClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected BuildServiceClient(BuildServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((BuildServiceStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected BuildServiceClient(BuildServiceStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final BuildServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public BuildServiceStub getStub() {
    return stub;
  }

  /**
   * Returns the OperationsClient that can be used to query the status of a long-running operation
   * returned by another API method call.
   */
  public final OperationsClient getOperationsClient() {
    return operationsClient;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all build targets that a user has access to.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildTargetsRequest request =
   *       ListBuildTargetsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   for (BuildTarget element : buildServiceClient.listBuildTargets(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListBuildTargetsPagedResponse listBuildTargets(ListBuildTargetsRequest request) {
    return listBuildTargetsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all build targets that a user has access to.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildTargetsRequest request =
   *       ListBuildTargetsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<BuildTarget> future =
   *       buildServiceClient.listBuildTargetsPagedCallable().futureCall(request);
   *   // Do something.
   *   for (BuildTarget element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListBuildTargetsRequest, ListBuildTargetsPagedResponse>
      listBuildTargetsPagedCallable() {
    return stub.listBuildTargetsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all build targets that a user has access to.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildTargetsRequest request =
   *       ListBuildTargetsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   while (true) {
   *     ListBuildTargetsResponse response =
   *         buildServiceClient.listBuildTargetsCallable().call(request);
   *     for (BuildTarget element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListBuildTargetsRequest, ListBuildTargetsResponse>
      listBuildTargetsCallable() {
    return stub.listBuildTargetsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all builds for the given build target and model in descending order for the milestones
   * and build versions.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ModelName parent = ModelName.of("[BUILD_TARGET]", "[MODEL]");
   *   for (Build element : buildServiceClient.listBuilds(parent).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param parent Required. The full resource name of the model. The model id is the same as the
   *     build target id for non-unified builds. For example, 'buildTargets/octopus/models/bobba'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListBuildsPagedResponse listBuilds(ModelName parent) {
    ListBuildsRequest request =
        ListBuildsRequest.newBuilder().setParent(parent == null ? null : parent.toString()).build();
    return listBuilds(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all builds for the given build target and model in descending order for the milestones
   * and build versions.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   String parent = ModelName.of("[BUILD_TARGET]", "[MODEL]").toString();
   *   for (Build element : buildServiceClient.listBuilds(parent).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param parent Required. The full resource name of the model. The model id is the same as the
   *     build target id for non-unified builds. For example, 'buildTargets/octopus/models/bobba'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListBuildsPagedResponse listBuilds(String parent) {
    ListBuildsRequest request = ListBuildsRequest.newBuilder().setParent(parent).build();
    return listBuilds(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all builds for the given build target and model in descending order for the milestones
   * and build versions.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildsRequest request =
   *       ListBuildsRequest.newBuilder()
   *           .setParent(ModelName.of("[BUILD_TARGET]", "[MODEL]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .setReadMask(FieldMask.newBuilder().build())
   *           .setGroupBy(FieldMask.newBuilder().build())
   *           .build();
   *   for (Build element : buildServiceClient.listBuilds(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListBuildsPagedResponse listBuilds(ListBuildsRequest request) {
    return listBuildsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all builds for the given build target and model in descending order for the milestones
   * and build versions.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildsRequest request =
   *       ListBuildsRequest.newBuilder()
   *           .setParent(ModelName.of("[BUILD_TARGET]", "[MODEL]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .setReadMask(FieldMask.newBuilder().build())
   *           .setGroupBy(FieldMask.newBuilder().build())
   *           .build();
   *   ApiFuture<Build> future = buildServiceClient.listBuildsPagedCallable().futureCall(request);
   *   // Do something.
   *   for (Build element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListBuildsRequest, ListBuildsPagedResponse> listBuildsPagedCallable() {
    return stub.listBuildsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all builds for the given build target and model in descending order for the milestones
   * and build versions.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   ListBuildsRequest request =
   *       ListBuildsRequest.newBuilder()
   *           .setParent(ModelName.of("[BUILD_TARGET]", "[MODEL]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .setReadMask(FieldMask.newBuilder().build())
   *           .setGroupBy(FieldMask.newBuilder().build())
   *           .build();
   *   while (true) {
   *     ListBuildsResponse response = buildServiceClient.listBuildsCallable().call(request);
   *     for (Build element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListBuildsRequest, ListBuildsResponse> listBuildsCallable() {
    return stub.listBuildsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Checks the stage status for a given build artifact in a partner Google Cloud Storage bucket.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   BuildArtifactName name =
   *       BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
   *   CheckBuildStageStatusResponse response = buildServiceClient.checkBuildStageStatus(name);
   * }
   * }</pre>
   *
   * @param name Required. The full resource name of the build artifact. For example,
   *     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CheckBuildStageStatusResponse checkBuildStageStatus(BuildArtifactName name) {
    CheckBuildStageStatusRequest request =
        CheckBuildStageStatusRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return checkBuildStageStatus(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Checks the stage status for a given build artifact in a partner Google Cloud Storage bucket.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   String name =
   *       BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]").toString();
   *   CheckBuildStageStatusResponse response = buildServiceClient.checkBuildStageStatus(name);
   * }
   * }</pre>
   *
   * @param name Required. The full resource name of the build artifact. For example,
   *     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CheckBuildStageStatusResponse checkBuildStageStatus(String name) {
    CheckBuildStageStatusRequest request =
        CheckBuildStageStatusRequest.newBuilder().setName(name).build();
    return checkBuildStageStatus(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Checks the stage status for a given build artifact in a partner Google Cloud Storage bucket.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   CheckBuildStageStatusRequest request =
   *       CheckBuildStageStatusRequest.newBuilder()
   *           .setName(
   *               BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
   *                   .toString())
   *           .setFilter("filter-1274492040")
   *           .build();
   *   CheckBuildStageStatusResponse response = buildServiceClient.checkBuildStageStatus(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CheckBuildStageStatusResponse checkBuildStageStatus(
      CheckBuildStageStatusRequest request) {
    return checkBuildStageStatusCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Checks the stage status for a given build artifact in a partner Google Cloud Storage bucket.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   CheckBuildStageStatusRequest request =
   *       CheckBuildStageStatusRequest.newBuilder()
   *           .setName(
   *               BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
   *                   .toString())
   *           .setFilter("filter-1274492040")
   *           .build();
   *   ApiFuture<CheckBuildStageStatusResponse> future =
   *       buildServiceClient.checkBuildStageStatusCallable().futureCall(request);
   *   // Do something.
   *   CheckBuildStageStatusResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusCallable() {
    return stub.checkBuildStageStatusCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stages a given build artifact from a internal Google Cloud Storage bucket to a partner Google
   * Cloud Storage bucket. If any of objects has already been copied, it will overwrite the previous
   * objects. Operation &lt;response:
   * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse], metadata:
   * [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   BuildArtifactName name =
   *       BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
   *   StageBuildResponse response = buildServiceClient.stageBuildAsync(name).get();
   * }
   * }</pre>
   *
   * @param name Required. The full resource name of the build artifact. For example,
   *     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<StageBuildResponse, StageBuildMetadata> stageBuildAsync(
      BuildArtifactName name) {
    StageBuildRequest request =
        StageBuildRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return stageBuildAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stages a given build artifact from a internal Google Cloud Storage bucket to a partner Google
   * Cloud Storage bucket. If any of objects has already been copied, it will overwrite the previous
   * objects. Operation &lt;response:
   * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse], metadata:
   * [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   String name =
   *       BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]").toString();
   *   StageBuildResponse response = buildServiceClient.stageBuildAsync(name).get();
   * }
   * }</pre>
   *
   * @param name Required. The full resource name of the build artifact. For example,
   *     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<StageBuildResponse, StageBuildMetadata> stageBuildAsync(
      String name) {
    StageBuildRequest request = StageBuildRequest.newBuilder().setName(name).build();
    return stageBuildAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stages a given build artifact from a internal Google Cloud Storage bucket to a partner Google
   * Cloud Storage bucket. If any of objects has already been copied, it will overwrite the previous
   * objects. Operation &lt;response:
   * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse], metadata:
   * [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   StageBuildRequest request =
   *       StageBuildRequest.newBuilder()
   *           .setName(
   *               BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
   *                   .toString())
   *           .setFilter("filter-1274492040")
   *           .build();
   *   StageBuildResponse response = buildServiceClient.stageBuildAsync(request).get();
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<StageBuildResponse, StageBuildMetadata> stageBuildAsync(
      StageBuildRequest request) {
    return stageBuildOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stages a given build artifact from a internal Google Cloud Storage bucket to a partner Google
   * Cloud Storage bucket. If any of objects has already been copied, it will overwrite the previous
   * objects. Operation &lt;response:
   * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse], metadata:
   * [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   StageBuildRequest request =
   *       StageBuildRequest.newBuilder()
   *           .setName(
   *               BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
   *                   .toString())
   *           .setFilter("filter-1274492040")
   *           .build();
   *   OperationFuture<StageBuildResponse, StageBuildMetadata> future =
   *       buildServiceClient.stageBuildOperationCallable().futureCall(request);
   *   // Do something.
   *   StageBuildResponse response = future.get();
   * }
   * }</pre>
   */
  public final OperationCallable<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
      stageBuildOperationCallable() {
    return stub.stageBuildOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stages a given build artifact from a internal Google Cloud Storage bucket to a partner Google
   * Cloud Storage bucket. If any of objects has already been copied, it will overwrite the previous
   * objects. Operation &lt;response:
   * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse], metadata:
   * [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   StageBuildRequest request =
   *       StageBuildRequest.newBuilder()
   *           .setName(
   *               BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
   *                   .toString())
   *           .setFilter("filter-1274492040")
   *           .build();
   *   ApiFuture<Operation> future = buildServiceClient.stageBuildCallable().futureCall(request);
   *   // Do something.
   *   Operation response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<StageBuildRequest, Operation> stageBuildCallable() {
    return stub.stageBuildCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finds the most stable build for the given build target. The definition of the most stable build
   * is determined by evaluating the following rules in order until one is true. If none are true,
   * then there is no stable build and it will return an empty response.
   *
   * <p>Evaluation rules: 1. Stable channel build with label ?Live? 2. Beta channel build with label
   * ?Live? 3. Dev channel build with label ?Live? 4. Most recent stable channel build with build
   * status Pass 5. Most recent beta channel build with build status Pass 6. Most recent dev channel
   * build with build status Pass
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   BuildTargetName buildTarget = BuildTargetName.of("[BUILD_TARGET]");
   *   FindMostStableBuildResponse response = buildServiceClient.findMostStableBuild(buildTarget);
   * }
   * }</pre>
   *
   * @param buildTarget Required. The full resource name of the build target. For example,
   *     'buildTargets/octopus'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final FindMostStableBuildResponse findMostStableBuild(BuildTargetName buildTarget) {
    FindMostStableBuildRequest request =
        FindMostStableBuildRequest.newBuilder()
            .setBuildTarget(buildTarget == null ? null : buildTarget.toString())
            .build();
    return findMostStableBuild(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finds the most stable build for the given build target. The definition of the most stable build
   * is determined by evaluating the following rules in order until one is true. If none are true,
   * then there is no stable build and it will return an empty response.
   *
   * <p>Evaluation rules: 1. Stable channel build with label ?Live? 2. Beta channel build with label
   * ?Live? 3. Dev channel build with label ?Live? 4. Most recent stable channel build with build
   * status Pass 5. Most recent beta channel build with build status Pass 6. Most recent dev channel
   * build with build status Pass
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   String buildTarget = BuildTargetName.of("[BUILD_TARGET]").toString();
   *   FindMostStableBuildResponse response = buildServiceClient.findMostStableBuild(buildTarget);
   * }
   * }</pre>
   *
   * @param buildTarget Required. The full resource name of the build target. For example,
   *     'buildTargets/octopus'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final FindMostStableBuildResponse findMostStableBuild(String buildTarget) {
    FindMostStableBuildRequest request =
        FindMostStableBuildRequest.newBuilder().setBuildTarget(buildTarget).build();
    return findMostStableBuild(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finds the most stable build for the given build target. The definition of the most stable build
   * is determined by evaluating the following rules in order until one is true. If none are true,
   * then there is no stable build and it will return an empty response.
   *
   * <p>Evaluation rules: 1. Stable channel build with label ?Live? 2. Beta channel build with label
   * ?Live? 3. Dev channel build with label ?Live? 4. Most recent stable channel build with build
   * status Pass 5. Most recent beta channel build with build status Pass 6. Most recent dev channel
   * build with build status Pass
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   FindMostStableBuildRequest request =
   *       FindMostStableBuildRequest.newBuilder()
   *           .setBuildTarget(BuildTargetName.of("[BUILD_TARGET]").toString())
   *           .build();
   *   FindMostStableBuildResponse response = buildServiceClient.findMostStableBuild(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final FindMostStableBuildResponse findMostStableBuild(FindMostStableBuildRequest request) {
    return findMostStableBuildCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finds the most stable build for the given build target. The definition of the most stable build
   * is determined by evaluating the following rules in order until one is true. If none are true,
   * then there is no stable build and it will return an empty response.
   *
   * <p>Evaluation rules: 1. Stable channel build with label ?Live? 2. Beta channel build with label
   * ?Live? 3. Dev channel build with label ?Live? 4. Most recent stable channel build with build
   * status Pass 5. Most recent beta channel build with build status Pass 6. Most recent dev channel
   * build with build status Pass
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BuildServiceClient buildServiceClient = BuildServiceClient.create()) {
   *   FindMostStableBuildRequest request =
   *       FindMostStableBuildRequest.newBuilder()
   *           .setBuildTarget(BuildTargetName.of("[BUILD_TARGET]").toString())
   *           .build();
   *   ApiFuture<FindMostStableBuildResponse> future =
   *       buildServiceClient.findMostStableBuildCallable().futureCall(request);
   *   // Do something.
   *   FindMostStableBuildResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<FindMostStableBuildRequest, FindMostStableBuildResponse>
      findMostStableBuildCallable() {
    return stub.findMostStableBuildCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }

  public static class ListBuildTargetsPagedResponse
      extends AbstractPagedListResponse<
          ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget, ListBuildTargetsPage,
          ListBuildTargetsFixedSizeCollection> {

    public static ApiFuture<ListBuildTargetsPagedResponse> createAsync(
        PageContext<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget> context,
        ApiFuture<ListBuildTargetsResponse> futureResponse) {
      ApiFuture<ListBuildTargetsPage> futurePage =
          ListBuildTargetsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          input -> new ListBuildTargetsPagedResponse(input),
          MoreExecutors.directExecutor());
    }

    private ListBuildTargetsPagedResponse(ListBuildTargetsPage page) {
      super(page, ListBuildTargetsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListBuildTargetsPage
      extends AbstractPage<
          ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget, ListBuildTargetsPage> {

    private ListBuildTargetsPage(
        PageContext<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget> context,
        ListBuildTargetsResponse response) {
      super(context, response);
    }

    private static ListBuildTargetsPage createEmptyPage() {
      return new ListBuildTargetsPage(null, null);
    }

    @Override
    protected ListBuildTargetsPage createPage(
        PageContext<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget> context,
        ListBuildTargetsResponse response) {
      return new ListBuildTargetsPage(context, response);
    }

    @Override
    public ApiFuture<ListBuildTargetsPage> createPageAsync(
        PageContext<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget> context,
        ApiFuture<ListBuildTargetsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListBuildTargetsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget, ListBuildTargetsPage,
          ListBuildTargetsFixedSizeCollection> {

    private ListBuildTargetsFixedSizeCollection(
        List<ListBuildTargetsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListBuildTargetsFixedSizeCollection createEmptyCollection() {
      return new ListBuildTargetsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListBuildTargetsFixedSizeCollection createCollection(
        List<ListBuildTargetsPage> pages, int collectionSize) {
      return new ListBuildTargetsFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListBuildsPagedResponse
      extends AbstractPagedListResponse<
          ListBuildsRequest, ListBuildsResponse, Build, ListBuildsPage,
          ListBuildsFixedSizeCollection> {

    public static ApiFuture<ListBuildsPagedResponse> createAsync(
        PageContext<ListBuildsRequest, ListBuildsResponse, Build> context,
        ApiFuture<ListBuildsResponse> futureResponse) {
      ApiFuture<ListBuildsPage> futurePage =
          ListBuildsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage, input -> new ListBuildsPagedResponse(input), MoreExecutors.directExecutor());
    }

    private ListBuildsPagedResponse(ListBuildsPage page) {
      super(page, ListBuildsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListBuildsPage
      extends AbstractPage<ListBuildsRequest, ListBuildsResponse, Build, ListBuildsPage> {

    private ListBuildsPage(
        PageContext<ListBuildsRequest, ListBuildsResponse, Build> context,
        ListBuildsResponse response) {
      super(context, response);
    }

    private static ListBuildsPage createEmptyPage() {
      return new ListBuildsPage(null, null);
    }

    @Override
    protected ListBuildsPage createPage(
        PageContext<ListBuildsRequest, ListBuildsResponse, Build> context,
        ListBuildsResponse response) {
      return new ListBuildsPage(context, response);
    }

    @Override
    public ApiFuture<ListBuildsPage> createPageAsync(
        PageContext<ListBuildsRequest, ListBuildsResponse, Build> context,
        ApiFuture<ListBuildsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListBuildsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListBuildsRequest, ListBuildsResponse, Build, ListBuildsPage,
          ListBuildsFixedSizeCollection> {

    private ListBuildsFixedSizeCollection(List<ListBuildsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListBuildsFixedSizeCollection createEmptyCollection() {
      return new ListBuildsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListBuildsFixedSizeCollection createCollection(
        List<ListBuildsPage> pages, int collectionSize) {
      return new ListBuildsFixedSizeCollection(pages, collectionSize);
    }
  }
}
