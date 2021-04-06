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

namespace Google\Cloud\Dialogflow\Cx\Tests\Unit\V3beta1;

use Google\ApiCore\ApiException;

use Google\ApiCore\BidiStream;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\Dialogflow\Cx\V3beta1\DetectIntentResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\FulfillIntentResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\MatchIntentResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\QueryInput;
use Google\Cloud\Dialogflow\Cx\V3beta1\SessionsClient;
use Google\Cloud\Dialogflow\Cx\V3beta1\StreamingDetectIntentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\StreamingDetectIntentResponse;
use Google\Rpc\Code;
use stdClass;

/**
 * @group cx
 *
 * @group gapic
 */
class SessionsClientTest extends GeneratedTest
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
     * @return SessionsClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new SessionsClient($options);
    }

    /**
     * @test
     */
    public function detectIntentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $responseId = 'responseId1847552473';
        $outputAudio = '24';
        $expectedResponse = new DetectIntentResponse();
        $expectedResponse->setResponseId($responseId);
        $expectedResponse->setOutputAudio($outputAudio);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedSession = $client->sessionName('[PROJECT]', '[LOCATION]', '[AGENT]', '[SESSION]');
        $queryInput = new QueryInput();
        $response = $client->detectIntent($formattedSession, $queryInput);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.dialogflow.cx.v3beta1.Sessions/DetectIntent', $actualFuncCall);
        $actualValue = $actualRequestObject->getSession();
        $this->assertProtobufEquals($formattedSession, $actualValue);
        $actualValue = $actualRequestObject->getQueryInput();
        $this->assertProtobufEquals($queryInput, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function detectIntentExceptionTest()
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
        $formattedSession = $client->sessionName('[PROJECT]', '[LOCATION]', '[AGENT]', '[SESSION]');
        $queryInput = new QueryInput();
        try {
            $client->detectIntent($formattedSession, $queryInput);
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
    public function fulfillIntentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $responseId = 'responseId1847552473';
        $outputAudio = '24';
        $expectedResponse = new FulfillIntentResponse();
        $expectedResponse->setResponseId($responseId);
        $expectedResponse->setOutputAudio($outputAudio);
        $transport->addResponse($expectedResponse);
        $response = $client->fulfillIntent();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.dialogflow.cx.v3beta1.Sessions/FulfillIntent', $actualFuncCall);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function fulfillIntentExceptionTest()
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
            $client->fulfillIntent();
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
    public function matchIntentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $text = 'text3556653';
        $expectedResponse = new MatchIntentResponse();
        $expectedResponse->setText($text);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedSession = $client->sessionName('[PROJECT]', '[LOCATION]', '[AGENT]', '[SESSION]');
        $queryInput = new QueryInput();
        $response = $client->matchIntent($formattedSession, $queryInput);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.dialogflow.cx.v3beta1.Sessions/MatchIntent', $actualFuncCall);
        $actualValue = $actualRequestObject->getSession();
        $this->assertProtobufEquals($formattedSession, $actualValue);
        $actualValue = $actualRequestObject->getQueryInput();
        $this->assertProtobufEquals($queryInput, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function matchIntentExceptionTest()
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
        $formattedSession = $client->sessionName('[PROJECT]', '[LOCATION]', '[AGENT]', '[SESSION]');
        $queryInput = new QueryInput();
        try {
            $client->matchIntent($formattedSession, $queryInput);
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
    public function streamingDetectIntentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new StreamingDetectIntentResponse();
        $transport->addResponse($expectedResponse);
        $expectedResponse2 = new StreamingDetectIntentResponse();
        $transport->addResponse($expectedResponse2);
        $expectedResponse3 = new StreamingDetectIntentResponse();
        $transport->addResponse($expectedResponse3);
        // Mock request
        $queryInput = new QueryInput();
        $request = new StreamingDetectIntentRequest();
        $request->setQueryInput($queryInput);
        $queryInput2 = new QueryInput();
        $request2 = new StreamingDetectIntentRequest();
        $request2->setQueryInput($queryInput2);
        $queryInput3 = new QueryInput();
        $request3 = new StreamingDetectIntentRequest();
        $request3->setQueryInput($queryInput3);
        $bidi = $client->streamingDetectIntent();
        $this->assertInstanceOf(BidiStream::class, $bidi);
        $bidi->write($request);
        $responses = [];
        $responses[] = $bidi->read();
        $bidi->writeAll([
            $request2,
            $request3,
        ]);
        foreach ($bidi->closeWriteAndReadAll() as $response) {
            $responses[] = $response;
        }

        $expectedResponses = [];
        $expectedResponses[] = $expectedResponse;
        $expectedResponses[] = $expectedResponse2;
        $expectedResponses[] = $expectedResponse3;
        $this->assertEquals($expectedResponses, $responses);
        $createStreamRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($createStreamRequests));
        $streamFuncCall = $createStreamRequests[0]->getFuncCall();
        $streamRequestObject = $createStreamRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.dialogflow.cx.v3beta1.Sessions/StreamingDetectIntent', $streamFuncCall);
        $this->assertNull($streamRequestObject);
        $callObjects = $transport->popCallObjects();
        $this->assertSame(1, count($callObjects));
        $bidiCall = $callObjects[0];
        $writeRequests = $bidiCall->popReceivedCalls();
        $expectedRequests = [];
        $expectedRequests[] = $request;
        $expectedRequests[] = $request2;
        $expectedRequests[] = $request3;
        $this->assertEquals($expectedRequests, $writeRequests);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function streamingDetectIntentExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';
        $expectedExceptionMessage = json_encode([
            'message' => 'internal error',
            'code' => Code::DATA_LOSS,
            'status' => 'DATA_LOSS',
            'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->setStreamingStatus($status);
        $this->assertTrue($transport->isExhausted());
        $bidi = $client->streamingDetectIntent();
        $results = $bidi->closeWriteAndReadAll();
        try {
            iterator_to_array($results);
            // If the close stream method call did not throw, fail the test
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
