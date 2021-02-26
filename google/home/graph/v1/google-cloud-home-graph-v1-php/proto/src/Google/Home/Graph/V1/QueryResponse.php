<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/home/graph/v1/homegraph.proto

namespace Google\Home\Graph\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response type for the
 * [`Query`](#google.home.graph.v1.HomeGraphApiService.Query) call.
 * This should follow the same format as the Google smart home
 * `action.devices.QUERY`
 * [response](https://developers.google.com/assistant/smarthome/reference/intent/query).
 * # Example
 * ```json
 * {
 *   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
 *   "payload": {
 *     "devices": {
 *       "123": {
 *         "on": true,
 *         "online": true
 *       },
 *       "456": {
 *         "on": true,
 *         "online": true,
 *         "brightness": 80,
 *         "color": {
 *           "name": "cerulean",
 *           "spectrumRGB": 31655
 *         }
 *       }
 *     }
 *   }
 * }
 * ```
 *
 * Generated from protobuf message <code>google.home.graph.v1.QueryResponse</code>
 */
class QueryResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Request ID used for debugging. Copied from the request.
     *
     * Generated from protobuf field <code>string request_id = 1;</code>
     */
    protected $request_id = '';
    /**
     * Device states for the devices given in the request.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.QueryResponsePayload payload = 2;</code>
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
     *     @type \Google\Home\Graph\V1\QueryResponsePayload $payload
     *           Device states for the devices given in the request.
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
     * Device states for the devices given in the request.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.QueryResponsePayload payload = 2;</code>
     * @return \Google\Home\Graph\V1\QueryResponsePayload|null
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
     * Device states for the devices given in the request.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.QueryResponsePayload payload = 2;</code>
     * @param \Google\Home\Graph\V1\QueryResponsePayload $var
     * @return $this
     */
    public function setPayload($var)
    {
        GPBUtil::checkMessage($var, \Google\Home\Graph\V1\QueryResponsePayload::class);
        $this->payload = $var;

        return $this;
    }

}

