<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/memcache/v1/cloud_memcache.proto

namespace Google\Cloud\Memcache\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request for [UpdateInstance][google.cloud.memcache.v1.CloudMemcache.UpdateInstance].
 *
 * Generated from protobuf message <code>google.cloud.memcache.v1.UpdateInstanceRequest</code>
 */
class UpdateInstanceRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Mask of fields to update.
     *  *   `displayName`
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;
    /**
     * Required. A Memcached Instance.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1.Instance instance = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $instance = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. Mask of fields to update.
     *            *   `displayName`
     *     @type \Google\Cloud\Memcache\V1\Instance $instance
     *           Required. A Memcached Instance.
     *           Only fields specified in update_mask are updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Memcache\V1\CloudMemcache::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Mask of fields to update.
     *  *   `displayName`
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Required. Mask of fields to update.
     *  *   `displayName`
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

    /**
     * Required. A Memcached Instance.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1.Instance instance = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Memcache\V1\Instance|null
     */
    public function getInstance()
    {
        return isset($this->instance) ? $this->instance : null;
    }

    public function hasInstance()
    {
        return isset($this->instance);
    }

    public function clearInstance()
    {
        unset($this->instance);
    }

    /**
     * Required. A Memcached Instance.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1.Instance instance = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Memcache\V1\Instance $var
     * @return $this
     */
    public function setInstance($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Memcache\V1\Instance::class);
        $this->instance = $var;

        return $this;
    }

}

