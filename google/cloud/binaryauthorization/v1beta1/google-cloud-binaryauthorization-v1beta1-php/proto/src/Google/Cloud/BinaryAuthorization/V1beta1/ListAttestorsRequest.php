<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/binaryauthorization/v1beta1/service.proto

namespace Google\Cloud\BinaryAuthorization\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for [BinauthzManagementService.ListAttestors][].
 *
 * Generated from protobuf message <code>google.cloud.binaryauthorization.v1beta1.ListAttestorsRequest</code>
 */
class ListAttestorsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the project associated with the
     * [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
     * format `projects/&#42;`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Requested page size. The server may return fewer results than requested. If
     * unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * A token identifying a page of results the server should return. Typically,
     * this is the value of
     * [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
     * returned from the previous call to the `ListAttestors` method.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The resource name of the project associated with the
     *           [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
     *           format `projects/&#42;`.
     *     @type int $page_size
     *           Requested page size. The server may return fewer results than requested. If
     *           unspecified, the server will pick an appropriate default.
     *     @type string $page_token
     *           A token identifying a page of results the server should return. Typically,
     *           this is the value of
     *           [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
     *           returned from the previous call to the `ListAttestors` method.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Binaryauthorization\V1Beta1\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name of the project associated with the
     * [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
     * format `projects/&#42;`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The resource name of the project associated with the
     * [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
     * format `projects/&#42;`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Requested page size. The server may return fewer results than requested. If
     * unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Requested page size. The server may return fewer results than requested. If
     * unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setPageSize($var)
    {
        GPBUtil::checkInt32($var);
        $this->page_size = $var;

        return $this;
    }

    /**
     * A token identifying a page of results the server should return. Typically,
     * this is the value of
     * [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
     * returned from the previous call to the `ListAttestors` method.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * A token identifying a page of results the server should return. Typically,
     * this is the value of
     * [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
     * returned from the previous call to the `ListAttestors` method.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->page_token = $var;

        return $this;
    }

}

