<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/shell/v1/cloudshell.proto

namespace Google\Cloud\Shell\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [AuthorizeEnvironment][google.cloud.shell.v1.CloudShellService.AuthorizeEnvironment].
 *
 * Generated from protobuf message <code>google.cloud.shell.v1.AuthorizeEnvironmentRequest</code>
 */
class AuthorizeEnvironmentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Name of the resource that should receive the credentials, for example
     * `users/me/environments/default` or
     * `users/someone&#64;example.com/environments/default`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * The OAuth access token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string access_token = 2;</code>
     */
    protected $access_token = '';
    /**
     * The OAuth ID token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string id_token = 4;</code>
     */
    protected $id_token = '';
    /**
     * The time when the credentials expire. If not set, defaults to one hour from
     * when the server received the request.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 3;</code>
     */
    protected $expire_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Name of the resource that should receive the credentials, for example
     *           `users/me/environments/default` or
     *           `users/someone&#64;example.com/environments/default`.
     *     @type string $access_token
     *           The OAuth access token that should be sent to the environment.
     *     @type string $id_token
     *           The OAuth ID token that should be sent to the environment.
     *     @type \Google\Protobuf\Timestamp $expire_time
     *           The time when the credentials expire. If not set, defaults to one hour from
     *           when the server received the request.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Shell\V1\Cloudshell::initOnce();
        parent::__construct($data);
    }

    /**
     * Name of the resource that should receive the credentials, for example
     * `users/me/environments/default` or
     * `users/someone&#64;example.com/environments/default`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Name of the resource that should receive the credentials, for example
     * `users/me/environments/default` or
     * `users/someone&#64;example.com/environments/default`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * The OAuth access token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string access_token = 2;</code>
     * @return string
     */
    public function getAccessToken()
    {
        return $this->access_token;
    }

    /**
     * The OAuth access token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string access_token = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setAccessToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->access_token = $var;

        return $this;
    }

    /**
     * The OAuth ID token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string id_token = 4;</code>
     * @return string
     */
    public function getIdToken()
    {
        return $this->id_token;
    }

    /**
     * The OAuth ID token that should be sent to the environment.
     *
     * Generated from protobuf field <code>string id_token = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setIdToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->id_token = $var;

        return $this;
    }

    /**
     * The time when the credentials expire. If not set, defaults to one hour from
     * when the server received the request.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 3;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getExpireTime()
    {
        return isset($this->expire_time) ? $this->expire_time : null;
    }

    public function hasExpireTime()
    {
        return isset($this->expire_time);
    }

    public function clearExpireTime()
    {
        unset($this->expire_time);
    }

    /**
     * The time when the credentials expire. If not set, defaults to one hour from
     * when the server received the request.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp expire_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setExpireTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->expire_time = $var;

        return $this;
    }

}

