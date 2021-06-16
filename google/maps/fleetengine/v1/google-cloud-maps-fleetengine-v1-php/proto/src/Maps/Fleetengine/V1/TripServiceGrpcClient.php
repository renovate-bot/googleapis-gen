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
 * Trip management service.
 */
class TripServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a trip in the Fleet Engine and returns the new trip.
     * @param \Maps\Fleetengine\V1\CreateTripRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTrip(\Maps\Fleetengine\V1\CreateTripRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.TripService/CreateTrip',
        $argument,
        ['\Maps\Fleetengine\V1\Trip', 'decode'],
        $metadata, $options);
    }

    /**
     * Get information about a single trip.
     * @param \Maps\Fleetengine\V1\GetTripRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTrip(\Maps\Fleetengine\V1\GetTripRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.TripService/GetTrip',
        $argument,
        ['\Maps\Fleetengine\V1\Trip', 'decode'],
        $metadata, $options);
    }

    /**
     * Report billable trip usage.
     * @param \Maps\Fleetengine\V1\ReportBillableTripRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ReportBillableTrip(\Maps\Fleetengine\V1\ReportBillableTripRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.TripService/ReportBillableTrip',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Get all the trips for a specific vehicle.
     * @param \Maps\Fleetengine\V1\SearchTripsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SearchTrips(\Maps\Fleetengine\V1\SearchTripsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.TripService/SearchTrips',
        $argument,
        ['\Maps\Fleetengine\V1\SearchTripsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates trip data.
     * @param \Maps\Fleetengine\V1\UpdateTripRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTrip(\Maps\Fleetengine\V1\UpdateTripRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/maps.fleetengine.v1.TripService/UpdateTrip',
        $argument,
        ['\Maps\Fleetengine\V1\Trip', 'decode'],
        $metadata, $options);
    }

}
