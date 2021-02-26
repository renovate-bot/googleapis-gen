<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p7beta1/asset_service.proto

namespace Google\Cloud\Asset\V1p7beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A BigQuery destination for exporting assets to.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1p7beta1.BigQueryDestination</code>
 */
class BigQueryDestination extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The BigQuery dataset in format
     * "projects/projectId/datasets/datasetId", to which the snapshot result
     * should be exported. If this dataset does not exist, the export call returns
     * an INVALID_ARGUMENT error.
     *
     * Generated from protobuf field <code>string dataset = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $dataset = '';
    /**
     * Required. The BigQuery table to which the snapshot result should be
     * written. If this table does not exist, a new table with the given name
     * will be created.
     *
     * Generated from protobuf field <code>string table = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $table = '';
    /**
     * If the destination table already exists and this flag is `TRUE`, the
     * table will be overwritten by the contents of assets snapshot. If the flag
     * is `FALSE` or unset and the destination table already exists, the export
     * call returns an INVALID_ARGUMEMT error.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     */
    protected $force = false;
    /**
     * [partition_spec] determines whether to export to partitioned table(s) and
     * how to partition the data.
     * If [partition_spec] is unset or [partition_spec.partition_key] is unset or
     * `PARTITION_KEY_UNSPECIFIED`, the snapshot results will be exported to
     * non-partitioned table(s). [force] will decide whether to overwrite existing
     * table(s).
     * If [partition_spec] is specified. First, the snapshot results will be
     * written to partitioned table(s) with two additional timestamp columns,
     * readTime and requestTime, one of which will be the partition key. Secondly,
     * in the case when any destination table already exists, it will first try to
     * update existing table's schema as necessary by appending additional
     * columns. Then, if [force] is `TRUE`, the corresponding partition will be
     * overwritten by the snapshot results (data in different partitions will
     * remain intact); if [force] is unset or `FALSE`, it will append the data. An
     * error will be returned if the schema update or data appension fails.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.PartitionSpec partition_spec = 4;</code>
     */
    protected $partition_spec = null;
    /**
     * If this flag is `TRUE`, the snapshot results will be written to one or
     * multiple tables, each of which contains results of one asset type. The
     * [force] and [partition_spec] fields will apply to each of them.
     * Field [table] will be concatenated with "_" and the asset type names (see
     * https://cloud.google.com/asset-inventory/docs/supported-asset-types for
     * supported asset types) to construct per-asset-type table names, in which
     * all non-alphanumeric characters like "." and "/" will be substituted by
     * "_". Example: if field [table] is "mytable" and snapshot results
     * contain "storage.googleapis.com/Bucket" assets, the corresponding table
     * name will be "mytable_storage_googleapis_com_Bucket". If any of these
     * tables does not exist, a new table with the concatenated name will be
     * created.
     * When [content_type] in the ExportAssetsRequest is `RESOURCE`, the schema of
     * each table will include RECORD-type columns mapped to the nested fields in
     * the Asset.resource.data field of that asset type (up to the 15 nested level
     * BigQuery supports
     * (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The
     * fields in >15 nested levels will be stored in JSON format string as a child
     * column of its parent RECORD column.
     * If error occurs when exporting to any table, the whole export call will
     * return an error but the export results that already succeed will persist.
     * Example: if exporting to table_type_A succeeds when exporting to
     * table_type_B fails during one export call, the results in table_type_A will
     * persist and there will not be partial results persisting in a table.
     *
     * Generated from protobuf field <code>bool separate_tables_per_asset_type = 5;</code>
     */
    protected $separate_tables_per_asset_type = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $dataset
     *           Required. The BigQuery dataset in format
     *           "projects/projectId/datasets/datasetId", to which the snapshot result
     *           should be exported. If this dataset does not exist, the export call returns
     *           an INVALID_ARGUMENT error.
     *     @type string $table
     *           Required. The BigQuery table to which the snapshot result should be
     *           written. If this table does not exist, a new table with the given name
     *           will be created.
     *     @type bool $force
     *           If the destination table already exists and this flag is `TRUE`, the
     *           table will be overwritten by the contents of assets snapshot. If the flag
     *           is `FALSE` or unset and the destination table already exists, the export
     *           call returns an INVALID_ARGUMEMT error.
     *     @type \Google\Cloud\Asset\V1p7beta1\PartitionSpec $partition_spec
     *           [partition_spec] determines whether to export to partitioned table(s) and
     *           how to partition the data.
     *           If [partition_spec] is unset or [partition_spec.partition_key] is unset or
     *           `PARTITION_KEY_UNSPECIFIED`, the snapshot results will be exported to
     *           non-partitioned table(s). [force] will decide whether to overwrite existing
     *           table(s).
     *           If [partition_spec] is specified. First, the snapshot results will be
     *           written to partitioned table(s) with two additional timestamp columns,
     *           readTime and requestTime, one of which will be the partition key. Secondly,
     *           in the case when any destination table already exists, it will first try to
     *           update existing table's schema as necessary by appending additional
     *           columns. Then, if [force] is `TRUE`, the corresponding partition will be
     *           overwritten by the snapshot results (data in different partitions will
     *           remain intact); if [force] is unset or `FALSE`, it will append the data. An
     *           error will be returned if the schema update or data appension fails.
     *     @type bool $separate_tables_per_asset_type
     *           If this flag is `TRUE`, the snapshot results will be written to one or
     *           multiple tables, each of which contains results of one asset type. The
     *           [force] and [partition_spec] fields will apply to each of them.
     *           Field [table] will be concatenated with "_" and the asset type names (see
     *           https://cloud.google.com/asset-inventory/docs/supported-asset-types for
     *           supported asset types) to construct per-asset-type table names, in which
     *           all non-alphanumeric characters like "." and "/" will be substituted by
     *           "_". Example: if field [table] is "mytable" and snapshot results
     *           contain "storage.googleapis.com/Bucket" assets, the corresponding table
     *           name will be "mytable_storage_googleapis_com_Bucket". If any of these
     *           tables does not exist, a new table with the concatenated name will be
     *           created.
     *           When [content_type] in the ExportAssetsRequest is `RESOURCE`, the schema of
     *           each table will include RECORD-type columns mapped to the nested fields in
     *           the Asset.resource.data field of that asset type (up to the 15 nested level
     *           BigQuery supports
     *           (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The
     *           fields in >15 nested levels will be stored in JSON format string as a child
     *           column of its parent RECORD column.
     *           If error occurs when exporting to any table, the whole export call will
     *           return an error but the export results that already succeed will persist.
     *           Example: if exporting to table_type_A succeeds when exporting to
     *           table_type_B fails during one export call, the results in table_type_A will
     *           persist and there will not be partial results persisting in a table.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1P7Beta1\AssetService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The BigQuery dataset in format
     * "projects/projectId/datasets/datasetId", to which the snapshot result
     * should be exported. If this dataset does not exist, the export call returns
     * an INVALID_ARGUMENT error.
     *
     * Generated from protobuf field <code>string dataset = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDataset()
    {
        return $this->dataset;
    }

    /**
     * Required. The BigQuery dataset in format
     * "projects/projectId/datasets/datasetId", to which the snapshot result
     * should be exported. If this dataset does not exist, the export call returns
     * an INVALID_ARGUMENT error.
     *
     * Generated from protobuf field <code>string dataset = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setDataset($var)
    {
        GPBUtil::checkString($var, True);
        $this->dataset = $var;

        return $this;
    }

    /**
     * Required. The BigQuery table to which the snapshot result should be
     * written. If this table does not exist, a new table with the given name
     * will be created.
     *
     * Generated from protobuf field <code>string table = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getTable()
    {
        return $this->table;
    }

    /**
     * Required. The BigQuery table to which the snapshot result should be
     * written. If this table does not exist, a new table with the given name
     * will be created.
     *
     * Generated from protobuf field <code>string table = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setTable($var)
    {
        GPBUtil::checkString($var, True);
        $this->table = $var;

        return $this;
    }

    /**
     * If the destination table already exists and this flag is `TRUE`, the
     * table will be overwritten by the contents of assets snapshot. If the flag
     * is `FALSE` or unset and the destination table already exists, the export
     * call returns an INVALID_ARGUMEMT error.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     * @return bool
     */
    public function getForce()
    {
        return $this->force;
    }

    /**
     * If the destination table already exists and this flag is `TRUE`, the
     * table will be overwritten by the contents of assets snapshot. If the flag
     * is `FALSE` or unset and the destination table already exists, the export
     * call returns an INVALID_ARGUMEMT error.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setForce($var)
    {
        GPBUtil::checkBool($var);
        $this->force = $var;

        return $this;
    }

    /**
     * [partition_spec] determines whether to export to partitioned table(s) and
     * how to partition the data.
     * If [partition_spec] is unset or [partition_spec.partition_key] is unset or
     * `PARTITION_KEY_UNSPECIFIED`, the snapshot results will be exported to
     * non-partitioned table(s). [force] will decide whether to overwrite existing
     * table(s).
     * If [partition_spec] is specified. First, the snapshot results will be
     * written to partitioned table(s) with two additional timestamp columns,
     * readTime and requestTime, one of which will be the partition key. Secondly,
     * in the case when any destination table already exists, it will first try to
     * update existing table's schema as necessary by appending additional
     * columns. Then, if [force] is `TRUE`, the corresponding partition will be
     * overwritten by the snapshot results (data in different partitions will
     * remain intact); if [force] is unset or `FALSE`, it will append the data. An
     * error will be returned if the schema update or data appension fails.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.PartitionSpec partition_spec = 4;</code>
     * @return \Google\Cloud\Asset\V1p7beta1\PartitionSpec|null
     */
    public function getPartitionSpec()
    {
        return isset($this->partition_spec) ? $this->partition_spec : null;
    }

    public function hasPartitionSpec()
    {
        return isset($this->partition_spec);
    }

    public function clearPartitionSpec()
    {
        unset($this->partition_spec);
    }

    /**
     * [partition_spec] determines whether to export to partitioned table(s) and
     * how to partition the data.
     * If [partition_spec] is unset or [partition_spec.partition_key] is unset or
     * `PARTITION_KEY_UNSPECIFIED`, the snapshot results will be exported to
     * non-partitioned table(s). [force] will decide whether to overwrite existing
     * table(s).
     * If [partition_spec] is specified. First, the snapshot results will be
     * written to partitioned table(s) with two additional timestamp columns,
     * readTime and requestTime, one of which will be the partition key. Secondly,
     * in the case when any destination table already exists, it will first try to
     * update existing table's schema as necessary by appending additional
     * columns. Then, if [force] is `TRUE`, the corresponding partition will be
     * overwritten by the snapshot results (data in different partitions will
     * remain intact); if [force] is unset or `FALSE`, it will append the data. An
     * error will be returned if the schema update or data appension fails.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.PartitionSpec partition_spec = 4;</code>
     * @param \Google\Cloud\Asset\V1p7beta1\PartitionSpec $var
     * @return $this
     */
    public function setPartitionSpec($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p7beta1\PartitionSpec::class);
        $this->partition_spec = $var;

        return $this;
    }

    /**
     * If this flag is `TRUE`, the snapshot results will be written to one or
     * multiple tables, each of which contains results of one asset type. The
     * [force] and [partition_spec] fields will apply to each of them.
     * Field [table] will be concatenated with "_" and the asset type names (see
     * https://cloud.google.com/asset-inventory/docs/supported-asset-types for
     * supported asset types) to construct per-asset-type table names, in which
     * all non-alphanumeric characters like "." and "/" will be substituted by
     * "_". Example: if field [table] is "mytable" and snapshot results
     * contain "storage.googleapis.com/Bucket" assets, the corresponding table
     * name will be "mytable_storage_googleapis_com_Bucket". If any of these
     * tables does not exist, a new table with the concatenated name will be
     * created.
     * When [content_type] in the ExportAssetsRequest is `RESOURCE`, the schema of
     * each table will include RECORD-type columns mapped to the nested fields in
     * the Asset.resource.data field of that asset type (up to the 15 nested level
     * BigQuery supports
     * (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The
     * fields in >15 nested levels will be stored in JSON format string as a child
     * column of its parent RECORD column.
     * If error occurs when exporting to any table, the whole export call will
     * return an error but the export results that already succeed will persist.
     * Example: if exporting to table_type_A succeeds when exporting to
     * table_type_B fails during one export call, the results in table_type_A will
     * persist and there will not be partial results persisting in a table.
     *
     * Generated from protobuf field <code>bool separate_tables_per_asset_type = 5;</code>
     * @return bool
     */
    public function getSeparateTablesPerAssetType()
    {
        return $this->separate_tables_per_asset_type;
    }

    /**
     * If this flag is `TRUE`, the snapshot results will be written to one or
     * multiple tables, each of which contains results of one asset type. The
     * [force] and [partition_spec] fields will apply to each of them.
     * Field [table] will be concatenated with "_" and the asset type names (see
     * https://cloud.google.com/asset-inventory/docs/supported-asset-types for
     * supported asset types) to construct per-asset-type table names, in which
     * all non-alphanumeric characters like "." and "/" will be substituted by
     * "_". Example: if field [table] is "mytable" and snapshot results
     * contain "storage.googleapis.com/Bucket" assets, the corresponding table
     * name will be "mytable_storage_googleapis_com_Bucket". If any of these
     * tables does not exist, a new table with the concatenated name will be
     * created.
     * When [content_type] in the ExportAssetsRequest is `RESOURCE`, the schema of
     * each table will include RECORD-type columns mapped to the nested fields in
     * the Asset.resource.data field of that asset type (up to the 15 nested level
     * BigQuery supports
     * (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The
     * fields in >15 nested levels will be stored in JSON format string as a child
     * column of its parent RECORD column.
     * If error occurs when exporting to any table, the whole export call will
     * return an error but the export results that already succeed will persist.
     * Example: if exporting to table_type_A succeeds when exporting to
     * table_type_B fails during one export call, the results in table_type_A will
     * persist and there will not be partial results persisting in a table.
     *
     * Generated from protobuf field <code>bool separate_tables_per_asset_type = 5;</code>
     * @param bool $var
     * @return $this
     */
    public function setSeparateTablesPerAssetType($var)
    {
        GPBUtil::checkBool($var);
        $this->separate_tables_per_asset_type = $var;

        return $this;
    }

}

