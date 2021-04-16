<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/security/privateca/v1/service.proto

namespace Google\Cloud\Security\PrivateCA\v1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response message for
 * [CertificateAuthorityService.FetchCaCerts][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCaCerts].
 *
 * Generated from protobuf message <code>google.cloud.security.privateca.v1.FetchCaCertsResponse</code>
 */
class FetchCaCertsResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The PEM encoded CA certificate chains of all
     * [ACTIVE][CertificateAuthority.State.ACTIVE] [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
     * resources in this [CaPool][google.cloud.security.privateca.v1.CaPool].
     *
     * Generated from protobuf field <code>repeated .google.cloud.security.privateca.v1.FetchCaCertsResponse.CertChain ca_certs = 1;</code>
     */
    private $ca_certs;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Security\PrivateCA\v1\FetchCaCertsResponse\CertChain[]|\Google\Protobuf\Internal\RepeatedField $ca_certs
     *           The PEM encoded CA certificate chains of all
     *           [ACTIVE][CertificateAuthority.State.ACTIVE] [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
     *           resources in this [CaPool][google.cloud.security.privateca.v1.CaPool].
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Security\Privateca\V1\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * The PEM encoded CA certificate chains of all
     * [ACTIVE][CertificateAuthority.State.ACTIVE] [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
     * resources in this [CaPool][google.cloud.security.privateca.v1.CaPool].
     *
     * Generated from protobuf field <code>repeated .google.cloud.security.privateca.v1.FetchCaCertsResponse.CertChain ca_certs = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getCaCerts()
    {
        return $this->ca_certs;
    }

    /**
     * The PEM encoded CA certificate chains of all
     * [ACTIVE][CertificateAuthority.State.ACTIVE] [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
     * resources in this [CaPool][google.cloud.security.privateca.v1.CaPool].
     *
     * Generated from protobuf field <code>repeated .google.cloud.security.privateca.v1.FetchCaCertsResponse.CertChain ca_certs = 1;</code>
     * @param \Google\Cloud\Security\PrivateCA\v1\FetchCaCertsResponse\CertChain[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setCaCerts($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Security\PrivateCA\v1\FetchCaCertsResponse\CertChain::class);
        $this->ca_certs = $arr;

        return $this;
    }

}

