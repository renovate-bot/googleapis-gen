<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/service.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A `Service` is a discrete, autonomous, and network-accessible unit, designed
 * to solve an individual concern
 * ([Wikipedia](https://en.wikipedia.org/wiki/Service-orientation)). In
 * Cloud Monitoring, a `Service` acts as the root resource under which
 * operational aspects of the service are accessible.
 *
 * Generated from protobuf message <code>google.monitoring.v3.Service</code>
 */
class Service extends \Google\Protobuf\Internal\Message
{
    /**
     * Resource name for this Service. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Name used for UI elements listing this Service.
     *
     * Generated from protobuf field <code>string display_name = 2;</code>
     */
    protected $display_name = '';
    /**
     * Configuration for how to query telemetry on a Service.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.Telemetry telemetry = 13;</code>
     */
    protected $telemetry = null;
    protected $identifier;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Resource name for this Service. The format is:
     *               projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
     *     @type string $display_name
     *           Name used for UI elements listing this Service.
     *     @type \Google\Cloud\Monitoring\V3\Service\Custom $custom
     *           Custom service type.
     *     @type \Google\Cloud\Monitoring\V3\Service\AppEngine $app_engine
     *           Type used for App Engine services.
     *     @type \Google\Cloud\Monitoring\V3\Service\CloudEndpoints $cloud_endpoints
     *           Type used for Cloud Endpoints services.
     *     @type \Google\Cloud\Monitoring\V3\Service\ClusterIstio $cluster_istio
     *           Type used for Istio services that live in a Kubernetes cluster.
     *     @type \Google\Cloud\Monitoring\V3\Service\MeshIstio $mesh_istio
     *           Type used for Istio services scoped to an Istio mesh.
     *     @type \Google\Cloud\Monitoring\V3\Service\Telemetry $telemetry
     *           Configuration for how to query telemetry on a Service.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * Resource name for this Service. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Resource name for this Service. The format is:
     *     projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * Name used for UI elements listing this Service.
     *
     * Generated from protobuf field <code>string display_name = 2;</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Name used for UI elements listing this Service.
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
     * Custom service type.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.Custom custom = 6;</code>
     * @return \Google\Cloud\Monitoring\V3\Service\Custom|null
     */
    public function getCustom()
    {
        return $this->readOneof(6);
    }

    public function hasCustom()
    {
        return $this->hasOneof(6);
    }

    /**
     * Custom service type.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.Custom custom = 6;</code>
     * @param \Google\Cloud\Monitoring\V3\Service\Custom $var
     * @return $this
     */
    public function setCustom($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\Custom::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * Type used for App Engine services.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.AppEngine app_engine = 7;</code>
     * @return \Google\Cloud\Monitoring\V3\Service\AppEngine|null
     */
    public function getAppEngine()
    {
        return $this->readOneof(7);
    }

    public function hasAppEngine()
    {
        return $this->hasOneof(7);
    }

    /**
     * Type used for App Engine services.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.AppEngine app_engine = 7;</code>
     * @param \Google\Cloud\Monitoring\V3\Service\AppEngine $var
     * @return $this
     */
    public function setAppEngine($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\AppEngine::class);
        $this->writeOneof(7, $var);

        return $this;
    }

    /**
     * Type used for Cloud Endpoints services.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.CloudEndpoints cloud_endpoints = 8;</code>
     * @return \Google\Cloud\Monitoring\V3\Service\CloudEndpoints|null
     */
    public function getCloudEndpoints()
    {
        return $this->readOneof(8);
    }

    public function hasCloudEndpoints()
    {
        return $this->hasOneof(8);
    }

    /**
     * Type used for Cloud Endpoints services.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.CloudEndpoints cloud_endpoints = 8;</code>
     * @param \Google\Cloud\Monitoring\V3\Service\CloudEndpoints $var
     * @return $this
     */
    public function setCloudEndpoints($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\CloudEndpoints::class);
        $this->writeOneof(8, $var);

        return $this;
    }

    /**
     * Type used for Istio services that live in a Kubernetes cluster.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.ClusterIstio cluster_istio = 9 [deprecated = true];</code>
     * @return \Google\Cloud\Monitoring\V3\Service\ClusterIstio|null
     * @deprecated
     */
    public function getClusterIstio()
    {
        @trigger_error('cluster_istio is deprecated.', E_USER_DEPRECATED);
        return $this->readOneof(9);
    }

    public function hasClusterIstio()
    {
        @trigger_error('cluster_istio is deprecated.', E_USER_DEPRECATED);
        return $this->hasOneof(9);
    }

    /**
     * Type used for Istio services that live in a Kubernetes cluster.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.ClusterIstio cluster_istio = 9 [deprecated = true];</code>
     * @param \Google\Cloud\Monitoring\V3\Service\ClusterIstio $var
     * @return $this
     * @deprecated
     */
    public function setClusterIstio($var)
    {
        @trigger_error('cluster_istio is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\ClusterIstio::class);
        $this->writeOneof(9, $var);

        return $this;
    }

    /**
     * Type used for Istio services scoped to an Istio mesh.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.MeshIstio mesh_istio = 10;</code>
     * @return \Google\Cloud\Monitoring\V3\Service\MeshIstio|null
     */
    public function getMeshIstio()
    {
        return $this->readOneof(10);
    }

    public function hasMeshIstio()
    {
        return $this->hasOneof(10);
    }

    /**
     * Type used for Istio services scoped to an Istio mesh.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.MeshIstio mesh_istio = 10;</code>
     * @param \Google\Cloud\Monitoring\V3\Service\MeshIstio $var
     * @return $this
     */
    public function setMeshIstio($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\MeshIstio::class);
        $this->writeOneof(10, $var);

        return $this;
    }

    /**
     * Configuration for how to query telemetry on a Service.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.Telemetry telemetry = 13;</code>
     * @return \Google\Cloud\Monitoring\V3\Service\Telemetry|null
     */
    public function getTelemetry()
    {
        return isset($this->telemetry) ? $this->telemetry : null;
    }

    public function hasTelemetry()
    {
        return isset($this->telemetry);
    }

    public function clearTelemetry()
    {
        unset($this->telemetry);
    }

    /**
     * Configuration for how to query telemetry on a Service.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Service.Telemetry telemetry = 13;</code>
     * @param \Google\Cloud\Monitoring\V3\Service\Telemetry $var
     * @return $this
     */
    public function setTelemetry($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\Service\Telemetry::class);
        $this->telemetry = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getIdentifier()
    {
        return $this->whichOneof("identifier");
    }

}

