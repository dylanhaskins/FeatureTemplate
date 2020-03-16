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
    /// <para>Reference entity for Application types.</para>
    /// <para>Display Name: Application type</para>
    /// </summary>
    [EntityLogicalName("dia_applicationtype")]
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [DataContract()]
    public partial class dia_applicationtype : ExtendedEntity<dia_applicationtypeState, dia_applicationtype_statuscode> {
        
        public const string EntityLogicalName = "dia_applicationtype";
        
        public const int EntityTypeCode = 10189;
        
        public dia_applicationtype() : 
                base(EntityLogicalName) {
        }
        
        public dia_applicationtype(Guid Id) : 
                base(EntityLogicalName, Id) {
        }
        
        private string DebuggerDisplay {
            get {
                return GetDebuggerDisplay("dia_name");
            }
        }
        
        [AttributeLogicalName("dia_applicationtypeid")]
        public override Guid Id {
            get {
                return base.Id;
            }
            set {
                SetId("dia_applicationtypeid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for entity instances</para>
        /// <para>Display Name: Application type</para>
        /// </summary>
        [AttributeLogicalName("dia_applicationtypeid")]
        public Guid? dia_applicationtypeId {
            get {
                return GetAttributeValue<Guid?>("dia_applicationtypeid");
            }
            set {
                SetId("dia_applicationtypeid", value);
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
        /// <para>Display Name: Created On</para>
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
        /// <para>Display Name: DAL code</para>
        /// </summary>
        [AttributeLogicalName("dia_dalcode")]
        public string dia_dalcode {
            get {
                return GetAttributeValue<string>("dia_dalcode");
            }
            set {
                SetAttributeValue("dia_dalcode", value);
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
        /// <para>Status of the Application type</para>
        /// <para>Display Name: State</para>
        /// </summary>
        [AttributeLogicalName("statecode")]
        public dia_applicationtypeState? statecode {
            get {
                return GetOptionSetValue<dia_applicationtypeState>("statecode");
            }
            set {
                SetOptionSetValue("statecode", value);
            }
        }
        
        /// <summary>
        /// <para>Reason for the status of the Application type</para>
        /// <para>Display Name: Status</para>
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public dia_applicationtype_statuscode? statuscode {
            get {
                return GetOptionSetValue<dia_applicationtype_statuscode>("statuscode");
            }
            set {
                SetOptionSetValue("statuscode", value);
            }
        }
        
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_dia_applicationtype")]
        public BusinessUnit business_unit_dia_applicationtype {
            get {
                return GetRelatedEntity<BusinessUnit>("business_unit_dia_applicationtype", null);
            }
            set {
                SetRelatedEntity("business_unit_dia_applicationtype", null, value);
            }
        }
        
        [RelationshipSchemaName("dia_product_applicationtype")]
        public IEnumerable<Product> dia_product_applicationtype {
            get {
                return GetRelatedEntities<Product>("dia_product_applicationtype", null);
            }
            set {
                SetRelatedEntities("dia_product_applicationtype", null, value);
            }
        }
        
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_dia_applicationtype_createdby")]
        public SystemUser lk_dia_applicationtype_createdby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_applicationtype_createdby", null);
            }
            set {
                SetRelatedEntity("lk_dia_applicationtype_createdby", null, value);
            }
        }
        
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_dia_applicationtype_createdonbehalfby")]
        public SystemUser lk_dia_applicationtype_createdonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_applicationtype_createdonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_applicationtype_createdonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_dia_applicationtype_modifiedby")]
        public SystemUser lk_dia_applicationtype_modifiedby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_applicationtype_modifiedby", null);
            }
            set {
                SetRelatedEntity("lk_dia_applicationtype_modifiedby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_dia_applicationtype_modifiedonbehalfby")]
        public SystemUser lk_dia_applicationtype_modifiedonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_applicationtype_modifiedonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_applicationtype_modifiedonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_dia_applicationtype")]
        public Team team_dia_applicationtype {
            get {
                return GetRelatedEntity<Team>("team_dia_applicationtype", null);
            }
            set {
                SetRelatedEntity("team_dia_applicationtype", null, value);
            }
        }
        
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_dia_applicationtype")]
        public SystemUser user_dia_applicationtype {
            get {
                return GetRelatedEntity<SystemUser>("user_dia_applicationtype", null);
            }
            set {
                SetRelatedEntity("user_dia_applicationtype", null, value);
            }
        }
        
        public static dia_applicationtype Retrieve(IOrganizationService service, Guid id, params Expression<Func<dia_applicationtype,object>>[] attrs) {
            return service.Retrieve(id, attrs);
        }
    }
    
    [DataContract()]
    public enum dia_applicationtypeState {
        
        [EnumMember()]
        Active = 0,
        
        [EnumMember()]
        Inactive = 1,
    }
    
    [DataContract()]
    public enum dia_applicationtype_statuscode {
        
        [EnumMember()]
        Active = 1,
        
        [EnumMember()]
        Inactive = 2,
    }
}