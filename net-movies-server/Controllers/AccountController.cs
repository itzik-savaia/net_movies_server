//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using SearchMovieServer.Models;
//using SearchMovieServer.Service;

//namespace SearchMovieServer.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly AccountService _accountService;

//        public AccountController(AccountService accountService)
//        {
//            _accountService = accountService;
//        }
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Accounts>>> GetAll()
//        {
//            var students = await _accountService.GetAllAsync();
//            return Ok(students);
//        }

        //public async Task<ActionResult<Student>> GetById(string id)
        //{
        //    var student = await _studentService.GetByIdAsync(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(student);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(Student student)
        //{
        //    await _studentService.CreateAsync(student);
        //    return Ok(student);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Update(string id, Student updatedStudent)
        //{
        //    var queriedStudent = await _studentService.GetByIdAsync(id);
        //    if (queriedStudent == null)
        //    {
        //        return NotFound();
        //    }
        //    await _studentService.UpdateAsync(id, updatedStudent);
        //    return NoContent();
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    var student = await _studentService.GetByIdAsync(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    await _studentService.DeleteAsync(id);
        //    return NoContent();
        //}
//    }
//}
