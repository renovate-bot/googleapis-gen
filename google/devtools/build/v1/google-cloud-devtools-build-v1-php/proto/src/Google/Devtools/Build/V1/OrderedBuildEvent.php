<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/build/v1/publish_build_event.proto

namespace Google\Devtools\Build\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Build event with contextual information about the stream it belongs to and
 * its position in that stream.
 *
 * Generated from protobuf message <code>google.devtools.build.v1.OrderedBuildEvent</code>
 */
class OrderedBuildEvent extends \Google\Protobuf\Internal\Message
{
    /**
     * Which build event stream this event belongs to.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.StreamId stream_id = 1;</code>
     */
    protected $stream_id = null;
    /**
     * The position of this event in the stream. The sequence numbers for a build
     * event stream should be a sequence of consecutive natural numbers starting
     * from one. (1, 2, 3, ...)
     *
     * Generated from protobuf field <code>int64 sequence_number = 2;</code>
     */
    protected $sequence_number = 0;
    /**
     * The actual event.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.BuildEvent event = 3;</code>
     */
    protected $event = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Devtools\Build\V1\StreamId $stream_id
     *           Which build event stream this event belongs to.
     *     @type int|string $sequence_number
     *           The position of this event in the stream. The sequence numbers for a build
     *           event stream should be a sequence of consecutive natural numbers starting
     *           from one. (1, 2, 3, ...)
     *     @type \Google\Devtools\Build\V1\BuildEvent $event
     *           The actual event.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Build\V1\PublishBuildEvent::initOnce();
        parent::__construct($data);
    }

    /**
     * Which build event stream this event belongs to.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.StreamId stream_id = 1;</code>
     * @return \Google\Devtools\Build\V1\StreamId|null
     */
    public function getStreamId()
    {
        return isset($this->stream_id) ? $this->stream_id : null;
    }

    public function hasStreamId()
    {
        return isset($this->stream_id);
    }

    public function clearStreamId()
    {
        unset($this->stream_id);
    }

    /**
     * Which build event stream this event belongs to.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.StreamId stream_id = 1;</code>
     * @param \Google\Devtools\Build\V1\StreamId $var
     * @return $this
     */
    public function setStreamId($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Build\V1\StreamId::class);
        $this->stream_id = $var;

        return $this;
    }

    /**
     * The position of this event in the stream. The sequence numbers for a build
     * event stream should be a sequence of consecutive natural numbers starting
     * from one. (1, 2, 3, ...)
     *
     * Generated from protobuf field <code>int64 sequence_number = 2;</code>
     * @return int|string
     */
    public function getSequenceNumber()
    {
        return $this->sequence_number;
    }

    /**
     * The position of this event in the stream. The sequence numbers for a build
     * event stream should be a sequence of consecutive natural numbers starting
     * from one. (1, 2, 3, ...)
     *
     * Generated from protobuf field <code>int64 sequence_number = 2;</code>
     * @param int|string $var
     * @return $this
     */
    public function setSequenceNumber($var)
    {
        GPBUtil::checkInt64($var);
        $this->sequence_number = $var;

        return $this;
    }

    /**
     * The actual event.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.BuildEvent event = 3;</code>
     * @return \Google\Devtools\Build\V1\BuildEvent|null
     */
    public function getEvent()
    {
        return isset($this->event) ? $this->event : null;
    }

    public function hasEvent()
    {
        return isset($this->event);
    }

    public function clearEvent()
    {
        unset($this->event);
    }

    /**
     * The actual event.
     *
     * Generated from protobuf field <code>.google.devtools.build.v1.BuildEvent event = 3;</code>
     * @param \Google\Devtools\Build\V1\BuildEvent $var
     * @return $this
     */
    public function setEvent($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Build\V1\BuildEvent::class);
        $this->event = $var;

        return $this;
    }

}

