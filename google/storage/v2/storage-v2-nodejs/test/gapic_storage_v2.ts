// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// ** This file is automatically generated by gapic-generator-typescript. **
// ** https://github.com/googleapis/gapic-generator-typescript **
// ** All changes to this file may be overwritten. **

import * as protos from '../protos/protos';
import * as assert from 'assert';
import * as sinon from 'sinon';
import {SinonStub} from 'sinon';
import { describe, it } from 'mocha';
import * as storageModule from '../src';

import {PassThrough} from 'stream';

import {protobuf} from 'google-gax';

function generateSampleMessage<T extends object>(instance: T) {
    const filledObject = (instance.constructor as typeof protobuf.Message)
        .toObject(instance as protobuf.Message<T>, {defaults: true});
    return (instance.constructor as typeof protobuf.Message).fromObject(filledObject) as T;
}

function stubSimpleCall<ResponseType>(response?: ResponseType, error?: Error) {
    return error ? sinon.stub().rejects(error) : sinon.stub().resolves([response]);
}

function stubSimpleCallWithCallback<ResponseType>(response?: ResponseType, error?: Error) {
    return error ? sinon.stub().callsArgWith(2, error) : sinon.stub().callsArgWith(2, null, response);
}

function stubServerStreamingCall<ResponseType>(response?: ResponseType, error?: Error) {
    const transformStub = error ? sinon.stub().callsArgWith(2, error) : sinon.stub().callsArgWith(2, null, response);
    const mockStream = new PassThrough({
        objectMode: true,
        transform: transformStub,
    });
    // write something to the stream to trigger transformStub and send the response back to the client
    setImmediate(() => { mockStream.write({}); });
    setImmediate(() => { mockStream.end(); });
    return sinon.stub().returns(mockStream);
}

function stubClientStreamingCall<ResponseType>(response?: ResponseType, error?: Error) {
    if (error) {
        return sinon.stub().callsArgWith(2, error);
    }
    const transformStub = sinon.stub();
    const mockStream = new PassThrough({
        objectMode: true,
        transform: transformStub,
    });
    return sinon.stub().returns(mockStream).callsArgWith(2, null, response);
}

describe('v2.StorageClient', () => {
    it('has servicePath', () => {
        const servicePath = storageModule.v2.StorageClient.servicePath;
        assert(servicePath);
    });

    it('has apiEndpoint', () => {
        const apiEndpoint = storageModule.v2.StorageClient.apiEndpoint;
        assert(apiEndpoint);
    });

    it('has port', () => {
        const port = storageModule.v2.StorageClient.port;
        assert(port);
        assert(typeof port === 'number');
    });

    it('should create a client with no option', () => {
        const client = new storageModule.v2.StorageClient();
        assert(client);
    });

    it('should create a client with gRPC fallback', () => {
        const client = new storageModule.v2.StorageClient({
            fallback: true,
        });
        assert(client);
    });

    it('has initialize method and supports deferred initialization', async () => {
        const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        assert.strictEqual(client.storageStub, undefined);
        await client.initialize();
        assert(client.storageStub);
    });

    it('has close method', () => {
        const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        client.close();
    });

    it('has getProjectId method', async () => {
        const fakeProjectId = 'fake-project-id';
        const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        client.auth.getProjectId = sinon.stub().resolves(fakeProjectId);
        const result = await client.getProjectId();
        assert.strictEqual(result, fakeProjectId);
        assert((client.auth.getProjectId as SinonStub).calledWithExactly());
    });

    it('has getProjectId method with callback', async () => {
        const fakeProjectId = 'fake-project-id';
        const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        client.auth.getProjectId = sinon.stub().callsArgWith(0, null, fakeProjectId);
        const promise = new Promise((resolve, reject) => {
            client.getProjectId((err?: Error|null, projectId?: string|null) => {
                if (err) {
                    reject(err);
                } else {
                    resolve(projectId);
                }
            });
        });
        const result = await promise;
        assert.strictEqual(result, fakeProjectId);
    });

    describe('startResumableWrite', () => {
        it('invokes startResumableWrite without error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.StartResumableWriteRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.StartResumableWriteResponse());
            client.innerApiCalls.startResumableWrite = stubSimpleCall(expectedResponse);
            const [response] = await client.startResumableWrite(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.startResumableWrite as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes startResumableWrite without error using callback', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.StartResumableWriteRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.StartResumableWriteResponse());
            client.innerApiCalls.startResumableWrite = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.startResumableWrite(
                    request,
                    (err?: Error|null, result?: protos.google.storage.v2.IStartResumableWriteResponse|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.startResumableWrite as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes startResumableWrite with error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.StartResumableWriteRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedError = new Error('expected');
            client.innerApiCalls.startResumableWrite = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.startResumableWrite(request), expectedError);
            assert((client.innerApiCalls.startResumableWrite as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('queryWriteStatus', () => {
        it('invokes queryWriteStatus without error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.QueryWriteStatusRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.QueryWriteStatusResponse());
            client.innerApiCalls.queryWriteStatus = stubSimpleCall(expectedResponse);
            const [response] = await client.queryWriteStatus(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.queryWriteStatus as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes queryWriteStatus without error using callback', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.QueryWriteStatusRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.QueryWriteStatusResponse());
            client.innerApiCalls.queryWriteStatus = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.queryWriteStatus(
                    request,
                    (err?: Error|null, result?: protos.google.storage.v2.IQueryWriteStatusResponse|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.queryWriteStatus as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes queryWriteStatus with error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.QueryWriteStatusRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedError = new Error('expected');
            client.innerApiCalls.queryWriteStatus = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.queryWriteStatus(request), expectedError);
            assert((client.innerApiCalls.queryWriteStatus as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('readObject', () => {
        it('invokes readObject without error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.ReadObjectRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.ReadObjectResponse());
            client.innerApiCalls.readObject = stubServerStreamingCall(expectedResponse);
            const stream = client.readObject(request);
            const promise = new Promise((resolve, reject) => {
                stream.on('data', (response: protos.google.storage.v2.ReadObjectResponse) => {
                    resolve(response);
                });
                stream.on('error', (err: Error) => {
                    reject(err);
                });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.readObject as SinonStub)
                .getCall(0).calledWith(request, expectedOptions));
        });

        it('invokes readObject with error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.ReadObjectRequest());
            const expectedOptions = {otherArgs: {headers: {}}};;
            const expectedError = new Error('expected');
            client.innerApiCalls.readObject = stubServerStreamingCall(undefined, expectedError);
            const stream = client.readObject(request);
            const promise = new Promise((resolve, reject) => {
                stream.on('data', (response: protos.google.storage.v2.ReadObjectResponse) => {
                    resolve(response);
                });
                stream.on('error', (err: Error) => {
                    reject(err);
                });
            });
            await assert.rejects(promise, expectedError);
            assert((client.innerApiCalls.readObject as SinonStub)
                .getCall(0).calledWith(request, expectedOptions));
        });
    });

    describe('writeObject', () => {
        it('invokes writeObject without error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.WriteObjectRequest());
            const expectedResponse = generateSampleMessage(new protos.google.storage.v2.WriteObjectResponse());
            client.innerApiCalls.writeObject = stubClientStreamingCall(expectedResponse);
            let stream: PassThrough;
            const promise = new Promise((resolve, reject) => {
                stream = client.writeObject(
                    (err?: Error|null, result?: protos.google.storage.v2.IWriteObjectResponse|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    }) as unknown as PassThrough;
                stream.write(request);
                stream.end();
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.writeObject as SinonStub)
                .getCall(0).calledWith(null, {} /*, callback defined above */));
            assert.deepStrictEqual((stream!._transform as SinonStub).getCall(0).args[0], request);
        });

        it('invokes writeObject with error', async () => {
            const client = new storageModule.v2.StorageClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.storage.v2.WriteObjectRequest());
            const expectedError = new Error('expected');
            client.innerApiCalls.writeObject = stubClientStreamingCall(undefined, expectedError);
            let stream: PassThrough;
            const promise = new Promise((resolve, reject) => {
                stream = client.writeObject(
                    (err?: Error|null, result?: protos.google.storage.v2.IWriteObjectResponse|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    }) as unknown as PassThrough;
                stream.write(request);
                stream.end();
            });
            await assert.rejects(promise, expectedError);
            assert((client.innerApiCalls.writeObject as SinonStub)
                .getCall(0).calledWith(null, {} /*, callback defined above */));
        });
    });

    describe('Path templates', () => {

        describe('bucket', () => {
            const fakePath = "/rendered/path/bucket";
            const expectedParameters = {
                project: "projectValue",
                bucket: "bucketValue",
            };
            const client = new storageModule.v2.StorageClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.bucketPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.bucketPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('bucketPath', () => {
                const result = client.bucketPath("projectValue", "bucketValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.bucketPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromBucketName', () => {
                const result = client.matchProjectFromBucketName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.bucketPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchBucketFromBucketName', () => {
                const result = client.matchBucketFromBucketName(fakePath);
                assert.strictEqual(result, "bucketValue");
                assert((client.pathTemplates.bucketPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });

        describe('cryptoKey', () => {
            const fakePath = "/rendered/path/cryptoKey";
            const expectedParameters = {
                project: "projectValue",
                location: "locationValue",
                key_ring: "keyRingValue",
                crypto_key: "cryptoKeyValue",
            };
            const client = new storageModule.v2.StorageClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.cryptoKeyPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.cryptoKeyPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('cryptoKeyPath', () => {
                const result = client.cryptoKeyPath("projectValue", "locationValue", "keyRingValue", "cryptoKeyValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.cryptoKeyPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromCryptoKeyName', () => {
                const result = client.matchProjectFromCryptoKeyName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.cryptoKeyPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchLocationFromCryptoKeyName', () => {
                const result = client.matchLocationFromCryptoKeyName(fakePath);
                assert.strictEqual(result, "locationValue");
                assert((client.pathTemplates.cryptoKeyPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchKeyRingFromCryptoKeyName', () => {
                const result = client.matchKeyRingFromCryptoKeyName(fakePath);
                assert.strictEqual(result, "keyRingValue");
                assert((client.pathTemplates.cryptoKeyPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchCryptoKeyFromCryptoKeyName', () => {
                const result = client.matchCryptoKeyFromCryptoKeyName(fakePath);
                assert.strictEqual(result, "cryptoKeyValue");
                assert((client.pathTemplates.cryptoKeyPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });

        describe('project', () => {
            const fakePath = "/rendered/path/project";
            const expectedParameters = {
                project: "projectValue",
            };
            const client = new storageModule.v2.StorageClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.projectPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.projectPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('projectPath', () => {
                const result = client.projectPath("projectValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.projectPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromProjectName', () => {
                const result = client.matchProjectFromProjectName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.projectPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });
    });
});
