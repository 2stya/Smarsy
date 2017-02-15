
namespace Smarsy.WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Smarsy.Logic;
    using SmarsyEntities;

    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            var sqlLogic = new SqlServerLogic();
            var student = sqlLogic.GetStudent(studentId: id);

            return student;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
