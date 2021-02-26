<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1alpha2/storage.proto

namespace Google\Cloud\Bigquery\Storage\V1alpha2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response message for `AppendRows`.
 *
 * Generated from protobuf message <code>google.cloud.bigquery.storage.v1alpha2.AppendRowsResponse</code>
 */
class AppendRowsResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * If backend detects a schema update, pass it to user so that user can
     * use it to input new type of message. It will be empty when there is no
     * schema updates.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1alpha2.TableSchema updated_schema = 3;</code>
     */
    protected $updated_schema = null;
    protected $response;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int|string $offset
     *           The row offset at which the last append occurred.
     *     @type \Google\Rpc\Status $error
     *           Error in case of append failure. If set, it means rows are not accepted
     *           into the system. Users can retry within the same connection.
     *     @type \Google\Cloud\Bigquery\Storage\V1alpha2\TableSchema $updated_schema
     *           If backend detects a schema update, pass it to user so that user can
     *           use it to input new type of message. It will be empty when there is no
     *           schema updates.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Bigquery\Storage\V1Alpha2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * The row offset at which the last append occurred.
     *
     * Generated from protobuf field <code>int64 offset = 1;</code>
     * @return int|string
     */
    public function getOffset()
    {
        return $this->readOneof(1);
    }

    public function hasOffset()
    {
        return $this->hasOneof(1);
    }

    /**
     * The row offset at which the last append occurred.
     *
     * Generated from protobuf field <code>int64 offset = 1;</code>
     * @param int|string $var
     * @return $this
     */
    public function setOffset($var)
    {
        GPBUtil::checkInt64($var);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Error in case of append failure. If set, it means rows are not accepted
     * into the system. Users can retry within the same connection.
     *
     * Generated from protobuf field <code>.google.rpc.Status error = 2;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getError()
    {
        return $this->readOneof(2);
    }

    public function hasError()
    {
        return $this->hasOneof(2);
    }

    /**
     * Error in case of append failure. If set, it means rows are not accepted
     * into the system. Users can retry within the same connection.
     *
     * Generated from protobuf field <code>.google.rpc.Status error = 2;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setError($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * If backend detects a schema update, pass it to user so that user can
     * use it to input new type of message. It will be empty when there is no
     * schema updates.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1alpha2.TableSchema updated_schema = 3;</code>
     * @return \Google\Cloud\Bigquery\Storage\V1alpha2\TableSchema|null
     */
    public function getUpdatedSchema()
    {
        return isset($this->updated_schema) ? $this->updated_schema : null;
    }

    public function hasUpdatedSchema()
    {
        return isset($this->updated_schema);
    }

    public function clearUpdatedSchema()
    {
        unset($this->updated_schema);
    }

    /**
     * If backend detects a schema update, pass it to user so that user can
     * use it to input new type of message. It will be empty when there is no
     * schema updates.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1alpha2.TableSchema updated_schema = 3;</code>
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\TableSchema $var
     * @return $this
     */
    public function setUpdatedSchema($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Bigquery\Storage\V1alpha2\TableSchema::class);
        $this->updated_schema = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getResponse()
    {
        return $this->whichOneof("response");
    }

}

