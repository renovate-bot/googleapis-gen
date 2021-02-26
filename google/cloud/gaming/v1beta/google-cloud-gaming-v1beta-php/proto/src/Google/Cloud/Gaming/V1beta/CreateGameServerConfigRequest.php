<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/game_server_configs.proto

namespace Google\Cloud\Gaming\V1beta;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for GameServerConfigsService.CreateGameServerConfig.
 *
 * Generated from protobuf message <code>google.cloud.gaming.v1beta.CreateGameServerConfigRequest</code>
 */
class CreateGameServerConfigRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The parent resource name. Uses the form:
     * `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The ID of the game server config resource to be created.
     *
     * Generated from protobuf field <code>string config_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $config_id = '';
    /**
     * Required. The game server config resource to be created.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $game_server_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The parent resource name. Uses the form:
     *           `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
     *     @type string $config_id
     *           Required. The ID of the game server config resource to be created.
     *     @type \Google\Cloud\Gaming\V1beta\GameServerConfig $game_server_config
     *           Required. The game server config resource to be created.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\GameServerConfigs::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The parent resource name. Uses the form:
     * `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The parent resource name. Uses the form:
     * `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
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
     * Required. The ID of the game server config resource to be created.
     *
     * Generated from protobuf field <code>string config_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getConfigId()
    {
        return $this->config_id;
    }

    /**
     * Required. The ID of the game server config resource to be created.
     *
     * Generated from protobuf field <code>string config_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setConfigId($var)
    {
        GPBUtil::checkString($var, True);
        $this->config_id = $var;

        return $this;
    }

    /**
     * Required. The game server config resource to be created.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Gaming\V1beta\GameServerConfig|null
     */
    public function getGameServerConfig()
    {
        return isset($this->game_server_config) ? $this->game_server_config : null;
    }

    public function hasGameServerConfig()
    {
        return isset($this->game_server_config);
    }

    public function clearGameServerConfig()
    {
        unset($this->game_server_config);
    }

    /**
     * Required. The game server config resource to be created.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1beta.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Gaming\V1beta\GameServerConfig $var
     * @return $this
     */
    public function setGameServerConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1beta\GameServerConfig::class);
        $this->game_server_config = $var;

        return $this;
    }

}

