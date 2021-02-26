<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/errors/errors.proto

namespace Google\Ads\GoogleAds\V5\Errors;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Additional error details.
 *
 * Generated from protobuf message <code>google.ads.googleads.v5.errors.ErrorDetails</code>
 */
class ErrorDetails extends \Google\Protobuf\Internal\Message
{
    /**
     * The error code that should have been returned, but wasn't. This is used
     * when the error code is not published in the client specified version.
     *
     * Generated from protobuf field <code>string unpublished_error_code = 1;</code>
     */
    protected $unpublished_error_code = '';
    /**
     * Describes an ad policy violation.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyViolationDetails policy_violation_details = 2;</code>
     */
    protected $policy_violation_details = null;
    /**
     * Describes policy violation findings.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyFindingDetails policy_finding_details = 3;</code>
     */
    protected $policy_finding_details = null;
    /**
     * Details on the quota error, including the scope (account or developer), the
     * rate bucket name and the retry delay.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.QuotaErrorDetails quota_error_details = 4;</code>
     */
    protected $quota_error_details = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $unpublished_error_code
     *           The error code that should have been returned, but wasn't. This is used
     *           when the error code is not published in the client specified version.
     *     @type \Google\Ads\GoogleAds\V5\Errors\PolicyViolationDetails $policy_violation_details
     *           Describes an ad policy violation.
     *     @type \Google\Ads\GoogleAds\V5\Errors\PolicyFindingDetails $policy_finding_details
     *           Describes policy violation findings.
     *     @type \Google\Ads\GoogleAds\V5\Errors\QuotaErrorDetails $quota_error_details
     *           Details on the quota error, including the scope (account or developer), the
     *           rate bucket name and the retry delay.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V5\Errors\Errors::initOnce();
        parent::__construct($data);
    }

    /**
     * The error code that should have been returned, but wasn't. This is used
     * when the error code is not published in the client specified version.
     *
     * Generated from protobuf field <code>string unpublished_error_code = 1;</code>
     * @return string
     */
    public function getUnpublishedErrorCode()
    {
        return $this->unpublished_error_code;
    }

    /**
     * The error code that should have been returned, but wasn't. This is used
     * when the error code is not published in the client specified version.
     *
     * Generated from protobuf field <code>string unpublished_error_code = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setUnpublishedErrorCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->unpublished_error_code = $var;

        return $this;
    }

    /**
     * Describes an ad policy violation.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyViolationDetails policy_violation_details = 2;</code>
     * @return \Google\Ads\GoogleAds\V5\Errors\PolicyViolationDetails|null
     */
    public function getPolicyViolationDetails()
    {
        return isset($this->policy_violation_details) ? $this->policy_violation_details : null;
    }

    public function hasPolicyViolationDetails()
    {
        return isset($this->policy_violation_details);
    }

    public function clearPolicyViolationDetails()
    {
        unset($this->policy_violation_details);
    }

    /**
     * Describes an ad policy violation.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyViolationDetails policy_violation_details = 2;</code>
     * @param \Google\Ads\GoogleAds\V5\Errors\PolicyViolationDetails $var
     * @return $this
     */
    public function setPolicyViolationDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Errors\PolicyViolationDetails::class);
        $this->policy_violation_details = $var;

        return $this;
    }

    /**
     * Describes policy violation findings.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyFindingDetails policy_finding_details = 3;</code>
     * @return \Google\Ads\GoogleAds\V5\Errors\PolicyFindingDetails|null
     */
    public function getPolicyFindingDetails()
    {
        return isset($this->policy_finding_details) ? $this->policy_finding_details : null;
    }

    public function hasPolicyFindingDetails()
    {
        return isset($this->policy_finding_details);
    }

    public function clearPolicyFindingDetails()
    {
        unset($this->policy_finding_details);
    }

    /**
     * Describes policy violation findings.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.PolicyFindingDetails policy_finding_details = 3;</code>
     * @param \Google\Ads\GoogleAds\V5\Errors\PolicyFindingDetails $var
     * @return $this
     */
    public function setPolicyFindingDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Errors\PolicyFindingDetails::class);
        $this->policy_finding_details = $var;

        return $this;
    }

    /**
     * Details on the quota error, including the scope (account or developer), the
     * rate bucket name and the retry delay.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.QuotaErrorDetails quota_error_details = 4;</code>
     * @return \Google\Ads\GoogleAds\V5\Errors\QuotaErrorDetails|null
     */
    public function getQuotaErrorDetails()
    {
        return isset($this->quota_error_details) ? $this->quota_error_details : null;
    }

    public function hasQuotaErrorDetails()
    {
        return isset($this->quota_error_details);
    }

    public function clearQuotaErrorDetails()
    {
        unset($this->quota_error_details);
    }

    /**
     * Details on the quota error, including the scope (account or developer), the
     * rate bucket name and the retry delay.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.errors.QuotaErrorDetails quota_error_details = 4;</code>
     * @param \Google\Ads\GoogleAds\V5\Errors\QuotaErrorDetails $var
     * @return $this
     */
    public function setQuotaErrorDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Errors\QuotaErrorDetails::class);
        $this->quota_error_details = $var;

        return $this;
    }

}

