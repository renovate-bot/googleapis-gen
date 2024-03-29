<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/firestore/admin/v1/database.proto

namespace Google\Cloud\Firestore\Admin\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A Cloud Firestore Database.
 * Currently only one database is allowed per cloud project; this database
 * must have a `database_id` of '(default)'.
 *
 * Generated from protobuf message <code>google.firestore.admin.v1.Database</code>
 */
class Database extends \Google\Protobuf\Internal\Message
{
    /**
     * The resource name of the Database.
     * Format: `projects/{project}/databases/{database}`
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * The location of the database. Available databases are listed at
     * https://cloud.google.com/firestore/docs/locations.
     *
     * Generated from protobuf field <code>string location_id = 9;</code>
     */
    protected $location_id = '';
    /**
     * The type of the database.
     * See https://cloud.google.com/datastore/docs/firestore-or-datastore for
     * information about how to choose.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.DatabaseType type = 10;</code>
     */
    protected $type = 0;
    /**
     * The concurrency control mode to use for this database.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.ConcurrencyMode concurrency_mode = 15;</code>
     */
    protected $concurrency_mode = 0;
    /**
     * This checksum is computed by the server based on the value of other
     * fields, and may be sent on update and delete requests to ensure the
     * client has an up-to-date value before proceeding.
     *
     * Generated from protobuf field <code>string etag = 99;</code>
     */
    protected $etag = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The resource name of the Database.
     *           Format: `projects/{project}/databases/{database}`
     *     @type string $location_id
     *           The location of the database. Available databases are listed at
     *           https://cloud.google.com/firestore/docs/locations.
     *     @type int $type
     *           The type of the database.
     *           See https://cloud.google.com/datastore/docs/firestore-or-datastore for
     *           information about how to choose.
     *     @type int $concurrency_mode
     *           The concurrency control mode to use for this database.
     *     @type string $etag
     *           This checksum is computed by the server based on the value of other
     *           fields, and may be sent on update and delete requests to ensure the
     *           client has an up-to-date value before proceeding.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Firestore\Admin\V1\Database::initOnce();
        parent::__construct($data);
    }

    /**
     * The resource name of the Database.
     * Format: `projects/{project}/databases/{database}`
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The resource name of the Database.
     * Format: `projects/{project}/databases/{database}`
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
     * The location of the database. Available databases are listed at
     * https://cloud.google.com/firestore/docs/locations.
     *
     * Generated from protobuf field <code>string location_id = 9;</code>
     * @return string
     */
    public function getLocationId()
    {
        return $this->location_id;
    }

    /**
     * The location of the database. Available databases are listed at
     * https://cloud.google.com/firestore/docs/locations.
     *
     * Generated from protobuf field <code>string location_id = 9;</code>
     * @param string $var
     * @return $this
     */
    public function setLocationId($var)
    {
        GPBUtil::checkString($var, True);
        $this->location_id = $var;

        return $this;
    }

    /**
     * The type of the database.
     * See https://cloud.google.com/datastore/docs/firestore-or-datastore for
     * information about how to choose.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.DatabaseType type = 10;</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * The type of the database.
     * See https://cloud.google.com/datastore/docs/firestore-or-datastore for
     * information about how to choose.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.DatabaseType type = 10;</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Firestore\Admin\V1\Database\DatabaseType::class);
        $this->type = $var;

        return $this;
    }

    /**
     * The concurrency control mode to use for this database.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.ConcurrencyMode concurrency_mode = 15;</code>
     * @return int
     */
    public function getConcurrencyMode()
    {
        return $this->concurrency_mode;
    }

    /**
     * The concurrency control mode to use for this database.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Database.ConcurrencyMode concurrency_mode = 15;</code>
     * @param int $var
     * @return $this
     */
    public function setConcurrencyMode($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Firestore\Admin\V1\Database\ConcurrencyMode::class);
        $this->concurrency_mode = $var;

        return $this;
    }

    /**
     * This checksum is computed by the server based on the value of other
     * fields, and may be sent on update and delete requests to ensure the
     * client has an up-to-date value before proceeding.
     *
     * Generated from protobuf field <code>string etag = 99;</code>
     * @return string
     */
    public function getEtag()
    {
        return $this->etag;
    }

    /**
     * This checksum is computed by the server based on the value of other
     * fields, and may be sent on update and delete requests to ensure the
     * client has an up-to-date value before proceeding.
     *
     * Generated from protobuf field <code>string etag = 99;</code>
     * @param string $var
     * @return $this
     */
    public function setEtag($var)
    {
        GPBUtil::checkString($var, True);
        $this->etag = $var;

        return $this;
    }

}

