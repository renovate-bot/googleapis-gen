// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Code generated by protoc-gen-go. DO NOT EDIT.
// versions:
// 	protoc-gen-go v1.25.0
// 	protoc        v3.15.3
// source: google/cloud/tasks/v2/task.proto

package tasks

import (
	proto "github.com/golang/protobuf/proto"
	_ "google.golang.org/genproto/googleapis/api/annotations"
	status "google.golang.org/genproto/googleapis/rpc/status"
	protoreflect "google.golang.org/protobuf/reflect/protoreflect"
	protoimpl "google.golang.org/protobuf/runtime/protoimpl"
	durationpb "google.golang.org/protobuf/types/known/durationpb"
	timestamppb "google.golang.org/protobuf/types/known/timestamppb"
	reflect "reflect"
	sync "sync"
)

const (
	// Verify that this generated code is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(20 - protoimpl.MinVersion)
	// Verify that runtime/protoimpl is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(protoimpl.MaxVersion - 20)
)

// This is a compile-time assertion that a sufficiently up-to-date version
// of the legacy proto package is being used.
const _ = proto.ProtoPackageIsVersion4

// The view specifies a subset of [Task][google.cloud.tasks.v2.Task] data.
//
// When a task is returned in a response, not all
// information is retrieved by default because some data, such as
// payloads, might be desirable to return only when needed because
// of its large size or because of the sensitivity of data that it
// contains.
type Task_View int32

const (
	// Unspecified. Defaults to BASIC.
	Task_VIEW_UNSPECIFIED Task_View = 0
	// The basic view omits fields which can be large or can contain
	// sensitive data.
	//
	// This view does not include the
	// [body in AppEngineHttpRequest][google.cloud.tasks.v2.AppEngineHttpRequest.body].
	// Bodies are desirable to return only when needed, because they
	// can be large and because of the sensitivity of the data that you
	// choose to store in it.
	Task_BASIC Task_View = 1
	// All information is returned.
	//
	// Authorization for [FULL][google.cloud.tasks.v2.Task.View.FULL] requires
	// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/)
	// permission on the [Queue][google.cloud.tasks.v2.Queue] resource.
	Task_FULL Task_View = 2
)

// Enum value maps for Task_View.
var (
	Task_View_name = map[int32]string{
		0: "VIEW_UNSPECIFIED",
		1: "BASIC",
		2: "FULL",
	}
	Task_View_value = map[string]int32{
		"VIEW_UNSPECIFIED": 0,
		"BASIC":            1,
		"FULL":             2,
	}
)

func (x Task_View) Enum() *Task_View {
	p := new(Task_View)
	*p = x
	return p
}

func (x Task_View) String() string {
	return protoimpl.X.EnumStringOf(x.Descriptor(), protoreflect.EnumNumber(x))
}

func (Task_View) Descriptor() protoreflect.EnumDescriptor {
	return file_google_cloud_tasks_v2_task_proto_enumTypes[0].Descriptor()
}

func (Task_View) Type() protoreflect.EnumType {
	return &file_google_cloud_tasks_v2_task_proto_enumTypes[0]
}

func (x Task_View) Number() protoreflect.EnumNumber {
	return protoreflect.EnumNumber(x)
}

// Deprecated: Use Task_View.Descriptor instead.
func (Task_View) EnumDescriptor() ([]byte, []int) {
	return file_google_cloud_tasks_v2_task_proto_rawDescGZIP(), []int{0, 0}
}

// A unit of scheduled work.
type Task struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Optionally caller-specified in [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask].
	//
	// The task name.
	//
	// The task name must have the following format:
	// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
	//
	// * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]),
	//    hyphens (-), colons (:), or periods (.).
	//    For more information, see
	//    [Identifying
	//    projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
	// * `LOCATION_ID` is the canonical ID for the task's location.
	//    The list of available locations can be obtained by calling
	//    [ListLocations][google.cloud.location.Locations.ListLocations].
	//    For more information, see https://cloud.google.com/about/locations/.
	// * `QUEUE_ID` can contain letters ([A-Za-z]), numbers ([0-9]), or
	//   hyphens (-). The maximum length is 100 characters.
	// * `TASK_ID` can contain only letters ([A-Za-z]), numbers ([0-9]),
	//   hyphens (-), or underscores (_). The maximum length is 500 characters.
	Name string `protobuf:"bytes,1,opt,name=name,proto3" json:"name,omitempty"`
	// Required. The message to send to the worker.
	//
	// Types that are assignable to MessageType:
	//	*Task_AppEngineHttpRequest
	//	*Task_HttpRequest
	MessageType isTask_MessageType `protobuf_oneof:"message_type"`
	// The time when the task is scheduled to be attempted or retried.
	//
	// `schedule_time` will be truncated to the nearest microsecond.
	ScheduleTime *timestamppb.Timestamp `protobuf:"bytes,4,opt,name=schedule_time,json=scheduleTime,proto3" json:"schedule_time,omitempty"`
	// Output only. The time that the task was created.
	//
	// `create_time` will be truncated to the nearest second.
	CreateTime *timestamppb.Timestamp `protobuf:"bytes,5,opt,name=create_time,json=createTime,proto3" json:"create_time,omitempty"`
	// The deadline for requests sent to the worker. If the worker does not
	// respond by this deadline then the request is cancelled and the attempt
	// is marked as a `DEADLINE_EXCEEDED` failure. Cloud Tasks will retry the
	// task according to the [RetryConfig][google.cloud.tasks.v2.RetryConfig].
	//
	// Note that when the request is cancelled, Cloud Tasks will stop listing for
	// the response, but whether the worker stops processing depends on the
	// worker. For example, if the worker is stuck, it may not react to cancelled
	// requests.
	//
	// The default and maximum values depend on the type of request:
	//
	// * For [HTTP tasks][google.cloud.tasks.v2.HttpRequest], the default is 10 minutes. The deadline
	//   must be in the interval [15 seconds, 30 minutes].
	//
	// * For [App Engine tasks][google.cloud.tasks.v2.AppEngineHttpRequest], 0 indicates that the
	//   request has the default deadline. The default deadline depends on the
	//   [scaling
	//   type](https://cloud.google.com/appengine/docs/standard/go/how-instances-are-managed#instance_scaling)
	//   of the service: 10 minutes for standard apps with automatic scaling, 24
	//   hours for standard apps with manual and basic scaling, and 60 minutes for
	//   flex apps. If the request deadline is set, it must be in the interval [15
	//   seconds, 24 hours 15 seconds]. Regardless of the task's
	//   `dispatch_deadline`, the app handler will not run for longer than than
	//   the service's timeout. We recommend setting the `dispatch_deadline` to
	//   at most a few seconds more than the app handler's timeout. For more
	//   information see
	//   [Timeouts](https://cloud.google.com/tasks/docs/creating-appengine-handlers#timeouts).
	//
	// `dispatch_deadline` will be truncated to the nearest millisecond. The
	// deadline is an approximate deadline.
	DispatchDeadline *durationpb.Duration `protobuf:"bytes,6,opt,name=dispatch_deadline,json=dispatchDeadline,proto3" json:"dispatch_deadline,omitempty"`
	// Output only. The number of attempts dispatched.
	//
	// This count includes attempts which have been dispatched but haven't
	// received a response.
	DispatchCount int32 `protobuf:"varint,7,opt,name=dispatch_count,json=dispatchCount,proto3" json:"dispatch_count,omitempty"`
	// Output only. The number of attempts which have received a response.
	ResponseCount int32 `protobuf:"varint,8,opt,name=response_count,json=responseCount,proto3" json:"response_count,omitempty"`
	// Output only. The status of the task's first attempt.
	//
	// Only [dispatch_time][google.cloud.tasks.v2.Attempt.dispatch_time] will be set.
	// The other [Attempt][google.cloud.tasks.v2.Attempt] information is not retained by Cloud Tasks.
	FirstAttempt *Attempt `protobuf:"bytes,9,opt,name=first_attempt,json=firstAttempt,proto3" json:"first_attempt,omitempty"`
	// Output only. The status of the task's last attempt.
	LastAttempt *Attempt `protobuf:"bytes,10,opt,name=last_attempt,json=lastAttempt,proto3" json:"last_attempt,omitempty"`
	// Output only. The view specifies which subset of the [Task][google.cloud.tasks.v2.Task] has
	// been returned.
	View Task_View `protobuf:"varint,11,opt,name=view,proto3,enum=google.cloud.tasks.v2.Task_View" json:"view,omitempty"`
}

func (x *Task) Reset() {
	*x = Task{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_tasks_v2_task_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Task) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Task) ProtoMessage() {}

func (x *Task) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_tasks_v2_task_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Task.ProtoReflect.Descriptor instead.
func (*Task) Descriptor() ([]byte, []int) {
	return file_google_cloud_tasks_v2_task_proto_rawDescGZIP(), []int{0}
}

func (x *Task) GetName() string {
	if x != nil {
		return x.Name
	}
	return ""
}

func (m *Task) GetMessageType() isTask_MessageType {
	if m != nil {
		return m.MessageType
	}
	return nil
}

func (x *Task) GetAppEngineHttpRequest() *AppEngineHttpRequest {
	if x, ok := x.GetMessageType().(*Task_AppEngineHttpRequest); ok {
		return x.AppEngineHttpRequest
	}
	return nil
}

func (x *Task) GetHttpRequest() *HttpRequest {
	if x, ok := x.GetMessageType().(*Task_HttpRequest); ok {
		return x.HttpRequest
	}
	return nil
}

func (x *Task) GetScheduleTime() *timestamppb.Timestamp {
	if x != nil {
		return x.ScheduleTime
	}
	return nil
}

func (x *Task) GetCreateTime() *timestamppb.Timestamp {
	if x != nil {
		return x.CreateTime
	}
	return nil
}

func (x *Task) GetDispatchDeadline() *durationpb.Duration {
	if x != nil {
		return x.DispatchDeadline
	}
	return nil
}

func (x *Task) GetDispatchCount() int32 {
	if x != nil {
		return x.DispatchCount
	}
	return 0
}

func (x *Task) GetResponseCount() int32 {
	if x != nil {
		return x.ResponseCount
	}
	return 0
}

func (x *Task) GetFirstAttempt() *Attempt {
	if x != nil {
		return x.FirstAttempt
	}
	return nil
}

func (x *Task) GetLastAttempt() *Attempt {
	if x != nil {
		return x.LastAttempt
	}
	return nil
}

func (x *Task) GetView() Task_View {
	if x != nil {
		return x.View
	}
	return Task_VIEW_UNSPECIFIED
}

type isTask_MessageType interface {
	isTask_MessageType()
}

type Task_AppEngineHttpRequest struct {
	// HTTP request that is sent to the App Engine app handler.
	//
	// An App Engine task is a task that has [AppEngineHttpRequest][google.cloud.tasks.v2.AppEngineHttpRequest] set.
	AppEngineHttpRequest *AppEngineHttpRequest `protobuf:"bytes,2,opt,name=app_engine_http_request,json=appEngineHttpRequest,proto3,oneof"`
}

type Task_HttpRequest struct {
	// HTTP request that is sent to the worker.
	//
	// An HTTP task is a task that has [HttpRequest][google.cloud.tasks.v2.HttpRequest] set.
	HttpRequest *HttpRequest `protobuf:"bytes,3,opt,name=http_request,json=httpRequest,proto3,oneof"`
}

func (*Task_AppEngineHttpRequest) isTask_MessageType() {}

func (*Task_HttpRequest) isTask_MessageType() {}

// The status of a task attempt.
type Attempt struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Output only. The time that this attempt was scheduled.
	//
	// `schedule_time` will be truncated to the nearest microsecond.
	ScheduleTime *timestamppb.Timestamp `protobuf:"bytes,1,opt,name=schedule_time,json=scheduleTime,proto3" json:"schedule_time,omitempty"`
	// Output only. The time that this attempt was dispatched.
	//
	// `dispatch_time` will be truncated to the nearest microsecond.
	DispatchTime *timestamppb.Timestamp `protobuf:"bytes,2,opt,name=dispatch_time,json=dispatchTime,proto3" json:"dispatch_time,omitempty"`
	// Output only. The time that this attempt response was received.
	//
	// `response_time` will be truncated to the nearest microsecond.
	ResponseTime *timestamppb.Timestamp `protobuf:"bytes,3,opt,name=response_time,json=responseTime,proto3" json:"response_time,omitempty"`
	// Output only. The response from the worker for this attempt.
	//
	// If `response_time` is unset, then the task has not been attempted or is
	// currently running and the `response_status` field is meaningless.
	ResponseStatus *status.Status `protobuf:"bytes,4,opt,name=response_status,json=responseStatus,proto3" json:"response_status,omitempty"`
}

func (x *Attempt) Reset() {
	*x = Attempt{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_tasks_v2_task_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Attempt) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Attempt) ProtoMessage() {}

func (x *Attempt) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_tasks_v2_task_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Attempt.ProtoReflect.Descriptor instead.
func (*Attempt) Descriptor() ([]byte, []int) {
	return file_google_cloud_tasks_v2_task_proto_rawDescGZIP(), []int{1}
}

func (x *Attempt) GetScheduleTime() *timestamppb.Timestamp {
	if x != nil {
		return x.ScheduleTime
	}
	return nil
}

func (x *Attempt) GetDispatchTime() *timestamppb.Timestamp {
	if x != nil {
		return x.DispatchTime
	}
	return nil
}

func (x *Attempt) GetResponseTime() *timestamppb.Timestamp {
	if x != nil {
		return x.ResponseTime
	}
	return nil
}

func (x *Attempt) GetResponseStatus() *status.Status {
	if x != nil {
		return x.ResponseStatus
	}
	return nil
}

var File_google_cloud_tasks_v2_task_proto protoreflect.FileDescriptor

var file_google_cloud_tasks_v2_task_proto_rawDesc = []byte{
	0x0a, 0x20, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x74,
	0x61, 0x73, 0x6b, 0x73, 0x2f, 0x76, 0x32, 0x2f, 0x74, 0x61, 0x73, 0x6b, 0x2e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x12, 0x15, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x2e, 0x76, 0x32, 0x1a, 0x19, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x72, 0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x2e, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x22, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f,
	0x75, 0x64, 0x2f, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x2f, 0x76, 0x32, 0x2f, 0x74, 0x61, 0x72, 0x67,
	0x65, 0x74, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x1e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x2f, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2f, 0x64, 0x75, 0x72, 0x61, 0x74, 0x69,
	0x6f, 0x6e, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x1f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x2f, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2f, 0x74, 0x69, 0x6d, 0x65, 0x73, 0x74,
	0x61, 0x6d, 0x70, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x17, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x2f, 0x72, 0x70, 0x63, 0x2f, 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x2e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x1a, 0x1c, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x61,
	0x6e, 0x6e, 0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f,
	0x22, 0xc8, 0x06, 0x0a, 0x04, 0x54, 0x61, 0x73, 0x6b, 0x12, 0x12, 0x0a, 0x04, 0x6e, 0x61, 0x6d,
	0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x04, 0x6e, 0x61, 0x6d, 0x65, 0x12, 0x64, 0x0a,
	0x17, 0x61, 0x70, 0x70, 0x5f, 0x65, 0x6e, 0x67, 0x69, 0x6e, 0x65, 0x5f, 0x68, 0x74, 0x74, 0x70,
	0x5f, 0x72, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x18, 0x02, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x2b,
	0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61,
	0x73, 0x6b, 0x73, 0x2e, 0x76, 0x32, 0x2e, 0x41, 0x70, 0x70, 0x45, 0x6e, 0x67, 0x69, 0x6e, 0x65,
	0x48, 0x74, 0x74, 0x70, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x48, 0x00, 0x52, 0x14, 0x61,
	0x70, 0x70, 0x45, 0x6e, 0x67, 0x69, 0x6e, 0x65, 0x48, 0x74, 0x74, 0x70, 0x52, 0x65, 0x71, 0x75,
	0x65, 0x73, 0x74, 0x12, 0x47, 0x0a, 0x0c, 0x68, 0x74, 0x74, 0x70, 0x5f, 0x72, 0x65, 0x71, 0x75,
	0x65, 0x73, 0x74, 0x18, 0x03, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x22, 0x2e, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x2e, 0x76,
	0x32, 0x2e, 0x48, 0x74, 0x74, 0x70, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x48, 0x00, 0x52,
	0x0b, 0x68, 0x74, 0x74, 0x70, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x12, 0x3f, 0x0a, 0x0d,
	0x73, 0x63, 0x68, 0x65, 0x64, 0x75, 0x6c, 0x65, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x04, 0x20,
	0x01, 0x28, 0x0b, 0x32, 0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x62, 0x75, 0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x52,
	0x0c, 0x73, 0x63, 0x68, 0x65, 0x64, 0x75, 0x6c, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x3b, 0x0a,
	0x0b, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x05, 0x20, 0x01,
	0x28, 0x0b, 0x32, 0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74,
	0x6f, 0x62, 0x75, 0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x52, 0x0a,
	0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x46, 0x0a, 0x11, 0x64, 0x69,
	0x73, 0x70, 0x61, 0x74, 0x63, 0x68, 0x5f, 0x64, 0x65, 0x61, 0x64, 0x6c, 0x69, 0x6e, 0x65, 0x18,
	0x06, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x19, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2e, 0x44, 0x75, 0x72, 0x61, 0x74, 0x69, 0x6f, 0x6e,
	0x52, 0x10, 0x64, 0x69, 0x73, 0x70, 0x61, 0x74, 0x63, 0x68, 0x44, 0x65, 0x61, 0x64, 0x6c, 0x69,
	0x6e, 0x65, 0x12, 0x25, 0x0a, 0x0e, 0x64, 0x69, 0x73, 0x70, 0x61, 0x74, 0x63, 0x68, 0x5f, 0x63,
	0x6f, 0x75, 0x6e, 0x74, 0x18, 0x07, 0x20, 0x01, 0x28, 0x05, 0x52, 0x0d, 0x64, 0x69, 0x73, 0x70,
	0x61, 0x74, 0x63, 0x68, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x12, 0x25, 0x0a, 0x0e, 0x72, 0x65, 0x73,
	0x70, 0x6f, 0x6e, 0x73, 0x65, 0x5f, 0x63, 0x6f, 0x75, 0x6e, 0x74, 0x18, 0x08, 0x20, 0x01, 0x28,
	0x05, 0x52, 0x0d, 0x72, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x43, 0x6f, 0x75, 0x6e, 0x74,
	0x12, 0x43, 0x0a, 0x0d, 0x66, 0x69, 0x72, 0x73, 0x74, 0x5f, 0x61, 0x74, 0x74, 0x65, 0x6d, 0x70,
	0x74, 0x18, 0x09, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x1e, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x2e, 0x76, 0x32, 0x2e,
	0x41, 0x74, 0x74, 0x65, 0x6d, 0x70, 0x74, 0x52, 0x0c, 0x66, 0x69, 0x72, 0x73, 0x74, 0x41, 0x74,
	0x74, 0x65, 0x6d, 0x70, 0x74, 0x12, 0x41, 0x0a, 0x0c, 0x6c, 0x61, 0x73, 0x74, 0x5f, 0x61, 0x74,
	0x74, 0x65, 0x6d, 0x70, 0x74, 0x18, 0x0a, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x1e, 0x2e, 0x67, 0x6f,
	0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61, 0x73, 0x6b, 0x73,
	0x2e, 0x76, 0x32, 0x2e, 0x41, 0x74, 0x74, 0x65, 0x6d, 0x70, 0x74, 0x52, 0x0b, 0x6c, 0x61, 0x73,
	0x74, 0x41, 0x74, 0x74, 0x65, 0x6d, 0x70, 0x74, 0x12, 0x34, 0x0a, 0x04, 0x76, 0x69, 0x65, 0x77,
	0x18, 0x0b, 0x20, 0x01, 0x28, 0x0e, 0x32, 0x20, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e,
	0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x2e, 0x76, 0x32, 0x2e, 0x54,
	0x61, 0x73, 0x6b, 0x2e, 0x56, 0x69, 0x65, 0x77, 0x52, 0x04, 0x76, 0x69, 0x65, 0x77, 0x22, 0x31,
	0x0a, 0x04, 0x56, 0x69, 0x65, 0x77, 0x12, 0x14, 0x0a, 0x10, 0x56, 0x49, 0x45, 0x57, 0x5f, 0x55,
	0x4e, 0x53, 0x50, 0x45, 0x43, 0x49, 0x46, 0x49, 0x45, 0x44, 0x10, 0x00, 0x12, 0x09, 0x0a, 0x05,
	0x42, 0x41, 0x53, 0x49, 0x43, 0x10, 0x01, 0x12, 0x08, 0x0a, 0x04, 0x46, 0x55, 0x4c, 0x4c, 0x10,
	0x02, 0x3a, 0x68, 0xea, 0x41, 0x65, 0x0a, 0x1e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x74, 0x61, 0x73,
	0x6b, 0x73, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f,
	0x6d, 0x2f, 0x54, 0x61, 0x73, 0x6b, 0x12, 0x43, 0x70, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x73,
	0x2f, 0x7b, 0x70, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x7d, 0x2f, 0x6c, 0x6f, 0x63, 0x61, 0x74,
	0x69, 0x6f, 0x6e, 0x73, 0x2f, 0x7b, 0x6c, 0x6f, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x7d, 0x2f,
	0x71, 0x75, 0x65, 0x75, 0x65, 0x73, 0x2f, 0x7b, 0x71, 0x75, 0x65, 0x75, 0x65, 0x7d, 0x2f, 0x74,
	0x61, 0x73, 0x6b, 0x73, 0x2f, 0x7b, 0x74, 0x61, 0x73, 0x6b, 0x7d, 0x42, 0x0e, 0x0a, 0x0c, 0x6d,
	0x65, 0x73, 0x73, 0x61, 0x67, 0x65, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x22, 0x89, 0x02, 0x0a, 0x07,
	0x41, 0x74, 0x74, 0x65, 0x6d, 0x70, 0x74, 0x12, 0x3f, 0x0a, 0x0d, 0x73, 0x63, 0x68, 0x65, 0x64,
	0x75, 0x6c, 0x65, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x1a,
	0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66,
	0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x52, 0x0c, 0x73, 0x63, 0x68, 0x65,
	0x64, 0x75, 0x6c, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x3f, 0x0a, 0x0d, 0x64, 0x69, 0x73, 0x70,
	0x61, 0x74, 0x63, 0x68, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x02, 0x20, 0x01, 0x28, 0x0b, 0x32,
	0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75,
	0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x52, 0x0c, 0x64, 0x69, 0x73,
	0x70, 0x61, 0x74, 0x63, 0x68, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x3f, 0x0a, 0x0d, 0x72, 0x65, 0x73,
	0x70, 0x6f, 0x6e, 0x73, 0x65, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x03, 0x20, 0x01, 0x28, 0x0b,
	0x32, 0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62,
	0x75, 0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x52, 0x0c, 0x72, 0x65,
	0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x3b, 0x0a, 0x0f, 0x72, 0x65,
	0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x5f, 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x18, 0x04, 0x20,
	0x01, 0x28, 0x0b, 0x32, 0x12, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x72, 0x70, 0x63,
	0x2e, 0x53, 0x74, 0x61, 0x74, 0x75, 0x73, 0x52, 0x0e, 0x72, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73,
	0x65, 0x53, 0x74, 0x61, 0x74, 0x75, 0x73, 0x42, 0x64, 0x0a, 0x19, 0x63, 0x6f, 0x6d, 0x2e, 0x67,
	0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x74, 0x61, 0x73, 0x6b,
	0x73, 0x2e, 0x76, 0x32, 0x42, 0x09, 0x54, 0x61, 0x73, 0x6b, 0x50, 0x72, 0x6f, 0x74, 0x6f, 0x50,
	0x01, 0x5a, 0x3a, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x67, 0x6f, 0x6c, 0x61, 0x6e, 0x67,
	0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x6f,
	0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x74,
	0x61, 0x73, 0x6b, 0x73, 0x2f, 0x76, 0x32, 0x3b, 0x74, 0x61, 0x73, 0x6b, 0x73, 0x62, 0x06, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_google_cloud_tasks_v2_task_proto_rawDescOnce sync.Once
	file_google_cloud_tasks_v2_task_proto_rawDescData = file_google_cloud_tasks_v2_task_proto_rawDesc
)

func file_google_cloud_tasks_v2_task_proto_rawDescGZIP() []byte {
	file_google_cloud_tasks_v2_task_proto_rawDescOnce.Do(func() {
		file_google_cloud_tasks_v2_task_proto_rawDescData = protoimpl.X.CompressGZIP(file_google_cloud_tasks_v2_task_proto_rawDescData)
	})
	return file_google_cloud_tasks_v2_task_proto_rawDescData
}

var file_google_cloud_tasks_v2_task_proto_enumTypes = make([]protoimpl.EnumInfo, 1)
var file_google_cloud_tasks_v2_task_proto_msgTypes = make([]protoimpl.MessageInfo, 2)
var file_google_cloud_tasks_v2_task_proto_goTypes = []interface{}{
	(Task_View)(0),                // 0: google.cloud.tasks.v2.Task.View
	(*Task)(nil),                  // 1: google.cloud.tasks.v2.Task
	(*Attempt)(nil),               // 2: google.cloud.tasks.v2.Attempt
	(*AppEngineHttpRequest)(nil),  // 3: google.cloud.tasks.v2.AppEngineHttpRequest
	(*HttpRequest)(nil),           // 4: google.cloud.tasks.v2.HttpRequest
	(*timestamppb.Timestamp)(nil), // 5: google.protobuf.Timestamp
	(*durationpb.Duration)(nil),   // 6: google.protobuf.Duration
	(*status.Status)(nil),         // 7: google.rpc.Status
}
var file_google_cloud_tasks_v2_task_proto_depIdxs = []int32{
	3,  // 0: google.cloud.tasks.v2.Task.app_engine_http_request:type_name -> google.cloud.tasks.v2.AppEngineHttpRequest
	4,  // 1: google.cloud.tasks.v2.Task.http_request:type_name -> google.cloud.tasks.v2.HttpRequest
	5,  // 2: google.cloud.tasks.v2.Task.schedule_time:type_name -> google.protobuf.Timestamp
	5,  // 3: google.cloud.tasks.v2.Task.create_time:type_name -> google.protobuf.Timestamp
	6,  // 4: google.cloud.tasks.v2.Task.dispatch_deadline:type_name -> google.protobuf.Duration
	2,  // 5: google.cloud.tasks.v2.Task.first_attempt:type_name -> google.cloud.tasks.v2.Attempt
	2,  // 6: google.cloud.tasks.v2.Task.last_attempt:type_name -> google.cloud.tasks.v2.Attempt
	0,  // 7: google.cloud.tasks.v2.Task.view:type_name -> google.cloud.tasks.v2.Task.View
	5,  // 8: google.cloud.tasks.v2.Attempt.schedule_time:type_name -> google.protobuf.Timestamp
	5,  // 9: google.cloud.tasks.v2.Attempt.dispatch_time:type_name -> google.protobuf.Timestamp
	5,  // 10: google.cloud.tasks.v2.Attempt.response_time:type_name -> google.protobuf.Timestamp
	7,  // 11: google.cloud.tasks.v2.Attempt.response_status:type_name -> google.rpc.Status
	12, // [12:12] is the sub-list for method output_type
	12, // [12:12] is the sub-list for method input_type
	12, // [12:12] is the sub-list for extension type_name
	12, // [12:12] is the sub-list for extension extendee
	0,  // [0:12] is the sub-list for field type_name
}

func init() { file_google_cloud_tasks_v2_task_proto_init() }
func file_google_cloud_tasks_v2_task_proto_init() {
	if File_google_cloud_tasks_v2_task_proto != nil {
		return
	}
	file_google_cloud_tasks_v2_target_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_google_cloud_tasks_v2_task_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Task); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_google_cloud_tasks_v2_task_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Attempt); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
	}
	file_google_cloud_tasks_v2_task_proto_msgTypes[0].OneofWrappers = []interface{}{
		(*Task_AppEngineHttpRequest)(nil),
		(*Task_HttpRequest)(nil),
	}
	type x struct{}
	out := protoimpl.TypeBuilder{
		File: protoimpl.DescBuilder{
			GoPackagePath: reflect.TypeOf(x{}).PkgPath(),
			RawDescriptor: file_google_cloud_tasks_v2_task_proto_rawDesc,
			NumEnums:      1,
			NumMessages:   2,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_google_cloud_tasks_v2_task_proto_goTypes,
		DependencyIndexes: file_google_cloud_tasks_v2_task_proto_depIdxs,
		EnumInfos:         file_google_cloud_tasks_v2_task_proto_enumTypes,
		MessageInfos:      file_google_cloud_tasks_v2_task_proto_msgTypes,
	}.Build()
	File_google_cloud_tasks_v2_task_proto = out.File
	file_google_cloud_tasks_v2_task_proto_rawDesc = nil
	file_google_cloud_tasks_v2_task_proto_goTypes = nil
	file_google_cloud_tasks_v2_task_proto_depIdxs = nil
}
