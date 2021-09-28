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

namespace Google\Cloud\Gaming\Allocationendpoint\Tests\Unit\V1alpha;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\Gaming\Allocationendpoint\V1alpha\AllocationEndpointServiceClient;
use Google\Cloud\Gaming\Allocationendpoint\V1alpha\AllocationResponse;
use Google\Rpc\Code;
use stdClass;

/**
 * @group allocationendpoint
 *
 * @group gapic
 */
class AllocationEndpointServiceClientTest extends GeneratedTest
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
     * @return AllocationEndpointServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new AllocationEndpointServiceClient($options);
    }

    /**
     * @test
     */
    public function allocateTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $gameServerName = 'gameServerName-1062836934';
        $address = 'address-1147692044';
        $nodeName = 'nodeName465630888';
        $gameServerClusterName = 'gameServerClusterName-637396641';
        $deploymentName = 'deploymentName2007133125';
        $expectedResponse = new AllocationResponse();
        $expectedResponse->setGameServerName($gameServerName);
        $expectedResponse->setAddress($address);
        $expectedResponse->setNodeName($nodeName);
        $expectedResponse->setGameServerClusterName($gameServerClusterName);
        $expectedResponse->setDeploymentName($deploymentName);
        $transport->addResponse($expectedResponse);
        $response = $client->allocate();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointService/Allocate', $actualFuncCall);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function allocateExceptionTest()
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
        try {
            $client->allocate();
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
