<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/ad_group_criterion_service.proto

namespace Google\Ads\GoogleAds\V4\Services;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A single operation (create, remove, update) on an ad group criterion.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.services.AdGroupCriterionOperation</code>
 */
class AdGroupCriterionOperation extends \Google\Protobuf\Internal\Message
{
    /**
     * FieldMask that determines which resource fields are modified in an update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4;</code>
     */
    protected $update_mask = null;
    /**
     * The list of policy violation keys that should not cause a
     * PolicyViolationError to be reported. Not all policy violations are
     * exemptable, please refer to the is_exemptible field in the returned
     * PolicyViolationError.
     * Resources violating these polices will be saved, but will not be eligible
     * to serve. They may begin serving at a later time due to a change in
     * policies, re-review of the resource, or a change in advertiser
     * certificates.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.common.PolicyViolationKey exempt_policy_violation_keys = 5;</code>
     */
    private $exempt_policy_violation_keys;
    protected $operation;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           FieldMask that determines which resource fields are modified in an update.
     *     @type \Google\Ads\GoogleAds\V4\Common\PolicyViolationKey[]|\Google\Protobuf\Internal\RepeatedField $exempt_policy_violation_keys
     *           The list of policy violation keys that should not cause a
     *           PolicyViolationError to be reported. Not all policy violations are
     *           exemptable, please refer to the is_exemptible field in the returned
     *           PolicyViolationError.
     *           Resources violating these polices will be saved, but will not be eligible
     *           to serve. They may begin serving at a later time due to a change in
     *           policies, re-review of the resource, or a change in advertiser
     *           certificates.
     *     @type \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion $create
     *           Create operation: No resource name is expected for the new criterion.
     *     @type \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion $update
     *           Update operation: The criterion is expected to have a valid resource
     *           name.
     *     @type string $remove
     *           Remove operation: A resource name for the removed criterion is expected,
     *           in this format:
     *           `customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}`
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Services\AdGroupCriterionService::initOnce();
        parent::__construct($data);
    }

    /**
     * FieldMask that determines which resource fields are modified in an update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * FieldMask that determines which resource fields are modified in an update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

    /**
     * The list of policy violation keys that should not cause a
     * PolicyViolationError to be reported. Not all policy violations are
     * exemptable, please refer to the is_exemptible field in the returned
     * PolicyViolationError.
     * Resources violating these polices will be saved, but will not be eligible
     * to serve. They may begin serving at a later time due to a change in
     * policies, re-review of the resource, or a change in advertiser
     * certificates.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.common.PolicyViolationKey exempt_policy_violation_keys = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getExemptPolicyViolationKeys()
    {
        return $this->exempt_policy_violation_keys;
    }

    /**
     * The list of policy violation keys that should not cause a
     * PolicyViolationError to be reported. Not all policy violations are
     * exemptable, please refer to the is_exemptible field in the returned
     * PolicyViolationError.
     * Resources violating these polices will be saved, but will not be eligible
     * to serve. They may begin serving at a later time due to a change in
     * policies, re-review of the resource, or a change in advertiser
     * certificates.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.common.PolicyViolationKey exempt_policy_violation_keys = 5;</code>
     * @param \Google\Ads\GoogleAds\V4\Common\PolicyViolationKey[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setExemptPolicyViolationKeys($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Ads\GoogleAds\V4\Common\PolicyViolationKey::class);
        $this->exempt_policy_violation_keys = $arr;

        return $this;
    }

    /**
     * Create operation: No resource name is expected for the new criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.AdGroupCriterion create = 1;</code>
     * @return \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion|null
     */
    public function getCreate()
    {
        return $this->readOneof(1);
    }

    public function hasCreate()
    {
        return $this->hasOneof(1);
    }

    /**
     * Create operation: No resource name is expected for the new criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.AdGroupCriterion create = 1;</code>
     * @param \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion $var
     * @return $this
     */
    public function setCreate($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Update operation: The criterion is expected to have a valid resource
     * name.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.AdGroupCriterion update = 2;</code>
     * @return \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion|null
     */
    public function getUpdate()
    {
        return $this->readOneof(2);
    }

    public function hasUpdate()
    {
        return $this->hasOneof(2);
    }

    /**
     * Update operation: The criterion is expected to have a valid resource
     * name.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.AdGroupCriterion update = 2;</code>
     * @param \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion $var
     * @return $this
     */
    public function setUpdate($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Resources\AdGroupCriterion::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Remove operation: A resource name for the removed criterion is expected,
     * in this format:
     * `customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}`
     *
     * Generated from protobuf field <code>string remove = 3;</code>
     * @return string
     */
    public function getRemove()
    {
        return $this->readOneof(3);
    }

    public function hasRemove()
    {
        return $this->hasOneof(3);
    }

    /**
     * Remove operation: A resource name for the removed criterion is expected,
     * in this format:
     * `customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}`
     *
     * Generated from protobuf field <code>string remove = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setRemove($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getOperation()
    {
        return $this->whichOneof("operation");
    }

}

