<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/security/privateca/v1/service.proto

namespace Google\Cloud\Security\PrivateCA\v1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [CertificateAuthorityService.ListCertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthorityService.ListCertificateAuthorities].
 *
 * Generated from protobuf message <code>google.cloud.security.privateca.v1.ListCertificateAuthoritiesRequest</code>
 */
class ListCertificateAuthoritiesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
     * [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority], in the format
     * `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional. Limit on the number of [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] to
     * include in the response.
     * Further [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] can subsequently be
     * obtained by including the
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_size = 0;
    /**
     * Optional. Pagination token, returned earlier via
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token].
     *
     * Generated from protobuf field <code>string page_token = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_token = '';
    /**
     * Optional. Only include resources that match the filter in the response.
     *
     * Generated from protobuf field <code>string filter = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $filter = '';
    /**
     * Optional. Specify how the results should be sorted.
     *
     * Generated from protobuf field <code>string order_by = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $order_by = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The resource name of the [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
     *           [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority], in the format
     *           `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     *     @type int $page_size
     *           Optional. Limit on the number of [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] to
     *           include in the response.
     *           Further [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] can subsequently be
     *           obtained by including the
     *           [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token] in a subsequent
     *           request. If unspecified, the server will pick an appropriate default.
     *     @type string $page_token
     *           Optional. Pagination token, returned earlier via
     *           [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token].
     *     @type string $filter
     *           Optional. Only include resources that match the filter in the response.
     *     @type string $order_by
     *           Optional. Specify how the results should be sorted.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Security\Privateca\V1\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name of the [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
     * [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority], in the format
     * `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The resource name of the [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
     * [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority], in the format
     * `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
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
     * Optional. Limit on the number of [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] to
     * include in the response.
     * Further [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] can subsequently be
     * obtained by including the
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Optional. Limit on the number of [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] to
     * include in the response.
     * Further [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority] can subsequently be
     * obtained by including the
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     *
     * Generated from protobuf field <code>int32 page_size = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
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
     * Optional. Pagination token, returned earlier via
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token].
     *
     * Generated from protobuf field <code>string page_token = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Optional. Pagination token, returned earlier via
     * [ListCertificateAuthoritiesResponse.next_page_token][google.cloud.security.privateca.v1.ListCertificateAuthoritiesResponse.next_page_token].
     *
     * Generated from protobuf field <code>string page_token = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->page_token = $var;

        return $this;
    }

    /**
     * Optional. Only include resources that match the filter in the response.
     *
     * Generated from protobuf field <code>string filter = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * Optional. Only include resources that match the filter in the response.
     *
     * Generated from protobuf field <code>string filter = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

    /**
     * Optional. Specify how the results should be sorted.
     *
     * Generated from protobuf field <code>string order_by = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getOrderBy()
    {
        return $this->order_by;
    }

    /**
     * Optional. Specify how the results should be sorted.
     *
     * Generated from protobuf field <code>string order_by = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setOrderBy($var)
    {
        GPBUtil::checkString($var, True);
        $this->order_by = $var;

        return $this;
    }

}

