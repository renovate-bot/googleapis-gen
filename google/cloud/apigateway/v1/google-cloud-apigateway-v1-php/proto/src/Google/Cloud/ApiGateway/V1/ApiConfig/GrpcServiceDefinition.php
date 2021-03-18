<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/apigateway/v1/apigateway.proto

namespace Google\Cloud\ApiGateway\V1\ApiConfig;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A gRPC service definition.
 *
 * Generated from protobuf message <code>google.cloud.apigateway.v1.ApiConfig.GrpcServiceDefinition</code>
 */
class GrpcServiceDefinition extends \Google\Protobuf\Internal\Message
{
    /**
     * Input only. File descriptor set, generated by protoc.
     * To generate, use protoc with imports and source info included.
     * For an example test.proto file, the following command would put the value
     * in a new file named out.pb.
     * $ protoc --include_imports --include_source_info test.proto -o out.pb
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig.File file_descriptor_set = 1 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     */
    protected $file_descriptor_set = null;
    /**
     * Optional. Uncompiled proto files associated with the descriptor set, used for
     * display purposes (server-side compilation is not supported). These
     * should match the inputs to 'protoc' command used to generate
     * file_descriptor_set.
     *
     * Generated from protobuf field <code>repeated .google.cloud.apigateway.v1.ApiConfig.File source = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\ApiGateway\V1\ApiConfig\File $file_descriptor_set
     *           Input only. File descriptor set, generated by protoc.
     *           To generate, use protoc with imports and source info included.
     *           For an example test.proto file, the following command would put the value
     *           in a new file named out.pb.
     *           $ protoc --include_imports --include_source_info test.proto -o out.pb
     *     @type \Google\Cloud\ApiGateway\V1\ApiConfig\File[]|\Google\Protobuf\Internal\RepeatedField $source
     *           Optional. Uncompiled proto files associated with the descriptor set, used for
     *           display purposes (server-side compilation is not supported). These
     *           should match the inputs to 'protoc' command used to generate
     *           file_descriptor_set.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Apigateway\V1\Apigateway::initOnce();
        parent::__construct($data);
    }

    /**
     * Input only. File descriptor set, generated by protoc.
     * To generate, use protoc with imports and source info included.
     * For an example test.proto file, the following command would put the value
     * in a new file named out.pb.
     * $ protoc --include_imports --include_source_info test.proto -o out.pb
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig.File file_descriptor_set = 1 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     * @return \Google\Cloud\ApiGateway\V1\ApiConfig\File|null
     */
    public function getFileDescriptorSet()
    {
        return isset($this->file_descriptor_set) ? $this->file_descriptor_set : null;
    }

    public function hasFileDescriptorSet()
    {
        return isset($this->file_descriptor_set);
    }

    public function clearFileDescriptorSet()
    {
        unset($this->file_descriptor_set);
    }

    /**
     * Input only. File descriptor set, generated by protoc.
     * To generate, use protoc with imports and source info included.
     * For an example test.proto file, the following command would put the value
     * in a new file named out.pb.
     * $ protoc --include_imports --include_source_info test.proto -o out.pb
     *
     * Generated from protobuf field <code>.google.cloud.apigateway.v1.ApiConfig.File file_descriptor_set = 1 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     * @param \Google\Cloud\ApiGateway\V1\ApiConfig\File $var
     * @return $this
     */
    public function setFileDescriptorSet($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ApiGateway\V1\ApiConfig\File::class);
        $this->file_descriptor_set = $var;

        return $this;
    }

    /**
     * Optional. Uncompiled proto files associated with the descriptor set, used for
     * display purposes (server-side compilation is not supported). These
     * should match the inputs to 'protoc' command used to generate
     * file_descriptor_set.
     *
     * Generated from protobuf field <code>repeated .google.cloud.apigateway.v1.ApiConfig.File source = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getSource()
    {
        return $this->source;
    }

    /**
     * Optional. Uncompiled proto files associated with the descriptor set, used for
     * display purposes (server-side compilation is not supported). These
     * should match the inputs to 'protoc' command used to generate
     * file_descriptor_set.
     *
     * Generated from protobuf field <code>repeated .google.cloud.apigateway.v1.ApiConfig.File source = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\ApiGateway\V1\ApiConfig\File[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setSource($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\ApiGateway\V1\ApiConfig\File::class);
        $this->source = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(GrpcServiceDefinition::class, \Google\Cloud\ApiGateway\V1\ApiConfig_GrpcServiceDefinition::class);

