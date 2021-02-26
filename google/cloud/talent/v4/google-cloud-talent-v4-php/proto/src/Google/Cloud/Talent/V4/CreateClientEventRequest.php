<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/talent/v4/event_service.proto

namespace Google\Cloud\Talent\V4;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The report event request.
 *
 * Generated from protobuf message <code>google.cloud.talent.v4.CreateClientEventRequest</code>
 */
class CreateClientEventRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Resource name of the tenant under which the event is created.
     * The format is "projects/{project_id}/tenants/{tenant_id}", for example,
     * "projects/foo/tenants/bar".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. Events issued when end user interacts with customer's application that
     * uses Cloud Talent Solution.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4.ClientEvent client_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $client_event = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. Resource name of the tenant under which the event is created.
     *           The format is "projects/{project_id}/tenants/{tenant_id}", for example,
     *           "projects/foo/tenants/bar".
     *     @type \Google\Cloud\Talent\V4\ClientEvent $client_event
     *           Required. Events issued when end user interacts with customer's application that
     *           uses Cloud Talent Solution.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Talent\V4\EventService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Resource name of the tenant under which the event is created.
     * The format is "projects/{project_id}/tenants/{tenant_id}", for example,
     * "projects/foo/tenants/bar".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. Resource name of the tenant under which the event is created.
     * The format is "projects/{project_id}/tenants/{tenant_id}", for example,
     * "projects/foo/tenants/bar".
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Required. Events issued when end user interacts with customer's application that
     * uses Cloud Talent Solution.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4.ClientEvent client_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Talent\V4\ClientEvent|null
     */
    public function getClientEvent()
    {
        return isset($this->client_event) ? $this->client_event : null;
    }

    public function hasClientEvent()
    {
        return isset($this->client_event);
    }

    public function clearClientEvent()
    {
        unset($this->client_event);
    }

    /**
     * Required. Events issued when end user interacts with customer's application that
     * uses Cloud Talent Solution.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4.ClientEvent client_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Talent\V4\ClientEvent $var
     * @return $this
     */
    public function setClientEvent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Talent\V4\ClientEvent::class);
        $this->client_event = $var;

        return $this;
    }

}

