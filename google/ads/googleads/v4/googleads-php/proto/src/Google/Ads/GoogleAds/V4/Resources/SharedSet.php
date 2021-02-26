<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/shared_set.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * SharedSets are used for sharing criterion exclusions across multiple
 * campaigns.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.SharedSet</code>
 */
class SharedSet extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the shared set.
     * Shared set resource names have the form:
     * `customers/{customer_id}/sharedSets/{shared_set_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Output only. The ID of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $id = null;
    /**
     * Immutable. The type of this shared set: each shared set holds only a single kind
     * of resource. Required. Immutable.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetTypeEnum.SharedSetType type = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $type = 0;
    /**
     * The name of this shared set. Required.
     * Shared Sets must have names that are unique among active shared sets of
     * the same type.
     * The length of this string should be between 1 and 255 UTF-8 bytes,
     * inclusive.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     */
    protected $name = null;
    /**
     * Output only. The status of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetStatusEnum.SharedSetStatus status = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $status = 0;
    /**
     * Output only. The number of shared criteria within this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value member_count = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $member_count = null;
    /**
     * Output only. The number of campaigns associated with this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value reference_count = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $reference_count = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the shared set.
     *           Shared set resource names have the form:
     *           `customers/{customer_id}/sharedSets/{shared_set_id}`
     *     @type \Google\Protobuf\Int64Value $id
     *           Output only. The ID of this shared set. Read only.
     *     @type int $type
     *           Immutable. The type of this shared set: each shared set holds only a single kind
     *           of resource. Required. Immutable.
     *     @type \Google\Protobuf\StringValue $name
     *           The name of this shared set. Required.
     *           Shared Sets must have names that are unique among active shared sets of
     *           the same type.
     *           The length of this string should be between 1 and 255 UTF-8 bytes,
     *           inclusive.
     *     @type int $status
     *           Output only. The status of this shared set. Read only.
     *     @type \Google\Protobuf\Int64Value $member_count
     *           Output only. The number of shared criteria within this shared set. Read only.
     *     @type \Google\Protobuf\Int64Value $reference_count
     *           Output only. The number of campaigns associated with this shared set. Read only.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\SharedSet::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the shared set.
     * Shared set resource names have the form:
     * `customers/{customer_id}/sharedSets/{shared_set_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the shared set.
     * Shared set resource names have the form:
     * `customers/{customer_id}/sharedSets/{shared_set_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_name = $var;

        return $this;
    }

    /**
     * Output only. The ID of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getId()
    {
        return isset($this->id) ? $this->id : null;
    }

    public function hasId()
    {
        return isset($this->id);
    }

    public function clearId()
    {
        unset($this->id);
    }

    /**
     * Returns the unboxed value from <code>getId()</code>

     * Output only. The ID of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getIdUnwrapped()
    {
        return $this->readWrapperValue("id");
    }

    /**
     * Output only. The ID of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The ID of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setIdUnwrapped($var)
    {
        $this->writeWrapperValue("id", $var);
        return $this;}

    /**
     * Immutable. The type of this shared set: each shared set holds only a single kind
     * of resource. Required. Immutable.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetTypeEnum.SharedSetType type = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * Immutable. The type of this shared set: each shared set holds only a single kind
     * of resource. Required. Immutable.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetTypeEnum.SharedSetType type = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\SharedSetTypeEnum\SharedSetType::class);
        $this->type = $var;

        return $this;
    }

    /**
     * The name of this shared set. Required.
     * Shared Sets must have names that are unique among active shared sets of
     * the same type.
     * The length of this string should be between 1 and 255 UTF-8 bytes,
     * inclusive.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getName()
    {
        return isset($this->name) ? $this->name : null;
    }

    public function hasName()
    {
        return isset($this->name);
    }

    public function clearName()
    {
        unset($this->name);
    }

    /**
     * Returns the unboxed value from <code>getName()</code>

     * The name of this shared set. Required.
     * Shared Sets must have names that are unique among active shared sets of
     * the same type.
     * The length of this string should be between 1 and 255 UTF-8 bytes,
     * inclusive.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @return string|null
     */
    public function getNameUnwrapped()
    {
        return $this->readWrapperValue("name");
    }

    /**
     * The name of this shared set. Required.
     * Shared Sets must have names that are unique among active shared sets of
     * the same type.
     * The length of this string should be between 1 and 255 UTF-8 bytes,
     * inclusive.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->name = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * The name of this shared set. Required.
     * Shared Sets must have names that are unique among active shared sets of
     * the same type.
     * The length of this string should be between 1 and 255 UTF-8 bytes,
     * inclusive.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @param string|null $var
     * @return $this
     */
    public function setNameUnwrapped($var)
    {
        $this->writeWrapperValue("name", $var);
        return $this;}

    /**
     * Output only. The status of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetStatusEnum.SharedSetStatus status = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getStatus()
    {
        return $this->status;
    }

    /**
     * Output only. The status of this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.SharedSetStatusEnum.SharedSetStatus status = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\SharedSetStatusEnum\SharedSetStatus::class);
        $this->status = $var;

        return $this;
    }

    /**
     * Output only. The number of shared criteria within this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value member_count = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getMemberCount()
    {
        return isset($this->member_count) ? $this->member_count : null;
    }

    public function hasMemberCount()
    {
        return isset($this->member_count);
    }

    public function clearMemberCount()
    {
        unset($this->member_count);
    }

    /**
     * Returns the unboxed value from <code>getMemberCount()</code>

     * Output only. The number of shared criteria within this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value member_count = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getMemberCountUnwrapped()
    {
        return $this->readWrapperValue("member_count");
    }

    /**
     * Output only. The number of shared criteria within this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value member_count = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setMemberCount($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->member_count = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The number of shared criteria within this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value member_count = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setMemberCountUnwrapped($var)
    {
        $this->writeWrapperValue("member_count", $var);
        return $this;}

    /**
     * Output only. The number of campaigns associated with this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value reference_count = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getReferenceCount()
    {
        return isset($this->reference_count) ? $this->reference_count : null;
    }

    public function hasReferenceCount()
    {
        return isset($this->reference_count);
    }

    public function clearReferenceCount()
    {
        unset($this->reference_count);
    }

    /**
     * Returns the unboxed value from <code>getReferenceCount()</code>

     * Output only. The number of campaigns associated with this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value reference_count = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getReferenceCountUnwrapped()
    {
        return $this->readWrapperValue("reference_count");
    }

    /**
     * Output only. The number of campaigns associated with this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value reference_count = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setReferenceCount($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->reference_count = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The number of campaigns associated with this shared set. Read only.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value reference_count = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setReferenceCountUnwrapped($var)
    {
        $this->writeWrapperValue("reference_count", $var);
        return $this;}

}

