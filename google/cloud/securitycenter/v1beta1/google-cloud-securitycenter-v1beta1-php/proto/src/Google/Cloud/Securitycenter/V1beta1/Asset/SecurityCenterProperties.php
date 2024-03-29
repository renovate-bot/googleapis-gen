<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/v1beta1/asset.proto

namespace Google\Cloud\Securitycenter\V1beta1\Asset;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Security Command Center managed properties. These properties are managed by
 * Security Command Center and cannot be modified by the user.
 *
 * Generated from protobuf message <code>google.cloud.securitycenter.v1beta1.Asset.SecurityCenterProperties</code>
 */
class SecurityCenterProperties extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The full resource name of the Google Cloud resource this asset
     * represents. This field is immutable after create time. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $resource_name = '';
    /**
     * The type of the Google Cloud resource. Examples include: APPLICATION,
     * PROJECT, and ORGANIZATION. This is a case insensitive field defined by
     * Security Command Center and/or the producer of the resource and is
     * immutable after create time.
     *
     * Generated from protobuf field <code>string resource_type = 2;</code>
     */
    protected $resource_type = '';
    /**
     * The full resource name of the immediate parent of the resource. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_parent = 3;</code>
     */
    protected $resource_parent = '';
    /**
     * The full resource name of the project the resource belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_project = 4;</code>
     */
    protected $resource_project = '';
    /**
     * Owners of the Google Cloud resource.
     *
     * Generated from protobuf field <code>repeated string resource_owners = 5;</code>
     */
    private $resource_owners;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The full resource name of the Google Cloud resource this asset
     *           represents. This field is immutable after create time. See:
     *           https://cloud.google.com/apis/design/resource_names#full_resource_name
     *     @type string $resource_type
     *           The type of the Google Cloud resource. Examples include: APPLICATION,
     *           PROJECT, and ORGANIZATION. This is a case insensitive field defined by
     *           Security Command Center and/or the producer of the resource and is
     *           immutable after create time.
     *     @type string $resource_parent
     *           The full resource name of the immediate parent of the resource. See:
     *           https://cloud.google.com/apis/design/resource_names#full_resource_name
     *     @type string $resource_project
     *           The full resource name of the project the resource belongs to. See:
     *           https://cloud.google.com/apis/design/resource_names#full_resource_name
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $resource_owners
     *           Owners of the Google Cloud resource.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Asset::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The full resource name of the Google Cloud resource this asset
     * represents. This field is immutable after create time. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The full resource name of the Google Cloud resource this asset
     * represents. This field is immutable after create time. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string $var
     * @return $this
     */
    public function setResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_name = $var;

        return $this;
    }

    /**
     * The type of the Google Cloud resource. Examples include: APPLICATION,
     * PROJECT, and ORGANIZATION. This is a case insensitive field defined by
     * Security Command Center and/or the producer of the resource and is
     * immutable after create time.
     *
     * Generated from protobuf field <code>string resource_type = 2;</code>
     * @return string
     */
    public function getResourceType()
    {
        return $this->resource_type;
    }

    /**
     * The type of the Google Cloud resource. Examples include: APPLICATION,
     * PROJECT, and ORGANIZATION. This is a case insensitive field defined by
     * Security Command Center and/or the producer of the resource and is
     * immutable after create time.
     *
     * Generated from protobuf field <code>string resource_type = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setResourceType($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_type = $var;

        return $this;
    }

    /**
     * The full resource name of the immediate parent of the resource. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_parent = 3;</code>
     * @return string
     */
    public function getResourceParent()
    {
        return $this->resource_parent;
    }

    /**
     * The full resource name of the immediate parent of the resource. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_parent = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setResourceParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_parent = $var;

        return $this;
    }

    /**
     * The full resource name of the project the resource belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_project = 4;</code>
     * @return string
     */
    public function getResourceProject()
    {
        return $this->resource_project;
    }

    /**
     * The full resource name of the project the resource belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name
     *
     * Generated from protobuf field <code>string resource_project = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setResourceProject($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_project = $var;

        return $this;
    }

    /**
     * Owners of the Google Cloud resource.
     *
     * Generated from protobuf field <code>repeated string resource_owners = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getResourceOwners()
    {
        return $this->resource_owners;
    }

    /**
     * Owners of the Google Cloud resource.
     *
     * Generated from protobuf field <code>repeated string resource_owners = 5;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setResourceOwners($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->resource_owners = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(SecurityCenterProperties::class, \Google\Cloud\Securitycenter\V1beta1\Asset_SecurityCenterProperties::class);

