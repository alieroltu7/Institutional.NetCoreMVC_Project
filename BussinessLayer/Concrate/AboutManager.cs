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
    public class AboutManager:IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            aboutDal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            aboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            aboutDal.Update(about);
        }

        public About GetByID(int id)
        {
            return aboutDal.Get(x => x.AboutId == id);
        }

        public List<About> GetList()
        {
            return aboutDal.List(); 
        }
    }
}
