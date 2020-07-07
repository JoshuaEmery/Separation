using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Separation.Core.Models;

namespace Separation.Data
{
    public partial class RayHopeBackupContext : DbContext
    {
        public RayHopeBackupContext()
        {
        }

        public RayHopeBackupContext(DbContextOptions<RayHopeBackupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BarCodeNumbers> BarCodeNumbers { get; set; }
        public virtual DbSet<CalendarEvents> CalendarEvents { get; set; }
        public virtual DbSet<CitiesLastSlept> CitiesLastSlept { get; set; }
        public virtual DbSet<CitizenShips> CitizenShips { get; set; }
        public virtual DbSet<ClientNotes> ClientNotes { get; set; }
        public virtual DbSet<ClientSignIns> ClientSignIns { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Dependents> Dependents { get; set; }
        public virtual DbSet<DrugAlcoholEvaluation> DrugAlcoholEvaluation { get; set; }
        public virtual DbSet<EducationLevels> EducationLevels { get; set; }
        public virtual DbSet<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual DbSet<Ethnicity> Ethnicity { get; set; }
        public virtual DbSet<FollowUps> FollowUps { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<HasHousingList> HasHousingList { get; set; }
        public virtual DbSet<HygieneClients> HygieneClients { get; set; }
        public virtual DbSet<Hygienes> Hygienes { get; set; }
        public virtual DbSet<Identifications> Identifications { get; set; }
        public virtual DbSet<Incidents> Incidents { get; set; }
        public virtual DbSet<LaundryDays> LaundryDays { get; set; }
        public virtual DbSet<MaritalStatuses> MaritalStatuses { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ServiceIssues> ServiceIssues { get; set; }
        public virtual DbSet<ServiceProviders> ServiceProviders { get; set; }
        public virtual DbSet<ServiceSearches> ServiceSearches { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<SunDownSignIn> SunDownSignIn { get; set; }
        public virtual DbSet<SuspendTimes> SuspendTimes { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<VeteransStatus> VeteransStatus { get; set; }
        public virtual DbSet<YearsInAuburn> YearsInAuburn { get; set; }
        public virtual DbSet<YearsInWashington> YearsInWashington { get; set; }
        public virtual DbSet<YearsOfHomelessness> YearsOfHomelessness { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=RayHopeBackup;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => e.RoleUserId)
                    .HasName("PK_dbo.AspNetUserRole");

                entity.Property(e => e.RoleUserId).HasColumnName("RoleUser_ID");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<BarCodeNumbers>(entity =>
            {
                entity.HasKey(e => e.BarcodeId)
                    .HasName("barcodenumID_pk");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.BarCodeNumbers)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__BarCodeNu__Clien__71D1E811");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.BarCodeNumbers)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK__BarCodeNu__Repor__72C60C4A");
            });

            modelBuilder.Entity<CalendarEvents>(entity =>
            {
                entity.HasKey(e => e.CalendarEventId)
                    .HasName("calendarEventID_pk");

                entity.Property(e => e.CalendarEventId).HasColumnName("CalendarEventID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndMeal).HasColumnType("datetime");

                entity.Property(e => e.StartMeal)
                    .HasColumnName("startMeal")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.CalendarEvents)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__CalendarE__Vendo__73BA3083");
            });

            modelBuilder.Entity<CitiesLastSlept>(entity =>
            {
                entity.HasKey(e => e.CitySleptId)
                    .HasName("citiesLastSleptID_pk");

                entity.Property(e => e.CitySleptId).HasColumnName("CitySlept_ID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CitizenShips>(entity =>
            {
                entity.HasKey(e => e.CitizenshipId)
                    .HasName("citizenshipID_pk");

                entity.Property(e => e.CitizenshipId).HasColumnName("Citizenship_ID");

                entity.Property(e => e.Citizenship)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientNotes>(entity =>
            {
                entity.HasKey(e => e.ClientNoteId)
                    .HasName("clientNotesID_pk");

                entity.Property(e => e.ClientNoteId).HasColumnName("ClientNote_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientNotes)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__ClientNot__Clien__74AE54BC");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.ClientNotes)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__ClientNot__Staff__75A278F5");
            });

            modelBuilder.Entity<ClientSignIns>(entity =>
            {
                entity.HasKey(e => e.ClientSignInId)
                    .HasName("ClientSignInID_pk");

                entity.Property(e => e.ClientSignInId).HasColumnName("ClientSignIn_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.SignIn).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSignIns)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__ClientSig__Clien__06CD04F7");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("clientsID_pk");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CitizenshipId).HasColumnName("Citizenship_ID");

                entity.Property(e => e.CitySleptId).HasColumnName("CitySlept_ID");

                entity.Property(e => e.ClientFname)
                    .IsRequired()
                    .HasColumnName("ClientFName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLname)
                    .IsRequired()
                    .HasColumnName("ClientLName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DependentId).HasColumnName("Dependent_ID");

                entity.Property(e => e.DrugAlcoholEvaluationId).HasColumnName("DrugAlcoholEvaluation_ID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevel_ID");

                entity.Property(e => e.EthnicityId).HasColumnName("Ethnicity_ID");

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.HasHousingId).HasColumnName("HasHousing_ID");

                entity.Property(e => e.IdentificationId).HasColumnName("Identification_ID");

                entity.Property(e => e.ImagePhoto).IsUnicode(false);

                entity.Property(e => e.IntakeDate).HasColumnType("date");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatus_ID");

                entity.Property(e => e.Medical).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ServiceIssuesId).HasColumnName("ServiceIssues_ID");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProvider_ID");

                entity.Property(e => e.ServiceSearchId).HasColumnName("ServiceSearch_ID");

                entity.Property(e => e.SocialSecurity)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.VeteransStatusId).HasColumnName("VeteransStatus_ID");

                entity.Property(e => e.YearsInAuburnId).HasColumnName("YearsInAuburn_ID");

                entity.Property(e => e.YearsInWashingtonId).HasColumnName("YearsInWashington_ID");

                entity.Property(e => e.YearsOfHomelessnessId).HasColumnName("YearsOfHomelessness_ID");

                entity.HasOne(d => d.Citizenship)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CitizenshipId)
                    .HasConstraintName("FK__Clients__Citizen__76969D2E");

                entity.HasOne(d => d.CitySlept)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CitySleptId)
                    .HasConstraintName("FK__Clients__CitySle__778AC167");

                entity.HasOne(d => d.Dependent)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.DependentId)
                    .HasConstraintName("FK__Clients__Depende__787EE5A0");

                entity.HasOne(d => d.DrugAlcoholEvaluation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.DrugAlcoholEvaluationId)
                    .HasConstraintName("FK__Clients__DrugAlc__797309D9");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK__Clients__Educati__7A672E12");

                entity.HasOne(d => d.Ethnicity)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.EthnicityId)
                    .HasConstraintName("FK__Clients__Ethnici__7B5B524B");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__Clients__Gender___7C4F7684");

                entity.HasOne(d => d.HasHousing)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.HasHousingId)
                    .HasConstraintName("FK__Clients__HasHous__7D439ABD");

                entity.HasOne(d => d.Identification)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdentificationId)
                    .HasConstraintName("FK__Clients__Identif__7E37BEF6");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK__Clients__Marital__7F2BE32F");

                entity.HasOne(d => d.ServiceIssues)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ServiceIssuesId)
                    .HasConstraintName("FK__Clients__Service__01142BA1");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK__Clients__Service__00200768");

                entity.HasOne(d => d.ServiceSearch)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ServiceSearchId)
                    .HasConstraintName("FK__Clients__Service__02084FDA");

                entity.HasOne(d => d.VeteransStatus)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.VeteransStatusId)
                    .HasConstraintName("FK__Clients__Veteran__02FC7413");

                entity.HasOne(d => d.YearsInAuburn)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.YearsInAuburnId)
                    .HasConstraintName("FK__Clients__YearsIn__03F0984C");

                entity.HasOne(d => d.YearsInWashington)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.YearsInWashingtonId)
                    .HasConstraintName("FK__Clients__YearsIn__04E4BC85");

                entity.HasOne(d => d.YearsOfHomelessness)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.YearsOfHomelessnessId)
                    .HasConstraintName("FK__Clients__YearsOf__05D8E0BE");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__Departme__151675F102FF20D3");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dependents>(entity =>
            {
                entity.HasKey(e => e.DependentId)
                    .HasName("DependentID_pk");

                entity.Property(e => e.DependentId).HasColumnName("Dependent_ID");

                entity.Property(e => e.DependentStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugAlcoholEvaluation>(entity =>
            {
                entity.Property(e => e.DrugAlcoholEvaluationId).HasColumnName("DrugAlcoholEvaluation_ID");

                entity.Property(e => e.EvalutionCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationLevels>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId)
                    .HasName("EducationLevelID_pk");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevel_ID");

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmergencyContacts>(entity =>
            {
                entity.HasKey(e => e.EmergencyContactId)
                    .HasName("contactsID_pk");

                entity.Property(e => e.EmergencyContactId).HasColumnName("EmergencyContact_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.EmergencyContactFname)
                    .HasColumnName("EmergencyContactFName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactLname)
                    .HasColumnName("EmergencyContactLName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Emergency__Clien__07C12930");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.Property(e => e.EthnicityId).HasColumnName("Ethnicity_ID");

                entity.Property(e => e.Ethnicity1)
                    .HasColumnName("Ethnicity")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FollowUps>(entity =>
            {
                entity.HasKey(e => e.FollowUpId)
                    .HasName("followUpsID_pk");

                entity.Property(e => e.FollowUpId).HasColumnName("FollowUpID");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.FollowUpSummary).IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.FollowUps)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK__FollowUps__Repor__08B54D69");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.FollowUps)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__FollowUps__Staff__09A971A2");
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("gendersID_pk");

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HasHousingList>(entity =>
            {
                entity.HasKey(e => e.HasHousingId)
                    .HasName("hashousinglistID_pk");

                entity.Property(e => e.HasHousingId).HasColumnName("HasHousing_ID");

                entity.Property(e => e.HasHousing)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HygieneClients>(entity =>
            {
                entity.HasKey(e => e.HygieneClientId)
                    .HasName("hygieneClientsID_pk");

                entity.Property(e => e.HygieneClientId).HasColumnName("HygieneClient_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.HygieneDate).HasColumnType("date");

                entity.Property(e => e.HygieneId).HasColumnName("Hygiene_ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.HygieneClients)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__HygieneCl__Clien__0A9D95DB");

                entity.HasOne(d => d.Hygiene)
                    .WithMany(p => p.HygieneClients)
                    .HasForeignKey(d => d.HygieneId)
                    .HasConstraintName("FK__HygieneCl__Hygie__0B91BA14");
            });

            modelBuilder.Entity<Hygienes>(entity =>
            {
                entity.HasKey(e => e.HygieneId)
                    .HasName("hygienesID_pk");

                entity.Property(e => e.HygieneId).HasColumnName("Hygiene_ID");

                entity.Property(e => e.Item)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Identifications>(entity =>
            {
                entity.HasKey(e => e.IdentificationId)
                    .HasName("IdentificationID_pk");

                entity.Property(e => e.IdentificationId).HasColumnName("Identification_ID");

                entity.Property(e => e.Identification)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Incidents>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("incidentsID_pk");

                entity.Property(e => e.IncidentId).HasColumnName("Incident_ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaundryDays>(entity =>
            {
                entity.HasKey(e => e.LaundryId)
                    .HasName("laundryID_pk");

                entity.Property(e => e.LaundryId).HasColumnName("Laundry_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.LaundryDate)
                    .HasColumnName("Laundry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NextLaundryDate).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LaundryDays)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__LaundryDa__Clien__0C85DE4D");
            });

            modelBuilder.Entity<MaritalStatuses>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId)
                    .HasName("maritalStatusID_pk");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatus_ID");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("reportsID_pk");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.FollowUpSummary).IsUnicode(false);

                entity.Property(e => e.IncidentDate).HasColumnType("date");

                entity.Property(e => e.IncidentId).HasColumnName("Incident_ID");

                entity.Property(e => e.PoliceCaseNum)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("date");

                entity.Property(e => e.ReportPage).IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnDateSundown).HasColumnType("date");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.Property(e => e.SuspendId).HasColumnName("Suspend_ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Reports__Client___0F624AF8");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Reports__Departm__0D7A0286");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.IncidentId)
                    .HasConstraintName("FK__Reports__Inciden__0E6E26BF");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__Reports__Staff_I__10566F31");

                entity.HasOne(d => d.Suspend)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.SuspendId)
                    .HasConstraintName("FK__Reports__Suspend__114A936A");
            });

            modelBuilder.Entity<ServiceIssues>(entity =>
            {
                entity.Property(e => e.ServiceIssuesId).HasColumnName("ServiceIssues_ID");

                entity.Property(e => e.ServiceSummary).IsUnicode(false);
            });

            modelBuilder.Entity<ServiceProviders>(entity =>
            {
                entity.HasKey(e => e.ServiceProviderId)
                    .HasName("serviceProviderID_pk");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProvider_ID");

                entity.Property(e => e.ServiceProvider)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceSearches>(entity =>
            {
                entity.HasKey(e => e.ServiceSearchId)
                    .HasName("servicesearchesID_pk");

                entity.Property(e => e.ServiceSearchId).HasColumnName("ServiceSearch_ID");

                entity.Property(e => e.ServiceCategory)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.StaffFname)
                    .HasColumnName("StaffFName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffLname)
                    .HasColumnName("StaffLName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunDownSignIn>(entity =>
            {
                entity.Property(e => e.SunDownSignInId).HasColumnName("SunDownSignIn_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.SignIn).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SunDownSignIn)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__SunDownSi__Clien__123EB7A3");
            });

            modelBuilder.Entity<SuspendTimes>(entity =>
            {
                entity.HasKey(e => e.SuspendId)
                    .HasName("suspendTimesID_pk");

                entity.Property(e => e.SuspendId).HasColumnName("Suspend_ID");

                entity.Property(e => e.DaysOut)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendors>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("vendorsID_pk");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Organization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VeteransStatus>(entity =>
            {
                entity.Property(e => e.VeteransStatusId).HasColumnName("VeteransStatus_ID");

                entity.Property(e => e.VeteranStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YearsInAuburn>(entity =>
            {
                entity.Property(e => e.YearsInAuburnId).HasColumnName("YearsInAuburn_ID");
            });

            modelBuilder.Entity<YearsInWashington>(entity =>
            {
                entity.Property(e => e.YearsInWashingtonId).HasColumnName("YearsInWashington_ID");
            });

            modelBuilder.Entity<YearsOfHomelessness>(entity =>
            {
                entity.Property(e => e.YearsOfHomelessnessId).HasColumnName("YearsOfHomelessness_ID");

                entity.Property(e => e.HomelessnessTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
