<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/container/v1beta1/cluster_service.proto

namespace Google\Cloud\Container\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The authentication information for accessing the master endpoint.
 * Authentication can be done using HTTP basic auth or using client
 * certificates.
 *
 * Generated from protobuf message <code>google.container.v1beta1.MasterAuth</code>
 */
class MasterAuth extends \Google\Protobuf\Internal\Message
{
    /**
     * The username to use for HTTP basic authentication to the master endpoint.
     * For clusters v1.6.0 and later, basic authentication can be disabled by
     * leaving username unspecified (or setting it to the empty string).
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string username = 1 [deprecated = true];</code>
     * @deprecated
     */
    protected $username = '';
    /**
     * The password to use for HTTP basic authentication to the master endpoint.
     * Because the master endpoint is open to the Internet, you should create a
     * strong password.  If a password is provided for cluster creation, username
     * must be non-empty.
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string password = 2 [deprecated = true];</code>
     * @deprecated
     */
    protected $password = '';
    /**
     * Configuration for client certificate authentication on the cluster. For
     * clusters before v1.12, if no configuration is specified, a client
     * certificate is issued.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClientCertificateConfig client_certificate_config = 3;</code>
     */
    protected $client_certificate_config = null;
    /**
     * Generated from protobuf field <code>string cluster_ca_certificate = 100;</code>
     */
    protected $cluster_ca_certificate = '';
    /**
     * [Output only] Base64-encoded public certificate used by clients to
     * authenticate to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_certificate = 101;</code>
     */
    protected $client_certificate = '';
    /**
     * [Output only] Base64-encoded private key used by clients to authenticate
     * to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_key = 102;</code>
     */
    protected $client_key = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $username
     *           The username to use for HTTP basic authentication to the master endpoint.
     *           For clusters v1.6.0 and later, basic authentication can be disabled by
     *           leaving username unspecified (or setting it to the empty string).
     *           Warning: basic authentication is deprecated, and will be removed in GKE
     *           control plane versions 1.19 and newer. For a list of recommended
     *           authentication methods, see:
     *           https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *     @type string $password
     *           The password to use for HTTP basic authentication to the master endpoint.
     *           Because the master endpoint is open to the Internet, you should create a
     *           strong password.  If a password is provided for cluster creation, username
     *           must be non-empty.
     *           Warning: basic authentication is deprecated, and will be removed in GKE
     *           control plane versions 1.19 and newer. For a list of recommended
     *           authentication methods, see:
     *           https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *     @type \Google\Cloud\Container\V1beta1\ClientCertificateConfig $client_certificate_config
     *           Configuration for client certificate authentication on the cluster. For
     *           clusters before v1.12, if no configuration is specified, a client
     *           certificate is issued.
     *     @type string $cluster_ca_certificate
     *     @type string $client_certificate
     *           [Output only] Base64-encoded public certificate used by clients to
     *           authenticate to the cluster endpoint.
     *     @type string $client_key
     *           [Output only] Base64-encoded private key used by clients to authenticate
     *           to the cluster endpoint.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Container\V1Beta1\ClusterService::initOnce();
        parent::__construct($data);
    }

    /**
     * The username to use for HTTP basic authentication to the master endpoint.
     * For clusters v1.6.0 and later, basic authentication can be disabled by
     * leaving username unspecified (or setting it to the empty string).
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string username = 1 [deprecated = true];</code>
     * @return string
     * @deprecated
     */
    public function getUsername()
    {
        @trigger_error('username is deprecated.', E_USER_DEPRECATED);
        return $this->username;
    }

    /**
     * The username to use for HTTP basic authentication to the master endpoint.
     * For clusters v1.6.0 and later, basic authentication can be disabled by
     * leaving username unspecified (or setting it to the empty string).
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string username = 1 [deprecated = true];</code>
     * @param string $var
     * @return $this
     * @deprecated
     */
    public function setUsername($var)
    {
        @trigger_error('username is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkString($var, True);
        $this->username = $var;

        return $this;
    }

    /**
     * The password to use for HTTP basic authentication to the master endpoint.
     * Because the master endpoint is open to the Internet, you should create a
     * strong password.  If a password is provided for cluster creation, username
     * must be non-empty.
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string password = 2 [deprecated = true];</code>
     * @return string
     * @deprecated
     */
    public function getPassword()
    {
        @trigger_error('password is deprecated.', E_USER_DEPRECATED);
        return $this->password;
    }

    /**
     * The password to use for HTTP basic authentication to the master endpoint.
     * Because the master endpoint is open to the Internet, you should create a
     * strong password.  If a password is provided for cluster creation, username
     * must be non-empty.
     * Warning: basic authentication is deprecated, and will be removed in GKE
     * control plane versions 1.19 and newer. For a list of recommended
     * authentication methods, see:
     * https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
     *
     * Generated from protobuf field <code>string password = 2 [deprecated = true];</code>
     * @param string $var
     * @return $this
     * @deprecated
     */
    public function setPassword($var)
    {
        @trigger_error('password is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkString($var, True);
        $this->password = $var;

        return $this;
    }

    /**
     * Configuration for client certificate authentication on the cluster. For
     * clusters before v1.12, if no configuration is specified, a client
     * certificate is issued.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClientCertificateConfig client_certificate_config = 3;</code>
     * @return \Google\Cloud\Container\V1beta1\ClientCertificateConfig|null
     */
    public function getClientCertificateConfig()
    {
        return isset($this->client_certificate_config) ? $this->client_certificate_config : null;
    }

    public function hasClientCertificateConfig()
    {
        return isset($this->client_certificate_config);
    }

    public function clearClientCertificateConfig()
    {
        unset($this->client_certificate_config);
    }

    /**
     * Configuration for client certificate authentication on the cluster. For
     * clusters before v1.12, if no configuration is specified, a client
     * certificate is issued.
     *
     * Generated from protobuf field <code>.google.container.v1beta1.ClientCertificateConfig client_certificate_config = 3;</code>
     * @param \Google\Cloud\Container\V1beta1\ClientCertificateConfig $var
     * @return $this
     */
    public function setClientCertificateConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Container\V1beta1\ClientCertificateConfig::class);
        $this->client_certificate_config = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string cluster_ca_certificate = 100;</code>
     * @return string
     */
    public function getClusterCaCertificate()
    {
        return $this->cluster_ca_certificate;
    }

    /**
     * Generated from protobuf field <code>string cluster_ca_certificate = 100;</code>
     * @param string $var
     * @return $this
     */
    public function setClusterCaCertificate($var)
    {
        GPBUtil::checkString($var, True);
        $this->cluster_ca_certificate = $var;

        return $this;
    }

    /**
     * [Output only] Base64-encoded public certificate used by clients to
     * authenticate to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_certificate = 101;</code>
     * @return string
     */
    public function getClientCertificate()
    {
        return $this->client_certificate;
    }

    /**
     * [Output only] Base64-encoded public certificate used by clients to
     * authenticate to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_certificate = 101;</code>
     * @param string $var
     * @return $this
     */
    public function setClientCertificate($var)
    {
        GPBUtil::checkString($var, True);
        $this->client_certificate = $var;

        return $this;
    }

    /**
     * [Output only] Base64-encoded private key used by clients to authenticate
     * to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_key = 102;</code>
     * @return string
     */
    public function getClientKey()
    {
        return $this->client_key;
    }

    /**
     * [Output only] Base64-encoded private key used by clients to authenticate
     * to the cluster endpoint.
     *
     * Generated from protobuf field <code>string client_key = 102;</code>
     * @param string $var
     * @return $this
     */
    public function setClientKey($var)
    {
        GPBUtil::checkString($var, True);
        $this->client_key = $var;

        return $this;
    }

}

