<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1beta1/storage.proto

namespace Google\Cloud\Bigquery\Storage\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Creates a new read session, which may include additional options such as
 * requested parallelism, projection filters and constraints.
 *
 * Generated from protobuf message <code>google.cloud.bigquery.storage.v1beta1.CreateReadSessionRequest</code>
 */
class CreateReadSessionRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Reference to the table to read.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReference table_reference = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $table_reference = null;
    /**
     * Required. String of the form `projects/{project_id}` indicating the
     * project this ReadSession is associated with. This is the project that will
     * be billed for usage.
     *
     * Generated from protobuf field <code>string parent = 6 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Any modifiers to the Table (e.g. snapshot timestamp).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableModifiers table_modifiers = 2;</code>
     */
    protected $table_modifiers = null;
    /**
     * Initial number of streams. If unset or 0, we will
     * provide a value of streams so as to produce reasonable throughput. Must be
     * non-negative. The number of streams may be lower than the requested number,
     * depending on the amount parallelism that is reasonable for the table and
     * the maximum amount of parallelism allowed by the system.
     * Streams must be read starting from offset 0.
     *
     * Generated from protobuf field <code>int32 requested_streams = 3;</code>
     */
    protected $requested_streams = 0;
    /**
     * Read options for this session (e.g. column selection, filters).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReadOptions read_options = 4;</code>
     */
    protected $read_options = null;
    /**
     * Data output format. Currently default to Avro.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.DataFormat format = 5;</code>
     */
    protected $format = 0;
    /**
     * The strategy to use for distributing data among multiple streams. Currently
     * defaults to liquid sharding.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.ShardingStrategy sharding_strategy = 7;</code>
     */
    protected $sharding_strategy = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Bigquery\Storage\V1beta1\TableReference $table_reference
     *           Required. Reference to the table to read.
     *     @type string $parent
     *           Required. String of the form `projects/{project_id}` indicating the
     *           project this ReadSession is associated with. This is the project that will
     *           be billed for usage.
     *     @type \Google\Cloud\Bigquery\Storage\V1beta1\TableModifiers $table_modifiers
     *           Any modifiers to the Table (e.g. snapshot timestamp).
     *     @type int $requested_streams
     *           Initial number of streams. If unset or 0, we will
     *           provide a value of streams so as to produce reasonable throughput. Must be
     *           non-negative. The number of streams may be lower than the requested number,
     *           depending on the amount parallelism that is reasonable for the table and
     *           the maximum amount of parallelism allowed by the system.
     *           Streams must be read starting from offset 0.
     *     @type \Google\Cloud\Bigquery\Storage\V1beta1\TableReadOptions $read_options
     *           Read options for this session (e.g. column selection, filters).
     *     @type int $format
     *           Data output format. Currently default to Avro.
     *     @type int $sharding_strategy
     *           The strategy to use for distributing data among multiple streams. Currently
     *           defaults to liquid sharding.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Bigquery\Storage\V1Beta1\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Reference to the table to read.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReference table_reference = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\TableReference|null
     */
    public function getTableReference()
    {
        return isset($this->table_reference) ? $this->table_reference : null;
    }

    public function hasTableReference()
    {
        return isset($this->table_reference);
    }

    public function clearTableReference()
    {
        unset($this->table_reference);
    }

    /**
     * Required. Reference to the table to read.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReference table_reference = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Bigquery\Storage\V1beta1\TableReference $var
     * @return $this
     */
    public function setTableReference($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Bigquery\Storage\V1beta1\TableReference::class);
        $this->table_reference = $var;

        return $this;
    }

    /**
     * Required. String of the form `projects/{project_id}` indicating the
     * project this ReadSession is associated with. This is the project that will
     * be billed for usage.
     *
     * Generated from protobuf field <code>string parent = 6 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. String of the form `projects/{project_id}` indicating the
     * project this ReadSession is associated with. This is the project that will
     * be billed for usage.
     *
     * Generated from protobuf field <code>string parent = 6 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Any modifiers to the Table (e.g. snapshot timestamp).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableModifiers table_modifiers = 2;</code>
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\TableModifiers|null
     */
    public function getTableModifiers()
    {
        return isset($this->table_modifiers) ? $this->table_modifiers : null;
    }

    public function hasTableModifiers()
    {
        return isset($this->table_modifiers);
    }

    public function clearTableModifiers()
    {
        unset($this->table_modifiers);
    }

    /**
     * Any modifiers to the Table (e.g. snapshot timestamp).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableModifiers table_modifiers = 2;</code>
     * @param \Google\Cloud\Bigquery\Storage\V1beta1\TableModifiers $var
     * @return $this
     */
    public function setTableModifiers($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Bigquery\Storage\V1beta1\TableModifiers::class);
        $this->table_modifiers = $var;

        return $this;
    }

    /**
     * Initial number of streams. If unset or 0, we will
     * provide a value of streams so as to produce reasonable throughput. Must be
     * non-negative. The number of streams may be lower than the requested number,
     * depending on the amount parallelism that is reasonable for the table and
     * the maximum amount of parallelism allowed by the system.
     * Streams must be read starting from offset 0.
     *
     * Generated from protobuf field <code>int32 requested_streams = 3;</code>
     * @return int
     */
    public function getRequestedStreams()
    {
        return $this->requested_streams;
    }

    /**
     * Initial number of streams. If unset or 0, we will
     * provide a value of streams so as to produce reasonable throughput. Must be
     * non-negative. The number of streams may be lower than the requested number,
     * depending on the amount parallelism that is reasonable for the table and
     * the maximum amount of parallelism allowed by the system.
     * Streams must be read starting from offset 0.
     *
     * Generated from protobuf field <code>int32 requested_streams = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setRequestedStreams($var)
    {
        GPBUtil::checkInt32($var);
        $this->requested_streams = $var;

        return $this;
    }

    /**
     * Read options for this session (e.g. column selection, filters).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReadOptions read_options = 4;</code>
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\TableReadOptions|null
     */
    public function getReadOptions()
    {
        return isset($this->read_options) ? $this->read_options : null;
    }

    public function hasReadOptions()
    {
        return isset($this->read_options);
    }

    public function clearReadOptions()
    {
        unset($this->read_options);
    }

    /**
     * Read options for this session (e.g. column selection, filters).
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.TableReadOptions read_options = 4;</code>
     * @param \Google\Cloud\Bigquery\Storage\V1beta1\TableReadOptions $var
     * @return $this
     */
    public function setReadOptions($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Bigquery\Storage\V1beta1\TableReadOptions::class);
        $this->read_options = $var;

        return $this;
    }

    /**
     * Data output format. Currently default to Avro.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.DataFormat format = 5;</code>
     * @return int
     */
    public function getFormat()
    {
        return $this->format;
    }

    /**
     * Data output format. Currently default to Avro.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.DataFormat format = 5;</code>
     * @param int $var
     * @return $this
     */
    public function setFormat($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Bigquery\Storage\V1beta1\DataFormat::class);
        $this->format = $var;

        return $this;
    }

    /**
     * The strategy to use for distributing data among multiple streams. Currently
     * defaults to liquid sharding.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.ShardingStrategy sharding_strategy = 7;</code>
     * @return int
     */
    public function getShardingStrategy()
    {
        return $this->sharding_strategy;
    }

    /**
     * The strategy to use for distributing data among multiple streams. Currently
     * defaults to liquid sharding.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.storage.v1beta1.ShardingStrategy sharding_strategy = 7;</code>
     * @param int $var
     * @return $this
     */
    public function setShardingStrategy($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Bigquery\Storage\V1beta1\ShardingStrategy::class);
        $this->sharding_strategy = $var;

        return $this;
    }

}

