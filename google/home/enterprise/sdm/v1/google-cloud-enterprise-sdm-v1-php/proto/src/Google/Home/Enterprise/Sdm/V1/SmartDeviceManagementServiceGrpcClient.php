<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2020 Google LLC
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
namespace Google\Home\Enterprise\Sdm\V1;

/**
 * core::0122 is getting triggered by adding fields custom_name.
 * though, 0122 has exception for such field name as display_name. Due to
 * historical reasons we use custom_name for exactly same purpose, so it is
 * covered by that exception.
 *
 * A service that allows API consumers to provision and manage Google
 * Home structures and devices for enterprise use cases.
 */
class SmartDeviceManagementServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets a device managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\GetDeviceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetDevice(\Google\Home\Enterprise\Sdm\V1\GetDeviceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetDevice',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\Device', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists devices managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\ListDevicesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDevices(\Google\Home\Enterprise\Sdm\V1\ListDevicesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListDevices',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\ListDevicesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Executes a command to device managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\ExecuteDeviceCommandRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExecuteDeviceCommand(\Google\Home\Enterprise\Sdm\V1\ExecuteDeviceCommandRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ExecuteDeviceCommand',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\ExecuteDeviceCommandResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a structure managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\GetStructureRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetStructure(\Google\Home\Enterprise\Sdm\V1\GetStructureRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetStructure',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\Structure', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists structures managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\ListStructuresRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListStructures(\Google\Home\Enterprise\Sdm\V1\ListStructuresRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListStructures',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\ListStructuresResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a room managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\GetRoomRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRoom(\Google\Home\Enterprise\Sdm\V1\GetRoomRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetRoom',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\Room', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists rooms managed by the enterprise.
     * @param \Google\Home\Enterprise\Sdm\V1\ListRoomsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRooms(\Google\Home\Enterprise\Sdm\V1\ListRoomsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListRooms',
        $argument,
        ['\Google\Home\Enterprise\Sdm\V1\ListRoomsResponse', 'decode'],
        $metadata, $options);
    }

}
