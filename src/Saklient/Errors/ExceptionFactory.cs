using Util = Saklient.Util;
using HttpException = Saklient.Errors.HttpException;
using HttpBadGatewayException = Saklient.Errors.HttpBadGatewayException;
using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;
using HttpConflictException = Saklient.Errors.HttpConflictException;
using HttpExpectationFailedException = Saklient.Errors.HttpExpectationFailedException;
using HttpFailedDependencyException = Saklient.Errors.HttpFailedDependencyException;
using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;
using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;
using HttpGoneException = Saklient.Errors.HttpGoneException;
using HttpHttpVersionNotSupportedException = Saklient.Errors.HttpHttpVersionNotSupportedException;
using HttpInsufficientStorageException = Saklient.Errors.HttpInsufficientStorageException;
using HttpInternalServerErrorException = Saklient.Errors.HttpInternalServerErrorException;
using HttpLengthRequiredException = Saklient.Errors.HttpLengthRequiredException;
using HttpLockedException = Saklient.Errors.HttpLockedException;
using HttpMethodNotAllowedException = Saklient.Errors.HttpMethodNotAllowedException;
using HttpNotAcceptableException = Saklient.Errors.HttpNotAcceptableException;
using HttpNotExtendedException = Saklient.Errors.HttpNotExtendedException;
using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;
using HttpNotImplementedException = Saklient.Errors.HttpNotImplementedException;
using HttpPaymentRequiredException = Saklient.Errors.HttpPaymentRequiredException;
using HttpPreconditionFailedException = Saklient.Errors.HttpPreconditionFailedException;
using HttpProxyAuthenticationRequiredException = Saklient.Errors.HttpProxyAuthenticationRequiredException;
using HttpRequestEntityTooLargeException = Saklient.Errors.HttpRequestEntityTooLargeException;
using HttpRequestTimeoutException = Saklient.Errors.HttpRequestTimeoutException;
using HttpRequestUriTooLongException = Saklient.Errors.HttpRequestUriTooLongException;
using HttpRequestedRangeNotSatisfiableException = Saklient.Errors.HttpRequestedRangeNotSatisfiableException;
using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;
using HttpUnauthorizedException = Saklient.Errors.HttpUnauthorizedException;
using HttpUnprocessableEntityException = Saklient.Errors.HttpUnprocessableEntityException;
using HttpUnsupportedMediaTypeException = Saklient.Errors.HttpUnsupportedMediaTypeException;
using HttpUpgradeRequiredException = Saklient.Errors.HttpUpgradeRequiredException;
using HttpVariantAlsoNegotiatesException = Saklient.Errors.HttpVariantAlsoNegotiatesException;
using AccessApiKeyDisabledException = Saklient.Cloud.Errors.AccessApiKeyDisabledException;
using AccessSakuraException = Saklient.Cloud.Errors.AccessSakuraException;
using AccessStaffException = Saklient.Cloud.Errors.AccessStaffException;
using AccessTokenException = Saklient.Cloud.Errors.AccessTokenException;
using AccessXhrOrApiKeyException = Saklient.Cloud.Errors.AccessXhrOrApiKeyException;
using AccountNotFoundException = Saklient.Cloud.Errors.AccountNotFoundException;
using AccountNotSpecifiedException = Saklient.Cloud.Errors.AccountNotSpecifiedException;
using AmbiguousIdentifierException = Saklient.Cloud.Errors.AmbiguousIdentifierException;
using AmbiguousZoneException = Saklient.Cloud.Errors.AmbiguousZoneException;
using ApiProxyTimeoutException = Saklient.Cloud.Errors.ApiProxyTimeoutException;
using ApiProxyTimeoutNonGetException = Saklient.Cloud.Errors.ApiProxyTimeoutNonGetException;
using ArchiveIsIncompleteException = Saklient.Cloud.Errors.ArchiveIsIncompleteException;
using BootFailureByLockException = Saklient.Cloud.Errors.BootFailureByLockException;
using BootFailureInGroupException = Saklient.Cloud.Errors.BootFailureInGroupException;
using BusyException = Saklient.Cloud.Errors.BusyException;
using CantResizeSmallerException = Saklient.Cloud.Errors.CantResizeSmallerException;
using CdromDeviceLockedException = Saklient.Cloud.Errors.CdromDeviceLockedException;
using CdromDisabledException = Saklient.Cloud.Errors.CdromDisabledException;
using CdromInUseException = Saklient.Cloud.Errors.CdromInUseException;
using CdromIsIncompleteException = Saklient.Cloud.Errors.CdromIsIncompleteException;
using ConnectToSameSwitchException = Saklient.Cloud.Errors.ConnectToSameSwitchException;
using ContractCreationException = Saklient.Cloud.Errors.ContractCreationException;
using CopyToItselfException = Saklient.Cloud.Errors.CopyToItselfException;
using DeleteDiskB4TemplateException = Saklient.Cloud.Errors.DeleteDiskB4TemplateException;
using DeleteIpV6NetsFirstException = Saklient.Cloud.Errors.DeleteIpV6NetsFirstException;
using DeleteResB4AccountException = Saklient.Cloud.Errors.DeleteResB4AccountException;
using DeleteRouterB4SwitchException = Saklient.Cloud.Errors.DeleteRouterB4SwitchException;
using DeleteStaticRouteFirstException = Saklient.Cloud.Errors.DeleteStaticRouteFirstException;
using DisabledInSandboxException = Saklient.Cloud.Errors.DisabledInSandboxException;
using DisconnectB4DeleteException = Saklient.Cloud.Errors.DisconnectB4DeleteException;
using DisconnectB4UpdateException = Saklient.Cloud.Errors.DisconnectB4UpdateException;
using DiskConnectionLimitException = Saklient.Cloud.Errors.DiskConnectionLimitException;
using DiskIsCopyingException = Saklient.Cloud.Errors.DiskIsCopyingException;
using DiskIsNotAvailableException = Saklient.Cloud.Errors.DiskIsNotAvailableException;
using DiskLicenseMismatchException = Saklient.Cloud.Errors.DiskLicenseMismatchException;
using DiskOrSsInMigrationException = Saklient.Cloud.Errors.DiskOrSsInMigrationException;
using DiskStockRunOutException = Saklient.Cloud.Errors.DiskStockRunOutException;
using DnsARecordNotFoundException = Saklient.Cloud.Errors.DnsARecordNotFoundException;
using DnsAaaaRecordNotFoundException = Saklient.Cloud.Errors.DnsAaaaRecordNotFoundException;
using DnsPtrUpdateFailureException = Saklient.Cloud.Errors.DnsPtrUpdateFailureException;
using DontCreateInSandboxException = Saklient.Cloud.Errors.DontCreateInSandboxException;
using DuplicateAccountCodeException = Saklient.Cloud.Errors.DuplicateAccountCodeException;
using DuplicateEntryException = Saklient.Cloud.Errors.DuplicateEntryException;
using DuplicateUserCodeException = Saklient.Cloud.Errors.DuplicateUserCodeException;
using FileNotUploadedException = Saklient.Cloud.Errors.FileNotUploadedException;
using FilterArrayComparisonException = Saklient.Cloud.Errors.FilterArrayComparisonException;
using FilterBadOperatorException = Saklient.Cloud.Errors.FilterBadOperatorException;
using FilterNullComparisonException = Saklient.Cloud.Errors.FilterNullComparisonException;
using FilterUnknownOperatorException = Saklient.Cloud.Errors.FilterUnknownOperatorException;
using FtpCannotCloseException = Saklient.Cloud.Errors.FtpCannotCloseException;
using FtpIsAlreadyCloseException = Saklient.Cloud.Errors.FtpIsAlreadyCloseException;
using FtpIsAlreadyOpenException = Saklient.Cloud.Errors.FtpIsAlreadyOpenException;
using FtpMustBeClosedException = Saklient.Cloud.Errors.FtpMustBeClosedException;
using HostOperationFailureException = Saklient.Cloud.Errors.HostOperationFailureException;
using IllegalDasUsageException = Saklient.Cloud.Errors.IllegalDasUsageException;
using InMigrationException = Saklient.Cloud.Errors.InMigrationException;
using InvalidFormatException = Saklient.Cloud.Errors.InvalidFormatException;
using InvalidParamCombException = Saklient.Cloud.Errors.InvalidParamCombException;
using InvalidRangeException = Saklient.Cloud.Errors.InvalidRangeException;
using InvalidUriArgumentException = Saklient.Cloud.Errors.InvalidUriArgumentException;
using IpV6NetAlreadyAttachedException = Saklient.Cloud.Errors.IpV6NetAlreadyAttachedException;
using LimitCountInAccountException = Saklient.Cloud.Errors.LimitCountInAccountException;
using LimitCountInMemberException = Saklient.Cloud.Errors.LimitCountInMemberException;
using LimitCountInNetworkException = Saklient.Cloud.Errors.LimitCountInNetworkException;
using LimitCountInRouterException = Saklient.Cloud.Errors.LimitCountInRouterException;
using LimitCountInZoneException = Saklient.Cloud.Errors.LimitCountInZoneException;
using LimitMemoryInAccountException = Saklient.Cloud.Errors.LimitMemoryInAccountException;
using LimitSizeInAccountException = Saklient.Cloud.Errors.LimitSizeInAccountException;
using MissingIsoImageException = Saklient.Cloud.Errors.MissingIsoImageException;
using MissingParamException = Saklient.Cloud.Errors.MissingParamException;
using MustBeOfSameZoneException = Saklient.Cloud.Errors.MustBeOfSameZoneException;
using NoDisplayResponseException = Saklient.Cloud.Errors.NoDisplayResponseException;
using NotForRouterException = Saklient.Cloud.Errors.NotForRouterException;
using NotReplicatingException = Saklient.Cloud.Errors.NotReplicatingException;
using NotWithHybridconnException = Saklient.Cloud.Errors.NotWithHybridconnException;
using OldStoragePlanException = Saklient.Cloud.Errors.OldStoragePlanException;
using OperationFailureException = Saklient.Cloud.Errors.OperationFailureException;
using OperationTimeoutException = Saklient.Cloud.Errors.OperationTimeoutException;
using OriginalHashMismatchException = Saklient.Cloud.Errors.OriginalHashMismatchException;
using PacketFilterApplyingException = Saklient.Cloud.Errors.PacketFilterApplyingException;
using PacketFilterVersionMismatchException = Saklient.Cloud.Errors.PacketFilterVersionMismatchException;
using ParamIpNotFoundException = Saklient.Cloud.Errors.ParamIpNotFoundException;
using ParamResNotFoundException = Saklient.Cloud.Errors.ParamResNotFoundException;
using PaymentCreditCardException = Saklient.Cloud.Errors.PaymentCreditCardException;
using PaymentPaymentException = Saklient.Cloud.Errors.PaymentPaymentException;
using PaymentRegistrationException = Saklient.Cloud.Errors.PaymentRegistrationException;
using PaymentTelCertificationException = Saklient.Cloud.Errors.PaymentTelCertificationException;
using PaymentUnpayableException = Saklient.Cloud.Errors.PaymentUnpayableException;
using PenaltyOperationException = Saklient.Cloud.Errors.PenaltyOperationException;
using ReplicaAlreadyExistsException = Saklient.Cloud.Errors.ReplicaAlreadyExistsException;
using ReplicaNotFoundException = Saklient.Cloud.Errors.ReplicaNotFoundException;
using ResAlreadyConnectedException = Saklient.Cloud.Errors.ResAlreadyConnectedException;
using ResAlreadyDisconnectedException = Saklient.Cloud.Errors.ResAlreadyDisconnectedException;
using ResAlreadyExistsException = Saklient.Cloud.Errors.ResAlreadyExistsException;
using ResUsedInZoneException = Saklient.Cloud.Errors.ResUsedInZoneException;
using ResourcePathNotFoundException = Saklient.Cloud.Errors.ResourcePathNotFoundException;
using RunOutOfIpAddressException = Saklient.Cloud.Errors.RunOutOfIpAddressException;
using SameLicenseRequiredException = Saklient.Cloud.Errors.SameLicenseRequiredException;
using ServerCouldNotStopException = Saklient.Cloud.Errors.ServerCouldNotStopException;
using ServerIsCleaningException = Saklient.Cloud.Errors.ServerIsCleaningException;
using ServerOperationFailureException = Saklient.Cloud.Errors.ServerOperationFailureException;
using ServerPowerMustBeDownException = Saklient.Cloud.Errors.ServerPowerMustBeDownException;
using ServerPowerMustBeUpException = Saklient.Cloud.Errors.ServerPowerMustBeUpException;
using ServiceTemporarilyUnavailableException = Saklient.Cloud.Errors.ServiceTemporarilyUnavailableException;
using SizeMismatchException = Saklient.Cloud.Errors.SizeMismatchException;
using SnapshotInMigrationException = Saklient.Cloud.Errors.SnapshotInMigrationException;
using StillCreatingException = Saklient.Cloud.Errors.StillCreatingException;
using StorageAbnormalException = Saklient.Cloud.Errors.StorageAbnormalException;
using StorageOperationFailureException = Saklient.Cloud.Errors.StorageOperationFailureException;
using SwitchHybridConnectedException = Saklient.Cloud.Errors.SwitchHybridConnectedException;
using TemplateFtpIsOpenException = Saklient.Cloud.Errors.TemplateFtpIsOpenException;
using TemplateIsIncompleteException = Saklient.Cloud.Errors.TemplateIsIncompleteException;
using TooManyRequestException = Saklient.Cloud.Errors.TooManyRequestException;
using UnknownException = Saklient.Cloud.Errors.UnknownException;
using UnknownOsTypeException = Saklient.Cloud.Errors.UnknownOsTypeException;
using UnsupportedResClassException = Saklient.Cloud.Errors.UnsupportedResClassException;
using UserNotSpecifiedException = Saklient.Cloud.Errors.UserNotSpecifiedException;
using VncProxyRequestFailureException = Saklient.Cloud.Errors.VncProxyRequestFailureException;

namespace Saklient.Errors
{

	/**
	 * @module saklient.errors.ExceptionFactory
	 * @class ExceptionFactory
	 * @constructor
	 */
	public class ExceptionFactory
	{
		
		/**
		 * @method Create
		 * @static
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 * @return {HttpException}
		 */
		public static HttpException Create(long status, string code=null, string message="")
		{
			switch (code) {
				case "access_apikey_disabled": {
					return new AccessApiKeyDisabledException(status, code, message);
				}
				case "access_sakura": {
					return new AccessSakuraException(status, code, message);
				}
				case "access_staff": {
					return new AccessStaffException(status, code, message);
				}
				case "access_token": {
					return new AccessTokenException(status, code, message);
				}
				case "access_xhr_or_apikey": {
					return new AccessXhrOrApiKeyException(status, code, message);
				}
				case "account_not_found": {
					return new AccountNotFoundException(status, code, message);
				}
				case "account_not_specified": {
					return new AccountNotSpecifiedException(status, code, message);
				}
				case "ambiguous_identifier": {
					return new AmbiguousIdentifierException(status, code, message);
				}
				case "ambiguous_zone": {
					return new AmbiguousZoneException(status, code, message);
				}
				case "apiproxy_timeout": {
					return new ApiProxyTimeoutException(status, code, message);
				}
				case "apiproxy_timeout_non_get": {
					return new ApiProxyTimeoutNonGetException(status, code, message);
				}
				case "archive_is_incomplete": {
					return new ArchiveIsIncompleteException(status, code, message);
				}
				case "bad_gateway": {
					return new HttpBadGatewayException(status, code, message);
				}
				case "bad_request": {
					return new HttpBadRequestException(status, code, message);
				}
				case "boot_failure_by_lock": {
					return new BootFailureByLockException(status, code, message);
				}
				case "boot_failure_in_group": {
					return new BootFailureInGroupException(status, code, message);
				}
				case "busy": {
					return new BusyException(status, code, message);
				}
				case "cant_resize_smaller": {
					return new CantResizeSmallerException(status, code, message);
				}
				case "cdrom_device_locked": {
					return new CdromDeviceLockedException(status, code, message);
				}
				case "cdrom_disabled": {
					return new CdromDisabledException(status, code, message);
				}
				case "cdrom_in_use": {
					return new CdromInUseException(status, code, message);
				}
				case "cdrom_is_incomplete": {
					return new CdromIsIncompleteException(status, code, message);
				}
				case "conflict": {
					return new HttpConflictException(status, code, message);
				}
				case "connect_to_same_switch": {
					return new ConnectToSameSwitchException(status, code, message);
				}
				case "contract_creation": {
					return new ContractCreationException(status, code, message);
				}
				case "copy_to_itself": {
					return new CopyToItselfException(status, code, message);
				}
				case "delete_disk_b4_template": {
					return new DeleteDiskB4TemplateException(status, code, message);
				}
				case "delete_ipv6nets_first": {
					return new DeleteIpV6NetsFirstException(status, code, message);
				}
				case "delete_res_b4_account": {
					return new DeleteResB4AccountException(status, code, message);
				}
				case "delete_router_b4_switch": {
					return new DeleteRouterB4SwitchException(status, code, message);
				}
				case "delete_static_route_first": {
					return new DeleteStaticRouteFirstException(status, code, message);
				}
				case "disabled_in_sandbox": {
					return new DisabledInSandboxException(status, code, message);
				}
				case "disconnect_b4_delete": {
					return new DisconnectB4DeleteException(status, code, message);
				}
				case "disconnect_b4_update": {
					return new DisconnectB4UpdateException(status, code, message);
				}
				case "disk_connection_limit": {
					return new DiskConnectionLimitException(status, code, message);
				}
				case "disk_is_copying": {
					return new DiskIsCopyingException(status, code, message);
				}
				case "disk_is_not_available": {
					return new DiskIsNotAvailableException(status, code, message);
				}
				case "disk_license_mismatch": {
					return new DiskLicenseMismatchException(status, code, message);
				}
				case "disk_stock_run_out": {
					return new DiskStockRunOutException(status, code, message);
				}
				case "diskorss_in_migration": {
					return new DiskOrSsInMigrationException(status, code, message);
				}
				case "dns_a_record_not_found": {
					return new DnsARecordNotFoundException(status, code, message);
				}
				case "dns_aaaa_record_not_found": {
					return new DnsAaaaRecordNotFoundException(status, code, message);
				}
				case "dns_ptr_update_failure": {
					return new DnsPtrUpdateFailureException(status, code, message);
				}
				case "dont_create_in_sandbox": {
					return new DontCreateInSandboxException(status, code, message);
				}
				case "duplicate_account_code": {
					return new DuplicateAccountCodeException(status, code, message);
				}
				case "duplicate_entry": {
					return new DuplicateEntryException(status, code, message);
				}
				case "duplicate_user_code": {
					return new DuplicateUserCodeException(status, code, message);
				}
				case "expectation_failed": {
					return new HttpExpectationFailedException(status, code, message);
				}
				case "failed_dependency": {
					return new HttpFailedDependencyException(status, code, message);
				}
				case "file_not_uploaded": {
					return new FileNotUploadedException(status, code, message);
				}
				case "filter_array_comparison": {
					return new FilterArrayComparisonException(status, code, message);
				}
				case "filter_bad_operator": {
					return new FilterBadOperatorException(status, code, message);
				}
				case "filter_null_comparison": {
					return new FilterNullComparisonException(status, code, message);
				}
				case "filter_unknown_operator": {
					return new FilterUnknownOperatorException(status, code, message);
				}
				case "forbidden": {
					return new HttpForbiddenException(status, code, message);
				}
				case "ftp_cannot_close": {
					return new FtpCannotCloseException(status, code, message);
				}
				case "ftp_is_already_close": {
					return new FtpIsAlreadyCloseException(status, code, message);
				}
				case "ftp_is_already_open": {
					return new FtpIsAlreadyOpenException(status, code, message);
				}
				case "ftp_must_be_closed": {
					return new FtpMustBeClosedException(status, code, message);
				}
				case "gateway_timeout": {
					return new HttpGatewayTimeoutException(status, code, message);
				}
				case "gone": {
					return new HttpGoneException(status, code, message);
				}
				case "host_operation_failure": {
					return new HostOperationFailureException(status, code, message);
				}
				case "http_version_not_supported": {
					return new HttpHttpVersionNotSupportedException(status, code, message);
				}
				case "illegal_das_usage": {
					return new IllegalDasUsageException(status, code, message);
				}
				case "in_migration": {
					return new InMigrationException(status, code, message);
				}
				case "insufficient_storage": {
					return new HttpInsufficientStorageException(status, code, message);
				}
				case "internal_server_error": {
					return new HttpInternalServerErrorException(status, code, message);
				}
				case "invalid_format": {
					return new InvalidFormatException(status, code, message);
				}
				case "invalid_param_comb": {
					return new InvalidParamCombException(status, code, message);
				}
				case "invalid_range": {
					return new InvalidRangeException(status, code, message);
				}
				case "invalid_uri_argument": {
					return new InvalidUriArgumentException(status, code, message);
				}
				case "ipv6net_already_attached": {
					return new IpV6NetAlreadyAttachedException(status, code, message);
				}
				case "length_required": {
					return new HttpLengthRequiredException(status, code, message);
				}
				case "limit_count_in_account": {
					return new LimitCountInAccountException(status, code, message);
				}
				case "limit_count_in_member": {
					return new LimitCountInMemberException(status, code, message);
				}
				case "limit_count_in_network": {
					return new LimitCountInNetworkException(status, code, message);
				}
				case "limit_count_in_router": {
					return new LimitCountInRouterException(status, code, message);
				}
				case "limit_count_in_zone": {
					return new LimitCountInZoneException(status, code, message);
				}
				case "limit_memory_in_account": {
					return new LimitMemoryInAccountException(status, code, message);
				}
				case "limit_size_in_account": {
					return new LimitSizeInAccountException(status, code, message);
				}
				case "locked": {
					return new HttpLockedException(status, code, message);
				}
				case "method_not_allowed": {
					return new HttpMethodNotAllowedException(status, code, message);
				}
				case "missing_iso_image": {
					return new MissingIsoImageException(status, code, message);
				}
				case "missing_param": {
					return new MissingParamException(status, code, message);
				}
				case "must_be_of_same_zone": {
					return new MustBeOfSameZoneException(status, code, message);
				}
				case "no_display_response": {
					return new NoDisplayResponseException(status, code, message);
				}
				case "not_acceptable": {
					return new HttpNotAcceptableException(status, code, message);
				}
				case "not_extended": {
					return new HttpNotExtendedException(status, code, message);
				}
				case "not_for_router": {
					return new NotForRouterException(status, code, message);
				}
				case "not_found": {
					return new HttpNotFoundException(status, code, message);
				}
				case "not_implemented": {
					return new HttpNotImplementedException(status, code, message);
				}
				case "not_replicating": {
					return new NotReplicatingException(status, code, message);
				}
				case "not_with_hybridconn": {
					return new NotWithHybridconnException(status, code, message);
				}
				case "old_storage_plan": {
					return new OldStoragePlanException(status, code, message);
				}
				case "operation_failure": {
					return new OperationFailureException(status, code, message);
				}
				case "operation_timeout": {
					return new OperationTimeoutException(status, code, message);
				}
				case "original_hash_mismatch": {
					return new OriginalHashMismatchException(status, code, message);
				}
				case "packetfilter_applying": {
					return new PacketFilterApplyingException(status, code, message);
				}
				case "packetfilter_version_mismatch": {
					return new PacketFilterVersionMismatchException(status, code, message);
				}
				case "param_ip_not_found": {
					return new ParamIpNotFoundException(status, code, message);
				}
				case "param_res_not_found": {
					return new ParamResNotFoundException(status, code, message);
				}
				case "payment_creditcard": {
					return new PaymentCreditCardException(status, code, message);
				}
				case "payment_payment": {
					return new PaymentPaymentException(status, code, message);
				}
				case "payment_registration": {
					return new PaymentRegistrationException(status, code, message);
				}
				case "payment_required": {
					return new HttpPaymentRequiredException(status, code, message);
				}
				case "payment_telcertification": {
					return new PaymentTelCertificationException(status, code, message);
				}
				case "payment_unpayable": {
					return new PaymentUnpayableException(status, code, message);
				}
				case "penalty_operation": {
					return new PenaltyOperationException(status, code, message);
				}
				case "precondition_failed": {
					return new HttpPreconditionFailedException(status, code, message);
				}
				case "proxy_authentication_required": {
					return new HttpProxyAuthenticationRequiredException(status, code, message);
				}
				case "replica_already_exists": {
					return new ReplicaAlreadyExistsException(status, code, message);
				}
				case "replica_not_found": {
					return new ReplicaNotFoundException(status, code, message);
				}
				case "request_entity_too_large": {
					return new HttpRequestEntityTooLargeException(status, code, message);
				}
				case "request_timeout": {
					return new HttpRequestTimeoutException(status, code, message);
				}
				case "request_uri_too_long": {
					return new HttpRequestUriTooLongException(status, code, message);
				}
				case "requested_range_not_satisfiable": {
					return new HttpRequestedRangeNotSatisfiableException(status, code, message);
				}
				case "res_already_connected": {
					return new ResAlreadyConnectedException(status, code, message);
				}
				case "res_already_disconnected": {
					return new ResAlreadyDisconnectedException(status, code, message);
				}
				case "res_already_exists": {
					return new ResAlreadyExistsException(status, code, message);
				}
				case "res_used_in_zone": {
					return new ResUsedInZoneException(status, code, message);
				}
				case "resource_path_not_found": {
					return new ResourcePathNotFoundException(status, code, message);
				}
				case "run_out_of_ipaddress": {
					return new RunOutOfIpAddressException(status, code, message);
				}
				case "same_license_required": {
					return new SameLicenseRequiredException(status, code, message);
				}
				case "server_could_not_stop": {
					return new ServerCouldNotStopException(status, code, message);
				}
				case "server_is_cleaning": {
					return new ServerIsCleaningException(status, code, message);
				}
				case "server_operation_failure": {
					return new ServerOperationFailureException(status, code, message);
				}
				case "server_power_must_be_down": {
					return new ServerPowerMustBeDownException(status, code, message);
				}
				case "server_power_must_be_up": {
					return new ServerPowerMustBeUpException(status, code, message);
				}
				case "service_temporarily_unavailable": {
					return new ServiceTemporarilyUnavailableException(status, code, message);
				}
				case "service_unavailable": {
					return new HttpServiceUnavailableException(status, code, message);
				}
				case "size_mismatch": {
					return new SizeMismatchException(status, code, message);
				}
				case "snapshot_in_migration": {
					return new SnapshotInMigrationException(status, code, message);
				}
				case "still_creating": {
					return new StillCreatingException(status, code, message);
				}
				case "storage_abnormal": {
					return new StorageAbnormalException(status, code, message);
				}
				case "storage_operation_failure": {
					return new StorageOperationFailureException(status, code, message);
				}
				case "switch_hybrid_connected": {
					return new SwitchHybridConnectedException(status, code, message);
				}
				case "template_ftp_is_open": {
					return new TemplateFtpIsOpenException(status, code, message);
				}
				case "template_is_incomplete": {
					return new TemplateIsIncompleteException(status, code, message);
				}
				case "too_many_request": {
					return new TooManyRequestException(status, code, message);
				}
				case "unauthorized": {
					return new HttpUnauthorizedException(status, code, message);
				}
				case "unknown": {
					return new UnknownException(status, code, message);
				}
				case "unknown_os_type": {
					return new UnknownOsTypeException(status, code, message);
				}
				case "unprocessable_entity": {
					return new HttpUnprocessableEntityException(status, code, message);
				}
				case "unsupported_media_type": {
					return new HttpUnsupportedMediaTypeException(status, code, message);
				}
				case "unsupported_res_class": {
					return new UnsupportedResClassException(status, code, message);
				}
				case "upgrade_required": {
					return new HttpUpgradeRequiredException(status, code, message);
				}
				case "user_not_specified": {
					return new UserNotSpecifiedException(status, code, message);
				}
				case "variant_also_negotiates": {
					return new HttpVariantAlsoNegotiatesException(status, code, message);
				}
				case "vnc_proxy_request_failure": {
					return new VncProxyRequestFailureException(status, code, message);
				}
			}
			;
			switch (status) {
				case 400: {
					return new HttpBadRequestException(status, code, message);
				}
				case 401: {
					return new HttpUnauthorizedException(status, code, message);
				}
				case 402: {
					return new HttpPaymentRequiredException(status, code, message);
				}
				case 403: {
					return new HttpForbiddenException(status, code, message);
				}
				case 404: {
					return new HttpNotFoundException(status, code, message);
				}
				case 405: {
					return new HttpMethodNotAllowedException(status, code, message);
				}
				case 406: {
					return new HttpNotAcceptableException(status, code, message);
				}
				case 407: {
					return new HttpProxyAuthenticationRequiredException(status, code, message);
				}
				case 408: {
					return new HttpRequestTimeoutException(status, code, message);
				}
				case 409: {
					return new HttpConflictException(status, code, message);
				}
				case 410: {
					return new HttpGoneException(status, code, message);
				}
				case 411: {
					return new HttpLengthRequiredException(status, code, message);
				}
				case 412: {
					return new HttpPreconditionFailedException(status, code, message);
				}
				case 413: {
					return new HttpRequestEntityTooLargeException(status, code, message);
				}
				case 415: {
					return new HttpUnsupportedMediaTypeException(status, code, message);
				}
				case 416: {
					return new HttpRequestedRangeNotSatisfiableException(status, code, message);
				}
				case 417: {
					return new HttpExpectationFailedException(status, code, message);
				}
				case 422: {
					return new HttpUnprocessableEntityException(status, code, message);
				}
				case 423: {
					return new HttpLockedException(status, code, message);
				}
				case 424: {
					return new HttpFailedDependencyException(status, code, message);
				}
				case 426: {
					return new HttpUpgradeRequiredException(status, code, message);
				}
				case 500: {
					return new HttpRequestUriTooLongException(status, code, message);
				}
				case 501: {
					return new HttpNotImplementedException(status, code, message);
				}
				case 502: {
					return new HttpBadGatewayException(status, code, message);
				}
				case 503: {
					return new HttpServiceUnavailableException(status, code, message);
				}
				case 504: {
					return new HttpGatewayTimeoutException(status, code, message);
				}
				case 505: {
					return new HttpHttpVersionNotSupportedException(status, code, message);
				}
				case 506: {
					return new HttpVariantAlsoNegotiatesException(status, code, message);
				}
				case 507: {
					return new HttpInsufficientStorageException(status, code, message);
				}
				case 510: {
					return new HttpNotExtendedException(status, code, message);
				}
			}
			;
			return new HttpException(status, code, message);
		}
		
	}
	
}
