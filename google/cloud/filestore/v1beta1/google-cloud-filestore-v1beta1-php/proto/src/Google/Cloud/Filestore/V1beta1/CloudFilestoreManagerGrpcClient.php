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
namespace Google\Cloud\Filestore\V1beta1;

/**
 * Configures and manages Cloud Filestore resources.
 *
 * Cloud Filestore Manager v1beta1.
 *
 * The `file.googleapis.com` service implements the Cloud Filestore API and
 * defines the following model for managing resources:
 * * The service works with a collection of cloud projects, named: `/projects/*`
 * * Each project has a collection of available locations, named: `/locations/*`
 * * Each location has a collection of instances and backups, named:
 * `/instances/*` and `/backups/*` respectively.
 * * As such, Cloud Filestore instances are resources of the form:
 *   `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
 *   backups are resources of the form:
 *   `/projects/{project_id}/locations/{location_id}/backup/{backup_id}`
 *
 * Note that location_id can represent a GCP `zone` or `region` depending on the
 * resource.
 * for example:
 * A zonal Filestore instance:
 * * `projects/my-project/locations/us-central1-c/instances/my-basic-tier-filer`
 * A regional Filestore instance:
 * * `projects/my-project/locations/us-central1/instances/my-enterprise-filer`
 */
class CloudFilestoreManagerGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists all instances in a project for either a specified location
     * or for all locations.
     * @param \Google\Cloud\Filestore\V1beta1\ListInstancesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListInstances(\Google\Cloud\Filestore\V1beta1\ListInstancesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/ListInstances',
        $argument,
        ['\Google\Cloud\Filestore\V1beta1\ListInstancesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the details of a specific instance.
     * @param \Google\Cloud\Filestore\V1beta1\GetInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetInstance(\Google\Cloud\Filestore\V1beta1\GetInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/GetInstance',
        $argument,
        ['\Google\Cloud\Filestore\V1beta1\Instance', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an instance.
     * When creating from a backup, the capacity of the new instance needs to be
     * equal to or larger than the capacity of the backup (and also equal to or
     * larger than the minimum capacity of the tier).
     * @param \Google\Cloud\Filestore\V1beta1\CreateInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateInstance(\Google\Cloud\Filestore\V1beta1\CreateInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/CreateInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the settings of a specific instance.
     * @param \Google\Cloud\Filestore\V1beta1\UpdateInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateInstance(\Google\Cloud\Filestore\V1beta1\UpdateInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/UpdateInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Restores an existing instance's file share from a backup.
     *
     * The capacity of the instance needs to be equal to or larger than the
     * capacity of the backup (and also equal to or larger than the minimum
     * capacity of the tier).
     * @param \Google\Cloud\Filestore\V1beta1\RestoreInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RestoreInstance(\Google\Cloud\Filestore\V1beta1\RestoreInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/RestoreInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes an instance.
     * @param \Google\Cloud\Filestore\V1beta1\DeleteInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteInstance(\Google\Cloud\Filestore\V1beta1\DeleteInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/DeleteInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all backups in a project for either a specified location or for all
     * locations.
     * @param \Google\Cloud\Filestore\V1beta1\ListBackupsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListBackups(\Google\Cloud\Filestore\V1beta1\ListBackupsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/ListBackups',
        $argument,
        ['\Google\Cloud\Filestore\V1beta1\ListBackupsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the details of a specific backup.
     * @param \Google\Cloud\Filestore\V1beta1\GetBackupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetBackup(\Google\Cloud\Filestore\V1beta1\GetBackupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/GetBackup',
        $argument,
        ['\Google\Cloud\Filestore\V1beta1\Backup', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a backup.
     * @param \Google\Cloud\Filestore\V1beta1\CreateBackupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateBackup(\Google\Cloud\Filestore\V1beta1\CreateBackupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/CreateBackup',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a backup.
     * @param \Google\Cloud\Filestore\V1beta1\DeleteBackupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteBackup(\Google\Cloud\Filestore\V1beta1\DeleteBackupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/DeleteBackup',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the settings of a specific backup.
     * @param \Google\Cloud\Filestore\V1beta1\UpdateBackupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateBackup(\Google\Cloud\Filestore\V1beta1\UpdateBackupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.filestore.v1beta1.CloudFilestoreManager/UpdateBackup',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
