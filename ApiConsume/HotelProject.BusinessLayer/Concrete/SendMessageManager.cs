using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMesageDal;

        public SendMessageManager(ISendMessageDal sendMesageDal)
        {
            _sendMesageDal = sendMesageDal;
        }

        public void TDelete(SendMessage t)
        {
            _sendMesageDal.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMesageDal.GetByID(id);  
        }

        public List<SendMessage> TGetList()
        {
            return _sendMesageDal.GetList();    
        }

        public void TInsert(SendMessage t)
        {
            _sendMesageDal.Insert(t);   
        }

        public void TUpdate(SendMessage t)
        {
            _sendMesageDal.Update(t);
        }
    }
}
