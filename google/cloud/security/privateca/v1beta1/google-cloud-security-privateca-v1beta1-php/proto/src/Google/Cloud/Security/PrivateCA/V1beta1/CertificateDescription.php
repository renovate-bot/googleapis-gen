<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/security/privateca/v1beta1/resources.proto

namespace Google\Cloud\Security\PrivateCA\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A [CertificateDescription][google.cloud.security.privateca.v1beta1.CertificateDescription] describes an X.509 certificate or CSR that has
 * been issued, as an alternative to using ASN.1 / X.509.
 *
 * Generated from protobuf message <code>google.cloud.security.privateca.v1beta1.CertificateDescription</code>
 */
class CertificateDescription extends \Google\Protobuf\Internal\Message
{
    /**
     * Describes some of the values in a certificate that are related to the
     * subject and lifetime.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.SubjectDescription subject_description = 1;</code>
     */
    protected $subject_description = null;
    /**
     * Describes some of the technical fields in a certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.ReusableConfigValues config_values = 2;</code>
     */
    protected $config_values = null;
    /**
     * The public key that corresponds to an issued certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.PublicKey public_key = 3;</code>
     */
    protected $public_key = null;
    /**
     * Provides a means of identifiying certificates that contain a particular
     * public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId subject_key_id = 4;</code>
     */
    protected $subject_key_id = null;
    /**
     * Identifies the subject_key_id of the parent certificate, per
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.1
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId authority_key_id = 5;</code>
     */
    protected $authority_key_id = null;
    /**
     * Describes a list of locations to obtain CRL information, i.e.
     * the DistributionPoint.fullName described by
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.13
     *
     * Generated from protobuf field <code>repeated string crl_distribution_points = 6;</code>
     */
    private $crl_distribution_points;
    /**
     * Describes lists of issuer CA certificate URLs that appear in the
     * "Authority Information Access" extension in the certificate.
     *
     * Generated from protobuf field <code>repeated string aia_issuing_certificate_urls = 7;</code>
     */
    private $aia_issuing_certificate_urls;
    /**
     * The hash of the x.509 certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.CertificateFingerprint cert_fingerprint = 8;</code>
     */
    protected $cert_fingerprint = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\SubjectDescription $subject_description
     *           Describes some of the values in a certificate that are related to the
     *           subject and lifetime.
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\ReusableConfigValues $config_values
     *           Describes some of the technical fields in a certificate.
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\PublicKey $public_key
     *           The public key that corresponds to an issued certificate.
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId $subject_key_id
     *           Provides a means of identifiying certificates that contain a particular
     *           public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId $authority_key_id
     *           Identifies the subject_key_id of the parent certificate, per
     *           https://tools.ietf.org/html/rfc5280#section-4.2.1.1
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $crl_distribution_points
     *           Describes a list of locations to obtain CRL information, i.e.
     *           the DistributionPoint.fullName described by
     *           https://tools.ietf.org/html/rfc5280#section-4.2.1.13
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $aia_issuing_certificate_urls
     *           Describes lists of issuer CA certificate URLs that appear in the
     *           "Authority Information Access" extension in the certificate.
     *     @type \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\CertificateFingerprint $cert_fingerprint
     *           The hash of the x.509 certificate.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Security\Privateca\V1Beta1\Resources::initOnce();
        parent::__construct($data);
    }

    /**
     * Describes some of the values in a certificate that are related to the
     * subject and lifetime.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.SubjectDescription subject_description = 1;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\SubjectDescription|null
     */
    public function getSubjectDescription()
    {
        return isset($this->subject_description) ? $this->subject_description : null;
    }

    public function hasSubjectDescription()
    {
        return isset($this->subject_description);
    }

    public function clearSubjectDescription()
    {
        unset($this->subject_description);
    }

    /**
     * Describes some of the values in a certificate that are related to the
     * subject and lifetime.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.SubjectDescription subject_description = 1;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\SubjectDescription $var
     * @return $this
     */
    public function setSubjectDescription($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\SubjectDescription::class);
        $this->subject_description = $var;

        return $this;
    }

    /**
     * Describes some of the technical fields in a certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.ReusableConfigValues config_values = 2;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\ReusableConfigValues|null
     */
    public function getConfigValues()
    {
        return isset($this->config_values) ? $this->config_values : null;
    }

    public function hasConfigValues()
    {
        return isset($this->config_values);
    }

    public function clearConfigValues()
    {
        unset($this->config_values);
    }

    /**
     * Describes some of the technical fields in a certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.ReusableConfigValues config_values = 2;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\ReusableConfigValues $var
     * @return $this
     */
    public function setConfigValues($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\ReusableConfigValues::class);
        $this->config_values = $var;

        return $this;
    }

    /**
     * The public key that corresponds to an issued certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.PublicKey public_key = 3;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\PublicKey|null
     */
    public function getPublicKey()
    {
        return isset($this->public_key) ? $this->public_key : null;
    }

    public function hasPublicKey()
    {
        return isset($this->public_key);
    }

    public function clearPublicKey()
    {
        unset($this->public_key);
    }

    /**
     * The public key that corresponds to an issued certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.PublicKey public_key = 3;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\PublicKey $var
     * @return $this
     */
    public function setPublicKey($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\PublicKey::class);
        $this->public_key = $var;

        return $this;
    }

    /**
     * Provides a means of identifiying certificates that contain a particular
     * public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId subject_key_id = 4;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId|null
     */
    public function getSubjectKeyId()
    {
        return isset($this->subject_key_id) ? $this->subject_key_id : null;
    }

    public function hasSubjectKeyId()
    {
        return isset($this->subject_key_id);
    }

    public function clearSubjectKeyId()
    {
        unset($this->subject_key_id);
    }

    /**
     * Provides a means of identifiying certificates that contain a particular
     * public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId subject_key_id = 4;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId $var
     * @return $this
     */
    public function setSubjectKeyId($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId::class);
        $this->subject_key_id = $var;

        return $this;
    }

    /**
     * Identifies the subject_key_id of the parent certificate, per
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.1
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId authority_key_id = 5;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId|null
     */
    public function getAuthorityKeyId()
    {
        return isset($this->authority_key_id) ? $this->authority_key_id : null;
    }

    public function hasAuthorityKeyId()
    {
        return isset($this->authority_key_id);
    }

    public function clearAuthorityKeyId()
    {
        unset($this->authority_key_id);
    }

    /**
     * Identifies the subject_key_id of the parent certificate, per
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.1
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.KeyId authority_key_id = 5;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId $var
     * @return $this
     */
    public function setAuthorityKeyId($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\KeyId::class);
        $this->authority_key_id = $var;

        return $this;
    }

    /**
     * Describes a list of locations to obtain CRL information, i.e.
     * the DistributionPoint.fullName described by
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.13
     *
     * Generated from protobuf field <code>repeated string crl_distribution_points = 6;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getCrlDistributionPoints()
    {
        return $this->crl_distribution_points;
    }

    /**
     * Describes a list of locations to obtain CRL information, i.e.
     * the DistributionPoint.fullName described by
     * https://tools.ietf.org/html/rfc5280#section-4.2.1.13
     *
     * Generated from protobuf field <code>repeated string crl_distribution_points = 6;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setCrlDistributionPoints($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->crl_distribution_points = $arr;

        return $this;
    }

    /**
     * Describes lists of issuer CA certificate URLs that appear in the
     * "Authority Information Access" extension in the certificate.
     *
     * Generated from protobuf field <code>repeated string aia_issuing_certificate_urls = 7;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAiaIssuingCertificateUrls()
    {
        return $this->aia_issuing_certificate_urls;
    }

    /**
     * Describes lists of issuer CA certificate URLs that appear in the
     * "Authority Information Access" extension in the certificate.
     *
     * Generated from protobuf field <code>repeated string aia_issuing_certificate_urls = 7;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAiaIssuingCertificateUrls($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->aia_issuing_certificate_urls = $arr;

        return $this;
    }

    /**
     * The hash of the x.509 certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.CertificateFingerprint cert_fingerprint = 8;</code>
     * @return \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\CertificateFingerprint|null
     */
    public function getCertFingerprint()
    {
        return isset($this->cert_fingerprint) ? $this->cert_fingerprint : null;
    }

    public function hasCertFingerprint()
    {
        return isset($this->cert_fingerprint);
    }

    public function clearCertFingerprint()
    {
        unset($this->cert_fingerprint);
    }

    /**
     * The hash of the x.509 certificate.
     *
     * Generated from protobuf field <code>.google.cloud.security.privateca.v1beta1.CertificateDescription.CertificateFingerprint cert_fingerprint = 8;</code>
     * @param \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\CertificateFingerprint $var
     * @return $this
     */
    public function setCertFingerprint($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Security\PrivateCA\V1beta1\CertificateDescription\CertificateFingerprint::class);
        $this->cert_fingerprint = $var;

        return $this;
    }

}

