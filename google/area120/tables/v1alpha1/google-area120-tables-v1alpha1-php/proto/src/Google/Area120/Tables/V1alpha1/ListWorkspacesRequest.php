<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/area120/tables/v1alpha1/tables.proto

namespace Google\Area120\Tables\V1alpha1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for TablesService.ListWorkspaces.
 *
 * Generated from protobuf message <code>google.area120.tables.v1alpha1.ListWorkspacesRequest</code>
 */
class ListWorkspacesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The maximum number of workspaces to return. The service may return fewer
     * than this value.
     * If unspecified, at most 10 workspaces are returned. The maximum value is
     * 25; values above 25 are coerced to 25.
     *
     * Generated from protobuf field <code>int32 page_size = 1;</code>
     */
    protected $page_size = 0;
    /**
     * A page token, received from a previous `ListWorkspaces` call.
     * Provide this to retrieve the subsequent page.
     * When paginating, all other parameters provided to `ListWorkspaces` must
     * match the call that provided the page token.
     *
     * Generated from protobuf field <code>string page_token = 2;</code>
     */
    protected $page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $page_size
     *           The maximum number of workspaces to return. The service may return fewer
     *           than this value.
     *           If unspecified, at most 10 workspaces are returned. The maximum value is
     *           25; values above 25 are coerced to 25.
     *     @type string $page_token
     *           A page token, received from a previous `ListWorkspaces` call.
     *           Provide this to retrieve the subsequent page.
     *           When paginating, all other parameters provided to `ListWorkspaces` must
     *           match the call that provided the page token.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Area120\Tables\V1Alpha1\Tables::initOnce();
        parent::__construct($data);
    }

    /**
     * The maximum number of workspaces to return. The service may return fewer
     * than this value.
     * If unspecified, at most 10 workspaces are returned. The maximum value is
     * 25; values above 25 are coerced to 25.
     *
     * Generated from protobuf field <code>int32 page_size = 1;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * The maximum number of workspaces to return. The service may return fewer
     * than this value.
     * If unspecified, at most 10 workspaces are returned. The maximum value is
     * 25; values above 25 are coerced to 25.
     *
     * Generated from protobuf field <code>int32 page_size = 1;</code>
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
     * A page token, received from a previous `ListWorkspaces` call.
     * Provide this to retrieve the subsequent page.
     * When paginating, all other parameters provided to `ListWorkspaces` must
     * match the call that provided the page token.
     *
     * Generated from protobuf field <code>string page_token = 2;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * A page token, received from a previous `ListWorkspaces` call.
     * Provide this to retrieve the subsequent page.
     * When paginating, all other parameters provided to `ListWorkspaces` must
     * match the call that provided the page token.
     *
     * Generated from protobuf field <code>string page_token = 2;</code>
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

