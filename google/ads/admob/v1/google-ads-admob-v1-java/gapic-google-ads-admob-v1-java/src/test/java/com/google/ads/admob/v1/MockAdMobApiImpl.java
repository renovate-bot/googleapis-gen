/*
 * Copyright 2020 Google LLC
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
package com.google.ads.admob.v1;

import com.google.ads.admob.v1.AdMobApiGrpc.AdMobApiImplBase;
import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse;
import com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount;
import com.google.api.core.BetaApi;
import com.google.protobuf.AbstractMessage;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

@javax.annotation.Generated("by GAPIC")
@BetaApi
public class MockAdMobApiImpl extends AdMobApiImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockAdMobApiImpl() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  public List<AbstractMessage> getRequests() {
    return requests;
  }

  public void addResponse(AbstractMessage response) {
    responses.add(response);
  }

  public void setResponses(List<AbstractMessage> responses) {
    this.responses = new LinkedList<Object>(responses);
  }

  public void addException(Exception exception) {
    responses.add(exception);
  }

  public void reset() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  @Override
  public void getPublisherAccount(
      GetPublisherAccountRequest request, StreamObserver<PublisherAccount> responseObserver) {
    Object response = responses.remove();
    if (response instanceof PublisherAccount) {
      requests.add(request);
      responseObserver.onNext((PublisherAccount) response);
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError((Exception) response);
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void listPublisherAccounts(
      ListPublisherAccountsRequest request,
      StreamObserver<ListPublisherAccountsResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ListPublisherAccountsResponse) {
      requests.add(request);
      responseObserver.onNext((ListPublisherAccountsResponse) response);
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError((Exception) response);
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void generateNetworkReport(
      GenerateNetworkReportRequest request,
      StreamObserver<GenerateNetworkReportResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof GenerateNetworkReportResponse) {
      requests.add(request);
      responseObserver.onNext((GenerateNetworkReportResponse) response);
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError((Exception) response);
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void generateMediationReport(
      GenerateMediationReportRequest request,
      StreamObserver<GenerateMediationReportResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof GenerateMediationReportResponse) {
      requests.add(request);
      responseObserver.onNext((GenerateMediationReportResponse) response);
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError((Exception) response);
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }
}
