<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/user_event_service.proto

namespace Google\Cloud\Retail\V2beta;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for WriteUserEvent method.
 *
 * Generated from protobuf message <code>google.cloud.retail.v2beta.WriteUserEventRequest</code>
 */
class WriteUserEventRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The parent catalog resource name, such as
     * "projects/1234/locations/global/catalogs/default_catalog".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $parent = '';
    /**
     * Required. User event to write.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2beta.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $user_event = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The parent catalog resource name, such as
     *           "projects/1234/locations/global/catalogs/default_catalog".
     *     @type \Google\Cloud\Retail\V2beta\UserEvent $user_event
     *           Required. User event to write.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Retail\V2Beta\UserEventService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The parent catalog resource name, such as
     * "projects/1234/locations/global/catalogs/default_catalog".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The parent catalog resource name, such as
     * "projects/1234/locations/global/catalogs/default_catalog".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. User event to write.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2beta.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Retail\V2beta\UserEvent|null
     */
    public function getUserEvent()
    {
        return isset($this->user_event) ? $this->user_event : null;
    }

    public function hasUserEvent()
    {
        return isset($this->user_event);
    }

    public function clearUserEvent()
    {
        unset($this->user_event);
    }

    /**
     * Required. User event to write.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2beta.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Retail\V2beta\UserEvent $var
     * @return $this
     */
    public function setUserEvent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Retail\V2beta\UserEvent::class);
        $this->user_event = $var;

        return $this;
    }

}

