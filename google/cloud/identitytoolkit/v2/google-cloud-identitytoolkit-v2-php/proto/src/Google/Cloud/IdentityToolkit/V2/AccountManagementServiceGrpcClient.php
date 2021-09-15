<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2021 Google LLC
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
namespace Google\Cloud\IdentityToolkit\V2;

/**
 * Account management for Identity Toolkit
 */
class AccountManagementServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Finishes enrolling a second factor for the user.
     * @param \Google\Cloud\IdentityToolkit\V2\FinalizeMfaEnrollmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FinalizeMfaEnrollment(\Google\Cloud\IdentityToolkit\V2\FinalizeMfaEnrollmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.identitytoolkit.v2.AccountManagementService/FinalizeMfaEnrollment',
        $argument,
        ['\Google\Cloud\IdentityToolkit\V2\FinalizeMfaEnrollmentResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Step one of the MFA enrollment process. In SMS case, this sends an
     * SMS verification code to the user.
     * @param \Google\Cloud\IdentityToolkit\V2\StartMfaEnrollmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartMfaEnrollment(\Google\Cloud\IdentityToolkit\V2\StartMfaEnrollmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.identitytoolkit.v2.AccountManagementService/StartMfaEnrollment',
        $argument,
        ['\Google\Cloud\IdentityToolkit\V2\StartMfaEnrollmentResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Revokes one second factor from the enrolled second factors for an account.
     * @param \Google\Cloud\IdentityToolkit\V2\WithdrawMfaRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function WithdrawMfa(\Google\Cloud\IdentityToolkit\V2\WithdrawMfaRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.identitytoolkit.v2.AccountManagementService/WithdrawMfa',
        $argument,
        ['\Google\Cloud\IdentityToolkit\V2\WithdrawMfaResponse', 'decode'],
        $metadata, $options);
    }

}
