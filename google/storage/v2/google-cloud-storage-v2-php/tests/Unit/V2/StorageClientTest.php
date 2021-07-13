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

namespace Google\Storage\Tests\Unit\V2;

use Google\ApiCore\ApiException;

use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\ServerStream;
use Google\ApiCore\Testing\GeneratedTest;

use Google\ApiCore\Testing\MockTransport;
use Google\Rpc\Code;
use Google\Storage\V2\Object;
use Google\Storage\V2\QueryWriteStatusResponse;
use Google\Storage\V2\ReadObjectResponse;
use Google\Storage\V2\StartResumableWriteResponse;
use Google\Storage\V2\StorageClient;
use stdClass;

/**
 * @group storage
 *
 * @group gapic
 */
class StorageClientTest extends GeneratedTest
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
     * @return StorageClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new StorageClient($options);
    }

    /**
     * @test
     */
    public function getObjectTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name = 'name3373707';
        $bucket2 = 'bucket2-1603304675';
        $generation2 = 1722994379;
        $metageneration = 1048558813;
        $storageClass = 'storageClass2035762868';
        $size = 3530753;
        $contentEncoding = 'contentEncoding1916674649';
        $contentDisposition = 'contentDisposition891901169';
        $cacheControl = 'cacheControl1032395168';
        $contentLanguage = 'contentLanguage-1408137122';
        $contentType = 'contentType831846208';
        $componentCount = 485073075;
        $kmsKey = 'kmsKey-591635343';
        $temporaryHold = false;
        $eventBasedHold = true;
        $expectedResponse = new Object();
        $expectedResponse->setName($name);
        $expectedResponse->setBucket($bucket2);
        $expectedResponse->setGeneration($generation2);
        $expectedResponse->setMetageneration($metageneration);
        $expectedResponse->setStorageClass($storageClass);
        $expectedResponse->setSize($size);
        $expectedResponse->setContentEncoding($contentEncoding);
        $expectedResponse->setContentDisposition($contentDisposition);
        $expectedResponse->setCacheControl($cacheControl);
        $expectedResponse->setContentLanguage($contentLanguage);
        $expectedResponse->setContentType($contentType);
        $expectedResponse->setComponentCount($componentCount);
        $expectedResponse->setKmsKey($kmsKey);
        $expectedResponse->setTemporaryHold($temporaryHold);
        $expectedResponse->setEventBasedHold($eventBasedHold);
        $transport->addResponse($expectedResponse);
        // Mock request
        $bucket = 'bucket-1378203158';
        $object = 'object-1023368385';
        $response = $client->getObject($bucket, $object);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.storage.v2.Storage/GetObject', $actualFuncCall);
        $actualValue = $actualRequestObject->getBucket();
        $this->assertProtobufEquals($bucket, $actualValue);
        $actualValue = $actualRequestObject->getObject();
        $this->assertProtobufEquals($object, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getObjectExceptionTest()
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
        $bucket = 'bucket-1378203158';
        $object = 'object-1023368385';
        try {
            $client->getObject($bucket, $object);
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
    public function queryWriteStatusTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $committedSize = 1907158756;
        $expectedResponse = new QueryWriteStatusResponse();
        $expectedResponse->setCommittedSize($committedSize);
        $transport->addResponse($expectedResponse);
        // Mock request
        $uploadId = 'uploadId1239095321';
        $response = $client->queryWriteStatus($uploadId);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.storage.v2.Storage/QueryWriteStatus', $actualFuncCall);
        $actualValue = $actualRequestObject->getUploadId();
        $this->assertProtobufEquals($uploadId, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function queryWriteStatusExceptionTest()
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
        $uploadId = 'uploadId1239095321';
        try {
            $client->queryWriteStatus($uploadId);
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
    public function readObjectTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new ReadObjectResponse();
        $transport->addResponse($expectedResponse);
        $expectedResponse2 = new ReadObjectResponse();
        $transport->addResponse($expectedResponse2);
        $expectedResponse3 = new ReadObjectResponse();
        $transport->addResponse($expectedResponse3);
        // Mock request
        $serverStream = $client->readObject();
        $this->assertInstanceOf(ServerStream::class, $serverStream);
        $responses = iterator_to_array($serverStream->readAll());
        $expectedResponses = [];
        $expectedResponses[] = $expectedResponse;
        $expectedResponses[] = $expectedResponse2;
        $expectedResponses[] = $expectedResponse3;
        $this->assertEquals($expectedResponses, $responses);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.storage.v2.Storage/ReadObject', $actualFuncCall);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function readObjectExceptionTest()
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
        // Mock request
        $serverStream = $client->readObject();
        $results = $serverStream->readAll();
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

    /**
     * @test
     */
    public function startResumableWriteTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $uploadId = 'uploadId1239095321';
        $expectedResponse = new StartResumableWriteResponse();
        $expectedResponse->setUploadId($uploadId);
        $transport->addResponse($expectedResponse);
        $response = $client->startResumableWrite();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.storage.v2.Storage/StartResumableWrite', $actualFuncCall);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startResumableWriteExceptionTest()
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
            $client->startResumableWrite();
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
