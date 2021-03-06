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

// Code generated by protoc-gen-go_gapic. DO NOT EDIT.

package admob

import (
	"context"
	"fmt"
	"math"
	"net/url"

	gax "github.com/googleapis/gax-go/v2"
	"google.golang.org/api/iterator"
	"google.golang.org/api/option"
	"google.golang.org/api/option/internaloption"
	gtransport "google.golang.org/api/transport/grpc"
	admobpb "google.golang.org/genproto/googleapis/ads/admob/v1"
	"google.golang.org/grpc"
	"google.golang.org/grpc/metadata"
	"google.golang.org/protobuf/proto"
)

var newAdMobApiClientHook clientHook

// AdMobApiCallOptions contains the retry settings for each method of AdMobApiClient.
type AdMobApiCallOptions struct {
	GetPublisherAccount     []gax.CallOption
	ListPublisherAccounts   []gax.CallOption
	GenerateNetworkReport   []gax.CallOption
	GenerateMediationReport []gax.CallOption
}

func defaultAdMobApiGRPCClientOptions() []option.ClientOption {
	return []option.ClientOption{
		internaloption.WithDefaultEndpoint("admob.googleapis.com:443"),
		internaloption.WithDefaultMTLSEndpoint("admob.mtls.googleapis.com:443"),
		internaloption.WithDefaultAudience("https://admob.googleapis.com/"),
		internaloption.WithDefaultScopes(DefaultAuthScopes()...),
		internaloption.EnableJwtWithScope(),
		option.WithGRPCDialOption(grpc.WithDisableServiceConfig()),
		option.WithGRPCDialOption(grpc.WithDefaultCallOptions(
			grpc.MaxCallRecvMsgSize(math.MaxInt32))),
	}
}

func defaultAdMobApiCallOptions() *AdMobApiCallOptions {
	return &AdMobApiCallOptions{
		GetPublisherAccount:     []gax.CallOption{},
		ListPublisherAccounts:   []gax.CallOption{},
		GenerateNetworkReport:   []gax.CallOption{},
		GenerateMediationReport: []gax.CallOption{},
	}
}

// internalAdMobApiClient is an interface that defines the methods availaible from AdMob API.
type internalAdMobApiClient interface {
	Close() error
	setGoogleClientInfo(...string)
	Connection() *grpc.ClientConn
	GetPublisherAccount(context.Context, *admobpb.GetPublisherAccountRequest, ...gax.CallOption) (*admobpb.PublisherAccount, error)
	ListPublisherAccounts(context.Context, *admobpb.ListPublisherAccountsRequest, ...gax.CallOption) *PublisherAccountIterator
	GenerateNetworkReport(context.Context, *admobpb.GenerateNetworkReportRequest, ...gax.CallOption) (admobpb.AdMobApi_GenerateNetworkReportClient, error)
	GenerateMediationReport(context.Context, *admobpb.GenerateMediationReportRequest, ...gax.CallOption) (admobpb.AdMobApi_GenerateMediationReportClient, error)
}

// AdMobApiClient is a client for interacting with AdMob API.
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
//
// The AdMob API allows AdMob publishers programmatically get information about
// their AdMob account.
type AdMobApiClient struct {
	// The internal transport-dependent client.
	internalClient internalAdMobApiClient

	// The call options for this service.
	CallOptions *AdMobApiCallOptions
}

// Wrapper methods routed to the internal client.

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *AdMobApiClient) Close() error {
	return c.internalClient.Close()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *AdMobApiClient) setGoogleClientInfo(keyval ...string) {
	c.internalClient.setGoogleClientInfo(keyval...)
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *AdMobApiClient) Connection() *grpc.ClientConn {
	return c.internalClient.Connection()
}

// GetPublisherAccount gets information about the specified AdMob publisher account.
func (c *AdMobApiClient) GetPublisherAccount(ctx context.Context, req *admobpb.GetPublisherAccountRequest, opts ...gax.CallOption) (*admobpb.PublisherAccount, error) {
	return c.internalClient.GetPublisherAccount(ctx, req, opts...)
}

// ListPublisherAccounts lists the AdMob publisher account accessible with the client credential.
// Currently, all credentials have access to at most one AdMob account.
func (c *AdMobApiClient) ListPublisherAccounts(ctx context.Context, req *admobpb.ListPublisherAccountsRequest, opts ...gax.CallOption) *PublisherAccountIterator {
	return c.internalClient.ListPublisherAccounts(ctx, req, opts...)
}

// GenerateNetworkReport generates an AdMob Network report based on the provided report
// specification.
func (c *AdMobApiClient) GenerateNetworkReport(ctx context.Context, req *admobpb.GenerateNetworkReportRequest, opts ...gax.CallOption) (admobpb.AdMobApi_GenerateNetworkReportClient, error) {
	return c.internalClient.GenerateNetworkReport(ctx, req, opts...)
}

// GenerateMediationReport generates an AdMob Mediation report based on the provided report
// specification.
func (c *AdMobApiClient) GenerateMediationReport(ctx context.Context, req *admobpb.GenerateMediationReportRequest, opts ...gax.CallOption) (admobpb.AdMobApi_GenerateMediationReportClient, error) {
	return c.internalClient.GenerateMediationReport(ctx, req, opts...)
}

// adMobApiGRPCClient is a client for interacting with AdMob API over gRPC transport.
//
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
type adMobApiGRPCClient struct {
	// Connection pool of gRPC connections to the service.
	connPool gtransport.ConnPool

	// flag to opt out of default deadlines via GOOGLE_API_GO_EXPERIMENTAL_DISABLE_DEFAULT_DEADLINE
	disableDeadlines bool

	// Points back to the CallOptions field of the containing AdMobApiClient
	CallOptions **AdMobApiCallOptions

	// The gRPC API client.
	adMobApiClient admobpb.AdMobApiClient

	// The x-goog-* metadata to be sent with each request.
	xGoogMetadata metadata.MD
}

// NewAdMobApiClient creates a new ad mob api client based on gRPC.
// The returned client must be Closed when it is done being used to clean up its underlying connections.
//
// The AdMob API allows AdMob publishers programmatically get information about
// their AdMob account.
func NewAdMobApiClient(ctx context.Context, opts ...option.ClientOption) (*AdMobApiClient, error) {
	clientOpts := defaultAdMobApiGRPCClientOptions()
	if newAdMobApiClientHook != nil {
		hookOpts, err := newAdMobApiClientHook(ctx, clientHookParams{})
		if err != nil {
			return nil, err
		}
		clientOpts = append(clientOpts, hookOpts...)
	}

	disableDeadlines, err := checkDisableDeadlines()
	if err != nil {
		return nil, err
	}

	connPool, err := gtransport.DialPool(ctx, append(clientOpts, opts...)...)
	if err != nil {
		return nil, err
	}
	client := AdMobApiClient{CallOptions: defaultAdMobApiCallOptions()}

	c := &adMobApiGRPCClient{
		connPool:         connPool,
		disableDeadlines: disableDeadlines,
		adMobApiClient:   admobpb.NewAdMobApiClient(connPool),
		CallOptions:      &client.CallOptions,
	}
	c.setGoogleClientInfo()

	client.internalClient = c

	return &client, nil
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *adMobApiGRPCClient) Connection() *grpc.ClientConn {
	return c.connPool.Conn()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *adMobApiGRPCClient) setGoogleClientInfo(keyval ...string) {
	kv := append([]string{"gl-go", versionGo()}, keyval...)
	kv = append(kv, "gapic", versionClient, "gax", gax.Version, "grpc", grpc.Version)
	c.xGoogMetadata = metadata.Pairs("x-goog-api-client", gax.XGoogHeader(kv...))
}

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *adMobApiGRPCClient) Close() error {
	return c.connPool.Close()
}

func (c *adMobApiGRPCClient) GetPublisherAccount(ctx context.Context, req *admobpb.GetPublisherAccountRequest, opts ...gax.CallOption) (*admobpb.PublisherAccount, error) {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).GetPublisherAccount[0:len((*c.CallOptions).GetPublisherAccount):len((*c.CallOptions).GetPublisherAccount)], opts...)
	var resp *admobpb.PublisherAccount
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.adMobApiClient.GetPublisherAccount(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

func (c *adMobApiGRPCClient) ListPublisherAccounts(ctx context.Context, req *admobpb.ListPublisherAccountsRequest, opts ...gax.CallOption) *PublisherAccountIterator {
	ctx = insertMetadata(ctx, c.xGoogMetadata)
	opts = append((*c.CallOptions).ListPublisherAccounts[0:len((*c.CallOptions).ListPublisherAccounts):len((*c.CallOptions).ListPublisherAccounts)], opts...)
	it := &PublisherAccountIterator{}
	req = proto.Clone(req).(*admobpb.ListPublisherAccountsRequest)
	it.InternalFetch = func(pageSize int, pageToken string) ([]*admobpb.PublisherAccount, string, error) {
		var resp *admobpb.ListPublisherAccountsResponse
		req.PageToken = pageToken
		if pageSize > math.MaxInt32 {
			req.PageSize = math.MaxInt32
		} else {
			req.PageSize = int32(pageSize)
		}
		err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
			var err error
			resp, err = c.adMobApiClient.ListPublisherAccounts(ctx, req, settings.GRPC...)
			return err
		}, opts...)
		if err != nil {
			return nil, "", err
		}

		it.Response = resp
		return resp.GetAccount(), resp.GetNextPageToken(), nil
	}
	fetch := func(pageSize int, pageToken string) (string, error) {
		items, nextPageToken, err := it.InternalFetch(pageSize, pageToken)
		if err != nil {
			return "", err
		}
		it.items = append(it.items, items...)
		return nextPageToken, nil
	}
	it.pageInfo, it.nextFunc = iterator.NewPageInfo(fetch, it.bufLen, it.takeBuf)
	it.pageInfo.MaxSize = int(req.GetPageSize())
	it.pageInfo.Token = req.GetPageToken()
	return it
}

func (c *adMobApiGRPCClient) GenerateNetworkReport(ctx context.Context, req *admobpb.GenerateNetworkReportRequest, opts ...gax.CallOption) (admobpb.AdMobApi_GenerateNetworkReportClient, error) {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	var resp admobpb.AdMobApi_GenerateNetworkReportClient
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.adMobApiClient.GenerateNetworkReport(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

func (c *adMobApiGRPCClient) GenerateMediationReport(ctx context.Context, req *admobpb.GenerateMediationReportRequest, opts ...gax.CallOption) (admobpb.AdMobApi_GenerateMediationReportClient, error) {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	var resp admobpb.AdMobApi_GenerateMediationReportClient
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.adMobApiClient.GenerateMediationReport(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

// PublisherAccountIterator manages a stream of *admobpb.PublisherAccount.
type PublisherAccountIterator struct {
	items    []*admobpb.PublisherAccount
	pageInfo *iterator.PageInfo
	nextFunc func() error

	// Response is the raw response for the current page.
	// It must be cast to the RPC response type.
	// Calling Next() or InternalFetch() updates this value.
	Response interface{}

	// InternalFetch is for use by the Google Cloud Libraries only.
	// It is not part of the stable interface of this package.
	//
	// InternalFetch returns results from a single call to the underlying RPC.
	// The number of results is no greater than pageSize.
	// If there are no more results, nextPageToken is empty and err is nil.
	InternalFetch func(pageSize int, pageToken string) (results []*admobpb.PublisherAccount, nextPageToken string, err error)
}

// PageInfo supports pagination. See the google.golang.org/api/iterator package for details.
func (it *PublisherAccountIterator) PageInfo() *iterator.PageInfo {
	return it.pageInfo
}

// Next returns the next result. Its second return value is iterator.Done if there are no more
// results. Once Next returns Done, all subsequent calls will return Done.
func (it *PublisherAccountIterator) Next() (*admobpb.PublisherAccount, error) {
	var item *admobpb.PublisherAccount
	if err := it.nextFunc(); err != nil {
		return item, err
	}
	item = it.items[0]
	it.items = it.items[1:]
	return item, nil
}

func (it *PublisherAccountIterator) bufLen() int {
	return len(it.items)
}

func (it *PublisherAccountIterator) takeBuf() interface{} {
	b := it.items
	it.items = nil
	return b
}
