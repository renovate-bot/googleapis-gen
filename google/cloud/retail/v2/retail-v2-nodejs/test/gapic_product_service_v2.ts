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
import * as productserviceModule from '../src';

import {protobuf, LROperation, operationsProtos} from 'google-gax';

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

function stubLongRunningCall<ResponseType>(response?: ResponseType, callError?: Error, lroError?: Error) {
    const innerStub = lroError ? sinon.stub().rejects(lroError) : sinon.stub().resolves([response]);
    const mockOperation = {
        promise: innerStub,
    };
    return callError ? sinon.stub().rejects(callError) : sinon.stub().resolves([mockOperation]);
}

function stubLongRunningCallWithCallback<ResponseType>(response?: ResponseType, callError?: Error, lroError?: Error) {
    const innerStub = lroError ? sinon.stub().rejects(lroError) : sinon.stub().resolves([response]);
    const mockOperation = {
        promise: innerStub,
    };
    return callError ? sinon.stub().callsArgWith(2, callError) : sinon.stub().callsArgWith(2, null, mockOperation);
}

describe('v2.ProductServiceClient', () => {
    it('has servicePath', () => {
        const servicePath = productserviceModule.v2.ProductServiceClient.servicePath;
        assert(servicePath);
    });

    it('has apiEndpoint', () => {
        const apiEndpoint = productserviceModule.v2.ProductServiceClient.apiEndpoint;
        assert(apiEndpoint);
    });

    it('has port', () => {
        const port = productserviceModule.v2.ProductServiceClient.port;
        assert(port);
        assert(typeof port === 'number');
    });

    it('should create a client with no option', () => {
        const client = new productserviceModule.v2.ProductServiceClient();
        assert(client);
    });

    it('should create a client with gRPC fallback', () => {
        const client = new productserviceModule.v2.ProductServiceClient({
            fallback: true,
        });
        assert(client);
    });

    it('has initialize method and supports deferred initialization', async () => {
        const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        assert.strictEqual(client.productServiceStub, undefined);
        await client.initialize();
        assert(client.productServiceStub);
    });

    it('has close method', () => {
        const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
        client.close();
    });

    it('has getProjectId method', async () => {
        const fakeProjectId = 'fake-project-id';
        const client = new productserviceModule.v2.ProductServiceClient({
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
        const client = new productserviceModule.v2.ProductServiceClient({
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

    describe('createProduct', () => {
        it('invokes createProduct without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.CreateProductRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.createProduct = stubSimpleCall(expectedResponse);
            const [response] = await client.createProduct(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.createProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes createProduct without error using callback', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.CreateProductRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.createProduct = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.createProduct(
                    request,
                    (err?: Error|null, result?: protos.google.cloud.retail.v2.IProduct|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.createProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes createProduct with error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.CreateProductRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.createProduct = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.createProduct(request), expectedError);
            assert((client.innerApiCalls.createProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('getProduct', () => {
        it('invokes getProduct without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.GetProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.getProduct = stubSimpleCall(expectedResponse);
            const [response] = await client.getProduct(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.getProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes getProduct without error using callback', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.GetProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.getProduct = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.getProduct(
                    request,
                    (err?: Error|null, result?: protos.google.cloud.retail.v2.IProduct|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.getProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes getProduct with error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.GetProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.getProduct = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.getProduct(request), expectedError);
            assert((client.innerApiCalls.getProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('updateProduct', () => {
        it('invokes updateProduct without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.UpdateProductRequest());
            request.product = {};
            request.product.name = '';
            const expectedHeaderRequestParams = "product.name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.updateProduct = stubSimpleCall(expectedResponse);
            const [response] = await client.updateProduct(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.updateProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes updateProduct without error using callback', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.UpdateProductRequest());
            request.product = {};
            request.product.name = '';
            const expectedHeaderRequestParams = "product.name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.cloud.retail.v2.Product());
            client.innerApiCalls.updateProduct = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.updateProduct(
                    request,
                    (err?: Error|null, result?: protos.google.cloud.retail.v2.IProduct|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.updateProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes updateProduct with error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.UpdateProductRequest());
            request.product = {};
            request.product.name = '';
            const expectedHeaderRequestParams = "product.name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.updateProduct = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.updateProduct(request), expectedError);
            assert((client.innerApiCalls.updateProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('deleteProduct', () => {
        it('invokes deleteProduct without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.DeleteProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.protobuf.Empty());
            client.innerApiCalls.deleteProduct = stubSimpleCall(expectedResponse);
            const [response] = await client.deleteProduct(request);
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.deleteProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes deleteProduct without error using callback', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.DeleteProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.protobuf.Empty());
            client.innerApiCalls.deleteProduct = stubSimpleCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.deleteProduct(
                    request,
                    (err?: Error|null, result?: protos.google.protobuf.IEmpty|null) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const response = await promise;
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.deleteProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes deleteProduct with error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.DeleteProductRequest());
            request.name = '';
            const expectedHeaderRequestParams = "name=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.deleteProduct = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.deleteProduct(request), expectedError);
            assert((client.innerApiCalls.deleteProduct as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });
    });

    describe('importProducts', () => {
        it('invokes importProducts without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.ImportProductsRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.longrunning.Operation());
            client.innerApiCalls.importProducts = stubLongRunningCall(expectedResponse);
            const [operation] = await client.importProducts(request);
            const [response] = await operation.promise();
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.importProducts as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes importProducts without error using callback', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.ImportProductsRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedResponse = generateSampleMessage(new protos.google.longrunning.Operation());
            client.innerApiCalls.importProducts = stubLongRunningCallWithCallback(expectedResponse);
            const promise = new Promise((resolve, reject) => {
                 client.importProducts(
                    request,
                    (err?: Error|null,
                     result?: LROperation<protos.google.cloud.retail.v2.IImportProductsResponse, protos.google.cloud.retail.v2.IImportMetadata>|null
                    ) => {
                        if (err) {
                            reject(err);
                        } else {
                            resolve(result);
                        }
                    });
            });
            const operation = await promise as LROperation<protos.google.cloud.retail.v2.IImportProductsResponse, protos.google.cloud.retail.v2.IImportMetadata>;
            const [response] = await operation.promise();
            assert.deepStrictEqual(response, expectedResponse);
            assert((client.innerApiCalls.importProducts as SinonStub)
                .getCall(0).calledWith(request, expectedOptions /*, callback defined above */));
        });

        it('invokes importProducts with call error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.ImportProductsRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.importProducts = stubLongRunningCall(undefined, expectedError);
            await assert.rejects(client.importProducts(request), expectedError);
            assert((client.innerApiCalls.importProducts as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes importProducts with LRO error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const request = generateSampleMessage(new protos.google.cloud.retail.v2.ImportProductsRequest());
            request.parent = '';
            const expectedHeaderRequestParams = "parent=";
            const expectedOptions = {
                otherArgs: {
                    headers: {
                        'x-goog-request-params': expectedHeaderRequestParams,
                    },
                },
            };
            const expectedError = new Error('expected');
            client.innerApiCalls.importProducts = stubLongRunningCall(undefined, undefined, expectedError);
            const [operation] = await client.importProducts(request);
            await assert.rejects(operation.promise(), expectedError);
            assert((client.innerApiCalls.importProducts as SinonStub)
                .getCall(0).calledWith(request, expectedOptions, undefined));
        });

        it('invokes checkImportProductsProgress without error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const expectedResponse = generateSampleMessage(new operationsProtos.google.longrunning.Operation());
            expectedResponse.name = 'test';
            expectedResponse.response = {type_url: 'url', value: Buffer.from('')};
            expectedResponse.metadata = {type_url: 'url', value: Buffer.from('')}

            client.operationsClient.getOperation = stubSimpleCall(expectedResponse);
            const decodedOperation = await client.checkImportProductsProgress(expectedResponse.name);
            assert.deepStrictEqual(decodedOperation.name, expectedResponse.name);
            assert(decodedOperation.metadata);
            assert((client.operationsClient.getOperation as SinonStub).getCall(0));
        });

        it('invokes checkImportProductsProgress with error', async () => {
            const client = new productserviceModule.v2.ProductServiceClient({
              credentials: {client_email: 'bogus', private_key: 'bogus'},
              projectId: 'bogus',
        });
            client.initialize();
            const expectedError = new Error('expected');

            client.operationsClient.getOperation = stubSimpleCall(undefined, expectedError);
            await assert.rejects(client.checkImportProductsProgress(''), expectedError);
            assert((client.operationsClient.getOperation as SinonStub)
                .getCall(0));
        });
    });

    describe('Path templates', () => {

        describe('branch', () => {
            const fakePath = "/rendered/path/branch";
            const expectedParameters = {
                project: "projectValue",
                location: "locationValue",
                catalog: "catalogValue",
                branch: "branchValue",
            };
            const client = new productserviceModule.v2.ProductServiceClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.branchPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.branchPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('branchPath', () => {
                const result = client.branchPath("projectValue", "locationValue", "catalogValue", "branchValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.branchPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromBranchName', () => {
                const result = client.matchProjectFromBranchName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.branchPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchLocationFromBranchName', () => {
                const result = client.matchLocationFromBranchName(fakePath);
                assert.strictEqual(result, "locationValue");
                assert((client.pathTemplates.branchPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchCatalogFromBranchName', () => {
                const result = client.matchCatalogFromBranchName(fakePath);
                assert.strictEqual(result, "catalogValue");
                assert((client.pathTemplates.branchPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchBranchFromBranchName', () => {
                const result = client.matchBranchFromBranchName(fakePath);
                assert.strictEqual(result, "branchValue");
                assert((client.pathTemplates.branchPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });

        describe('catalog', () => {
            const fakePath = "/rendered/path/catalog";
            const expectedParameters = {
                project: "projectValue",
                location: "locationValue",
                catalog: "catalogValue",
            };
            const client = new productserviceModule.v2.ProductServiceClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.catalogPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.catalogPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('catalogPath', () => {
                const result = client.catalogPath("projectValue", "locationValue", "catalogValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.catalogPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromCatalogName', () => {
                const result = client.matchProjectFromCatalogName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.catalogPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchLocationFromCatalogName', () => {
                const result = client.matchLocationFromCatalogName(fakePath);
                assert.strictEqual(result, "locationValue");
                assert((client.pathTemplates.catalogPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchCatalogFromCatalogName', () => {
                const result = client.matchCatalogFromCatalogName(fakePath);
                assert.strictEqual(result, "catalogValue");
                assert((client.pathTemplates.catalogPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });

        describe('product', () => {
            const fakePath = "/rendered/path/product";
            const expectedParameters = {
                project: "projectValue",
                location: "locationValue",
                catalog: "catalogValue",
                branch: "branchValue",
                product: "productValue",
            };
            const client = new productserviceModule.v2.ProductServiceClient({
                credentials: {client_email: 'bogus', private_key: 'bogus'},
                projectId: 'bogus',
            });
            client.initialize();
            client.pathTemplates.productPathTemplate.render =
                sinon.stub().returns(fakePath);
            client.pathTemplates.productPathTemplate.match =
                sinon.stub().returns(expectedParameters);

            it('productPath', () => {
                const result = client.productPath("projectValue", "locationValue", "catalogValue", "branchValue", "productValue");
                assert.strictEqual(result, fakePath);
                assert((client.pathTemplates.productPathTemplate.render as SinonStub)
                    .getCall(-1).calledWith(expectedParameters));
            });

            it('matchProjectFromProductName', () => {
                const result = client.matchProjectFromProductName(fakePath);
                assert.strictEqual(result, "projectValue");
                assert((client.pathTemplates.productPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchLocationFromProductName', () => {
                const result = client.matchLocationFromProductName(fakePath);
                assert.strictEqual(result, "locationValue");
                assert((client.pathTemplates.productPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchCatalogFromProductName', () => {
                const result = client.matchCatalogFromProductName(fakePath);
                assert.strictEqual(result, "catalogValue");
                assert((client.pathTemplates.productPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchBranchFromProductName', () => {
                const result = client.matchBranchFromProductName(fakePath);
                assert.strictEqual(result, "branchValue");
                assert((client.pathTemplates.productPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });

            it('matchProductFromProductName', () => {
                const result = client.matchProductFromProductName(fakePath);
                assert.strictEqual(result, "productValue");
                assert((client.pathTemplates.productPathTemplate.match as SinonStub)
                    .getCall(-1).calledWith(fakePath));
            });
        });
    });
});
