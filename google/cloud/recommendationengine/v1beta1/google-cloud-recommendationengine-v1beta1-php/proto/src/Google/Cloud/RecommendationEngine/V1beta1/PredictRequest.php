<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/recommendationengine/v1beta1/prediction_service.proto

namespace Google\Cloud\RecommendationEngine\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for Predict method.
 *
 * Generated from protobuf message <code>google.cloud.recommendationengine.v1beta1.PredictRequest</code>
 */
class PredictRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Full resource name of the format:
     * `{name=projects/&#42;&#47;locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/&#42;}`
     * The id of the recommendation engine placement. This id is used to identify
     * the set of models that will be used to make the prediction.
     * We currently support three placements with the following IDs by default:
     * * `shopping_cart`: Predicts items frequently bought together with one or
     *   more catalog items in the same shopping session. Commonly displayed after
     *   `add-to-cart` events, on product detail pages, or on the shopping cart
     *   page.
     * * `home_page`: Predicts the next product that a user will most likely
     *   engage with or purchase based on the shopping or viewing history of the
     *   specified `userId` or `visitorId`. For example - Recommendations for you.
     * * `product_detail`: Predicts the next product that a user will most likely
     *   engage with or purchase. The prediction is based on the shopping or
     *   viewing history of the specified `userId` or `visitorId` and its
     *   relevance to a specified `CatalogItem`. Typically used on product detail
     *   pages. For example - More items like this.
     * * `recently_viewed_default`: Returns up to 75 items recently viewed by the
     *   specified `userId` or `visitorId`, most recent ones first. Returns
     *   nothing if neither of them has viewed any items yet. For example -
     *   Recently viewed.
     * The full list of available placements can be seen at
     * https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. Context about the user, what they are looking at and what action
     * they took to trigger the predict request. Note that this user event detail
     * won't be ingested to userEvent logs. Thus, a separate userEvent write
     * request is required for event logging.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $user_event = null;
    /**
     * Optional. Maximum number of results to return per page. Set this property
     * to the number of prediction results required. If zero, the service will
     * choose a reasonable default.
     *
     * Generated from protobuf field <code>int32 page_size = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_size = 0;
    /**
     * Optional. The previous PredictResponse.next_page_token.
     *
     * Generated from protobuf field <code>string page_token = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_token = '';
    /**
     * Optional. Filter for restricting prediction results. Accepts values for
     * tags and the `filterOutOfStockItems` flag.
     *  * Tag expressions. Restricts predictions to items that match all of the
     *    specified tags. Boolean operators `OR` and `NOT` are supported if the
     *    expression is enclosed in parentheses, and must be separated from the
     *    tag values by a space. `-"tagA"` is also supported and is equivalent to
     *    `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings
     *    with a size limit of 1 KiB.
     *  * filterOutOfStockItems. Restricts predictions to items that do not have a
     *    stockState value of OUT_OF_STOCK.
     * Examples:
     *  * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional")
     *  * filterOutOfStockItems  tag=(-"promotional")
     *  * filterOutOfStockItems
     *
     * Generated from protobuf field <code>string filter = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $filter = '';
    /**
     * Optional. Use dryRun mode for this prediction query. If set to true, a
     * dummy model will be used that returns arbitrary catalog items.
     * Note that the dryRun mode should only be used for testing the API, or if
     * the model is not ready.
     *
     * Generated from protobuf field <code>bool dry_run = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $dry_run = false;
    /**
     * Optional. Additional domain specific parameters for the predictions.
     * Allowed values:
     * * `returnCatalogItem`: Boolean. If set to true, the associated catalogItem
     *    object will be returned in the
     *   `PredictResponse.PredictionResult.itemMetadata` object in the method
     *    response.
     * * `returnItemScore`: Boolean. If set to true, the prediction 'score'
     *    corresponding to each returned item will be set in the `metadata`
     *    field in the prediction response. The given 'score' indicates the
     *    probability of an item being clicked/purchased given the user's context
     *    and history.
     *
     * Generated from protobuf field <code>map<string, .google.protobuf.Value> params = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $params;
    /**
     * Optional. The labels for the predict request.
     *  * Label keys can contain lowercase letters, digits and hyphens, must start
     *    with a letter, and must end with a letter or digit.
     *  * Non-zero label values can contain lowercase letters, digits and hyphens,
     *    must start with a letter, and must end with a letter or digit.
     *  * No more than 64 labels can be associated with a given request.
     * See https://goo.gl/xmQnxf for more information on and examples of labels.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $labels;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. Full resource name of the format:
     *           `{name=projects/&#42;&#47;locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/&#42;}`
     *           The id of the recommendation engine placement. This id is used to identify
     *           the set of models that will be used to make the prediction.
     *           We currently support three placements with the following IDs by default:
     *           * `shopping_cart`: Predicts items frequently bought together with one or
     *             more catalog items in the same shopping session. Commonly displayed after
     *             `add-to-cart` events, on product detail pages, or on the shopping cart
     *             page.
     *           * `home_page`: Predicts the next product that a user will most likely
     *             engage with or purchase based on the shopping or viewing history of the
     *             specified `userId` or `visitorId`. For example - Recommendations for you.
     *           * `product_detail`: Predicts the next product that a user will most likely
     *             engage with or purchase. The prediction is based on the shopping or
     *             viewing history of the specified `userId` or `visitorId` and its
     *             relevance to a specified `CatalogItem`. Typically used on product detail
     *             pages. For example - More items like this.
     *           * `recently_viewed_default`: Returns up to 75 items recently viewed by the
     *             specified `userId` or `visitorId`, most recent ones first. Returns
     *             nothing if neither of them has viewed any items yet. For example -
     *             Recently viewed.
     *           The full list of available placements can be seen at
     *           https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
     *     @type \Google\Cloud\RecommendationEngine\V1beta1\UserEvent $user_event
     *           Required. Context about the user, what they are looking at and what action
     *           they took to trigger the predict request. Note that this user event detail
     *           won't be ingested to userEvent logs. Thus, a separate userEvent write
     *           request is required for event logging.
     *     @type int $page_size
     *           Optional. Maximum number of results to return per page. Set this property
     *           to the number of prediction results required. If zero, the service will
     *           choose a reasonable default.
     *     @type string $page_token
     *           Optional. The previous PredictResponse.next_page_token.
     *     @type string $filter
     *           Optional. Filter for restricting prediction results. Accepts values for
     *           tags and the `filterOutOfStockItems` flag.
     *            * Tag expressions. Restricts predictions to items that match all of the
     *              specified tags. Boolean operators `OR` and `NOT` are supported if the
     *              expression is enclosed in parentheses, and must be separated from the
     *              tag values by a space. `-"tagA"` is also supported and is equivalent to
     *              `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings
     *              with a size limit of 1 KiB.
     *            * filterOutOfStockItems. Restricts predictions to items that do not have a
     *              stockState value of OUT_OF_STOCK.
     *           Examples:
     *            * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional")
     *            * filterOutOfStockItems  tag=(-"promotional")
     *            * filterOutOfStockItems
     *     @type bool $dry_run
     *           Optional. Use dryRun mode for this prediction query. If set to true, a
     *           dummy model will be used that returns arbitrary catalog items.
     *           Note that the dryRun mode should only be used for testing the API, or if
     *           the model is not ready.
     *     @type array|\Google\Protobuf\Internal\MapField $params
     *           Optional. Additional domain specific parameters for the predictions.
     *           Allowed values:
     *           * `returnCatalogItem`: Boolean. If set to true, the associated catalogItem
     *              object will be returned in the
     *             `PredictResponse.PredictionResult.itemMetadata` object in the method
     *              response.
     *           * `returnItemScore`: Boolean. If set to true, the prediction 'score'
     *              corresponding to each returned item will be set in the `metadata`
     *              field in the prediction response. The given 'score' indicates the
     *              probability of an item being clicked/purchased given the user's context
     *              and history.
     *     @type array|\Google\Protobuf\Internal\MapField $labels
     *           Optional. The labels for the predict request.
     *            * Label keys can contain lowercase letters, digits and hyphens, must start
     *              with a letter, and must end with a letter or digit.
     *            * Non-zero label values can contain lowercase letters, digits and hyphens,
     *              must start with a letter, and must end with a letter or digit.
     *            * No more than 64 labels can be associated with a given request.
     *           See https://goo.gl/xmQnxf for more information on and examples of labels.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Recommendationengine\V1Beta1\PredictionService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Full resource name of the format:
     * `{name=projects/&#42;&#47;locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/&#42;}`
     * The id of the recommendation engine placement. This id is used to identify
     * the set of models that will be used to make the prediction.
     * We currently support three placements with the following IDs by default:
     * * `shopping_cart`: Predicts items frequently bought together with one or
     *   more catalog items in the same shopping session. Commonly displayed after
     *   `add-to-cart` events, on product detail pages, or on the shopping cart
     *   page.
     * * `home_page`: Predicts the next product that a user will most likely
     *   engage with or purchase based on the shopping or viewing history of the
     *   specified `userId` or `visitorId`. For example - Recommendations for you.
     * * `product_detail`: Predicts the next product that a user will most likely
     *   engage with or purchase. The prediction is based on the shopping or
     *   viewing history of the specified `userId` or `visitorId` and its
     *   relevance to a specified `CatalogItem`. Typically used on product detail
     *   pages. For example - More items like this.
     * * `recently_viewed_default`: Returns up to 75 items recently viewed by the
     *   specified `userId` or `visitorId`, most recent ones first. Returns
     *   nothing if neither of them has viewed any items yet. For example -
     *   Recently viewed.
     * The full list of available placements can be seen at
     * https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. Full resource name of the format:
     * `{name=projects/&#42;&#47;locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/&#42;}`
     * The id of the recommendation engine placement. This id is used to identify
     * the set of models that will be used to make the prediction.
     * We currently support three placements with the following IDs by default:
     * * `shopping_cart`: Predicts items frequently bought together with one or
     *   more catalog items in the same shopping session. Commonly displayed after
     *   `add-to-cart` events, on product detail pages, or on the shopping cart
     *   page.
     * * `home_page`: Predicts the next product that a user will most likely
     *   engage with or purchase based on the shopping or viewing history of the
     *   specified `userId` or `visitorId`. For example - Recommendations for you.
     * * `product_detail`: Predicts the next product that a user will most likely
     *   engage with or purchase. The prediction is based on the shopping or
     *   viewing history of the specified `userId` or `visitorId` and its
     *   relevance to a specified `CatalogItem`. Typically used on product detail
     *   pages. For example - More items like this.
     * * `recently_viewed_default`: Returns up to 75 items recently viewed by the
     *   specified `userId` or `visitorId`, most recent ones first. Returns
     *   nothing if neither of them has viewed any items yet. For example -
     *   Recently viewed.
     * The full list of available placements can be seen at
     * https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Required. Context about the user, what they are looking at and what action
     * they took to trigger the predict request. Note that this user event detail
     * won't be ingested to userEvent logs. Thus, a separate userEvent write
     * request is required for event logging.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\RecommendationEngine\V1beta1\UserEvent|null
     */
    public function getUserEvent()
    {
        return isset($this->user_event) ? $this->user_event : null;
    }

    public function hasUserEvent()
    {
        return isset($this->user_event);
    }

    public function clearUserEvent()
    {
        unset($this->user_event);
    }

    /**
     * Required. Context about the user, what they are looking at and what action
     * they took to trigger the predict request. Note that this user event detail
     * won't be ingested to userEvent logs. Thus, a separate userEvent write
     * request is required for event logging.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent user_event = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\RecommendationEngine\V1beta1\UserEvent $var
     * @return $this
     */
    public function setUserEvent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecommendationEngine\V1beta1\UserEvent::class);
        $this->user_event = $var;

        return $this;
    }

    /**
     * Optional. Maximum number of results to return per page. Set this property
     * to the number of prediction results required. If zero, the service will
     * choose a reasonable default.
     *
     * Generated from protobuf field <code>int32 page_size = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Optional. Maximum number of results to return per page. Set this property
     * to the number of prediction results required. If zero, the service will
     * choose a reasonable default.
     *
     * Generated from protobuf field <code>int32 page_size = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
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
     * Optional. The previous PredictResponse.next_page_token.
     *
     * Generated from protobuf field <code>string page_token = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Optional. The previous PredictResponse.next_page_token.
     *
     * Generated from protobuf field <code>string page_token = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
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
     * Optional. Filter for restricting prediction results. Accepts values for
     * tags and the `filterOutOfStockItems` flag.
     *  * Tag expressions. Restricts predictions to items that match all of the
     *    specified tags. Boolean operators `OR` and `NOT` are supported if the
     *    expression is enclosed in parentheses, and must be separated from the
     *    tag values by a space. `-"tagA"` is also supported and is equivalent to
     *    `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings
     *    with a size limit of 1 KiB.
     *  * filterOutOfStockItems. Restricts predictions to items that do not have a
     *    stockState value of OUT_OF_STOCK.
     * Examples:
     *  * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional")
     *  * filterOutOfStockItems  tag=(-"promotional")
     *  * filterOutOfStockItems
     *
     * Generated from protobuf field <code>string filter = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * Optional. Filter for restricting prediction results. Accepts values for
     * tags and the `filterOutOfStockItems` flag.
     *  * Tag expressions. Restricts predictions to items that match all of the
     *    specified tags. Boolean operators `OR` and `NOT` are supported if the
     *    expression is enclosed in parentheses, and must be separated from the
     *    tag values by a space. `-"tagA"` is also supported and is equivalent to
     *    `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings
     *    with a size limit of 1 KiB.
     *  * filterOutOfStockItems. Restricts predictions to items that do not have a
     *    stockState value of OUT_OF_STOCK.
     * Examples:
     *  * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional")
     *  * filterOutOfStockItems  tag=(-"promotional")
     *  * filterOutOfStockItems
     *
     * Generated from protobuf field <code>string filter = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

    /**
     * Optional. Use dryRun mode for this prediction query. If set to true, a
     * dummy model will be used that returns arbitrary catalog items.
     * Note that the dryRun mode should only be used for testing the API, or if
     * the model is not ready.
     *
     * Generated from protobuf field <code>bool dry_run = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return bool
     */
    public function getDryRun()
    {
        return $this->dry_run;
    }

    /**
     * Optional. Use dryRun mode for this prediction query. If set to true, a
     * dummy model will be used that returns arbitrary catalog items.
     * Note that the dryRun mode should only be used for testing the API, or if
     * the model is not ready.
     *
     * Generated from protobuf field <code>bool dry_run = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param bool $var
     * @return $this
     */
    public function setDryRun($var)
    {
        GPBUtil::checkBool($var);
        $this->dry_run = $var;

        return $this;
    }

    /**
     * Optional. Additional domain specific parameters for the predictions.
     * Allowed values:
     * * `returnCatalogItem`: Boolean. If set to true, the associated catalogItem
     *    object will be returned in the
     *   `PredictResponse.PredictionResult.itemMetadata` object in the method
     *    response.
     * * `returnItemScore`: Boolean. If set to true, the prediction 'score'
     *    corresponding to each returned item will be set in the `metadata`
     *    field in the prediction response. The given 'score' indicates the
     *    probability of an item being clicked/purchased given the user's context
     *    and history.
     *
     * Generated from protobuf field <code>map<string, .google.protobuf.Value> params = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getParams()
    {
        return $this->params;
    }

    /**
     * Optional. Additional domain specific parameters for the predictions.
     * Allowed values:
     * * `returnCatalogItem`: Boolean. If set to true, the associated catalogItem
     *    object will be returned in the
     *   `PredictResponse.PredictionResult.itemMetadata` object in the method
     *    response.
     * * `returnItemScore`: Boolean. If set to true, the prediction 'score'
     *    corresponding to each returned item will be set in the `metadata`
     *    field in the prediction response. The given 'score' indicates the
     *    probability of an item being clicked/purchased given the user's context
     *    and history.
     *
     * Generated from protobuf field <code>map<string, .google.protobuf.Value> params = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setParams($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Protobuf\Value::class);
        $this->params = $arr;

        return $this;
    }

    /**
     * Optional. The labels for the predict request.
     *  * Label keys can contain lowercase letters, digits and hyphens, must start
     *    with a letter, and must end with a letter or digit.
     *  * Non-zero label values can contain lowercase letters, digits and hyphens,
     *    must start with a letter, and must end with a letter or digit.
     *  * No more than 64 labels can be associated with a given request.
     * See https://goo.gl/xmQnxf for more information on and examples of labels.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getLabels()
    {
        return $this->labels;
    }

    /**
     * Optional. The labels for the predict request.
     *  * Label keys can contain lowercase letters, digits and hyphens, must start
     *    with a letter, and must end with a letter or digit.
     *  * Non-zero label values can contain lowercase letters, digits and hyphens,
     *    must start with a letter, and must end with a letter or digit.
     *  * No more than 64 labels can be associated with a given request.
     * See https://goo.gl/xmQnxf for more information on and examples of labels.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setLabels($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->labels = $arr;

        return $this;
    }

}

