<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/remoteworkers/v1test2/bots.proto

namespace Google\Devtools\Remoteworkers\V1test2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for UpdateBotSession.
 *
 * Generated from protobuf message <code>google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest</code>
 */
class UpdateBotSessionRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The bot session name. Must match bot_session.name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. The bot session resource to update.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotSession bot_session = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $bot_session = null;
    /**
     * Required. The fields on the bot that should be updated. See the BotSession resource
     * for which fields are updatable by which caller.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The bot session name. Must match bot_session.name.
     *     @type \Google\Devtools\Remoteworkers\V1test2\BotSession $bot_session
     *           Required. The bot session resource to update.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. The fields on the bot that should be updated. See the BotSession resource
     *           for which fields are updatable by which caller.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Remoteworkers\V1Test2\Bots::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The bot session name. Must match bot_session.name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The bot session name. Must match bot_session.name.
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

    /**
     * Required. The bot session resource to update.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotSession bot_session = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Devtools\Remoteworkers\V1test2\BotSession|null
     */
    public function getBotSession()
    {
        return isset($this->bot_session) ? $this->bot_session : null;
    }

    public function hasBotSession()
    {
        return isset($this->bot_session);
    }

    public function clearBotSession()
    {
        unset($this->bot_session);
    }

    /**
     * Required. The bot session resource to update.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotSession bot_session = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Devtools\Remoteworkers\V1test2\BotSession $var
     * @return $this
     */
    public function setBotSession($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Remoteworkers\V1test2\BotSession::class);
        $this->bot_session = $var;

        return $this;
    }

    /**
     * Required. The fields on the bot that should be updated. See the BotSession resource
     * for which fields are updatable by which caller.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask|null
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
     * Required. The fields on the bot that should be updated. See the BotSession resource
     * for which fields are updatable by which caller.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
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

