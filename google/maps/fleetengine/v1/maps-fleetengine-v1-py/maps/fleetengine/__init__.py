# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

from maps.fleetengine_v1.services.trip_service.client import TripServiceClient
from maps.fleetengine_v1.services.trip_service.async_client import TripServiceAsyncClient
from maps.fleetengine_v1.services.vehicle_service.client import VehicleServiceClient
from maps.fleetengine_v1.services.vehicle_service.async_client import VehicleServiceAsyncClient

from maps.fleetengine_v1.types.fleetengine import Address
from maps.fleetengine_v1.types.fleetengine import FormattedAddress
from maps.fleetengine_v1.types.fleetengine import Status
from maps.fleetengine_v1.types.fleetengine import TerminalLocation
from maps.fleetengine_v1.types.fleetengine import TerminalPointId
from maps.fleetengine_v1.types.fleetengine import TripWaypoint
from maps.fleetengine_v1.types.fleetengine import VehicleAttribute
from maps.fleetengine_v1.types.fleetengine import VehicleLocation
from maps.fleetengine_v1.types.fleetengine import LocationSensor
from maps.fleetengine_v1.types.fleetengine import NavigationStatus
from maps.fleetengine_v1.types.fleetengine import PolylineFormatType
from maps.fleetengine_v1.types.fleetengine import TripType
from maps.fleetengine_v1.types.fleetengine import WaypointType
from maps.fleetengine_v1.types.header import RequestHeader
from maps.fleetengine_v1.types.trip_api import CreateTripRequest
from maps.fleetengine_v1.types.trip_api import GetTripRequest
from maps.fleetengine_v1.types.trip_api import ReportBillableTripRequest
from maps.fleetengine_v1.types.trip_api import SearchTripsRequest
from maps.fleetengine_v1.types.trip_api import SearchTripsResponse
from maps.fleetengine_v1.types.trip_api import UpdateTripRequest
from maps.fleetengine_v1.types.trips import StopLocation
from maps.fleetengine_v1.types.trips import Trip
from maps.fleetengine_v1.types.trips import BillingPlatformIdentifier
from maps.fleetengine_v1.types.trips import TripStatus
from maps.fleetengine_v1.types.trips import TripView
from maps.fleetengine_v1.types.vehicle_api import CreateVehicleRequest
from maps.fleetengine_v1.types.vehicle_api import GetVehicleRequest
from maps.fleetengine_v1.types.vehicle_api import ListVehiclesRequest
from maps.fleetengine_v1.types.vehicle_api import ListVehiclesResponse
from maps.fleetengine_v1.types.vehicle_api import SearchVehiclesRequest
from maps.fleetengine_v1.types.vehicle_api import SearchVehiclesResponse
from maps.fleetengine_v1.types.vehicle_api import UpdateVehicleAttributesRequest
from maps.fleetengine_v1.types.vehicle_api import UpdateVehicleAttributesResponse
from maps.fleetengine_v1.types.vehicle_api import UpdateVehicleLocationRequest
from maps.fleetengine_v1.types.vehicle_api import UpdateVehicleRequest
from maps.fleetengine_v1.types.vehicle_api import VehicleAttributeList
from maps.fleetengine_v1.types.vehicle_api import VehicleMatch
from maps.fleetengine_v1.types.vehicle_api import Waypoint
from maps.fleetengine_v1.types.vehicles import BatteryInfo
from maps.fleetengine_v1.types.vehicles import DeviceSettings
from maps.fleetengine_v1.types.vehicles import LicensePlate
from maps.fleetengine_v1.types.vehicles import Vehicle
from maps.fleetengine_v1.types.vehicles import BatteryStatus
from maps.fleetengine_v1.types.vehicles import LocationPowerSaveMode
from maps.fleetengine_v1.types.vehicles import PowerSource
from maps.fleetengine_v1.types.vehicles import VehicleState

__all__ = ('TripServiceClient',
    'TripServiceAsyncClient',
    'VehicleServiceClient',
    'VehicleServiceAsyncClient',
    'Address',
    'FormattedAddress',
    'Status',
    'TerminalLocation',
    'TerminalPointId',
    'TripWaypoint',
    'VehicleAttribute',
    'VehicleLocation',
    'LocationSensor',
    'NavigationStatus',
    'PolylineFormatType',
    'TripType',
    'WaypointType',
    'RequestHeader',
    'CreateTripRequest',
    'GetTripRequest',
    'ReportBillableTripRequest',
    'SearchTripsRequest',
    'SearchTripsResponse',
    'UpdateTripRequest',
    'StopLocation',
    'Trip',
    'BillingPlatformIdentifier',
    'TripStatus',
    'TripView',
    'CreateVehicleRequest',
    'GetVehicleRequest',
    'ListVehiclesRequest',
    'ListVehiclesResponse',
    'SearchVehiclesRequest',
    'SearchVehiclesResponse',
    'UpdateVehicleAttributesRequest',
    'UpdateVehicleAttributesResponse',
    'UpdateVehicleLocationRequest',
    'UpdateVehicleRequest',
    'VehicleAttributeList',
    'VehicleMatch',
    'Waypoint',
    'BatteryInfo',
    'DeviceSettings',
    'LicensePlate',
    'Vehicle',
    'BatteryStatus',
    'LocationPowerSaveMode',
    'PowerSource',
    'VehicleState',
)
