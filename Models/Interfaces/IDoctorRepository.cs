using HospitalWebApp.Models.Doctors;

namespace HospitalWebApp.Models.Interfaces
{
    public interface IDoctorRepository
    {
        bool Create(Doctor doctor);
        bool Remove(int doctorID);
        Doctor GetDoctorByID(int doctorID);
        List<Doctor> GetAllDoctors();
        bool CreateAppointment(Appointment appointment);
    }
}
