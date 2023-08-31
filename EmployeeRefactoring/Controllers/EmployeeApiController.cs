using Microsoft.AspNetCore.Mvc;

namespace EmployeeRefactoring.Controllers
{
    [ApiController]
    [Route("employee")]
    public class EmployeeApiController : ControllerBase
    {

        [HttpGet]
        public string GetName()
        {
            return "John Doe";
        }

        
        [Route("getAge")]
        [HttpGet]
        public int GetAge()
        {
            return 20;
        }

        [Route("sendData")]
        [HttpPost]
        public void SendData([FromBody] Employee employee)
        {
             Console.WriteLine(employee.FirstName +  " " + employee.LastName);

        }
    }
}