<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/dashboard/v1/dashboards_service.proto

namespace Google\Cloud\Monitoring\Dashboard\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The `ListDashboards` request.
 *
 * Generated from protobuf message <code>google.monitoring.dashboard.v1.ListDashboardsResponse</code>
 */
class ListDashboardsResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The list of requested dashboards.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.dashboard.v1.Dashboard dashboards = 1;</code>
     */
    private $dashboards;
    /**
     * If there are more results than have been returned, then this field is set
     * to a non-empty value.  To see the additional results,
     * use that value as `page_token` in the next call to this method.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     */
    protected $next_page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Monitoring\Dashboard\V1\Dashboard[]|\Google\Protobuf\Internal\RepeatedField $dashboards
     *           The list of requested dashboards.
     *     @type string $next_page_token
     *           If there are more results than have been returned, then this field is set
     *           to a non-empty value.  To see the additional results,
     *           use that value as `page_token` in the next call to this method.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\Dashboard\V1\DashboardsService::initOnce();
        parent::__construct($data);
    }

    /**
     * The list of requested dashboards.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.dashboard.v1.Dashboard dashboards = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getDashboards()
    {
        return $this->dashboards;
    }

    /**
     * The list of requested dashboards.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.dashboard.v1.Dashboard dashboards = 1;</code>
     * @param \Google\Cloud\Monitoring\Dashboard\V1\Dashboard[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setDashboards($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Monitoring\Dashboard\V1\Dashboard::class);
        $this->dashboards = $arr;

        return $this;
    }

    /**
     * If there are more results than have been returned, then this field is set
     * to a non-empty value.  To see the additional results,
     * use that value as `page_token` in the next call to this method.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     * @return string
     */
    public function getNextPageToken()
    {
        return $this->next_page_token;
    }

    /**
     * If there are more results than have been returned, then this field is set
     * to a non-empty value.  To see the additional results,
     * use that value as `page_token` in the next call to this method.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setNextPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->next_page_token = $var;

        return $this;
    }

}

