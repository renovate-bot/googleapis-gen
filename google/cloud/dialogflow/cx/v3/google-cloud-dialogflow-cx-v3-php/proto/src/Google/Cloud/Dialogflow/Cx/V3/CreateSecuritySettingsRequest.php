<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/security_settings.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [SecuritySettings.CreateSecuritySettings][].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.CreateSecuritySettingsRequest</code>
 */
class CreateSecuritySettingsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The location to create an [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The security settings to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $security_settings = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The location to create an [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
     *           Format: `projects/<Project ID>/locations/<Location ID>`.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings $security_settings
     *           Required. The security settings to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The location to create an [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The location to create an [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
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
     * Required. The security settings to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings|null
     */
    public function getSecuritySettings()
    {
        return isset($this->security_settings) ? $this->security_settings : null;
    }

    public function hasSecuritySettings()
    {
        return isset($this->security_settings);
    }

    public function clearSecuritySettings()
    {
        unset($this->security_settings);
    }

    /**
     * Required. The security settings to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings $var
     * @return $this
     */
    public function setSecuritySettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings::class);
        $this->security_settings = $var;

        return $this;
    }

}

