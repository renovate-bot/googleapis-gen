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

package com.google.cloud.bigquery.v2;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.bigquery.v2.stub.ModelServiceStub;
import com.google.cloud.bigquery.v2.stub.ModelServiceStubSettings;
import com.google.protobuf.Empty;
import com.google.protobuf.UInt32Value;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * This class provides the ability to make remote calls to the backing service through method calls
 * that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
 *   String projectId = "projectId-894832108";
 *   String datasetId = "datasetId-345342029";
 *   String modelId = "modelId1226956324";
 *   ModelProto.Model response = modelServiceClient.getModel(projectId, datasetId, modelId);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the ModelServiceClient object to clean up resources such
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
 * <p>This class can be customized by passing in a custom instance of ModelServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * ModelServiceSettings modelServiceSettings =
 *     ModelServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * ModelServiceClient modelServiceClient = ModelServiceClient.create(modelServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * ModelServiceSettings modelServiceSettings =
 *     ModelServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * ModelServiceClient modelServiceClient = ModelServiceClient.create(modelServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class ModelServiceClient implements BackgroundResource {
  private final ModelServiceSettings settings;
  private final ModelServiceStub stub;

  /** Constructs an instance of ModelServiceClient with default settings. */
  public static final ModelServiceClient create() throws IOException {
    return create(ModelServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of ModelServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final ModelServiceClient create(ModelServiceSettings settings) throws IOException {
    return new ModelServiceClient(settings);
  }

  /**
   * Constructs an instance of ModelServiceClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(ModelServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final ModelServiceClient create(ModelServiceStub stub) {
    return new ModelServiceClient(stub);
  }

  /**
   * Constructs an instance of ModelServiceClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected ModelServiceClient(ModelServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((ModelServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected ModelServiceClient(ModelServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final ModelServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ModelServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the specified model resource by model ID.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   String projectId = "projectId-894832108";
   *   String datasetId = "datasetId-345342029";
   *   String modelId = "modelId1226956324";
   *   ModelProto.Model response = modelServiceClient.getModel(projectId, datasetId, modelId);
   * }
   * }</pre>
   *
   * @param projectId Required. Project ID of the requested model.
   * @param datasetId Required. Dataset ID of the requested model.
   * @param modelId Required. Model ID of the requested model.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.Model getModel(String projectId, String datasetId, String modelId) {
    ModelProto.GetModelRequest request =
        ModelProto.GetModelRequest.newBuilder()
            .setProjectId(projectId)
            .setDatasetId(datasetId)
            .setModelId(modelId)
            .build();
    return getModel(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the specified model resource by model ID.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.GetModelRequest request =
   *       ModelProto.GetModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .build();
   *   ModelProto.Model response = modelServiceClient.getModel(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.Model getModel(ModelProto.GetModelRequest request) {
    return getModelCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the specified model resource by model ID.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.GetModelRequest request =
   *       ModelProto.GetModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .build();
   *   ApiFuture<ModelProto.Model> future =
   *       modelServiceClient.getModelCallable().futureCall(request);
   *   // Do something.
   *   ModelProto.Model response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ModelProto.GetModelRequest, ModelProto.Model> getModelCallable() {
    return stub.getModelCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all models in the specified dataset. Requires the READER dataset role. After retrieving
   * the list of models, you can get information about a particular model by calling the models.get
   * method.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   String projectId = "projectId-894832108";
   *   String datasetId = "datasetId-345342029";
   *   UInt32Value maxResults = UInt32Value.newBuilder().build();
   *   ModelProto.ListModelsResponse response =
   *       modelServiceClient.listModels(projectId, datasetId, maxResults);
   * }
   * }</pre>
   *
   * @param projectId Required. Project ID of the models to list.
   * @param datasetId Required. Dataset ID of the models to list.
   * @param maxResults The maximum number of results to return in a single response page. Leverage
   *     the page tokens to iterate through the entire collection.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.ListModelsResponse listModels(
      String projectId, String datasetId, UInt32Value maxResults) {
    ModelProto.ListModelsRequest request =
        ModelProto.ListModelsRequest.newBuilder()
            .setProjectId(projectId)
            .setDatasetId(datasetId)
            .setMaxResults(maxResults)
            .build();
    return listModels(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all models in the specified dataset. Requires the READER dataset role. After retrieving
   * the list of models, you can get information about a particular model by calling the models.get
   * method.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.ListModelsRequest request =
   *       ModelProto.ListModelsRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setMaxResults(UInt32Value.newBuilder().build())
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ModelProto.ListModelsResponse response = modelServiceClient.listModels(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.ListModelsResponse listModels(ModelProto.ListModelsRequest request) {
    return listModelsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all models in the specified dataset. Requires the READER dataset role. After retrieving
   * the list of models, you can get information about a particular model by calling the models.get
   * method.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.ListModelsRequest request =
   *       ModelProto.ListModelsRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setMaxResults(UInt32Value.newBuilder().build())
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<ModelProto.ListModelsResponse> future =
   *       modelServiceClient.listModelsCallable().futureCall(request);
   *   // Do something.
   *   ModelProto.ListModelsResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsCallable() {
    return stub.listModelsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Patch specific fields in the specified model.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   String projectId = "projectId-894832108";
   *   String datasetId = "datasetId-345342029";
   *   String modelId = "modelId1226956324";
   *   ModelProto.Model model = ModelProto.Model.newBuilder().build();
   *   ModelProto.Model response =
   *       modelServiceClient.patchModel(projectId, datasetId, modelId, model);
   * }
   * }</pre>
   *
   * @param projectId Required. Project ID of the model to patch.
   * @param datasetId Required. Dataset ID of the model to patch.
   * @param modelId Required. Model ID of the model to patch.
   * @param model Required. Patched model. Follows RFC5789 patch semantics. Missing fields are not
   *     updated. To clear a field, explicitly set to default value.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.Model patchModel(
      String projectId, String datasetId, String modelId, ModelProto.Model model) {
    ModelProto.PatchModelRequest request =
        ModelProto.PatchModelRequest.newBuilder()
            .setProjectId(projectId)
            .setDatasetId(datasetId)
            .setModelId(modelId)
            .setModel(model)
            .build();
    return patchModel(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Patch specific fields in the specified model.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.PatchModelRequest request =
   *       ModelProto.PatchModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .setModel(ModelProto.Model.newBuilder().build())
   *           .build();
   *   ModelProto.Model response = modelServiceClient.patchModel(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ModelProto.Model patchModel(ModelProto.PatchModelRequest request) {
    return patchModelCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Patch specific fields in the specified model.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.PatchModelRequest request =
   *       ModelProto.PatchModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .setModel(ModelProto.Model.newBuilder().build())
   *           .build();
   *   ApiFuture<ModelProto.Model> future =
   *       modelServiceClient.patchModelCallable().futureCall(request);
   *   // Do something.
   *   ModelProto.Model response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ModelProto.PatchModelRequest, ModelProto.Model> patchModelCallable() {
    return stub.patchModelCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes the model specified by modelId from the dataset.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   String projectId = "projectId-894832108";
   *   String datasetId = "datasetId-345342029";
   *   String modelId = "modelId1226956324";
   *   modelServiceClient.deleteModel(projectId, datasetId, modelId);
   * }
   * }</pre>
   *
   * @param projectId Required. Project ID of the model to delete.
   * @param datasetId Required. Dataset ID of the model to delete.
   * @param modelId Required. Model ID of the model to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteModel(String projectId, String datasetId, String modelId) {
    ModelProto.DeleteModelRequest request =
        ModelProto.DeleteModelRequest.newBuilder()
            .setProjectId(projectId)
            .setDatasetId(datasetId)
            .setModelId(modelId)
            .build();
    deleteModel(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes the model specified by modelId from the dataset.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.DeleteModelRequest request =
   *       ModelProto.DeleteModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .build();
   *   modelServiceClient.deleteModel(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteModel(ModelProto.DeleteModelRequest request) {
    deleteModelCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes the model specified by modelId from the dataset.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ModelServiceClient modelServiceClient = ModelServiceClient.create()) {
   *   ModelProto.DeleteModelRequest request =
   *       ModelProto.DeleteModelRequest.newBuilder()
   *           .setProjectId("projectId-894832108")
   *           .setDatasetId("datasetId-345342029")
   *           .setModelId("modelId1226956324")
   *           .build();
   *   ApiFuture<Empty> future = modelServiceClient.deleteModelCallable().futureCall(request);
   *   // Do something.
   *   future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ModelProto.DeleteModelRequest, Empty> deleteModelCallable() {
    return stub.deleteModelCallable();
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
}
