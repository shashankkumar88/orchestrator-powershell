// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores the result of the BulkAddQueueItems operation.
    /// </summary>
    public partial class FailedQueueItemDto
    {
        /// <summary>
        /// Initializes a new instance of the FailedQueueItemDto class.
        /// </summary>
        public FailedQueueItemDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailedQueueItemDto class.
        /// </summary>
        /// <param name="ordinal">Ordinal of the item that failed.
        /// A value of null means that offending item is unknown.</param>
        /// <param name="errorCode">Error code. Possible values include:
        /// 'Unknown', 'MultipleErrors', 'InvalidRequest', 'NameAlreadyUsed',
        /// 'ItemNotFound', 'StringProtectFailed', 'ItemAlreadyExists',
        /// 'ErrorDeleting', 'ErrorInserting', 'ErrorUpdating',
        /// 'ErrorSendingEmail', 'InvalidArgument', 'SqlAcquireLockFailure',
        /// 'LibrariesFeedInUse', 'HasDependentItems', 'ItemIsInUse',
        /// 'ParameterMissing', 'ParameterInvalid', 'DuplicateReference',
        /// 'ForbiddenOperation', 'InvalidUser', 'FeatureDisabled',
        /// 'OptimisticConcurrency', 'EncryptionException',
        /// 'CannotCreateOrMigrateTenantDb', 'TenantIsRequired',
        /// 'FieldNotEditable', 'ServiceUnavailable',
        /// 'SharedAccessSignatureFailure', 'ProviderNotSupported',
        /// 'InvalidAuditRelationship', 'InvalidOrganizationUnit',
        /// 'RequiredOrganizationUnit', 'OrganizationUnitNotEditable',
        /// 'MachineAlreadyPairedWithDifferentLicenseKey',
        /// 'NoAvailableLicenses', 'HasAttachedRobots', 'InvalidMachineKey',
        /// 'MachineNameRequired', 'UserNameRequired', 'CannotDeleteBusyRobot',
        /// 'MachineNameCannotChange', 'MachineLicenseCannotChange',
        /// 'CannotUpdateBusyRobot', 'MachineTypeCannotChange',
        /// 'UserNameInvalid', 'SessionAlreadyActive',
        /// 'CannotAssignMachineToFloatingRobot',
        /// 'CannotUpdateRobotHostingType',
        /// 'CannotAssignMachineTemplateToStandardRobot',
        /// 'CannotUpdateActiveSession', 'MachineTemplateUniqueLicenseKey',
        /// 'InvalidMachineId', 'InvalidNonProductionMachineSlots',
        /// 'InvalidUnattendedMachineSlots', 'DisconnectedRobot',
        /// 'UnresponsiveRobot', 'UnsupportedFloatingSessionRobotType',
        /// 'UnsupportedStandardSessionRobotType',
        /// 'EnvironmentDeploymentConflict', 'ServerConflict',
        /// 'ActionAlreadyPerformed', 'UnavailableResources', 'UserIsDeleted',
        /// 'UserIsLockedOut', 'ChangePassword', 'PasswordExpired',
        /// 'InvalidPassword', 'CannotDeleteStaticRole', 'UserNotEditable',
        /// 'DomainUnreachable', 'PasswordResetFailed', 'ConfirmEmailFailed',
        /// 'CannotUsePreviousPassword', 'RoleIsNotEditable',
        /// 'UserNotFoundInDomain', 'CannotUpdateUsername',
        /// 'InvalidLoginMethod', 'InvalidUsernameOrPassword',
        /// 'MultipleMatchingUsers', 'CannotCallFromHost', 'CreateNotAllowed',
        /// 'ProvisionError', 'EmptyDomainOrUsername',
        /// 'NotDirectoryUserOrGroup',
        /// 'CredentialAssetEmptyPasswordForNewUser',
        /// 'CredentialAssetEmptyForNewRobot', 'AssetTypeNonUpdatable',
        /// 'AssetNotAvailableForRobot', 'InvalidCron', 'ScheduleWillNeverRun',
        /// 'ScheduleMisfired', 'ScheduleInvalidTimeZone',
        /// 'InvalidScheduleKey', 'ScheduleIsNotEnabled',
        /// 'ScheduleNotAssociatedWithAQueue',
        /// 'ScheduleCannotBeAssociatedWithAQueue', 'UserIsAssignedToTriggers',
        /// 'DownloadUnavailable', 'CannotConnectToPackagesRepository',
        /// 'NotSupportedByExternalFeeds', 'ErrorDownloading',
        /// 'InvalidPackageDetails', 'TenantFeedInUse', 'InvalidProcessKey',
        /// 'JobTypeCannotBeStopped', 'JobCannotBeCancelled',
        /// 'JobCannotBeTerminated', 'VersionNotFound', 'ProcessNotFound',
        /// 'HasAttachedProcesses', 'InvalidExtension', 'InvalidPackageCount',
        /// 'PreviousVersionNotFound', 'HasRunningJobs', 'TenantNotFound',
        /// 'PendingJobsAlreadyExist', 'InvalidStartJobRobotIds',
        /// 'UnregisteredCannotStartJobs', 'LicenseExpiredCannotStartJobs',
        /// 'InvalidReleaseKey', 'InvalidPackageVersion', 'TenantIsDisabled',
        /// 'PackageNotFound', 'NoRobotsAvailable', 'PathTooLong',
        /// 'JobExecutionFaulted', 'InvalidJobIdOrRobotKey',
        /// 'InvalidJobStateForSuspend', 'JobNotFoundByPersistenceId',
        /// 'ErrorPackagePublish', 'ErrorSavingPackageDefinition',
        /// 'MaxNumberJobsAlreadyExist', 'HasSlaEnabedQueuesAssociated',
        /// 'VersionsManagedAutomatically', 'InaccessibleFeed',
        /// 'MultipleEntryPointsJobExecutionNotSupported',
        /// 'CyberArkEditPasswordNotAllowed', 'LogMessageNotFound',
        /// 'LogRobotNameNotFound', 'EncryptionKeyNotFound',
        /// 'EncryptionKeyIncorrectFormat', 'AzureKeyVaultRetrieveIssue',
        /// 'AzureKeyVaultStoreIssue', 'TransactionReferenceRequired',
        /// 'InvalidTransactionProgressStatus', 'TransactionNotStarted',
        /// 'ReviewerNotAvailable', 'QueueDefinitionParametersCannotChange',
        /// 'QueueProcessingApplicationException',
        /// 'QueueItemSchemaViolationException',
        /// 'InvalidQueueSchemaDefinition',
        /// 'InvalidQueueSchemaDefinitionChange', 'InvalidQueueSchemaType',
        /// 'QueueSchemaDefinitionNotFound', 'SlaEnableQueueDefinitionFailure',
        /// 'QueueSlaAtPredictedRisk', 'QueueSlaPredictedBreach',
        /// 'QueueItemContentSizeExceeded', 'LicenseNotFound',
        /// 'LicenseExpired', 'LicenseAlreadyInUse', 'InvalidLicenseFormat',
        /// 'LicenseLimitExceeded', 'UnattendedLicenseLimitExceeded',
        /// 'NonProductionLicenseLimitExceeded',
        /// 'AttendedLicenseLimitExceeded', 'DevelopmentLicenseLimitExceeded',
        /// 'RobotFailedToAcquireLicense', 'NonProductionSlotsLimitExceeded',
        /// 'UnattendedSlotsLimitExceeded', 'LicenseUnregistered',
        /// 'LicenseNotAvailable', 'NotEnoughAvailableSlots',
        /// 'NotEnoughRuntimeLicenses', 'SlotsExceedLicenseLimit',
        /// 'NotEnoughAvailableLicenses', 'HostLicenseLimitExceeded',
        /// 'NoHostLicense', 'LicenseNewInvalidArguments',
        /// 'LicenseMachineDisabled', 'CannotDisableBusyMachine',
        /// 'HeadlessSlotsLimitExceeded', 'HeadlessLicenseLimitExceeded',
        /// 'TestAutomationSlotsLimitExceeded',
        /// 'TestAutomationLicenseLimitExceeded', 'ArgumentMetadataExtract',
        /// 'ArgumentMetadataValidation', 'ArgumentDefinitionExtract',
        /// 'ArgumentValueExtract', 'ArgumentValidation',
        /// 'PackageMetadataExtract', 'PackageMetadataValidation',
        /// 'UnknownWebhookEventType', 'WebhookQuotaReached',
        /// 'ExecutionMediaStorageUnavailable',
        /// 'ExecutionMediaNotAvailableForJob',
        /// 'ExecutionMediaContentNotAvailable',
        /// 'CannotDeleteDefaultCredentialStore', 'CredentialStoreNotFound',
        /// 'UnknownCredentialStoreType',
        /// 'InvalidCredentialStoreConfiguration',
        /// 'FailedToReadFromCredentialStore',
        /// 'FailedToWriteToCredentialStore',
        /// 'CannotDeleteNonEmptyCredentialStore', 'ContentLengthTooLarge',
        /// 'TaskAssignmentError', 'TaskCompletionError',
        /// 'TaskAssigneeMismatchError', 'TaskFormInvalidFormLayout',
        /// 'TaskFormInvalidFormPayload', 'TaskFormMultipleActions',
        /// 'TaskFormNoAction', 'TaskFormInvalidAction',
        /// 'TasksNotAllowedInModernFolder', 'InvalidSecureStoreContext',
        /// 'MailSmtpSettingsError', 'CannotDeleteCalendarWhenUsedBySchedule',
        /// 'MandatoryPropertiesForRootFolderNotSpecified',
        /// 'IncompatibleFolderProperties',
        /// 'NoHierarchyAllowedForClassicFolders',
        /// 'MaximumFolderHierarchyDepthReached',
        /// 'CannotChangeRobotProvisionType',
        /// 'CannotChangeFolderPermissionModel', 'CannotEditFolderParent',
        /// 'EntitiesRequiredForAssignmentNotFound',
        /// 'CannotAssignRolesToNonFineGrainedFolders',
        /// 'InvalidFolderDisplayName', 'AssociationAlreadyExists',
        /// 'UserDoesNotHaveAccessToFolder',
        /// 'CannotChangeRobotUserFolderAssignments',
        /// 'CannotAssignMachineToClassicFolder',
        /// 'StrategyNotAvailableInModernFolder',
        /// 'StrategyNotAvailableInClassicFolder',
        /// 'ValidModernFolderIdRequired', 'NoMachineAssociatedWithFolder',
        /// 'MaintenanceActive', 'TenantMaintenanceActive',
        /// 'TenantMaintenanceNotActive', 'AnalyticsNotAuthorized',
        /// 'AnalyticsTenantNotProvisioned', 'AnalyticsUserIsHostUser',
        /// 'AnalyticsUserHasNoEmail', 'AnalyticsUserNotFound',
        /// 'AnalyticsAdminEmailProhibited', 'InvalidStorageProvider',
        /// 'BucketIsReadOnly', 'InvalidBlobFilePath',
        /// 'UnavailableStorageProvider', 'TestSetNotNewOnCreate',
        /// 'TestAutomationKeyMismatch', 'TestSetNewOnUpdate', 'TestSetEmpty',
        /// 'TestSetDuplicatePackages', 'TestSetVersionMaskInvalid',
        /// 'TestSetDefinitionNotFound', 'TestSetTestCaseInvalid',
        /// 'TestSetTestCaseVersionInvalid', 'TestAutomationVersionInvalid',
        /// 'TestSetExecutionEmptyTestSet', 'TestSetExecutionCreateFailed',
        /// 'TestSetExecutionDuplicateUniqueIds',
        /// 'TestCaseAssertionScreenshotMimeTypeMissing',
        /// 'TestCaseAssertionScreenshotMissing', 'InvalidTenantMoveStatus',
        /// 'TenantMoveIdConflict', 'TenantMoveMigrationConflict',
        /// 'MediaFileNotFound', 'MediaFileNotFoundForKey',
        /// 'InvalidMediaFilesUpload', 'MediaFileTypeNotSupported'</param>
        /// <param name="errorMessage">Error message.</param>
        public FailedQueueItemDto(int? ordinal = default(int?), FailedQueueItemDtoErrorCode? errorCode = default(FailedQueueItemDtoErrorCode?), string errorMessage = default(string))
        {
            Ordinal = ordinal;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ordinal of the item that failed.
        /// A value of null means that offending item is unknown.
        /// </summary>
        [JsonProperty(PropertyName = "Ordinal")]
        public int? Ordinal { get; set; }

        /// <summary>
        /// Gets or sets error code. Possible values include: 'Unknown',
        /// 'MultipleErrors', 'InvalidRequest', 'NameAlreadyUsed',
        /// 'ItemNotFound', 'StringProtectFailed', 'ItemAlreadyExists',
        /// 'ErrorDeleting', 'ErrorInserting', 'ErrorUpdating',
        /// 'ErrorSendingEmail', 'InvalidArgument', 'SqlAcquireLockFailure',
        /// 'LibrariesFeedInUse', 'HasDependentItems', 'ItemIsInUse',
        /// 'ParameterMissing', 'ParameterInvalid', 'DuplicateReference',
        /// 'ForbiddenOperation', 'InvalidUser', 'FeatureDisabled',
        /// 'OptimisticConcurrency', 'EncryptionException',
        /// 'CannotCreateOrMigrateTenantDb', 'TenantIsRequired',
        /// 'FieldNotEditable', 'ServiceUnavailable',
        /// 'SharedAccessSignatureFailure', 'ProviderNotSupported',
        /// 'InvalidAuditRelationship', 'InvalidOrganizationUnit',
        /// 'RequiredOrganizationUnit', 'OrganizationUnitNotEditable',
        /// 'MachineAlreadyPairedWithDifferentLicenseKey',
        /// 'NoAvailableLicenses', 'HasAttachedRobots', 'InvalidMachineKey',
        /// 'MachineNameRequired', 'UserNameRequired', 'CannotDeleteBusyRobot',
        /// 'MachineNameCannotChange', 'MachineLicenseCannotChange',
        /// 'CannotUpdateBusyRobot', 'MachineTypeCannotChange',
        /// 'UserNameInvalid', 'SessionAlreadyActive',
        /// 'CannotAssignMachineToFloatingRobot',
        /// 'CannotUpdateRobotHostingType',
        /// 'CannotAssignMachineTemplateToStandardRobot',
        /// 'CannotUpdateActiveSession', 'MachineTemplateUniqueLicenseKey',
        /// 'InvalidMachineId', 'InvalidNonProductionMachineSlots',
        /// 'InvalidUnattendedMachineSlots', 'DisconnectedRobot',
        /// 'UnresponsiveRobot', 'UnsupportedFloatingSessionRobotType',
        /// 'UnsupportedStandardSessionRobotType',
        /// 'EnvironmentDeploymentConflict', 'ServerConflict',
        /// 'ActionAlreadyPerformed', 'UnavailableResources', 'UserIsDeleted',
        /// 'UserIsLockedOut', 'ChangePassword', 'PasswordExpired',
        /// 'InvalidPassword', 'CannotDeleteStaticRole', 'UserNotEditable',
        /// 'DomainUnreachable', 'PasswordResetFailed', 'ConfirmEmailFailed',
        /// 'CannotUsePreviousPassword', 'RoleIsNotEditable',
        /// 'UserNotFoundInDomain', 'CannotUpdateUsername',
        /// 'InvalidLoginMethod', 'InvalidUsernameOrPassword',
        /// 'MultipleMatchingUsers', 'CannotCallFromHost', 'CreateNotAllowed',
        /// 'ProvisionError', 'EmptyDomainOrUsername',
        /// 'NotDirectoryUserOrGroup',
        /// 'CredentialAssetEmptyPasswordForNewUser',
        /// 'CredentialAssetEmptyForNewRobot', 'AssetTypeNonUpdatable',
        /// 'AssetNotAvailableForRobot', 'InvalidCron', 'ScheduleWillNeverRun',
        /// 'ScheduleMisfired', 'ScheduleInvalidTimeZone',
        /// 'InvalidScheduleKey', 'ScheduleIsNotEnabled',
        /// 'ScheduleNotAssociatedWithAQueue',
        /// 'ScheduleCannotBeAssociatedWithAQueue', 'UserIsAssignedToTriggers',
        /// 'DownloadUnavailable', 'CannotConnectToPackagesRepository',
        /// 'NotSupportedByExternalFeeds', 'ErrorDownloading',
        /// 'InvalidPackageDetails', 'TenantFeedInUse', 'InvalidProcessKey',
        /// 'JobTypeCannotBeStopped', 'JobCannotBeCancelled',
        /// 'JobCannotBeTerminated', 'VersionNotFound', 'ProcessNotFound',
        /// 'HasAttachedProcesses', 'InvalidExtension', 'InvalidPackageCount',
        /// 'PreviousVersionNotFound', 'HasRunningJobs', 'TenantNotFound',
        /// 'PendingJobsAlreadyExist', 'InvalidStartJobRobotIds',
        /// 'UnregisteredCannotStartJobs', 'LicenseExpiredCannotStartJobs',
        /// 'InvalidReleaseKey', 'InvalidPackageVersion', 'TenantIsDisabled',
        /// 'PackageNotFound', 'NoRobotsAvailable', 'PathTooLong',
        /// 'JobExecutionFaulted', 'InvalidJobIdOrRobotKey',
        /// 'InvalidJobStateForSuspend', 'JobNotFoundByPersistenceId',
        /// 'ErrorPackagePublish', 'ErrorSavingPackageDefinition',
        /// 'MaxNumberJobsAlreadyExist', 'HasSlaEnabedQueuesAssociated',
        /// 'VersionsManagedAutomatically', 'InaccessibleFeed',
        /// 'MultipleEntryPointsJobExecutionNotSupported',
        /// 'CyberArkEditPasswordNotAllowed', 'LogMessageNotFound',
        /// 'LogRobotNameNotFound', 'EncryptionKeyNotFound',
        /// 'EncryptionKeyIncorrectFormat', 'AzureKeyVaultRetrieveIssue',
        /// 'AzureKeyVaultStoreIssue', 'TransactionReferenceRequired',
        /// 'InvalidTransactionProgressStatus', 'TransactionNotStarted',
        /// 'ReviewerNotAvailable', 'QueueDefinitionParametersCannotChange',
        /// 'QueueProcessingApplicationException',
        /// 'QueueItemSchemaViolationException',
        /// 'InvalidQueueSchemaDefinition',
        /// 'InvalidQueueSchemaDefinitionChange', 'InvalidQueueSchemaType',
        /// 'QueueSchemaDefinitionNotFound', 'SlaEnableQueueDefinitionFailure',
        /// 'QueueSlaAtPredictedRisk', 'QueueSlaPredictedBreach',
        /// 'QueueItemContentSizeExceeded', 'LicenseNotFound',
        /// 'LicenseExpired', 'LicenseAlreadyInUse', 'InvalidLicenseFormat',
        /// 'LicenseLimitExceeded', 'UnattendedLicenseLimitExceeded',
        /// 'NonProductionLicenseLimitExceeded',
        /// 'AttendedLicenseLimitExceeded', 'DevelopmentLicenseLimitExceeded',
        /// 'RobotFailedToAcquireLicense', 'NonProductionSlotsLimitExceeded',
        /// 'UnattendedSlotsLimitExceeded', 'LicenseUnregistered',
        /// 'LicenseNotAvailable', 'NotEnoughAvailableSlots',
        /// 'NotEnoughRuntimeLicenses', 'SlotsExceedLicenseLimit',
        /// 'NotEnoughAvailableLicenses', 'HostLicenseLimitExceeded',
        /// 'NoHostLicense', 'LicenseNewInvalidArguments',
        /// 'LicenseMachineDisabled', 'CannotDisableBusyMachine',
        /// 'HeadlessSlotsLimitExceeded', 'HeadlessLicenseLimitExceeded',
        /// 'TestAutomationSlotsLimitExceeded',
        /// 'TestAutomationLicenseLimitExceeded', 'ArgumentMetadataExtract',
        /// 'ArgumentMetadataValidation', 'ArgumentDefinitionExtract',
        /// 'ArgumentValueExtract', 'ArgumentValidation',
        /// 'PackageMetadataExtract', 'PackageMetadataValidation',
        /// 'UnknownWebhookEventType', 'WebhookQuotaReached',
        /// 'ExecutionMediaStorageUnavailable',
        /// 'ExecutionMediaNotAvailableForJob',
        /// 'ExecutionMediaContentNotAvailable',
        /// 'CannotDeleteDefaultCredentialStore', 'CredentialStoreNotFound',
        /// 'UnknownCredentialStoreType',
        /// 'InvalidCredentialStoreConfiguration',
        /// 'FailedToReadFromCredentialStore',
        /// 'FailedToWriteToCredentialStore',
        /// 'CannotDeleteNonEmptyCredentialStore', 'ContentLengthTooLarge',
        /// 'TaskAssignmentError', 'TaskCompletionError',
        /// 'TaskAssigneeMismatchError', 'TaskFormInvalidFormLayout',
        /// 'TaskFormInvalidFormPayload', 'TaskFormMultipleActions',
        /// 'TaskFormNoAction', 'TaskFormInvalidAction',
        /// 'TasksNotAllowedInModernFolder', 'InvalidSecureStoreContext',
        /// 'MailSmtpSettingsError', 'CannotDeleteCalendarWhenUsedBySchedule',
        /// 'MandatoryPropertiesForRootFolderNotSpecified',
        /// 'IncompatibleFolderProperties',
        /// 'NoHierarchyAllowedForClassicFolders',
        /// 'MaximumFolderHierarchyDepthReached',
        /// 'CannotChangeRobotProvisionType',
        /// 'CannotChangeFolderPermissionModel', 'CannotEditFolderParent',
        /// 'EntitiesRequiredForAssignmentNotFound',
        /// 'CannotAssignRolesToNonFineGrainedFolders',
        /// 'InvalidFolderDisplayName', 'AssociationAlreadyExists',
        /// 'UserDoesNotHaveAccessToFolder',
        /// 'CannotChangeRobotUserFolderAssignments',
        /// 'CannotAssignMachineToClassicFolder',
        /// 'StrategyNotAvailableInModernFolder',
        /// 'StrategyNotAvailableInClassicFolder',
        /// 'ValidModernFolderIdRequired', 'NoMachineAssociatedWithFolder',
        /// 'MaintenanceActive', 'TenantMaintenanceActive',
        /// 'TenantMaintenanceNotActive', 'AnalyticsNotAuthorized',
        /// 'AnalyticsTenantNotProvisioned', 'AnalyticsUserIsHostUser',
        /// 'AnalyticsUserHasNoEmail', 'AnalyticsUserNotFound',
        /// 'AnalyticsAdminEmailProhibited', 'InvalidStorageProvider',
        /// 'BucketIsReadOnly', 'InvalidBlobFilePath',
        /// 'UnavailableStorageProvider', 'TestSetNotNewOnCreate',
        /// 'TestAutomationKeyMismatch', 'TestSetNewOnUpdate', 'TestSetEmpty',
        /// 'TestSetDuplicatePackages', 'TestSetVersionMaskInvalid',
        /// 'TestSetDefinitionNotFound', 'TestSetTestCaseInvalid',
        /// 'TestSetTestCaseVersionInvalid', 'TestAutomationVersionInvalid',
        /// 'TestSetExecutionEmptyTestSet', 'TestSetExecutionCreateFailed',
        /// 'TestSetExecutionDuplicateUniqueIds',
        /// 'TestCaseAssertionScreenshotMimeTypeMissing',
        /// 'TestCaseAssertionScreenshotMissing', 'InvalidTenantMoveStatus',
        /// 'TenantMoveIdConflict', 'TenantMoveMigrationConflict',
        /// 'MediaFileNotFound', 'MediaFileNotFoundForKey',
        /// 'InvalidMediaFilesUpload', 'MediaFileTypeNotSupported'
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public FailedQueueItemDtoErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

    }
}