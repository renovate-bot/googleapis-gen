<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/admin/v1/audit_data.proto

namespace Google\Cloud\Iam\Admin\V1\AuditData;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A PermissionDelta message to record the added_permissions and
 * removed_permissions inside a role.
 *
 * Generated from protobuf message <code>google.iam.admin.v1.AuditData.PermissionDelta</code>
 */
class PermissionDelta extends \Google\Protobuf\Internal\Message
{
    /**
     * Added permissions.
     *
     * Generated from protobuf field <code>repeated string added_permissions = 1;</code>
     */
    private $added_permissions;
    /**
     * Removed permissions.
     *
     * Generated from protobuf field <code>repeated string removed_permissions = 2;</code>
     */
    private $removed_permissions;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $added_permissions
     *           Added permissions.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $removed_permissions
     *           Removed permissions.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Iam\Admin\V1\AuditData::initOnce();
        parent::__construct($data);
    }

    /**
     * Added permissions.
     *
     * Generated from protobuf field <code>repeated string added_permissions = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAddedPermissions()
    {
        return $this->added_permissions;
    }

    /**
     * Added permissions.
     *
     * Generated from protobuf field <code>repeated string added_permissions = 1;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAddedPermissions($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->added_permissions = $arr;

        return $this;
    }

    /**
     * Removed permissions.
     *
     * Generated from protobuf field <code>repeated string removed_permissions = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRemovedPermissions()
    {
        return $this->removed_permissions;
    }

    /**
     * Removed permissions.
     *
     * Generated from protobuf field <code>repeated string removed_permissions = 2;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRemovedPermissions($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->removed_permissions = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(PermissionDelta::class, \Google\Cloud\Iam\Admin\V1\AuditData_PermissionDelta::class);

