using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NbnBotClean.Infrastructure.Migrations.NbnBotDb
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_results",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raw_id = table.Column<long>(type: "bigint", nullable: true),
                    DirectoryID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TransactionID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FibreAddressRecord = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    AddressLong = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("address_results_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "addresses_csv",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source_Name = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Charge_Type = table.Column<int>(type: "int", nullable: true),
                    FNN = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    cost = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    billed = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    Technology_Type = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    FSA = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    Address = table.Column<string>(type: "varchar(57)", unicode: false, maxLength: 57, nullable: true),
                    Suburb = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Postcode = table.Column<int>(type: "int", nullable: true),
                    location_ids = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("addresses_csv_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "config",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    subcategory = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    config_key = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    config_value = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    config_text = table.Column<string>(type: "ntext", nullable: true),
                    updated_by_user_id = table.Column<long>(type: "bigint", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("config_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "crm_imports",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uploaded_by_user_email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    file_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    storage_path = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    file_name_original = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    total_rows = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    error = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    validation_count = table.Column<int>(type: "int", nullable: true),
                    generation_count = table.Column<int>(type: "int", nullable: true),
                    output_file_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("crm_imports_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "crm_orders",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm_import_id = table.Column<long>(type: "bigint", nullable: true),
                    new_mtorderid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnlocid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_ordernumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_ordertype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_appointmentdate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitepostcode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_deliveryunitnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitestreetnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitestreetname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_siteaddresscountrycode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    new_sitesuburb = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnlongaddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_utilibillaccountnumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fv_new_nbnserviceclass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnservicetype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    sqServiceType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_account = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fv_new_sitestreettype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_sitestate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnnewtransfer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_csaid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnspeedtier = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_ubgroup = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_modemonorder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_newdevchargeapplies = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    check_modemonorder = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_newdevchargeapplies = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_address = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_hfc_speed = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    plan_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    copper_pair_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    reference_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    phone_number = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    ServiceID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    resubmit = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    note_tag = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    new_preferredstartdate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    check_coat_upgrade = table.Column<short>(type: "smallint", nullable: true),
                    new_mtordertypeid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnspeedtier = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnservicetype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_useableip = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_eslatype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_staticip = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_mtproductid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_productnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("crm_orders_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "crm_plan_change_orders",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm_import_id = table.Column<long>(type: "bigint", nullable: true),
                    new_mtorderid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnlocid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_ordernumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_ordertype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_appointmentdate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitepostcode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_deliveryunitnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitestreetnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_sitestreetname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_siteaddresscountrycode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    new_sitesuburb = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnlongaddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_utilibillaccountnumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fv_new_nbnserviceclass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnservicetype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    sqServiceType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_account = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fv_new_sitestreettype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_sitestate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnnewtransfer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_csaid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnspeedtier = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_ubgroup = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_modemonorder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_newdevchargeapplies = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    check_modemonorder = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_newdevchargeapplies = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_address = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    check_hfc_speed = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    plan_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    copper_pair_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    reference_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    phone_number = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    ServiceID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    resubmit = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    note_tag = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    new_preferredstartdate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    check_coat_upgrade = table.Column<short>(type: "smallint", nullable: true),
                    new_mtordertypeid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_newplanchangeplan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_newplanchangeplan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_newmtproductitemchangeplan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_newmtproductitemchangeplan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_originatingmtproduct = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_originatingmtproduct = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    originatingmtproduct_new_carrierid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    originatingmtproduct_new_ubserviceid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    originatingmtproduct_new_mtproductitem = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    backendRawId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TransactionState = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ErrorCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    faultstring = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    response_updated_at = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    provisioned_at = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ubplan_new_ubid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    flagUBUpdated = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    flagCRMProductUpdated = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    flagCRMOrderUpdated = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("crm_plan_change_orders_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "crm_update_queue",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    db_operation = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    entity_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    entity_reference_id = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    crm_data = table.Column<string>(type: "ntext", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    error_msg = table.Column<string>(type: "ntext", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("crm_update_queue_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "db_rollout",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    version_number = table.Column<int>(type: "int", nullable: true),
                    success = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    message = table.Column<string>(type: "ntext", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("db_rollout_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "eero_order_api_history",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eero_order_id = table.Column<long>(type: "bigint", nullable: true),
                    eero_serial = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    eero_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    api_request = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    api_response = table.Column<string>(type: "ntext", nullable: true),
                    log_comments = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("eero_order_api_history_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "eero_orders",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm_import_id = table.Column<long>(type: "bigint", nullable: true),
                    new_mtproductid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_productnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_account = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_nbnserviceclass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnlocid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_mtproductcategory = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_mtproductitem = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_ubplan = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_ubgroup = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    new_servicetype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_originatingmtorder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_eerostatus = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    new_senttoeerodate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_serialnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_utilibillaccountnumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    phone_number = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnserviceclass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_ubgroup = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_account = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fv_new_originatingmtorder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_servicetype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_mtproductitem = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_mtproductcategory = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    resubmit = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    note_tag = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    eero_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    call_counter = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    is_archived = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("eero_orders_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    queue = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    payload = table.Column<string>(type: "ntext", nullable: false),
                    attempts = table.Column<short>(type: "smallint", nullable: false),
                    reserved_at = table.Column<long>(type: "bigint", nullable: true),
                    available_at = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("jobs_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "migrations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    migration = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    batch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("migrations_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "model_has_permissions",
                columns: table => new
                {
                    permission_id = table.Column<long>(type: "bigint", nullable: false),
                    model_type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    model_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("model_has_permissions_PRIMARY", x => new { x.permission_id, x.model_id, x.model_type })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "model_has_roles",
                columns: table => new
                {
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    model_type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    model_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("model_has_roles_PRIMARY", x => new { x.role_id, x.model_id, x.model_type })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "nbn_orders",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm_order_id = table.Column<long>(type: "bigint", nullable: true),
                    new_ordernumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_mtorderid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fv_new_nbnserviceclass = table.Column<int>(type: "int", nullable: true),
                    fv_new_nbnspeedtier = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ProductID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PlanID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VoicebandContinuity = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Scope = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Realm = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OrderType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Username = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrafficClass1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DataPortNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VoicePortID1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VoicePortID2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CopperPairID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CarrierID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Battery = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceLevel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CentralSplitter = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NTDID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DirectoryID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CPEDirectoryID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CPEPlanID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NBNCPEPlanID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NBNCRD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VOIPServiceID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LocationReference = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Reference = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CADate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_utilibillaccountnumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransactionState = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TransactionID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    callbackId = table.Column<long>(type: "bigint", nullable: true),
                    AppointmentDate = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    BillingProviderID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    service_run_count = table.Column<int>(type: "int", nullable: true),
                    faultstring = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    ErrorCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    error_message = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    scheduled_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    submitted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    provisioned_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    response_updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_archived = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)0),
                    archival_reason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    note_tag = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AlternativeTechnology = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    latest_service_health_id = table.Column<int>(type: "int", nullable: true),
                    service_health_signal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    new_useableip = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_eslatype = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_staticip = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_mtproductid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_productnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnavc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_nbnpri = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("nbn_orders_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "nbn_plan_speeds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mt_product_item_title = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    mt_product_item_guid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ub_plan_title = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ub_plan_guid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ub_id = table.Column<int>(type: "int", nullable: true),
                    service_type_technology = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telco_brand = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    download_speed_mbps = table.Column<int>(type: "int", nullable: true),
                    upload_speed_mbps = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("nbn_plan_speeds_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "nbn_search_normalised",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    upload_id = table.Column<long>(type: "bigint", nullable: true),
                    username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    service_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    service_status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    api_response = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("nbn_search_normalised_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    guard_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("permissions_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "provisioning_status",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("provisioning_status_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "role_has_permissions",
                columns: table => new
                {
                    permission_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_has_permissions_PRIMARY", x => new { x.permission_id, x.role_id })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    guard_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("roles_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "service_classes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_class = table.Column<int>(type: "int", nullable: true),
                    technology = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_types = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_classes_PRIMARY", x => x.id);
                });
				
            migrationBuilder.CreateTable(
                name: "service_health",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    health_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    connectivity = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    performance = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stability = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    response_status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    response_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    shs_json = table.Column<string>(type: "ntext", nullable: true),
                    normalisation_status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_health_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "service_health_data",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_health_id = table.Column<long>(type: "bigint", nullable: false),
                    metric_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    metric_type = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    param_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    param_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    param_status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    param_unit = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    param_value = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    capture_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_health_data_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "service_health_rvs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_health_id = table.Column<long>(type: "bigint", nullable: false),
                    rv_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    rv_description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    rv_capture_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_health_rvs_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "service_health_rvs_ap_cons",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_health_rv_id = table.Column<long>(type: "bigint", nullable: false),
                    rv_ac_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    rv_ac_description = table.Column<string>(type: "varchar(4096)", unicode: false, maxLength: 4096, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_health_rvs_ap_cons_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "sq_results",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raw_id = table.Column<long>(type: "bigint", nullable: true),
                    DirectoryID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TransactionID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Result = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ServiceClass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DataPort = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VoicePort = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NBNPortRecord = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    CSA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CVCID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Zone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VoiceCVCID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrafficClass1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrafficClass2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrafficClass3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrafficClass4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AvailableCTAG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    STAG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NTDID = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    Battery = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ConnectionType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DevelopmentCharge = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CopperPairRecord = table.Column<string>(type: "ntext", nullable: true),
                    ActivationDate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CopperDisconnectionDate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NBNFeatureRecord = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    HFCSelfInstall = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BroadbandAddressRecord = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    AddressLong = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AlternativeTechnology = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NBNCOATRecord = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sq_results_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "summary",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    summaryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    submitted = table.Column<int>(type: "int", nullable: true),
                    provisioned = table.Column<int>(type: "int", nullable: true),
                    processing = table.Column<int>(type: "int", nullable: true),
                    active = table.Column<int>(type: "int", nullable: true),
                    archived = table.Column<int>(type: "int", nullable: true),
                    failed = table.Column<int>(type: "int", nullable: true),
                    errored = table.Column<int>(type: "int", nullable: true),
                    withdrawn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("summary_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "transaction_log",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    request = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    line_size = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    plan_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    username = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    carrier_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    domain = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("transaction_log_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "upload_usernames",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("upload_usernames_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email_verified_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    remember_token = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "wsm_callback_responses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ack_transaction_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    updated_by_user_id = table.Column<long>(type: "bigint", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("wsm_callback_responses_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "wsm_callbacks",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wsm_transaction_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    raw_callback_id = table.Column<long>(type: "bigint", nullable: true),
                    ack_transaction_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    updated_by_user_id = table.Column<long>(type: "bigint", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("wsm_callbacks_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "wsm_callbacks_raw",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_ip = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    updated_by_user_id = table.Column<long>(type: "bigint", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    error_message = table.Column<string>(type: "ntext", nullable: true),
                    raw_payload = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("wsm_callbacks_raw_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "wsm_plans",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ProductID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Technology = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mapping = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LineSpeed = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    serviceTypeOptionsetValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    speedTypeOptionsetValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_by = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("wsm_plans_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "wsm_service_ids",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    updated_by_user_id = table.Column<long>(type: "bigint", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("wsm_service_ids_PRIMARY", x => x.id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "config_category_IDX",
                table: "config",
                column: "category");

            migrationBuilder.CreateIndex(
                name: "config_key_IDX",
                table: "config",
                column: "config_key");

            migrationBuilder.CreateIndex(
                name: "config_subcategory_IDX",
                table: "config",
                column: "subcategory");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_created_at_IDX",
                table: "crm_imports",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_file_name_IDX",
                table: "crm_imports",
                column: "file_name");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_file_name_original_IDX",
                table: "crm_imports",
                column: "file_name_original");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_generation_count_IDX",
                table: "crm_imports",
                column: "generation_count");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_output_file_name_IDX",
                table: "crm_imports",
                column: "output_file_name");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_status_IDX",
                table: "crm_imports",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_storage_path_IDX",
                table: "crm_imports",
                column: "storage_path");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_total_rows_IDX",
                table: "crm_imports",
                column: "total_rows");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_uploaded_by_user_email_IDX",
                table: "crm_imports",
                column: "uploaded_by_user_email");

            migrationBuilder.CreateIndex(
                name: "crm_imports_ipnd_source_files_validation_count_IDX",
                table: "crm_imports",
                column: "validation_count");

            migrationBuilder.CreateIndex(
                name: "crm_orders_crm_import_id_IDX",
                table: "crm_orders",
                column: "crm_import_id");

            migrationBuilder.CreateIndex(
                name: "crm_orders_fv_new_ordertype",
                table: "crm_orders",
                column: "fv_new_ordertype");

            migrationBuilder.CreateIndex(
                name: "crm_orders_new_mtorderid_IDX",
                table: "crm_orders",
                column: "new_mtorderid");

            migrationBuilder.CreateIndex(
                name: "crm_orders_new_nbnlocid_IDX",
                table: "crm_orders",
                column: "new_nbnlocid");

            migrationBuilder.CreateIndex(
                name: "crm_orders_new_ordernumber_IDX",
                table: "crm_orders",
                column: "new_ordernumber");

            migrationBuilder.CreateIndex(
                name: "crm_orders_status_IDX",
                table: "crm_orders",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_crm_orders_crm_import_id_IDX",
                table: "crm_plan_change_orders",
                column: "crm_import_id");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_crm_orders_new_mtorderid_IDX",
                table: "crm_plan_change_orders",
                column: "new_mtorderid");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_crm_orders_new_nbnlocid_IDX",
                table: "crm_plan_change_orders",
                column: "new_nbnlocid");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_crm_orders_new_ordernumber_IDX",
                table: "crm_plan_change_orders",
                column: "new_ordernumber");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_crm_orders_status_IDX",
                table: "crm_plan_change_orders",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "crm_plan_change_orders_fv_new_mtordertype",
                table: "crm_plan_change_orders",
                column: "fv_new_ordertype");

            migrationBuilder.CreateIndex(
                name: "crm_update_queue_cuq_db_operation_IDX",
                table: "crm_update_queue",
                column: "db_operation");

            migrationBuilder.CreateIndex(
                name: "crm_update_queue_cuq_entity_name_IDX",
                table: "crm_update_queue",
                column: "entity_name");

            migrationBuilder.CreateIndex(
                name: "crm_update_queue_cuq_entity_reference_id_IDX",
                table: "crm_update_queue",
                column: "entity_reference_id");

            migrationBuilder.CreateIndex(
                name: "crm_update_queue_cuq_status_IDX",
                table: "crm_update_queue",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "db_rollout_success_IDX",
                table: "db_rollout",
                column: "success");

            migrationBuilder.CreateIndex(
                name: "db_rollout_version_number_IDX",
                table: "db_rollout",
                column: "version_number");

            migrationBuilder.CreateIndex(
                name: "eero_order_api_history_eero_order_id_IDX",
                table: "eero_order_api_history",
                column: "eero_order_id");

            migrationBuilder.CreateIndex(
                name: "eero_orders_crm_eerostatus_IDX",
                table: "eero_orders",
                column: "new_eerostatus");

            migrationBuilder.CreateIndex(
                name: "eero_orders_crm_orders_new_nbnlocid_IDX",
                table: "eero_orders",
                column: "new_nbnlocid");

            migrationBuilder.CreateIndex(
                name: "eero_orders_crm_products_crm_import_id_IDX",
                table: "eero_orders",
                column: "crm_import_id");

            migrationBuilder.CreateIndex(
                name: "eero_orders_crm_products_new_mtproductid_IDX",
                table: "eero_orders",
                column: "new_mtproductid");

            migrationBuilder.CreateIndex(
                name: "eero_orders_new_productnumber",
                table: "eero_orders",
                column: "new_productnumber");

            migrationBuilder.CreateIndex(
                name: "jobs_queue_index",
                table: "jobs",
                column: "queue");

            migrationBuilder.CreateIndex(
                name: "model_has_permissions_model_id_model_type_index",
                table: "model_has_permissions",
                columns: new[] { "model_id", "model_type" });

            migrationBuilder.CreateIndex(
                name: "model_has_roles_model_id_model_type_index",
                table: "model_has_roles",
                columns: new[] { "model_id", "model_type" });

            migrationBuilder.CreateIndex(
                name: "nbn_orders_AppointmentDate_IDX",
                table: "nbn_orders",
                column: "AppointmentDate");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_BillingProviderID_IDX",
                table: "nbn_orders",
                column: "BillingProviderID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_CADate_IDX",
                table: "nbn_orders",
                column: "CADate");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_callbackId_IDX",
                table: "nbn_orders",
                column: "callbackId");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_CarrierID_IDX",
                table: "nbn_orders",
                column: "CarrierID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_created_at_IDX",
                table: "nbn_orders",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_crm_order_id_IDX",
                table: "nbn_orders",
                column: "crm_order_id");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_ErrorCode_IDX",
                table: "nbn_orders",
                column: "ErrorCode");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_faultstring_IDX",
                table: "nbn_orders",
                column: "faultstring");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_fv_new_nbnserviceclass_IDX",
                table: "nbn_orders",
                column: "fv_new_nbnserviceclass");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_is_archived_IDX",
                table: "nbn_orders",
                column: "is_archived");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_latest_service_health_id_IDX",
                table: "nbn_orders",
                column: "latest_service_health_id");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_eslatype_IDX",
                table: "nbn_orders",
                column: "new_eslatype");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_mtorderid_IDX",
                table: "nbn_orders",
                column: "new_mtorderid");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_mtproductid_IDX",
                table: "nbn_orders",
                column: "new_mtproductid");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_nbnavc_IDX",
                table: "nbn_orders",
                column: "new_nbnavc");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_nbnpri_IDX",
                table: "nbn_orders",
                column: "new_nbnpri");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_ordernumber_IDX",
                table: "nbn_orders",
                column: "new_ordernumber");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_productnumber_IDX",
                table: "nbn_orders",
                column: "new_productnumber");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_staticip_IDX",
                table: "nbn_orders",
                column: "new_staticip");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_useableip_IDX",
                table: "nbn_orders",
                column: "new_useableip");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_new_utilibillaccountnumber_IDX",
                table: "nbn_orders",
                column: "new_utilibillaccountnumber");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_OrderType_IDX",
                table: "nbn_orders",
                column: "OrderType");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_PlanID_IDX",
                table: "nbn_orders",
                column: "PlanID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_ProductID_IDX",
                table: "nbn_orders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_provisioned_at_IDX",
                table: "nbn_orders",
                column: "provisioned_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_response_updated_at_IDX",
                table: "nbn_orders",
                column: "response_updated_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_scheduled_at_IDX",
                table: "nbn_orders",
                column: "scheduled_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_service_health_signal_IDX",
                table: "nbn_orders",
                column: "service_health_signal");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_ServiceID_IDX",
                table: "nbn_orders",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_ServiceType_IDX",
                table: "nbn_orders",
                column: "ServiceType");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_status_IDX",
                table: "nbn_orders",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_submitted_at_IDX",
                table: "nbn_orders",
                column: "submitted_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_TransactionID_IDX",
                table: "nbn_orders",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_TransactionState_IDX",
                table: "nbn_orders",
                column: "TransactionState");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_updated_at_IDX",
                table: "nbn_orders",
                column: "updated_at");

            migrationBuilder.CreateIndex(
                name: "nbn_orders_updated_by_IDX",
                table: "nbn_orders",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_created_at_IDX",
                table: "nbn_search_normalised",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_service_id_IDX",
                table: "nbn_search_normalised",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_status_IDX",
                table: "nbn_search_normalised",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_updated_at_IDX",
                table: "nbn_search_normalised",
                column: "updated_at");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_upload_id_IDX",
                table: "nbn_search_normalised",
                column: "upload_id");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_user_id_IDX",
                table: "nbn_search_normalised",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "nbn_search_normalised_username_IDX",
                table: "nbn_search_normalised",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "provisioning_status_order_status_status_IDX",
                table: "provisioning_status",
                column: "status",
                unique: true,
                filter: "[status] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "provisioning_status_order_status_title_IDX",
                table: "provisioning_status",
                column: "title",
                unique: true,
                filter: "[title] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "role_has_permissions_role_id_foreign",
                table: "role_has_permissions",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "service_health_connectivity_IDX",
                table: "service_health",
                column: "connectivity");

            migrationBuilder.CreateIndex(
                name: "service_health_normalisation_status_IDX",
                table: "service_health",
                column: "normalisation_status");

            migrationBuilder.CreateIndex(
                name: "service_health_performance_IDX",
                table: "service_health",
                column: "performance");

            migrationBuilder.CreateIndex(
                name: "service_health_response_datetime_IDX",
                table: "service_health",
                column: "response_datetime");

            migrationBuilder.CreateIndex(
                name: "service_health_response_status_IDX",
                table: "service_health",
                column: "response_status");

            migrationBuilder.CreateIndex(
                name: "service_health_shs_created_at_IDX",
                table: "service_health",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "service_health_shs_health_id_IDX",
                table: "service_health",
                column: "health_id");

            migrationBuilder.CreateIndex(
                name: "service_health_shs_service_id_IDX",
                table: "service_health",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "service_health_stability_IDX",
                table: "service_health",
                column: "stability");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_capture_datetime_IDX",
                table: "service_health_data",
                column: "capture_datetime");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_created_at_IDX",
                table: "service_health_data",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_metric_name_IDX",
                table: "service_health_data",
                column: "metric_name");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_metric_type_IDX",
                table: "service_health_data",
                column: "metric_type");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_param_code_IDX",
                table: "service_health_data",
                column: "param_code");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_param_status_IDX",
                table: "service_health_data",
                column: "param_status");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_param_value_IDX",
                table: "service_health_data",
                column: "param_value");

            migrationBuilder.CreateIndex(
                name: "service_health_data_shd_service_health_id_IDX",
                table: "service_health_data",
                column: "service_health_id");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_shrv_created_at_IDX",
                table: "service_health_rvs",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_shrv_rv_capture_datetime_IDX",
                table: "service_health_rvs",
                column: "rv_capture_datetime");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_shrv_rv_name_IDX",
                table: "service_health_rvs",
                column: "rv_name");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_shrv_service_health_id_IDX",
                table: "service_health_rvs",
                column: "service_health_id");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_ap_cons_shrvac_created_at_IDX",
                table: "service_health_rvs_ap_cons",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_ap_cons_shrvac_rv_ac_name_IDX",
                table: "service_health_rvs_ap_cons",
                column: "rv_ac_name");

            migrationBuilder.CreateIndex(
                name: "service_health_rvs_ap_cons_shrvac_service_health_rv_id_IDX",
                table: "service_health_rvs_ap_cons",
                column: "service_health_rv_id");

            migrationBuilder.CreateIndex(
                name: "upload_usernames_created_at_IDX",
                table: "upload_usernames",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "upload_usernames_status_IDX",
                table: "upload_usernames",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "upload_usernames_updated_at_IDX",
                table: "upload_usernames",
                column: "updated_at");

            migrationBuilder.CreateIndex(
                name: "upload_usernames_user_id_IDX",
                table: "upload_usernames",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "upload_usernames_username_IDX",
                table: "upload_usernames",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "users_email_unique",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "wsm_callback_responses_ack_transaction_id_IDX",
                table: "wsm_callback_responses",
                column: "ack_transaction_id",
                unique: true,
                filter: "[ack_transaction_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "wsm_callbacks_raw_callback_id_IDX",
                table: "wsm_callbacks",
                column: "raw_callback_id");

            migrationBuilder.CreateIndex(
                name: "wsm_callbacks_status_IDX",
                table: "wsm_callbacks",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "wsm_callbacks_wsm_transaction_id_IDX",
                table: "wsm_callbacks",
                column: "wsm_transaction_id");

            migrationBuilder.CreateIndex(
                name: "wsm_callbacks_raw_client_ip_IDX",
                table: "wsm_callbacks_raw",
                column: "client_ip");

            migrationBuilder.CreateIndex(
                name: "wsm_callbacks_raw_status_IDX",
                table: "wsm_callbacks_raw",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "wsm_service_ids_wsm_callback_responses_ack_transaction_id_IDX",
                table: "wsm_service_ids",
                column: "service_id",
                unique: true,
                filter: "[service_id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_results");

            migrationBuilder.DropTable(
                name: "addresses_csv");

            migrationBuilder.DropTable(
                name: "config");

            migrationBuilder.DropTable(
                name: "crm_imports");

            migrationBuilder.DropTable(
                name: "crm_orders");

            migrationBuilder.DropTable(
                name: "crm_plan_change_orders");

            migrationBuilder.DropTable(
                name: "crm_update_queue");

            migrationBuilder.DropTable(
                name: "db_rollout");

            migrationBuilder.DropTable(
                name: "eero_order_api_history");

            migrationBuilder.DropTable(
                name: "eero_orders");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "migrations");

            migrationBuilder.DropTable(
                name: "model_has_permissions");

            migrationBuilder.DropTable(
                name: "model_has_roles");

            migrationBuilder.DropTable(
                name: "nbn_orders");

            migrationBuilder.DropTable(
                name: "nbn_plan_speeds");

            migrationBuilder.DropTable(
                name: "nbn_search_normalised");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "provisioning_status");

            migrationBuilder.DropTable(
                name: "role_has_permissions");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "service_health");

            migrationBuilder.DropTable(
                name: "service_health_data");

            migrationBuilder.DropTable(
                name: "service_health_rvs");

            migrationBuilder.DropTable(
                name: "service_health_rvs_ap_cons");

            migrationBuilder.DropTable(
                name: "sq_results");

            migrationBuilder.DropTable(
                name: "summary");

            migrationBuilder.DropTable(
                name: "transaction_log");

            migrationBuilder.DropTable(
                name: "upload_usernames");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "wsm_callback_responses");

            migrationBuilder.DropTable(
                name: "wsm_callbacks");

            migrationBuilder.DropTable(
                name: "wsm_callbacks_raw");

            migrationBuilder.DropTable(
                name: "wsm_plans");

            migrationBuilder.DropTable(
                name: "wsm_service_ids");
        }
    }
}
