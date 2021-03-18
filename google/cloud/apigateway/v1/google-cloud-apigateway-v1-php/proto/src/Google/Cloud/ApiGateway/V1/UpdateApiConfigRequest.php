<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/apigateway/v1/apigateway.proto

namespace Google\Cloud\ApiGateway\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for ApiGatewayService.UpdateApiConfig
 *
 * Generated from protobuf message <code>google.cloud.apigateway.v1.UpdateApiConfigRequest</code>
 */
class UpdateApiConfigRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Field mask is used to specify the fields to be overwritten in the
     * ApiConfig resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    protected $update_mask = null;
    /**
     * Required. API Config resource.
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig api_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $api_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Field mask is used to specify the fields to be overwritten in the
     *           ApiConfig resource by the update.
     *           The fields specified in the update_mask are relative to the resource, not
     *           the full request. A field will be overwritten if it is in the mask. If the
     *           user does not provide a mask then all fields will be overwritten.
     *     @type \Google\Cloud\ApiGateway\V1\ApiConfig $api_config
     *           Required. API Config resource.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Apigateway\V1\Apigateway::initOnce();
        parent::__construct($data);
    }

    /**
     * Field mask is used to specify the fields to be overwritten in the
     * ApiConfig resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1;</code>
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
     * Field mask is used to specify the fields to be overwritten in the
     * ApiConfig resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 1;</code>
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
     * Required. API Config resource.
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig api_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\ApiGateway\V1\ApiConfig|null
     */
    public function getApiConfig()
    {
        return isset($this->api_config) ? $this->api_config : null;
    }

    public function hasApiConfig()
    {
        return isset($this->api_config);
    }

    public function clearApiConfig()
    {
        unset($this->api_config);
    }

    /**
     * Required. API Config resource.
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig api_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\ApiGateway\V1\ApiConfig $var
     * @return $this
     */
    public function setApiConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ApiGateway\V1\ApiConfig::class);
        $this->api_config = $var;

        return $this;
    }

}

