<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/alert_service.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The protocol for the `CreateAlertPolicy` request.
 *
 * Generated from protobuf message <code>google.monitoring.v3.CreateAlertPolicyRequest</code>
 */
class CreateAlertPolicyRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The project in which to create the alerting policy. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * Note that this field names the parent container in which the alerting
     * policy will be written, not the name of the created policy. |name| must be
     * a host project of a workspace, otherwise INVALID_ARGUMENT error will
     * return. The alerting policy that is returned will have a name that contains
     * a normalized representation of this name as a prefix but adds a suffix of
     * the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
     * container.
     *
     * Generated from protobuf field <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. The requested alerting policy. You should omit the `name` field in this
     * policy. The name will be returned in the new policy, including
     * a new `[ALERT_POLICY_ID]` value.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy alert_policy = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $alert_policy = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The project in which to create the alerting policy. The format is:
     *               projects/[PROJECT_ID_OR_NUMBER]
     *           Note that this field names the parent container in which the alerting
     *           policy will be written, not the name of the created policy. |name| must be
     *           a host project of a workspace, otherwise INVALID_ARGUMENT error will
     *           return. The alerting policy that is returned will have a name that contains
     *           a normalized representation of this name as a prefix but adds a suffix of
     *           the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
     *           container.
     *     @type \Google\Cloud\Monitoring\V3\AlertPolicy $alert_policy
     *           Required. The requested alerting policy. You should omit the `name` field in this
     *           policy. The name will be returned in the new policy, including
     *           a new `[ALERT_POLICY_ID]` value.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\AlertService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The project in which to create the alerting policy. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * Note that this field names the parent container in which the alerting
     * policy will be written, not the name of the created policy. |name| must be
     * a host project of a workspace, otherwise INVALID_ARGUMENT error will
     * return. The alerting policy that is returned will have a name that contains
     * a normalized representation of this name as a prefix but adds a suffix of
     * the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
     * container.
     *
     * Generated from protobuf field <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The project in which to create the alerting policy. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]
     * Note that this field names the parent container in which the alerting
     * policy will be written, not the name of the created policy. |name| must be
     * a host project of a workspace, otherwise INVALID_ARGUMENT error will
     * return. The alerting policy that is returned will have a name that contains
     * a normalized representation of this name as a prefix but adds a suffix of
     * the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
     * container.
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
     * Required. The requested alerting policy. You should omit the `name` field in this
     * policy. The name will be returned in the new policy, including
     * a new `[ALERT_POLICY_ID]` value.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy alert_policy = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Monitoring\V3\AlertPolicy|null
     */
    public function getAlertPolicy()
    {
        return isset($this->alert_policy) ? $this->alert_policy : null;
    }

    public function hasAlertPolicy()
    {
        return isset($this->alert_policy);
    }

    public function clearAlertPolicy()
    {
        unset($this->alert_policy);
    }

    /**
     * Required. The requested alerting policy. You should omit the `name` field in this
     * policy. The name will be returned in the new policy, including
     * a new `[ALERT_POLICY_ID]` value.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy alert_policy = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Monitoring\V3\AlertPolicy $var
     * @return $this
     */
    public function setAlertPolicy($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\AlertPolicy::class);
        $this->alert_policy = $var;

        return $this;
    }

}

