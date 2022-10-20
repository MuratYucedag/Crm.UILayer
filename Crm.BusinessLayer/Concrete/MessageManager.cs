using Crm.BusinessLayer.Abstact;
using Crm.DataAccessLayer.Abstract;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetReceiverMessageList(string mail)
        {
            return _messageDal.GetReceiverMessageList(mail);
        }

        public List<Message> TGetSenderMessageList(string mail)
        {
            return _messageDal.GetSenderMessageList(mail);
        }

        public void TInsert(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
