<?php
/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 * GENERATED CODE WARNING
 * This file was automatically generated - do not edit!
 */

namespace Google\Cloud\IdentityToolkit\Tests\Unit\V2;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\IdentityToolkit\V2\AccountManagementServiceClient;
use Google\Cloud\IdentityToolkit\V2\FinalizeMfaEnrollmentResponse;
use Google\Cloud\IdentityToolkit\V2\StartMfaEnrollmentResponse;
use Google\Cloud\IdentityToolkit\V2\WithdrawMfaResponse;
use Google\Rpc\Code;
use stdClass;

/**
 * @group identitytoolkit
 *
 * @group gapic
 */
class AccountManagementServiceClientTest extends GeneratedTest
{
    /**
     * @return TransportInterface
     */
    private function createTransport($deserialize = null)
    {
        return new MockTransport($deserialize);
    }

    /**
     * @return CredentialsWrapper
     */
    private function createCredentials()
    {
        return $this->getMockBuilder(CredentialsWrapper::class)->disableOriginalConstructor()->getMock();
    }

    /**
     * @return AccountManagementServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new AccountManagementServiceClient($options);
    }

    /**
     * @test
     */
    public function finalizeMfaEnrollmentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $idToken2 = 'idToken21698337864';
        $refreshToken = 'refreshToken-1432035435';
        $expectedResponse = new FinalizeMfaEnrollmentResponse();
        $expectedResponse->setIdToken($idToken2);
        $expectedResponse->setRefreshToken($refreshToken);
        $transport->addResponse($expectedResponse);
        // Mock request
        $idToken = 'idToken-302143019';
        $response = $client->finalizeMfaEnrollment($idToken);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.identitytoolkit.v2.AccountManagementService/FinalizeMfaEnrollment', $actualFuncCall);
        $actualValue = $actualRequestObject->getIdToken();
        $this->assertProtobufEquals($idToken, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function finalizeMfaEnrollmentExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';
        $expectedExceptionMessage  = json_encode([
            'message' => 'internal error',
            'code' => Code::DATA_LOSS,
            'status' => 'DATA_LOSS',
            'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);
        // Mock request
        $idToken = 'idToken-302143019';
        try {
            $client->finalizeMfaEnrollment($idToken);
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }
        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startMfaEnrollmentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new StartMfaEnrollmentResponse();
        $transport->addResponse($expectedResponse);
        // Mock request
        $idToken = 'idToken-302143019';
        $response = $client->startMfaEnrollment($idToken);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.identitytoolkit.v2.AccountManagementService/StartMfaEnrollment', $actualFuncCall);
        $actualValue = $actualRequestObject->getIdToken();
        $this->assertProtobufEquals($idToken, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startMfaEnrollmentExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';
        $expectedExceptionMessage  = json_encode([
            'message' => 'internal error',
            'code' => Code::DATA_LOSS,
            'status' => 'DATA_LOSS',
            'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);
        // Mock request
        $idToken = 'idToken-302143019';
        try {
            $client->startMfaEnrollment($idToken);
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }
        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function withdrawMfaTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $idToken2 = 'idToken21698337864';
        $refreshToken = 'refreshToken-1432035435';
        $expectedResponse = new WithdrawMfaResponse();
        $expectedResponse->setIdToken($idToken2);
        $expectedResponse->setRefreshToken($refreshToken);
        $transport->addResponse($expectedResponse);
        // Mock request
        $idToken = 'idToken-302143019';
        $mfaEnrollmentId = 'mfaEnrollmentId1344012831';
        $response = $client->withdrawMfa($idToken, $mfaEnrollmentId);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.identitytoolkit.v2.AccountManagementService/WithdrawMfa', $actualFuncCall);
        $actualValue = $actualRequestObject->getIdToken();
        $this->assertProtobufEquals($idToken, $actualValue);
        $actualValue = $actualRequestObject->getMfaEnrollmentId();
        $this->assertProtobufEquals($mfaEnrollmentId, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function withdrawMfaExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';
        $expectedExceptionMessage  = json_encode([
            'message' => 'internal error',
            'code' => Code::DATA_LOSS,
            'status' => 'DATA_LOSS',
            'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);
        // Mock request
        $idToken = 'idToken-302143019';
        $mfaEnrollmentId = 'mfaEnrollmentId1344012831';
        try {
            $client->withdrawMfa($idToken, $mfaEnrollmentId);
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }
        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }
}
