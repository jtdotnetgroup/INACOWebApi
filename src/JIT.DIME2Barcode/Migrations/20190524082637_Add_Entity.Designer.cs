﻿// <auto-generated />
using System;
using JIT.DIME2Barcode.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JIT.DIME2Barcode.Migrations
{
    [DbContext(typeof(ProductionPlanMySqlDbContext))]
    [Migration("20190524082637_Add_Entity")]
    partial class Add_Entity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.BillStatus", b =>
                {
                    b.Property<int>("FTranType")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FName");

                    b.Property<string>("FNote");

                    b.Property<int>("FStatus");

                    b.Property<string>("FTranName");

                    b.HasKey("FTranType");

                    b.ToTable("BillStatus");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FDepartment");

                    b.Property<int?>("FERPOfficeClerk");

                    b.Property<int?>("FERPUser");

                    b.Property<string>("FEmailAddress");

                    b.Property<DateTime?>("FHiredate");

                    b.Property<string>("FMpno")
                        .HasMaxLength(100);

                    b.Property<string>("FName")
                        .HasMaxLength(10);

                    b.Property<int>("FOrganizationUnitId");

                    b.Property<int?>("FParentId");

                    b.Property<string>("FPhone");

                    b.Property<int?>("FSex");

                    b.Property<int?>("FSystemUser");

                    b.Property<int>("FTenantId");

                    b.Property<long>("FUserId");

                    b.Property<int?>("FWorkingState");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.Equipment", b =>
                {
                    b.Property<int>("FInterID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<TimeSpan?>("FDayWorkHours");

                    b.Property<TimeSpan?>("FMaxWorkHours");

                    b.Property<string>("FName");

                    b.Property<string>("FNumber");

                    b.Property<int>("FStatus");

                    b.Property<int>("FType");

                    b.Property<int?>("FWorkCenterID");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Note");

                    b.HasKey("FInterID");

                    b.HasIndex("FNumber")
                        .IsUnique();

                    b.ToTable("t_equipment");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICBOM", b =>
                {
                    b.Property<int>("FInterID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("FAUXQTY");

                    b.Property<int>("FAccessories");

                    b.Property<DateTime?>("FAudDate");

                    b.Property<int>("FAuxPropID");

                    b.Property<string>("FBOMNumber");

                    b.Property<short>("FBOMSkip");

                    b.Property<bool?>("FBeenChecked");

                    b.Property<int>("FBomType");

                    b.Property<string>("FBrNo");

                    b.Property<bool?>("FCancellation");

                    b.Property<DateTime?>("FCheckDate");

                    b.Property<int?>("FCheckID");

                    b.Property<int?>("FCheckerID");

                    b.Property<int?>("FClassTypeID");

                    b.Property<int>("FCustID");

                    b.Property<int>("FCustItemID");

                    b.Property<int>("FEcnInterID");

                    b.Property<DateTime?>("FEnterTime");

                    b.Property<short>("FForbid");

                    b.Property<short>("FImpMode");

                    b.Property<int>("FItemID");

                    b.Property<string>("FNote");

                    b.Property<int?>("FOperatorID");

                    b.Property<DateTime?>("FPDMImportDate");

                    b.Property<int?>("FParentID");

                    b.Property<decimal>("FQty");

                    b.Property<int>("FRoutingID");

                    b.Property<short>("FStatus");

                    b.Property<int>("FTranType");

                    b.Property<int>("FUnitID");

                    b.Property<DateTime?>("FUseDate");

                    b.Property<int?>("FUseStatus");

                    b.Property<int?>("FUserID");

                    b.Property<string>("FVersion");

                    b.Property<decimal?>("FYield");

                    b.HasKey("FInterID");

                    b.ToTable("ICBOM");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICException", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FBiller");

                    b.Property<string>("FNote");

                    b.Property<DateTime?>("FRecoverTime");

                    b.Property<string>("FRemark");

                    b.Property<string>("FSrcID");

                    b.Property<DateTime?>("FTime");

                    b.HasKey("FID");

                    b.ToTable("ICException");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMO", b =>
                {
                    b.Property<int>("FInterID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("FAuxCheckCommitQty");

                    b.Property<decimal>("FAuxCommitQty");

                    b.Property<decimal>("FAuxInHighLimitQty");

                    b.Property<decimal>("FAuxInLowLimitQty");

                    b.Property<decimal>("FAuxQty");

                    b.Property<decimal>("FAuxQtyBack");

                    b.Property<decimal>("FAuxQtyFinish");

                    b.Property<decimal?>("FAuxQtyForItem");

                    b.Property<decimal>("FAuxQtyLost");

                    b.Property<decimal>("FAuxQtyPass");

                    b.Property<decimal>("FAuxQtyScrap");

                    b.Property<decimal>("FAuxStockQty");

                    b.Property<string>("FBillNo");

                    b.Property<int?>("FBillerID");

                    b.Property<int>("FBomInterID");

                    b.Property<string>("FBrNo");

                    b.Property<bool?>("FCancellation");

                    b.Property<int>("FCardClosed");

                    b.Property<int>("FChangeTimes");

                    b.Property<decimal>("FCheckCommitQty");

                    b.Property<DateTime?>("FCheckDate");

                    b.Property<int?>("FCheckerID");

                    b.Property<DateTime?>("FCloseDate");

                    b.Property<short>("FClosed");

                    b.Property<DateTime?>("FCommitDate");

                    b.Property<decimal>("FCommitQty");

                    b.Property<DateTime?>("FConfirmDate");

                    b.Property<int?>("FConfirmerID");

                    b.Property<int?>("FConveyerID");

                    b.Property<int>("FCostObjID");

                    b.Property<int?>("FCurCheckLevel");

                    b.Property<int>("FCustID");

                    b.Property<int>("FFinClosed");

                    b.Property<DateTime?>("FFinClosedate");

                    b.Property<int?>("FFinCloseer");

                    b.Property<DateTime?>("FFinishDate");

                    b.Property<decimal>("FFinishTime");

                    b.Property<decimal>("FFixTime");

                    b.Property<string>("FGMPBatchNo");

                    b.Property<decimal>("FGMPBulkQty");

                    b.Property<decimal>("FGMPCollectRate");

                    b.Property<decimal>("FGMPItemBalance");

                    b.Property<decimal>("FHRReadyTime");

                    b.Property<int>("FHandworkClose");

                    b.Property<decimal>("FInHighLimit");

                    b.Property<decimal>("FInHighLimitQty");

                    b.Property<decimal>("FInLowLimit");

                    b.Property<decimal>("FInLowLimitQty");

                    b.Property<int>("FItemID");

                    b.Property<short>("FMRP");

                    b.Property<int>("FMRPLockFlag");

                    b.Property<string>("FMTONo");

                    b.Property<int>("FMrpClosed");

                    b.Property<DateTime?>("FMultiCheckDate1");

                    b.Property<DateTime?>("FMultiCheckDate2");

                    b.Property<DateTime?>("FMultiCheckDate3");

                    b.Property<DateTime?>("FMultiCheckDate4");

                    b.Property<DateTime?>("FMultiCheckDate5");

                    b.Property<DateTime?>("FMultiCheckDate6");

                    b.Property<int?>("FMultiCheckLevel1");

                    b.Property<int?>("FMultiCheckLevel2");

                    b.Property<int?>("FMultiCheckLevel3");

                    b.Property<int?>("FMultiCheckLevel4");

                    b.Property<int?>("FMultiCheckLevel5");

                    b.Property<int?>("FMultiCheckLevel6");

                    b.Property<string>("FNote");

                    b.Property<int?>("FOrderInterID");

                    b.Property<int?>("FPPOrderInterID");

                    b.Property<int?>("FParentInterID");

                    b.Property<DateTime?>("FPlanCommitDate");

                    b.Property<int>("FPlanConfirmed");

                    b.Property<DateTime?>("FPlanFinishDate");

                    b.Property<DateTime?>("FPlanIssueDate");

                    b.Property<int>("FPlanMode");

                    b.Property<int>("FPlanOrderInterID");

                    b.Property<decimal>("FPowerCutTime");

                    b.Property<int>("FPrintCount");

                    b.Property<decimal>("FProcessFee");

                    b.Property<decimal>("FProcessPrice");

                    b.Property<int?>("FProductionLineID");

                    b.Property<int?>("FProjectNO");

                    b.Property<decimal>("FQty");

                    b.Property<decimal>("FQtyBack");

                    b.Property<decimal>("FQtyFinish");

                    b.Property<decimal?>("FQtyForItem");

                    b.Property<decimal>("FQtyLost");

                    b.Property<decimal>("FQtyPass");

                    b.Property<decimal>("FQtyScrap");

                    b.Property<decimal>("FReadyTIme");

                    b.Property<decimal>("FReleasedAuxQty");

                    b.Property<decimal>("FReleasedQty");

                    b.Property<int?>("FRequesterID");

                    b.Property<int?>("FRoutingID");

                    b.Property<int>("FScheduleID");

                    b.Property<short>("FSourceEntryID");

                    b.Property<DateTime?>("FStartDate");

                    b.Property<int>("FStartFlag");

                    b.Property<short>("FStatus");

                    b.Property<int>("FStockFlag");

                    b.Property<decimal>("FStockQty");

                    b.Property<int>("FSubEntryID");

                    b.Property<int?>("FSupplyID");

                    b.Property<bool?>("FSuspend");

                    b.Property<int>("FTaskID");

                    b.Property<short>("FTranType");

                    b.Property<short?>("FType");

                    b.Property<decimal>("FUnScheduledAuxQty");

                    b.Property<decimal>("FUnScheduledQty");

                    b.Property<int>("FUnitID");

                    b.Property<string>("FVchBillNo");

                    b.Property<int>("FVchInterID");

                    b.Property<decimal>("FWaitItemTime");

                    b.Property<decimal>("FWaitToolTime");

                    b.Property<int?>("FWorkShop");

                    b.Property<int>("FWorkTypeID");

                    b.HasKey("FInterID");

                    b.ToTable("ICMO");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMODaily", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FBillNo");

                    b.Property<DateTime?>("FBillTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FBiller");

                    b.Property<DateTime?>("FCheckTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FChecker");

                    b.Property<DateTime?>("FCloseTime")
                        .HasColumnType("datetime");

                    b.Property<bool?>("FClosed");

                    b.Property<string>("FCloser");

                    b.Property<decimal?>("FCommitAuxQty");

                    b.Property<DateTime>("FDate")
                        .HasColumnType("datetime");

                    b.Property<int>("FEntryID");

                    b.Property<decimal?>("FFailAuxQty");

                    b.Property<decimal?>("FFinishAuxQty");

                    b.Property<string>("FMOBillNo");

                    b.Property<int?>("FMOInterID");

                    b.Property<int?>("FMachineID");

                    b.Property<string>("FNote");

                    b.Property<int?>("FOperID");

                    b.Property<string>("FOperNote");

                    b.Property<decimal?>("FPassAuxQty");

                    b.Property<decimal?>("FPlanAuxQty");

                    b.Property<int?>("FShift");

                    b.Property<string>("FSrcID");

                    b.Property<int>("FStatus");

                    b.Property<int?>("FTranType");

                    b.Property<int?>("FWorkCenterID");

                    b.Property<string>("FWorkCenterName");

                    b.Property<string>("FWorker");

                    b.HasKey("FID");

                    b.HasIndex("FSrcID");

                    b.ToTable("ICMODaily");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMODispBill", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FBillNo");

                    b.Property<DateTime?>("FBillTime");

                    b.Property<string>("FBiller");

                    b.Property<DateTime?>("FCheckTime");

                    b.Property<string>("FChecker");

                    b.Property<DateTime?>("FCloseTime");

                    b.Property<bool?>("FClosed");

                    b.Property<string>("FCloser");

                    b.Property<decimal?>("FCommitAuxQty");

                    b.Property<DateTime?>("FDate");

                    b.Property<decimal?>("FFInspectAuxQty");

                    b.Property<decimal?>("FFailAuxQty");

                    b.Property<decimal?>("FFinishAuxQty");

                    b.Property<string>("FMOBillNo");

                    b.Property<int?>("FMOInterID");

                    b.Property<int?>("FMachineID");

                    b.Property<string>("FNote");

                    b.Property<int?>("FOperID");

                    b.Property<decimal?>("FPassAuxQty");

                    b.Property<decimal?>("FPlanAuxQty");

                    b.Property<int>("FPrintCount");

                    b.Property<int?>("FShift");

                    b.Property<string>("FSrcID");

                    b.Property<int>("FStatus");

                    b.Property<int>("FTranType");

                    b.Property<int?>("FWorkCenterID");

                    b.Property<string>("FWorker");

                    b.HasKey("FID");

                    b.ToTable("ICMODispBill");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMOInspectBill", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("FAuxQty");

                    b.Property<string>("FBillNo");

                    b.Property<DateTime?>("FBillTime");

                    b.Property<string>("FBiller");

                    b.Property<decimal?>("FCheckAuxQty");

                    b.Property<DateTime?>("FCheckTime");

                    b.Property<string>("FChecker");

                    b.Property<decimal?>("FFailAuxQty");

                    b.Property<decimal?>("FFailAuxQtyM");

                    b.Property<decimal?>("FFailAuxQtyP");

                    b.Property<DateTime?>("FInspectTime");

                    b.Property<string>("FInspector");

                    b.Property<int?>("FMOInterID");

                    b.Property<int?>("FMachineID");

                    b.Property<string>("FNote");

                    b.Property<int?>("FOperID");

                    b.Property<decimal?>("FPassAuxQty");

                    b.Property<decimal?>("FPassAuxQtyM");

                    b.Property<decimal?>("FPassAuxQtyP");

                    b.Property<int>("FStatus");

                    b.Property<int>("FTranType");

                    b.Property<int?>("FWorkcenterID");

                    b.Property<string>("FWorker");

                    b.HasKey("FID");

                    b.ToTable("ICMOInspectBill");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMOSchedule", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FBillNo");

                    b.Property<DateTime?>("FBillTime");

                    b.Property<string>("FBiller");

                    b.Property<bool?>("FCancellation");

                    b.Property<DateTime?>("FCheckTime");

                    b.Property<string>("FChecker");

                    b.Property<DateTime?>("FCloseTime");

                    b.Property<bool?>("FClosed");

                    b.Property<string>("FCloser");

                    b.Property<decimal?>("FFailAuxQty");

                    b.Property<decimal?>("FFinishAuxQty");

                    b.Property<DateTime?>("FFinishDate");

                    b.Property<string>("FItemID");

                    b.Property<string>("FItemModel");

                    b.Property<string>("FItemName");

                    b.Property<string>("FMOBillNo");

                    b.Property<int>("FMOInterID");

                    b.Property<string>("FNote");

                    b.Property<decimal?>("FPassAuxQty");

                    b.Property<decimal?>("FPlanAuxQty");

                    b.Property<DateTime?>("FPlanBeginDate");

                    b.Property<DateTime?>("FPlanFinishDate");

                    b.Property<decimal?>("FSrcAuxQty");

                    b.Property<int>("FStatus");

                    b.Property<int>("FTranType");

                    b.HasKey("FID");

                    b.ToTable("ICMOSchedule");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMaterialPicking", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("FAuxQty");

                    b.Property<string>("FBatchNo");

                    b.Property<string>("FBiller");

                    b.Property<DateTime?>("FDate");

                    b.Property<int>("FEntryID");

                    b.Property<int?>("FItemID");

                    b.Property<string>("FNote");

                    b.Property<string>("FSrcID");

                    b.Property<int?>("FUnitID");

                    b.HasKey("FID");

                    b.ToTable("ICMaterialPicking");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICQualityRpt", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("FAuxQty");

                    b.Property<int>("FItemID");

                    b.Property<string>("FNote");

                    b.Property<string>("FRemark");

                    b.HasKey("FID");

                    b.ToTable("ICQualityRpt");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.OrganizationUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("DataBaseConnection");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ERPOrganization");

                    b.Property<int?>("ERPOrganizationLeader");

                    b.Property<bool?>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int?>("LastModifierUserId");

                    b.Property<int?>("OrganizationType");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Remark");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("T_OrganizationUnit");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.SEOrder", b =>
                {
                    b.Property<int>("FInterID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FAreaPS");

                    b.Property<short>("FBClosed");

                    b.Property<string>("FBillNo");

                    b.Property<int?>("FBillerID");

                    b.Property<int?>("FBrID");

                    b.Property<string>("FBrNo");

                    b.Property<bool?>("FCancellation");

                    b.Property<string>("FCashDiscount");

                    b.Property<string>("FChangeCauses");

                    b.Property<DateTime?>("FChangeDate");

                    b.Property<int>("FChangeMark");

                    b.Property<int>("FChangeUser");

                    b.Property<DateTime?>("FCheckDate");

                    b.Property<int?>("FCheckerID");

                    b.Property<int>("FChildren");

                    b.Property<int>("FClassTypeID");

                    b.Property<short>("FClosed");

                    b.Property<string>("FConsignee");

                    b.Property<int?>("FCurCheckLevel");

                    b.Property<int?>("FCurrencyID");

                    b.Property<int?>("FCustID");

                    b.Property<DateTime?>("FDate");

                    b.Property<int?>("FDeptID");

                    b.Property<bool?>("FDiscountType");

                    b.Property<int>("FDrpRelateTranType");

                    b.Property<int?>("FEmpID");

                    b.Property<double?>("FExchangeRate");

                    b.Property<int>("FExchangeRateType");

                    b.Property<string>("FExplanation");

                    b.Property<string>("FFetchAdd");

                    b.Property<DateTime?>("FFetchDate");

                    b.Property<string>("FFetchStyle");

                    b.Property<int?>("FHeadSelfS0150");

                    b.Property<int?>("FHeadSelfS0151");

                    b.Property<DateTime?>("FHeadSelfS0153");

                    b.Property<int?>("FHeadSelfS0154");

                    b.Property<int>("FImport");

                    b.Property<short?>("FInvoiceClosed");

                    b.Property<int?>("FManageType");

                    b.Property<int?>("FMangerID");

                    b.Property<DateTime?>("FMultiCheckDate1");

                    b.Property<DateTime?>("FMultiCheckDate2");

                    b.Property<DateTime?>("FMultiCheckDate3");

                    b.Property<DateTime?>("FMultiCheckDate4");

                    b.Property<DateTime?>("FMultiCheckDate5");

                    b.Property<DateTime?>("FMultiCheckDate6");

                    b.Property<int?>("FMultiCheckLevel1");

                    b.Property<int?>("FMultiCheckLevel2");

                    b.Property<int?>("FMultiCheckLevel3");

                    b.Property<int?>("FMultiCheckLevel4");

                    b.Property<int?>("FMultiCheckLevel5");

                    b.Property<int?>("FMultiCheckLevel6");

                    b.Property<string>("FNote");

                    b.Property<byte[]>("FOperDate");

                    b.Property<int?>("FOrderAffirm");

                    b.Property<string>("FPOOrdBillNo");

                    b.Property<DateTime?>("FPayDate");

                    b.Property<string>("FPayStyle");

                    b.Property<short>("FPrintCount");

                    b.Property<int?>("FRelateBrID");

                    b.Property<int?>("FSaleStyle");

                    b.Property<int>("FSelTranType");

                    b.Property<DateTime?>("FSettleDate");

                    b.Property<int?>("FSettleID");

                    b.Property<short>("FStatus");

                    b.Property<short>("FSysStatus");

                    b.Property<int>("FSystemType");

                    b.Property<int?>("FTranStatus");

                    b.Property<int>("FTranType");

                    b.Property<float?>("FTransitAheadTime");

                    b.Property<Guid>("FUUID");

                    b.Property<string>("FValidaterName");

                    b.Property<string>("FVersionNo");

                    b.HasKey("FInterID");

                    b.ToTable("SEOrder");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.TB_BadItemRelation", b =>
                {
                    b.Property<int>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("FDeleted");

                    b.Property<int?>("FItemID");

                    b.Property<string>("FName");

                    b.Property<string>("FNumber");

                    b.Property<int>("FOperID");

                    b.Property<string>("FRemark");

                    b.HasKey("FID");

                    b.ToTable("TB_BadItemRelation");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.T_PrintTemplate", b =>
                {
                    b.Property<string>("FInterID")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("FFile");

                    b.Property<string>("FFileDir");

                    b.Property<int>("FItemID");

                    b.Property<string>("FNote");

                    b.Property<int>("FTranType");

                    b.Property<string>("FType");

                    b.Property<int?>("FUserID");

                    b.HasKey("FInterID");

                    b.ToTable("T_PrintTemplate");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.VW_ICMODaily", b =>
                {
                    b.Property<string>("计划单号")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FID");

                    b.Property<string>("产品名称");

                    b.Property<string>("产品编码");

                    b.Property<string>("任务单号");

                    b.Property<decimal?>("完成数量");

                    b.Property<DateTime?>("日期");

                    b.Property<string>("规格型号");

                    b.Property<DateTime?>("计划完工日期");

                    b.Property<DateTime?>("计划开工日期");

                    b.Property<decimal?>("计划数量");

                    b.Property<int>("车间");

                    b.HasKey("计划单号");

                    b.ToTable("VW_ICMODaily");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.t_Department", b =>
                {
                    b.Property<int>("FItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FAcctID");

                    b.Property<string>("FBrNO");

                    b.Property<int>("FCalID");

                    b.Property<int>("FCostAccountType");

                    b.Property<int>("FDProperty");

                    b.Property<int?>("FDStock");

                    b.Property<short>("FDeleted");

                    b.Property<string>("FFax");

                    b.Property<bool?>("FIsCreditMgr");

                    b.Property<int?>("FManager");

                    b.Property<byte[]>("FModifyTime");

                    b.Property<string>("FName");

                    b.Property<string>("FNote");

                    b.Property<string>("FNumber");

                    b.Property<int>("FOtherAPAcctID");

                    b.Property<int>("FOtherARAcctID");

                    b.Property<int?>("FParentID");

                    b.Property<string>("FPhone");

                    b.Property<int?>("FPlanArea");

                    b.Property<int>("FPreAPAcctID");

                    b.Property<int>("FPreARAcctID");

                    b.Property<string>("FShortNumber");

                    b.HasKey("FItemID");

                    b.ToTable("t_Department");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.t_MeasureUnit", b =>
                {
                    b.Property<int>("FMeasureUnitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FAuxClass");

                    b.Property<string>("FBrNo");

                    b.Property<decimal>("FCoefficient");

                    b.Property<short>("FControl");

                    b.Property<int?>("FConversation");

                    b.Property<short>("FDeleted");

                    b.Property<int>("FItemID");

                    b.Property<byte[]>("FModifyTime");

                    b.Property<string>("FName");

                    b.Property<string>("FNameEN");

                    b.Property<string>("FNameEnPlu");

                    b.Property<string>("FNumber");

                    b.Property<string>("FOperDate");

                    b.Property<int?>("FParentID");

                    b.Property<int>("FPrecision");

                    b.Property<decimal>("FScale");

                    b.Property<string>("FShortNumber");

                    b.Property<short>("FStandard");

                    b.Property<int>("FSystemType");

                    b.Property<int>("FUnitGroupID");

                    b.Property<Guid>("UUID");

                    b.HasKey("FMeasureUnitID");

                    b.ToTable("t_MeasureUnit");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.TaskAssignment.ICMODispBill.Dtos.VW_MODispBillList", b =>
                {
                    b.Property<string>("FID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("FClosed");

                    b.Property<int?>("FItemID");

                    b.Property<int>("FStatus");

                    b.Property<int?>("FWorkCenterID");

                    b.Property<string>("FsrcID");

                    b.Property<decimal?>("不合格数量");

                    b.Property<string>("产品代码");

                    b.Property<string>("产品名称");

                    b.Property<decimal?>("合格数量");

                    b.Property<string>("工作中心");

                    b.Property<string>("工序");

                    b.Property<int>("打印次数");

                    b.Property<string>("操作者");

                    b.Property<decimal?>("汇报数量");

                    b.Property<string>("派工单号");

                    b.Property<decimal?>("派工数量");

                    b.Property<int?>("班次");

                    b.Property<string>("生产任务");

                    b.Property<DateTime>("生产日期");

                    b.Property<string>("规格型号");

                    b.Property<decimal?>("计划数量");

                    b.Property<string>("设备");

                    b.HasKey("FID");

                    b.ToTable("VW_MODispBillList");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.ICMODaily", b =>
                {
                    b.HasOne("JIT.DIME2Barcode.Entities.ICMOSchedule", "Schedule")
                        .WithMany("Dailies")
                        .HasForeignKey("FSrcID");
                });

            modelBuilder.Entity("JIT.DIME2Barcode.Entities.OrganizationUnit", b =>
                {
                    b.HasOne("JIT.DIME2Barcode.Entities.OrganizationUnit", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
