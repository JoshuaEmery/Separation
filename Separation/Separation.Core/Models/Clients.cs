using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Clients
    {
        public Clients()
        {
            BarCodeNumbers = new HashSet<BarCodeNumbers>();
            ClientNotes = new HashSet<ClientNotes>();
            ClientSignIns = new HashSet<ClientSignIns>();
            EmergencyContacts = new HashSet<EmergencyContacts>();
            HygieneClients = new HashSet<HygieneClients>();
            LaundryDays = new HashSet<LaundryDays>();
            Reports = new HashSet<Reports>();
            SunDownSignIn = new HashSet<SunDownSignIn>();
        }

        public int ClientId { get; set; }
        public string ClientFname { get; set; }
        public string ClientLname { get; set; }
        public DateTime? IntakeDate { get; set; }
        public int? CitySleptId { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderId { get; set; }
        public int? EthnicityId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? DependentId { get; set; }
        public int? EducationLevelId { get; set; }
        public string SocialSecurity { get; set; }
        public int? VeteransStatusId { get; set; }
        public int? YearsOfHomelessnessId { get; set; }
        public int? YearsInAuburnId { get; set; }
        public int? YearsInWashingtonId { get; set; }
        public int? CitizenshipId { get; set; }
        public int? IdentificationId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? ServiceIssuesId { get; set; }
        public int? DrugAlcoholEvaluationId { get; set; }
        public int? ServiceSearchId { get; set; }
        public string ImagePhoto { get; set; }
        public string Medical { get; set; }
        public string Notes { get; set; }
        public int? HasHousingId { get; set; }

        public virtual CitizenShips Citizenship { get; set; }
        public virtual CitiesLastSlept CitySlept { get; set; }
        public virtual Dependents Dependent { get; set; }
        public virtual DrugAlcoholEvaluation DrugAlcoholEvaluation { get; set; }
        public virtual EducationLevels EducationLevel { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        public virtual Genders Gender { get; set; }
        public virtual HasHousingList HasHousing { get; set; }
        public virtual Identifications Identification { get; set; }
        public virtual MaritalStatuses MaritalStatus { get; set; }
        public virtual ServiceIssues ServiceIssues { get; set; }
        public virtual ServiceProviders ServiceProvider { get; set; }
        public virtual ServiceSearches ServiceSearch { get; set; }
        public virtual VeteransStatus VeteransStatus { get; set; }
        public virtual YearsInAuburn YearsInAuburn { get; set; }
        public virtual YearsInWashington YearsInWashington { get; set; }
        public virtual YearsOfHomelessness YearsOfHomelessness { get; set; }
        public virtual ICollection<BarCodeNumbers> BarCodeNumbers { get; set; }
        public virtual ICollection<ClientNotes> ClientNotes { get; set; }
        public virtual ICollection<ClientSignIns> ClientSignIns { get; set; }
        public virtual ICollection<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual ICollection<HygieneClients> HygieneClients { get; set; }
        public virtual ICollection<LaundryDays> LaundryDays { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
        public virtual ICollection<SunDownSignIn> SunDownSignIn { get; set; }
    }
}
