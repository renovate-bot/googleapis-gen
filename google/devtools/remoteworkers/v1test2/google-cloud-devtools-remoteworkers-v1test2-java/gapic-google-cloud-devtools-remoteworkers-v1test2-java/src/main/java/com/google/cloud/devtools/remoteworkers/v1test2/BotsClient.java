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

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.devtools.remoteworkers.v1test2.stub.BotsStub;
import com.google.cloud.devtools.remoteworkers.v1test2.stub.BotsStubSettings;
import com.google.devtools.remoteworkers.v1test2.BotSession;
import com.google.devtools.remoteworkers.v1test2.BotSessionName;
import com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest;
import com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Design doc: https://goo.gl/oojM5H
 *
 * <p>Loosely speaking, the Bots interface monitors a collection of workers (think of them as
 * "computers" for a moment). This collection is known as a "farm," and its purpose is to perform
 * work on behalf of a client.
 *
 * <p>Each worker runs a small program known as a "bot" that allows it to be controlled by the
 * server. This interface contains only methods that are called by the bots themselves; admin
 * functionality is out of scope for this interface.
 *
 * <p>More precisely, we use the term "worker" to refer to the physical "thing" running the bot. We
 * use the term "worker," and not "machine" or "computer," since a worker may consist of more than
 * one machine - e.g., a computer with multiple attached devices, or even a cluster of computers,
 * with only one of them running the bot. Conversely, a single machine may host several bots, in
 * which case each bot has a "worker" corresponding to the slice of the machine being managed by
 * that bot.
 *
 * <p>The main resource in the Bots interface is not, surprisingly, a Bot - it is a BotSession,
 * which represents a period of time in which a bot is in continuous contact with the server (see
 * the BotSession message for more information). The parent of a bot session can be thought of as an
 * instance of a farm. That is, one endpoint may be able to manage many farms for many users. For
 * example, for a farm managed through GCP, the parent resource will typically take the form
 * "projects/{project_id}". This is referred to below as "the farm resource."
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (BotsClient botsClient = BotsClient.create()) {
 *   String parent = "parent-995424086";
 *   BotSession botSession = BotSession.newBuilder().build();
 *   BotSession response = botsClient.createBotSession(parent, botSession);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the BotsClient object to clean up resources such as
 * threads. In the example above, try-with-resources is used, which automatically calls close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li>A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li>A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li>A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of BotsSettings to create(). For
 * example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * BotsSettings botsSettings =
 *     BotsSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * BotsClient botsClient = BotsClient.create(botsSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * BotsSettings botsSettings = BotsSettings.newBuilder().setEndpoint(myEndpoint).build();
 * BotsClient botsClient = BotsClient.create(botsSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class BotsClient implements BackgroundResource {
  private final BotsSettings settings;
  private final BotsStub stub;

  /** Constructs an instance of BotsClient with default settings. */
  public static final BotsClient create() throws IOException {
    return create(BotsSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of BotsClient, using the given settings. The channels are created based
   * on the settings passed in, or defaults for any settings that are not set.
   */
  public static final BotsClient create(BotsSettings settings) throws IOException {
    return new BotsClient(settings);
  }

  /**
   * Constructs an instance of BotsClient, using the given stub for making calls. This is for
   * advanced usage - prefer using create(BotsSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final BotsClient create(BotsStub stub) {
    return new BotsClient(stub);
  }

  /**
   * Constructs an instance of BotsClient, using the given settings. This is protected so that it is
   * easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected BotsClient(BotsSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((BotsStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected BotsClient(BotsStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final BotsSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public BotsStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * CreateBotSession is called when the bot first joins the farm, and establishes a session ID to
   * ensure that multiple machines do not register using the same name accidentally.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   String parent = "parent-995424086";
   *   BotSession botSession = BotSession.newBuilder().build();
   *   BotSession response = botsClient.createBotSession(parent, botSession);
   * }
   * }</pre>
   *
   * @param parent Required. The farm resource.
   * @param botSession Required. The bot session to create. Server-assigned fields like name must be
   *     unset.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final BotSession createBotSession(String parent, BotSession botSession) {
    CreateBotSessionRequest request =
        CreateBotSessionRequest.newBuilder().setParent(parent).setBotSession(botSession).build();
    return createBotSession(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * CreateBotSession is called when the bot first joins the farm, and establishes a session ID to
   * ensure that multiple machines do not register using the same name accidentally.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   CreateBotSessionRequest request =
   *       CreateBotSessionRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setBotSession(BotSession.newBuilder().build())
   *           .build();
   *   BotSession response = botsClient.createBotSession(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final BotSession createBotSession(CreateBotSessionRequest request) {
    return createBotSessionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * CreateBotSession is called when the bot first joins the farm, and establishes a session ID to
   * ensure that multiple machines do not register using the same name accidentally.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   CreateBotSessionRequest request =
   *       CreateBotSessionRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setBotSession(BotSession.newBuilder().build())
   *           .build();
   *   ApiFuture<BotSession> future = botsClient.createBotSessionCallable().futureCall(request);
   *   // Do something.
   *   BotSession response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<CreateBotSessionRequest, BotSession> createBotSessionCallable() {
    return stub.createBotSessionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * UpdateBotSession must be called periodically by the bot (on a schedule determined by the
   * server) to let the server know about its status, and to pick up new lease requests from the
   * server.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   BotSessionName name = BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]");
   *   BotSession botSession = BotSession.newBuilder().build();
   *   FieldMask updateMask = FieldMask.newBuilder().build();
   *   BotSession response = botsClient.updateBotSession(name, botSession, updateMask);
   * }
   * }</pre>
   *
   * @param name Required. The bot session name. Must match bot_session.name.
   * @param botSession Required. The bot session resource to update.
   * @param updateMask Required. The fields on the bot that should be updated. See the BotSession
   *     resource for which fields are updatable by which caller.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final BotSession updateBotSession(
      BotSessionName name, BotSession botSession, FieldMask updateMask) {
    UpdateBotSessionRequest request =
        UpdateBotSessionRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setBotSession(botSession)
            .setUpdateMask(updateMask)
            .build();
    return updateBotSession(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * UpdateBotSession must be called periodically by the bot (on a schedule determined by the
   * server) to let the server know about its status, and to pick up new lease requests from the
   * server.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   String name = BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString();
   *   BotSession botSession = BotSession.newBuilder().build();
   *   FieldMask updateMask = FieldMask.newBuilder().build();
   *   BotSession response = botsClient.updateBotSession(name, botSession, updateMask);
   * }
   * }</pre>
   *
   * @param name Required. The bot session name. Must match bot_session.name.
   * @param botSession Required. The bot session resource to update.
   * @param updateMask Required. The fields on the bot that should be updated. See the BotSession
   *     resource for which fields are updatable by which caller.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final BotSession updateBotSession(
      String name, BotSession botSession, FieldMask updateMask) {
    UpdateBotSessionRequest request =
        UpdateBotSessionRequest.newBuilder()
            .setName(name)
            .setBotSession(botSession)
            .setUpdateMask(updateMask)
            .build();
    return updateBotSession(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * UpdateBotSession must be called periodically by the bot (on a schedule determined by the
   * server) to let the server know about its status, and to pick up new lease requests from the
   * server.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   UpdateBotSessionRequest request =
   *       UpdateBotSessionRequest.newBuilder()
   *           .setName(BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString())
   *           .setBotSession(BotSession.newBuilder().build())
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .build();
   *   BotSession response = botsClient.updateBotSession(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final BotSession updateBotSession(UpdateBotSessionRequest request) {
    return updateBotSessionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * UpdateBotSession must be called periodically by the bot (on a schedule determined by the
   * server) to let the server know about its status, and to pick up new lease requests from the
   * server.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (BotsClient botsClient = BotsClient.create()) {
   *   UpdateBotSessionRequest request =
   *       UpdateBotSessionRequest.newBuilder()
   *           .setName(BotSessionName.of("[UNKNOWN_PATH]", "[BOT_SESSION]").toString())
   *           .setBotSession(BotSession.newBuilder().build())
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .build();
   *   ApiFuture<BotSession> future = botsClient.updateBotSessionCallable().futureCall(request);
   *   // Do something.
   *   BotSession response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<UpdateBotSessionRequest, BotSession> updateBotSessionCallable() {
    return stub.updateBotSessionCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }
}
