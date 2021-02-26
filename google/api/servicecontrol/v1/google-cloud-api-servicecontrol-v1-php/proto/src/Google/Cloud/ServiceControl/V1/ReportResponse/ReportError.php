<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/api/servicecontrol/v1/service_controller.proto

namespace Google\Cloud\ServiceControl\V1\ReportResponse;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents the processing error of one [Operation][google.api.servicecontrol.v1.Operation] in the request.
 *
 * Generated from protobuf message <code>google.api.servicecontrol.v1.ReportResponse.ReportError</code>
 */
class ReportError extends \Google\Protobuf\Internal\Message
{
    /**
     * The [Operation.operation_id][google.api.servicecontrol.v1.Operation.operation_id] value from the request.
     *
     * Generated from protobuf field <code>string operation_id = 1;</code>
     */
    protected $operation_id = '';
    /**
     * Details of the error when processing the [Operation][google.api.servicecontrol.v1.Operation].
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     */
    protected $status = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $operation_id
     *           The [Operation.operation_id][google.api.servicecontrol.v1.Operation.operation_id] value from the request.
     *     @type \Google\Rpc\Status $status
     *           Details of the error when processing the [Operation][google.api.servicecontrol.v1.Operation].
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Api\Servicecontrol\V1\ServiceController::initOnce();
        parent::__construct($data);
    }

    /**
     * The [Operation.operation_id][google.api.servicecontrol.v1.Operation.operation_id] value from the request.
     *
     * Generated from protobuf field <code>string operation_id = 1;</code>
     * @return string
     */
    public function getOperationId()
    {
        return $this->operation_id;
    }

    /**
     * The [Operation.operation_id][google.api.servicecontrol.v1.Operation.operation_id] value from the request.
     *
     * Generated from protobuf field <code>string operation_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setOperationId($var)
    {
        GPBUtil::checkString($var, True);
        $this->operation_id = $var;

        return $this;
    }

    /**
     * Details of the error when processing the [Operation][google.api.servicecontrol.v1.Operation].
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getStatus()
    {
        return isset($this->status) ? $this->status : null;
    }

    public function hasStatus()
    {
        return isset($this->status);
    }

    public function clearStatus()
    {
        unset($this->status);
    }

    /**
     * Details of the error when processing the [Operation][google.api.servicecontrol.v1.Operation].
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->status = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ReportError::class, \Google\Cloud\ServiceControl\V1\ReportResponse_ReportError::class);

