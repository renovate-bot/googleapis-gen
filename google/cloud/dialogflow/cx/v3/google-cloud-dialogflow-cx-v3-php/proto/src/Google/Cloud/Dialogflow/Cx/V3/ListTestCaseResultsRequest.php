<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TestCases.ListTestCaseResults][google.cloud.dialogflow.cx.v3.TestCases.ListTestCaseResults].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.ListTestCaseResultsRequest</code>
 */
class ListTestCaseResultsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The test case to list results for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
     * list results across multiple test cases.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';
    /**
     * The filter expression used to filter test case results. See
     * [API Filtering](https://aip.dev/160).
     * The expression is case insensitive. Only 'AND' is supported for logical
     * operators. The supported syntax is listed below in detail:
     *   <field> <operator> <value> [AND <field> <operator> <value>] ...
     *   [AND latest]
     * The supported fields and operators are:
     * field                 operator
     * `environment`         `=`, `IN`  (Use value `draft` for draft environment)
     * `test_time`           `>`, `<`
     * `latest` only returns the latest test result in all results for each test
     * case.
     * Examples:
     * *   "environment=draft AND latest" matches the latest test result for each
     *     test case in the draft environment.
     * *   "environment IN (e1,e2)" matches any test case results with an
     *     environment resource name of either "e1" or "e2".
     * *   "test_time > 1602540713" matches any test case results with test time
     *     later than a unix timestamp in seconds 1602540713.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     */
    protected $filter = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The test case to list results for.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     *           testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
     *           list results across multiple test cases.
     *     @type int $page_size
     *           The maximum number of items to return in a single page. By default 100 and
     *           at most 1000.
     *     @type string $page_token
     *           The next_page_token value returned from a previous list request.
     *     @type string $filter
     *           The filter expression used to filter test case results. See
     *           [API Filtering](https://aip.dev/160).
     *           The expression is case insensitive. Only 'AND' is supported for logical
     *           operators. The supported syntax is listed below in detail:
     *             <field> <operator> <value> [AND <field> <operator> <value>] ...
     *             [AND latest]
     *           The supported fields and operators are:
     *           field                 operator
     *           `environment`         `=`, `IN`  (Use value `draft` for draft environment)
     *           `test_time`           `>`, `<`
     *           `latest` only returns the latest test result in all results for each test
     *           case.
     *           Examples:
     *           *   "environment=draft AND latest" matches the latest test result for each
     *               test case in the draft environment.
     *           *   "environment IN (e1,e2)" matches any test case results with an
     *               environment resource name of either "e1" or "e2".
     *           *   "test_time > 1602540713" matches any test case results with test time
     *               later than a unix timestamp in seconds 1602540713.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The test case to list results for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
     * list results across multiple test cases.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The test case to list results for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
     * list results across multiple test cases.
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
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
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
     * The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * The next_page_token value returned from a previous list request.
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

    /**
     * The filter expression used to filter test case results. See
     * [API Filtering](https://aip.dev/160).
     * The expression is case insensitive. Only 'AND' is supported for logical
     * operators. The supported syntax is listed below in detail:
     *   <field> <operator> <value> [AND <field> <operator> <value>] ...
     *   [AND latest]
     * The supported fields and operators are:
     * field                 operator
     * `environment`         `=`, `IN`  (Use value `draft` for draft environment)
     * `test_time`           `>`, `<`
     * `latest` only returns the latest test result in all results for each test
     * case.
     * Examples:
     * *   "environment=draft AND latest" matches the latest test result for each
     *     test case in the draft environment.
     * *   "environment IN (e1,e2)" matches any test case results with an
     *     environment resource name of either "e1" or "e2".
     * *   "test_time > 1602540713" matches any test case results with test time
     *     later than a unix timestamp in seconds 1602540713.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * The filter expression used to filter test case results. See
     * [API Filtering](https://aip.dev/160).
     * The expression is case insensitive. Only 'AND' is supported for logical
     * operators. The supported syntax is listed below in detail:
     *   <field> <operator> <value> [AND <field> <operator> <value>] ...
     *   [AND latest]
     * The supported fields and operators are:
     * field                 operator
     * `environment`         `=`, `IN`  (Use value `draft` for draft environment)
     * `test_time`           `>`, `<`
     * `latest` only returns the latest test result in all results for each test
     * case.
     * Examples:
     * *   "environment=draft AND latest" matches the latest test result for each
     *     test case in the draft environment.
     * *   "environment IN (e1,e2)" matches any test case results with an
     *     environment resource name of either "e1" or "e2".
     * *   "test_time > 1602540713" matches any test case results with test time
     *     later than a unix timestamp in seconds 1602540713.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

}

