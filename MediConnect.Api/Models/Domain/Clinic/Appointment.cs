using MediConnect.Api.Models.Domain;
using MediConnect.Api.Models.Domain.Patient;

namespace MediConnect.Api.Models.Domain.Clinic
{
    public class Appointment
    {
        public Guid Id { get; set; }

        public ClinicPatient? Patient { get; set; }

        public DateTime Date { get; set; }


    }
}
