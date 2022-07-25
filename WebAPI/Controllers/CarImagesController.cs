using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _carImageService = carImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("getallimages")]
        public IActionResult GetAllImages()
        {
            var result = _carImageService.GetAllImages();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("[action]")]
        public IActionResult UploadCarImage(List<IFormFile> images)
        {
            if (images.Count == 0) { return BadRequest(); }
            string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, "UploadedImages");

            foreach (var image in images)
            {
                String filename = Guid.NewGuid().ToString() + ".jpg";
                string imagePath = Path.Combine(directoryPath, filename);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                _carImageService.Insert(new CarImage() { CarId = 1, Id = 1, ImagePath = filename, Date = DateTime.Now });
            }

            return Ok("Upload Successful");
        }


    }
}
