<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gsuiteaddons/v1/gsuiteaddons.proto

namespace Google\Cloud\GSuiteAddOns\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message to create a deployment.
 *
 * Generated from protobuf message <code>google.cloud.gsuiteaddons.v1.CreateDeploymentRequest</code>
 */
class CreateDeploymentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Name of the project in which to create the deployment.
     * Example: `projects/my_project`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The id to use for this deployment.  The full name of the created
     * resource will be `projects/<project_number>/deployments/<deployment_id>`.
     *
     * Generated from protobuf field <code>string deployment_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $deployment_id = '';
    /**
     * Required. The deployment to create (deployment.name cannot be set).
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $deployment = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. Name of the project in which to create the deployment.
     *           Example: `projects/my_project`.
     *     @type string $deployment_id
     *           Required. The id to use for this deployment.  The full name of the created
     *           resource will be `projects/<project_number>/deployments/<deployment_id>`.
     *     @type \Google\Cloud\GSuiteAddOns\V1\Deployment $deployment
     *           Required. The deployment to create (deployment.name cannot be set).
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gsuiteaddons\V1\Gsuiteaddons::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Name of the project in which to create the deployment.
     * Example: `projects/my_project`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. Name of the project in which to create the deployment.
     * Example: `projects/my_project`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. The id to use for this deployment.  The full name of the created
     * resource will be `projects/<project_number>/deployments/<deployment_id>`.
     *
     * Generated from protobuf field <code>string deployment_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDeploymentId()
    {
        return $this->deployment_id;
    }

    /**
     * Required. The id to use for this deployment.  The full name of the created
     * resource will be `projects/<project_number>/deployments/<deployment_id>`.
     *
     * Generated from protobuf field <code>string deployment_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setDeploymentId($var)
    {
        GPBUtil::checkString($var, True);
        $this->deployment_id = $var;

        return $this;
    }

    /**
     * Required. The deployment to create (deployment.name cannot be set).
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\GSuiteAddOns\V1\Deployment|null
     */
    public function getDeployment()
    {
        return isset($this->deployment) ? $this->deployment : null;
    }

    public function hasDeployment()
    {
        return isset($this->deployment);
    }

    public function clearDeployment()
    {
        unset($this->deployment);
    }

    /**
     * Required. The deployment to create (deployment.name cannot be set).
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\GSuiteAddOns\V1\Deployment $var
     * @return $this
     */
    public function setDeployment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\GSuiteAddOns\V1\Deployment::class);
        $this->deployment = $var;

        return $this;
    }

}

