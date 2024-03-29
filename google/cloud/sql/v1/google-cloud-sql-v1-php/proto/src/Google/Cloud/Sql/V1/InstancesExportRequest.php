<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/sql/v1/cloud_sql_instances.proto

namespace Google\Cloud\Sql\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Database instance export request.
 *
 * Generated from protobuf message <code>google.cloud.sql.v1.InstancesExportRequest</code>
 */
class InstancesExportRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Contains details about the export operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.ExportContext export_context = 1;</code>
     */
    protected $export_context = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Sql\V1\ExportContext $export_context
     *           Contains details about the export operation.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Sql\V1\CloudSqlInstances::initOnce();
        parent::__construct($data);
    }

    /**
     * Contains details about the export operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.ExportContext export_context = 1;</code>
     * @return \Google\Cloud\Sql\V1\ExportContext|null
     */
    public function getExportContext()
    {
        return $this->export_context;
    }

    public function hasExportContext()
    {
        return isset($this->export_context);
    }

    public function clearExportContext()
    {
        unset($this->export_context);
    }

    /**
     * Contains details about the export operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.ExportContext export_context = 1;</code>
     * @param \Google\Cloud\Sql\V1\ExportContext $var
     * @return $this
     */
    public function setExportContext($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Sql\V1\ExportContext::class);
        $this->export_context = $var;

        return $this;
    }

}

