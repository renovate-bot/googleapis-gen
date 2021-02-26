<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/talent/v4beta1/profile_service.proto

namespace Google\Cloud\Talent\V4beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response of SearchProfiles method.
 *
 * Generated from protobuf message <code>google.cloud.talent.v4beta1.SearchProfilesResponse</code>
 */
class SearchProfilesResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * An estimation of the number of profiles that match the specified query.
     * This number isn't guaranteed to be accurate.
     *
     * Generated from protobuf field <code>int64 estimated_total_size = 1;</code>
     */
    protected $estimated_total_size = 0;
    /**
     * The spell checking result, and correction.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.SpellingCorrection spell_correction = 2;</code>
     */
    protected $spell_correction = null;
    /**
     * Additional information for the API invocation, such as the request
     * tracking id.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.ResponseMetadata metadata = 3;</code>
     */
    protected $metadata = null;
    /**
     * A token to retrieve the next page of results. This is empty if there are no
     * more results.
     *
     * Generated from protobuf field <code>string next_page_token = 4;</code>
     */
    protected $next_page_token = '';
    /**
     * The histogram results that match with specified
     * [SearchProfilesRequest.histogram_queries][google.cloud.talent.v4beta1.SearchProfilesRequest.histogram_queries].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.HistogramQueryResult histogram_query_results = 5;</code>
     */
    private $histogram_query_results;
    /**
     * The profile entities that match the specified [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.SummarizedProfile summarized_profiles = 6;</code>
     */
    private $summarized_profiles;
    /**
     * An id that uniquely identifies the result set of a
     * [SearchProfiles][google.cloud.talent.v4beta1.ProfileService.SearchProfiles] call for consistent
     * results.
     *
     * Generated from protobuf field <code>string result_set_id = 7;</code>
     */
    protected $result_set_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int|string $estimated_total_size
     *           An estimation of the number of profiles that match the specified query.
     *           This number isn't guaranteed to be accurate.
     *     @type \Google\Cloud\Talent\V4beta1\SpellingCorrection $spell_correction
     *           The spell checking result, and correction.
     *     @type \Google\Cloud\Talent\V4beta1\ResponseMetadata $metadata
     *           Additional information for the API invocation, such as the request
     *           tracking id.
     *     @type string $next_page_token
     *           A token to retrieve the next page of results. This is empty if there are no
     *           more results.
     *     @type \Google\Cloud\Talent\V4beta1\HistogramQueryResult[]|\Google\Protobuf\Internal\RepeatedField $histogram_query_results
     *           The histogram results that match with specified
     *           [SearchProfilesRequest.histogram_queries][google.cloud.talent.v4beta1.SearchProfilesRequest.histogram_queries].
     *     @type \Google\Cloud\Talent\V4beta1\SummarizedProfile[]|\Google\Protobuf\Internal\RepeatedField $summarized_profiles
     *           The profile entities that match the specified [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest].
     *     @type string $result_set_id
     *           An id that uniquely identifies the result set of a
     *           [SearchProfiles][google.cloud.talent.v4beta1.ProfileService.SearchProfiles] call for consistent
     *           results.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Talent\V4Beta1\ProfileService::initOnce();
        parent::__construct($data);
    }

    /**
     * An estimation of the number of profiles that match the specified query.
     * This number isn't guaranteed to be accurate.
     *
     * Generated from protobuf field <code>int64 estimated_total_size = 1;</code>
     * @return int|string
     */
    public function getEstimatedTotalSize()
    {
        return $this->estimated_total_size;
    }

    /**
     * An estimation of the number of profiles that match the specified query.
     * This number isn't guaranteed to be accurate.
     *
     * Generated from protobuf field <code>int64 estimated_total_size = 1;</code>
     * @param int|string $var
     * @return $this
     */
    public function setEstimatedTotalSize($var)
    {
        GPBUtil::checkInt64($var);
        $this->estimated_total_size = $var;

        return $this;
    }

    /**
     * The spell checking result, and correction.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.SpellingCorrection spell_correction = 2;</code>
     * @return \Google\Cloud\Talent\V4beta1\SpellingCorrection|null
     */
    public function getSpellCorrection()
    {
        return isset($this->spell_correction) ? $this->spell_correction : null;
    }

    public function hasSpellCorrection()
    {
        return isset($this->spell_correction);
    }

    public function clearSpellCorrection()
    {
        unset($this->spell_correction);
    }

    /**
     * The spell checking result, and correction.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.SpellingCorrection spell_correction = 2;</code>
     * @param \Google\Cloud\Talent\V4beta1\SpellingCorrection $var
     * @return $this
     */
    public function setSpellCorrection($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Talent\V4beta1\SpellingCorrection::class);
        $this->spell_correction = $var;

        return $this;
    }

    /**
     * Additional information for the API invocation, such as the request
     * tracking id.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.ResponseMetadata metadata = 3;</code>
     * @return \Google\Cloud\Talent\V4beta1\ResponseMetadata|null
     */
    public function getMetadata()
    {
        return isset($this->metadata) ? $this->metadata : null;
    }

    public function hasMetadata()
    {
        return isset($this->metadata);
    }

    public function clearMetadata()
    {
        unset($this->metadata);
    }

    /**
     * Additional information for the API invocation, such as the request
     * tracking id.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.ResponseMetadata metadata = 3;</code>
     * @param \Google\Cloud\Talent\V4beta1\ResponseMetadata $var
     * @return $this
     */
    public function setMetadata($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Talent\V4beta1\ResponseMetadata::class);
        $this->metadata = $var;

        return $this;
    }

    /**
     * A token to retrieve the next page of results. This is empty if there are no
     * more results.
     *
     * Generated from protobuf field <code>string next_page_token = 4;</code>
     * @return string
     */
    public function getNextPageToken()
    {
        return $this->next_page_token;
    }

    /**
     * A token to retrieve the next page of results. This is empty if there are no
     * more results.
     *
     * Generated from protobuf field <code>string next_page_token = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setNextPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->next_page_token = $var;

        return $this;
    }

    /**
     * The histogram results that match with specified
     * [SearchProfilesRequest.histogram_queries][google.cloud.talent.v4beta1.SearchProfilesRequest.histogram_queries].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.HistogramQueryResult histogram_query_results = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getHistogramQueryResults()
    {
        return $this->histogram_query_results;
    }

    /**
     * The histogram results that match with specified
     * [SearchProfilesRequest.histogram_queries][google.cloud.talent.v4beta1.SearchProfilesRequest.histogram_queries].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.HistogramQueryResult histogram_query_results = 5;</code>
     * @param \Google\Cloud\Talent\V4beta1\HistogramQueryResult[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setHistogramQueryResults($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Talent\V4beta1\HistogramQueryResult::class);
        $this->histogram_query_results = $arr;

        return $this;
    }

    /**
     * The profile entities that match the specified [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.SummarizedProfile summarized_profiles = 6;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getSummarizedProfiles()
    {
        return $this->summarized_profiles;
    }

    /**
     * The profile entities that match the specified [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.SummarizedProfile summarized_profiles = 6;</code>
     * @param \Google\Cloud\Talent\V4beta1\SummarizedProfile[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setSummarizedProfiles($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Talent\V4beta1\SummarizedProfile::class);
        $this->summarized_profiles = $arr;

        return $this;
    }

    /**
     * An id that uniquely identifies the result set of a
     * [SearchProfiles][google.cloud.talent.v4beta1.ProfileService.SearchProfiles] call for consistent
     * results.
     *
     * Generated from protobuf field <code>string result_set_id = 7;</code>
     * @return string
     */
    public function getResultSetId()
    {
        return $this->result_set_id;
    }

    /**
     * An id that uniquely identifies the result set of a
     * [SearchProfiles][google.cloud.talent.v4beta1.ProfileService.SearchProfiles] call for consistent
     * results.
     *
     * Generated from protobuf field <code>string result_set_id = 7;</code>
     * @param string $var
     * @return $this
     */
    public function setResultSetId($var)
    {
        GPBUtil::checkString($var, True);
        $this->result_set_id = $var;

        return $this;
    }

}

