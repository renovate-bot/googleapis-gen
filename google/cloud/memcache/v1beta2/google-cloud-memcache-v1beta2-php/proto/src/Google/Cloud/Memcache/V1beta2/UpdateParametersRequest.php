<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/memcache/v1beta2/cloud_memcache.proto

namespace Google\Cloud\Memcache\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request for [UpdateParameters][google.cloud.memcache.v1beta2.CloudMemcache.UpdateParameters].
 *
 * Generated from protobuf message <code>google.cloud.memcache.v1beta2.UpdateParametersRequest</code>
 */
class UpdateParametersRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Resource name of the Memcached instance for which the parameters should be
     * updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. Mask of fields to update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;
    /**
     * The parameters to apply to the instance.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1beta2.MemcacheParameters parameters = 3;</code>
     */
    protected $parameters = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. Resource name of the Memcached instance for which the parameters should be
     *           updated.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. Mask of fields to update.
     *     @type \Google\Cloud\Memcache\V1beta2\MemcacheParameters $parameters
     *           The parameters to apply to the instance.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Memcache\V1Beta2\CloudMemcache::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Resource name of the Memcached instance for which the parameters should be
     * updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. Resource name of the Memcached instance for which the parameters should be
     * updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. Mask of fields to update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * The parameters to apply to the instance.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1beta2.MemcacheParameters parameters = 3;</code>
     * @return \Google\Cloud\Memcache\V1beta2\MemcacheParameters|null
     */
    public function getParameters()
    {
        return isset($this->parameters) ? $this->parameters : null;
    }

    public function hasParameters()
    {
        return isset($this->parameters);
    }

    public function clearParameters()
    {
        unset($this->parameters);
    }

    /**
     * The parameters to apply to the instance.
     *
     * Generated from protobuf field <code>.google.cloud.memcache.v1beta2.MemcacheParameters parameters = 3;</code>
     * @param \Google\Cloud\Memcache\V1beta2\MemcacheParameters $var
     * @return $this
     */
    public function setParameters($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Memcache\V1beta2\MemcacheParameters::class);
        $this->parameters = $var;

        return $this;
    }

}

