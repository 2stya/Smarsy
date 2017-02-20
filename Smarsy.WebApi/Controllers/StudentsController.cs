
using System;

namespace Smarsy.WebApi.Controllers
{
    using System.Web.Http;
    using Logic;
    using SmarsyEntities;

    public class StudentsController : ApiController
    {
        // GET: api/Student/5
        public Student Get(int id = 0, string login = "")
        {
            if (id == 0 && login.Equals(string.Empty))
            {
                throw new NullReferenceException("Student Id or login must be provided.");
            }

            var sqlLogic = new SqlServerLogic();

            return id > 0 ? sqlLogic.GetStudent(studentId: id) : sqlLogic.GetStudent(login: login);
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
