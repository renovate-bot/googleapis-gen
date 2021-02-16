<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/security_settings.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [SecuritySettingsService.UpdateSecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettingsService.UpdateSecuritySettings].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.UpdateSecuritySettingsRequest</code>
 */
class UpdateSecuritySettingsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. [SecuritySettings] object that contains values for each of the
     * fields to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $security_settings = null;
    /**
     * Required. The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings $security_settings
     *           Required. [SecuritySettings] object that contains values for each of the
     *           fields to update.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. The mask to control which fields get updated. If the mask is not present,
     *           all fields will be updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. [SecuritySettings] object that contains values for each of the
     * fields to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings
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
     * Required. [SecuritySettings] object that contains values for each of the
     * fields to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings security_settings = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings $var
     * @return $this
     */
    public function setSecuritySettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings::class);
        $this->security_settings = $var;

        return $this;
    }

    /**
     * Required. The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask
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
     * Required. The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
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

}

