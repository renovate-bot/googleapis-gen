<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/container/v1beta1/cluster_service.proto

namespace Google\Cloud\Container\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * ListOperationsRequest lists operations.
 *
 * Generated from protobuf message <code>google.container.v1beta1.ListOperationsRequest</code>
 */
class ListOperationsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Deprecated. The Google Developers Console [project ID or project
     * number](https://support.google.com/cloud/answer/6158840).
     * This field has been deprecated and replaced by the parent field.
     *
     * Generated from protobuf field <code>string project_id = 1 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @deprecated
     */
    protected $project_id = '';
    /**
     * Required. Deprecated. The name of the Google Compute Engine
     * [zone](https://cloud.google.com/compute/docs/zones#available) to return
     * operations for, or `-` for all zones. This field has been deprecated and
     * replaced by the parent field.
     *
     * Generated from protobuf field <code>string zone = 2 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @deprecated
     */
    protected $zone = '';
    /**
     * The parent (project and location) where the operations will be listed.
     * Specified in the format `projects/&#42;&#47;locations/&#42;`.
     * Location "-" matches all zones and all regions.
     *
     * Generated from protobuf field <code>string parent = 4;</code>
     */
    protected $parent = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $project_id
     *           Required. Deprecated. The Google Developers Console [project ID or project
     *           number](https://support.google.com/cloud/answer/6158840).
     *           This field has been deprecated and replaced by the parent field.
     *     @type string $zone
     *           Required. Deprecated. The name of the Google Compute Engine
     *           [zone](https://cloud.google.com/compute/docs/zones#available) to return
     *           operations for, or `-` for all zones. This field has been deprecated and
     *           replaced by the parent field.
     *     @type string $parent
     *           The parent (project and location) where the operations will be listed.
     *           Specified in the format `projects/&#42;&#47;locations/&#42;`.
     *           Location "-" matches all zones and all regions.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Container\V1Beta1\ClusterService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Deprecated. The Google Developers Console [project ID or project
     * number](https://support.google.com/cloud/answer/6158840).
     * This field has been deprecated and replaced by the parent field.
     *
     * Generated from protobuf field <code>string project_id = 1 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     * @deprecated
     */
    public function getProjectId()
    {
        @trigger_error('project_id is deprecated.', E_USER_DEPRECATED);
        return $this->project_id;
    }

    /**
     * Required. Deprecated. The Google Developers Console [project ID or project
     * number](https://support.google.com/cloud/answer/6158840).
     * This field has been deprecated and replaced by the parent field.
     *
     * Generated from protobuf field <code>string project_id = 1 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     * @deprecated
     */
    public function setProjectId($var)
    {
        @trigger_error('project_id is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkString($var, True);
        $this->project_id = $var;

        return $this;
    }

    /**
     * Required. Deprecated. The name of the Google Compute Engine
     * [zone](https://cloud.google.com/compute/docs/zones#available) to return
     * operations for, or `-` for all zones. This field has been deprecated and
     * replaced by the parent field.
     *
     * Generated from protobuf field <code>string zone = 2 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     * @deprecated
     */
    public function getZone()
    {
        @trigger_error('zone is deprecated.', E_USER_DEPRECATED);
        return $this->zone;
    }

    /**
     * Required. Deprecated. The name of the Google Compute Engine
     * [zone](https://cloud.google.com/compute/docs/zones#available) to return
     * operations for, or `-` for all zones. This field has been deprecated and
     * replaced by the parent field.
     *
     * Generated from protobuf field <code>string zone = 2 [deprecated = true, (.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     * @deprecated
     */
    public function setZone($var)
    {
        @trigger_error('zone is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkString($var, True);
        $this->zone = $var;

        return $this;
    }

    /**
     * The parent (project and location) where the operations will be listed.
     * Specified in the format `projects/&#42;&#47;locations/&#42;`.
     * Location "-" matches all zones and all regions.
     *
     * Generated from protobuf field <code>string parent = 4;</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * The parent (project and location) where the operations will be listed.
     * Specified in the format `projects/&#42;&#47;locations/&#42;`.
     * Location "-" matches all zones and all regions.
     *
     * Generated from protobuf field <code>string parent = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

}

