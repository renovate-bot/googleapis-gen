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

package com.google.ads.admob.v1;

import com.google.ads.admob.v1.AdMobApiGrpc.AdMobApiImplBase;
import com.google.api.core.BetaApi;
import com.google.protobuf.AbstractMessage;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import javax.annotation.Generated;

@BetaApi
@Generated("by gapic-generator-java")
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
      AdMobApiProto.GetPublisherAccountRequest request,
      StreamObserver<AdMobResourcesProto.PublisherAccount> responseObserver) {
    Object response = responses.remove();
    if (response instanceof AdMobResourcesProto.PublisherAccount) {
      requests.add(request);
      responseObserver.onNext(((AdMobResourcesProto.PublisherAccount) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetPublisherAccount, expected %s or %s",
                  response.getClass().getName(),
                  AdMobResourcesProto.PublisherAccount.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void listPublisherAccounts(
      AdMobApiProto.ListPublisherAccountsRequest request,
      StreamObserver<AdMobApiProto.ListPublisherAccountsResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof AdMobApiProto.ListPublisherAccountsResponse) {
      requests.add(request);
      responseObserver.onNext(((AdMobApiProto.ListPublisherAccountsResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListPublisherAccounts, expected %s or %s",
                  response.getClass().getName(),
                  AdMobApiProto.ListPublisherAccountsResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void generateNetworkReport(
      AdMobApiProto.GenerateNetworkReportRequest request,
      StreamObserver<AdMobApiProto.GenerateNetworkReportResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof AdMobApiProto.GenerateNetworkReportResponse) {
      requests.add(request);
      responseObserver.onNext(((AdMobApiProto.GenerateNetworkReportResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GenerateNetworkReport, expected %s or %s",
                  response.getClass().getName(),
                  AdMobApiProto.GenerateNetworkReportResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void generateMediationReport(
      AdMobApiProto.GenerateMediationReportRequest request,
      StreamObserver<AdMobApiProto.GenerateMediationReportResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof AdMobApiProto.GenerateMediationReportResponse) {
      requests.add(request);
      responseObserver.onNext(((AdMobApiProto.GenerateMediationReportResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GenerateMediationReport, expected %s or %s",
                  response.getClass().getName(),
                  AdMobApiProto.GenerateMediationReportResponse.class.getName(),
                  Exception.class.getName())));
    }
  }
}
