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

namespace Google\Cloud\AIPlatform\Tests\Unit\V1beta1;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\AIPlatform\V1beta1\ExplainResponse;
use Google\Cloud\AIPlatform\V1beta1\PredictionServiceClient;
use Google\Cloud\AIPlatform\V1beta1\PredictResponse;
use Google\Rpc\Code;
use stdClass;

/**
 * @group aiplatform
 *
 * @group gapic
 */
class PredictionServiceClientTest extends GeneratedTest
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
     * @return PredictionServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new PredictionServiceClient($options);
    }

    /**
     * @test
     */
    public function explainTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $deployedModelId2 = 'deployedModelId2-380204163';
        $expectedResponse = new ExplainResponse();
        $expectedResponse->setDeployedModelId($deployedModelId2);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedEndpoint = $client->endpointName('[PROJECT]', '[LOCATION]', '[ENDPOINT]');
        $instances = [];
        $response = $client->explain($formattedEndpoint, $instances);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.aiplatform.v1beta1.PredictionService/Explain', $actualFuncCall);
        $actualValue = $actualRequestObject->getEndpoint();
        $this->assertProtobufEquals($formattedEndpoint, $actualValue);
        $actualValue = $actualRequestObject->getInstances();
        $this->assertProtobufEquals($instances, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function explainExceptionTest()
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
        $formattedEndpoint = $client->endpointName('[PROJECT]', '[LOCATION]', '[ENDPOINT]');
        $instances = [];
        try {
            $client->explain($formattedEndpoint, $instances);
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
    public function predictTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $deployedModelId = 'deployedModelId866642506';
        $expectedResponse = new PredictResponse();
        $expectedResponse->setDeployedModelId($deployedModelId);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedEndpoint = $client->endpointName('[PROJECT]', '[LOCATION]', '[ENDPOINT]');
        $instances = [];
        $response = $client->predict($formattedEndpoint, $instances);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.aiplatform.v1beta1.PredictionService/Predict', $actualFuncCall);
        $actualValue = $actualRequestObject->getEndpoint();
        $this->assertProtobufEquals($formattedEndpoint, $actualValue);
        $actualValue = $actualRequestObject->getInstances();
        $this->assertProtobufEquals($instances, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function predictExceptionTest()
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
        $formattedEndpoint = $client->endpointName('[PROJECT]', '[LOCATION]', '[ENDPOINT]');
        $instances = [];
        try {
            $client->predict($formattedEndpoint, $instances);
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
