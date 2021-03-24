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
import * as tetherModule from '../src';

import {PassThrough} from 'stream';

import {protobuf} from 'google-gax';

function generateSampleMessage<T extends object>(instance: T) {
    const filledObject = (instance.constructor as typeof protobuf.Message)
        .toObject(instance as protobuf.Message<T>, {defaults: true});
    return (instance.constructor as typeof protobuf.Message).fromObject(filledObject) as T;
}

function stubBidiStreamingCall<ResponseType>(response?: ResponseType, error?: Error) {
    const transformStub = error ? sinon.stub().callsArgWith(2, error) : sinon.stub().callsArgWith(2, null, response);
    const mockStream = new PassThrough({
        objectMode: true,
        transform: transformStub,
    });
    return sinon.stub().returns(mockStream);
}

describe('v1.TetherClient', () => {
    it('has servicePath', () => {
        const servicePath = tetherModule.v1.TetherClient.servicePath;
        assert(servicePath);
    });

    it('has apiEndpoint', () => {
        const apiEndpoint = tetherModule.v1.TetherClient.apiEndpoint;
        assert(apiEndpoint);
    });

    it('has port', () => {
        const port = tetherModule.v1.TetherClient.port;
        assert(port);
        assert(typeof port === 'number');
    });

    it('should create a client with no option', () => {
        const client = new tetherModule.v1.TetherClient();
        assert(client);
    });

    it('should create a client with gRPC fallback', () => {
        const client = new tetherModule.v1.TetherClient({
            fallback: true,
        });
        assert(client);
    });

    it('has initialize method and supports deferred initialization', async () => {
        const client = new tetherModule.v1.TetherClient({
            credentials: { client_email: 'bogus', private_key: 'bogus' },
            projectId: 'bogus',
        });
        assert.strictEqual(client.tetherStub, undefined);
        await client.initialize();
        assert(client.tetherStub);
    });

    it('has close method', () => {
        const client = new tetherModule.v1.TetherClient({
            credentials: { client_email: 'bogus', private_key: 'bogus' },
            projectId: 'bogus',
        });
        client.close();
    });

    it('has getProjectId method', async () => {
        const fakeProjectId = 'fake-project-id';
        const client = new tetherModule.v1.TetherClient({
            credentials: { client_email: 'bogus', private_key: 'bogus' },
            projectId: 'bogus',
        });
        client.auth.getProjectId = sinon.stub().resolves(fakeProjectId);
        const result = await client.getProjectId();
        assert.strictEqual(result, fakeProjectId);
        assert((client.auth.getProjectId as SinonStub).calledWithExactly());
    });

    it('has getProjectId method with callback', async () => {
        const fakeProjectId = 'fake-project-id';
        const client = new tetherModule.v1.TetherClient({
            credentials: { client_email: 'bogus', private_key: 'bogus' },
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

    describe('egress', () => {
        it('invokes egress without error', async () => {
            const client = new tetherModule.v1.TetherClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.apigeeconnect.v1.EgressResponse());
            const expectedResponse = generateSampleMessage(new protos.google.cloud.apigeeconnect.v1.EgressRequest());
            client.innerApiCalls.egress = stubBidiStreamingCall(expectedResponse);
            const stream = client.egress();
            const promise = new Promise((resolve, reject) => {
                stream.on('data', (response: protos.google.cloud.apigeeconnect.v1.EgressRequest) => {
                    resolve(response);
                });
                stream.on('error', (err: Error) => {
                    reject(err);
                });
                stream.write(request);
                stream.end();
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.egress as SinonStub)
                .getCall(0).calledWithExactly(undefined));
            assert.deepStrictEqual(((stream as unknown as PassThrough)
                ._transform as SinonStub).getCall(0).args[0], request);
        });

        it('invokes egress with error', async () => {
            const client = new tetherModule.v1.TetherClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.apigeeconnect.v1.EgressResponse());const expectedError = new Error('expected');
            client.innerApiCalls.egress = stubBidiStreamingCall(undefined, expectedError);
            const stream = client.egress();
            const promise = new Promise((resolve, reject) => {
                stream.on('data', (response: protos.google.cloud.apigeeconnect.v1.EgressRequest) => {
                    resolve(response);
                });
                stream.on('error', (err: Error) => {
                    reject(err);
                });
                stream.write(request);
                stream.end();
            });
            await assert.rejects(promise, expectedError);
            assert((client.innerApiCalls.egress as SinonStub)
                .getCall(0).calledWithExactly(undefined));
            assert.deepStrictEqual(((stream as unknown as PassThrough)
                ._transform as SinonStub).getCall(0).args[0], request);
        });
    });
});
