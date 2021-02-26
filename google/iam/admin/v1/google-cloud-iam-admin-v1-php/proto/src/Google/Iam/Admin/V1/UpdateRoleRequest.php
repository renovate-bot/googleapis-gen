<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/admin/v1/iam.proto

namespace Google\Iam\Admin\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request to update a role.
 *
 * Generated from protobuf message <code>google.iam.admin.v1.UpdateRoleRequest</code>
 */
class UpdateRoleRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The `name` parameter's value depends on the target resource for the
     * request, namely
     * [`projects`](/iam/reference/rest/v1/projects.roles) or
     * [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
     * resource type's `name` value format is described below:
     * * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
     *   `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
     *   [custom roles](/iam/docs/understanding-custom-roles) that have been
     *   created at the project level. Example request URL:
     *   `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
     * * [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
     *   `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
     *   updates only [custom roles](/iam/docs/understanding-custom-roles) that
     *   have been created at the organization level. Example request URL:
     *   `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
     * Note: Wildcard (*) values are invalid; you must specify a complete project
     * ID or organization ID.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * The updated role.
     *
     * Generated from protobuf field <code>.google.iam.admin.v1.Role role = 2;</code>
     */
    protected $role = null;
    /**
     * A mask describing which fields in the Role have changed.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The `name` parameter's value depends on the target resource for the
     *           request, namely
     *           [`projects`](/iam/reference/rest/v1/projects.roles) or
     *           [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
     *           resource type's `name` value format is described below:
     *           * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
     *             `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
     *             [custom roles](/iam/docs/understanding-custom-roles) that have been
     *             created at the project level. Example request URL:
     *             `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
     *           * [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
     *             `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
     *             updates only [custom roles](/iam/docs/understanding-custom-roles) that
     *             have been created at the organization level. Example request URL:
     *             `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
     *           Note: Wildcard (*) values are invalid; you must specify a complete project
     *           ID or organization ID.
     *     @type \Google\Iam\Admin\V1\Role $role
     *           The updated role.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           A mask describing which fields in the Role have changed.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Iam\Admin\V1\Iam::initOnce();
        parent::__construct($data);
    }

    /**
     * The `name` parameter's value depends on the target resource for the
     * request, namely
     * [`projects`](/iam/reference/rest/v1/projects.roles) or
     * [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
     * resource type's `name` value format is described below:
     * * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
     *   `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
     *   [custom roles](/iam/docs/understanding-custom-roles) that have been
     *   created at the project level. Example request URL:
     *   `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
     * * [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
     *   `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
     *   updates only [custom roles](/iam/docs/understanding-custom-roles) that
     *   have been created at the organization level. Example request URL:
     *   `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
     * Note: Wildcard (*) values are invalid; you must specify a complete project
     * ID or organization ID.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The `name` parameter's value depends on the target resource for the
     * request, namely
     * [`projects`](/iam/reference/rest/v1/projects.roles) or
     * [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
     * resource type's `name` value format is described below:
     * * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
     *   `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
     *   [custom roles](/iam/docs/understanding-custom-roles) that have been
     *   created at the project level. Example request URL:
     *   `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
     * * [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
     *   `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
     *   updates only [custom roles](/iam/docs/understanding-custom-roles) that
     *   have been created at the organization level. Example request URL:
     *   `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
     * Note: Wildcard (*) values are invalid; you must specify a complete project
     * ID or organization ID.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.resource_reference) = {</code>
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
     * The updated role.
     *
     * Generated from protobuf field <code>.google.iam.admin.v1.Role role = 2;</code>
     * @return \Google\Iam\Admin\V1\Role|null
     */
    public function getRole()
    {
        return isset($this->role) ? $this->role : null;
    }

    public function hasRole()
    {
        return isset($this->role);
    }

    public function clearRole()
    {
        unset($this->role);
    }

    /**
     * The updated role.
     *
     * Generated from protobuf field <code>.google.iam.admin.v1.Role role = 2;</code>
     * @param \Google\Iam\Admin\V1\Role $var
     * @return $this
     */
    public function setRole($var)
    {
        GPBUtil::checkMessage($var, \Google\Iam\Admin\V1\Role::class);
        $this->role = $var;

        return $this;
    }

    /**
     * A mask describing which fields in the Role have changed.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * A mask describing which fields in the Role have changed.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

