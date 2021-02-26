<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1p4beta1/image_annotator.proto

namespace Google\Cloud\Vision\V1p4beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Contains metadata for the BatchAnnotateImages operation.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1p4beta1.OperationMetadata</code>
 */
class OperationMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Current state of the batch operation.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p4beta1.OperationMetadata.State state = 1;</code>
     */
    protected $state = 0;
    /**
     * The time when the batch request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 5;</code>
     */
    protected $create_time = null;
    /**
     * The time when the operation result was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6;</code>
     */
    protected $update_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $state
     *           Current state of the batch operation.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           The time when the batch request was received.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           The time when the operation result was last updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1P4Beta1\ImageAnnotator::initOnce();
        parent::__construct($data);
    }

    /**
     * Current state of the batch operation.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p4beta1.OperationMetadata.State state = 1;</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * Current state of the batch operation.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p4beta1.OperationMetadata.State state = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Vision\V1p4beta1\OperationMetadata\State::class);
        $this->state = $var;

        return $this;
    }

    /**
     * The time when the batch request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 5;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return isset($this->create_time) ? $this->create_time : null;
    }

    public function hasCreateTime()
    {
        return isset($this->create_time);
    }

    public function clearCreateTime()
    {
        unset($this->create_time);
    }

    /**
     * The time when the batch request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 5;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->create_time = $var;

        return $this;
    }

    /**
     * The time when the operation result was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUpdateTime()
    {
        return isset($this->update_time) ? $this->update_time : null;
    }

    public function hasUpdateTime()
    {
        return isset($this->update_time);
    }

    public function clearUpdateTime()
    {
        unset($this->update_time);
    }

    /**
     * The time when the operation result was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

}

