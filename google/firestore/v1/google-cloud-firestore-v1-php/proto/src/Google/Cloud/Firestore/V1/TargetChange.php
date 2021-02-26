<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/firestore/v1/firestore.proto

namespace Google\Cloud\Firestore\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Targets being watched have changed.
 *
 * Generated from protobuf message <code>google.firestore.v1.TargetChange</code>
 */
class TargetChange extends \Google\Protobuf\Internal\Message
{
    /**
     * The type of change that occurred.
     *
     * Generated from protobuf field <code>.google.firestore.v1.TargetChange.TargetChangeType target_change_type = 1;</code>
     */
    protected $target_change_type = 0;
    /**
     * The target IDs of targets that have changed.
     * If empty, the change applies to all targets.
     * The order of the target IDs is not defined.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 2;</code>
     */
    private $target_ids;
    /**
     * The error that resulted in this change, if applicable.
     *
     * Generated from protobuf field <code>.google.rpc.Status cause = 3;</code>
     */
    protected $cause = null;
    /**
     * A token that can be used to resume the stream for the given `target_ids`,
     * or all targets if `target_ids` is empty.
     * Not set on every target change.
     *
     * Generated from protobuf field <code>bytes resume_token = 4;</code>
     */
    protected $resume_token = '';
    /**
     * The consistent `read_time` for the given `target_ids` (omitted when the
     * target_ids are not at a consistent snapshot).
     * The stream is guaranteed to send a `read_time` with `target_ids` empty
     * whenever the entire stream reaches a new consistent snapshot. ADD,
     * CURRENT, and RESET messages are guaranteed to (eventually) result in a
     * new consistent snapshot (while NO_CHANGE and REMOVE messages are not).
     * For a given stream, `read_time` is guaranteed to be monotonically
     * increasing.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp read_time = 6;</code>
     */
    protected $read_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $target_change_type
     *           The type of change that occurred.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $target_ids
     *           The target IDs of targets that have changed.
     *           If empty, the change applies to all targets.
     *           The order of the target IDs is not defined.
     *     @type \Google\Rpc\Status $cause
     *           The error that resulted in this change, if applicable.
     *     @type string $resume_token
     *           A token that can be used to resume the stream for the given `target_ids`,
     *           or all targets if `target_ids` is empty.
     *           Not set on every target change.
     *     @type \Google\Protobuf\Timestamp $read_time
     *           The consistent `read_time` for the given `target_ids` (omitted when the
     *           target_ids are not at a consistent snapshot).
     *           The stream is guaranteed to send a `read_time` with `target_ids` empty
     *           whenever the entire stream reaches a new consistent snapshot. ADD,
     *           CURRENT, and RESET messages are guaranteed to (eventually) result in a
     *           new consistent snapshot (while NO_CHANGE and REMOVE messages are not).
     *           For a given stream, `read_time` is guaranteed to be monotonically
     *           increasing.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Firestore\V1\Firestore::initOnce();
        parent::__construct($data);
    }

    /**
     * The type of change that occurred.
     *
     * Generated from protobuf field <code>.google.firestore.v1.TargetChange.TargetChangeType target_change_type = 1;</code>
     * @return int
     */
    public function getTargetChangeType()
    {
        return $this->target_change_type;
    }

    /**
     * The type of change that occurred.
     *
     * Generated from protobuf field <code>.google.firestore.v1.TargetChange.TargetChangeType target_change_type = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setTargetChangeType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Firestore\V1\TargetChange\TargetChangeType::class);
        $this->target_change_type = $var;

        return $this;
    }

    /**
     * The target IDs of targets that have changed.
     * If empty, the change applies to all targets.
     * The order of the target IDs is not defined.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTargetIds()
    {
        return $this->target_ids;
    }

    /**
     * The target IDs of targets that have changed.
     * If empty, the change applies to all targets.
     * The order of the target IDs is not defined.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 2;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTargetIds($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::INT32);
        $this->target_ids = $arr;

        return $this;
    }

    /**
     * The error that resulted in this change, if applicable.
     *
     * Generated from protobuf field <code>.google.rpc.Status cause = 3;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getCause()
    {
        return isset($this->cause) ? $this->cause : null;
    }

    public function hasCause()
    {
        return isset($this->cause);
    }

    public function clearCause()
    {
        unset($this->cause);
    }

    /**
     * The error that resulted in this change, if applicable.
     *
     * Generated from protobuf field <code>.google.rpc.Status cause = 3;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setCause($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->cause = $var;

        return $this;
    }

    /**
     * A token that can be used to resume the stream for the given `target_ids`,
     * or all targets if `target_ids` is empty.
     * Not set on every target change.
     *
     * Generated from protobuf field <code>bytes resume_token = 4;</code>
     * @return string
     */
    public function getResumeToken()
    {
        return $this->resume_token;
    }

    /**
     * A token that can be used to resume the stream for the given `target_ids`,
     * or all targets if `target_ids` is empty.
     * Not set on every target change.
     *
     * Generated from protobuf field <code>bytes resume_token = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setResumeToken($var)
    {
        GPBUtil::checkString($var, False);
        $this->resume_token = $var;

        return $this;
    }

    /**
     * The consistent `read_time` for the given `target_ids` (omitted when the
     * target_ids are not at a consistent snapshot).
     * The stream is guaranteed to send a `read_time` with `target_ids` empty
     * whenever the entire stream reaches a new consistent snapshot. ADD,
     * CURRENT, and RESET messages are guaranteed to (eventually) result in a
     * new consistent snapshot (while NO_CHANGE and REMOVE messages are not).
     * For a given stream, `read_time` is guaranteed to be monotonically
     * increasing.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp read_time = 6;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getReadTime()
    {
        return isset($this->read_time) ? $this->read_time : null;
    }

    public function hasReadTime()
    {
        return isset($this->read_time);
    }

    public function clearReadTime()
    {
        unset($this->read_time);
    }

    /**
     * The consistent `read_time` for the given `target_ids` (omitted when the
     * target_ids are not at a consistent snapshot).
     * The stream is guaranteed to send a `read_time` with `target_ids` empty
     * whenever the entire stream reaches a new consistent snapshot. ADD,
     * CURRENT, and RESET messages are guaranteed to (eventually) result in a
     * new consistent snapshot (while NO_CHANGE and REMOVE messages are not).
     * For a given stream, `read_time` is guaranteed to be monotonically
     * increasing.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp read_time = 6;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setReadTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->read_time = $var;

        return $this;
    }

}

