<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
namespace Google\Cloud\Aiplatform\V1beta1;

/**
 * Service for reading and writing metadata entries.
 */
class MetadataServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Initializes a MetadataStore, including allocation of resources.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateMetadataStoreRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateMetadataStore(\Google\Cloud\Aiplatform\V1beta1\CreateMetadataStoreRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/CreateMetadataStore',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a specific MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetMetadataStoreRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetMetadataStore(\Google\Cloud\Aiplatform\V1beta1\GetMetadataStoreRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/GetMetadataStore',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\MetadataStore', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists MetadataStores for a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListMetadataStoresRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListMetadataStores(\Google\Cloud\Aiplatform\V1beta1\ListMetadataStoresRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/ListMetadataStores',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListMetadataStoresResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteMetadataStoreRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteMetadataStore(\Google\Cloud\Aiplatform\V1beta1\DeleteMetadataStoreRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/DeleteMetadataStore',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an Artifact associated with a MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateArtifactRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateArtifact(\Google\Cloud\Aiplatform\V1beta1\CreateArtifactRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/CreateArtifact',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Artifact', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a specific Artifact.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetArtifactRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetArtifact(\Google\Cloud\Aiplatform\V1beta1\GetArtifactRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/GetArtifact',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Artifact', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Artifacts in the MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListArtifactsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListArtifacts(\Google\Cloud\Aiplatform\V1beta1\ListArtifactsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/ListArtifacts',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListArtifactsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a stored Artifact.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateArtifactRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateArtifact(\Google\Cloud\Aiplatform\V1beta1\UpdateArtifactRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/UpdateArtifact',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Artifact', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a Context associated with a MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateContextRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateContext(\Google\Cloud\Aiplatform\V1beta1\CreateContextRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/CreateContext',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Context', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a specific Context.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetContextRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetContext(\Google\Cloud\Aiplatform\V1beta1\GetContextRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/GetContext',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Context', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Contexts on the MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListContextsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListContexts(\Google\Cloud\Aiplatform\V1beta1\ListContextsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/ListContexts',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListContextsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a stored Context.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateContextRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateContext(\Google\Cloud\Aiplatform\V1beta1\UpdateContextRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/UpdateContext',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Context', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a stored Context.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteContextRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteContext(\Google\Cloud\Aiplatform\V1beta1\DeleteContextRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/DeleteContext',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a set of Artifacts and Executions to a Context. If any of the
     * Artifacts or Executions have already been added to a Context, they are
     * simply skipped.
     * @param \Google\Cloud\Aiplatform\V1beta1\AddContextArtifactsAndExecutionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AddContextArtifactsAndExecutions(\Google\Cloud\Aiplatform\V1beta1\AddContextArtifactsAndExecutionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/AddContextArtifactsAndExecutions',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\AddContextArtifactsAndExecutionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a set of Contexts as children to a parent Context. If any of the
     * child Contexts have already been added to the parent Context, they are
     * simply skipped. If this call would create a cycle or cause any Context to
     * have more than 10 parents, the request will fail with INVALID_ARGUMENT
     * error.
     * @param \Google\Cloud\Aiplatform\V1beta1\AddContextChildrenRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AddContextChildren(\Google\Cloud\Aiplatform\V1beta1\AddContextChildrenRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/AddContextChildren',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\AddContextChildrenResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves Artifacts and Executions within the specified Context, connected
     * by Event edges and returned as a LineageSubgraph.
     * @param \Google\Cloud\Aiplatform\V1beta1\QueryContextLineageSubgraphRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryContextLineageSubgraph(\Google\Cloud\Aiplatform\V1beta1\QueryContextLineageSubgraphRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/QueryContextLineageSubgraph',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\LineageSubgraph', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an Execution associated with a MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateExecutionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateExecution(\Google\Cloud\Aiplatform\V1beta1\CreateExecutionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/CreateExecution',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Execution', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a specific Execution.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetExecutionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetExecution(\Google\Cloud\Aiplatform\V1beta1\GetExecutionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/GetExecution',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Execution', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Executions in the MetadataStore.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListExecutionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListExecutions(\Google\Cloud\Aiplatform\V1beta1\ListExecutionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/ListExecutions',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListExecutionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a stored Execution.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateExecutionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateExecution(\Google\Cloud\Aiplatform\V1beta1\UpdateExecutionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/UpdateExecution',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Execution', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds Events for denoting whether each Artifact was an input or output for a
     * given Execution. If any Events already exist between the Execution and any
     * of the specified Artifacts they are simply skipped.
     * @param \Google\Cloud\Aiplatform\V1beta1\AddExecutionEventsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AddExecutionEvents(\Google\Cloud\Aiplatform\V1beta1\AddExecutionEventsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/AddExecutionEvents',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\AddExecutionEventsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Obtains the set of input and output Artifacts for this Execution, in the
     * form of LineageSubgraph that also contains the Execution and connecting
     * Events.
     * @param \Google\Cloud\Aiplatform\V1beta1\QueryExecutionInputsAndOutputsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryExecutionInputsAndOutputs(\Google\Cloud\Aiplatform\V1beta1\QueryExecutionInputsAndOutputsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/QueryExecutionInputsAndOutputs',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\LineageSubgraph', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an MetadataSchema.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateMetadataSchemaRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateMetadataSchema(\Google\Cloud\Aiplatform\V1beta1\CreateMetadataSchemaRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/CreateMetadataSchema',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\MetadataSchema', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a specific MetadataSchema.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetMetadataSchemaRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetMetadataSchema(\Google\Cloud\Aiplatform\V1beta1\GetMetadataSchemaRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/GetMetadataSchema',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\MetadataSchema', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists MetadataSchemas.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListMetadataSchemasRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListMetadataSchemas(\Google\Cloud\Aiplatform\V1beta1\ListMetadataSchemasRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/ListMetadataSchemas',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListMetadataSchemasResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves lineage of an Artifact represented through Artifacts and
     * Executions connected by Event edges and returned as a LineageSubgraph.
     * @param \Google\Cloud\Aiplatform\V1beta1\QueryArtifactLineageSubgraphRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryArtifactLineageSubgraph(\Google\Cloud\Aiplatform\V1beta1\QueryArtifactLineageSubgraphRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.MetadataService/QueryArtifactLineageSubgraph',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\LineageSubgraph', 'decode'],
        $metadata, $options);
    }

}
