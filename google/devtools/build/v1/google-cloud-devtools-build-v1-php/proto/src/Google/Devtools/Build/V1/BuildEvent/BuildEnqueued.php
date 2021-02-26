<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/build/v1/build_events.proto

namespace Google\Devtools\Build\V1\BuildEvent;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Notification that the build request is enqueued.
 *
 * Generated from protobuf message <code>google.devtools.build.v1.BuildEvent.BuildEnqueued</code>
 */
class BuildEnqueued extends \Google\Protobuf\Internal\Message
{
    /**
     * Additional details about the Build.
     *
     * Generated from protobuf field <code>.google.protobuf.Any details = 1;</code>
     */
    protected $details = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Any $details
     *           Additional details about the Build.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Build\V1\BuildEvents::initOnce();
        parent::__construct($data);
    }

    /**
     * Additional details about the Build.
     *
     * Generated from protobuf field <code>.google.protobuf.Any details = 1;</code>
     * @return \Google\Protobuf\Any|null
     */
    public function getDetails()
    {
        return isset($this->details) ? $this->details : null;
    }

    public function hasDetails()
    {
        return isset($this->details);
    }

    public function clearDetails()
    {
        unset($this->details);
    }

    /**
     * Additional details about the Build.
     *
     * Generated from protobuf field <code>.google.protobuf.Any details = 1;</code>
     * @param \Google\Protobuf\Any $var
     * @return $this
     */
    public function setDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Any::class);
        $this->details = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(BuildEnqueued::class, \Google\Devtools\Build\V1\BuildEvent_BuildEnqueued::class);

