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

namespace Google\Cloud\VideoIntelligence\Tests\Unit\V1p3beta1;

use Google\ApiCore\ApiException;

use Google\ApiCore\BidiStream;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\VideoIntelligence\V1p3beta1\StreamingAnnotateVideoRequest;
use Google\Cloud\VideoIntelligence\V1p3beta1\StreamingAnnotateVideoResponse;
use Google\Cloud\VideoIntelligence\V1p3beta1\StreamingVideoIntelligenceServiceClient;
use Google\Rpc\Code;
use stdClass;

/**
 * @group videointelligence
 *
 * @group gapic
 */
class StreamingVideoIntelligenceServiceClientTest extends GeneratedTest
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
     * @return StreamingVideoIntelligenceServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new StreamingVideoIntelligenceServiceClient($options);
    }

    /**
     * @test
     */
    public function streamingAnnotateVideoTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $annotationResultsUri = 'annotationResultsUri-238075757';
        $expectedResponse = new StreamingAnnotateVideoResponse();
        $expectedResponse->setAnnotationResultsUri($annotationResultsUri);
        $transport->addResponse($expectedResponse);
        $annotationResultsUri2 = 'annotationResultsUri2-1157532794';
        $expectedResponse2 = new StreamingAnnotateVideoResponse();
        $expectedResponse2->setAnnotationResultsUri($annotationResultsUri2);
        $transport->addResponse($expectedResponse2);
        $annotationResultsUri3 = 'annotationResultsUri3-1157532793';
        $expectedResponse3 = new StreamingAnnotateVideoResponse();
        $expectedResponse3->setAnnotationResultsUri($annotationResultsUri3);
        $transport->addResponse($expectedResponse3);
        // Mock request
        $request = new StreamingAnnotateVideoRequest();
        $request2 = new StreamingAnnotateVideoRequest();
        $request3 = new StreamingAnnotateVideoRequest();
        $bidi = $client->streamingAnnotateVideo();
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
        $this->assertSame('/google.cloud.videointelligence.v1p3beta1.StreamingVideoIntelligenceService/StreamingAnnotateVideo', $streamFuncCall);
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
    public function streamingAnnotateVideoExceptionTest()
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
        $bidi = $client->streamingAnnotateVideo();
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
