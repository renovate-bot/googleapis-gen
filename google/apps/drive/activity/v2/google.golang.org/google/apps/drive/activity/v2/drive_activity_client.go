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

package activity

import (
	"context"
	"math"
	"time"

	"github.com/golang/protobuf/proto"
	gax "github.com/googleapis/gax-go/v2"
	"google.golang.org/api/iterator"
	"google.golang.org/api/option"
	"google.golang.org/api/option/internaloption"
	gtransport "google.golang.org/api/transport/grpc"
	activitypb "google.golang.org/genproto/googleapis/apps/drive/activity/v2"
	"google.golang.org/grpc"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/metadata"
)

var newDriveActivityClientHook clientHook

// DriveActivityCallOptions contains the retry settings for each method of DriveActivityClient.
type DriveActivityCallOptions struct {
	QueryDriveActivity []gax.CallOption
}

func defaultDriveActivityClientOptions() []option.ClientOption {
	return []option.ClientOption{
		internaloption.WithDefaultEndpoint("driveactivity.googleapis.com:443"),
		internaloption.WithDefaultMTLSEndpoint("driveactivity.mtls.googleapis.com:443"),
		internaloption.WithDefaultAudience("https://driveactivity.googleapis.com/"),
		internaloption.WithDefaultScopes(DefaultAuthScopes()...),
		option.WithGRPCDialOption(grpc.WithDisableServiceConfig()),
		option.WithGRPCDialOption(grpc.WithDefaultCallOptions(
			grpc.MaxCallRecvMsgSize(math.MaxInt32))),
	}
}

func defaultDriveActivityCallOptions() *DriveActivityCallOptions {
	return &DriveActivityCallOptions{
		QueryDriveActivity: []gax.CallOption{
			gax.WithRetry(func() gax.Retryer {
				return gax.OnCodes([]codes.Code{
					codes.Unavailable,
				}, gax.Backoff{
					Initial:    1000 * time.Millisecond,
					Max:        60000 * time.Millisecond,
					Multiplier: 1.30,
				})
			}),
		},
	}
}

// DriveActivityClient is a client for interacting with Drive Activity API.
//
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
type DriveActivityClient struct {
	// Connection pool of gRPC connections to the service.
	connPool gtransport.ConnPool

	// flag to opt out of default deadlines via GOOGLE_API_GO_EXPERIMENTAL_DISABLE_DEFAULT_DEADLINE
	disableDeadlines bool

	// The gRPC API client.
	driveActivityClient activitypb.DriveActivityServiceClient

	// The call options for this service.
	CallOptions *DriveActivityCallOptions

	// The x-goog-* metadata to be sent with each request.
	xGoogMetadata metadata.MD
}

// NewDriveActivityClient creates a new drive activity service client.
//
// Service for querying activity on Drive items. Activity is user
// or system action on Drive items that happened in the past. A Drive item can
// be a file or folder, or a Team Drive.
func NewDriveActivityClient(ctx context.Context, opts ...option.ClientOption) (*DriveActivityClient, error) {
	clientOpts := defaultDriveActivityClientOptions()

	if newDriveActivityClientHook != nil {
		hookOpts, err := newDriveActivityClientHook(ctx, clientHookParams{})
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
	c := &DriveActivityClient{
		connPool:         connPool,
		disableDeadlines: disableDeadlines,
		CallOptions:      defaultDriveActivityCallOptions(),

		driveActivityClient: activitypb.NewDriveActivityServiceClient(connPool),
	}
	c.setGoogleClientInfo()

	return c, nil
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *DriveActivityClient) Connection() *grpc.ClientConn {
	return c.connPool.Conn()
}

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *DriveActivityClient) Close() error {
	return c.connPool.Close()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *DriveActivityClient) setGoogleClientInfo(keyval ...string) {
	kv := append([]string{"gl-go", versionGo()}, keyval...)
	kv = append(kv, "gapic", versionClient, "gax", gax.Version, "grpc", grpc.Version)
	c.xGoogMetadata = metadata.Pairs("x-goog-api-client", gax.XGoogHeader(kv...))
}

// QueryDriveActivity query past activity in Google Drive.
func (c *DriveActivityClient) QueryDriveActivity(ctx context.Context, req *activitypb.QueryDriveActivityRequest, opts ...gax.CallOption) *DriveActivityIterator {
	ctx = insertMetadata(ctx, c.xGoogMetadata)
	opts = append(c.CallOptions.QueryDriveActivity[0:len(c.CallOptions.QueryDriveActivity):len(c.CallOptions.QueryDriveActivity)], opts...)
	it := &DriveActivityIterator{}
	req = proto.Clone(req).(*activitypb.QueryDriveActivityRequest)
	it.InternalFetch = func(pageSize int, pageToken string) ([]*activitypb.DriveActivity, string, error) {
		var resp *activitypb.QueryDriveActivityResponse
		req.PageToken = pageToken
		if pageSize > math.MaxInt32 {
			req.PageSize = math.MaxInt32
		} else {
			req.PageSize = int32(pageSize)
		}
		err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
			var err error
			resp, err = c.driveActivityClient.QueryDriveActivity(ctx, req, settings.GRPC...)
			return err
		}, opts...)
		if err != nil {
			return nil, "", err
		}

		it.Response = resp
		return resp.GetActivities(), resp.GetNextPageToken(), nil
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

// DriveActivityIterator manages a stream of *activitypb.DriveActivity.
type DriveActivityIterator struct {
	items    []*activitypb.DriveActivity
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
	InternalFetch func(pageSize int, pageToken string) (results []*activitypb.DriveActivity, nextPageToken string, err error)
}

// PageInfo supports pagination. See the google.golang.org/api/iterator package for details.
func (it *DriveActivityIterator) PageInfo() *iterator.PageInfo {
	return it.pageInfo
}

// Next returns the next result. Its second return value is iterator.Done if there are no more
// results. Once Next returns Done, all subsequent calls will return Done.
func (it *DriveActivityIterator) Next() (*activitypb.DriveActivity, error) {
	var item *activitypb.DriveActivity
	if err := it.nextFunc(); err != nil {
		return item, err
	}
	item = it.items[0]
	it.items = it.items[1:]
	return item, nil
}

func (it *DriveActivityIterator) bufLen() int {
	return len(it.items)
}

func (it *DriveActivityIterator) takeBuf() interface{} {
	b := it.items
	it.items = nil
	return b
}
