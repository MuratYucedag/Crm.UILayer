using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Abstact
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> TGetReceiverMessageList(string mail);
        List<Message> TGetSenderMessageList(string mail);
    }
}
