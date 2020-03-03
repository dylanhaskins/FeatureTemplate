declare namespace Rest {
  interface SystemUserBase extends RestEntity {
    AccessMode?: SDK.OptionSet<systemuser_accessmode> | null;
    ActiveDirectoryGuid?: string | null;
    Address1_AddressId?: string | null;
    Address1_AddressTypeCode?: SDK.OptionSet<systemuser_address1_addresstypecode> | null;
    Address1_City?: string | null;
    Address1_Composite?: string | null;
    Address1_Country?: string | null;
    Address1_County?: string | null;
    Address1_Fax?: string | null;
    Address1_Latitude?: number | null;
    Address1_Line1?: string | null;
    Address1_Line2?: string | null;
    Address1_Line3?: string | null;
    Address1_Longitude?: number | null;
    Address1_Name?: string | null;
    Address1_PostOfficeBox?: string | null;
    Address1_PostalCode?: string | null;
    Address1_ShippingMethodCode?: SDK.OptionSet<systemuser_address1_shippingmethodcode> | null;
    Address1_StateOrProvince?: string | null;
    Address1_Telephone1?: string | null;
    Address1_Telephone2?: string | null;
    Address1_Telephone3?: string | null;
    Address1_UPSZone?: string | null;
    Address1_UTCOffset?: number | null;
    Address2_AddressId?: string | null;
    Address2_AddressTypeCode?: SDK.OptionSet<systemuser_address2_addresstypecode> | null;
    Address2_City?: string | null;
    Address2_Composite?: string | null;
    Address2_Country?: string | null;
    Address2_County?: string | null;
    Address2_Fax?: string | null;
    Address2_Latitude?: number | null;
    Address2_Line1?: string | null;
    Address2_Line2?: string | null;
    Address2_Line3?: string | null;
    Address2_Longitude?: number | null;
    Address2_Name?: string | null;
    Address2_PostOfficeBox?: string | null;
    Address2_PostalCode?: string | null;
    Address2_ShippingMethodCode?: SDK.OptionSet<systemuser_address2_shippingmethodcode> | null;
    Address2_StateOrProvince?: string | null;
    Address2_Telephone1?: string | null;
    Address2_Telephone2?: string | null;
    Address2_Telephone3?: string | null;
    Address2_UPSZone?: string | null;
    Address2_UTCOffset?: number | null;
    ApplicationId?: string | null;
    ApplicationIdUri?: string | null;
    AzureActiveDirectoryObjectId?: string | null;
    BusinessUnitId?: SDK.EntityReference | null;
    CALType?: SDK.OptionSet<systemuser_caltype> | null;
    CalendarId?: SDK.EntityReference | null;
    CreatedBy?: SDK.EntityReference | null;
    CreatedOn?: Date | null;
    CreatedOnBehalfBy?: SDK.EntityReference | null;
    DefaultFiltersPopulated?: boolean | null;
    DefaultMailbox?: SDK.EntityReference | null;
    DefaultOdbFolderName?: string | null;
    DisabledReason?: string | null;
    DisplayInServiceViews?: boolean | null;
    DomainName?: string | null;
    EmailRouterAccessApproval?: SDK.OptionSet<systemuser_emailrouteraccessapproval> | null;
    EmployeeId?: string | null;
    EntityImageId?: string | null;
    ExchangeRate?: string | null;
    FirstName?: string | null;
    FullName?: string | null;
    GovernmentId?: string | null;
    HomePhone?: string | null;
    IdentityId?: number | null;
    ImportSequenceNumber?: number | null;
    IncomingEmailDeliveryMethod?: SDK.OptionSet<systemuser_incomingemaildeliverymethod> | null;
    InternalEMailAddress?: string | null;
    InviteStatusCode?: SDK.OptionSet<systemuser_invitestatuscode> | null;
    IsActiveDirectoryUser?: boolean | null;
    IsDisabled?: boolean | null;
    IsEmailAddressApprovedByO365Admin?: boolean | null;
    IsIntegrationUser?: boolean | null;
    IsLicensed?: boolean | null;
    IsSyncWithDirectory?: boolean | null;
    JobTitle?: string | null;
    LastName?: string | null;
    LatestUpdateTime?: Date | null;
    MiddleName?: string | null;
    MobileAlertEMail?: string | null;
    MobileOfflineProfileId?: SDK.EntityReference | null;
    MobilePhone?: string | null;
    ModifiedBy?: SDK.EntityReference | null;
    ModifiedOn?: Date | null;
    ModifiedOnBehalfBy?: SDK.EntityReference | null;
    NickName?: string | null;
    OrganizationId?: string | null;
    OutgoingEmailDeliveryMethod?: SDK.OptionSet<systemuser_outgoingemaildeliverymethod> | null;
    OverriddenCreatedOn?: Date | null;
    ParentSystemUserId?: SDK.EntityReference | null;
    PassportHi?: number | null;
    PassportLo?: number | null;
    PersonalEMailAddress?: string | null;
    PhotoUrl?: string | null;
    PositionId?: SDK.EntityReference | null;
    PreferredAddressCode?: SDK.OptionSet<systemuser_preferredaddresscode> | null;
    PreferredEmailCode?: SDK.OptionSet<systemuser_preferredemailcode> | null;
    PreferredPhoneCode?: SDK.OptionSet<systemuser_preferredphonecode> | null;
    ProcessId?: string | null;
    QueueId?: SDK.EntityReference | null;
    Salutation?: string | null;
    SetupUser?: boolean | null;
    SharePointEmailAddress?: string | null;
    Skills?: string | null;
    StageId?: string | null;
    SystemUserId?: string | null;
    TerritoryId?: SDK.EntityReference | null;
    TimeZoneRuleVersionNumber?: number | null;
    Title?: string | null;
    TransactionCurrencyId?: SDK.EntityReference | null;
    TraversedPath?: string | null;
    UTCConversionTimeZoneCode?: number | null;
    UserLicenseType?: number | null;
    UserPuid?: string | null;
    VersionNumber?: number | null;
    WindowsLiveID?: string | null;
    YammerEmailAddress?: string | null;
    YammerUserId?: string | null;
  }
  interface SystemUser extends SystemUserBase {
    Referencedlk_systemuser_createdonbehalfby?: SystemUser[] | null;
    Referencedlk_systemuser_modifiedonbehalfby?: SystemUser[] | null;
    Referencedlk_systemuserbase_createdby?: SystemUser[] | null;
    Referencedlk_systemuserbase_modifiedby?: SystemUser[] | null;
    Referenceduser_parent_user?: SystemUser[] | null;
    Referencinglk_systemuser_createdonbehalfby?: SystemUser | null;
    Referencinglk_systemuser_modifiedonbehalfby?: SystemUser | null;
    Referencinglk_systemuserbase_createdby?: SystemUser | null;
    Referencinglk_systemuserbase_modifiedby?: SystemUser | null;
    Referencinguser_parent_user?: SystemUser | null;
    business_unit_system_users?: BusinessUnit | null;
    createdby_connection?: Connection[] | null;
    lk_businessunit_createdonbehalfby?: BusinessUnit[] | null;
    lk_businessunit_modifiedonbehalfby?: BusinessUnit[] | null;
    lk_businessunitbase_createdby?: BusinessUnit[] | null;
    lk_businessunitbase_modifiedby?: BusinessUnit[] | null;
    lk_connectionbase_createdonbehalfby?: Connection[] | null;
    lk_connectionbase_modifiedonbehalfby?: Connection[] | null;
    lk_team_createdonbehalfby?: Team[] | null;
    lk_team_modifiedonbehalfby?: Team[] | null;
    lk_teambase_administratorid?: Team[] | null;
    lk_teambase_createdby?: Team[] | null;
    lk_teambase_modifiedby?: Team[] | null;
    modifiedby_connection?: Connection[] | null;
    systemuser_connections1?: Connection[] | null;
    systemuser_connections2?: Connection[] | null;
    teammembership_association?: Team[] | null;
  }
  interface SystemUserResult extends SystemUserBase {
    Referencedlk_systemuser_createdonbehalfby?: SDK.Results<SystemUserResult> | null;
    Referencedlk_systemuser_modifiedonbehalfby?: SDK.Results<SystemUserResult> | null;
    Referencedlk_systemuserbase_createdby?: SDK.Results<SystemUserResult> | null;
    Referencedlk_systemuserbase_modifiedby?: SDK.Results<SystemUserResult> | null;
    Referenceduser_parent_user?: SDK.Results<SystemUserResult> | null;
    Referencinglk_systemuser_createdonbehalfby?: SystemUser | null;
    Referencinglk_systemuser_modifiedonbehalfby?: SystemUser | null;
    Referencinglk_systemuserbase_createdby?: SystemUser | null;
    Referencinglk_systemuserbase_modifiedby?: SystemUser | null;
    Referencinguser_parent_user?: SystemUser | null;
    business_unit_system_users?: BusinessUnit | null;
    createdby_connection?: SDK.Results<ConnectionResult> | null;
    lk_businessunit_createdonbehalfby?: SDK.Results<BusinessUnitResult> | null;
    lk_businessunit_modifiedonbehalfby?: SDK.Results<BusinessUnitResult> | null;
    lk_businessunitbase_createdby?: SDK.Results<BusinessUnitResult> | null;
    lk_businessunitbase_modifiedby?: SDK.Results<BusinessUnitResult> | null;
    lk_connectionbase_createdonbehalfby?: SDK.Results<ConnectionResult> | null;
    lk_connectionbase_modifiedonbehalfby?: SDK.Results<ConnectionResult> | null;
    lk_team_createdonbehalfby?: SDK.Results<TeamResult> | null;
    lk_team_modifiedonbehalfby?: SDK.Results<TeamResult> | null;
    lk_teambase_administratorid?: SDK.Results<TeamResult> | null;
    lk_teambase_createdby?: SDK.Results<TeamResult> | null;
    lk_teambase_modifiedby?: SDK.Results<TeamResult> | null;
    modifiedby_connection?: SDK.Results<ConnectionResult> | null;
    systemuser_connections1?: SDK.Results<ConnectionResult> | null;
    systemuser_connections2?: SDK.Results<ConnectionResult> | null;
    teammembership_association?: SDK.Results<TeamResult> | null;
  }
  interface SystemUser_Select extends SystemUser_Expand {
    AccessMode: RestAttribute<SystemUser_Select>;
    ActiveDirectoryGuid: RestAttribute<SystemUser_Select>;
    Address1_AddressId: RestAttribute<SystemUser_Select>;
    Address1_AddressTypeCode: RestAttribute<SystemUser_Select>;
    Address1_City: RestAttribute<SystemUser_Select>;
    Address1_Composite: RestAttribute<SystemUser_Select>;
    Address1_Country: RestAttribute<SystemUser_Select>;
    Address1_County: RestAttribute<SystemUser_Select>;
    Address1_Fax: RestAttribute<SystemUser_Select>;
    Address1_Latitude: RestAttribute<SystemUser_Select>;
    Address1_Line1: RestAttribute<SystemUser_Select>;
    Address1_Line2: RestAttribute<SystemUser_Select>;
    Address1_Line3: RestAttribute<SystemUser_Select>;
    Address1_Longitude: RestAttribute<SystemUser_Select>;
    Address1_Name: RestAttribute<SystemUser_Select>;
    Address1_PostOfficeBox: RestAttribute<SystemUser_Select>;
    Address1_PostalCode: RestAttribute<SystemUser_Select>;
    Address1_ShippingMethodCode: RestAttribute<SystemUser_Select>;
    Address1_StateOrProvince: RestAttribute<SystemUser_Select>;
    Address1_Telephone1: RestAttribute<SystemUser_Select>;
    Address1_Telephone2: RestAttribute<SystemUser_Select>;
    Address1_Telephone3: RestAttribute<SystemUser_Select>;
    Address1_UPSZone: RestAttribute<SystemUser_Select>;
    Address1_UTCOffset: RestAttribute<SystemUser_Select>;
    Address2_AddressId: RestAttribute<SystemUser_Select>;
    Address2_AddressTypeCode: RestAttribute<SystemUser_Select>;
    Address2_City: RestAttribute<SystemUser_Select>;
    Address2_Composite: RestAttribute<SystemUser_Select>;
    Address2_Country: RestAttribute<SystemUser_Select>;
    Address2_County: RestAttribute<SystemUser_Select>;
    Address2_Fax: RestAttribute<SystemUser_Select>;
    Address2_Latitude: RestAttribute<SystemUser_Select>;
    Address2_Line1: RestAttribute<SystemUser_Select>;
    Address2_Line2: RestAttribute<SystemUser_Select>;
    Address2_Line3: RestAttribute<SystemUser_Select>;
    Address2_Longitude: RestAttribute<SystemUser_Select>;
    Address2_Name: RestAttribute<SystemUser_Select>;
    Address2_PostOfficeBox: RestAttribute<SystemUser_Select>;
    Address2_PostalCode: RestAttribute<SystemUser_Select>;
    Address2_ShippingMethodCode: RestAttribute<SystemUser_Select>;
    Address2_StateOrProvince: RestAttribute<SystemUser_Select>;
    Address2_Telephone1: RestAttribute<SystemUser_Select>;
    Address2_Telephone2: RestAttribute<SystemUser_Select>;
    Address2_Telephone3: RestAttribute<SystemUser_Select>;
    Address2_UPSZone: RestAttribute<SystemUser_Select>;
    Address2_UTCOffset: RestAttribute<SystemUser_Select>;
    ApplicationId: RestAttribute<SystemUser_Select>;
    ApplicationIdUri: RestAttribute<SystemUser_Select>;
    AzureActiveDirectoryObjectId: RestAttribute<SystemUser_Select>;
    BusinessUnitId: RestAttribute<SystemUser_Select>;
    CALType: RestAttribute<SystemUser_Select>;
    CalendarId: RestAttribute<SystemUser_Select>;
    CreatedBy: RestAttribute<SystemUser_Select>;
    CreatedOn: RestAttribute<SystemUser_Select>;
    CreatedOnBehalfBy: RestAttribute<SystemUser_Select>;
    DefaultFiltersPopulated: RestAttribute<SystemUser_Select>;
    DefaultMailbox: RestAttribute<SystemUser_Select>;
    DefaultOdbFolderName: RestAttribute<SystemUser_Select>;
    DisabledReason: RestAttribute<SystemUser_Select>;
    DisplayInServiceViews: RestAttribute<SystemUser_Select>;
    DomainName: RestAttribute<SystemUser_Select>;
    EmailRouterAccessApproval: RestAttribute<SystemUser_Select>;
    EmployeeId: RestAttribute<SystemUser_Select>;
    EntityImageId: RestAttribute<SystemUser_Select>;
    ExchangeRate: RestAttribute<SystemUser_Select>;
    FirstName: RestAttribute<SystemUser_Select>;
    FullName: RestAttribute<SystemUser_Select>;
    GovernmentId: RestAttribute<SystemUser_Select>;
    HomePhone: RestAttribute<SystemUser_Select>;
    IdentityId: RestAttribute<SystemUser_Select>;
    ImportSequenceNumber: RestAttribute<SystemUser_Select>;
    IncomingEmailDeliveryMethod: RestAttribute<SystemUser_Select>;
    InternalEMailAddress: RestAttribute<SystemUser_Select>;
    InviteStatusCode: RestAttribute<SystemUser_Select>;
    IsActiveDirectoryUser: RestAttribute<SystemUser_Select>;
    IsDisabled: RestAttribute<SystemUser_Select>;
    IsEmailAddressApprovedByO365Admin: RestAttribute<SystemUser_Select>;
    IsIntegrationUser: RestAttribute<SystemUser_Select>;
    IsLicensed: RestAttribute<SystemUser_Select>;
    IsSyncWithDirectory: RestAttribute<SystemUser_Select>;
    JobTitle: RestAttribute<SystemUser_Select>;
    LastName: RestAttribute<SystemUser_Select>;
    LatestUpdateTime: RestAttribute<SystemUser_Select>;
    MiddleName: RestAttribute<SystemUser_Select>;
    MobileAlertEMail: RestAttribute<SystemUser_Select>;
    MobileOfflineProfileId: RestAttribute<SystemUser_Select>;
    MobilePhone: RestAttribute<SystemUser_Select>;
    ModifiedBy: RestAttribute<SystemUser_Select>;
    ModifiedOn: RestAttribute<SystemUser_Select>;
    ModifiedOnBehalfBy: RestAttribute<SystemUser_Select>;
    NickName: RestAttribute<SystemUser_Select>;
    OrganizationId: RestAttribute<SystemUser_Select>;
    OutgoingEmailDeliveryMethod: RestAttribute<SystemUser_Select>;
    OverriddenCreatedOn: RestAttribute<SystemUser_Select>;
    ParentSystemUserId: RestAttribute<SystemUser_Select>;
    PassportHi: RestAttribute<SystemUser_Select>;
    PassportLo: RestAttribute<SystemUser_Select>;
    PersonalEMailAddress: RestAttribute<SystemUser_Select>;
    PhotoUrl: RestAttribute<SystemUser_Select>;
    PositionId: RestAttribute<SystemUser_Select>;
    PreferredAddressCode: RestAttribute<SystemUser_Select>;
    PreferredEmailCode: RestAttribute<SystemUser_Select>;
    PreferredPhoneCode: RestAttribute<SystemUser_Select>;
    ProcessId: RestAttribute<SystemUser_Select>;
    QueueId: RestAttribute<SystemUser_Select>;
    Salutation: RestAttribute<SystemUser_Select>;
    SetupUser: RestAttribute<SystemUser_Select>;
    SharePointEmailAddress: RestAttribute<SystemUser_Select>;
    Skills: RestAttribute<SystemUser_Select>;
    StageId: RestAttribute<SystemUser_Select>;
    SystemUserId: RestAttribute<SystemUser_Select>;
    TerritoryId: RestAttribute<SystemUser_Select>;
    TimeZoneRuleVersionNumber: RestAttribute<SystemUser_Select>;
    Title: RestAttribute<SystemUser_Select>;
    TransactionCurrencyId: RestAttribute<SystemUser_Select>;
    TraversedPath: RestAttribute<SystemUser_Select>;
    UTCConversionTimeZoneCode: RestAttribute<SystemUser_Select>;
    UserLicenseType: RestAttribute<SystemUser_Select>;
    UserPuid: RestAttribute<SystemUser_Select>;
    VersionNumber: RestAttribute<SystemUser_Select>;
    WindowsLiveID: RestAttribute<SystemUser_Select>;
    YammerEmailAddress: RestAttribute<SystemUser_Select>;
    YammerUserId: RestAttribute<SystemUser_Select>;
  }
  interface SystemUser_Filter {
    AccessMode: XQR.ValueContainerFilter<systemuser_accessmode>;
    ActiveDirectoryGuid: XQR.Guid;
    Address1_AddressId: XQR.Guid;
    Address1_AddressTypeCode: XQR.ValueContainerFilter<systemuser_address1_addresstypecode>;
    Address1_City: string;
    Address1_Composite: string;
    Address1_Country: string;
    Address1_County: string;
    Address1_Fax: string;
    Address1_Latitude: number;
    Address1_Line1: string;
    Address1_Line2: string;
    Address1_Line3: string;
    Address1_Longitude: number;
    Address1_Name: string;
    Address1_PostOfficeBox: string;
    Address1_PostalCode: string;
    Address1_ShippingMethodCode: XQR.ValueContainerFilter<systemuser_address1_shippingmethodcode>;
    Address1_StateOrProvince: string;
    Address1_Telephone1: string;
    Address1_Telephone2: string;
    Address1_Telephone3: string;
    Address1_UPSZone: string;
    Address1_UTCOffset: number;
    Address2_AddressId: XQR.Guid;
    Address2_AddressTypeCode: XQR.ValueContainerFilter<systemuser_address2_addresstypecode>;
    Address2_City: string;
    Address2_Composite: string;
    Address2_Country: string;
    Address2_County: string;
    Address2_Fax: string;
    Address2_Latitude: number;
    Address2_Line1: string;
    Address2_Line2: string;
    Address2_Line3: string;
    Address2_Longitude: number;
    Address2_Name: string;
    Address2_PostOfficeBox: string;
    Address2_PostalCode: string;
    Address2_ShippingMethodCode: XQR.ValueContainerFilter<systemuser_address2_shippingmethodcode>;
    Address2_StateOrProvince: string;
    Address2_Telephone1: string;
    Address2_Telephone2: string;
    Address2_Telephone3: string;
    Address2_UPSZone: string;
    Address2_UTCOffset: number;
    ApplicationId: XQR.Guid;
    ApplicationIdUri: string;
    AzureActiveDirectoryObjectId: XQR.Guid;
    BusinessUnitId: XQR.EntityReferenceFilter;
    CALType: XQR.ValueContainerFilter<systemuser_caltype>;
    CalendarId: XQR.EntityReferenceFilter;
    CreatedBy: XQR.EntityReferenceFilter;
    CreatedOn: Date;
    CreatedOnBehalfBy: XQR.EntityReferenceFilter;
    DefaultFiltersPopulated: boolean;
    DefaultMailbox: XQR.EntityReferenceFilter;
    DefaultOdbFolderName: string;
    DisabledReason: string;
    DisplayInServiceViews: boolean;
    DomainName: string;
    EmailRouterAccessApproval: XQR.ValueContainerFilter<systemuser_emailrouteraccessapproval>;
    EmployeeId: string;
    EntityImageId: XQR.Guid;
    ExchangeRate: any;
    FirstName: string;
    FullName: string;
    GovernmentId: string;
    HomePhone: string;
    IdentityId: number;
    ImportSequenceNumber: number;
    IncomingEmailDeliveryMethod: XQR.ValueContainerFilter<systemuser_incomingemaildeliverymethod>;
    InternalEMailAddress: string;
    InviteStatusCode: XQR.ValueContainerFilter<systemuser_invitestatuscode>;
    IsActiveDirectoryUser: boolean;
    IsDisabled: boolean;
    IsEmailAddressApprovedByO365Admin: boolean;
    IsIntegrationUser: boolean;
    IsLicensed: boolean;
    IsSyncWithDirectory: boolean;
    JobTitle: string;
    LastName: string;
    LatestUpdateTime: Date;
    MiddleName: string;
    MobileAlertEMail: string;
    MobileOfflineProfileId: XQR.EntityReferenceFilter;
    MobilePhone: string;
    ModifiedBy: XQR.EntityReferenceFilter;
    ModifiedOn: Date;
    ModifiedOnBehalfBy: XQR.EntityReferenceFilter;
    NickName: string;
    OrganizationId: XQR.Guid;
    OutgoingEmailDeliveryMethod: XQR.ValueContainerFilter<systemuser_outgoingemaildeliverymethod>;
    OverriddenCreatedOn: Date;
    ParentSystemUserId: XQR.EntityReferenceFilter;
    PassportHi: number;
    PassportLo: number;
    PersonalEMailAddress: string;
    PhotoUrl: string;
    PositionId: XQR.EntityReferenceFilter;
    PreferredAddressCode: XQR.ValueContainerFilter<systemuser_preferredaddresscode>;
    PreferredEmailCode: XQR.ValueContainerFilter<systemuser_preferredemailcode>;
    PreferredPhoneCode: XQR.ValueContainerFilter<systemuser_preferredphonecode>;
    ProcessId: XQR.Guid;
    QueueId: XQR.EntityReferenceFilter;
    Salutation: string;
    SetupUser: boolean;
    SharePointEmailAddress: string;
    Skills: string;
    StageId: XQR.Guid;
    SystemUserId: XQR.Guid;
    TerritoryId: XQR.EntityReferenceFilter;
    TimeZoneRuleVersionNumber: number;
    Title: string;
    TransactionCurrencyId: XQR.EntityReferenceFilter;
    TraversedPath: string;
    UTCConversionTimeZoneCode: number;
    UserLicenseType: number;
    UserPuid: string;
    VersionNumber: number;
    WindowsLiveID: string;
    YammerEmailAddress: string;
    YammerUserId: string;
  }
  interface SystemUser_Expand {
    Referencedlk_systemuser_createdonbehalfby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencedlk_systemuser_modifiedonbehalfby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencedlk_systemuserbase_createdby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencedlk_systemuserbase_modifiedby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referenceduser_parent_user: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencinglk_systemuser_createdonbehalfby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencinglk_systemuser_modifiedonbehalfby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencinglk_systemuserbase_createdby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencinglk_systemuserbase_modifiedby: RestExpand<SystemUser_Select, SystemUser_Select>;
    Referencinguser_parent_user: RestExpand<SystemUser_Select, SystemUser_Select>;
    business_unit_system_users: RestExpand<SystemUser_Select, BusinessUnit_Select>;
    createdby_connection: RestExpand<SystemUser_Select, Connection_Select>;
    lk_businessunit_createdonbehalfby: RestExpand<SystemUser_Select, BusinessUnit_Select>;
    lk_businessunit_modifiedonbehalfby: RestExpand<SystemUser_Select, BusinessUnit_Select>;
    lk_businessunitbase_createdby: RestExpand<SystemUser_Select, BusinessUnit_Select>;
    lk_businessunitbase_modifiedby: RestExpand<SystemUser_Select, BusinessUnit_Select>;
    lk_connectionbase_createdonbehalfby: RestExpand<SystemUser_Select, Connection_Select>;
    lk_connectionbase_modifiedonbehalfby: RestExpand<SystemUser_Select, Connection_Select>;
    lk_team_createdonbehalfby: RestExpand<SystemUser_Select, Team_Select>;
    lk_team_modifiedonbehalfby: RestExpand<SystemUser_Select, Team_Select>;
    lk_teambase_administratorid: RestExpand<SystemUser_Select, Team_Select>;
    lk_teambase_createdby: RestExpand<SystemUser_Select, Team_Select>;
    lk_teambase_modifiedby: RestExpand<SystemUser_Select, Team_Select>;
    modifiedby_connection: RestExpand<SystemUser_Select, Connection_Select>;
    systemuser_connections1: RestExpand<SystemUser_Select, Connection_Select>;
    systemuser_connections2: RestExpand<SystemUser_Select, Connection_Select>;
    teammembership_association: RestExpand<SystemUser_Select, Team_Select>;
  }
}
interface RestEntities {
  SystemUser: RestMapping<Rest.SystemUser,Rest.SystemUser_Select,Rest.SystemUser_Expand,Rest.SystemUser_Filter,Rest.SystemUserResult>;
}
