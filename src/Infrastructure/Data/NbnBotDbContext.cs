using NbnBotClean.Application.Common.Interfaces;
using NbnBotClean.Domain.Entities.NbnBotDb;
using Microsoft.EntityFrameworkCore;

namespace NbnBotClean.Infrastructure.Data;

	public class NbnBotDbContext(DbContextOptions<NbnBotDbContext> options) : DbContext(options), INbnBotDbContext
	{
		
    public virtual DbSet<AddressResult> AddressResults { get; set; }

    public virtual DbSet<AddressesCsv> AddressesCsvs { get; set; }

    public virtual DbSet<Config> Configs { get; set; }

    public virtual DbSet<CrmImport> CrmImports { get; set; }

    public virtual DbSet<CrmOrder> CrmOrders { get; set; }

    public virtual DbSet<CrmPlanChangeOrder> CrmPlanChangeOrders { get; set; }

    public virtual DbSet<CrmUpdateQueue> CrmUpdateQueues { get; set; }

    public virtual DbSet<DbRollout> DbRollouts { get; set; }

    public virtual DbSet<EeroOrder> EeroOrders { get; set; }

    public virtual DbSet<EeroOrderApiHistory> EeroOrderApiHistories { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; }

    public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; }

    public virtual DbSet<NbnOrder> NbnOrders { get; set; }

    public virtual DbSet<NbnPlanSpeed> NbnPlanSpeeds { get; set; }

    public virtual DbSet<NbnSearchNormalised> NbnSearchNormaliseds { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<ProvisioningStatus> ProvisioningStatuses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleHasPermission> RoleHasPermissions { get; set; }

    public virtual DbSet<ServiceClass> ServiceClasses { get; set; }

    public virtual DbSet<ServiceHealth> ServiceHealths { get; set; }

    public virtual DbSet<ServiceHealthDatum> ServiceHealthData { get; set; }

    public virtual DbSet<ServiceHealthRv> ServiceHealthRvs { get; set; }

    public virtual DbSet<ServiceHealthRvsApCon> ServiceHealthRvsApCons { get; set; }

    public virtual DbSet<SqResult> SqResults { get; set; }

    public virtual DbSet<Summary> Summaries { get; set; }

    public virtual DbSet<TransactionLog> TransactionLogs { get; set; }

    public virtual DbSet<UploadUsername> UploadUsernames { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WsmCallback> WsmCallbacks { get; set; }

    public virtual DbSet<WsmCallbackResponse> WsmCallbackResponses { get; set; }

    public virtual DbSet<WsmCallbacksRaw> WsmCallbacksRaws { get; set; }

    public virtual DbSet<WsmPlan> WsmPlans { get; set; }

    public virtual DbSet<WsmServiceId> WsmServiceIds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressResult>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("address_results_PRIMARY")
                .IsClustered(false);

            entity.ToTable("address_results");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressLong)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DirectoryId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DirectoryID");
            entity.Property(e => e.FibreAddressRecord)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.RawId).HasColumnName("raw_id");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<AddressesCsv>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("addresses_csv_PRIMARY")
                .IsClustered(false);

            entity.ToTable("addresses_csv");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(57)
                .IsUnicode(false);
            entity.Property(e => e.Billed)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("billed");
            entity.Property(e => e.ChargeType).HasColumnName("Charge_Type");
            entity.Property(e => e.Cost)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("cost");
            entity.Property(e => e.Fnn).HasColumnName("FNN");
            entity.Property(e => e.Fsa)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FSA");
            entity.Property(e => e.LocationIds)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("location_ids");
            entity.Property(e => e.SourceName)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("Source_Name");
            entity.Property(e => e.State)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Suburb)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TechnologyType)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Technology_Type");
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("config_PRIMARY")
                .IsClustered(false);

            entity.ToTable("config");

            entity.HasIndex(e => e.Category, "config_category_IDX");

            entity.HasIndex(e => e.ConfigKey, "config_key_IDX");

            entity.HasIndex(e => e.Subcategory, "config_subcategory_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.ConfigKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("config_key");
            entity.Property(e => e.ConfigText)
                .HasColumnType("ntext")
                .HasColumnName("config_text");
            entity.Property(e => e.ConfigValue)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("config_value");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Subcategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subcategory");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
        });

        modelBuilder.Entity<CrmImport>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("crm_imports_PRIMARY")
                .IsClustered(false);

            entity.ToTable("crm_imports");

            entity.HasIndex(e => e.CreatedAt, "crm_imports_ipnd_source_files_created_at_IDX");

            entity.HasIndex(e => e.FileName, "crm_imports_ipnd_source_files_file_name_IDX");

            entity.HasIndex(e => e.FileNameOriginal, "crm_imports_ipnd_source_files_file_name_original_IDX");

            entity.HasIndex(e => e.GenerationCount, "crm_imports_ipnd_source_files_generation_count_IDX");

            entity.HasIndex(e => e.OutputFileName, "crm_imports_ipnd_source_files_output_file_name_IDX");

            entity.HasIndex(e => e.Status, "crm_imports_ipnd_source_files_status_IDX");

            entity.HasIndex(e => e.StoragePath, "crm_imports_ipnd_source_files_storage_path_IDX");

            entity.HasIndex(e => e.TotalRows, "crm_imports_ipnd_source_files_total_rows_IDX");

            entity.HasIndex(e => e.UploadedByUserEmail, "crm_imports_ipnd_source_files_uploaded_by_user_email_IDX");

            entity.HasIndex(e => e.ValidationCount, "crm_imports_ipnd_source_files_validation_count_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Error)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("error");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.FileNameOriginal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("file_name_original");
            entity.Property(e => e.GenerationCount).HasColumnName("generation_count");
            entity.Property(e => e.OutputFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("output_file_name");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.StoragePath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("storage_path");
            entity.Property(e => e.TotalRows).HasColumnName("total_rows");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UploadedByUserEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("uploaded_by_user_email");
            entity.Property(e => e.ValidationCount).HasColumnName("validation_count");
        });

        modelBuilder.Entity<CrmOrder>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("crm_orders_PRIMARY")
                .IsClustered(false);

            entity.ToTable("crm_orders");

            entity.HasIndex(e => e.CrmImportId, "crm_orders_crm_import_id_IDX");

            entity.HasIndex(e => e.FvNewOrdertype, "crm_orders_fv_new_ordertype");

            entity.HasIndex(e => e.NewMtorderid, "crm_orders_new_mtorderid_IDX");

            entity.HasIndex(e => e.NewNbnlocid, "crm_orders_new_nbnlocid_IDX");

            entity.HasIndex(e => e.NewOrdernumber, "crm_orders_new_ordernumber_IDX");

            entity.HasIndex(e => e.Status, "crm_orders_status_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckAddress)
                .HasDefaultValue((short)0)
                .HasColumnName("check_address");
            entity.Property(e => e.CheckCoatUpgrade).HasColumnName("check_coat_upgrade");
            entity.Property(e => e.CheckHfcSpeed)
                .HasDefaultValue((short)0)
                .HasColumnName("check_hfc_speed");
            entity.Property(e => e.CheckModemonorder)
                .HasDefaultValue((short)0)
                .HasColumnName("check_modemonorder");
            entity.Property(e => e.CheckNewdevchargeapplies)
                .HasDefaultValue((short)0)
                .HasColumnName("check_newdevchargeapplies");
            entity.Property(e => e.CopperPairId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("copper_pair_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CrmImportId).HasColumnName("crm_import_id");
            entity.Property(e => e.FvNewAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fv_new_account");
            entity.Property(e => e.FvNewCsaid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_csaid");
            entity.Property(e => e.FvNewModemonorder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_modemonorder");
            entity.Property(e => e.FvNewNbnnewtransfer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnnewtransfer");
            entity.Property(e => e.FvNewNbnserviceclass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnserviceclass");
            entity.Property(e => e.FvNewNbnservicetype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnservicetype");
            entity.Property(e => e.FvNewNbnspeedtier)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnspeedtier");
            entity.Property(e => e.FvNewNewdevchargeapplies)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_newdevchargeapplies");
            entity.Property(e => e.FvNewOrdertype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_ordertype");
            entity.Property(e => e.FvNewSitestate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_sitestate");
            entity.Property(e => e.FvNewSitestreettype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_sitestreettype");
            entity.Property(e => e.FvNewUbgroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_ubgroup");
            entity.Property(e => e.NewAppointmentdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_appointmentdate");
            entity.Property(e => e.NewDeliveryunitnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_deliveryunitnumber");
            entity.Property(e => e.NewEslatype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_eslatype");
            entity.Property(e => e.NewMtorderid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtorderid");
            entity.Property(e => e.NewMtordertypeid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtordertypeid");
            entity.Property(e => e.NewMtproductid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtproductid");
            entity.Property(e => e.NewNbnlocid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnlocid");
            entity.Property(e => e.NewNbnlongaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_nbnlongaddress");
            entity.Property(e => e.NewNbnservicetype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnservicetype");
            entity.Property(e => e.NewNbnspeedtier)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnspeedtier");
            entity.Property(e => e.NewOrdernumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_ordernumber");
            entity.Property(e => e.NewPreferredstartdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_preferredstartdate");
            entity.Property(e => e.NewProductnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_productnumber");
            entity.Property(e => e.NewSiteaddresscountrycode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_siteaddresscountrycode");
            entity.Property(e => e.NewSitepostcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitepostcode");
            entity.Property(e => e.NewSitestreetname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitestreetname");
            entity.Property(e => e.NewSitestreetnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitestreetnumber");
            entity.Property(e => e.NewSitesuburb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitesuburb");
            entity.Property(e => e.NewStaticip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_staticip");
            entity.Property(e => e.NewUseableip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_useableip");
            entity.Property(e => e.NewUtilibillaccountnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_utilibillaccountnumber");
            entity.Property(e => e.NoteTag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note_tag");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.PlanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reference_id");
            entity.Property(e => e.Resubmit)
                .HasDefaultValue((short)0)
                .HasColumnName("resubmit");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ServiceID");
            entity.Property(e => e.SqServiceType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sqServiceType");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CrmPlanChangeOrder>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("crm_plan_change_orders_PRIMARY")
                .IsClustered(false);

            entity.ToTable("crm_plan_change_orders");

            entity.HasIndex(e => e.CrmImportId, "crm_plan_change_orders_crm_orders_crm_import_id_IDX");

            entity.HasIndex(e => e.NewMtorderid, "crm_plan_change_orders_crm_orders_new_mtorderid_IDX");

            entity.HasIndex(e => e.NewNbnlocid, "crm_plan_change_orders_crm_orders_new_nbnlocid_IDX");

            entity.HasIndex(e => e.NewOrdernumber, "crm_plan_change_orders_crm_orders_new_ordernumber_IDX");

            entity.HasIndex(e => e.Status, "crm_plan_change_orders_crm_orders_status_IDX");

            entity.HasIndex(e => e.FvNewOrdertype, "crm_plan_change_orders_fv_new_mtordertype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackendRawId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("backendRawId");
            entity.Property(e => e.CheckAddress)
                .HasDefaultValue((short)0)
                .HasColumnName("check_address");
            entity.Property(e => e.CheckCoatUpgrade).HasColumnName("check_coat_upgrade");
            entity.Property(e => e.CheckHfcSpeed)
                .HasDefaultValue((short)0)
                .HasColumnName("check_hfc_speed");
            entity.Property(e => e.CheckModemonorder)
                .HasDefaultValue((short)0)
                .HasColumnName("check_modemonorder");
            entity.Property(e => e.CheckNewdevchargeapplies)
                .HasDefaultValue((short)0)
                .HasColumnName("check_newdevchargeapplies");
            entity.Property(e => e.CopperPairId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("copper_pair_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CrmImportId).HasColumnName("crm_import_id");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Faultstring)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("faultstring");
            entity.Property(e => e.FlagCrmorderUpdated)
                .HasDefaultValue((short)0)
                .HasColumnName("flagCRMOrderUpdated");
            entity.Property(e => e.FlagCrmproductUpdated)
                .HasDefaultValue((short)0)
                .HasColumnName("flagCRMProductUpdated");
            entity.Property(e => e.FlagUbupdated)
                .HasDefaultValue((short)0)
                .HasColumnName("flagUBUpdated");
            entity.Property(e => e.FvNewAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fv_new_account");
            entity.Property(e => e.FvNewCsaid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_csaid");
            entity.Property(e => e.FvNewModemonorder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_modemonorder");
            entity.Property(e => e.FvNewNbnnewtransfer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnnewtransfer");
            entity.Property(e => e.FvNewNbnserviceclass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnserviceclass");
            entity.Property(e => e.FvNewNbnservicetype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnservicetype");
            entity.Property(e => e.FvNewNbnspeedtier)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnspeedtier");
            entity.Property(e => e.FvNewNewdevchargeapplies)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_newdevchargeapplies");
            entity.Property(e => e.FvNewNewmtproductitemchangeplan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_newmtproductitemchangeplan");
            entity.Property(e => e.FvNewNewplanchangeplan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_newplanchangeplan");
            entity.Property(e => e.FvNewOrdertype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_ordertype");
            entity.Property(e => e.FvNewOriginatingmtproduct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_originatingmtproduct");
            entity.Property(e => e.FvNewSitestate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_sitestate");
            entity.Property(e => e.FvNewSitestreettype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_sitestreettype");
            entity.Property(e => e.FvNewUbgroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_ubgroup");
            entity.Property(e => e.NewAppointmentdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_appointmentdate");
            entity.Property(e => e.NewDeliveryunitnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_deliveryunitnumber");
            entity.Property(e => e.NewMtorderid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtorderid");
            entity.Property(e => e.NewMtordertypeid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtordertypeid");
            entity.Property(e => e.NewNbnlocid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnlocid");
            entity.Property(e => e.NewNbnlongaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_nbnlongaddress");
            entity.Property(e => e.NewNewmtproductitemchangeplan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_newmtproductitemchangeplan");
            entity.Property(e => e.NewNewplanchangeplan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_newplanchangeplan");
            entity.Property(e => e.NewOrdernumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_ordernumber");
            entity.Property(e => e.NewOriginatingmtproduct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_originatingmtproduct");
            entity.Property(e => e.NewPreferredstartdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_preferredstartdate");
            entity.Property(e => e.NewSiteaddresscountrycode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_siteaddresscountrycode");
            entity.Property(e => e.NewSitepostcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitepostcode");
            entity.Property(e => e.NewSitestreetname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitestreetname");
            entity.Property(e => e.NewSitestreetnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitestreetnumber");
            entity.Property(e => e.NewSitesuburb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_sitesuburb");
            entity.Property(e => e.NewUtilibillaccountnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_utilibillaccountnumber");
            entity.Property(e => e.NoteTag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note_tag");
            entity.Property(e => e.OriginatingmtproductNewCarrierid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("originatingmtproduct_new_carrierid");
            entity.Property(e => e.OriginatingmtproductNewMtproductitem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("originatingmtproduct_new_mtproductitem");
            entity.Property(e => e.OriginatingmtproductNewUbserviceid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("originatingmtproduct_new_ubserviceid");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.PlanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ProvisionedAt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("provisioned_at");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reference_id");
            entity.Property(e => e.ResponseUpdatedAt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("response_updated_at");
            entity.Property(e => e.Resubmit)
                .HasDefaultValue((short)0)
                .HasColumnName("resubmit");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ServiceID");
            entity.Property(e => e.SqServiceType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sqServiceType");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");
            entity.Property(e => e.TransactionState)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UbplanNewUbid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ubplan_new_ubid");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CrmUpdateQueue>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("crm_update_queue_PRIMARY")
                .IsClustered(false);

            entity.ToTable("crm_update_queue");

            entity.HasIndex(e => e.DbOperation, "crm_update_queue_cuq_db_operation_IDX");

            entity.HasIndex(e => e.EntityName, "crm_update_queue_cuq_entity_name_IDX");

            entity.HasIndex(e => e.EntityReferenceId, "crm_update_queue_cuq_entity_reference_id_IDX");

            entity.HasIndex(e => e.Status, "crm_update_queue_cuq_status_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CrmData)
                .HasColumnType("ntext")
                .HasColumnName("crm_data");
            entity.Property(e => e.DbOperation)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("db_operation");
            entity.Property(e => e.EntityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("entity_name");
            entity.Property(e => e.EntityReferenceId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("entity_reference_id");
            entity.Property(e => e.ErrorMsg)
                .HasColumnType("ntext")
                .HasColumnName("error_msg");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<DbRollout>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("db_rollout_PRIMARY")
                .IsClustered(false);

            entity.ToTable("db_rollout");

            entity.HasIndex(e => e.Success, "db_rollout_success_IDX");

            entity.HasIndex(e => e.VersionNumber, "db_rollout_version_number_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Message)
                .HasColumnType("ntext")
                .HasColumnName("message");
            entity.Property(e => e.Success)
                .HasDefaultValue((short)0)
                .HasColumnName("success");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.VersionNumber).HasColumnName("version_number");
        });

        modelBuilder.Entity<EeroOrder>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("eero_orders_PRIMARY")
                .IsClustered(false);

            entity.ToTable("eero_orders");

            entity.HasIndex(e => e.NewEerostatus, "eero_orders_crm_eerostatus_IDX");

            entity.HasIndex(e => e.NewNbnlocid, "eero_orders_crm_orders_new_nbnlocid_IDX");

            entity.HasIndex(e => e.CrmImportId, "eero_orders_crm_products_crm_import_id_IDX");

            entity.HasIndex(e => e.NewMtproductid, "eero_orders_crm_products_new_mtproductid_IDX");

            entity.HasIndex(e => e.NewProductnumber, "eero_orders_new_productnumber");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CallCounter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("call_counter");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CrmImportId).HasColumnName("crm_import_id");
            entity.Property(e => e.EeroId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eero_id");
            entity.Property(e => e.FvNewAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fv_new_account");
            entity.Property(e => e.FvNewMtproductcategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_mtproductcategory");
            entity.Property(e => e.FvNewMtproductitem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_mtproductitem");
            entity.Property(e => e.FvNewNbnserviceclass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnserviceclass");
            entity.Property(e => e.FvNewOriginatingmtorder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_originatingmtorder");
            entity.Property(e => e.FvNewServicetype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_servicetype");
            entity.Property(e => e.FvNewUbgroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_ubgroup");
            entity.Property(e => e.IsArchived)
                .HasDefaultValue((short)0)
                .HasColumnName("is_archived");
            entity.Property(e => e.NewAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_account");
            entity.Property(e => e.NewEerostatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("new_eerostatus");
            entity.Property(e => e.NewMtproductcategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_mtproductcategory");
            entity.Property(e => e.NewMtproductid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtproductid");
            entity.Property(e => e.NewMtproductitem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_mtproductitem");
            entity.Property(e => e.NewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_name");
            entity.Property(e => e.NewNbnlocid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnlocid");
            entity.Property(e => e.NewNbnserviceclass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnserviceclass");
            entity.Property(e => e.NewOriginatingmtorder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_originatingmtorder");
            entity.Property(e => e.NewProductnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_productnumber");
            entity.Property(e => e.NewSenttoeerodate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_senttoeerodate");
            entity.Property(e => e.NewSerialnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_serialnumber");
            entity.Property(e => e.NewServicetype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_servicetype");
            entity.Property(e => e.NewUbgroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_ubgroup");
            entity.Property(e => e.NewUbplan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("new_ubplan");
            entity.Property(e => e.NewUtilibillaccountnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_utilibillaccountnumber");
            entity.Property(e => e.NoteTag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note_tag");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.Resubmit)
                .HasDefaultValue((short)0)
                .HasColumnName("resubmit");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<EeroOrderApiHistory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("eero_order_api_history_PRIMARY")
                .IsClustered(false);

            entity.ToTable("eero_order_api_history");

            entity.HasIndex(e => e.EeroOrderId, "eero_order_api_history_eero_order_id_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiRequest)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("api_request");
            entity.Property(e => e.ApiResponse)
                .HasColumnType("ntext")
                .HasColumnName("api_response");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EeroId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eero_id");
            entity.Property(e => e.EeroOrderId).HasColumnName("eero_order_id");
            entity.Property(e => e.EeroSerial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eero_serial");
            entity.Property(e => e.LogComments)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("log_comments");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("jobs_PRIMARY")
                .IsClustered(false);

            entity.ToTable("jobs");

            entity.HasIndex(e => e.Queue, "jobs_queue_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.AvailableAt).HasColumnName("available_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Payload)
                .HasColumnType("ntext")
                .HasColumnName("payload");
            entity.Property(e => e.Queue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("queue");
            entity.Property(e => e.ReservedAt).HasColumnName("reserved_at");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("migrations_PRIMARY")
                .IsClustered(false);

            entity.ToTable("migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<ModelHasPermission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionId, e.ModelId, e.ModelType })
                .HasName("model_has_permissions_PRIMARY")
                .IsClustered(false);

            entity.ToTable("model_has_permissions");

            entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_permissions_model_id_model_type_index");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.ModelType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("model_type");
        });

        modelBuilder.Entity<ModelHasRole>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType })
                .HasName("model_has_roles_PRIMARY")
                .IsClustered(false);

            entity.ToTable("model_has_roles");

            entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_roles_model_id_model_type_index");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.ModelType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("model_type");
        });

        modelBuilder.Entity<NbnOrder>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("nbn_orders_PRIMARY")
                .IsClustered(false);

            entity.ToTable("nbn_orders");

            entity.HasIndex(e => e.AppointmentDate, "nbn_orders_AppointmentDate_IDX");

            entity.HasIndex(e => e.BillingProviderId, "nbn_orders_BillingProviderID_IDX");

            entity.HasIndex(e => e.Cadate, "nbn_orders_CADate_IDX");

            entity.HasIndex(e => e.CarrierId, "nbn_orders_CarrierID_IDX");

            entity.HasIndex(e => e.ErrorCode, "nbn_orders_ErrorCode_IDX");

            entity.HasIndex(e => e.OrderType, "nbn_orders_OrderType_IDX");

            entity.HasIndex(e => e.PlanId, "nbn_orders_PlanID_IDX");

            entity.HasIndex(e => e.ProductId, "nbn_orders_ProductID_IDX");

            entity.HasIndex(e => e.ServiceId, "nbn_orders_ServiceID_IDX");

            entity.HasIndex(e => e.ServiceType, "nbn_orders_ServiceType_IDX");

            entity.HasIndex(e => e.TransactionId, "nbn_orders_TransactionID_IDX");

            entity.HasIndex(e => e.TransactionState, "nbn_orders_TransactionState_IDX");

            entity.HasIndex(e => e.CallbackId, "nbn_orders_callbackId_IDX");

            entity.HasIndex(e => e.CreatedAt, "nbn_orders_created_at_IDX");

            entity.HasIndex(e => e.CrmOrderId, "nbn_orders_crm_order_id_IDX");

            entity.HasIndex(e => e.Faultstring, "nbn_orders_faultstring_IDX");

            entity.HasIndex(e => e.FvNewNbnserviceclass, "nbn_orders_fv_new_nbnserviceclass_IDX");

            entity.HasIndex(e => e.IsArchived, "nbn_orders_is_archived_IDX");

            entity.HasIndex(e => e.LatestServiceHealthId, "nbn_orders_latest_service_health_id_IDX");

            entity.HasIndex(e => e.NewEslatype, "nbn_orders_new_eslatype_IDX");

            entity.HasIndex(e => e.NewMtorderid, "nbn_orders_new_mtorderid_IDX");

            entity.HasIndex(e => e.NewMtproductid, "nbn_orders_new_mtproductid_IDX");

            entity.HasIndex(e => e.NewNbnavc, "nbn_orders_new_nbnavc_IDX");

            entity.HasIndex(e => e.NewNbnpri, "nbn_orders_new_nbnpri_IDX");

            entity.HasIndex(e => e.NewOrdernumber, "nbn_orders_new_ordernumber_IDX");

            entity.HasIndex(e => e.NewProductnumber, "nbn_orders_new_productnumber_IDX");

            entity.HasIndex(e => e.NewStaticip, "nbn_orders_new_staticip_IDX");

            entity.HasIndex(e => e.NewUseableip, "nbn_orders_new_useableip_IDX");

            entity.HasIndex(e => e.NewUtilibillaccountnumber, "nbn_orders_new_utilibillaccountnumber_IDX");

            entity.HasIndex(e => e.ProvisionedAt, "nbn_orders_provisioned_at_IDX");

            entity.HasIndex(e => e.ResponseUpdatedAt, "nbn_orders_response_updated_at_IDX");

            entity.HasIndex(e => e.ScheduledAt, "nbn_orders_scheduled_at_IDX");

            entity.HasIndex(e => e.ServiceHealthSignal, "nbn_orders_service_health_signal_IDX");

            entity.HasIndex(e => e.Status, "nbn_orders_status_IDX");

            entity.HasIndex(e => e.SubmittedAt, "nbn_orders_submitted_at_IDX");

            entity.HasIndex(e => e.UpdatedAt, "nbn_orders_updated_at_IDX");

            entity.HasIndex(e => e.UpdatedBy, "nbn_orders_updated_by_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlternativeTechnology)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AppointmentDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ArchivalReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("archival_reason");
            entity.Property(e => e.Battery)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillingProviderId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BillingProviderID");
            entity.Property(e => e.Cadate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CADate");
            entity.Property(e => e.CallbackId).HasColumnName("callbackId");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CarrierID");
            entity.Property(e => e.CentralSplitter)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CopperPairId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CopperPairID");
            entity.Property(e => e.CpedirectoryId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CPEDirectoryID");
            entity.Property(e => e.CpeplanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CPEPlanID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CrmOrderId).HasColumnName("crm_order_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DataPortNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DirectoryId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DirectoryID");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("error_message");
            entity.Property(e => e.Faultstring)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("faultstring");
            entity.Property(e => e.FvNewNbnserviceclass).HasColumnName("fv_new_nbnserviceclass");
            entity.Property(e => e.FvNewNbnspeedtier)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fv_new_nbnspeedtier");
            entity.Property(e => e.IsArchived)
                .HasDefaultValue((short)0)
                .HasColumnName("is_archived");
            entity.Property(e => e.LatestServiceHealthId).HasColumnName("latest_service_health_id");
            entity.Property(e => e.LocationReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NbncpeplanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NBNCPEPlanID");
            entity.Property(e => e.Nbncrd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NBNCRD");
            entity.Property(e => e.NewEslatype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_eslatype");
            entity.Property(e => e.NewMtorderid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtorderid");
            entity.Property(e => e.NewMtproductid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_mtproductid");
            entity.Property(e => e.NewNbnavc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnavc");
            entity.Property(e => e.NewNbnpri)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_nbnpri");
            entity.Property(e => e.NewOrdernumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_ordernumber");
            entity.Property(e => e.NewProductnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_productnumber");
            entity.Property(e => e.NewStaticip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_staticip");
            entity.Property(e => e.NewUseableip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_useableip");
            entity.Property(e => e.NewUtilibillaccountnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_utilibillaccountnumber");
            entity.Property(e => e.NoteTag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note_tag");
            entity.Property(e => e.Ntdid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTDID");
            entity.Property(e => e.OrderType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PlanID");
            entity.Property(e => e.ProductId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProvisionedAt)
                .HasColumnType("datetime")
                .HasColumnName("provisioned_at");
            entity.Property(e => e.Realm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResponseUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("response_updated_at");
            entity.Property(e => e.ScheduledAt)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_at");
            entity.Property(e => e.Scope)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceHealthSignal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service_health_signal");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ServiceID");
            entity.Property(e => e.ServiceLevel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceRunCount).HasColumnName("service_run_count");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.SubmittedAt)
                .HasColumnType("datetime")
                .HasColumnName("submitted_at");
            entity.Property(e => e.TrafficClass1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionState)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VoicePortId1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VoicePortID1");
            entity.Property(e => e.VoicePortId2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VoicePortID2");
            entity.Property(e => e.VoicebandContinuity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VoipserviceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VOIPServiceID");
        });

        modelBuilder.Entity<NbnPlanSpeed>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("nbn_plan_speeds_PRIMARY")
                .IsClustered(false);

            entity.ToTable("nbn_plan_speeds");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DownloadSpeedMbps).HasColumnName("download_speed_mbps");
            entity.Property(e => e.MtProductItemGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mt_product_item_guid");
            entity.Property(e => e.MtProductItemTitle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mt_product_item_title");
            entity.Property(e => e.ServiceTypeTechnology)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("service_type_technology");
            entity.Property(e => e.TelcoBrand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telco_brand");
            entity.Property(e => e.UbId).HasColumnName("ub_id");
            entity.Property(e => e.UbPlanGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ub_plan_guid");
            entity.Property(e => e.UbPlanTitle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ub_plan_title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UploadSpeedMbps).HasColumnName("upload_speed_mbps");
        });

        modelBuilder.Entity<NbnSearchNormalised>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("nbn_search_normalised_PRIMARY")
                .IsClustered(false);

            entity.ToTable("nbn_search_normalised");

            entity.HasIndex(e => e.CreatedAt, "nbn_search_normalised_created_at_IDX");

            entity.HasIndex(e => e.ServiceId, "nbn_search_normalised_service_id_IDX");

            entity.HasIndex(e => e.Status, "nbn_search_normalised_status_IDX");

            entity.HasIndex(e => e.UpdatedAt, "nbn_search_normalised_updated_at_IDX");

            entity.HasIndex(e => e.UploadId, "nbn_search_normalised_upload_id_IDX");

            entity.HasIndex(e => e.UserId, "nbn_search_normalised_user_id_IDX");

            entity.HasIndex(e => e.Username, "nbn_search_normalised_username_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiResponse)
                .HasColumnType("ntext")
                .HasColumnName("api_response");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service_id");
            entity.Property(e => e.ServiceStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("service_status");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UploadId).HasColumnName("upload_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("permissions_PRIMARY")
                .IsClustered(false);

            entity.ToTable("permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.GuardName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("guard_name");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ProvisioningStatus>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("provisioning_status_PRIMARY")
                .IsClustered(false);

            entity.ToTable("provisioning_status");

            entity.HasIndex(e => e.Status, "provisioning_status_order_status_status_IDX").IsUnique();

            entity.HasIndex(e => e.Title, "provisioning_status_order_status_title_IDX").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("roles_PRIMARY")
                .IsClustered(false);

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.GuardName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("guard_name");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<RoleHasPermission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionId, e.RoleId })
                .HasName("role_has_permissions_PRIMARY")
                .IsClustered(false);

            entity.ToTable("role_has_permissions");

            entity.HasIndex(e => e.RoleId, "role_has_permissions_role_id_foreign");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
        });

        modelBuilder.Entity<ServiceClass>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_classes_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_classes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.OrderTypes)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("order_types");
            entity.Property(e => e.ServiceClass1).HasColumnName("service_class");
            entity.Property(e => e.Technology)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("technology");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ServiceHealth>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_health_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_health");

            entity.HasIndex(e => e.Connectivity, "service_health_connectivity_IDX");

            entity.HasIndex(e => e.NormalisationStatus, "service_health_normalisation_status_IDX");

            entity.HasIndex(e => e.Performance, "service_health_performance_IDX");

            entity.HasIndex(e => e.ResponseDatetime, "service_health_response_datetime_IDX");

            entity.HasIndex(e => e.ResponseStatus, "service_health_response_status_IDX");

            entity.HasIndex(e => e.CreatedAt, "service_health_shs_created_at_IDX");

            entity.HasIndex(e => e.HealthId, "service_health_shs_health_id_IDX");

            entity.HasIndex(e => e.ServiceId, "service_health_shs_service_id_IDX");

            entity.HasIndex(e => e.Stability, "service_health_stability_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Connectivity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("connectivity");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.HealthId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("health_id");
            entity.Property(e => e.NormalisationStatus)
                .HasDefaultValue(0)
                .HasColumnName("normalisation_status");
            entity.Property(e => e.Performance)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("performance");
            entity.Property(e => e.ResponseDatetime)
                .HasColumnType("datetime")
                .HasColumnName("response_datetime");
            entity.Property(e => e.ResponseStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("response_status");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service_id");
            entity.Property(e => e.ShsJson)
                .HasColumnType("ntext")
                .HasColumnName("shs_json");
            entity.Property(e => e.Stability)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stability");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ServiceHealthDatum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_health_data_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_health_data");

            entity.HasIndex(e => e.CaptureDatetime, "service_health_data_shd_capture_datetime_IDX");

            entity.HasIndex(e => e.CreatedAt, "service_health_data_shd_created_at_IDX");

            entity.HasIndex(e => e.MetricName, "service_health_data_shd_metric_name_IDX");

            entity.HasIndex(e => e.MetricType, "service_health_data_shd_metric_type_IDX");

            entity.HasIndex(e => e.ParamCode, "service_health_data_shd_param_code_IDX");

            entity.HasIndex(e => e.ParamStatus, "service_health_data_shd_param_status_IDX");

            entity.HasIndex(e => e.ParamValue, "service_health_data_shd_param_value_IDX");

            entity.HasIndex(e => e.ServiceHealthId, "service_health_data_shd_service_health_id_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaptureDatetime)
                .HasColumnType("datetime")
                .HasColumnName("capture_datetime");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.MetricName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("metric_name");
            entity.Property(e => e.MetricType)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("metric_type");
            entity.Property(e => e.ParamCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("param_code");
            entity.Property(e => e.ParamName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("param_status");
            entity.Property(e => e.ParamUnit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("param_unit");
            entity.Property(e => e.ParamValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("param_value");
            entity.Property(e => e.ServiceHealthId).HasColumnName("service_health_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ServiceHealthRv>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_health_rvs_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_health_rvs");

            entity.HasIndex(e => e.CreatedAt, "service_health_rvs_shrv_created_at_IDX");

            entity.HasIndex(e => e.RvCaptureDatetime, "service_health_rvs_shrv_rv_capture_datetime_IDX");

            entity.HasIndex(e => e.RvName, "service_health_rvs_shrv_rv_name_IDX");

            entity.HasIndex(e => e.ServiceHealthId, "service_health_rvs_shrv_service_health_id_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.RvCaptureDatetime)
                .HasColumnType("datetime")
                .HasColumnName("rv_capture_datetime");
            entity.Property(e => e.RvDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rv_description");
            entity.Property(e => e.RvName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rv_name");
            entity.Property(e => e.ServiceHealthId).HasColumnName("service_health_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ServiceHealthRvsApCon>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_health_rvs_ap_cons_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_health_rvs_ap_cons");

            entity.HasIndex(e => e.CreatedAt, "service_health_rvs_ap_cons_shrvac_created_at_IDX");

            entity.HasIndex(e => e.RvAcName, "service_health_rvs_ap_cons_shrvac_rv_ac_name_IDX");

            entity.HasIndex(e => e.ServiceHealthRvId, "service_health_rvs_ap_cons_shrvac_service_health_rv_id_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.RvAcDescription)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("rv_ac_description");
            entity.Property(e => e.RvAcName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rv_ac_name");
            entity.Property(e => e.ServiceHealthRvId).HasColumnName("service_health_rv_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SqResult>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("sq_results_PRIMARY")
                .IsClustered(false);

            entity.ToTable("sq_results");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationDate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressLong)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AlternativeTechnology)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AvailableCtag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AvailableCTAG");
            entity.Property(e => e.Battery)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BroadbandAddressRecord)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.ConnectionType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CopperDisconnectionDate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CopperPairRecord).HasColumnType("ntext");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Csa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CSA");
            entity.Property(e => e.Cvcid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CVCID");
            entity.Property(e => e.DataPort)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DevelopmentCharge)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DirectoryId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DirectoryID");
            entity.Property(e => e.HfcselfInstall)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HFCSelfInstall");
            entity.Property(e => e.Nbncoatrecord)
                .HasColumnType("ntext")
                .HasColumnName("NBNCOATRecord");
            entity.Property(e => e.NbnfeatureRecord)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("NBNFeatureRecord");
            entity.Property(e => e.NbnportRecord)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("NBNPortRecord");
            entity.Property(e => e.Ntdid)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("NTDID");
            entity.Property(e => e.RawId).HasColumnName("raw_id");
            entity.Property(e => e.Result)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceClass)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Stag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STAG");
            entity.Property(e => e.TrafficClass1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrafficClass2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrafficClass3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrafficClass4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.VoiceCvcid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VoiceCVCID");
            entity.Property(e => e.VoicePort)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Zone)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Summary>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("summary_PRIMARY")
                .IsClustered(false);

            entity.ToTable("summary");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Errored).HasColumnName("errored");
            entity.Property(e => e.Failed).HasColumnName("failed");
            entity.Property(e => e.Processing).HasColumnName("processing");
            entity.Property(e => e.Provisioned).HasColumnName("provisioned");
            entity.Property(e => e.Submitted).HasColumnName("submitted");
            entity.Property(e => e.SummaryDate)
                .HasColumnType("datetime")
                .HasColumnName("summaryDate");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.Withdrawn).HasColumnName("withdrawn");
        });

        modelBuilder.Entity<TransactionLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("transaction_log_PRIMARY")
                .IsClustered(false);

            entity.ToTable("transaction_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("carrier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasColumnName("date_updated");
            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("domain");
            entity.Property(e => e.LineSize)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("line_size");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PlanType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plan_type");
            entity.Property(e => e.Request)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("request");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UploadUsername>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("upload_usernames_PRIMARY")
                .IsClustered(false);

            entity.ToTable("upload_usernames");

            entity.HasIndex(e => e.CreatedAt, "upload_usernames_created_at_IDX");

            entity.HasIndex(e => e.Status, "upload_usernames_status_IDX");

            entity.HasIndex(e => e.UpdatedAt, "upload_usernames_updated_at_IDX");

            entity.HasIndex(e => e.UserId, "upload_usernames_user_id_IDX");

            entity.HasIndex(e => e.Username, "upload_usernames_username_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("users_PRIMARY")
                .IsClustered(false);

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "users_email_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remember_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WsmCallback>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("wsm_callbacks_PRIMARY")
                .IsClustered(false);

            entity.ToTable("wsm_callbacks");

            entity.HasIndex(e => e.RawCallbackId, "wsm_callbacks_raw_callback_id_IDX");

            entity.HasIndex(e => e.Status, "wsm_callbacks_status_IDX");

            entity.HasIndex(e => e.WsmTransactionId, "wsm_callbacks_wsm_transaction_id_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckTransactionId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ack_transaction_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.RawCallbackId).HasColumnName("raw_callback_id");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            entity.Property(e => e.WsmTransactionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wsm_transaction_id");
        });

        modelBuilder.Entity<WsmCallbackResponse>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("wsm_callback_responses_PRIMARY")
                .IsClustered(false);

            entity.ToTable("wsm_callback_responses");

            entity.HasIndex(e => e.AckTransactionId, "wsm_callback_responses_ack_transaction_id_IDX").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckTransactionId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ack_transaction_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
        });

        modelBuilder.Entity<WsmCallbacksRaw>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("wsm_callbacks_raw_PRIMARY")
                .IsClustered(false);

            entity.ToTable("wsm_callbacks_raw");

            entity.HasIndex(e => e.ClientIp, "wsm_callbacks_raw_client_ip_IDX");

            entity.HasIndex(e => e.Status, "wsm_callbacks_raw_status_IDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("client_ip");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ErrorMessage)
                .HasColumnType("ntext")
                .HasColumnName("error_message");
            entity.Property(e => e.RawPayload)
                .HasColumnType("ntext")
                .HasColumnName("raw_payload");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
        });

        modelBuilder.Entity<WsmPlan>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("wsm_plans_PRIMARY")
                .IsClustered(false);

            entity.ToTable("wsm_plans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.LineSpeed)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mapping)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PlanID");
            entity.Property(e => e.ProductId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ServiceTypeOptionsetValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("serviceTypeOptionsetValue");
            entity.Property(e => e.SpeedTypeOptionsetValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("speedTypeOptionsetValue");
            entity.Property(e => e.Technology)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<WsmServiceId>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("wsm_service_ids_PRIMARY")
                .IsClustered(false);

            entity.ToTable("wsm_service_ids");

            entity.HasIndex(e => e.ServiceId, "wsm_service_ids_wsm_callback_responses_ack_transaction_id_IDX").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
        });

    }

}
