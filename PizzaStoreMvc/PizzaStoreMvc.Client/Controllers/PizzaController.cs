﻿using PizzaStoreMvc.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMvc.Client.Controllers
{
  public class PizzaController : Controller
  {
    // GET: Pizza
    public ActionResult Index()
    {
      var model = new PizzaOrder();
      return View(model);
    }


    // POST: Pizza/Create
    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }


    // POST: Pizza/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // GET: Pizza/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: Pizza/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }
  }
}
