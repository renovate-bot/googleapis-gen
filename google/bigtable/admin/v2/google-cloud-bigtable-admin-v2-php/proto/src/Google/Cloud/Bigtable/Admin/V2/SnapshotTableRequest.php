<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/bigtable/admin/v2/bigtable_table_admin.proto

namespace Google\Cloud\Bigtable\Admin\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [google.bigtable.admin.v2.BigtableTableAdmin.SnapshotTable][google.bigtable.admin.v2.BigtableTableAdmin.SnapshotTable]
 * Note: This is a private alpha release of Cloud Bigtable snapshots. This
 * feature is not currently available to most Cloud Bigtable customers. This
 * feature might be changed in backward-incompatible ways and is not recommended
 * for production use. It is not subject to any SLA or deprecation policy.
 *
 * Generated from protobuf message <code>google.bigtable.admin.v2.SnapshotTableRequest</code>
 */
class SnapshotTableRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The unique name of the table to have the snapshot taken.
     * Values are of the form
     * `projects/{project}/instances/{instance}/tables/{table}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. The name of the cluster where the snapshot will be created in.
     * Values are of the form
     * `projects/{project}/instances/{instance}/clusters/{cluster}`.
     *
     * Generated from protobuf field <code>string cluster = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $cluster = '';
    /**
     * Required. The ID by which the new snapshot should be referred to within the parent
     * cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
     * rather than
     * `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
     *
     * Generated from protobuf field <code>string snapshot_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $snapshot_id = '';
    /**
     * The amount of time that the new snapshot can stay active after it is
     * created. Once 'ttl' expires, the snapshot will get deleted. The maximum
     * amount of time a snapshot can stay active is 7 days. If 'ttl' is not
     * specified, the default value of 24 hours will be used.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration ttl = 4;</code>
     */
    protected $ttl = null;
    /**
     * Description of the snapshot.
     *
     * Generated from protobuf field <code>string description = 5;</code>
     */
    protected $description = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The unique name of the table to have the snapshot taken.
     *           Values are of the form
     *           `projects/{project}/instances/{instance}/tables/{table}`.
     *     @type string $cluster
     *           Required. The name of the cluster where the snapshot will be created in.
     *           Values are of the form
     *           `projects/{project}/instances/{instance}/clusters/{cluster}`.
     *     @type string $snapshot_id
     *           Required. The ID by which the new snapshot should be referred to within the parent
     *           cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
     *           rather than
     *           `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
     *     @type \Google\Protobuf\Duration $ttl
     *           The amount of time that the new snapshot can stay active after it is
     *           created. Once 'ttl' expires, the snapshot will get deleted. The maximum
     *           amount of time a snapshot can stay active is 7 days. If 'ttl' is not
     *           specified, the default value of 24 hours will be used.
     *     @type string $description
     *           Description of the snapshot.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Bigtable\Admin\V2\BigtableTableAdmin::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The unique name of the table to have the snapshot taken.
     * Values are of the form
     * `projects/{project}/instances/{instance}/tables/{table}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The unique name of the table to have the snapshot taken.
     * Values are of the form
     * `projects/{project}/instances/{instance}/tables/{table}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Required. The name of the cluster where the snapshot will be created in.
     * Values are of the form
     * `projects/{project}/instances/{instance}/clusters/{cluster}`.
     *
     * Generated from protobuf field <code>string cluster = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getCluster()
    {
        return $this->cluster;
    }

    /**
     * Required. The name of the cluster where the snapshot will be created in.
     * Values are of the form
     * `projects/{project}/instances/{instance}/clusters/{cluster}`.
     *
     * Generated from protobuf field <code>string cluster = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setCluster($var)
    {
        GPBUtil::checkString($var, True);
        $this->cluster = $var;

        return $this;
    }

    /**
     * Required. The ID by which the new snapshot should be referred to within the parent
     * cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
     * rather than
     * `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
     *
     * Generated from protobuf field <code>string snapshot_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getSnapshotId()
    {
        return $this->snapshot_id;
    }

    /**
     * Required. The ID by which the new snapshot should be referred to within the parent
     * cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
     * rather than
     * `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
     *
     * Generated from protobuf field <code>string snapshot_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setSnapshotId($var)
    {
        GPBUtil::checkString($var, True);
        $this->snapshot_id = $var;

        return $this;
    }

    /**
     * The amount of time that the new snapshot can stay active after it is
     * created. Once 'ttl' expires, the snapshot will get deleted. The maximum
     * amount of time a snapshot can stay active is 7 days. If 'ttl' is not
     * specified, the default value of 24 hours will be used.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration ttl = 4;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getTtl()
    {
        return isset($this->ttl) ? $this->ttl : null;
    }

    public function hasTtl()
    {
        return isset($this->ttl);
    }

    public function clearTtl()
    {
        unset($this->ttl);
    }

    /**
     * The amount of time that the new snapshot can stay active after it is
     * created. Once 'ttl' expires, the snapshot will get deleted. The maximum
     * amount of time a snapshot can stay active is 7 days. If 'ttl' is not
     * specified, the default value of 24 hours will be used.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration ttl = 4;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setTtl($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->ttl = $var;

        return $this;
    }

    /**
     * Description of the snapshot.
     *
     * Generated from protobuf field <code>string description = 5;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Description of the snapshot.
     *
     * Generated from protobuf field <code>string description = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

}

