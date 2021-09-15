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
use Google\Cloud\IdentityToolkit\V2\AuthenticationServiceClient;
use Google\Cloud\IdentityToolkit\V2\FinalizeMfaSignInResponse;
use Google\Cloud\IdentityToolkit\V2\StartMfaSignInResponse;
use Google\Rpc\Code;
use stdClass;

/**
 * @group identitytoolkit
 *
 * @group gapic
 */
class AuthenticationServiceClientTest extends GeneratedTest
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
     * @return AuthenticationServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new AuthenticationServiceClient($options);
    }

    /**
     * @test
     */
    public function finalizeMfaSignInTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $idToken = 'idToken-302143019';
        $refreshToken = 'refreshToken-1432035435';
        $expectedResponse = new FinalizeMfaSignInResponse();
        $expectedResponse->setIdToken($idToken);
        $expectedResponse->setRefreshToken($refreshToken);
        $transport->addResponse($expectedResponse);
        // Mock request
        $mfaPendingCredential = 'mfaPendingCredential-1937152074';
        $response = $client->finalizeMfaSignIn($mfaPendingCredential);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.identitytoolkit.v2.AuthenticationService/FinalizeMfaSignIn', $actualFuncCall);
        $actualValue = $actualRequestObject->getMfaPendingCredential();
        $this->assertProtobufEquals($mfaPendingCredential, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function finalizeMfaSignInExceptionTest()
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
        $mfaPendingCredential = 'mfaPendingCredential-1937152074';
        try {
            $client->finalizeMfaSignIn($mfaPendingCredential);
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
    public function startMfaSignInTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new StartMfaSignInResponse();
        $transport->addResponse($expectedResponse);
        // Mock request
        $mfaPendingCredential = 'mfaPendingCredential-1937152074';
        $mfaEnrollmentId = 'mfaEnrollmentId1344012831';
        $response = $client->startMfaSignIn($mfaPendingCredential, $mfaEnrollmentId);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.identitytoolkit.v2.AuthenticationService/StartMfaSignIn', $actualFuncCall);
        $actualValue = $actualRequestObject->getMfaPendingCredential();
        $this->assertProtobufEquals($mfaPendingCredential, $actualValue);
        $actualValue = $actualRequestObject->getMfaEnrollmentId();
        $this->assertProtobufEquals($mfaEnrollmentId, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startMfaSignInExceptionTest()
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
        $mfaPendingCredential = 'mfaPendingCredential-1937152074';
        $mfaEnrollmentId = 'mfaEnrollmentId1344012831';
        try {
            $client->startMfaSignIn($mfaPendingCredential, $mfaEnrollmentId);
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
