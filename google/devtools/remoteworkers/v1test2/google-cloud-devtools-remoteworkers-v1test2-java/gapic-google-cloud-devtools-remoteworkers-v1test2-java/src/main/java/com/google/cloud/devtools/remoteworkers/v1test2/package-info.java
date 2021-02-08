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

/**
 * The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= BotsClient =======================
 *
 * <p>Service Description: Design doc: https://goo.gl/oojM5H
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
 * <p>Sample for BotsClient:
 *
 * <pre>{@code
 * try (BotsClient botsClient = BotsClient.create()) {
 *   String parent = "parent-995424086";
 *   BotSession botSession = BotSession.newBuilder().build();
 *   BotSession response = botsClient.createBotSession(parent, botSession);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.cloud.devtools.remoteworkers.v1test2;

import javax.annotation.Generated;
