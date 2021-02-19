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
namespace Google\Area120\Tables\V1alpha1;

/**
 * The Tables Service provides an API for reading and updating tables.
 * It defines the following resource model:
 *
 * - The API has a collection of [Table][google.area120.tables.v1alpha1.Table]
 *   resources, named `tables/*`
 *
 * - Each Table has a collection of [Row][google.area120.tables.v1alpha1.Row]
 *   resources, named `tables/&#42;/rows/*`
 *
 * - The API has a collection of
 *   [Workspace][google.area120.tables.v1alpha1.Workspace]
 *   resources, named `workspaces/*`.
 */
class TablesServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets a table. Returns NOT_FOUND if the table does not exist.
     * @param \Google\Area120\Tables\V1alpha1\GetTableRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTable(\Google\Area120\Tables\V1alpha1\GetTableRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/GetTable',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\Table', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists tables for the user.
     * @param \Google\Area120\Tables\V1alpha1\ListTablesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTables(\Google\Area120\Tables\V1alpha1\ListTablesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/ListTables',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\ListTablesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
     * @param \Google\Area120\Tables\V1alpha1\GetWorkspaceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetWorkspace(\Google\Area120\Tables\V1alpha1\GetWorkspaceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/GetWorkspace',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\Workspace', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists workspaces for the user.
     * @param \Google\Area120\Tables\V1alpha1\ListWorkspacesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListWorkspaces(\Google\Area120\Tables\V1alpha1\ListWorkspacesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/ListWorkspaces',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\ListWorkspacesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a row. Returns NOT_FOUND if the row does not exist in the table.
     * @param \Google\Area120\Tables\V1alpha1\GetRowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRow(\Google\Area120\Tables\V1alpha1\GetRowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/GetRow',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\Row', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists rows in a table. Returns NOT_FOUND if the table does not exist.
     * @param \Google\Area120\Tables\V1alpha1\ListRowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRows(\Google\Area120\Tables\V1alpha1\ListRowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/ListRows',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\ListRowsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a row.
     * @param \Google\Area120\Tables\V1alpha1\CreateRowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateRow(\Google\Area120\Tables\V1alpha1\CreateRowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/CreateRow',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\Row', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates multiple rows.
     * @param \Google\Area120\Tables\V1alpha1\BatchCreateRowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchCreateRows(\Google\Area120\Tables\V1alpha1\BatchCreateRowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/BatchCreateRows',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\BatchCreateRowsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a row.
     * @param \Google\Area120\Tables\V1alpha1\UpdateRowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateRow(\Google\Area120\Tables\V1alpha1\UpdateRowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/UpdateRow',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\Row', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates multiple rows.
     * @param \Google\Area120\Tables\V1alpha1\BatchUpdateRowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchUpdateRows(\Google\Area120\Tables\V1alpha1\BatchUpdateRowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/BatchUpdateRows',
        $argument,
        ['\Google\Area120\Tables\V1alpha1\BatchUpdateRowsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a row.
     * @param \Google\Area120\Tables\V1alpha1\DeleteRowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteRow(\Google\Area120\Tables\V1alpha1\DeleteRowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/DeleteRow',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes multiple rows.
     * @param \Google\Area120\Tables\V1alpha1\BatchDeleteRowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchDeleteRows(\Google\Area120\Tables\V1alpha1\BatchDeleteRowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.area120.tables.v1alpha1.TablesService/BatchDeleteRows',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
