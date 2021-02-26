<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/logging/v2/logging_config.proto

namespace Google\Cloud\Logging\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes a repository of logs.
 *
 * Generated from protobuf message <code>google.logging.v2.LogBucket</code>
 */
class LogBucket extends \Google\Protobuf\Internal\Message
{
    /**
     * The resource name of the bucket.
     * For example:
     * "projects/my-project-id/locations/my-location/buckets/my-bucket-id The
     * supported locations are:
     *   "global"
     * For the location of `global` it is unspecified where logs are actually
     * stored.
     * Once a bucket has been created, the location can not be changed.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Describes this bucket.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     */
    protected $description = '';
    /**
     * Output only. The creation timestamp of the bucket. This is not set for any of the
     * default buckets.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $create_time = null;
    /**
     * Output only. The last update timestamp of the bucket.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $update_time = null;
    /**
     * Logs will be retained by default for this amount of time, after which they
     * will automatically be deleted. The minimum retention period is 1 day.
     * If this value is set to zero at bucket creation time, the default time of
     * 30 days will be used.
     *
     * Generated from protobuf field <code>int32 retention_days = 11;</code>
     */
    protected $retention_days = 0;
    /**
     * Whether the bucket has been locked.
     * The retention period on a locked bucket may not be changed.
     * Locked buckets may only be deleted if they are empty.
     *
     * Generated from protobuf field <code>bool locked = 9;</code>
     */
    protected $locked = false;
    /**
     * Output only. The bucket lifecycle state.
     *
     * Generated from protobuf field <code>.google.logging.v2.LifecycleState lifecycle_state = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $lifecycle_state = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The resource name of the bucket.
     *           For example:
     *           "projects/my-project-id/locations/my-location/buckets/my-bucket-id The
     *           supported locations are:
     *             "global"
     *           For the location of `global` it is unspecified where logs are actually
     *           stored.
     *           Once a bucket has been created, the location can not be changed.
     *     @type string $description
     *           Describes this bucket.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Output only. The creation timestamp of the bucket. This is not set for any of the
     *           default buckets.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Output only. The last update timestamp of the bucket.
     *     @type int $retention_days
     *           Logs will be retained by default for this amount of time, after which they
     *           will automatically be deleted. The minimum retention period is 1 day.
     *           If this value is set to zero at bucket creation time, the default time of
     *           30 days will be used.
     *     @type bool $locked
     *           Whether the bucket has been locked.
     *           The retention period on a locked bucket may not be changed.
     *           Locked buckets may only be deleted if they are empty.
     *     @type int $lifecycle_state
     *           Output only. The bucket lifecycle state.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Logging\V2\LoggingConfig::initOnce();
        parent::__construct($data);
    }

    /**
     * The resource name of the bucket.
     * For example:
     * "projects/my-project-id/locations/my-location/buckets/my-bucket-id The
     * supported locations are:
     *   "global"
     * For the location of `global` it is unspecified where logs are actually
     * stored.
     * Once a bucket has been created, the location can not be changed.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The resource name of the bucket.
     * For example:
     * "projects/my-project-id/locations/my-location/buckets/my-bucket-id The
     * supported locations are:
     *   "global"
     * For the location of `global` it is unspecified where logs are actually
     * stored.
     * Once a bucket has been created, the location can not be changed.
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
     * Describes this bucket.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Describes this bucket.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * Output only. The creation timestamp of the bucket. This is not set for any of the
     * default buckets.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return isset($this->create_time) ? $this->create_time : null;
    }

    public function hasCreateTime()
    {
        return isset($this->create_time);
    }

    public function clearCreateTime()
    {
        unset($this->create_time);
    }

    /**
     * Output only. The creation timestamp of the bucket. This is not set for any of the
     * default buckets.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->create_time = $var;

        return $this;
    }

    /**
     * Output only. The last update timestamp of the bucket.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUpdateTime()
    {
        return isset($this->update_time) ? $this->update_time : null;
    }

    public function hasUpdateTime()
    {
        return isset($this->update_time);
    }

    public function clearUpdateTime()
    {
        unset($this->update_time);
    }

    /**
     * Output only. The last update timestamp of the bucket.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

    /**
     * Logs will be retained by default for this amount of time, after which they
     * will automatically be deleted. The minimum retention period is 1 day.
     * If this value is set to zero at bucket creation time, the default time of
     * 30 days will be used.
     *
     * Generated from protobuf field <code>int32 retention_days = 11;</code>
     * @return int
     */
    public function getRetentionDays()
    {
        return $this->retention_days;
    }

    /**
     * Logs will be retained by default for this amount of time, after which they
     * will automatically be deleted. The minimum retention period is 1 day.
     * If this value is set to zero at bucket creation time, the default time of
     * 30 days will be used.
     *
     * Generated from protobuf field <code>int32 retention_days = 11;</code>
     * @param int $var
     * @return $this
     */
    public function setRetentionDays($var)
    {
        GPBUtil::checkInt32($var);
        $this->retention_days = $var;

        return $this;
    }

    /**
     * Whether the bucket has been locked.
     * The retention period on a locked bucket may not be changed.
     * Locked buckets may only be deleted if they are empty.
     *
     * Generated from protobuf field <code>bool locked = 9;</code>
     * @return bool
     */
    public function getLocked()
    {
        return $this->locked;
    }

    /**
     * Whether the bucket has been locked.
     * The retention period on a locked bucket may not be changed.
     * Locked buckets may only be deleted if they are empty.
     *
     * Generated from protobuf field <code>bool locked = 9;</code>
     * @param bool $var
     * @return $this
     */
    public function setLocked($var)
    {
        GPBUtil::checkBool($var);
        $this->locked = $var;

        return $this;
    }

    /**
     * Output only. The bucket lifecycle state.
     *
     * Generated from protobuf field <code>.google.logging.v2.LifecycleState lifecycle_state = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getLifecycleState()
    {
        return $this->lifecycle_state;
    }

    /**
     * Output only. The bucket lifecycle state.
     *
     * Generated from protobuf field <code>.google.logging.v2.LifecycleState lifecycle_state = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setLifecycleState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Logging\V2\LifecycleState::class);
        $this->lifecycle_state = $var;

        return $this;
    }

}

