<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/webrisk/v1beta1/webrisk.proto

namespace Google\Cloud\WebRisk\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes an API diff request.
 *
 * Generated from protobuf message <code>google.cloud.webrisk.v1beta1.ComputeThreatListDiffRequest</code>
 */
class ComputeThreatListDiffRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The ThreatList to update.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ThreatType threat_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $threat_type = 0;
    /**
     * The current version token of the client for the requested list (the
     * client version that was received from the last successful diff).
     *
     * Generated from protobuf field <code>bytes version_token = 2;</code>
     */
    protected $version_token = '';
    /**
     * Required. The constraints associated with this request.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ComputeThreatListDiffRequest.Constraints constraints = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $constraints = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $threat_type
     *           The ThreatList to update.
     *     @type string $version_token
     *           The current version token of the client for the requested list (the
     *           client version that was received from the last successful diff).
     *     @type \Google\Cloud\WebRisk\V1beta1\ComputeThreatListDiffRequest\Constraints $constraints
     *           Required. The constraints associated with this request.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Webrisk\V1Beta1\Webrisk::initOnce();
        parent::__construct($data);
    }

    /**
     * The ThreatList to update.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ThreatType threat_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getThreatType()
    {
        return $this->threat_type;
    }

    /**
     * The ThreatList to update.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ThreatType threat_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setThreatType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\WebRisk\V1beta1\ThreatType::class);
        $this->threat_type = $var;

        return $this;
    }

    /**
     * The current version token of the client for the requested list (the
     * client version that was received from the last successful diff).
     *
     * Generated from protobuf field <code>bytes version_token = 2;</code>
     * @return string
     */
    public function getVersionToken()
    {
        return $this->version_token;
    }

    /**
     * The current version token of the client for the requested list (the
     * client version that was received from the last successful diff).
     *
     * Generated from protobuf field <code>bytes version_token = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setVersionToken($var)
    {
        GPBUtil::checkString($var, False);
        $this->version_token = $var;

        return $this;
    }

    /**
     * Required. The constraints associated with this request.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ComputeThreatListDiffRequest.Constraints constraints = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\WebRisk\V1beta1\ComputeThreatListDiffRequest\Constraints|null
     */
    public function getConstraints()
    {
        return isset($this->constraints) ? $this->constraints : null;
    }

    public function hasConstraints()
    {
        return isset($this->constraints);
    }

    public function clearConstraints()
    {
        unset($this->constraints);
    }

    /**
     * Required. The constraints associated with this request.
     *
     * Generated from protobuf field <code>.google.cloud.webrisk.v1beta1.ComputeThreatListDiffRequest.Constraints constraints = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\WebRisk\V1beta1\ComputeThreatListDiffRequest\Constraints $var
     * @return $this
     */
    public function setConstraints($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\WebRisk\V1beta1\ComputeThreatListDiffRequest\Constraints::class);
        $this->constraints = $var;

        return $this;
    }

}

