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

package com.google.cloud.devtools.remoteworkers.v1test2;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.devtools.remoteworkers.v1test2.BotSession;
import com.google.devtools.remoteworkers.v1test2.BotSessionName;
import com.google.devtools.remoteworkers.v1test2.BotStatus;
import com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest;
import com.google.devtools.remoteworkers.v1test2.Lease;
import com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest;
import com.google.devtools.remoteworkers.v1test2.Worker;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.FieldMask;
import com.google.protobuf.Timestamp;
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
public class BotsClientTest {
  private static MockBots mockBots;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private BotsClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockBots = new MockBots();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockBots));
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
    BotsSettings settings =
        BotsSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = BotsClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void createBotSessionTest() throws Exception {
    BotSession expectedResponse =
        BotSession.newBuilder()
            .setName(BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString())
            .setBotId("botId93925698")
            .setStatus(BotStatus.forNumber(0))
            .setWorker(Worker.newBuilder().build())
            .addAllLeases(new ArrayList<Lease>())
            .setExpireTime(Timestamp.newBuilder().build())
            .setVersion("version351608024")
            .build();
    mockBots.addResponse(expectedResponse);

    String parent = "parent-995424086";
    BotSession botSession = BotSession.newBuilder().build();

    BotSession actualResponse = client.createBotSession(parent, botSession);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBots.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateBotSessionRequest actualRequest = ((CreateBotSessionRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertEquals(botSession, actualRequest.getBotSession());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createBotSessionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBots.addException(exception);

    try {
      String parent = "parent-995424086";
      BotSession botSession = BotSession.newBuilder().build();
      client.createBotSession(parent, botSession);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void updateBotSessionTest() throws Exception {
    BotSession expectedResponse =
        BotSession.newBuilder()
            .setName(BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString())
            .setBotId("botId93925698")
            .setStatus(BotStatus.forNumber(0))
            .setWorker(Worker.newBuilder().build())
            .addAllLeases(new ArrayList<Lease>())
            .setExpireTime(Timestamp.newBuilder().build())
            .setVersion("version351608024")
            .build();
    mockBots.addResponse(expectedResponse);

    BotSessionName name = BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]");
    BotSession botSession = BotSession.newBuilder().build();
    FieldMask updateMask = FieldMask.newBuilder().build();

    BotSession actualResponse = client.updateBotSession(name, botSession, updateMask);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBots.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UpdateBotSessionRequest actualRequest = ((UpdateBotSessionRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertEquals(botSession, actualRequest.getBotSession());
    Assert.assertEquals(updateMask, actualRequest.getUpdateMask());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updateBotSessionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBots.addException(exception);

    try {
      BotSessionName name = BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]");
      BotSession botSession = BotSession.newBuilder().build();
      FieldMask updateMask = FieldMask.newBuilder().build();
      client.updateBotSession(name, botSession, updateMask);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void updateBotSessionTest2() throws Exception {
    BotSession expectedResponse =
        BotSession.newBuilder()
            .setName(BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString())
            .setBotId("botId93925698")
            .setStatus(BotStatus.forNumber(0))
            .setWorker(Worker.newBuilder().build())
            .addAllLeases(new ArrayList<Lease>())
            .setExpireTime(Timestamp.newBuilder().build())
            .setVersion("version351608024")
            .build();
    mockBots.addResponse(expectedResponse);

    String name = "name3373707";
    BotSession botSession = BotSession.newBuilder().build();
    FieldMask updateMask = FieldMask.newBuilder().build();

    BotSession actualResponse = client.updateBotSession(name, botSession, updateMask);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBots.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UpdateBotSessionRequest actualRequest = ((UpdateBotSessionRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertEquals(botSession, actualRequest.getBotSession());
    Assert.assertEquals(updateMask, actualRequest.getUpdateMask());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updateBotSessionExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBots.addException(exception);

    try {
      String name = "name3373707";
      BotSession botSession = BotSession.newBuilder().build();
      FieldMask updateMask = FieldMask.newBuilder().build();
      client.updateBotSession(name, botSession, updateMask);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
