<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/remoteworkers/v1test2/bots.proto

namespace Google\Devtools\Remoteworkers\V1test2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A bot session represents the state of a bot while in continuous contact with
 * the server for a period of time. The session includes information about the
 * worker - that is, the *worker* (the physical or virtual hardware) is
 * considered to be a property of the bot (the software agent running on that
 * hardware), which is the reverse of real life, but more natural from the point
 * of the view of this API, which communicates solely with the bot and not
 * directly with the underlying worker.
 *
 * Generated from protobuf message <code>google.devtools.remoteworkers.v1test2.BotSession</code>
 */
class BotSession extends \Google\Protobuf\Internal\Message
{
    /**
     * The bot session name, as selected by the server. Output only during a call
     * to CreateBotSession.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * A unique bot ID within the farm used to persistently identify this bot over
     * time (i.e., over multiple sessions). This ID must be unique within a
     * farm. Typically, the bot ID will be the same as the name of the primary
     * device in the worker (e.g., what you'd get from typing `uname -n` on *nix),
     * but this is not required since a single device may allow multiple bots to
     * run on it, each with access to different resources. What is important is
     * that this ID is meaningful to humans, who might need to hunt a physical
     * machine down to fix it.
     * When CreateBotSession is successfully called with a bot_id, all prior
     * sessions with the same ID are invalidated. If a bot attempts to update an
     * invalid session, the server must reject that request, and may also
     * quarantine the other bot with the same bot IDs (ie, stop sending it new
     * leases and alert an admin).
     *
     * Generated from protobuf field <code>string bot_id = 2;</code>
     */
    protected $bot_id = '';
    /**
     * The status of the bot. This must be populated in every call to
     * UpdateBotSession.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotStatus status = 3;</code>
     */
    protected $status = 0;
    /**
     * A description of the worker hosting this bot. The Worker message is used
     * here in the Status context (see Worker for more information).  If multiple
     * bots are running on the worker, this field should only describe the
     * resources accessible from this bot.
     * During the call to CreateBotSession, the server may make arbitrary changes
     * to the worker's `server_properties` field (see that field for more
     * information). Otherwise, this field is input-only.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.Worker worker = 4;</code>
     */
    protected $worker = null;
    /**
     * A list of all leases that are a part of this session. See the Lease message
     * for details.
     *
     * Generated from protobuf field <code>repeated .google.devtools.remoteworkers.v1test2.Lease leases = 5;</code>
     */
    private $leases;
    /**
     * The time at which this bot session will expire, unless the bot calls
     * UpdateBotSession again. Output only.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 6;</code>
     */
    protected $expire_time = null;
    /**
     * The version of the bot code currently running. The server may use this
     * information to issue an admin action to tell the bot to update itself.
     *
     * Generated from protobuf field <code>string version = 7;</code>
     */
    protected $version = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The bot session name, as selected by the server. Output only during a call
     *           to CreateBotSession.
     *     @type string $bot_id
     *           A unique bot ID within the farm used to persistently identify this bot over
     *           time (i.e., over multiple sessions). This ID must be unique within a
     *           farm. Typically, the bot ID will be the same as the name of the primary
     *           device in the worker (e.g., what you'd get from typing `uname -n` on *nix),
     *           but this is not required since a single device may allow multiple bots to
     *           run on it, each with access to different resources. What is important is
     *           that this ID is meaningful to humans, who might need to hunt a physical
     *           machine down to fix it.
     *           When CreateBotSession is successfully called with a bot_id, all prior
     *           sessions with the same ID are invalidated. If a bot attempts to update an
     *           invalid session, the server must reject that request, and may also
     *           quarantine the other bot with the same bot IDs (ie, stop sending it new
     *           leases and alert an admin).
     *     @type int $status
     *           The status of the bot. This must be populated in every call to
     *           UpdateBotSession.
     *     @type \Google\Devtools\Remoteworkers\V1test2\Worker $worker
     *           A description of the worker hosting this bot. The Worker message is used
     *           here in the Status context (see Worker for more information).  If multiple
     *           bots are running on the worker, this field should only describe the
     *           resources accessible from this bot.
     *           During the call to CreateBotSession, the server may make arbitrary changes
     *           to the worker's `server_properties` field (see that field for more
     *           information). Otherwise, this field is input-only.
     *     @type \Google\Devtools\Remoteworkers\V1test2\Lease[]|\Google\Protobuf\Internal\RepeatedField $leases
     *           A list of all leases that are a part of this session. See the Lease message
     *           for details.
     *     @type \Google\Protobuf\Timestamp $expire_time
     *           The time at which this bot session will expire, unless the bot calls
     *           UpdateBotSession again. Output only.
     *     @type string $version
     *           The version of the bot code currently running. The server may use this
     *           information to issue an admin action to tell the bot to update itself.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Remoteworkers\V1Test2\Bots::initOnce();
        parent::__construct($data);
    }

    /**
     * The bot session name, as selected by the server. Output only during a call
     * to CreateBotSession.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The bot session name, as selected by the server. Output only during a call
     * to CreateBotSession.
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
     * A unique bot ID within the farm used to persistently identify this bot over
     * time (i.e., over multiple sessions). This ID must be unique within a
     * farm. Typically, the bot ID will be the same as the name of the primary
     * device in the worker (e.g., what you'd get from typing `uname -n` on *nix),
     * but this is not required since a single device may allow multiple bots to
     * run on it, each with access to different resources. What is important is
     * that this ID is meaningful to humans, who might need to hunt a physical
     * machine down to fix it.
     * When CreateBotSession is successfully called with a bot_id, all prior
     * sessions with the same ID are invalidated. If a bot attempts to update an
     * invalid session, the server must reject that request, and may also
     * quarantine the other bot with the same bot IDs (ie, stop sending it new
     * leases and alert an admin).
     *
     * Generated from protobuf field <code>string bot_id = 2;</code>
     * @return string
     */
    public function getBotId()
    {
        return $this->bot_id;
    }

    /**
     * A unique bot ID within the farm used to persistently identify this bot over
     * time (i.e., over multiple sessions). This ID must be unique within a
     * farm. Typically, the bot ID will be the same as the name of the primary
     * device in the worker (e.g., what you'd get from typing `uname -n` on *nix),
     * but this is not required since a single device may allow multiple bots to
     * run on it, each with access to different resources. What is important is
     * that this ID is meaningful to humans, who might need to hunt a physical
     * machine down to fix it.
     * When CreateBotSession is successfully called with a bot_id, all prior
     * sessions with the same ID are invalidated. If a bot attempts to update an
     * invalid session, the server must reject that request, and may also
     * quarantine the other bot with the same bot IDs (ie, stop sending it new
     * leases and alert an admin).
     *
     * Generated from protobuf field <code>string bot_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setBotId($var)
    {
        GPBUtil::checkString($var, True);
        $this->bot_id = $var;

        return $this;
    }

    /**
     * The status of the bot. This must be populated in every call to
     * UpdateBotSession.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotStatus status = 3;</code>
     * @return int
     */
    public function getStatus()
    {
        return $this->status;
    }

    /**
     * The status of the bot. This must be populated in every call to
     * UpdateBotSession.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.BotStatus status = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkEnum($var, \Google\Devtools\Remoteworkers\V1test2\BotStatus::class);
        $this->status = $var;

        return $this;
    }

    /**
     * A description of the worker hosting this bot. The Worker message is used
     * here in the Status context (see Worker for more information).  If multiple
     * bots are running on the worker, this field should only describe the
     * resources accessible from this bot.
     * During the call to CreateBotSession, the server may make arbitrary changes
     * to the worker's `server_properties` field (see that field for more
     * information). Otherwise, this field is input-only.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.Worker worker = 4;</code>
     * @return \Google\Devtools\Remoteworkers\V1test2\Worker|null
     */
    public function getWorker()
    {
        return isset($this->worker) ? $this->worker : null;
    }

    public function hasWorker()
    {
        return isset($this->worker);
    }

    public function clearWorker()
    {
        unset($this->worker);
    }

    /**
     * A description of the worker hosting this bot. The Worker message is used
     * here in the Status context (see Worker for more information).  If multiple
     * bots are running on the worker, this field should only describe the
     * resources accessible from this bot.
     * During the call to CreateBotSession, the server may make arbitrary changes
     * to the worker's `server_properties` field (see that field for more
     * information). Otherwise, this field is input-only.
     *
     * Generated from protobuf field <code>.google.devtools.remoteworkers.v1test2.Worker worker = 4;</code>
     * @param \Google\Devtools\Remoteworkers\V1test2\Worker $var
     * @return $this
     */
    public function setWorker($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Remoteworkers\V1test2\Worker::class);
        $this->worker = $var;

        return $this;
    }

    /**
     * A list of all leases that are a part of this session. See the Lease message
     * for details.
     *
     * Generated from protobuf field <code>repeated .google.devtools.remoteworkers.v1test2.Lease leases = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getLeases()
    {
        return $this->leases;
    }

    /**
     * A list of all leases that are a part of this session. See the Lease message
     * for details.
     *
     * Generated from protobuf field <code>repeated .google.devtools.remoteworkers.v1test2.Lease leases = 5;</code>
     * @param \Google\Devtools\Remoteworkers\V1test2\Lease[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setLeases($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Devtools\Remoteworkers\V1test2\Lease::class);
        $this->leases = $arr;

        return $this;
    }

    /**
     * The time at which this bot session will expire, unless the bot calls
     * UpdateBotSession again. Output only.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 6;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getExpireTime()
    {
        return isset($this->expire_time) ? $this->expire_time : null;
    }

    public function hasExpireTime()
    {
        return isset($this->expire_time);
    }

    public function clearExpireTime()
    {
        unset($this->expire_time);
    }

    /**
     * The time at which this bot session will expire, unless the bot calls
     * UpdateBotSession again. Output only.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 6;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setExpireTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->expire_time = $var;

        return $this;
    }

    /**
     * The version of the bot code currently running. The server may use this
     * information to issue an admin action to tell the bot to update itself.
     *
     * Generated from protobuf field <code>string version = 7;</code>
     * @return string
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * The version of the bot code currently running. The server may use this
     * information to issue an admin action to tell the bot to update itself.
     *
     * Generated from protobuf field <code>string version = 7;</code>
     * @param string $var
     * @return $this
     */
    public function setVersion($var)
    {
        GPBUtil::checkString($var, True);
        $this->version = $var;

        return $this;
    }

}

