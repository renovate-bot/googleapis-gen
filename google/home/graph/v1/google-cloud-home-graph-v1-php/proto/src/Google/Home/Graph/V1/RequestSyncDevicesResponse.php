<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/home/graph/v1/homegraph.proto

namespace Google\Home\Graph\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response type for the
 * [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
 * call.
 * Intentionally empty upon success. An HTTP response code is returned
 * with more details upon failure.
 *
 * Generated from protobuf message <code>google.home.graph.v1.RequestSyncDevicesResponse</code>
 */
class RequestSyncDevicesResponse extends \Google\Protobuf\Internal\Message
{

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Home\Graph\V1\Homegraph::initOnce();
        parent::__construct($data);
    }

}

