using HospitalWebApp.Models.Doctors;
using HospitalWebApp.Models.Patients;

namespace HospitalWebApp.Models.Interfaces
{
    public interface IPatientRepository
    {
        List<Doctor> GetDoctorsDropdown();
        PROMIS10 GetPROMIS10ByAppointmentID(int appointmentID);
        List<Bill> GetPatientBills(int patientID);
    }
}
