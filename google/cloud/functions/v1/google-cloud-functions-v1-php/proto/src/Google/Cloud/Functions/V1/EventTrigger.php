<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/functions/v1/functions.proto

namespace Google\Cloud\Functions\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes EventTrigger, used to request events be sent from another
 * service.
 *
 * Generated from protobuf message <code>google.cloud.functions.v1.EventTrigger</code>
 */
class EventTrigger extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The type of event to observe. For example:
     * `providers/cloud.storage/eventTypes/object.change` and
     * `providers/cloud.pubsub/eventTypes/topic.publish`.
     * Event types match pattern `providers/&#42;&#47;eventTypes/&#42;.*`.
     * The pattern contains:
     * 1. namespace: For example, `cloud.storage` and
     *    `google.firebase.analytics`.
     * 2. resource type: The type of resource on which event occurs. For
     *    example, the Google Cloud Storage API includes the type `object`.
     * 3. action: The action that generates the event. For example, action for
     *    a Google Cloud Storage Object is 'change'.
     * These parts are lower case.
     *
     * Generated from protobuf field <code>string event_type = 1;</code>
     */
    protected $event_type = '';
    /**
     * Required. The resource(s) from which to observe events, for example,
     * `projects/_/buckets/myBucket`.
     * Not all syntactically correct values are accepted by all services. For
     * example:
     * 1. The authorization model must support it. Google Cloud Functions
     *    only allows EventTriggers to be deployed that observe resources in the
     *    same project as the `CloudFunction`.
     * 2. The resource type must match the pattern expected for an
     *    `event_type`. For example, an `EventTrigger` that has an
     *    `event_type` of "google.pubsub.topic.publish" should have a resource
     *    that matches Google Cloud Pub/Sub topics.
     * Additionally, some services may support short names when creating an
     * `EventTrigger`. These will always be returned in the normalized "long"
     * format.
     * See each *service's* documentation for supported formats.
     *
     * Generated from protobuf field <code>string resource = 2;</code>
     */
    protected $resource = '';
    /**
     * The hostname of the service that should be observed.
     * If no string is provided, the default service implementing the API will
     * be used. For example, `storage.googleapis.com` is the default for all
     * event types in the `google.storage` namespace.
     *
     * Generated from protobuf field <code>string service = 3;</code>
     */
    protected $service = '';
    /**
     * Specifies policy for failed executions.
     *
     * Generated from protobuf field <code>.google.cloud.functions.v1.FailurePolicy failure_policy = 5;</code>
     */
    protected $failure_policy = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $event_type
     *           Required. The type of event to observe. For example:
     *           `providers/cloud.storage/eventTypes/object.change` and
     *           `providers/cloud.pubsub/eventTypes/topic.publish`.
     *           Event types match pattern `providers/&#42;&#47;eventTypes/&#42;.*`.
     *           The pattern contains:
     *           1. namespace: For example, `cloud.storage` and
     *              `google.firebase.analytics`.
     *           2. resource type: The type of resource on which event occurs. For
     *              example, the Google Cloud Storage API includes the type `object`.
     *           3. action: The action that generates the event. For example, action for
     *              a Google Cloud Storage Object is 'change'.
     *           These parts are lower case.
     *     @type string $resource
     *           Required. The resource(s) from which to observe events, for example,
     *           `projects/_/buckets/myBucket`.
     *           Not all syntactically correct values are accepted by all services. For
     *           example:
     *           1. The authorization model must support it. Google Cloud Functions
     *              only allows EventTriggers to be deployed that observe resources in the
     *              same project as the `CloudFunction`.
     *           2. The resource type must match the pattern expected for an
     *              `event_type`. For example, an `EventTrigger` that has an
     *              `event_type` of "google.pubsub.topic.publish" should have a resource
     *              that matches Google Cloud Pub/Sub topics.
     *           Additionally, some services may support short names when creating an
     *           `EventTrigger`. These will always be returned in the normalized "long"
     *           format.
     *           See each *service's* documentation for supported formats.
     *     @type string $service
     *           The hostname of the service that should be observed.
     *           If no string is provided, the default service implementing the API will
     *           be used. For example, `storage.googleapis.com` is the default for all
     *           event types in the `google.storage` namespace.
     *     @type \Google\Cloud\Functions\V1\FailurePolicy $failure_policy
     *           Specifies policy for failed executions.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Functions\V1\Functions::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The type of event to observe. For example:
     * `providers/cloud.storage/eventTypes/object.change` and
     * `providers/cloud.pubsub/eventTypes/topic.publish`.
     * Event types match pattern `providers/&#42;&#47;eventTypes/&#42;.*`.
     * The pattern contains:
     * 1. namespace: For example, `cloud.storage` and
     *    `google.firebase.analytics`.
     * 2. resource type: The type of resource on which event occurs. For
     *    example, the Google Cloud Storage API includes the type `object`.
     * 3. action: The action that generates the event. For example, action for
     *    a Google Cloud Storage Object is 'change'.
     * These parts are lower case.
     *
     * Generated from protobuf field <code>string event_type = 1;</code>
     * @return string
     */
    public function getEventType()
    {
        return $this->event_type;
    }

    /**
     * Required. The type of event to observe. For example:
     * `providers/cloud.storage/eventTypes/object.change` and
     * `providers/cloud.pubsub/eventTypes/topic.publish`.
     * Event types match pattern `providers/&#42;&#47;eventTypes/&#42;.*`.
     * The pattern contains:
     * 1. namespace: For example, `cloud.storage` and
     *    `google.firebase.analytics`.
     * 2. resource type: The type of resource on which event occurs. For
     *    example, the Google Cloud Storage API includes the type `object`.
     * 3. action: The action that generates the event. For example, action for
     *    a Google Cloud Storage Object is 'change'.
     * These parts are lower case.
     *
     * Generated from protobuf field <code>string event_type = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setEventType($var)
    {
        GPBUtil::checkString($var, True);
        $this->event_type = $var;

        return $this;
    }

    /**
     * Required. The resource(s) from which to observe events, for example,
     * `projects/_/buckets/myBucket`.
     * Not all syntactically correct values are accepted by all services. For
     * example:
     * 1. The authorization model must support it. Google Cloud Functions
     *    only allows EventTriggers to be deployed that observe resources in the
     *    same project as the `CloudFunction`.
     * 2. The resource type must match the pattern expected for an
     *    `event_type`. For example, an `EventTrigger` that has an
     *    `event_type` of "google.pubsub.topic.publish" should have a resource
     *    that matches Google Cloud Pub/Sub topics.
     * Additionally, some services may support short names when creating an
     * `EventTrigger`. These will always be returned in the normalized "long"
     * format.
     * See each *service's* documentation for supported formats.
     *
     * Generated from protobuf field <code>string resource = 2;</code>
     * @return string
     */
    public function getResource()
    {
        return $this->resource;
    }

    /**
     * Required. The resource(s) from which to observe events, for example,
     * `projects/_/buckets/myBucket`.
     * Not all syntactically correct values are accepted by all services. For
     * example:
     * 1. The authorization model must support it. Google Cloud Functions
     *    only allows EventTriggers to be deployed that observe resources in the
     *    same project as the `CloudFunction`.
     * 2. The resource type must match the pattern expected for an
     *    `event_type`. For example, an `EventTrigger` that has an
     *    `event_type` of "google.pubsub.topic.publish" should have a resource
     *    that matches Google Cloud Pub/Sub topics.
     * Additionally, some services may support short names when creating an
     * `EventTrigger`. These will always be returned in the normalized "long"
     * format.
     * See each *service's* documentation for supported formats.
     *
     * Generated from protobuf field <code>string resource = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setResource($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource = $var;

        return $this;
    }

    /**
     * The hostname of the service that should be observed.
     * If no string is provided, the default service implementing the API will
     * be used. For example, `storage.googleapis.com` is the default for all
     * event types in the `google.storage` namespace.
     *
     * Generated from protobuf field <code>string service = 3;</code>
     * @return string
     */
    public function getService()
    {
        return $this->service;
    }

    /**
     * The hostname of the service that should be observed.
     * If no string is provided, the default service implementing the API will
     * be used. For example, `storage.googleapis.com` is the default for all
     * event types in the `google.storage` namespace.
     *
     * Generated from protobuf field <code>string service = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setService($var)
    {
        GPBUtil::checkString($var, True);
        $this->service = $var;

        return $this;
    }

    /**
     * Specifies policy for failed executions.
     *
     * Generated from protobuf field <code>.google.cloud.functions.v1.FailurePolicy failure_policy = 5;</code>
     * @return \Google\Cloud\Functions\V1\FailurePolicy|null
     */
    public function getFailurePolicy()
    {
        return isset($this->failure_policy) ? $this->failure_policy : null;
    }

    public function hasFailurePolicy()
    {
        return isset($this->failure_policy);
    }

    public function clearFailurePolicy()
    {
        unset($this->failure_policy);
    }

    /**
     * Specifies policy for failed executions.
     *
     * Generated from protobuf field <code>.google.cloud.functions.v1.FailurePolicy failure_policy = 5;</code>
     * @param \Google\Cloud\Functions\V1\FailurePolicy $var
     * @return $this
     */
    public function setFailurePolicy($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Functions\V1\FailurePolicy::class);
        $this->failure_policy = $var;

        return $this;
    }

}

