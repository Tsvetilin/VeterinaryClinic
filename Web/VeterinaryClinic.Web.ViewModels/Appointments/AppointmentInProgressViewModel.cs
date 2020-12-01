﻿using System;
using System.Collections.Generic;
using System.Text;
using VeterinaryClinic.Data.Models;
using VeterinaryClinic.Services.Mapping;

namespace VeterinaryClinic.Web.ViewModels.Appointments
{
    public class AppointmentInProgressViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public string OwnerFirstName { get; set; }

        public string OwnerLastName { get; set; }

        public string OwnerFullName => this.OwnerFirstName + " " + this.OwnerLastName;

        public string PetName { get; set; }

        public string PetId { get; set; }

        public string VetId { get; set; }

        public string Subject { get; set; }

        public DateTime StartTime { get; set; }

        public string PetDiagnoseDescription { get; set; }

        public string PetDiagnoseName { get; set; }

        // Add medications
    }
}
