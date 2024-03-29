<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p4beta1/assets.proto

namespace Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A GCP resource that appears in an access control list.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.Resource</code>
 */
class Resource extends \Google\Protobuf\Internal\Message
{
    /**
     * The [full resource name](https://aip.dev/122#full-resource-names).
     *
     * Generated from protobuf field <code>string full_resource_name = 1;</code>
     */
    protected $full_resource_name = '';
    /**
     * The analysis state of this resource node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 2;</code>
     */
    protected $analysis_state = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $full_resource_name
     *           The [full resource name](https://aip.dev/122#full-resource-names).
     *     @type \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState $analysis_state
     *           The analysis state of this resource node.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1P4Beta1\Assets::initOnce();
        parent::__construct($data);
    }

    /**
     * The [full resource name](https://aip.dev/122#full-resource-names).
     *
     * Generated from protobuf field <code>string full_resource_name = 1;</code>
     * @return string
     */
    public function getFullResourceName()
    {
        return $this->full_resource_name;
    }

    /**
     * The [full resource name](https://aip.dev/122#full-resource-names).
     *
     * Generated from protobuf field <code>string full_resource_name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setFullResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->full_resource_name = $var;

        return $this;
    }

    /**
     * The analysis state of this resource node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 2;</code>
     * @return \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState|null
     */
    public function getAnalysisState()
    {
        return $this->analysis_state;
    }

    public function hasAnalysisState()
    {
        return isset($this->analysis_state);
    }

    public function clearAnalysisState()
    {
        unset($this->analysis_state);
    }

    /**
     * The analysis state of this resource node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 2;</code>
     * @param \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState $var
     * @return $this
     */
    public function setAnalysisState($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState::class);
        $this->analysis_state = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Resource::class, \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult_Resource::class);

