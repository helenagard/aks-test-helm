﻿// <auto-generated />
using System;
using ClaimsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClaimsApi.Migrations
{
    [DbContext(typeof(ClaimsContext))]
    partial class ClaimsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.ClaimNumbers", "'ClaimNumbers', '', '100', '1', '', '', 'Int32', 'False'")
                .HasAnnotation("Relational:Sequence:.PlanPayNumbers", "'PlanPayNumbers', '', '100', '1', '', '', 'Int32', 'False'")
                .HasAnnotation("Relational:Sequence:.ServiceLineNumbers", "'ServiceLineNumbers', '', '100', '1', '', '', 'Int32', 'False'")
                .HasAnnotation("Relational:Sequence:.SubNumbers", "'SubNumbers', '', '100', '1', '', '', 'Int32', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClaimsApi.Models.ClaimItem", b =>
                {
                    b.Property<int>("ClaimItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("claim_item_id")
                        .HasDefaultValueSql("NEXT VALUE FOR ClaimNumbers");

                    b.Property<string>("ClaimInputMethod")
                        .HasColumnName("claim_inp_method");

                    b.Property<string>("ClaimNumber")
                        .HasColumnName("claim_no");

                    b.Property<DateTime>("ClaimPaidDate")
                        .HasColumnName("claim_paid_date");

                    b.Property<string>("ClaimStatus")
                        .HasColumnName("claim_status");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type");

                    b.Property<string>("DestinationID")
                        .HasColumnName("destination_id");

                    b.Property<string>("OriginatorID")
                        .HasColumnName("originator_id");

                    b.Property<decimal>("PatientAmountDue")
                        .HasColumnName("patient_amt_due")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("PatientStatus")
                        .HasColumnName("patient_status");

                    b.Property<string>("PolicyNumber")
                        .HasColumnName("policy_no");

                    b.Property<string>("ReceiverID")
                        .HasColumnName("receiver_id");

                    b.Property<string>("SenderID")
                        .HasColumnName("sender_id");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnName("service_date");

                    b.Property<decimal>("TotalClaimCharge")
                        .HasColumnName("total_claim_charge")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ClaimItemId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("ClaimsApi.Models.PlanPayment", b =>
                {
                    b.Property<int>("PlanPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("plan_payment_id")
                        .HasDefaultValueSql("NEXT VALUE FOR PlanPayNumbers");

                    b.Property<decimal>("ClaimAdjAmount")
                        .HasColumnName("claim_adj_amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ClaimAdjGroupCode")
                        .HasColumnName("claim_adj_grp_code");

                    b.Property<string>("ClaimAdjQuantity")
                        .HasColumnName("claim_adj_qty");

                    b.Property<string>("ClaimAdjReasonCode")
                        .HasColumnName("claim_adj_reason_code");

                    b.Property<int>("ClaimItemId")
                        .HasColumnName("claim_id");

                    b.Property<decimal>("CobServicePaidAmount")
                        .HasColumnName("cob_service_paid_amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnName("payment_date");

                    b.Property<string>("PrimaryPayerID")
                        .HasColumnName("primary_payer_id");

                    b.Property<string>("ServiceCode")
                        .HasColumnName("service_code");

                    b.HasKey("PlanPaymentId");

                    b.HasIndex("ClaimItemId");

                    b.ToTable("Plan_Payment");
                });

            modelBuilder.Entity("ClaimsApi.Models.ServiceLineDetails", b =>
                {
                    b.Property<int>("ServiceLineDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("service_line_id")
                        .HasDefaultValueSql("NEXT VALUE FOR ServiceLineNumbers");

                    b.Property<int>("ClaimItemId")
                        .HasColumnName("claim_id");

                    b.Property<string>("DrugCode")
                        .HasColumnName("drug_code");

                    b.Property<int>("DrugUnitQuantity")
                        .HasColumnName("drug_unit_qty");

                    b.Property<bool>("InNetworkIndicator")
                        .HasColumnName("in_network_id");

                    b.Property<decimal>("LineChargeAmount")
                        .HasColumnName("line_charge_amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("LineCounter")
                        .HasColumnName("line_counter");

                    b.Property<string>("PharmacyPrescriptionNumber")
                        .HasColumnName("pharmacy_pres_no");

                    b.Property<string>("ProviderCode")
                        .HasColumnName("provider_code");

                    b.Property<string>("ProviderFirstName")
                        .HasColumnName("provider_first_name");

                    b.Property<string>("ProviderIdentification")
                        .HasColumnName("provider_id");

                    b.Property<string>("ProviderLastName")
                        .HasColumnName("provider_last_name");

                    b.Property<string>("ServiceCodeDescription")
                        .HasColumnName("service_code_desc");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnName("service_type");

                    b.Property<DateTime>("StatementDate")
                        .HasColumnName("statement_date");

                    b.HasKey("ServiceLineDetailsId");

                    b.HasIndex("ClaimItemId");

                    b.ToTable("Svc_Line_Details");
                });

            modelBuilder.Entity("ClaimsApi.Models.SubscriberInfo", b =>
                {
                    b.Property<int>("SubscriberInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("subscriber_id")
                        .HasDefaultValueSql("NEXT VALUE FOR SubNumbers");

                    b.Property<string>("CatgOfService")
                        .HasColumnName("category_of_service");

                    b.Property<int>("ClaimItemId")
                        .HasColumnName("claim_id");

                    b.Property<string>("InsuredGroupName")
                        .HasColumnName("insured_group_name");

                    b.Property<string>("PatientDOB")
                        .HasColumnName("patient_dob");

                    b.Property<string>("PatientFirstName")
                        .HasColumnName("patient_first_name");

                    b.Property<string>("PatientGender")
                        .HasColumnName("patient_gender");

                    b.Property<string>("PatientLastName")
                        .HasColumnName("patient_last_name");

                    b.Property<string>("PatientMemberID")
                        .HasColumnName("patient_member_id");

                    b.Property<string>("PatientSSN")
                        .HasColumnName("patient_ssn");

                    b.Property<string>("PayerName")
                        .IsRequired()
                        .HasColumnName("payer_name");

                    b.Property<string>("SubDateOfBirth")
                        .HasColumnName("subscriber_dob");

                    b.Property<string>("SubscriberAddressLine1")
                        .HasColumnName("subscriber_addr_1");

                    b.Property<string>("SubscriberAddressLine2")
                        .HasColumnName("subscriber_address_2");

                    b.Property<string>("SubscriberCity")
                        .HasColumnName("subscriber_city");

                    b.Property<string>("SubscriberCountry")
                        .HasColumnName("subscriber_country");

                    b.Property<string>("SubscriberFirstName")
                        .IsRequired()
                        .HasColumnName("subscriber_first_name");

                    b.Property<string>("SubscriberGender")
                        .HasColumnName("subscriber_gender");

                    b.Property<string>("SubscriberIdentifierSSN")
                        .IsRequired()
                        .HasColumnName("subscriber_id_ssn");

                    b.Property<string>("SubscriberLastName")
                        .IsRequired()
                        .HasColumnName("subscriber_last_name");

                    b.Property<string>("SubscriberMiddleName")
                        .HasColumnName("subscriber_middle_name");

                    b.Property<string>("SubscriberPolicyNumber")
                        .HasColumnName("subscriber_policy_no");

                    b.Property<string>("SubscriberPostalCode")
                        .HasColumnName("subscriber_postal_code");

                    b.Property<string>("SubscriberRelationship")
                        .HasColumnName("subscriber_reln");

                    b.Property<string>("SubscriberState")
                        .HasColumnName("subscriber_state");

                    b.HasKey("SubscriberInfoId");

                    b.HasIndex("ClaimItemId");

                    b.ToTable("Subscriber_Info");
                });

            modelBuilder.Entity("ClaimsApi.Models.PlanPayment", b =>
                {
                    b.HasOne("ClaimsApi.Models.ClaimItem")
                        .WithMany("PlanPayment")
                        .HasForeignKey("ClaimItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClaimsApi.Models.ServiceLineDetails", b =>
                {
                    b.HasOne("ClaimsApi.Models.ClaimItem")
                        .WithMany("ServiceLineDetails")
                        .HasForeignKey("ClaimItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClaimsApi.Models.SubscriberInfo", b =>
                {
                    b.HasOne("ClaimsApi.Models.ClaimItem")
                        .WithMany("SubscriberInfo")
                        .HasForeignKey("ClaimItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
