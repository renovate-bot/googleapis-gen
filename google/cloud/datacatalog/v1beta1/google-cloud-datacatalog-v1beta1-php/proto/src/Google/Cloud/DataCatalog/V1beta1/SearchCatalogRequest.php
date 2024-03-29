<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1beta1/datacatalog.proto

namespace Google\Cloud\DataCatalog\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [SearchCatalog][google.cloud.datacatalog.v1beta1.DataCatalog.SearchCatalog].
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1beta1.SearchCatalogRequest</code>
 */
class SearchCatalogRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The scope of this search request. A `scope` that has empty
     * `include_org_ids`, `include_project_ids` AND false
     * `include_gcp_public_datasets` is considered invalid. Data Catalog will
     * return an error in such a case.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.SearchCatalogRequest.Scope scope = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $scope = null;
    /**
     * Required. The query string in search query syntax. The query must be non-empty.
     * Query strings can be simple as "x" or more qualified as:
     * * name:x
     * * column:x
     * * description:y
     * Note: Query tokens need to have a minimum of 3 characters for substring
     * matching to work correctly. See [Data Catalog Search
     * Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
     * for more information.
     *
     * Generated from protobuf field <code>string query = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $query = '';
    /**
     * Number of results in the search page. If <=0 then defaults to 10. Max limit
     * for page_size is 1000. Throws an invalid argument for page_size > 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * Optional. Pagination token returned in an earlier
     * [SearchCatalogResponse.next_page_token][google.cloud.datacatalog.v1beta1.SearchCatalogResponse.next_page_token], which
     * indicates that this is a continuation of a prior
     * [SearchCatalogRequest][google.cloud.datacatalog.v1beta1.DataCatalog.SearchCatalog]
     * call, and that the system should return the next page of data. If empty,
     * the first page is returned.
     *
     * Generated from protobuf field <code>string page_token = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_token = '';
    /**
     * Specifies the ordering of results, currently supported case-sensitive
     * choices are:
     *   * `relevance`, only supports descending
     *   * `last_modified_timestamp [asc|desc]`, defaults to descending if not
     *     specified
     * If not specified, defaults to `relevance` descending.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
     */
    protected $order_by = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DataCatalog\V1beta1\SearchCatalogRequest\Scope $scope
     *           Required. The scope of this search request. A `scope` that has empty
     *           `include_org_ids`, `include_project_ids` AND false
     *           `include_gcp_public_datasets` is considered invalid. Data Catalog will
     *           return an error in such a case.
     *     @type string $query
     *           Required. The query string in search query syntax. The query must be non-empty.
     *           Query strings can be simple as "x" or more qualified as:
     *           * name:x
     *           * column:x
     *           * description:y
     *           Note: Query tokens need to have a minimum of 3 characters for substring
     *           matching to work correctly. See [Data Catalog Search
     *           Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
     *           for more information.
     *     @type int $page_size
     *           Number of results in the search page. If <=0 then defaults to 10. Max limit
     *           for page_size is 1000. Throws an invalid argument for page_size > 1000.
     *     @type string $page_token
     *           Optional. Pagination token returned in an earlier
     *           [SearchCatalogResponse.next_page_token][google.cloud.datacatalog.v1beta1.SearchCatalogResponse.next_page_token], which
     *           indicates that this is a continuation of a prior
     *           [SearchCatalogRequest][google.cloud.datacatalog.v1beta1.DataCatalog.SearchCatalog]
     *           call, and that the system should return the next page of data. If empty,
     *           the first page is returned.
     *     @type string $order_by
     *           Specifies the ordering of results, currently supported case-sensitive
     *           choices are:
     *             * `relevance`, only supports descending
     *             * `last_modified_timestamp [asc|desc]`, defaults to descending if not
     *               specified
     *           If not specified, defaults to `relevance` descending.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1Beta1\Datacatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The scope of this search request. A `scope` that has empty
     * `include_org_ids`, `include_project_ids` AND false
     * `include_gcp_public_datasets` is considered invalid. Data Catalog will
     * return an error in such a case.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.SearchCatalogRequest.Scope scope = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\DataCatalog\V1beta1\SearchCatalogRequest\Scope|null
     */
    public function getScope()
    {
        return $this->scope;
    }

    public function hasScope()
    {
        return isset($this->scope);
    }

    public function clearScope()
    {
        unset($this->scope);
    }

    /**
     * Required. The scope of this search request. A `scope` that has empty
     * `include_org_ids`, `include_project_ids` AND false
     * `include_gcp_public_datasets` is considered invalid. Data Catalog will
     * return an error in such a case.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.SearchCatalogRequest.Scope scope = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\DataCatalog\V1beta1\SearchCatalogRequest\Scope $var
     * @return $this
     */
    public function setScope($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataCatalog\V1beta1\SearchCatalogRequest\Scope::class);
        $this->scope = $var;

        return $this;
    }

    /**
     * Required. The query string in search query syntax. The query must be non-empty.
     * Query strings can be simple as "x" or more qualified as:
     * * name:x
     * * column:x
     * * description:y
     * Note: Query tokens need to have a minimum of 3 characters for substring
     * matching to work correctly. See [Data Catalog Search
     * Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
     * for more information.
     *
     * Generated from protobuf field <code>string query = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getQuery()
    {
        return $this->query;
    }

    /**
     * Required. The query string in search query syntax. The query must be non-empty.
     * Query strings can be simple as "x" or more qualified as:
     * * name:x
     * * column:x
     * * description:y
     * Note: Query tokens need to have a minimum of 3 characters for substring
     * matching to work correctly. See [Data Catalog Search
     * Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
     * for more information.
     *
     * Generated from protobuf field <code>string query = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setQuery($var)
    {
        GPBUtil::checkString($var, True);
        $this->query = $var;

        return $this;
    }

    /**
     * Number of results in the search page. If <=0 then defaults to 10. Max limit
     * for page_size is 1000. Throws an invalid argument for page_size > 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Number of results in the search page. If <=0 then defaults to 10. Max limit
     * for page_size is 1000. Throws an invalid argument for page_size > 1000.
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
     * Optional. Pagination token returned in an earlier
     * [SearchCatalogResponse.next_page_token][google.cloud.datacatalog.v1beta1.SearchCatalogResponse.next_page_token], which
     * indicates that this is a continuation of a prior
     * [SearchCatalogRequest][google.cloud.datacatalog.v1beta1.DataCatalog.SearchCatalog]
     * call, and that the system should return the next page of data. If empty,
     * the first page is returned.
     *
     * Generated from protobuf field <code>string page_token = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Optional. Pagination token returned in an earlier
     * [SearchCatalogResponse.next_page_token][google.cloud.datacatalog.v1beta1.SearchCatalogResponse.next_page_token], which
     * indicates that this is a continuation of a prior
     * [SearchCatalogRequest][google.cloud.datacatalog.v1beta1.DataCatalog.SearchCatalog]
     * call, and that the system should return the next page of data. If empty,
     * the first page is returned.
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
     * Specifies the ordering of results, currently supported case-sensitive
     * choices are:
     *   * `relevance`, only supports descending
     *   * `last_modified_timestamp [asc|desc]`, defaults to descending if not
     *     specified
     * If not specified, defaults to `relevance` descending.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
     * @return string
     */
    public function getOrderBy()
    {
        return $this->order_by;
    }

    /**
     * Specifies the ordering of results, currently supported case-sensitive
     * choices are:
     *   * `relevance`, only supports descending
     *   * `last_modified_timestamp [asc|desc]`, defaults to descending if not
     *     specified
     * If not specified, defaults to `relevance` descending.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
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

