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

package com.google.home.graph.v1;

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
public class AgentUserPathName implements ResourceName {
  private static final PathTemplate AGENT_USER_PATH =
      PathTemplate.createWithoutUrlEncoding("agentUsers/{agent_user_path=**}");
  private volatile Map<String, String> fieldValuesMap;
  private final String agentUserPath;

  @Deprecated
  protected AgentUserPathName() {
    agentUserPath = null;
  }

  private AgentUserPathName(Builder builder) {
    agentUserPath = Preconditions.checkNotNull(builder.getAgentUserPath());
  }

  public String getAgentUserPath() {
    return agentUserPath;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AgentUserPathName of(String agentUserPath) {
    return newBuilder().setAgentUserPath(agentUserPath).build();
  }

  public static String format(String agentUserPath) {
    return newBuilder().setAgentUserPath(agentUserPath).build().toString();
  }

  public static AgentUserPathName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        AGENT_USER_PATH.validatedMatch(
            formattedString, "AgentUserPathName.parse: formattedString not in valid format");
    return of(matchMap.get("agent_user_path"));
  }

  public static List<AgentUserPathName> parseList(List<String> formattedStrings) {
    List<AgentUserPathName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AgentUserPathName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AgentUserPathName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return AGENT_USER_PATH.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (agentUserPath != null) {
            fieldMapBuilder.put("agent_user_path", agentUserPath);
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
    return AGENT_USER_PATH.instantiate("agent_user_path", agentUserPath);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AgentUserPathName that = ((AgentUserPathName) o);
      return Objects.equals(this.agentUserPath, that.agentUserPath);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(agentUserPath);
    return h;
  }

  /** Builder for agentUsers/{agent_user_path=&#42;&#42;}. */
  public static class Builder {
    private String agentUserPath;

    protected Builder() {}

    public String getAgentUserPath() {
      return agentUserPath;
    }

    public Builder setAgentUserPath(String agentUserPath) {
      this.agentUserPath = agentUserPath;
      return this;
    }

    private Builder(AgentUserPathName agentUserPathName) {
      agentUserPath = agentUserPathName.agentUserPath;
    }

    public AgentUserPathName build() {
      return new AgentUserPathName(this);
    }
  }
}
