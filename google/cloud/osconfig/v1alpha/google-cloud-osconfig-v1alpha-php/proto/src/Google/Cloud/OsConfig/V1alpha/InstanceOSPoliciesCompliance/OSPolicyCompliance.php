<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/v1alpha/instance_os_policies_compliance.proto

namespace Google\Cloud\OsConfig\V1alpha\InstanceOSPoliciesCompliance;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Compliance data for an OS policy
 *
 * Generated from protobuf message <code>google.cloud.osconfig.v1alpha.InstanceOSPoliciesCompliance.OSPolicyCompliance</code>
 */
class OSPolicyCompliance extends \Google\Protobuf\Internal\Message
{
    /**
     * The OS policy id
     *
     * Generated from protobuf field <code>string os_policy_id = 1;</code>
     */
    protected $os_policy_id = '';
    /**
     * Reference to the `OSPolicyAssignment` API resource that the `OSPolicy`
     * belongs to.
     * Format:
     * `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id&#64;revision_id}`
     *
     * Generated from protobuf field <code>string os_policy_assignment = 2 [(.google.api.resource_reference) = {</code>
     */
    protected $os_policy_assignment = '';
    /**
     * Compliance state of the OS policy.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1alpha.OSPolicyComplianceState state = 4;</code>
     */
    protected $state = 0;
    /**
     * Compliance data for each `OSPolicyResource` that is applied to the
     * VM.
     *
     * Generated from protobuf field <code>repeated .google.cloud.osconfig.v1alpha.OSPolicyResourceCompliance os_policy_resource_compliances = 5;</code>
     */
    private $os_policy_resource_compliances;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $os_policy_id
     *           The OS policy id
     *     @type string $os_policy_assignment
     *           Reference to the `OSPolicyAssignment` API resource that the `OSPolicy`
     *           belongs to.
     *           Format:
     *           `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id&#64;revision_id}`
     *     @type int $state
     *           Compliance state of the OS policy.
     *     @type \Google\Cloud\OsConfig\V1alpha\OSPolicyResourceCompliance[]|\Google\Protobuf\Internal\RepeatedField $os_policy_resource_compliances
     *           Compliance data for each `OSPolicyResource` that is applied to the
     *           VM.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Osconfig\V1Alpha\InstanceOsPoliciesCompliance::initOnce();
        parent::__construct($data);
    }

    /**
     * The OS policy id
     *
     * Generated from protobuf field <code>string os_policy_id = 1;</code>
     * @return string
     */
    public function getOsPolicyId()
    {
        return $this->os_policy_id;
    }

    /**
     * The OS policy id
     *
     * Generated from protobuf field <code>string os_policy_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setOsPolicyId($var)
    {
        GPBUtil::checkString($var, True);
        $this->os_policy_id = $var;

        return $this;
    }

    /**
     * Reference to the `OSPolicyAssignment` API resource that the `OSPolicy`
     * belongs to.
     * Format:
     * `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id&#64;revision_id}`
     *
     * Generated from protobuf field <code>string os_policy_assignment = 2 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getOsPolicyAssignment()
    {
        return $this->os_policy_assignment;
    }

    /**
     * Reference to the `OSPolicyAssignment` API resource that the `OSPolicy`
     * belongs to.
     * Format:
     * `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id&#64;revision_id}`
     *
     * Generated from protobuf field <code>string os_policy_assignment = 2 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setOsPolicyAssignment($var)
    {
        GPBUtil::checkString($var, True);
        $this->os_policy_assignment = $var;

        return $this;
    }

    /**
     * Compliance state of the OS policy.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1alpha.OSPolicyComplianceState state = 4;</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * Compliance state of the OS policy.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1alpha.OSPolicyComplianceState state = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\OsConfig\V1alpha\OSPolicyComplianceState::class);
        $this->state = $var;

        return $this;
    }

    /**
     * Compliance data for each `OSPolicyResource` that is applied to the
     * VM.
     *
     * Generated from protobuf field <code>repeated .google.cloud.osconfig.v1alpha.OSPolicyResourceCompliance os_policy_resource_compliances = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getOsPolicyResourceCompliances()
    {
        return $this->os_policy_resource_compliances;
    }

    /**
     * Compliance data for each `OSPolicyResource` that is applied to the
     * VM.
     *
     * Generated from protobuf field <code>repeated .google.cloud.osconfig.v1alpha.OSPolicyResourceCompliance os_policy_resource_compliances = 5;</code>
     * @param \Google\Cloud\OsConfig\V1alpha\OSPolicyResourceCompliance[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setOsPolicyResourceCompliances($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\OsConfig\V1alpha\OSPolicyResourceCompliance::class);
        $this->os_policy_resource_compliances = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(OSPolicyCompliance::class, \Google\Cloud\OsConfig\V1alpha\InstanceOSPoliciesCompliance_OSPolicyCompliance::class);

