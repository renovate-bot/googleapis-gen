<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/action.proto

namespace Google\Apps\Drive\Activity\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about the action.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.Action</code>
 */
class Action extends \Google\Protobuf\Internal\Message
{
    /**
     * The type and detailed information about the action.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ActionDetail detail = 1;</code>
     */
    protected $detail = null;
    /**
     * The actor responsible for this action (or empty if all actors are
     * responsible).
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Actor actor = 3;</code>
     */
    protected $actor = null;
    /**
     * The target this action affects (or empty if affecting all targets). This
     * represents the state of the target immediately after this action occurred.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Target target = 4;</code>
     */
    protected $target = null;
    protected $time;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Apps\Drive\Activity\V2\ActionDetail $detail
     *           The type and detailed information about the action.
     *     @type \Google\Apps\Drive\Activity\V2\Actor $actor
     *           The actor responsible for this action (or empty if all actors are
     *           responsible).
     *     @type \Google\Apps\Drive\Activity\V2\Target $target
     *           The target this action affects (or empty if affecting all targets). This
     *           represents the state of the target immediately after this action occurred.
     *     @type \Google\Protobuf\Timestamp $timestamp
     *           The action occurred at this specific time.
     *     @type \Google\Apps\Drive\Activity\V2\TimeRange $time_range
     *           The action occurred over this time range.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Action::initOnce();
        parent::__construct($data);
    }

    /**
     * The type and detailed information about the action.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ActionDetail detail = 1;</code>
     * @return \Google\Apps\Drive\Activity\V2\ActionDetail|null
     */
    public function getDetail()
    {
        return isset($this->detail) ? $this->detail : null;
    }

    public function hasDetail()
    {
        return isset($this->detail);
    }

    public function clearDetail()
    {
        unset($this->detail);
    }

    /**
     * The type and detailed information about the action.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ActionDetail detail = 1;</code>
     * @param \Google\Apps\Drive\Activity\V2\ActionDetail $var
     * @return $this
     */
    public function setDetail($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\ActionDetail::class);
        $this->detail = $var;

        return $this;
    }

    /**
     * The actor responsible for this action (or empty if all actors are
     * responsible).
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Actor actor = 3;</code>
     * @return \Google\Apps\Drive\Activity\V2\Actor|null
     */
    public function getActor()
    {
        return isset($this->actor) ? $this->actor : null;
    }

    public function hasActor()
    {
        return isset($this->actor);
    }

    public function clearActor()
    {
        unset($this->actor);
    }

    /**
     * The actor responsible for this action (or empty if all actors are
     * responsible).
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Actor actor = 3;</code>
     * @param \Google\Apps\Drive\Activity\V2\Actor $var
     * @return $this
     */
    public function setActor($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\Actor::class);
        $this->actor = $var;

        return $this;
    }

    /**
     * The target this action affects (or empty if affecting all targets). This
     * represents the state of the target immediately after this action occurred.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Target target = 4;</code>
     * @return \Google\Apps\Drive\Activity\V2\Target|null
     */
    public function getTarget()
    {
        return isset($this->target) ? $this->target : null;
    }

    public function hasTarget()
    {
        return isset($this->target);
    }

    public function clearTarget()
    {
        unset($this->target);
    }

    /**
     * The target this action affects (or empty if affecting all targets). This
     * represents the state of the target immediately after this action occurred.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.Target target = 4;</code>
     * @param \Google\Apps\Drive\Activity\V2\Target $var
     * @return $this
     */
    public function setTarget($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\Target::class);
        $this->target = $var;

        return $this;
    }

    /**
     * The action occurred at this specific time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp timestamp = 5;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getTimestamp()
    {
        return $this->readOneof(5);
    }

    public function hasTimestamp()
    {
        return $this->hasOneof(5);
    }

    /**
     * The action occurred at this specific time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp timestamp = 5;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setTimestamp($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * The action occurred over this time range.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.TimeRange time_range = 6;</code>
     * @return \Google\Apps\Drive\Activity\V2\TimeRange|null
     */
    public function getTimeRange()
    {
        return $this->readOneof(6);
    }

    public function hasTimeRange()
    {
        return $this->hasOneof(6);
    }

    /**
     * The action occurred over this time range.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.TimeRange time_range = 6;</code>
     * @param \Google\Apps\Drive\Activity\V2\TimeRange $var
     * @return $this
     */
    public function setTimeRange($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\TimeRange::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getTime()
    {
        return $this->whichOneof("time");
    }

}

