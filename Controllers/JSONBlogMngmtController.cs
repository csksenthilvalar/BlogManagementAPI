using BlogManagementSysAPI.DataAccessLayer.Interface;
using BlogManagementSysAPI.DataAccessLayer.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace BlogManagementSysAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class JSONBlogMngmtController : ControllerBase
    {
        private readonly IJSONBlogMngmt _blogRepo;
        public JSONBlogMngmtController(IJSONBlogMngmt blogRepo)
        {

            _blogRepo = blogRepo;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBlogMngmt()
        {
            try
            {
                var BlogMngmt =  _blogRepo.GetBlogMngmtlist();
               
                return Ok(BlogMngmt);
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBlogMngmt([FromBody]  BlogMngmt blogMngmt)
        {
            try
            {
                var createdblogMngmt =  _blogRepo.AddBlogMngmt(blogMngmt);
                return CreatedAtAction(nameof(CreateBlogMngmt), createdblogMngmt);
            }
            catch (Exception ex)
            {
                //  _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlogMngmt(BlogMngmt blogMngmt)
        {
            try
            {
                var _blogMngmt =  _blogRepo.GetBlogMngmtById(blogMngmt.Id);
                if (_blogMngmt == null)
                {
                    return NotFound(new
                    {
                        statusCode = 404
                        ,
                        message = "Blog does not found"
                    });
                }
                 _blogRepo.UpdateBlogMngmt(blogMngmt);
                return NoContent();
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogMngmtById(int id)
        {
            try
            {
                var _blogMngmt =  _blogRepo.GetBlogMngmtById(id);
                if (_blogMngmt == null)
                {
                    return NotFound(new
                    {
                        statusCode = 404
                        ,
                        message = "Blog  does not found"
                    });
                }
                return Ok(_blogMngmt);
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogMngmt(int id)
        {
            try
            {
                var _blogMngmt =  _blogRepo.GetBlogMngmtById(id);
                if (_blogMngmt == null)
                {
                    return NotFound(new
                    {
                        statusCode = 404
                        ,
                        message = "Blog  does not found"
                    });
                }
               var res=  _blogRepo.DeleteBlogMngmt(id);
                return NoContent();
            }
            catch (Exception ex)
            {
              //  _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }
    }
}
