<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/orgpolicy/v2/constraint.proto

namespace Google\Cloud\OrgPolicy\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A `constraint` describes a way to restrict resource's configuration. For
 * example, you could enforce a constraint that controls which cloud services
 * can be activated across an organization, or whether a Compute Engine instance
 * can have serial port connections established. `Constraints` can be configured
 * by the organization's policy adminstrator to fit the needs of the organzation
 * by setting a `policy` that includes `constraints` at different locations in
 * the organization's resource hierarchy. Policies are inherited down the
 * resource hierarchy from higher levels, but can also be overridden. For
 * details about the inheritance rules please read about
 * [`policies`][google.cloud.OrgPolicy.v2.Policy].
 * `Constraints` have a default behavior determined by the `constraint_default`
 * field, which is the enforcement behavior that is used in the absence of a
 * `policy` being defined or inherited for the resource in question.
 *
 * Generated from protobuf message <code>google.cloud.orgpolicy.v2.Constraint</code>
 */
class Constraint extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the Constraint. Must be in one of
     * the following forms:
     * * `projects/{project_number}/constraints/{constraint_name}`
     * * `folders/{folder_id}/constraints/{constraint_name}`
     * * `organizations/{organization_id}/constraints/{constraint_name}`
     * For example, "/projects/123/constraints/compute.disableSerialPortAccess".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $name = '';
    /**
     * The human readable name.
     * Mutable.
     *
     * Generated from protobuf field <code>string display_name = 2;</code>
     */
    protected $display_name = '';
    /**
     * Detailed description of what this `Constraint` controls as well as how and
     * where it is enforced.
     * Mutable.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     */
    protected $description = '';
    /**
     * The evaluation behavior of this constraint in the absence of 'Policy'.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.ConstraintDefault constraint_default = 4;</code>
     */
    protected $constraint_default = 0;
    protected $constraint_type;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Immutable. The resource name of the Constraint. Must be in one of
     *           the following forms:
     *           * `projects/{project_number}/constraints/{constraint_name}`
     *           * `folders/{folder_id}/constraints/{constraint_name}`
     *           * `organizations/{organization_id}/constraints/{constraint_name}`
     *           For example, "/projects/123/constraints/compute.disableSerialPortAccess".
     *     @type string $display_name
     *           The human readable name.
     *           Mutable.
     *     @type string $description
     *           Detailed description of what this `Constraint` controls as well as how and
     *           where it is enforced.
     *           Mutable.
     *     @type int $constraint_default
     *           The evaluation behavior of this constraint in the absence of 'Policy'.
     *     @type \Google\Cloud\OrgPolicy\V2\Constraint\ListConstraint $list_constraint
     *           Defines this constraint as being a ListConstraint.
     *     @type \Google\Cloud\OrgPolicy\V2\Constraint\BooleanConstraint $boolean_constraint
     *           Defines this constraint as being a BooleanConstraint.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Orgpolicy\V2\Constraint::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the Constraint. Must be in one of
     * the following forms:
     * * `projects/{project_number}/constraints/{constraint_name}`
     * * `folders/{folder_id}/constraints/{constraint_name}`
     * * `organizations/{organization_id}/constraints/{constraint_name}`
     * For example, "/projects/123/constraints/compute.disableSerialPortAccess".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Immutable. The resource name of the Constraint. Must be in one of
     * the following forms:
     * * `projects/{project_number}/constraints/{constraint_name}`
     * * `folders/{folder_id}/constraints/{constraint_name}`
     * * `organizations/{organization_id}/constraints/{constraint_name}`
     * For example, "/projects/123/constraints/compute.disableSerialPortAccess".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
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
     * The human readable name.
     * Mutable.
     *
     * Generated from protobuf field <code>string display_name = 2;</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * The human readable name.
     * Mutable.
     *
     * Generated from protobuf field <code>string display_name = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * Detailed description of what this `Constraint` controls as well as how and
     * where it is enforced.
     * Mutable.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Detailed description of what this `Constraint` controls as well as how and
     * where it is enforced.
     * Mutable.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * The evaluation behavior of this constraint in the absence of 'Policy'.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.ConstraintDefault constraint_default = 4;</code>
     * @return int
     */
    public function getConstraintDefault()
    {
        return $this->constraint_default;
    }

    /**
     * The evaluation behavior of this constraint in the absence of 'Policy'.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.ConstraintDefault constraint_default = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setConstraintDefault($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\OrgPolicy\V2\Constraint\ConstraintDefault::class);
        $this->constraint_default = $var;

        return $this;
    }

    /**
     * Defines this constraint as being a ListConstraint.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.ListConstraint list_constraint = 5;</code>
     * @return \Google\Cloud\OrgPolicy\V2\Constraint\ListConstraint|null
     */
    public function getListConstraint()
    {
        return $this->readOneof(5);
    }

    public function hasListConstraint()
    {
        return $this->hasOneof(5);
    }

    /**
     * Defines this constraint as being a ListConstraint.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.ListConstraint list_constraint = 5;</code>
     * @param \Google\Cloud\OrgPolicy\V2\Constraint\ListConstraint $var
     * @return $this
     */
    public function setListConstraint($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\OrgPolicy\V2\Constraint\ListConstraint::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Defines this constraint as being a BooleanConstraint.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.BooleanConstraint boolean_constraint = 6;</code>
     * @return \Google\Cloud\OrgPolicy\V2\Constraint\BooleanConstraint|null
     */
    public function getBooleanConstraint()
    {
        return $this->readOneof(6);
    }

    public function hasBooleanConstraint()
    {
        return $this->hasOneof(6);
    }

    /**
     * Defines this constraint as being a BooleanConstraint.
     *
     * Generated from protobuf field <code>.google.cloud.orgpolicy.v2.Constraint.BooleanConstraint boolean_constraint = 6;</code>
     * @param \Google\Cloud\OrgPolicy\V2\Constraint\BooleanConstraint $var
     * @return $this
     */
    public function setBooleanConstraint($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\OrgPolicy\V2\Constraint\BooleanConstraint::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getConstraintType()
    {
        return $this->whichOneof("constraint_type");
    }

}

