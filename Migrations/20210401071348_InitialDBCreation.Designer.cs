// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiGresol;

namespace WebApiGresol.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210401071348_InitialDBCreation")]
    partial class InitialDBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiGresol.Model.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("Categories")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("ExpenseID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("WebApiGresol.Model.ExpenseCategories", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("UID");

                    b.ToTable("ExpenseCategories");
                });

            modelBuilder.Entity("WebApiGresol.Model.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CreditDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBadDedbt")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<int>("ThirdPartyID")
                        .HasColumnType("int");

                    b.HasKey("InvoiceID");

                    b.HasIndex("ThirdPartyID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("WebApiGresol.Model.ThirdParty", b =>
                {
                    b.Property<int>("ThirdPartyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssociateUser")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBuyer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGovernment")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOther")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProspect")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSupplier")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("ThirdPartyID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("ThirdParty");
                });

            modelBuilder.Entity("WebApiGresol.Model.Todo", b =>
                {
                    b.Property<int>("TodoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignBy")
                        .HasColumnType("int");

                    b.Property<int>("AssignTo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimateDays")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("TodoID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("WebApiGresol.Model.TravelExpense", b =>
                {
                    b.Property<int>("TravelExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssociateUser")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CloseDistance")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FoodAllowance")
                        .HasColumnType("float");

                    b.Property<bool>("IsApprove")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JourneyDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OpenDistance")
                        .HasColumnType("float");

                    b.Property<double>("PetrolAllowance")
                        .HasColumnType("float");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("TravelExpenseID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("TravelExpenses");
                });

            modelBuilder.Entity("WebApiGresol.Model.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetrolAllowance")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelAllowance")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApiGresol.Model.Visit", b =>
                {
                    b.Property<int>("VisitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThirdPartyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitID");

                    b.HasIndex("ThirdPartyId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("WebApiGresol.Model.Expense", b =>
                {
                    b.HasOne("WebApiGresol.Model.Users", "Users")
                        .WithMany("Expenses")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApiGresol.Model.Invoice", b =>
                {
                    b.HasOne("WebApiGresol.Model.ThirdParty", "ThirdParty")
                        .WithMany("Invoices")
                        .HasForeignKey("ThirdPartyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThirdParty");
                });

            modelBuilder.Entity("WebApiGresol.Model.ThirdParty", b =>
                {
                    b.HasOne("WebApiGresol.Model.Users", "Users")
                        .WithMany("ThirdParty")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApiGresol.Model.Todo", b =>
                {
                    b.HasOne("WebApiGresol.Model.Users", "Users")
                        .WithMany("Todos")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApiGresol.Model.TravelExpense", b =>
                {
                    b.HasOne("WebApiGresol.Model.Users", "Users")
                        .WithMany("TravelExpenses")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApiGresol.Model.Visit", b =>
                {
                    b.HasOne("WebApiGresol.Model.ThirdParty", "ThirdParty")
                        .WithMany("Visits")
                        .HasForeignKey("ThirdPartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThirdParty");
                });

            modelBuilder.Entity("WebApiGresol.Model.ThirdParty", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("WebApiGresol.Model.Users", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("ThirdParty");

                    b.Navigation("Todos");

                    b.Navigation("TravelExpenses");
                });
#pragma warning restore 612, 618
        }
    }
}
