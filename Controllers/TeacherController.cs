using CoreBusiness;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqlServerPlugin;
using UseCases.Interfaces;
using UseCases.TeacherUseCases;

namespace StudentTeacherManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private ITeacherInformationUseCases _teacherInformationUseCases;
        public TeacherController(ITeacherInformationUseCases teacherInformationUseCases) 
        {
            this._teacherInformationUseCases = teacherInformationUseCases;
        }

        [HttpGet("get-all-teacher")]
        public IEnumerable<Teacher> Get()
        {
            return _teacherInformationUseCases.GetTeachers();
        }
    }
}
