<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/import_config.proto

namespace Google\Cloud\Retail\V2beta;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Metadata related to the progress of the Import operation. This will be
 * returned by the google.longrunning.Operation.metadata field.
 *
 * Generated from protobuf message <code>google.cloud.retail.v2beta.ImportMetadata</code>
 */
class ImportMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Operation create time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
     */
    protected $create_time = null;
    /**
     * Operation last update time. If the operation is done, this is also the
     * finish time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 2;</code>
     */
    protected $update_time = null;
    /**
     * Count of entries that were processed successfully.
     *
     * Generated from protobuf field <code>int64 success_count = 3;</code>
     */
    protected $success_count = 0;
    /**
     * Count of entries that encountered errors while processing.
     *
     * Generated from protobuf field <code>int64 failure_count = 4;</code>
     */
    protected $failure_count = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Operation create time.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Operation last update time. If the operation is done, this is also the
     *           finish time.
     *     @type int|string $success_count
     *           Count of entries that were processed successfully.
     *     @type int|string $failure_count
     *           Count of entries that encountered errors while processing.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Retail\V2Beta\ImportConfig::initOnce();
        parent::__construct($data);
    }

    /**
     * Operation create time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
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
     * Operation create time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
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
     * Operation last update time. If the operation is done, this is also the
     * finish time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 2;</code>
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
     * Operation last update time. If the operation is done, this is also the
     * finish time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 2;</code>
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
     * Count of entries that were processed successfully.
     *
     * Generated from protobuf field <code>int64 success_count = 3;</code>
     * @return int|string
     */
    public function getSuccessCount()
    {
        return $this->success_count;
    }

    /**
     * Count of entries that were processed successfully.
     *
     * Generated from protobuf field <code>int64 success_count = 3;</code>
     * @param int|string $var
     * @return $this
     */
    public function setSuccessCount($var)
    {
        GPBUtil::checkInt64($var);
        $this->success_count = $var;

        return $this;
    }

    /**
     * Count of entries that encountered errors while processing.
     *
     * Generated from protobuf field <code>int64 failure_count = 4;</code>
     * @return int|string
     */
    public function getFailureCount()
    {
        return $this->failure_count;
    }

    /**
     * Count of entries that encountered errors while processing.
     *
     * Generated from protobuf field <code>int64 failure_count = 4;</code>
     * @param int|string $var
     * @return $this
     */
    public function setFailureCount($var)
    {
        GPBUtil::checkInt64($var);
        $this->failure_count = $var;

        return $this;
    }

}

