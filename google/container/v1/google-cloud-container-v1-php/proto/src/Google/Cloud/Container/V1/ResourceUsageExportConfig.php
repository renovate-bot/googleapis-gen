<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/container/v1/cluster_service.proto

namespace Google\Cloud\Container\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Configuration for exporting cluster resource usages.
 *
 * Generated from protobuf message <code>google.container.v1.ResourceUsageExportConfig</code>
 */
class ResourceUsageExportConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * Configuration to use BigQuery as usage export destination.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.BigQueryDestination bigquery_destination = 1;</code>
     */
    protected $bigquery_destination = null;
    /**
     * Whether to enable network egress metering for this cluster. If enabled, a
     * daemonset will be created in the cluster to meter network egress traffic.
     *
     * Generated from protobuf field <code>bool enable_network_egress_metering = 2;</code>
     */
    protected $enable_network_egress_metering = false;
    /**
     * Configuration to enable resource consumption metering.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.ConsumptionMeteringConfig consumption_metering_config = 3;</code>
     */
    protected $consumption_metering_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Container\V1\ResourceUsageExportConfig\BigQueryDestination $bigquery_destination
     *           Configuration to use BigQuery as usage export destination.
     *     @type bool $enable_network_egress_metering
     *           Whether to enable network egress metering for this cluster. If enabled, a
     *           daemonset will be created in the cluster to meter network egress traffic.
     *     @type \Google\Cloud\Container\V1\ResourceUsageExportConfig\ConsumptionMeteringConfig $consumption_metering_config
     *           Configuration to enable resource consumption metering.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Container\V1\ClusterService::initOnce();
        parent::__construct($data);
    }

    /**
     * Configuration to use BigQuery as usage export destination.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.BigQueryDestination bigquery_destination = 1;</code>
     * @return \Google\Cloud\Container\V1\ResourceUsageExportConfig\BigQueryDestination|null
     */
    public function getBigqueryDestination()
    {
        return isset($this->bigquery_destination) ? $this->bigquery_destination : null;
    }

    public function hasBigqueryDestination()
    {
        return isset($this->bigquery_destination);
    }

    public function clearBigqueryDestination()
    {
        unset($this->bigquery_destination);
    }

    /**
     * Configuration to use BigQuery as usage export destination.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.BigQueryDestination bigquery_destination = 1;</code>
     * @param \Google\Cloud\Container\V1\ResourceUsageExportConfig\BigQueryDestination $var
     * @return $this
     */
    public function setBigqueryDestination($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Container\V1\ResourceUsageExportConfig\BigQueryDestination::class);
        $this->bigquery_destination = $var;

        return $this;
    }

    /**
     * Whether to enable network egress metering for this cluster. If enabled, a
     * daemonset will be created in the cluster to meter network egress traffic.
     *
     * Generated from protobuf field <code>bool enable_network_egress_metering = 2;</code>
     * @return bool
     */
    public function getEnableNetworkEgressMetering()
    {
        return $this->enable_network_egress_metering;
    }

    /**
     * Whether to enable network egress metering for this cluster. If enabled, a
     * daemonset will be created in the cluster to meter network egress traffic.
     *
     * Generated from protobuf field <code>bool enable_network_egress_metering = 2;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableNetworkEgressMetering($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_network_egress_metering = $var;

        return $this;
    }

    /**
     * Configuration to enable resource consumption metering.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.ConsumptionMeteringConfig consumption_metering_config = 3;</code>
     * @return \Google\Cloud\Container\V1\ResourceUsageExportConfig\ConsumptionMeteringConfig|null
     */
    public function getConsumptionMeteringConfig()
    {
        return isset($this->consumption_metering_config) ? $this->consumption_metering_config : null;
    }

    public function hasConsumptionMeteringConfig()
    {
        return isset($this->consumption_metering_config);
    }

    public function clearConsumptionMeteringConfig()
    {
        unset($this->consumption_metering_config);
    }

    /**
     * Configuration to enable resource consumption metering.
     *
     * Generated from protobuf field <code>.google.container.v1.ResourceUsageExportConfig.ConsumptionMeteringConfig consumption_metering_config = 3;</code>
     * @param \Google\Cloud\Container\V1\ResourceUsageExportConfig\ConsumptionMeteringConfig $var
     * @return $this
     */
    public function setConsumptionMeteringConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Container\V1\ResourceUsageExportConfig\ConsumptionMeteringConfig::class);
        $this->consumption_metering_config = $var;

        return $this;
    }

}

