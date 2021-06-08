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

package com.google.home.enterprise.sdm.v1;

import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListDevicesPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListRoomsPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListStructuresPagedResponse;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.common.collect.Lists;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Struct;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;
import javax.annotation.Generated;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@Generated("by gapic-generator-java")
public class SmartDeviceManagementServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockSmartDeviceManagementService mockSmartDeviceManagementService;
  private LocalChannelProvider channelProvider;
  private SmartDeviceManagementServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockSmartDeviceManagementService = new MockSmartDeviceManagementService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockSmartDeviceManagementService));
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
    SmartDeviceManagementServiceSettings settings =
        SmartDeviceManagementServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = SmartDeviceManagementServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getDeviceTest() throws Exception {
    Device expectedResponse =
        Device.newBuilder()
            .setName(DeviceName.of("[ENTERPRISE]", "[DEVICE]").toString())
            .setType("type3575610")
            .setTraits(Struct.newBuilder().build())
            .addAllParentRelations(new ArrayList<ParentRelation>())
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();

    Device actualResponse = client.getDevice(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetDeviceRequest actualRequest = ((GetDeviceRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getDeviceExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();
      client.getDevice(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listDevicesTest() throws Exception {
    Device responsesElement = Device.newBuilder().build();
    ListDevicesResponse expectedResponse =
        ListDevicesResponse.newBuilder()
            .setNextPageToken("")
            .addAllDevices(Arrays.asList(responsesElement))
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    ListDevicesRequest request =
        ListDevicesRequest.newBuilder()
            .setParent("parent-995424086")
            .setPageSize(883849137)
            .setPageToken("pageToken873572522")
            .setFilter("filter-1274492040")
            .build();

    ListDevicesPagedResponse pagedListResponse = client.listDevices(request);

    List<Device> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getDevicesList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListDevicesRequest actualRequest = ((ListDevicesRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getPageSize(), actualRequest.getPageSize());
    Assert.assertEquals(request.getPageToken(), actualRequest.getPageToken());
    Assert.assertEquals(request.getFilter(), actualRequest.getFilter());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listDevicesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      ListDevicesRequest request =
          ListDevicesRequest.newBuilder()
              .setParent("parent-995424086")
              .setPageSize(883849137)
              .setPageToken("pageToken873572522")
              .setFilter("filter-1274492040")
              .build();
      client.listDevices(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void executeDeviceCommandTest() throws Exception {
    ExecuteDeviceCommandResponse expectedResponse =
        ExecuteDeviceCommandResponse.newBuilder().setResults(Struct.newBuilder().build()).build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    ExecuteDeviceCommandRequest request =
        ExecuteDeviceCommandRequest.newBuilder()
            .setName("name3373707")
            .setCommand("command950394699")
            .setParams(Struct.newBuilder().build())
            .build();

    ExecuteDeviceCommandResponse actualResponse = client.executeDeviceCommand(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ExecuteDeviceCommandRequest actualRequest =
        ((ExecuteDeviceCommandRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertEquals(request.getCommand(), actualRequest.getCommand());
    Assert.assertEquals(request.getParams(), actualRequest.getParams());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void executeDeviceCommandExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      ExecuteDeviceCommandRequest request =
          ExecuteDeviceCommandRequest.newBuilder()
              .setName("name3373707")
              .setCommand("command950394699")
              .setParams(Struct.newBuilder().build())
              .build();
      client.executeDeviceCommand(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getStructureTest() throws Exception {
    Structure expectedResponse =
        Structure.newBuilder()
            .setName(StructureName.of("[ENTERPRISE]", "[STRUCTURE]").toString())
            .setTraits(Struct.newBuilder().build())
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    GetStructureRequest request = GetStructureRequest.newBuilder().setName("name3373707").build();

    Structure actualResponse = client.getStructure(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetStructureRequest actualRequest = ((GetStructureRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getStructureExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      GetStructureRequest request = GetStructureRequest.newBuilder().setName("name3373707").build();
      client.getStructure(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listStructuresTest() throws Exception {
    Structure responsesElement = Structure.newBuilder().build();
    ListStructuresResponse expectedResponse =
        ListStructuresResponse.newBuilder()
            .setNextPageToken("")
            .addAllStructures(Arrays.asList(responsesElement))
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    ListStructuresRequest request =
        ListStructuresRequest.newBuilder()
            .setParent("parent-995424086")
            .setPageSize(883849137)
            .setPageToken("pageToken873572522")
            .setFilter("filter-1274492040")
            .build();

    ListStructuresPagedResponse pagedListResponse = client.listStructures(request);

    List<Structure> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getStructuresList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListStructuresRequest actualRequest = ((ListStructuresRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getPageSize(), actualRequest.getPageSize());
    Assert.assertEquals(request.getPageToken(), actualRequest.getPageToken());
    Assert.assertEquals(request.getFilter(), actualRequest.getFilter());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listStructuresExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      ListStructuresRequest request =
          ListStructuresRequest.newBuilder()
              .setParent("parent-995424086")
              .setPageSize(883849137)
              .setPageToken("pageToken873572522")
              .setFilter("filter-1274492040")
              .build();
      client.listStructures(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getRoomTest() throws Exception {
    Room expectedResponse =
        Room.newBuilder()
            .setName(RoomName.of("[ENTERPRISE]", "[STRUCTURE]", "[ROOM]").toString())
            .setTraits(Struct.newBuilder().build())
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    GetRoomRequest request = GetRoomRequest.newBuilder().setName("name3373707").build();

    Room actualResponse = client.getRoom(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetRoomRequest actualRequest = ((GetRoomRequest) actualRequests.get(0));

    Assert.assertEquals(request.getName(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getRoomExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      GetRoomRequest request = GetRoomRequest.newBuilder().setName("name3373707").build();
      client.getRoom(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listRoomsTest() throws Exception {
    Room responsesElement = Room.newBuilder().build();
    ListRoomsResponse expectedResponse =
        ListRoomsResponse.newBuilder()
            .setNextPageToken("")
            .addAllRooms(Arrays.asList(responsesElement))
            .build();
    mockSmartDeviceManagementService.addResponse(expectedResponse);

    ListRoomsRequest request =
        ListRoomsRequest.newBuilder()
            .setParent("parent-995424086")
            .setPageSize(883849137)
            .setPageToken("pageToken873572522")
            .build();

    ListRoomsPagedResponse pagedListResponse = client.listRooms(request);

    List<Room> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getRoomsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockSmartDeviceManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListRoomsRequest actualRequest = ((ListRoomsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getPageSize(), actualRequest.getPageSize());
    Assert.assertEquals(request.getPageToken(), actualRequest.getPageToken());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listRoomsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockSmartDeviceManagementService.addException(exception);

    try {
      ListRoomsRequest request =
          ListRoomsRequest.newBuilder()
              .setParent("parent-995424086")
              .setPageSize(883849137)
              .setPageToken("pageToken873572522")
              .build();
      client.listRooms(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
