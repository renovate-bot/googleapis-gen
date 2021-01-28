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
namespace Google\Home\Graph\V1;

/**
 * Google Home Graph API service. The Home Graph service provides support for
 * accessing first-party and third-party devices stored in Google's Home Graph.
 * The Home Graph database provides contextual data about the relationships
 * between devices and the home.
 *
 * For more details, see the [Home Graph developer
 * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
 */
class HomeGraphApiServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     *
     *
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * @param \Google\Home\Graph\V1\RequestSyncDevicesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RequestSyncDevices(\Google\Home\Graph\V1\RequestSyncDevicesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.graph.v1.HomeGraphApiService/RequestSyncDevices',
        $argument,
        ['\Google\Home\Graph\V1\RequestSyncDevicesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     *
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * @param \Google\Home\Graph\V1\ReportStateAndNotificationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ReportStateAndNotification(\Google\Home\Graph\V1\ReportStateAndNotificationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.graph.v1.HomeGraphApiService/ReportStateAndNotification',
        $argument,
        ['\Google\Home\Graph\V1\ReportStateAndNotificationResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     *
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * @param \Google\Home\Graph\V1\DeleteAgentUserRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteAgentUser(\Google\Home\Graph\V1\DeleteAgentUserRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.graph.v1.HomeGraphApiService/DeleteAgentUser',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * @param \Google\Home\Graph\V1\QueryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function Query(\Google\Home\Graph\V1\QueryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.graph.v1.HomeGraphApiService/Query',
        $argument,
        ['\Google\Home\Graph\V1\QueryResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets all the devices associated with the given third-party user.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * @param \Google\Home\Graph\V1\SyncRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function Sync(\Google\Home\Graph\V1\SyncRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.home.graph.v1.HomeGraphApiService/Sync',
        $argument,
        ['\Google\Home\Graph\V1\SyncResponse', 'decode'],
        $metadata, $options);
    }

}
