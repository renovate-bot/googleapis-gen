<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/v1beta/guest_policies.proto

namespace Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A guest policy recipe including its source.
 *
 * Generated from protobuf message <code>google.cloud.osconfig.v1beta.EffectiveGuestPolicy.SourcedSoftwareRecipe</code>
 */
class SourcedSoftwareRecipe extends \Google\Protobuf\Internal\Message
{
    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     */
    protected $source = '';
    /**
     * A software recipe to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.SoftwareRecipe software_recipe = 2;</code>
     */
    protected $software_recipe = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $source
     *           Name of the guest policy providing this config.
     *     @type \Google\Cloud\Osconfig\V1beta\SoftwareRecipe $software_recipe
     *           A software recipe to configure on the VM instance.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Osconfig\V1Beta\GuestPolicies::initOnce();
        parent::__construct($data);
    }

    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     * @return string
     */
    public function getSource()
    {
        return $this->source;
    }

    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setSource($var)
    {
        GPBUtil::checkString($var, True);
        $this->source = $var;

        return $this;
    }

    /**
     * A software recipe to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.SoftwareRecipe software_recipe = 2;</code>
     * @return \Google\Cloud\Osconfig\V1beta\SoftwareRecipe|null
     */
    public function getSoftwareRecipe()
    {
        return isset($this->software_recipe) ? $this->software_recipe : null;
    }

    public function hasSoftwareRecipe()
    {
        return isset($this->software_recipe);
    }

    public function clearSoftwareRecipe()
    {
        unset($this->software_recipe);
    }

    /**
     * A software recipe to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.SoftwareRecipe software_recipe = 2;</code>
     * @param \Google\Cloud\Osconfig\V1beta\SoftwareRecipe $var
     * @return $this
     */
    public function setSoftwareRecipe($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Osconfig\V1beta\SoftwareRecipe::class);
        $this->software_recipe = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(SourcedSoftwareRecipe::class, \Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy_SourcedSoftwareRecipe::class);

