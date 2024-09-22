using MapApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MapApplication.Controllers
{
    [Route("api/[controller]")]
    public class PointController : ControllerBase
    {
        private readonly PointService _pointService;

        public PointController(PointService pointService)
        {
            _pointService = pointService;
        }

        // Tüm noktaları getirir
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _pointService.GetAll();

            if (!response.Succeeded)
            {
                return StatusCode(500, "Veriler alınamadı.");
            }

            var results = response.Value.Select(point => new {
                id = point.id,
                name = point.name,
                wkt = point.wkt  // WKT formatında geometri
            }).ToList();

            return Ok(results);  // JSON formatında geri döner
        }

        // Yeni nokta ekler
        [HttpPost("Add")]
        public IActionResult AddPoint([FromBody] Point point)
        {
            if (point == null)
            {
                return BadRequest("Invalid point data.");
            }

            var response = _pointService.Add(point);

            if (!response.Succeeded)
            {
                return StatusCode(500, response.Message); // Hata varsa 500 hata kodu ve mesaj döner
            }

            return Ok(response.Value); // Başarılı ise eklenen noktayı döner
        }

        // Belirtilen ID'ye sahip noktayı günceller
        [HttpPut("Update/{id}")]
        public IActionResult UpdatePoint(long id, [FromBody] Point updatedPoint)
        {
            if (updatedPoint == null)
            {
                return BadRequest("Invalid point data.");
            }

            var response = _pointService.Update(id, updatedPoint);

            if (!response.Succeeded)
            {
                return StatusCode(404, response.Message); // Return 404 if the point is not found
            }

            return Ok(response.Value); // Return the updated point
        }


        // Belirtilen ID'ye sahip noktayı siler
        [HttpDelete("Delete/{id}")]
        public IActionResult DeletePoint(long id)
        {
            var response = _pointService.Delete(id);

            if (!response.Succeeded)
            {
                return StatusCode(404, new { message = "Point not found." });
            }

            return Ok(new { message = "Point successfully deleted." });
        }


        // Belirtilen ID'ye sahip noktayı getirir
        [HttpGet("GetById/{id}")]
        public IActionResult GetPointById(long id)
        {
            var response = _pointService.GetById(id);

            if (!response.Succeeded || response.Value == null || string.IsNullOrEmpty(response.Value.wkt))
            {
                return StatusCode(404, new { message = "WKT verisi eksik ya da tanımsız." }); // WKT verisi eksikse 404 döndür
            }

            return Ok(response.Value); // Başarılı ise noktayı döner
        }
    }
}
