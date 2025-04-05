using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MockClassificationAPI.Controllers
{
    [Route("api/classification")]
    [ApiController]
    public class ClassificationController : ControllerBase
    {
        private static readonly string[] Classifications =
        {
            "WaterLeakDetection",
            "RoofingTileReplacement",
            "FireDamagedWallRepair",
            "BrokenDoorRepair",
            "BasementWaterproofing"
        };

        private static readonly string[] RiskLevels = { "Low", "Medium", "High" };

        [HttpGet("classify")]
        public IActionResult GetClassification(string invoiceId)
        {
            var random = new Random();
            var response = new
            {
                Classification = Classifications[random.Next(Classifications.Length)],
                RiskLevel = RiskLevels[random.Next(RiskLevels.Length)]
            };

            //var jsonResponse = JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });
            return Ok(response);
        }
    }
}
