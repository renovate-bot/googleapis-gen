<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/orchestration/airflow/service/v1beta1/environments.proto

namespace Google\Cloud\Orchestration\Airflow\Service\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Restart Airflow web server.
 *
 * Generated from protobuf message <code>google.cloud.orchestration.airflow.service.v1beta1.RestartWebServerRequest</code>
 */
class RestartWebServerRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The resource name of the environment to restart the web server for, in the
     * form:
     * "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The resource name of the environment to restart the web server for, in the
     *           form:
     *           "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Orchestration\Airflow\Service\V1Beta1\Environments::initOnce();
        parent::__construct($data);
    }

    /**
     * The resource name of the environment to restart the web server for, in the
     * form:
     * "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The resource name of the environment to restart the web server for, in the
     * form:
     * "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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

}

