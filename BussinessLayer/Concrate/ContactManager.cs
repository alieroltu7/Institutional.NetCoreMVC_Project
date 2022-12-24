using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
    public class ContactManager:IContactService
    {
        IContactDal _contatDal;

        public ContactManager(IContactDal contatDal)
        {
            _contatDal = contatDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contatDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contatDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contatDal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _contatDal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contatDal.List();
        }
    }
}
