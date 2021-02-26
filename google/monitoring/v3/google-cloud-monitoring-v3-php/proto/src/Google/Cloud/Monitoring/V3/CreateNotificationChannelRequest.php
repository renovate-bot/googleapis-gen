<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/notification_service.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The `CreateNotificationChannel` request.
 *
 * Generated from protobuf message <code>google.monitoring.v3.CreateNotificationChannelRequest</code>
 */
class CreateNotificationChannelRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The project on which to execute the request. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * This names the container into which the channel will be
     * written, this does not name the newly created channel. The resulting
     * channel's name will have a normalized version of this field as a prefix,
     * but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
     *
     * Generated from protobuf field <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. The definition of the `NotificationChannel` to create.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.NotificationChannel notification_channel = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $notification_channel = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The project on which to execute the request. The format is:
     *               projects/[PROJECT_ID_OR_NUMBER]
     *           This names the container into which the channel will be
     *           written, this does not name the newly created channel. The resulting
     *           channel's name will have a normalized version of this field as a prefix,
     *           but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
     *     @type \Google\Cloud\Monitoring\V3\NotificationChannel $notification_channel
     *           Required. The definition of the `NotificationChannel` to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\NotificationService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The project on which to execute the request. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * This names the container into which the channel will be
     * written, this does not name the newly created channel. The resulting
     * channel's name will have a normalized version of this field as a prefix,
     * but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
     *
     * Generated from protobuf field <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The project on which to execute the request. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * This names the container into which the channel will be
     * written, this does not name the newly created channel. The resulting
     * channel's name will have a normalized version of this field as a prefix,
     * but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
     *
     * Generated from protobuf field <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Required. The definition of the `NotificationChannel` to create.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.NotificationChannel notification_channel = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Monitoring\V3\NotificationChannel|null
     */
    public function getNotificationChannel()
    {
        return isset($this->notification_channel) ? $this->notification_channel : null;
    }

    public function hasNotificationChannel()
    {
        return isset($this->notification_channel);
    }

    public function clearNotificationChannel()
    {
        unset($this->notification_channel);
    }

    /**
     * Required. The definition of the `NotificationChannel` to create.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.NotificationChannel notification_channel = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Monitoring\V3\NotificationChannel $var
     * @return $this
     */
    public function setNotificationChannel($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\NotificationChannel::class);
        $this->notification_channel = $var;

        return $this;
    }

}

