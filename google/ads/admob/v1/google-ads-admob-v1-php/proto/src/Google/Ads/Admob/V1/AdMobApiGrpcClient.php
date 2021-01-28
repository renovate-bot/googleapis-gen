<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
namespace Google\Ads\Admob\V1;

/**
 * The AdMob API allows AdMob publishers programmatically get information about
 * their AdMob account.
 */
class AdMobApiGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets information about the specified AdMob publisher account.
     * @param \Google\Ads\Admob\V1\GetPublisherAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPublisherAccount(\Google\Ads\Admob\V1\GetPublisherAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.ads.admob.v1.AdMobApi/GetPublisherAccount',
        $argument,
        ['\Google\Ads\Admob\V1\PublisherAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     * @param \Google\Ads\Admob\V1\ListPublisherAccountsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPublisherAccounts(\Google\Ads\Admob\V1\ListPublisherAccountsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.ads.admob.v1.AdMobApi/ListPublisherAccounts',
        $argument,
        ['\Google\Ads\Admob\V1\ListPublisherAccountsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Generates an AdMob Network report based on the provided report
     * specification.
     * @param \Google\Ads\Admob\V1\GenerateNetworkReportRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\ServerStreamingCall
     */
    public function GenerateNetworkReport(\Google\Ads\Admob\V1\GenerateNetworkReportRequest $argument,
      $metadata = [], $options = []) {
        return $this->_serverStreamRequest('/google.ads.admob.v1.AdMobApi/GenerateNetworkReport',
        $argument,
        ['\Google\Ads\Admob\V1\GenerateNetworkReportResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Generates an AdMob Mediation report based on the provided report
     * specification.
     * @param \Google\Ads\Admob\V1\GenerateMediationReportRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\ServerStreamingCall
     */
    public function GenerateMediationReport(\Google\Ads\Admob\V1\GenerateMediationReportRequest $argument,
      $metadata = [], $options = []) {
        return $this->_serverStreamRequest('/google.ads.admob.v1.AdMobApi/GenerateMediationReport',
        $argument,
        ['\Google\Ads\Admob\V1\GenerateMediationReportResponse', 'decode'],
        $metadata, $options);
    }

}
