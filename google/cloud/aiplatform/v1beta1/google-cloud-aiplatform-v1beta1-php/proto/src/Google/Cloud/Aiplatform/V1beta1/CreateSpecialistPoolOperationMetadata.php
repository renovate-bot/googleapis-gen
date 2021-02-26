<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/specialist_pool_service.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Runtime operation information for
 * [SpecialistPoolService.CreateSpecialistPool][google.cloud.aiplatform.v1beta1.SpecialistPoolService.CreateSpecialistPool].
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.CreateSpecialistPoolOperationMetadata</code>
 */
class CreateSpecialistPoolOperationMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * The operation generic information.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.GenericOperationMetadata generic_metadata = 1;</code>
     */
    protected $generic_metadata = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Aiplatform\V1beta1\GenericOperationMetadata $generic_metadata
     *           The operation generic information.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\SpecialistPoolService::initOnce();
        parent::__construct($data);
    }

    /**
     * The operation generic information.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.GenericOperationMetadata generic_metadata = 1;</code>
     * @return \Google\Cloud\Aiplatform\V1beta1\GenericOperationMetadata|null
     */
    public function getGenericMetadata()
    {
        return isset($this->generic_metadata) ? $this->generic_metadata : null;
    }

    public function hasGenericMetadata()
    {
        return isset($this->generic_metadata);
    }

    public function clearGenericMetadata()
    {
        unset($this->generic_metadata);
    }

    /**
     * The operation generic information.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.GenericOperationMetadata generic_metadata = 1;</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\GenericOperationMetadata $var
     * @return $this
     */
    public function setGenericMetadata($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Aiplatform\V1beta1\GenericOperationMetadata::class);
        $this->generic_metadata = $var;

        return $this;
    }

}

