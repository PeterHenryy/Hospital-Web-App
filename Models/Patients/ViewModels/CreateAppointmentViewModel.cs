using HospitalWebApp.Models.Doctors;

namespace HospitalWebApp.Models.Patients.ViewModels
{
    public class CreateAppointmentViewModel
    {
        public Appointment Appointment { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
