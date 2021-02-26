<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/privacy/dlp/v2/storage.proto

namespace Google\Cloud\Dlp\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Message defining a field of a BigQuery table.
 *
 * Generated from protobuf message <code>google.privacy.dlp.v2.BigQueryField</code>
 */
class BigQueryField extends \Google\Protobuf\Internal\Message
{
    /**
     * Source table of the field.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.BigQueryTable table = 1;</code>
     */
    protected $table = null;
    /**
     * Designated field in the BigQuery table.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.FieldId field = 2;</code>
     */
    protected $field = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dlp\V2\BigQueryTable $table
     *           Source table of the field.
     *     @type \Google\Cloud\Dlp\V2\FieldId $field
     *           Designated field in the BigQuery table.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Privacy\Dlp\V2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * Source table of the field.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.BigQueryTable table = 1;</code>
     * @return \Google\Cloud\Dlp\V2\BigQueryTable|null
     */
    public function getTable()
    {
        return isset($this->table) ? $this->table : null;
    }

    public function hasTable()
    {
        return isset($this->table);
    }

    public function clearTable()
    {
        unset($this->table);
    }

    /**
     * Source table of the field.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.BigQueryTable table = 1;</code>
     * @param \Google\Cloud\Dlp\V2\BigQueryTable $var
     * @return $this
     */
    public function setTable($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dlp\V2\BigQueryTable::class);
        $this->table = $var;

        return $this;
    }

    /**
     * Designated field in the BigQuery table.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.FieldId field = 2;</code>
     * @return \Google\Cloud\Dlp\V2\FieldId|null
     */
    public function getField()
    {
        return isset($this->field) ? $this->field : null;
    }

    public function hasField()
    {
        return isset($this->field);
    }

    public function clearField()
    {
        unset($this->field);
    }

    /**
     * Designated field in the BigQuery table.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.FieldId field = 2;</code>
     * @param \Google\Cloud\Dlp\V2\FieldId $var
     * @return $this
     */
    public function setField($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dlp\V2\FieldId::class);
        $this->field = $var;

        return $this;
    }

}

