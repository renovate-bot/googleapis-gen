<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/game_server_deployments.proto

namespace Google\Cloud\Gaming\V1beta;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response message for PreviewGameServerDeploymentRollout.
 * This has details about the Agones fleet and autoscaler to be actuated.
 *
 * Generated from protobuf message <code>google.cloud.gaming.v1beta.PreviewGameServerDeploymentRolloutResponse</code>
 */
class PreviewGameServerDeploymentRolloutResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Locations that could not be reached on this request.
     *
     * Generated from protobuf field <code>repeated string unavailable = 2;</code>
     */
    private $unavailable;
    /**
     * ETag of the game server deployment.
     *
     * Generated from protobuf field <code>string etag = 3;</code>
     */
    protected $etag = '';
    /**
     * The target state.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.TargetState target_state = 4;</code>
     */
    protected $target_state = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $unavailable
     *           Locations that could not be reached on this request.
     *     @type string $etag
     *           ETag of the game server deployment.
     *     @type \Google\Cloud\Gaming\V1beta\TargetState $target_state
     *           The target state.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\GameServerDeployments::initOnce();
        parent::__construct($data);
    }

    /**
     * Locations that could not be reached on this request.
     *
     * Generated from protobuf field <code>repeated string unavailable = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getUnavailable()
    {
        return $this->unavailable;
    }

    /**
     * Locations that could not be reached on this request.
     *
     * Generated from protobuf field <code>repeated string unavailable = 2;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setUnavailable($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->unavailable = $arr;

        return $this;
    }

    /**
     * ETag of the game server deployment.
     *
     * Generated from protobuf field <code>string etag = 3;</code>
     * @return string
     */
    public function getEtag()
    {
        return $this->etag;
    }

    /**
     * ETag of the game server deployment.
     *
     * Generated from protobuf field <code>string etag = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setEtag($var)
    {
        GPBUtil::checkString($var, True);
        $this->etag = $var;

        return $this;
    }

    /**
     * The target state.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.TargetState target_state = 4;</code>
     * @return \Google\Cloud\Gaming\V1beta\TargetState|null
     */
    public function getTargetState()
    {
        return isset($this->target_state) ? $this->target_state : null;
    }

    public function hasTargetState()
    {
        return isset($this->target_state);
    }

    public function clearTargetState()
    {
        unset($this->target_state);
    }

    /**
     * The target state.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.TargetState target_state = 4;</code>
     * @param \Google\Cloud\Gaming\V1beta\TargetState $var
     * @return $this
     */
    public function setTargetState($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1beta\TargetState::class);
        $this->target_state = $var;

        return $this;
    }

}

