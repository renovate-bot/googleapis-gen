<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/settings/v1beta1/component_settings.proto

namespace Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentSettings;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Settings for each detector.
 *
 * Generated from protobuf message <code>google.cloud.securitycenter.settings.v1beta1.ComponentSettings.DetectorSettings</code>
 */
class DetectorSettings extends \Google\Protobuf\Internal\Message
{
    /**
     * ENABLE to enable component, DISABLE to disable and INHERIT to inherit
     * setting from ancestors.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.settings.v1beta1.ComponentEnablementState state = 1;</code>
     */
    protected $state = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $state
     *           ENABLE to enable component, DISABLE to disable and INHERIT to inherit
     *           setting from ancestors.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Securitycenter\Settings\V1Beta1\ComponentSettings::initOnce();
        parent::__construct($data);
    }

    /**
     * ENABLE to enable component, DISABLE to disable and INHERIT to inherit
     * setting from ancestors.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.settings.v1beta1.ComponentEnablementState state = 1;</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * ENABLE to enable component, DISABLE to disable and INHERIT to inherit
     * setting from ancestors.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.settings.v1beta1.ComponentEnablementState state = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentEnablementState::class);
        $this->state = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(DetectorSettings::class, \Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentSettings_DetectorSettings::class);

