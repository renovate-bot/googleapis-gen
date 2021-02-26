<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/batch_job_service.proto

namespace Google\Ads\GoogleAds\V6\Services;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A single operation on a batch job.
 *
 * Generated from protobuf message <code>google.ads.googleads.v6.services.BatchJobOperation</code>
 */
class BatchJobOperation extends \Google\Protobuf\Internal\Message
{
    protected $operation;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Ads\GoogleAds\V6\Resources\BatchJob $create
     *           Create operation: No resource name is expected for the new batch job.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V6\Services\BatchJobService::initOnce();
        parent::__construct($data);
    }

    /**
     * Create operation: No resource name is expected for the new batch job.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.BatchJob create = 1;</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\BatchJob|null
     */
    public function getCreate()
    {
        return $this->readOneof(1);
    }

    public function hasCreate()
    {
        return $this->hasOneof(1);
    }

    /**
     * Create operation: No resource name is expected for the new batch job.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.BatchJob create = 1;</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\BatchJob $var
     * @return $this
     */
    public function setCreate($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\BatchJob::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getOperation()
    {
        return $this->whichOneof("operation");
    }

}

