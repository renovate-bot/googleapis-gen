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
namespace Google\Cloud\ArtifactRegistry\V1;

/**
 * The Artifact Registry API service.
 *
 * Artifact Registry is an artifact management system for storing artifacts
 * from different package management systems.
 *
 * The resources managed by this API are:
 *
 * * Repositories, which group packages and their data.
 * * Packages, which group versions and their tags.
 * * Versions, which are specific forms of a package.
 * * Tags, which represent alternative names for versions.
 * * Files, which contain content and are optionally associated with a Package
 *   or Version.
 */
class ArtifactRegistryGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists docker images.
     * @param \Google\Cloud\ArtifactRegistry\V1\ListDockerImagesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDockerImages(\Google\Cloud\ArtifactRegistry\V1\ListDockerImagesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.artifactregistry.v1.ArtifactRegistry/ListDockerImages',
        $argument,
        ['\Google\Cloud\ArtifactRegistry\V1\ListDockerImagesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists repositories.
     * @param \Google\Cloud\ArtifactRegistry\V1\ListRepositoriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRepositories(\Google\Cloud\ArtifactRegistry\V1\ListRepositoriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.artifactregistry.v1.ArtifactRegistry/ListRepositories',
        $argument,
        ['\Google\Cloud\ArtifactRegistry\V1\ListRepositoriesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a repository.
     * @param \Google\Cloud\ArtifactRegistry\V1\GetRepositoryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRepository(\Google\Cloud\ArtifactRegistry\V1\GetRepositoryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.artifactregistry.v1.ArtifactRegistry/GetRepository',
        $argument,
        ['\Google\Cloud\ArtifactRegistry\V1\Repository', 'decode'],
        $metadata, $options);
    }

}
