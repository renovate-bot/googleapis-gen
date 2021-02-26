<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p4beta1/assets.proto

namespace Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A role or permission that appears in an access control list.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.Access</code>
 */
class Access extends \Google\Protobuf\Internal\Message
{
    /**
     * The analysis state of this access node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 3;</code>
     */
    protected $analysis_state = null;
    protected $oneof_access;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $role
     *           The role.
     *     @type string $permission
     *           The permission.
     *     @type \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState $analysis_state
     *           The analysis state of this access node.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1P4Beta1\Assets::initOnce();
        parent::__construct($data);
    }

    /**
     * The role.
     *
     * Generated from protobuf field <code>string role = 1;</code>
     * @return string
     */
    public function getRole()
    {
        return $this->readOneof(1);
    }

    public function hasRole()
    {
        return $this->hasOneof(1);
    }

    /**
     * The role.
     *
     * Generated from protobuf field <code>string role = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setRole($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The permission.
     *
     * Generated from protobuf field <code>string permission = 2;</code>
     * @return string
     */
    public function getPermission()
    {
        return $this->readOneof(2);
    }

    public function hasPermission()
    {
        return $this->hasOneof(2);
    }

    /**
     * The permission.
     *
     * Generated from protobuf field <code>string permission = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setPermission($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * The analysis state of this access node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 3;</code>
     * @return \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState|null
     */
    public function getAnalysisState()
    {
        return isset($this->analysis_state) ? $this->analysis_state : null;
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
     * The analysis state of this access node.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult.AnalysisState analysis_state = 3;</code>
     * @param \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState $var
     * @return $this
     */
    public function setAnalysisState($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult\AnalysisState::class);
        $this->analysis_state = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getOneofAccess()
    {
        return $this->whichOneof("oneof_access");
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Access::class, \Google\Cloud\Asset\V1p4beta1\IamPolicyAnalysisResult_Access::class);

