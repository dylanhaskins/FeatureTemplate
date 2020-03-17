//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DG.XrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;


namespace CCMS.Entities {
    
    
    /// <summary>
    /// <para>Allows a user to upload supporting documents.</para>
    /// <para>Display Name: Supporting document</para>
    /// </summary>
    [EntityLogicalName("dia_supportingdocument")]
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [DataContract()]
    public partial class dia_supportingdocument : ExtendedEntity<dia_supportingdocumentState, dia_supportingdocument_statuscode> {
        
        public const string EntityLogicalName = "dia_supportingdocument";
        
        public const int EntityTypeCode = 10218;
        
        public dia_supportingdocument() : 
                base(EntityLogicalName) {
        }
        
        public dia_supportingdocument(Guid Id) : 
                base(EntityLogicalName, Id) {
        }
        
        private string DebuggerDisplay {
            get {
                return GetDebuggerDisplay("dia_name");
            }
        }
        
        [AttributeLogicalName("dia_supportingdocumentid")]
        public override Guid Id {
            get {
                return base.Id;
            }
            set {
                SetId("dia_supportingdocumentid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for entity instances</para>
        /// <para>Display Name: Supporting document</para>
        /// </summary>
        [AttributeLogicalName("dia_supportingdocumentid")]
        public Guid? dia_supportingdocumentId {
            get {
                return GetAttributeValue<Guid?>("dia_supportingdocumentid");
            }
            set {
                SetId("dia_supportingdocumentid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the user who created the record.</para>
        /// <para>Display Name: Created By</para>
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy {
            get {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }
        
        /// <summary>
        /// <para>Date and time when the record was created.</para>
        /// <para>Display Name: Uploaded on</para>
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn {
            get {
                return GetAttributeValue<DateTime?>("createdon");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the delegate user who created the record.</para>
        /// <para>Display Name: Created By (Delegate)</para>
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy {
            get {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }
        
        /// <summary>
        /// <para>Sequence number of the import that created this record.</para>
        /// <para>Display Name: Import Sequence Number</para>
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber {
            get {
                return GetAttributeValue<int?>("importsequencenumber");
            }
            set {
                SetAttributeValue("importsequencenumber", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the user who modified the record.</para>
        /// <para>Display Name: Modified By</para>
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy {
            get {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }
        
        /// <summary>
        /// <para>Date and time when the record was modified.</para>
        /// <para>Display Name: Modified On</para>
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn {
            get {
                return GetAttributeValue<DateTime?>("modifiedon");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the delegate user who modified the record.</para>
        /// <para>Display Name: Modified By (Delegate)</para>
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy {
            get {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }
        
        /// <summary>
        /// <para>Date and time that the record was migrated.</para>
        /// <para>Display Name: Record Created On</para>
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn {
            get {
                return GetAttributeValue<DateTime?>("overriddencreatedon");
            }
            set {
                SetAttributeValue("overriddencreatedon", value);
            }
        }
        
        /// <summary>
        /// <para>Owner Id</para>
        /// <para>Display Name: Owner</para>
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId {
            get {
                return GetAttributeValue<EntityReference>("ownerid");
            }
            set {
                SetAttributeValue("ownerid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the business unit that owns the record</para>
        /// <para>Display Name: Owning Business Unit</para>
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit {
            get {
                return GetAttributeValue<EntityReference>("owningbusinessunit");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the team that owns the record.</para>
        /// <para>Display Name: Owning Team</para>
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam {
            get {
                return GetAttributeValue<EntityReference>("owningteam");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the user that owns the record.</para>
        /// <para>Display Name: Owning User</para>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser {
            get {
                return GetAttributeValue<EntityReference>("owninguser");
            }
        }
        
        /// <summary>
        /// <para>For internal use only.</para>
        /// <para>Display Name: Time Zone Rule Version Number</para>
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber {
            get {
                return GetAttributeValue<int?>("timezoneruleversionnumber");
            }
            set {
                SetAttributeValue("timezoneruleversionnumber", value);
            }
        }
        
        /// <summary>
        /// <para>Time zone code that was in use when the record was created.</para>
        /// <para>Display Name: UTC Conversion Time Zone Code</para>
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode {
            get {
                return GetAttributeValue<int?>("utcconversiontimezonecode");
            }
            set {
                SetAttributeValue("utcconversiontimezonecode", value);
            }
        }
        
        /// <summary>
        /// <para>Version Number</para>
        /// <para>Display Name: Version Number</para>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber {
            get {
                return GetAttributeValue<long?>("versionnumber");
            }
        }
        
        /// <summary>
        /// <para>Display Name: Require translation</para>
        /// </summary>
        [AttributeLogicalName("dia_requiretranslation")]
        public dia_yesno? dia_RequireTranslation {
            get {
                return GetOptionSetValue<dia_yesno>("dia_requiretranslation");
            }
            set {
                SetOptionSetValue("dia_requiretranslation", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: CBG application</para>
        /// </summary>
        [AttributeLogicalName("dia_cbgapplicationid")]
        public EntityReference dia_cbgapplicationid {
            get {
                return GetAttributeValue<EntityReference>("dia_cbgapplicationid");
            }
            set {
                SetAttributeValue("dia_cbgapplicationid", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Channel type</para>
        /// </summary>
        [AttributeLogicalName("dia_channeltype")]
        public dia_supportingdocument_dia_channeltype? dia_channeltype {
            get {
                return GetOptionSetValue<dia_supportingdocument_dia_channeltype>("dia_channeltype");
            }
            set {
                SetOptionSetValue("dia_channeltype", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Provided as</para>
        /// </summary>
        [AttributeLogicalName("dia_documentcategory")]
        public EntityReference dia_documentcategory {
            get {
                return GetAttributeValue<EntityReference>("dia_documentcategory");
            }
            set {
                SetAttributeValue("dia_documentcategory", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Document path</para>
        /// </summary>
        [AttributeLogicalName("dia_documentpath")]
        public string dia_documentpath {
            get {
                return GetAttributeValue<string>("dia_documentpath");
            }
            set {
                SetAttributeValue("dia_documentpath", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Document type</para>
        /// </summary>
        [AttributeLogicalName("dia_documenttypeid")]
        public EntityReference dia_documenttypeid {
            get {
                return GetAttributeValue<EntityReference>("dia_documenttypeid");
            }
            set {
                SetAttributeValue("dia_documenttypeid", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: File size</para>
        /// </summary>
        [AttributeLogicalName("dia_filesize")]
        public string dia_filesize {
            get {
                return GetAttributeValue<string>("dia_filesize");
            }
            set {
                SetAttributeValue("dia_filesize", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: File type</para>
        /// </summary>
        [AttributeLogicalName("dia_filetype")]
        public string dia_filetype {
            get {
                return GetAttributeValue<string>("dia_filetype");
            }
            set {
                SetAttributeValue("dia_filetype", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Is archived</para>
        /// </summary>
        [AttributeLogicalName("dia_isarchived")]
        public bool? dia_isarchived {
            get {
                return GetAttributeValue<bool?>("dia_isarchived");
            }
            set {
                SetAttributeValue("dia_isarchived", value);
            }
        }
        
        /// <summary>
        /// <para>The name of the custom entity.</para>
        /// <para>Display Name: Name</para>
        /// </summary>
        [AttributeLogicalName("dia_name")]
        public string dia_name {
            get {
                return GetAttributeValue<string>("dia_name");
            }
            set {
                SetAttributeValue("dia_name", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Rejection reason</para>
        /// </summary>
        [AttributeLogicalName("dia_rejectionreason")]
        public dia_documentrejectionreason? dia_rejectionreason {
            get {
                return GetOptionSetValue<dia_documentrejectionreason>("dia_rejectionreason");
            }
            set {
                SetOptionSetValue("dia_rejectionreason", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for Replacement certificate associated with Supporting document.</para>
        /// <para>Display Name: Replacement certificate</para>
        /// </summary>
        [AttributeLogicalName("dia_replacementcertificateid")]
        public EntityReference dia_replacementcertificateid {
            get {
                return GetAttributeValue<EntityReference>("dia_replacementcertificateid");
            }
            set {
                SetAttributeValue("dia_replacementcertificateid", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Translation</para>
        /// </summary>
        [AttributeLogicalName("dia_translation")]
        public bool? dia_translation {
            get {
                return GetAttributeValue<bool?>("dia_translation");
            }
            set {
                SetAttributeValue("dia_translation", value);
            }
        }
        
        /// <summary>
        /// <para>Status of the Supporting document</para>
        /// <para>Display Name: State</para>
        /// </summary>
        [AttributeLogicalName("statecode")]
        public dia_supportingdocumentState? statecode {
            get {
                return GetOptionSetValue<dia_supportingdocumentState>("statecode");
            }
            set {
                SetOptionSetValue("statecode", value);
            }
        }
        
        /// <summary>
        /// <para>Reason for the status of the Supporting document</para>
        /// <para>Display Name: Status</para>
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public dia_supportingdocument_statuscode? statuscode {
            get {
                return GetOptionSetValue<dia_supportingdocument_statuscode>("statuscode");
            }
            set {
                SetOptionSetValue("statuscode", value);
            }
        }
        
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_dia_supportingdocument")]
        public BusinessUnit business_unit_dia_supportingdocument {
            get {
                return GetRelatedEntity<BusinessUnit>("business_unit_dia_supportingdocument", null);
            }
            set {
                SetRelatedEntity("business_unit_dia_supportingdocument", null, value);
            }
        }
        
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_dia_supportingdocument_createdby")]
        public SystemUser lk_dia_supportingdocument_createdby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_supportingdocument_createdby", null);
            }
            set {
                SetRelatedEntity("lk_dia_supportingdocument_createdby", null, value);
            }
        }
        
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_dia_supportingdocument_createdonbehalfby")]
        public SystemUser lk_dia_supportingdocument_createdonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_supportingdocument_createdonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_supportingdocument_createdonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_dia_supportingdocument_modifiedby")]
        public SystemUser lk_dia_supportingdocument_modifiedby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_supportingdocument_modifiedby", null);
            }
            set {
                SetRelatedEntity("lk_dia_supportingdocument_modifiedby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_dia_supportingdocument_modifiedonbehalfby")]
        public SystemUser lk_dia_supportingdocument_modifiedonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_supportingdocument_modifiedonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_supportingdocument_modifiedonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_dia_supportingdocument")]
        public Team team_dia_supportingdocument {
            get {
                return GetRelatedEntity<Team>("team_dia_supportingdocument", null);
            }
            set {
                SetRelatedEntity("team_dia_supportingdocument", null, value);
            }
        }
        
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_dia_supportingdocument")]
        public SystemUser user_dia_supportingdocument {
            get {
                return GetRelatedEntity<SystemUser>("user_dia_supportingdocument", null);
            }
            set {
                SetRelatedEntity("user_dia_supportingdocument", null, value);
            }
        }
        
        public static dia_supportingdocument Retrieve(IOrganizationService service, Guid id, params Expression<Func<dia_supportingdocument,object>>[] attrs) {
            return service.Retrieve(id, attrs);
        }
    }
    
    [DataContract()]
    public enum dia_supportingdocumentState {
        
        [EnumMember()]
        Active = 0,
        
        [EnumMember()]
        Inactive = 1,
    }
    
    [DataContract()]
    public enum dia_supportingdocument_dia_channeltype {
        
        [EnumMember()]
        Mail = 100000000,
        
        [EnumMember()]
        Counter = 100000001,
        
        [EnumMember()]
        Email = 100000002,
        
        [EnumMember()]
        Internal = 100000003,
        
        [EnumMember()]
        Online = 100000004,
    }
    
    [DataContract()]
    public enum dia_supportingdocument_statuscode {
        
        [EnumMember()]
        Pendingupload = 1,
        
        [EnumMember()]
        Inactive = 2,
        
        [EnumMember()]
        Uploadsuccessful = 100000000,
        
        [EnumMember()]
        Uploadrejected = 100000001,
    }
}