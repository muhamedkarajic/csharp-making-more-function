using System.Linq;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private IRepository<User> UsersRepository { get; }

        public UsersController(IRepository<User> usersRepository)
        {
            this.UsersRepository = usersRepository;
        }

        [HttpGet]
        public IActionResult GetAll() =>
            Ok(this.UsersRepository.GetAll());

        [HttpGet]
        [Route("{username}", Name="get-user")]
        public IActionResult Find(string username) =>
            Ok(this.UsersRepository.GetAll().First(user => user.UserName == username));

        [HttpPost]
        public IActionResult Create([FromBody] InputModels.User user)
        {
            User model = user.ToModel();
            this.UsersRepository.Add(model);
            string url = Url.Link("get-user", new {username = model.UserName});
            return Created(url, model);
        }
    }
}