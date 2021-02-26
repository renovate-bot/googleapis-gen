<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/container/v1beta1/cluster_service.proto

namespace Google\Cloud\Container\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * ClusterAutoscaling contains global, per-cluster information
 * required by Cluster Autoscaler to automatically adjust
 * the size of the cluster and create/delete
 * node pools based on the current needs.
 *
 * Generated from protobuf message <code>google.container.v1beta1.ClusterAutoscaling</code>
 */
class ClusterAutoscaling extends \Google\Protobuf\Internal\Message
{
    /**
     * Enables automatic node pool creation and deletion.
     *
     * Generated from protobuf field <code>bool enable_node_autoprovisioning = 1;</code>
     */
    protected $enable_node_autoprovisioning = false;
    /**
     * Contains global constraints regarding minimum and maximum
     * amount of resources in the cluster.
     *
     * Generated from protobuf field <code>repeated .google.container.v1beta1.ResourceLimit resource_limits = 2;</code>
     */
    private $resource_limits;
    /**
     * Defines autoscaling behaviour.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClusterAutoscaling.AutoscalingProfile autoscaling_profile = 3;</code>
     */
    protected $autoscaling_profile = 0;
    /**
     * AutoprovisioningNodePoolDefaults contains defaults for a node pool
     * created by NAP.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.AutoprovisioningNodePoolDefaults autoprovisioning_node_pool_defaults = 4;</code>
     */
    protected $autoprovisioning_node_pool_defaults = null;
    /**
     * The list of Google Compute Engine
     * [zones](https://cloud.google.com/compute/docs/zones#available) in which the
     * NodePool's nodes can be created by NAP.
     *
     * Generated from protobuf field <code>repeated string autoprovisioning_locations = 5;</code>
     */
    private $autoprovisioning_locations;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type bool $enable_node_autoprovisioning
     *           Enables automatic node pool creation and deletion.
     *     @type \Google\Cloud\Container\V1beta1\ResourceLimit[]|\Google\Protobuf\Internal\RepeatedField $resource_limits
     *           Contains global constraints regarding minimum and maximum
     *           amount of resources in the cluster.
     *     @type int $autoscaling_profile
     *           Defines autoscaling behaviour.
     *     @type \Google\Cloud\Container\V1beta1\AutoprovisioningNodePoolDefaults $autoprovisioning_node_pool_defaults
     *           AutoprovisioningNodePoolDefaults contains defaults for a node pool
     *           created by NAP.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $autoprovisioning_locations
     *           The list of Google Compute Engine
     *           [zones](https://cloud.google.com/compute/docs/zones#available) in which the
     *           NodePool's nodes can be created by NAP.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Container\V1Beta1\ClusterService::initOnce();
        parent::__construct($data);
    }

    /**
     * Enables automatic node pool creation and deletion.
     *
     * Generated from protobuf field <code>bool enable_node_autoprovisioning = 1;</code>
     * @return bool
     */
    public function getEnableNodeAutoprovisioning()
    {
        return $this->enable_node_autoprovisioning;
    }

    /**
     * Enables automatic node pool creation and deletion.
     *
     * Generated from protobuf field <code>bool enable_node_autoprovisioning = 1;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableNodeAutoprovisioning($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_node_autoprovisioning = $var;

        return $this;
    }

    /**
     * Contains global constraints regarding minimum and maximum
     * amount of resources in the cluster.
     *
     * Generated from protobuf field <code>repeated .google.container.v1beta1.ResourceLimit resource_limits = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getResourceLimits()
    {
        return $this->resource_limits;
    }

    /**
     * Contains global constraints regarding minimum and maximum
     * amount of resources in the cluster.
     *
     * Generated from protobuf field <code>repeated .google.container.v1beta1.ResourceLimit resource_limits = 2;</code>
     * @param \Google\Cloud\Container\V1beta1\ResourceLimit[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setResourceLimits($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Container\V1beta1\ResourceLimit::class);
        $this->resource_limits = $arr;

        return $this;
    }

    /**
     * Defines autoscaling behaviour.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClusterAutoscaling.AutoscalingProfile autoscaling_profile = 3;</code>
     * @return int
     */
    public function getAutoscalingProfile()
    {
        return $this->autoscaling_profile;
    }

    /**
     * Defines autoscaling behaviour.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClusterAutoscaling.AutoscalingProfile autoscaling_profile = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setAutoscalingProfile($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Container\V1beta1\ClusterAutoscaling\AutoscalingProfile::class);
        $this->autoscaling_profile = $var;

        return $this;
    }

    /**
     * AutoprovisioningNodePoolDefaults contains defaults for a node pool
     * created by NAP.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.AutoprovisioningNodePoolDefaults autoprovisioning_node_pool_defaults = 4;</code>
     * @return \Google\Cloud\Container\V1beta1\AutoprovisioningNodePoolDefaults|null
     */
    public function getAutoprovisioningNodePoolDefaults()
    {
        return isset($this->autoprovisioning_node_pool_defaults) ? $this->autoprovisioning_node_pool_defaults : null;
    }

    public function hasAutoprovisioningNodePoolDefaults()
    {
        return isset($this->autoprovisioning_node_pool_defaults);
    }

    public function clearAutoprovisioningNodePoolDefaults()
    {
        unset($this->autoprovisioning_node_pool_defaults);
    }

    /**
     * AutoprovisioningNodePoolDefaults contains defaults for a node pool
     * created by NAP.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.AutoprovisioningNodePoolDefaults autoprovisioning_node_pool_defaults = 4;</code>
     * @param \Google\Cloud\Container\V1beta1\AutoprovisioningNodePoolDefaults $var
     * @return $this
     */
    public function setAutoprovisioningNodePoolDefaults($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Container\V1beta1\AutoprovisioningNodePoolDefaults::class);
        $this->autoprovisioning_node_pool_defaults = $var;

        return $this;
    }

    /**
     * The list of Google Compute Engine
     * [zones](https://cloud.google.com/compute/docs/zones#available) in which the
     * NodePool's nodes can be created by NAP.
     *
     * Generated from protobuf field <code>repeated string autoprovisioning_locations = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAutoprovisioningLocations()
    {
        return $this->autoprovisioning_locations;
    }

    /**
     * The list of Google Compute Engine
     * [zones](https://cloud.google.com/compute/docs/zones#available) in which the
     * NodePool's nodes can be created by NAP.
     *
     * Generated from protobuf field <code>repeated string autoprovisioning_locations = 5;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAutoprovisioningLocations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->autoprovisioning_locations = $arr;

        return $this;
    }

}

