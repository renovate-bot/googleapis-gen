<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/home/graph/v1/homegraph.proto

namespace Google\Home\Graph\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response type for the
 * [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync) call.
 * This should follow the same format as the Google smart home
 * `action.devices.SYNC`
 * [response](https://developers.google.com/assistant/smarthome/reference/intent/sync).
 * # Example
 * ```json
 * {
 *   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
 *   "payload": {
 *     "agentUserId": "1836.15267389",
 *     "devices": [{
 *       "id": "123",
 *       "type": "action.devices.types.OUTLET",
 *       "traits": [
 *         "action.devices.traits.OnOff"
 *       ],
 *       "name": {
 *         "defaultNames": ["My Outlet 1234"],
 *         "name": "Night light",
 *         "nicknames": ["wall plug"]
 *       },
 *       "willReportState": false,
 *       "deviceInfo": {
 *         "manufacturer": "lights-out-inc",
 *         "model": "hs1234",
 *         "hwVersion": "3.2",
 *         "swVersion": "11.4"
 *       },
 *       "customData": {
 *         "fooValue": 74,
 *         "barValue": true,
 *         "bazValue": "foo"
 *       }
 *     }]
 *   }
 * }
 * ```
 *
 * Generated from protobuf message <code>google.home.graph.v1.SyncResponse</code>
 */
class SyncResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Request ID used for debugging. Copied from the request.
     *
     * Generated from protobuf field <code>string request_id = 1;</code>
     */
    protected $request_id = '';
    /**
     * Devices associated with the third-party user.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.SyncResponsePayload payload = 2;</code>
     */
    protected $payload = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $request_id
     *           Request ID used for debugging. Copied from the request.
     *     @type \Google\Home\Graph\V1\SyncResponsePayload $payload
     *           Devices associated with the third-party user.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Home\Graph\V1\Homegraph::initOnce();
        parent::__construct($data);
    }

    /**
     * Request ID used for debugging. Copied from the request.
     *
     * Generated from protobuf field <code>string request_id = 1;</code>
     * @return string
     */
    public function getRequestId()
    {
        return $this->request_id;
    }

    /**
     * Request ID used for debugging. Copied from the request.
     *
     * Generated from protobuf field <code>string request_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setRequestId($var)
    {
        GPBUtil::checkString($var, True);
        $this->request_id = $var;

        return $this;
    }

    /**
     * Devices associated with the third-party user.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.SyncResponsePayload payload = 2;</code>
     * @return \Google\Home\Graph\V1\SyncResponsePayload|null
     */
    public function getPayload()
    {
        return isset($this->payload) ? $this->payload : null;
    }

    public function hasPayload()
    {
        return isset($this->payload);
    }

    public function clearPayload()
    {
        unset($this->payload);
    }

    /**
     * Devices associated with the third-party user.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.SyncResponsePayload payload = 2;</code>
     * @param \Google\Home\Graph\V1\SyncResponsePayload $var
     * @return $this
     */
    public function setPayload($var)
    {
        GPBUtil::checkMessage($var, \Google\Home\Graph\V1\SyncResponsePayload::class);
        $this->payload = $var;

        return $this;
    }

}

