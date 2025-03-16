using HospitalWebApp.Models.Identity;

namespace HospitalWebApp.Models.Doctors.ViewModels
{
    public class DoctorUpdateViewModelForm
    {
        public AppUser AppUser { get; set; }
        public Doctor Doctor { get; set; }
    }
}
