<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gsuiteaddons/v1/gsuiteaddons.proto

namespace Google\Cloud\GSuiteAddOns\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message to create or replace a deployment.
 *
 * Generated from protobuf message <code>google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest</code>
 */
class ReplaceDeploymentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The deployment to create or replace.
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $deployment = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\GSuiteAddOns\V1\Deployment $deployment
     *           Required. The deployment to create or replace.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gsuiteaddons\V1\Gsuiteaddons::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The deployment to create or replace.
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The deployment to create or replace.
     *
     * Generated from protobuf field <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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

