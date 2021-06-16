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
namespace Maps\Fleetengine\V1;

/**
 * Vehicle management service.
 */
class VehicleServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * CreateVehicle instantiates a new vehicle associated with a rideshare
     * provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
     *
     * The following Vehicle fields are required when creating a Vehicle:
     *
     * * vehicleState
     * * supportedTripTypes
     * * maximumCapacity
     * * vehicleType
     *
     * The following Vehicle fields are ignored when creating a Vehicle:
     *
     * * name
     * * currentTrips
     * * availableCapacity
     * * current_route_segment
     * * current_route_segment_version
     * * waypoint
     * * waypoints_version
     * * remaining_distance_meters
     * * eta_to_next_waypoint
     * * navigation_status
     *
     * All other fields are optional and used if provided.
     * @param \Maps\Fleetengine\V1\CreateVehicleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateVehicle(\Maps\Fleetengine\V1\CreateVehicleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/CreateVehicle',
        $argument,
        ['\Maps\Fleetengine\V1\Vehicle', 'decode'],
        $metadata, $options);
    }

    /**
     * GetVehicle returns a vehicle from the Fleet Engine.
     * @param \Maps\Fleetengine\V1\GetVehicleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetVehicle(\Maps\Fleetengine\V1\GetVehicleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/GetVehicle',
        $argument,
        ['\Maps\Fleetengine\V1\Vehicle', 'decode'],
        $metadata, $options);
    }

    /**
     * UpdateVehicle writes updated vehicle data to the Fleet Engine.
     *
     * When updating a Vehicle, the following fields cannot be updated since they
     * are managed by the Fleet Engine:
     *
     * * currentTrips
     * * availableCapacity
     * * current_route_segment_version
     * * waypoints_version
     *
     * The vehicle name also cannot be updated.
     *
     * The waypoints field can be updated, but must contain all the waypoints
     * currently on the vehicle, and no other waypoints.
     * @param \Maps\Fleetengine\V1\UpdateVehicleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateVehicle(\Maps\Fleetengine\V1\UpdateVehicleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/UpdateVehicle',
        $argument,
        ['\Maps\Fleetengine\V1\Vehicle', 'decode'],
        $metadata, $options);
    }

    /**
     * UpdateVehicleLocation updates the location of the vehicle.
     * This method is deprecated. Use UpdateVehicle method instead.
     * @param \Maps\Fleetengine\V1\UpdateVehicleLocationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateVehicleLocation(\Maps\Fleetengine\V1\UpdateVehicleLocationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/UpdateVehicleLocation',
        $argument,
        ['\Maps\Fleetengine\V1\VehicleLocation', 'decode'],
        $metadata, $options);
    }

    /**
     * UpdateVehicleAttributes partially updates a vehicle's attributes.
     * Only the attributes mentioned in the request will be updated, other
     * attributes will NOT be altered. Note: this is different in UpdateVehicle,
     * where the whole `attributes` field will be replaced by the one in
     * UpdateVehicleRequest, attributes not in the request would be removed.
     * @param \Maps\Fleetengine\V1\UpdateVehicleAttributesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateVehicleAttributes(\Maps\Fleetengine\V1\UpdateVehicleAttributesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/UpdateVehicleAttributes',
        $argument,
        ['\Maps\Fleetengine\V1\UpdateVehicleAttributesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * ListVehicles returns a paginated list of vehicles associated with
     * a provider that match the request options.
     * @param \Maps\Fleetengine\V1\ListVehiclesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListVehicles(\Maps\Fleetengine\V1\ListVehiclesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/ListVehicles',
        $argument,
        ['\Maps\Fleetengine\V1\ListVehiclesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * SearchVehicles returns a list of vehicles that match the request options.
     * @param \Maps\Fleetengine\V1\SearchVehiclesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SearchVehicles(\Maps\Fleetengine\V1\SearchVehiclesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/SearchVehicles',
        $argument,
        ['\Maps\Fleetengine\V1\SearchVehiclesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * SearchFuzzedVehicles returns a list of vehicles that match the request
     * options with their locations fuzzed.
     * Request does not support 'order_by' field.
     * Vehicle matches in response will be in order of distance from pickup point.
     * Vehicle matches in response will only have 'vehicle' and 'trip_type' field
     * set.
     * @param \Maps\Fleetengine\V1\SearchVehiclesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SearchFuzzedVehicles(\Maps\Fleetengine\V1\SearchVehiclesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.VehicleService/SearchFuzzedVehicles',
        $argument,
        ['\Maps\Fleetengine\V1\SearchVehiclesResponse', 'decode'],
        $metadata, $options);
    }

}
