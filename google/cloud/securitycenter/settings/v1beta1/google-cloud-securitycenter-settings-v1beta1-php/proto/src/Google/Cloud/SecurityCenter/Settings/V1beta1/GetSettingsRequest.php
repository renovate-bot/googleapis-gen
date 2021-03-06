<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/settings/v1beta1/securitycenter_settings_service.proto

namespace Google\Cloud\SecurityCenter\Settings\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for GetSettings.
 *
 * Generated from protobuf message <code>google.cloud.securitycenter.settings.v1beta1.GetSettingsRequest</code>
 */
class GetSettingsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the settings to retrieve.
     * Formats:
     *  * `organizations/{organization}/settings`
     *  * `folders/{folder}/settings`
     *  * `projects/{project}/settings`
     *  * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
     *  * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
     *  * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the settings to retrieve.
     *           Formats:
     *            * `organizations/{organization}/settings`
     *            * `folders/{folder}/settings`
     *            * `projects/{project}/settings`
     *            * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
     *            * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
     *            * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Securitycenter\Settings\V1Beta1\SecuritycenterSettingsService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the settings to retrieve.
     * Formats:
     *  * `organizations/{organization}/settings`
     *  * `folders/{folder}/settings`
     *  * `projects/{project}/settings`
     *  * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
     *  * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
     *  * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the settings to retrieve.
     * Formats:
     *  * `organizations/{organization}/settings`
     *  * `folders/{folder}/settings`
     *  * `projects/{project}/settings`
     *  * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
     *  * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
     *  * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
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

}

