<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p7beta1/asset_service.proto

namespace Google\Cloud\Asset\V1p7beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Output configuration for export assets destination.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1p7beta1.OutputConfig</code>
 */
class OutputConfig extends \Google\Protobuf\Internal\Message
{
    protected $destination;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Asset\V1p7beta1\GcsDestination $gcs_destination
     *           Destination on Cloud Storage.
     *     @type \Google\Cloud\Asset\V1p7beta1\BigQueryDestination $bigquery_destination
     *           Destination on BigQuery. The output table stores the fields in asset
     *           proto as columns in BigQuery.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1P7Beta1\AssetService::initOnce();
        parent::__construct($data);
    }

    /**
     * Destination on Cloud Storage.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.GcsDestination gcs_destination = 1;</code>
     * @return \Google\Cloud\Asset\V1p7beta1\GcsDestination
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
     * Destination on Cloud Storage.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.GcsDestination gcs_destination = 1;</code>
     * @param \Google\Cloud\Asset\V1p7beta1\GcsDestination $var
     * @return $this
     */
    public function setGcsDestination($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p7beta1\GcsDestination::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Destination on BigQuery. The output table stores the fields in asset
     * proto as columns in BigQuery.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.BigQueryDestination bigquery_destination = 2;</code>
     * @return \Google\Cloud\Asset\V1p7beta1\BigQueryDestination
     */
    public function getBigqueryDestination()
    {
        return $this->readOneof(2);
    }

    public function hasBigqueryDestination()
    {
        return $this->hasOneof(2);
    }

    /**
     * Destination on BigQuery. The output table stores the fields in asset
     * proto as columns in BigQuery.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p7beta1.BigQueryDestination bigquery_destination = 2;</code>
     * @param \Google\Cloud\Asset\V1p7beta1\BigQueryDestination $var
     * @return $this
     */
    public function setBigqueryDestination($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p7beta1\BigQueryDestination::class);
        $this->writeOneof(2, $var);

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

