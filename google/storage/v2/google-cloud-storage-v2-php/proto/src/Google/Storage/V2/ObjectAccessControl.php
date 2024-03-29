<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/storage/v2/storage.proto

namespace Google\Storage\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An access-control entry.
 *
 * Generated from protobuf message <code>google.storage.v2.ObjectAccessControl</code>
 */
class ObjectAccessControl extends \Google\Protobuf\Internal\Message
{
    /**
     * The access permission for the entity.
     *
     * Generated from protobuf field <code>string role = 1;</code>
     */
    protected $role = '';
    /**
     * The ID of the access-control entry.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     */
    protected $id = '';
    /**
     * The entity holding the permission, in one of the following forms:
     * * `user-{userid}`
     * * `user-{email}`
     * * `group-{groupid}`
     * * `group-{email}`
     * * `domain-{domain}`
     * * `project-{team-projectid}`
     * * `allUsers`
     * * `allAuthenticatedUsers`
     * Examples:
     * * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
     * * The group `example&#64;googlegroups.com` would be
     * `group-example&#64;googlegroups.com`.
     * * All members of the Google Apps for Business domain `example.com` would be
     * `domain-example.com`.
     *
     * Generated from protobuf field <code>string entity = 3;</code>
     */
    protected $entity = '';
    /**
     * The ID for the entity, if any.
     *
     * Generated from protobuf field <code>string entity_id = 4;</code>
     */
    protected $entity_id = '';
    /**
     * The email address associated with the entity, if any.
     *
     * Generated from protobuf field <code>string email = 5;</code>
     */
    protected $email = '';
    /**
     * The domain associated with the entity, if any.
     *
     * Generated from protobuf field <code>string domain = 6;</code>
     */
    protected $domain = '';
    /**
     * The project team associated with the entity, if any.
     *
     * Generated from protobuf field <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
     */
    protected $project_team = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $role
     *           The access permission for the entity.
     *     @type string $id
     *           The ID of the access-control entry.
     *     @type string $entity
     *           The entity holding the permission, in one of the following forms:
     *           * `user-{userid}`
     *           * `user-{email}`
     *           * `group-{groupid}`
     *           * `group-{email}`
     *           * `domain-{domain}`
     *           * `project-{team-projectid}`
     *           * `allUsers`
     *           * `allAuthenticatedUsers`
     *           Examples:
     *           * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
     *           * The group `example&#64;googlegroups.com` would be
     *           `group-example&#64;googlegroups.com`.
     *           * All members of the Google Apps for Business domain `example.com` would be
     *           `domain-example.com`.
     *     @type string $entity_id
     *           The ID for the entity, if any.
     *     @type string $email
     *           The email address associated with the entity, if any.
     *     @type string $domain
     *           The domain associated with the entity, if any.
     *     @type \Google\Storage\V2\ProjectTeam $project_team
     *           The project team associated with the entity, if any.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Storage\V2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * The access permission for the entity.
     *
     * Generated from protobuf field <code>string role = 1;</code>
     * @return string
     */
    public function getRole()
    {
        return $this->role;
    }

    /**
     * The access permission for the entity.
     *
     * Generated from protobuf field <code>string role = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setRole($var)
    {
        GPBUtil::checkString($var, True);
        $this->role = $var;

        return $this;
    }

    /**
     * The ID of the access-control entry.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * The ID of the access-control entry.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     * The entity holding the permission, in one of the following forms:
     * * `user-{userid}`
     * * `user-{email}`
     * * `group-{groupid}`
     * * `group-{email}`
     * * `domain-{domain}`
     * * `project-{team-projectid}`
     * * `allUsers`
     * * `allAuthenticatedUsers`
     * Examples:
     * * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
     * * The group `example&#64;googlegroups.com` would be
     * `group-example&#64;googlegroups.com`.
     * * All members of the Google Apps for Business domain `example.com` would be
     * `domain-example.com`.
     *
     * Generated from protobuf field <code>string entity = 3;</code>
     * @return string
     */
    public function getEntity()
    {
        return $this->entity;
    }

    /**
     * The entity holding the permission, in one of the following forms:
     * * `user-{userid}`
     * * `user-{email}`
     * * `group-{groupid}`
     * * `group-{email}`
     * * `domain-{domain}`
     * * `project-{team-projectid}`
     * * `allUsers`
     * * `allAuthenticatedUsers`
     * Examples:
     * * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
     * * The group `example&#64;googlegroups.com` would be
     * `group-example&#64;googlegroups.com`.
     * * All members of the Google Apps for Business domain `example.com` would be
     * `domain-example.com`.
     *
     * Generated from protobuf field <code>string entity = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setEntity($var)
    {
        GPBUtil::checkString($var, True);
        $this->entity = $var;

        return $this;
    }

    /**
     * The ID for the entity, if any.
     *
     * Generated from protobuf field <code>string entity_id = 4;</code>
     * @return string
     */
    public function getEntityId()
    {
        return $this->entity_id;
    }

    /**
     * The ID for the entity, if any.
     *
     * Generated from protobuf field <code>string entity_id = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setEntityId($var)
    {
        GPBUtil::checkString($var, True);
        $this->entity_id = $var;

        return $this;
    }

    /**
     * The email address associated with the entity, if any.
     *
     * Generated from protobuf field <code>string email = 5;</code>
     * @return string
     */
    public function getEmail()
    {
        return $this->email;
    }

    /**
     * The email address associated with the entity, if any.
     *
     * Generated from protobuf field <code>string email = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setEmail($var)
    {
        GPBUtil::checkString($var, True);
        $this->email = $var;

        return $this;
    }

    /**
     * The domain associated with the entity, if any.
     *
     * Generated from protobuf field <code>string domain = 6;</code>
     * @return string
     */
    public function getDomain()
    {
        return $this->domain;
    }

    /**
     * The domain associated with the entity, if any.
     *
     * Generated from protobuf field <code>string domain = 6;</code>
     * @param string $var
     * @return $this
     */
    public function setDomain($var)
    {
        GPBUtil::checkString($var, True);
        $this->domain = $var;

        return $this;
    }

    /**
     * The project team associated with the entity, if any.
     *
     * Generated from protobuf field <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
     * @return \Google\Storage\V2\ProjectTeam|null
     */
    public function getProjectTeam()
    {
        return $this->project_team;
    }

    public function hasProjectTeam()
    {
        return isset($this->project_team);
    }

    public function clearProjectTeam()
    {
        unset($this->project_team);
    }

    /**
     * The project team associated with the entity, if any.
     *
     * Generated from protobuf field <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
     * @param \Google\Storage\V2\ProjectTeam $var
     * @return $this
     */
    public function setProjectTeam($var)
    {
        GPBUtil::checkMessage($var, \Google\Storage\V2\ProjectTeam::class);
        $this->project_team = $var;

        return $this;
    }

}

