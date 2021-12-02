/*
 * Copyright 2021 Google LLC
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

package com.google.cloud.networkservices.v1;

import static com.google.cloud.networkservices.v1.NetworkServicesClient.ListEndpointPoliciesPagedResponse;

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
public class NetworkServicesClientTest {
  private static MockNetworkServices mockNetworkServices;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private NetworkServicesClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockNetworkServices = new MockNetworkServices();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockNetworkServices));
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
    NetworkServicesSettings settings =
        NetworkServicesSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = NetworkServicesClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void listEndpointPoliciesTest() throws Exception {
    EndpointPolicy responsesElement = EndpointPolicy.newBuilder().build();
    ListEndpointPoliciesResponse expectedResponse =
        ListEndpointPoliciesResponse.newBuilder()
            .setNextPageToken("")
            .addAllEndpointPolicies(Arrays.asList(responsesElement))
            .build();
    mockNetworkServices.addResponse(expectedResponse);

    LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");

    ListEndpointPoliciesPagedResponse pagedListResponse = client.listEndpointPolicies(parent);

    List<EndpointPolicy> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getEndpointPoliciesList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListEndpointPoliciesRequest actualRequest =
        ((ListEndpointPoliciesRequest) actualRequests.get(0));

    Assert.assertEquals(parent.toString(), actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listEndpointPoliciesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
      client.listEndpointPolicies(parent);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listEndpointPoliciesTest2() throws Exception {
    EndpointPolicy responsesElement = EndpointPolicy.newBuilder().build();
    ListEndpointPoliciesResponse expectedResponse =
        ListEndpointPoliciesResponse.newBuilder()
            .setNextPageToken("")
            .addAllEndpointPolicies(Arrays.asList(responsesElement))
            .build();
    mockNetworkServices.addResponse(expectedResponse);

    String parent = "parent-995424086";

    ListEndpointPoliciesPagedResponse pagedListResponse = client.listEndpointPolicies(parent);

    List<EndpointPolicy> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getEndpointPoliciesList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListEndpointPoliciesRequest actualRequest =
        ((ListEndpointPoliciesRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listEndpointPoliciesExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      String parent = "parent-995424086";
      client.listEndpointPolicies(parent);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getEndpointPolicyTest() throws Exception {
    EndpointPolicy expectedResponse =
        EndpointPolicy.newBuilder()
            .setName(
                EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .putAllLabels(new HashMap<String, String>())
            .setAuthorizationPolicy("authorizationPolicy1042707211")
            .setEndpointMatcher(EndpointMatcher.newBuilder().build())
            .setTrafficPortSelector(TrafficPortSelector.newBuilder().build())
            .setDescription("description-1724546052")
            .setServerTlsPolicy("serverTlsPolicy-1897015798")
            .setClientTlsPolicy("clientTlsPolicy1568516738")
            .build();
    mockNetworkServices.addResponse(expectedResponse);

    EndpointPolicyName name = EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");

    EndpointPolicy actualResponse = client.getEndpointPolicy(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetEndpointPolicyRequest actualRequest = ((GetEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getEndpointPolicyExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      EndpointPolicyName name =
          EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
      client.getEndpointPolicy(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getEndpointPolicyTest2() throws Exception {
    EndpointPolicy expectedResponse =
        EndpointPolicy.newBuilder()
            .setName(
                EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .putAllLabels(new HashMap<String, String>())
            .setAuthorizationPolicy("authorizationPolicy1042707211")
            .setEndpointMatcher(EndpointMatcher.newBuilder().build())
            .setTrafficPortSelector(TrafficPortSelector.newBuilder().build())
            .setDescription("description-1724546052")
            .setServerTlsPolicy("serverTlsPolicy-1897015798")
            .setClientTlsPolicy("clientTlsPolicy1568516738")
            .build();
    mockNetworkServices.addResponse(expectedResponse);

    String name = "name3373707";

    EndpointPolicy actualResponse = client.getEndpointPolicy(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetEndpointPolicyRequest actualRequest = ((GetEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getEndpointPolicyExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      String name = "name3373707";
      client.getEndpointPolicy(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void createEndpointPolicyTest() throws Exception {
    EndpointPolicy expectedResponse =
        EndpointPolicy.newBuilder()
            .setName(
                EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .putAllLabels(new HashMap<String, String>())
            .setAuthorizationPolicy("authorizationPolicy1042707211")
            .setEndpointMatcher(EndpointMatcher.newBuilder().build())
            .setTrafficPortSelector(TrafficPortSelector.newBuilder().build())
            .setDescription("description-1724546052")
            .setServerTlsPolicy("serverTlsPolicy-1897015798")
            .setClientTlsPolicy("clientTlsPolicy1568516738")
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("createEndpointPolicyTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockNetworkServices.addResponse(resultOperation);

    LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
    EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
    String endpointPolicyId = "endpointPolicyId-509458782";

    EndpointPolicy actualResponse =
        client.createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateEndpointPolicyRequest actualRequest =
        ((CreateEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(parent.toString(), actualRequest.getParent());
    Assert.assertEquals(endpointPolicy, actualRequest.getEndpointPolicy());
    Assert.assertEquals(endpointPolicyId, actualRequest.getEndpointPolicyId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createEndpointPolicyExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
      EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
      String endpointPolicyId = "endpointPolicyId-509458782";
      client.createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void createEndpointPolicyTest2() throws Exception {
    EndpointPolicy expectedResponse =
        EndpointPolicy.newBuilder()
            .setName(
                EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .putAllLabels(new HashMap<String, String>())
            .setAuthorizationPolicy("authorizationPolicy1042707211")
            .setEndpointMatcher(EndpointMatcher.newBuilder().build())
            .setTrafficPortSelector(TrafficPortSelector.newBuilder().build())
            .setDescription("description-1724546052")
            .setServerTlsPolicy("serverTlsPolicy-1897015798")
            .setClientTlsPolicy("clientTlsPolicy1568516738")
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("createEndpointPolicyTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockNetworkServices.addResponse(resultOperation);

    String parent = "parent-995424086";
    EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
    String endpointPolicyId = "endpointPolicyId-509458782";

    EndpointPolicy actualResponse =
        client.createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateEndpointPolicyRequest actualRequest =
        ((CreateEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertEquals(endpointPolicy, actualRequest.getEndpointPolicy());
    Assert.assertEquals(endpointPolicyId, actualRequest.getEndpointPolicyId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createEndpointPolicyExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      String parent = "parent-995424086";
      EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
      String endpointPolicyId = "endpointPolicyId-509458782";
      client.createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void updateEndpointPolicyTest() throws Exception {
    EndpointPolicy expectedResponse =
        EndpointPolicy.newBuilder()
            .setName(
                EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .putAllLabels(new HashMap<String, String>())
            .setAuthorizationPolicy("authorizationPolicy1042707211")
            .setEndpointMatcher(EndpointMatcher.newBuilder().build())
            .setTrafficPortSelector(TrafficPortSelector.newBuilder().build())
            .setDescription("description-1724546052")
            .setServerTlsPolicy("serverTlsPolicy-1897015798")
            .setClientTlsPolicy("clientTlsPolicy1568516738")
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("updateEndpointPolicyTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockNetworkServices.addResponse(resultOperation);

    EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
    FieldMask updateMask = FieldMask.newBuilder().build();

    EndpointPolicy actualResponse =
        client.updateEndpointPolicyAsync(endpointPolicy, updateMask).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UpdateEndpointPolicyRequest actualRequest =
        ((UpdateEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(endpointPolicy, actualRequest.getEndpointPolicy());
    Assert.assertEquals(updateMask, actualRequest.getUpdateMask());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updateEndpointPolicyExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
      FieldMask updateMask = FieldMask.newBuilder().build();
      client.updateEndpointPolicyAsync(endpointPolicy, updateMask).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void deleteEndpointPolicyTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("deleteEndpointPolicyTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockNetworkServices.addResponse(resultOperation);

    EndpointPolicyName name = EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");

    client.deleteEndpointPolicyAsync(name).get();

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    DeleteEndpointPolicyRequest actualRequest =
        ((DeleteEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteEndpointPolicyExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      EndpointPolicyName name =
          EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
      client.deleteEndpointPolicyAsync(name).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void deleteEndpointPolicyTest2() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("deleteEndpointPolicyTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockNetworkServices.addResponse(resultOperation);

    String name = "name3373707";

    client.deleteEndpointPolicyAsync(name).get();

    List<AbstractMessage> actualRequests = mockNetworkServices.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    DeleteEndpointPolicyRequest actualRequest =
        ((DeleteEndpointPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteEndpointPolicyExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockNetworkServices.addException(exception);

    try {
      String name = "name3373707";
      client.deleteEndpointPolicyAsync(name).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
