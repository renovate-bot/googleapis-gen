<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/servicedirectory/v1/lookup_service.proto

namespace Google\Cloud\ServiceDirectory\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The response message for
 * [LookupService.ResolveService][google.cloud.servicedirectory.v1.LookupService.ResolveService].
 *
 * Generated from protobuf message <code>google.cloud.servicedirectory.v1.ResolveServiceResponse</code>
 */
class ResolveServiceResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>.google.cloud.servicedirectory.v1.Service service = 1;</code>
     */
    protected $service = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\ServiceDirectory\V1\Service $service
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Servicedirectory\V1\LookupService::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>.google.cloud.servicedirectory.v1.Service service = 1;</code>
     * @return \Google\Cloud\ServiceDirectory\V1\Service|null
     */
    public function getService()
    {
        return isset($this->service) ? $this->service : null;
    }

    public function hasService()
    {
        return isset($this->service);
    }

    public function clearService()
    {
        unset($this->service);
    }

    /**
     * Generated from protobuf field <code>.google.cloud.servicedirectory.v1.Service service = 1;</code>
     * @param \Google\Cloud\ServiceDirectory\V1\Service $var
     * @return $this
     */
    public function setService($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ServiceDirectory\V1\Service::class);
        $this->service = $var;

        return $this;
    }

}

