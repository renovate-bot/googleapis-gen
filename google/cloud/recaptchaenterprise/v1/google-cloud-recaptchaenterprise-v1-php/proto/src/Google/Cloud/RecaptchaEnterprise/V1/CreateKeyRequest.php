<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/recaptchaenterprise/v1/recaptchaenterprise.proto

namespace Google\Cloud\RecaptchaEnterprise\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The create key request message.
 *
 * Generated from protobuf message <code>google.cloud.recaptchaenterprise.v1.CreateKeyRequest</code>
 */
class CreateKeyRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the project in which the key will be created, in the
     * format "projects/{project}".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. Information to create a reCAPTCHA Enterprise key.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1.Key key = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $key = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the project in which the key will be created, in the
     *           format "projects/{project}".
     *     @type \Google\Cloud\RecaptchaEnterprise\V1\Key $key
     *           Required. Information to create a reCAPTCHA Enterprise key.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Recaptchaenterprise\V1\Recaptchaenterprise::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the project in which the key will be created, in the
     * format "projects/{project}".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the project in which the key will be created, in the
     * format "projects/{project}".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. Information to create a reCAPTCHA Enterprise key.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1.Key key = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\RecaptchaEnterprise\V1\Key|null
     */
    public function getKey()
    {
        return isset($this->key) ? $this->key : null;
    }

    public function hasKey()
    {
        return isset($this->key);
    }

    public function clearKey()
    {
        unset($this->key);
    }

    /**
     * Required. Information to create a reCAPTCHA Enterprise key.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1.Key key = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\RecaptchaEnterprise\V1\Key $var
     * @return $this
     */
    public function setKey($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecaptchaEnterprise\V1\Key::class);
        $this->key = $var;

        return $this;
    }

}

