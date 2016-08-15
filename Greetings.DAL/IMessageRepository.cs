using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greetings.Domain;

namespace Greetings.DAL
{
    public interface IMessageRepository
    {
          Message GetMessage();
    }

}
