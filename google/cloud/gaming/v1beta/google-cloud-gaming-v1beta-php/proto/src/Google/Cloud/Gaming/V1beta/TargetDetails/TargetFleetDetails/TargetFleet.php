<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/common.proto

namespace Google\Cloud\Gaming\V1beta\TargetDetails\TargetFleetDetails;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Target Agones fleet specification.
 *
 * Generated from protobuf message <code>google.cloud.gaming.v1beta.TargetDetails.TargetFleetDetails.TargetFleet</code>
 */
class TargetFleet extends \Google\Protobuf\Internal\Message
{
    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Encapsulates the source of the Agones fleet spec.
     * The Agones fleet spec source.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 2;</code>
     */
    protected $spec_source = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The name of the Agones fleet.
     *     @type \Google\Cloud\Gaming\V1beta\SpecSource $spec_source
     *           Encapsulates the source of the Agones fleet spec.
     *           The Agones fleet spec source.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\Common::initOnce();
        parent::__construct($data);
    }

    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * Encapsulates the source of the Agones fleet spec.
     * The Agones fleet spec source.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 2;</code>
     * @return \Google\Cloud\Gaming\V1beta\SpecSource|null
     */
    public function getSpecSource()
    {
        return isset($this->spec_source) ? $this->spec_source : null;
    }

    public function hasSpecSource()
    {
        return isset($this->spec_source);
    }

    public function clearSpecSource()
    {
        unset($this->spec_source);
    }

    /**
     * Encapsulates the source of the Agones fleet spec.
     * The Agones fleet spec source.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 2;</code>
     * @param \Google\Cloud\Gaming\V1beta\SpecSource $var
     * @return $this
     */
    public function setSpecSource($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1beta\SpecSource::class);
        $this->spec_source = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(TargetFleet::class, \Google\Cloud\Gaming\V1beta\TargetDetails_TargetFleetDetails_TargetFleet::class);

