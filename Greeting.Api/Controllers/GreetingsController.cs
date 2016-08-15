using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Greetings.DAL;

namespace Greeting.Api.Controllers
{
    public class GreetingsController : ApiController
    {
        private readonly IMessageRepository _repository;

        public GreetingsController()
        {
            _repository = new MessageRepository();
        }
        public string Get()
        {
            return _repository.GetMessage().Greeting;
        }
    }
}
