<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/bigtable/admin/v2/table.proto

namespace Google\Cloud\Bigtable\Admin\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about a backup.
 *
 * Generated from protobuf message <code>google.bigtable.admin.v2.BackupInfo</code>
 */
class BackupInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $backup = '';
    /**
     * Output only. The time that the backup was started. Row data in the backup
     * will be no older than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $start_time = null;
    /**
     * Output only. This time that the backup was finished. Row data in the
     * backup will be no newer than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $end_time = null;
    /**
     * Output only. Name of the table the backup was created from.
     *
     * Generated from protobuf field <code>string source_table = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $source_table = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $backup
     *           Output only. Name of the backup.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Output only. The time that the backup was started. Row data in the backup
     *           will be no older than this timestamp.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Output only. This time that the backup was finished. Row data in the
     *           backup will be no newer than this timestamp.
     *     @type string $source_table
     *           Output only. Name of the table the backup was created from.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Bigtable\Admin\V2\Table::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getBackup()
    {
        return $this->backup;
    }

    /**
     * Output only. Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setBackup($var)
    {
        GPBUtil::checkString($var, True);
        $this->backup = $var;

        return $this;
    }

    /**
     * Output only. The time that the backup was started. Row data in the backup
     * will be no older than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getStartTime()
    {
        return isset($this->start_time) ? $this->start_time : null;
    }

    public function hasStartTime()
    {
        return isset($this->start_time);
    }

    public function clearStartTime()
    {
        unset($this->start_time);
    }

    /**
     * Output only. The time that the backup was started. Row data in the backup
     * will be no older than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Output only. This time that the backup was finished. Row data in the
     * backup will be no newer than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEndTime()
    {
        return isset($this->end_time) ? $this->end_time : null;
    }

    public function hasEndTime()
    {
        return isset($this->end_time);
    }

    public function clearEndTime()
    {
        unset($this->end_time);
    }

    /**
     * Output only. This time that the backup was finished. Row data in the
     * backup will be no newer than this timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * Output only. Name of the table the backup was created from.
     *
     * Generated from protobuf field <code>string source_table = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getSourceTable()
    {
        return $this->source_table;
    }

    /**
     * Output only. Name of the table the backup was created from.
     *
     * Generated from protobuf field <code>string source_table = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setSourceTable($var)
    {
        GPBUtil::checkString($var, True);
        $this->source_table = $var;

        return $this;
    }

}

