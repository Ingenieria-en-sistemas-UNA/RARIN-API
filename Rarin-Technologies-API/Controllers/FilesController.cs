using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rarin_Technologies_API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [EnableCors("AllowOrigin")]
        [HttpPost]
        public ActionResult<Object> upload([FromForm(Name = "file")] IFormFile file)
        {
            if(file == null || file.Length == 0)
            {
                return BadRequest();
            }
            Account account = new Account(
                "dhp8mrpln",
                "245516721673195",
                "vUTem45Du0KK5Skj8XrQ-zIU2Zc"
            );
            Cloudinary cloudinary = new Cloudinary(account);

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.Name, file.OpenReadStream())
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            var imageUrl = uploadResult.SecureUri;
            return new { ok = true, imageUrl };
        }
    }
}