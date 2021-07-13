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

package com.google.storage.v2;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.grpc.testing.MockStreamObserver;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ApiStreamObserver;
import com.google.api.gax.rpc.ClientStreamingCallable;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.StatusCode;
import com.google.protobuf.AbstractMessage;
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
public class StorageClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockStorage mockStorage;
  private LocalChannelProvider channelProvider;
  private StorageClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockStorage = new MockStorage();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockStorage));
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
    StorageSettings settings =
        StorageSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = StorageClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getObjectTest() throws Exception {
    Object expectedResponse =
        Object.newBuilder()
            .setName("name3373707")
            .setBucket(BucketName.of("[PROJECT]", "[BUCKET]").toString())
            .setGeneration(305703192)
            .setMetageneration(1048558813)
            .setStorageClass("storageClass871353277")
            .setSize(3530753)
            .setContentEncoding("contentEncoding-160088852")
            .setContentDisposition("contentDisposition1034341758")
            .setCacheControl("cacheControl-1336592517")
            .addAllAcl(new ArrayList<ObjectAccessControl>())
            .setContentLanguage("contentLanguage810066673")
            .setDeleteTime(Timestamp.newBuilder().build())
            .setContentType("contentType-389131437")
            .setCreateTime(Timestamp.newBuilder().build())
            .setComponentCount(-485073075)
            .setChecksums(ObjectChecksums.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setKmsKey(
                CryptoKeyName.of("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]")
                    .toString())
            .setUpdateStorageClassTime(Timestamp.newBuilder().build())
            .setTemporaryHold(true)
            .setRetentionExpireTime(Timestamp.newBuilder().build())
            .putAllMetadata(new HashMap<String, String>())
            .setEventBasedHold(true)
            .setOwner(Owner.newBuilder().build())
            .setCustomerEncryption(Object.CustomerEncryption.newBuilder().build())
            .setCustomTime(Timestamp.newBuilder().build())
            .build();
    mockStorage.addResponse(expectedResponse);

    String bucket = "bucket-1378203158";
    String object = "object-1023368385";

    Object actualResponse = client.getObject(bucket, object);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStorage.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetObjectRequest actualRequest = ((GetObjectRequest) actualRequests.get(0));

    Assert.assertEquals(bucket, actualRequest.getBucket());
    Assert.assertEquals(object, actualRequest.getObject());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getObjectExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);

    try {
      String bucket = "bucket-1378203158";
      String object = "object-1023368385";
      client.getObject(bucket, object);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getObjectTest2() throws Exception {
    Object expectedResponse =
        Object.newBuilder()
            .setName("name3373707")
            .setBucket(BucketName.of("[PROJECT]", "[BUCKET]").toString())
            .setGeneration(305703192)
            .setMetageneration(1048558813)
            .setStorageClass("storageClass871353277")
            .setSize(3530753)
            .setContentEncoding("contentEncoding-160088852")
            .setContentDisposition("contentDisposition1034341758")
            .setCacheControl("cacheControl-1336592517")
            .addAllAcl(new ArrayList<ObjectAccessControl>())
            .setContentLanguage("contentLanguage810066673")
            .setDeleteTime(Timestamp.newBuilder().build())
            .setContentType("contentType-389131437")
            .setCreateTime(Timestamp.newBuilder().build())
            .setComponentCount(-485073075)
            .setChecksums(ObjectChecksums.newBuilder().build())
            .setUpdateTime(Timestamp.newBuilder().build())
            .setKmsKey(
                CryptoKeyName.of("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]")
                    .toString())
            .setUpdateStorageClassTime(Timestamp.newBuilder().build())
            .setTemporaryHold(true)
            .setRetentionExpireTime(Timestamp.newBuilder().build())
            .putAllMetadata(new HashMap<String, String>())
            .setEventBasedHold(true)
            .setOwner(Owner.newBuilder().build())
            .setCustomerEncryption(Object.CustomerEncryption.newBuilder().build())
            .setCustomTime(Timestamp.newBuilder().build())
            .build();
    mockStorage.addResponse(expectedResponse);

    String bucket = "bucket-1378203158";
    String object = "object-1023368385";
    long generation = 305703192;

    Object actualResponse = client.getObject(bucket, object, generation);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStorage.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetObjectRequest actualRequest = ((GetObjectRequest) actualRequests.get(0));

    Assert.assertEquals(bucket, actualRequest.getBucket());
    Assert.assertEquals(object, actualRequest.getObject());
    Assert.assertEquals(generation, actualRequest.getGeneration());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getObjectExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);

    try {
      String bucket = "bucket-1378203158";
      String object = "object-1023368385";
      long generation = 305703192;
      client.getObject(bucket, object, generation);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void readObjectTest() throws Exception {
    ReadObjectResponse expectedResponse =
        ReadObjectResponse.newBuilder()
            .setChecksummedData(ChecksummedData.newBuilder().build())
            .setObjectChecksums(ObjectChecksums.newBuilder().build())
            .setContentRange(ContentRange.newBuilder().build())
            .setMetadata(Object.newBuilder().build())
            .build();
    mockStorage.addResponse(expectedResponse);
    ReadObjectRequest request =
        ReadObjectRequest.newBuilder()
            .setBucket("bucket-1378203158")
            .setObject("object-1023368385")
            .setGeneration(305703192)
            .setReadOffset(-715377828)
            .setReadLimit(-164298798)
            .setIfGenerationMatch(-1086241088)
            .setIfGenerationNotMatch(1475720404)
            .setIfMetagenerationMatch(1043427781)
            .setIfMetagenerationNotMatch(1025430873)
            .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
            .setCommonRequestParams(CommonRequestParams.newBuilder().build())
            .setReadMask(FieldMask.newBuilder().build())
            .build();

    MockStreamObserver<ReadObjectResponse> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ReadObjectRequest, ReadObjectResponse> callable =
        client.readObjectCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<ReadObjectResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void readObjectExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);
    ReadObjectRequest request =
        ReadObjectRequest.newBuilder()
            .setBucket("bucket-1378203158")
            .setObject("object-1023368385")
            .setGeneration(305703192)
            .setReadOffset(-715377828)
            .setReadLimit(-164298798)
            .setIfGenerationMatch(-1086241088)
            .setIfGenerationNotMatch(1475720404)
            .setIfMetagenerationMatch(1043427781)
            .setIfMetagenerationNotMatch(1025430873)
            .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
            .setCommonRequestParams(CommonRequestParams.newBuilder().build())
            .setReadMask(FieldMask.newBuilder().build())
            .build();

    MockStreamObserver<ReadObjectResponse> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ReadObjectRequest, ReadObjectResponse> callable =
        client.readObjectCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<ReadObjectResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void writeObjectTest() throws Exception {
    WriteObjectResponse expectedResponse = WriteObjectResponse.newBuilder().build();
    mockStorage.addResponse(expectedResponse);
    WriteObjectRequest request =
        WriteObjectRequest.newBuilder()
            .setWriteOffset(-1559543565)
            .setObjectChecksums(ObjectChecksums.newBuilder().build())
            .setFinishWrite(true)
            .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
            .setCommonRequestParams(CommonRequestParams.newBuilder().build())
            .build();

    MockStreamObserver<WriteObjectResponse> responseObserver = new MockStreamObserver<>();

    ClientStreamingCallable<WriteObjectRequest, WriteObjectResponse> callable =
        client.writeObjectCallable();
    ApiStreamObserver<WriteObjectRequest> requestObserver =
        callable.clientStreamingCall(responseObserver);

    requestObserver.onNext(request);
    requestObserver.onCompleted();

    List<WriteObjectResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void writeObjectExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);
    WriteObjectRequest request =
        WriteObjectRequest.newBuilder()
            .setWriteOffset(-1559543565)
            .setObjectChecksums(ObjectChecksums.newBuilder().build())
            .setFinishWrite(true)
            .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
            .setCommonRequestParams(CommonRequestParams.newBuilder().build())
            .build();

    MockStreamObserver<WriteObjectResponse> responseObserver = new MockStreamObserver<>();

    ClientStreamingCallable<WriteObjectRequest, WriteObjectResponse> callable =
        client.writeObjectCallable();
    ApiStreamObserver<WriteObjectRequest> requestObserver =
        callable.clientStreamingCall(responseObserver);

    requestObserver.onNext(request);

    try {
      List<WriteObjectResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void startResumableWriteTest() throws Exception {
    StartResumableWriteResponse expectedResponse =
        StartResumableWriteResponse.newBuilder().setUploadId("uploadId1563990780").build();
    mockStorage.addResponse(expectedResponse);

    StartResumableWriteRequest request =
        StartResumableWriteRequest.newBuilder()
            .setWriteObjectSpec(WriteObjectSpec.newBuilder().build())
            .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
            .setCommonRequestParams(CommonRequestParams.newBuilder().build())
            .build();

    StartResumableWriteResponse actualResponse = client.startResumableWrite(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStorage.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StartResumableWriteRequest actualRequest = ((StartResumableWriteRequest) actualRequests.get(0));

    Assert.assertEquals(request.getWriteObjectSpec(), actualRequest.getWriteObjectSpec());
    Assert.assertEquals(
        request.getCommonObjectRequestParams(), actualRequest.getCommonObjectRequestParams());
    Assert.assertEquals(request.getCommonRequestParams(), actualRequest.getCommonRequestParams());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void startResumableWriteExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);

    try {
      StartResumableWriteRequest request =
          StartResumableWriteRequest.newBuilder()
              .setWriteObjectSpec(WriteObjectSpec.newBuilder().build())
              .setCommonObjectRequestParams(CommonObjectRequestParams.newBuilder().build())
              .setCommonRequestParams(CommonRequestParams.newBuilder().build())
              .build();
      client.startResumableWrite(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void queryWriteStatusTest() throws Exception {
    QueryWriteStatusResponse expectedResponse = QueryWriteStatusResponse.newBuilder().build();
    mockStorage.addResponse(expectedResponse);

    String uploadId = "uploadId1563990780";

    QueryWriteStatusResponse actualResponse = client.queryWriteStatus(uploadId);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStorage.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    QueryWriteStatusRequest actualRequest = ((QueryWriteStatusRequest) actualRequests.get(0));

    Assert.assertEquals(uploadId, actualRequest.getUploadId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void queryWriteStatusExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStorage.addException(exception);

    try {
      String uploadId = "uploadId1563990780";
      client.queryWriteStatus(uploadId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
