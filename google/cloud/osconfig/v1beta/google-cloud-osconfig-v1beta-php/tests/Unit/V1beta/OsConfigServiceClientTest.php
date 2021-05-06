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

declare(strict_types=1);

namespace Google\Cloud\Osconfig\Tests\Unit\V1beta;

use Google\ApiCore\ApiException;

use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;
use Google\ApiCore\Testing\MockTransport;

use Google\Cloud\Osconfig\V1beta\Assignment;
use Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy;
use Google\Cloud\Osconfig\V1beta\GuestPolicy;
use Google\Cloud\Osconfig\V1beta\ListGuestPoliciesResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchJobsResponse;
use Google\Cloud\Osconfig\V1beta\MonthlySchedule;
use Google\Cloud\Osconfig\V1beta\OneTimeSchedule;
use Google\Cloud\Osconfig\V1beta\OsConfigServiceClient;
use Google\Cloud\Osconfig\V1beta\PatchDeployment;
use Google\Cloud\Osconfig\V1beta\PatchInstanceFilter;
use Google\Cloud\Osconfig\V1beta\PatchJob;
use Google\Cloud\Osconfig\V1beta\PatchJobInstanceDetails;
use Google\Cloud\Osconfig\V1beta\RecurringSchedule;
use Google\Cloud\Osconfig\V1beta\RecurringSchedule\Frequency;
use Google\Cloud\Osconfig\V1beta\WeekDayOfMonth;
use Google\Cloud\Osconfig\V1beta\WeeklySchedule;
use Google\Protobuf\GPBEmpty;
use Google\Protobuf\Timestamp;
use Google\Rpc\Code;
use Google\Type\DayOfWeek;
use Google\Type\TimeOfDay;
use Google\Type\TimeZone;
use stdClass;

/**
 * @group osconfig
 *
 * @group gapic
 */
class OsConfigServiceClientTest extends GeneratedTest
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
     * @return OsConfigServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];
        return new OsConfigServiceClient($options);
    }

    /**
     * @test
     */
    public function cancelPatchJobTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name2 = 'name2-1052831874';
        $displayName = 'displayName1615086568';
        $description = 'description-1724546052';
        $dryRun = false;
        $errorMessage = 'errorMessage-1938755376';
        $percentComplete = -1.96096922E8;
        $patchDeployment = 'patchDeployment633565980';
        $expectedResponse = new PatchJob();
        $expectedResponse->setName($name2);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDescription($description);
        $expectedResponse->setDryRun($dryRun);
        $expectedResponse->setErrorMessage($errorMessage);
        $expectedResponse->setPercentComplete($percentComplete);
        $expectedResponse->setPatchDeployment($patchDeployment);
        $transport->addResponse($expectedResponse);
        // Mock request
        $name = 'name3373707';
        $response = $client->cancelPatchJob($name);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/CancelPatchJob', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($name, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function cancelPatchJobExceptionTest()
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
        $name = 'name3373707';
        try {
            $client->cancelPatchJob($name);
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
    public function createGuestPolicyTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name = 'name3373707';
        $description = 'description-1724546052';
        $etag = 'etag3123477';
        $expectedResponse = new GuestPolicy();
        $expectedResponse->setName($name);
        $expectedResponse->setDescription($description);
        $expectedResponse->setEtag($etag);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedParent = $client->projectName('[PROJECT]');
        $guestPolicyId = 'guestPolicyId26354081';
        $guestPolicy = new GuestPolicy();
        $guestPolicyName = 'guestPolicyName1032799957';
        $guestPolicy->setName($guestPolicyName);
        $guestPolicyAssignment = new Assignment();
        $guestPolicy->setAssignment($guestPolicyAssignment);
        $response = $client->createGuestPolicy($formattedParent, $guestPolicyId, $guestPolicy);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/CreateGuestPolicy', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($formattedParent, $actualValue);
        $actualValue = $actualRequestObject->getGuestPolicyId();
        $this->assertProtobufEquals($guestPolicyId, $actualValue);
        $actualValue = $actualRequestObject->getGuestPolicy();
        $this->assertProtobufEquals($guestPolicy, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function createGuestPolicyExceptionTest()
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
        $formattedParent = $client->projectName('[PROJECT]');
        $guestPolicyId = 'guestPolicyId26354081';
        $guestPolicy = new GuestPolicy();
        $guestPolicyName = 'guestPolicyName1032799957';
        $guestPolicy->setName($guestPolicyName);
        $guestPolicyAssignment = new Assignment();
        $guestPolicy->setAssignment($guestPolicyAssignment);
        try {
            $client->createGuestPolicy($formattedParent, $guestPolicyId, $guestPolicy);
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
    public function createPatchDeploymentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name = 'name3373707';
        $description = 'description-1724546052';
        $expectedResponse = new PatchDeployment();
        $expectedResponse->setName($name);
        $expectedResponse->setDescription($description);
        $transport->addResponse($expectedResponse);
        // Mock request
        $parent = 'parent-995424086';
        $patchDeploymentId = 'patchDeploymentId-1817061090';
        $patchDeployment = new PatchDeployment();
        $patchDeploymentInstanceFilter = new PatchInstanceFilter();
        $patchDeployment->setInstanceFilter($patchDeploymentInstanceFilter);
        $patchDeploymentOneTimeSchedule = new OneTimeSchedule();
        $oneTimeScheduleExecuteTime = new Timestamp();
        $patchDeploymentOneTimeSchedule->setExecuteTime($oneTimeScheduleExecuteTime);
        $patchDeployment->setOneTimeSchedule($patchDeploymentOneTimeSchedule);
        $patchDeploymentRecurringSchedule = new RecurringSchedule();
        $recurringScheduleTimeZone = new TimeZone();
        $patchDeploymentRecurringSchedule->setTimeZone($recurringScheduleTimeZone);
        $recurringScheduleTimeOfDay = new TimeOfDay();
        $patchDeploymentRecurringSchedule->setTimeOfDay($recurringScheduleTimeOfDay);
        $recurringScheduleFrequency = Frequency::FREQUENCY_UNSPECIFIED;
        $patchDeploymentRecurringSchedule->setFrequency($recurringScheduleFrequency);
        $recurringScheduleWeekly = new WeeklySchedule();
        $weeklyDayOfWeek = DayOfWeek::DAY_OF_WEEK_UNSPECIFIED;
        $recurringScheduleWeekly->setDayOfWeek($weeklyDayOfWeek);
        $patchDeploymentRecurringSchedule->setWeekly($recurringScheduleWeekly);
        $recurringScheduleMonthly = new MonthlySchedule();
        $monthlyWeekDayOfMonth = new WeekDayOfMonth();
        $weekDayOfMonthWeekOrdinal = 1918414244;
        $monthlyWeekDayOfMonth->setWeekOrdinal($weekDayOfMonthWeekOrdinal);
        $weekDayOfMonthDayOfWeek = DayOfWeek::DAY_OF_WEEK_UNSPECIFIED;
        $monthlyWeekDayOfMonth->setDayOfWeek($weekDayOfMonthDayOfWeek);
        $recurringScheduleMonthly->setWeekDayOfMonth($monthlyWeekDayOfMonth);
        $monthlyMonthDay = 1149931479;
        $recurringScheduleMonthly->setMonthDay($monthlyMonthDay);
        $patchDeploymentRecurringSchedule->setMonthly($recurringScheduleMonthly);
        $patchDeployment->setRecurringSchedule($patchDeploymentRecurringSchedule);
        $response = $client->createPatchDeployment($parent, $patchDeploymentId, $patchDeployment);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/CreatePatchDeployment', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($parent, $actualValue);
        $actualValue = $actualRequestObject->getPatchDeploymentId();
        $this->assertProtobufEquals($patchDeploymentId, $actualValue);
        $actualValue = $actualRequestObject->getPatchDeployment();
        $this->assertProtobufEquals($patchDeployment, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function createPatchDeploymentExceptionTest()
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
        $parent = 'parent-995424086';
        $patchDeploymentId = 'patchDeploymentId-1817061090';
        $patchDeployment = new PatchDeployment();
        $patchDeploymentInstanceFilter = new PatchInstanceFilter();
        $patchDeployment->setInstanceFilter($patchDeploymentInstanceFilter);
        $patchDeploymentOneTimeSchedule = new OneTimeSchedule();
        $oneTimeScheduleExecuteTime = new Timestamp();
        $patchDeploymentOneTimeSchedule->setExecuteTime($oneTimeScheduleExecuteTime);
        $patchDeployment->setOneTimeSchedule($patchDeploymentOneTimeSchedule);
        $patchDeploymentRecurringSchedule = new RecurringSchedule();
        $recurringScheduleTimeZone = new TimeZone();
        $patchDeploymentRecurringSchedule->setTimeZone($recurringScheduleTimeZone);
        $recurringScheduleTimeOfDay = new TimeOfDay();
        $patchDeploymentRecurringSchedule->setTimeOfDay($recurringScheduleTimeOfDay);
        $recurringScheduleFrequency = Frequency::FREQUENCY_UNSPECIFIED;
        $patchDeploymentRecurringSchedule->setFrequency($recurringScheduleFrequency);
        $recurringScheduleWeekly = new WeeklySchedule();
        $weeklyDayOfWeek = DayOfWeek::DAY_OF_WEEK_UNSPECIFIED;
        $recurringScheduleWeekly->setDayOfWeek($weeklyDayOfWeek);
        $patchDeploymentRecurringSchedule->setWeekly($recurringScheduleWeekly);
        $recurringScheduleMonthly = new MonthlySchedule();
        $monthlyWeekDayOfMonth = new WeekDayOfMonth();
        $weekDayOfMonthWeekOrdinal = 1918414244;
        $monthlyWeekDayOfMonth->setWeekOrdinal($weekDayOfMonthWeekOrdinal);
        $weekDayOfMonthDayOfWeek = DayOfWeek::DAY_OF_WEEK_UNSPECIFIED;
        $monthlyWeekDayOfMonth->setDayOfWeek($weekDayOfMonthDayOfWeek);
        $recurringScheduleMonthly->setWeekDayOfMonth($monthlyWeekDayOfMonth);
        $monthlyMonthDay = 1149931479;
        $recurringScheduleMonthly->setMonthDay($monthlyMonthDay);
        $patchDeploymentRecurringSchedule->setMonthly($recurringScheduleMonthly);
        $patchDeployment->setRecurringSchedule($patchDeploymentRecurringSchedule);
        try {
            $client->createPatchDeployment($parent, $patchDeploymentId, $patchDeployment);
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
    public function deleteGuestPolicyTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new GPBEmpty();
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedName = $client->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
        $client->deleteGuestPolicy($formattedName);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/DeleteGuestPolicy', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($formattedName, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deleteGuestPolicyExceptionTest()
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
        $formattedName = $client->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
        try {
            $client->deleteGuestPolicy($formattedName);
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
    public function deletePatchDeploymentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new GPBEmpty();
        $transport->addResponse($expectedResponse);
        // Mock request
        $name = 'name3373707';
        $client->deletePatchDeployment($name);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/DeletePatchDeployment', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($name, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deletePatchDeploymentExceptionTest()
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
        $name = 'name3373707';
        try {
            $client->deletePatchDeployment($name);
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
    public function executePatchJobTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name = 'name3373707';
        $displayName2 = 'displayName21615000987';
        $description2 = 'description2568623279';
        $dryRun2 = true;
        $errorMessage = 'errorMessage-1938755376';
        $percentComplete = -1.96096922E8;
        $patchDeployment = 'patchDeployment633565980';
        $expectedResponse = new PatchJob();
        $expectedResponse->setName($name);
        $expectedResponse->setDisplayName($displayName2);
        $expectedResponse->setDescription($description2);
        $expectedResponse->setDryRun($dryRun2);
        $expectedResponse->setErrorMessage($errorMessage);
        $expectedResponse->setPercentComplete($percentComplete);
        $expectedResponse->setPatchDeployment($patchDeployment);
        $transport->addResponse($expectedResponse);
        // Mock request
        $parent = 'parent-995424086';
        $instanceFilter = new PatchInstanceFilter();
        $response = $client->executePatchJob($parent, $instanceFilter);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/ExecutePatchJob', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($parent, $actualValue);
        $actualValue = $actualRequestObject->getInstanceFilter();
        $this->assertProtobufEquals($instanceFilter, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function executePatchJobExceptionTest()
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
        $parent = 'parent-995424086';
        $instanceFilter = new PatchInstanceFilter();
        try {
            $client->executePatchJob($parent, $instanceFilter);
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
    public function getGuestPolicyTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name2 = 'name2-1052831874';
        $description = 'description-1724546052';
        $etag = 'etag3123477';
        $expectedResponse = new GuestPolicy();
        $expectedResponse->setName($name2);
        $expectedResponse->setDescription($description);
        $expectedResponse->setEtag($etag);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedName = $client->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
        $response = $client->getGuestPolicy($formattedName);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/GetGuestPolicy', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($formattedName, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getGuestPolicyExceptionTest()
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
        $formattedName = $client->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
        try {
            $client->getGuestPolicy($formattedName);
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
    public function getPatchDeploymentTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name2 = 'name2-1052831874';
        $description = 'description-1724546052';
        $expectedResponse = new PatchDeployment();
        $expectedResponse->setName($name2);
        $expectedResponse->setDescription($description);
        $transport->addResponse($expectedResponse);
        // Mock request
        $name = 'name3373707';
        $response = $client->getPatchDeployment($name);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/GetPatchDeployment', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($name, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getPatchDeploymentExceptionTest()
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
        $name = 'name3373707';
        try {
            $client->getPatchDeployment($name);
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
    public function getPatchJobTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name2 = 'name2-1052831874';
        $displayName = 'displayName1615086568';
        $description = 'description-1724546052';
        $dryRun = false;
        $errorMessage = 'errorMessage-1938755376';
        $percentComplete = -1.96096922E8;
        $patchDeployment = 'patchDeployment633565980';
        $expectedResponse = new PatchJob();
        $expectedResponse->setName($name2);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDescription($description);
        $expectedResponse->setDryRun($dryRun);
        $expectedResponse->setErrorMessage($errorMessage);
        $expectedResponse->setPercentComplete($percentComplete);
        $expectedResponse->setPatchDeployment($patchDeployment);
        $transport->addResponse($expectedResponse);
        // Mock request
        $name = 'name3373707';
        $response = $client->getPatchJob($name);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/GetPatchJob', $actualFuncCall);
        $actualValue = $actualRequestObject->getName();
        $this->assertProtobufEquals($name, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getPatchJobExceptionTest()
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
        $name = 'name3373707';
        try {
            $client->getPatchJob($name);
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
    public function listGuestPoliciesTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $nextPageToken = '';
        $guestPoliciesElement = new GuestPolicy();
        $guestPolicies = [
            $guestPoliciesElement,
        ];
        $expectedResponse = new ListGuestPoliciesResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $expectedResponse->setGuestPolicies($guestPolicies);
        $transport->addResponse($expectedResponse);
        // Mock request
        $formattedParent = $client->projectName('[PROJECT]');
        $response = $client->listGuestPolicies($formattedParent);
        $this->assertEquals($expectedResponse, $response->getPage()->getResponseObject());
        $resources = iterator_to_array($response->iterateAllElements());
        $this->assertSame(1, count($resources));
        $this->assertEquals($expectedResponse->getGuestPolicies()[0], $resources[0]);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/ListGuestPolicies', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($formattedParent, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listGuestPoliciesExceptionTest()
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
        $formattedParent = $client->projectName('[PROJECT]');
        try {
            $client->listGuestPolicies($formattedParent);
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
    public function listPatchDeploymentsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $nextPageToken = '';
        $patchDeploymentsElement = new PatchDeployment();
        $patchDeployments = [
            $patchDeploymentsElement,
        ];
        $expectedResponse = new ListPatchDeploymentsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $expectedResponse->setPatchDeployments($patchDeployments);
        $transport->addResponse($expectedResponse);
        // Mock request
        $parent = 'parent-995424086';
        $response = $client->listPatchDeployments($parent);
        $this->assertEquals($expectedResponse, $response->getPage()->getResponseObject());
        $resources = iterator_to_array($response->iterateAllElements());
        $this->assertSame(1, count($resources));
        $this->assertEquals($expectedResponse->getPatchDeployments()[0], $resources[0]);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchDeployments', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($parent, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listPatchDeploymentsExceptionTest()
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
        $parent = 'parent-995424086';
        try {
            $client->listPatchDeployments($parent);
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
    public function listPatchJobInstanceDetailsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $nextPageToken = '';
        $patchJobInstanceDetailsElement = new PatchJobInstanceDetails();
        $patchJobInstanceDetails = [
            $patchJobInstanceDetailsElement,
        ];
        $expectedResponse = new ListPatchJobInstanceDetailsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $expectedResponse->setPatchJobInstanceDetails($patchJobInstanceDetails);
        $transport->addResponse($expectedResponse);
        // Mock request
        $parent = 'parent-995424086';
        $response = $client->listPatchJobInstanceDetails($parent);
        $this->assertEquals($expectedResponse, $response->getPage()->getResponseObject());
        $resources = iterator_to_array($response->iterateAllElements());
        $this->assertSame(1, count($resources));
        $this->assertEquals($expectedResponse->getPatchJobInstanceDetails()[0], $resources[0]);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchJobInstanceDetails', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($parent, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listPatchJobInstanceDetailsExceptionTest()
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
        $parent = 'parent-995424086';
        try {
            $client->listPatchJobInstanceDetails($parent);
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
    public function listPatchJobsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $nextPageToken = '';
        $patchJobsElement = new PatchJob();
        $patchJobs = [
            $patchJobsElement,
        ];
        $expectedResponse = new ListPatchJobsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $expectedResponse->setPatchJobs($patchJobs);
        $transport->addResponse($expectedResponse);
        // Mock request
        $parent = 'parent-995424086';
        $response = $client->listPatchJobs($parent);
        $this->assertEquals($expectedResponse, $response->getPage()->getResponseObject());
        $resources = iterator_to_array($response->iterateAllElements());
        $this->assertSame(1, count($resources));
        $this->assertEquals($expectedResponse->getPatchJobs()[0], $resources[0]);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchJobs', $actualFuncCall);
        $actualValue = $actualRequestObject->getParent();
        $this->assertProtobufEquals($parent, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listPatchJobsExceptionTest()
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
        $parent = 'parent-995424086';
        try {
            $client->listPatchJobs($parent);
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
    public function lookupEffectiveGuestPolicyTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $expectedResponse = new EffectiveGuestPolicy();
        $transport->addResponse($expectedResponse);
        // Mock request
        $instance = 'instance555127957';
        $response = $client->lookupEffectiveGuestPolicy($instance);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/LookupEffectiveGuestPolicy', $actualFuncCall);
        $actualValue = $actualRequestObject->getInstance();
        $this->assertProtobufEquals($instance, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function lookupEffectiveGuestPolicyExceptionTest()
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
        $instance = 'instance555127957';
        try {
            $client->lookupEffectiveGuestPolicy($instance);
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
    public function updateGuestPolicyTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient([
            'transport' => $transport,
        ]);
        $this->assertTrue($transport->isExhausted());
        // Mock response
        $name = 'name3373707';
        $description = 'description-1724546052';
        $etag = 'etag3123477';
        $expectedResponse = new GuestPolicy();
        $expectedResponse->setName($name);
        $expectedResponse->setDescription($description);
        $expectedResponse->setEtag($etag);
        $transport->addResponse($expectedResponse);
        // Mock request
        $guestPolicy = new GuestPolicy();
        $guestPolicyName = 'guestPolicyName1032799957';
        $guestPolicy->setName($guestPolicyName);
        $guestPolicyAssignment = new Assignment();
        $guestPolicy->setAssignment($guestPolicyAssignment);
        $response = $client->updateGuestPolicy($guestPolicy);
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.osconfig.v1beta.OsConfigService/UpdateGuestPolicy', $actualFuncCall);
        $actualValue = $actualRequestObject->getGuestPolicy();
        $this->assertProtobufEquals($guestPolicy, $actualValue);
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function updateGuestPolicyExceptionTest()
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
        $guestPolicy = new GuestPolicy();
        $guestPolicyName = 'guestPolicyName1032799957';
        $guestPolicy->setName($guestPolicyName);
        $guestPolicyAssignment = new Assignment();
        $guestPolicy->setAssignment($guestPolicyAssignment);
        try {
            $client->updateGuestPolicy($guestPolicy);
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
