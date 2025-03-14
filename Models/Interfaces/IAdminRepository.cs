namespace HospitalWebApp.Models.Interfaces
{
    public interface IAdminRepository   
    {

        decimal CalculateDoctorRevenue(int doctorID);
        decimal CalculateHospitalRevenue();
    }
}
