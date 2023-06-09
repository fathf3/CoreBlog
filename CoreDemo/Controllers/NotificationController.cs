﻿using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AllNotification() {

            var values = notificationManager.getList();
            return View(values);
        }
    }
}
