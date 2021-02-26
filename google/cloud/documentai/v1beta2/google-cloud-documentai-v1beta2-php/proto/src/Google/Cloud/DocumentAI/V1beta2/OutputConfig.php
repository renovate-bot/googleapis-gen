<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta2/document_understanding.proto

namespace Google\Cloud\DocumentAI\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The desired output location and metadata.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta2.OutputConfig</code>
 */
class OutputConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * The max number of pages to include into each output Document shard JSON on
     * Google Cloud Storage.
     * The valid range is [1, 100]. If not specified, the default value is 20.
     * For example, for one pdf file with 100 pages, 100 parsed pages will be
     * produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
     * containing 20 parsed pages will be written under the prefix
     * [OutputConfig.gcs_destination.uri][] and suffix pages-x-to-y.json where
     * x and y are 1-indexed page numbers.
     * Example GCS outputs with 157 pages and pages_per_shard = 50:
     * <prefix>pages-001-to-050.json
     * <prefix>pages-051-to-100.json
     * <prefix>pages-101-to-150.json
     * <prefix>pages-151-to-157.json
     *
     * Generated from protobuf field <code>int32 pages_per_shard = 2;</code>
     */
    protected $pages_per_shard = 0;
    protected $destination;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DocumentAI\V1beta2\GcsDestination $gcs_destination
     *           The Google Cloud Storage location to write the output to.
     *     @type int $pages_per_shard
     *           The max number of pages to include into each output Document shard JSON on
     *           Google Cloud Storage.
     *           The valid range is [1, 100]. If not specified, the default value is 20.
     *           For example, for one pdf file with 100 pages, 100 parsed pages will be
     *           produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
     *           containing 20 parsed pages will be written under the prefix
     *           [OutputConfig.gcs_destination.uri][] and suffix pages-x-to-y.json where
     *           x and y are 1-indexed page numbers.
     *           Example GCS outputs with 157 pages and pages_per_shard = 50:
     *           <prefix>pages-001-to-050.json
     *           <prefix>pages-051-to-100.json
     *           <prefix>pages-101-to-150.json
     *           <prefix>pages-151-to-157.json
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta2\DocumentUnderstanding::initOnce();
        parent::__construct($data);
    }

    /**
     * The Google Cloud Storage location to write the output to.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta2.GcsDestination gcs_destination = 1;</code>
     * @return \Google\Cloud\DocumentAI\V1beta2\GcsDestination|null
     */
    public function getGcsDestination()
    {
        return $this->readOneof(1);
    }

    public function hasGcsDestination()
    {
        return $this->hasOneof(1);
    }

    /**
     * The Google Cloud Storage location to write the output to.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta2.GcsDestination gcs_destination = 1;</code>
     * @param \Google\Cloud\DocumentAI\V1beta2\GcsDestination $var
     * @return $this
     */
    public function setGcsDestination($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta2\GcsDestination::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The max number of pages to include into each output Document shard JSON on
     * Google Cloud Storage.
     * The valid range is [1, 100]. If not specified, the default value is 20.
     * For example, for one pdf file with 100 pages, 100 parsed pages will be
     * produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
     * containing 20 parsed pages will be written under the prefix
     * [OutputConfig.gcs_destination.uri][] and suffix pages-x-to-y.json where
     * x and y are 1-indexed page numbers.
     * Example GCS outputs with 157 pages and pages_per_shard = 50:
     * <prefix>pages-001-to-050.json
     * <prefix>pages-051-to-100.json
     * <prefix>pages-101-to-150.json
     * <prefix>pages-151-to-157.json
     *
     * Generated from protobuf field <code>int32 pages_per_shard = 2;</code>
     * @return int
     */
    public function getPagesPerShard()
    {
        return $this->pages_per_shard;
    }

    /**
     * The max number of pages to include into each output Document shard JSON on
     * Google Cloud Storage.
     * The valid range is [1, 100]. If not specified, the default value is 20.
     * For example, for one pdf file with 100 pages, 100 parsed pages will be
     * produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
     * containing 20 parsed pages will be written under the prefix
     * [OutputConfig.gcs_destination.uri][] and suffix pages-x-to-y.json where
     * x and y are 1-indexed page numbers.
     * Example GCS outputs with 157 pages and pages_per_shard = 50:
     * <prefix>pages-001-to-050.json
     * <prefix>pages-051-to-100.json
     * <prefix>pages-101-to-150.json
     * <prefix>pages-151-to-157.json
     *
     * Generated from protobuf field <code>int32 pages_per_shard = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setPagesPerShard($var)
    {
        GPBUtil::checkInt32($var);
        $this->pages_per_shard = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getDestination()
    {
        return $this->whichOneof("destination");
    }

}

