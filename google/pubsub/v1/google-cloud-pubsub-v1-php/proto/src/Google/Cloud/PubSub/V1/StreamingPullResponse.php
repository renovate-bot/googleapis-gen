<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/pubsub/v1/pubsub.proto

namespace Google\Cloud\PubSub\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response for the `StreamingPull` method. This response is used to stream
 * messages from the server to the client.
 *
 * Generated from protobuf message <code>google.pubsub.v1.StreamingPullResponse</code>
 */
class StreamingPullResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Received Pub/Sub messages. This will not be empty.
     *
     * Generated from protobuf field <code>repeated .google.pubsub.v1.ReceivedMessage received_messages = 1;</code>
     */
    private $received_messages;
    /**
     * Properties associated with this subscription.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.StreamingPullResponse.SubscriptionProperties subscription_properties = 4;</code>
     */
    protected $subscription_properties = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\PubSub\V1\ReceivedMessage[]|\Google\Protobuf\Internal\RepeatedField $received_messages
     *           Received Pub/Sub messages. This will not be empty.
     *     @type \Google\Cloud\PubSub\V1\StreamingPullResponse\SubscriptionProperties $subscription_properties
     *           Properties associated with this subscription.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Pubsub\V1\Pubsub::initOnce();
        parent::__construct($data);
    }

    /**
     * Received Pub/Sub messages. This will not be empty.
     *
     * Generated from protobuf field <code>repeated .google.pubsub.v1.ReceivedMessage received_messages = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getReceivedMessages()
    {
        return $this->received_messages;
    }

    /**
     * Received Pub/Sub messages. This will not be empty.
     *
     * Generated from protobuf field <code>repeated .google.pubsub.v1.ReceivedMessage received_messages = 1;</code>
     * @param \Google\Cloud\PubSub\V1\ReceivedMessage[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setReceivedMessages($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\PubSub\V1\ReceivedMessage::class);
        $this->received_messages = $arr;

        return $this;
    }

    /**
     * Properties associated with this subscription.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.StreamingPullResponse.SubscriptionProperties subscription_properties = 4;</code>
     * @return \Google\Cloud\PubSub\V1\StreamingPullResponse\SubscriptionProperties|null
     */
    public function getSubscriptionProperties()
    {
        return $this->subscription_properties;
    }

    public function hasSubscriptionProperties()
    {
        return isset($this->subscription_properties);
    }

    public function clearSubscriptionProperties()
    {
        unset($this->subscription_properties);
    }

    /**
     * Properties associated with this subscription.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.StreamingPullResponse.SubscriptionProperties subscription_properties = 4;</code>
     * @param \Google\Cloud\PubSub\V1\StreamingPullResponse\SubscriptionProperties $var
     * @return $this
     */
    public function setSubscriptionProperties($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\StreamingPullResponse\SubscriptionProperties::class);
        $this->subscription_properties = $var;

        return $this;
    }

}

