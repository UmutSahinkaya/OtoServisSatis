﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly IService<Musteri> _service;
        private readonly IService<Arac> _serviceArac;

        public CustomersController(IService<Musteri> service, IService<Arac> serviceArac)
        {
            _service = service;
            _serviceArac = serviceArac;
        }

        // GET: CustomersController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomersController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Adi");
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddAsync(musteri);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            return View(musteri);
        }

        // GET: CustomersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.FindAsync(id);
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            return View(model);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(musteri);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            return View(musteri);
        }

        // GET: CustomersController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Musteri musteri)
        {
            try
            {
                _service.Delete(musteri);
                _service.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}