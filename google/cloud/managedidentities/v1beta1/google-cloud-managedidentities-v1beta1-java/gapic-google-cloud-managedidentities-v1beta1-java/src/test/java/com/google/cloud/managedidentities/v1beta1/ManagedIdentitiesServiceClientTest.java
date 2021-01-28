/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.cloud.managedidentities.v1beta1;

import static com.google.cloud.managedidentities.v1beta1.ManagedIdentitiesServiceClient.ListDomainsPagedResponse;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.StatusCode;
import com.google.common.collect.Lists;
import com.google.longrunning.Operation;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Any;
import com.google.protobuf.Empty;
import com.google.protobuf.FieldMask;
import com.google.protobuf.Timestamp;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.UUID;
import java.util.concurrent.ExecutionException;
import javax.annotation.Generated;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@Generated("by gapic-generator-java")
public class ManagedIdentitiesServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private ManagedIdentitiesServiceClient client;
  private static MockManagedIdentitiesService mockManagedIdentitiesService;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockManagedIdentitiesService = new MockManagedIdentitiesService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockManagedIdentitiesService));
    mockServiceHelper.start();
  }

  @AfterClass
  public static void stopServer() {
    mockServiceHelper.stop();
  }

  @Before
  public void setUp() throws IOException {
    mockServiceHelper.reset();
    channelProvider = mockServiceHelper.createChannelProvider();
    ManagedIdentitiesServiceSettings settings =
        ManagedIdentitiesServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = ManagedIdentitiesServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void createMicrosoftAdDomainTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("createMicrosoftAdDomainTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    CreateMicrosoftAdDomainRequest request =
        CreateMicrosoftAdDomainRequest.newBuilder()
            .setParent("parent-995424086")
            .setDomainName("domainName-1244085905")
            .setDomain(Domain.newBuilder().build())
            .build();

    Domain actualResponse = client.createMicrosoftAdDomainAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateMicrosoftAdDomainRequest actualRequest =
        ((CreateMicrosoftAdDomainRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getDomainName(), actualRequest.getDomainName());
    Assert.assertEquals(request.getDomain(), actualRequest.getDomain());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createMicrosoftAdDomainExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      CreateMicrosoftAdDomainRequest request =
          CreateMicrosoftAdDomainRequest.newBuilder()
              .setParent("parent-995424086")
              .setDomainName("domainName-1244085905")
              .setDomain(Domain.newBuilder().build())
              .build();
      client.createMicrosoftAdDomainAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void resetAdminPasswordTest() throws Exception {
    ResetAdminPasswordResponse expectedResponse =
        ResetAdminPasswordResponse.newBuilder().setPassword("password1216985755").build();
    mockManagedIdentitiesService.addResponse(expectedResponse);

    ResetAdminPasswordRequest request =
        ResetAdminPasswordRequest.newBuilder().setName("name3373707").build();

    ResetAdminPasswordResponse actualResponse = client.resetAdminPassword(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ResetAdminPasswordRequest actualRequest = ((ResetAdminPasswordRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void resetAdminPasswordExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      ResetAdminPasswordRequest request =
          ResetAdminPasswordRequest.newBuilder().setName("name3373707").build();
      client.resetAdminPassword(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listDomainsTest() throws Exception {
    Domain responsesElement = Domain.newBuilder().build();
    ListDomainsResponse expectedResponse =
        ListDomainsResponse.newBuilder()
            .setNextPageToken("")
            .addAllDomains(Arrays.asList(responsesElement))
            .build();
    mockManagedIdentitiesService.addResponse(expectedResponse);

    ListDomainsRequest request =
        ListDomainsRequest.newBuilder()
            .setParent("parent-995424086")
            .setPageSize(883849137)
            .setPageToken("pageToken873572522")
            .setFilter("filter-1274492040")
            .setOrderBy("orderBy-1207110587")
            .build();

    ListDomainsPagedResponse pagedListResponse = client.listDomains(request);

    List<Domain> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getDomainsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListDomainsRequest actualRequest = ((ListDomainsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getPageSize(), actualRequest.getPageSize());
    Assert.assertEquals(request.getPageToken(), actualRequest.getPageToken());
    Assert.assertEquals(request.getFilter(), actualRequest.getFilter());
    Assert.assertEquals(request.getOrderBy(), actualRequest.getOrderBy());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listDomainsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      ListDomainsRequest request =
          ListDomainsRequest.newBuilder()
              .setParent("parent-995424086")
              .setPageSize(883849137)
              .setPageToken("pageToken873572522")
              .setFilter("filter-1274492040")
              .setOrderBy("orderBy-1207110587")
              .build();
      client.listDomains(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getDomainTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    mockManagedIdentitiesService.addResponse(expectedResponse);

    GetDomainRequest request = GetDomainRequest.newBuilder().setName("name3373707").build();

    Domain actualResponse = client.getDomain(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetDomainRequest actualRequest = ((GetDomainRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getDomainExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      GetDomainRequest request = GetDomainRequest.newBuilder().setName("name3373707").build();
      client.getDomain(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void updateDomainTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("updateDomainTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    UpdateDomainRequest request =
        UpdateDomainRequest.newBuilder()
            .setUpdateMask(FieldMask.newBuilder().build())
            .setDomain(Domain.newBuilder().build())
            .build();

    Domain actualResponse = client.updateDomainAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UpdateDomainRequest actualRequest = ((UpdateDomainRequest) actualRequests.get(0));

    Assert.assertEquals(request.getUpdateMask(), actualRequest.getUpdateMask());
    Assert.assertEquals(request.getDomain(), actualRequest.getDomain());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updateDomainExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      UpdateDomainRequest request =
          UpdateDomainRequest.newBuilder()
              .setUpdateMask(FieldMask.newBuilder().build())
              .setDomain(Domain.newBuilder().build())
              .build();
      client.updateDomainAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void deleteDomainTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("deleteDomainTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    DeleteDomainRequest request = DeleteDomainRequest.newBuilder().setName("name3373707").build();

    client.deleteDomainAsync(request).get();

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    DeleteDomainRequest actualRequest = ((DeleteDomainRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteDomainExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      DeleteDomainRequest request = DeleteDomainRequest.newBuilder().setName("name3373707").build();
      client.deleteDomainAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void attachTrustTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("attachTrustTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    AttachTrustRequest request =
        AttachTrustRequest.newBuilder()
            .setName("name3373707")
            .setTrust(Trust.newBuilder().build())
            .build();

    Domain actualResponse = client.attachTrustAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AttachTrustRequest actualRequest = ((AttachTrustRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertEquals(request.getTrust(), actualRequest.getTrust());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void attachTrustExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      AttachTrustRequest request =
          AttachTrustRequest.newBuilder()
              .setName("name3373707")
              .setTrust(Trust.newBuilder().build())
              .build();
      client.attachTrustAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void reconfigureTrustTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("reconfigureTrustTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    ReconfigureTrustRequest request =
        ReconfigureTrustRequest.newBuilder()
            .setName("name3373707")
            .setTargetDomainName("targetDomainName2065239520")
            .addAllTargetDnsIpAddresses(new ArrayList<String>())
            .build();

    Domain actualResponse = client.reconfigureTrustAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ReconfigureTrustRequest actualRequest = ((ReconfigureTrustRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertEquals(request.getTargetDomainName(), actualRequest.getTargetDomainName());
    Assert.assertEquals(
        request.getTargetDnsIpAddressesList(), actualRequest.getTargetDnsIpAddressesList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void reconfigureTrustExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      ReconfigureTrustRequest request =
          ReconfigureTrustRequest.newBuilder()
              .setName("name3373707")
              .setTargetDomainName("targetDomainName2065239520")
              .addAllTargetDnsIpAddresses(new ArrayList<String>())
              .build();
      client.reconfigureTrustAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void detachTrustTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("detachTrustTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    DetachTrustRequest request =
        DetachTrustRequest.newBuilder()
            .setName("name3373707")
            .setTrust(Trust.newBuilder().build())
            .build();

    Domain actualResponse = client.detachTrustAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    DetachTrustRequest actualRequest = ((DetachTrustRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertEquals(request.getTrust(), actualRequest.getTrust());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void detachTrustExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      DetachTrustRequest request =
          DetachTrustRequest.newBuilder()
              .setName("name3373707")
              .setTrust(Trust.newBuilder().build())
              .build();
      client.detachTrustAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void validateTrustTest() throws Exception {
    Domain expectedResponse =
        Domain.newBuilder()
            .setName("name3373707")
            .putAllLabels(new HashMap<String, String>())
            .addAllAuthorizedNetworks(new ArrayList<String>())
            .setReservedIpRange("reservedIpRange575015950")
            .addAllLocations(new ArrayList<String>())
            .setAdmin("admin92668751")
            .setFqdn("fqdn3150485")
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setStatusMessage("statusMessage-958704715")
            .addAllTrusts(new ArrayList<Trust>())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("validateTrustTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockManagedIdentitiesService.addResponse(resultOperation);

    ValidateTrustRequest request =
        ValidateTrustRequest.newBuilder()
            .setName("name3373707")
            .setTrust(Trust.newBuilder().build())
            .build();

    Domain actualResponse = client.validateTrustAsync(request).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockManagedIdentitiesService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ValidateTrustRequest actualRequest = ((ValidateTrustRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertEquals(request.getTrust(), actualRequest.getTrust());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void validateTrustExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockManagedIdentitiesService.addException(exception);

    try {
      ValidateTrustRequest request =
          ValidateTrustRequest.newBuilder()
              .setName("name3373707")
              .setTrust(Trust.newBuilder().build())
              .build();
      client.validateTrustAsync(request).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
