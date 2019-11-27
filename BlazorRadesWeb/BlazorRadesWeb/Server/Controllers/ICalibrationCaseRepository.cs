using System.Threading.Tasks;
using BlazorRadesWeb.Model;

namespace BlazorRadesWeb.Controllers
{
    public interface ICalibrationCaseRepository
    {
        Task<CalibrationCase[]> GetCalibrationCaseAsync();
    }
}