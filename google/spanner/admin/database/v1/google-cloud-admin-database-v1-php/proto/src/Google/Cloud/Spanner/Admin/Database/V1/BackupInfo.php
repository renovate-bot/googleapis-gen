<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/spanner/admin/database/v1/backup.proto

namespace Google\Cloud\Spanner\Admin\Database\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about a backup.
 *
 * Generated from protobuf message <code>google.spanner.admin.database.v1.BackupInfo</code>
 */
class BackupInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.resource_reference) = {</code>
     */
    protected $backup = '';
    /**
     * The backup contains an externally consistent copy of `source_database` at
     * the timestamp specified by `version_time`. If the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request did not specify `version_time`, the `version_time` of the backup is
     * equivalent to the `create_time`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp version_time = 4;</code>
     */
    protected $version_time = null;
    /**
     * The time the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 2;</code>
     */
    protected $create_time = null;
    /**
     * Name of the database the backup was created from.
     *
     * Generated from protobuf field <code>string source_database = 3 [(.google.api.resource_reference) = {</code>
     */
    protected $source_database = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $backup
     *           Name of the backup.
     *     @type \Google\Protobuf\Timestamp $version_time
     *           The backup contains an externally consistent copy of `source_database` at
     *           the timestamp specified by `version_time`. If the
     *           [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     *           request did not specify `version_time`, the `version_time` of the backup is
     *           equivalent to the `create_time`.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           The time the
     *           [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     *           request was received.
     *     @type string $source_database
     *           Name of the database the backup was created from.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Spanner\Admin\Database\V1\Backup::initOnce();
        parent::__construct($data);
    }

    /**
     * Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getBackup()
    {
        return $this->backup;
    }

    /**
     * Name of the backup.
     *
     * Generated from protobuf field <code>string backup = 1 [(.google.api.resource_reference) = {</code>
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
     * The backup contains an externally consistent copy of `source_database` at
     * the timestamp specified by `version_time`. If the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request did not specify `version_time`, the `version_time` of the backup is
     * equivalent to the `create_time`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp version_time = 4;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getVersionTime()
    {
        return isset($this->version_time) ? $this->version_time : null;
    }

    public function hasVersionTime()
    {
        return isset($this->version_time);
    }

    public function clearVersionTime()
    {
        unset($this->version_time);
    }

    /**
     * The backup contains an externally consistent copy of `source_database` at
     * the timestamp specified by `version_time`. If the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request did not specify `version_time`, the `version_time` of the backup is
     * equivalent to the `create_time`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp version_time = 4;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setVersionTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->version_time = $var;

        return $this;
    }

    /**
     * The time the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 2;</code>
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
     * The time the
     * [CreateBackup][google.spanner.admin.database.v1.DatabaseAdmin.CreateBackup]
     * request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 2;</code>
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
     * Name of the database the backup was created from.
     *
     * Generated from protobuf field <code>string source_database = 3 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getSourceDatabase()
    {
        return $this->source_database;
    }

    /**
     * Name of the database the backup was created from.
     *
     * Generated from protobuf field <code>string source_database = 3 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setSourceDatabase($var)
    {
        GPBUtil::checkString($var, True);
        $this->source_database = $var;

        return $this;
    }

}

