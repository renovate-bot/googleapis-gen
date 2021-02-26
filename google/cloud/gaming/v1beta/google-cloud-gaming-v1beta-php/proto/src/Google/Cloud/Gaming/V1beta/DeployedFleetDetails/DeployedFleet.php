<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/common.proto

namespace Google\Cloud\Gaming\V1beta\DeployedFleetDetails;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Agones fleet specification and details.
 *
 * Generated from protobuf message <code>google.cloud.gaming.v1beta.DeployedFleetDetails.DeployedFleet</code>
 */
class DeployedFleet extends \Google\Protobuf\Internal\Message
{
    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet = 1;</code>
     */
    protected $fleet = '';
    /**
     * The fleet spec retrieved from the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet_spec = 2;</code>
     */
    protected $fleet_spec = '';
    /**
     * The source spec that is used to create the Agones fleet.
     * The GameServerConfig resource may no longer exist in the system.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 3;</code>
     */
    protected $spec_source = null;
    /**
     * The current status of the Agones fleet.
     * Includes count of game servers in various states.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.DeployedFleetDetails.DeployedFleet.DeployedFleetStatus status = 5;</code>
     */
    protected $status = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $fleet
     *           The name of the Agones fleet.
     *     @type string $fleet_spec
     *           The fleet spec retrieved from the Agones fleet.
     *     @type \Google\Cloud\Gaming\V1beta\SpecSource $spec_source
     *           The source spec that is used to create the Agones fleet.
     *           The GameServerConfig resource may no longer exist in the system.
     *     @type \Google\Cloud\Gaming\V1beta\DeployedFleetDetails\DeployedFleet\DeployedFleetStatus $status
     *           The current status of the Agones fleet.
     *           Includes count of game servers in various states.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\Common::initOnce();
        parent::__construct($data);
    }

    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet = 1;</code>
     * @return string
     */
    public function getFleet()
    {
        return $this->fleet;
    }

    /**
     * The name of the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setFleet($var)
    {
        GPBUtil::checkString($var, True);
        $this->fleet = $var;

        return $this;
    }

    /**
     * The fleet spec retrieved from the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet_spec = 2;</code>
     * @return string
     */
    public function getFleetSpec()
    {
        return $this->fleet_spec;
    }

    /**
     * The fleet spec retrieved from the Agones fleet.
     *
     * Generated from protobuf field <code>string fleet_spec = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setFleetSpec($var)
    {
        GPBUtil::checkString($var, True);
        $this->fleet_spec = $var;

        return $this;
    }

    /**
     * The source spec that is used to create the Agones fleet.
     * The GameServerConfig resource may no longer exist in the system.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 3;</code>
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
     * The source spec that is used to create the Agones fleet.
     * The GameServerConfig resource may no longer exist in the system.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.SpecSource spec_source = 3;</code>
     * @param \Google\Cloud\Gaming\V1beta\SpecSource $var
     * @return $this
     */
    public function setSpecSource($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1beta\SpecSource::class);
        $this->spec_source = $var;

        return $this;
    }

    /**
     * The current status of the Agones fleet.
     * Includes count of game servers in various states.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.DeployedFleetDetails.DeployedFleet.DeployedFleetStatus status = 5;</code>
     * @return \Google\Cloud\Gaming\V1beta\DeployedFleetDetails\DeployedFleet\DeployedFleetStatus|null
     */
    public function getStatus()
    {
        return isset($this->status) ? $this->status : null;
    }

    public function hasStatus()
    {
        return isset($this->status);
    }

    public function clearStatus()
    {
        unset($this->status);
    }

    /**
     * The current status of the Agones fleet.
     * Includes count of game servers in various states.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.DeployedFleetDetails.DeployedFleet.DeployedFleetStatus status = 5;</code>
     * @param \Google\Cloud\Gaming\V1beta\DeployedFleetDetails\DeployedFleet\DeployedFleetStatus $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1beta\DeployedFleetDetails\DeployedFleet\DeployedFleetStatus::class);
        $this->status = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(DeployedFleet::class, \Google\Cloud\Gaming\V1beta\DeployedFleetDetails_DeployedFleet::class);

