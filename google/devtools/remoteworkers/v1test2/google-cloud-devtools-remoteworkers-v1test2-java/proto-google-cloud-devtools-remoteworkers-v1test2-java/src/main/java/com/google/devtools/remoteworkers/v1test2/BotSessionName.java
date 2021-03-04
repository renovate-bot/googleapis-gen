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

package com.google.devtools.remoteworkers.v1test2;

import com.google.api.pathtemplate.PathTemplate;
import com.google.api.resourcenames.ResourceName;
import com.google.common.base.Preconditions;
import com.google.common.collect.ImmutableMap;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Objects;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
@Generated("by gapic-generator-java")
public class BotSessionName implements ResourceName {
  private static final PathTemplate UNKNOWN_PATH_BOT_SESSION =
      PathTemplate.createWithoutUrlEncoding("{unknown_path=**}/botSessions/{bot_session}");
  private volatile Map<String, String> fieldValuesMap;
  private final String unknownPath;
  private final String botSession;

  @Deprecated
  protected BotSessionName() {
    unknownPath = null;
    botSession = null;
  }

  private BotSessionName(Builder builder) {
    unknownPath = Preconditions.checkNotNull(builder.getUnknownPath());
    botSession = Preconditions.checkNotNull(builder.getBotSession());
  }

  public String getUnknownPath() {
    return unknownPath;
  }

  public String getBotSession() {
    return botSession;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static BotSessionName of(String unknownPath, String botSession) {
    return newBuilder().setUnknownPath(unknownPath).setBotSession(botSession).build();
  }

  public static String format(String unknownPath, String botSession) {
    return newBuilder().setUnknownPath(unknownPath).setBotSession(botSession).build().toString();
  }

  public static BotSessionName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        UNKNOWN_PATH_BOT_SESSION.validatedMatch(
            formattedString, "BotSessionName.parse: formattedString not in valid format");
    return of(matchMap.get("unknown_path"), matchMap.get("bot_session"));
  }

  public static List<BotSessionName> parseList(List<String> formattedStrings) {
    List<BotSessionName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<BotSessionName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (BotSessionName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return UNKNOWN_PATH_BOT_SESSION.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (unknownPath != null) {
            fieldMapBuilder.put("unknown_path", unknownPath);
          }
          if (botSession != null) {
            fieldMapBuilder.put("bot_session", botSession);
          }
          fieldValuesMap = fieldMapBuilder.build();
        }
      }
    }
    return fieldValuesMap;
  }

  public String getFieldValue(String fieldName) {
    return getFieldValuesMap().get(fieldName);
  }

  @Override
  public String toString() {
    return UNKNOWN_PATH_BOT_SESSION.instantiate(
        "unknown_path", unknownPath, "bot_session", botSession);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      BotSessionName that = ((BotSessionName) o);
      return Objects.equals(this.unknownPath, that.unknownPath)
          && Objects.equals(this.botSession, that.botSession);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(unknownPath);
    h *= 1000003;
    h ^= Objects.hashCode(botSession);
    return h;
  }

  /** Builder for {unknown_path=&#42;&#42;}/botSessions/{bot_session}. */
  public static class Builder {
    private String unknownPath;
    private String botSession;

    protected Builder() {}

    public String getUnknownPath() {
      return unknownPath;
    }

    public String getBotSession() {
      return botSession;
    }

    public Builder setUnknownPath(String unknownPath) {
      this.unknownPath = unknownPath;
      return this;
    }

    public Builder setBotSession(String botSession) {
      this.botSession = botSession;
      return this;
    }

    private Builder(BotSessionName botSessionName) {
      unknownPath = botSessionName.unknownPath;
      botSession = botSessionName.botSession;
    }

    public BotSessionName build() {
      return new BotSessionName(this);
    }
  }
}
