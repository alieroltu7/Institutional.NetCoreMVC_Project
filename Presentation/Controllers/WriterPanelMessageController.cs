using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        
        MessageManager cm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messagelist = cm.GetListInbox();
            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var messagelist = cm.GetListSendbox();
            return View(messagelist);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}