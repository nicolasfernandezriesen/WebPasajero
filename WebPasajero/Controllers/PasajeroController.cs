using WebPasajero.Data;
using WebPasajero.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebPasajero.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly WebPasajeroContext context;

        public PasajeroController(WebPasajeroContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Pasajeros.ToList());
        }

        public IActionResult Create() 
        {
            Pasajero pasajero= new Pasajero();
            return View(pasajero);
        }

        [HttpPost]
        public IActionResult Create(Pasajero pasajero) 
        {
            context.Add(pasajero);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("Pasajero/ListarPorFechaNacimiento/{fecha:DateTime}")]
        public IActionResult ListarPorFechaNacimiento(DateTime fecha)
        {
            List<Pasajero> pasajeros = (from p in context.Pasajeros
                              where p.BirthDate == fecha
                              select p).ToList();

            return View("Index", pasajeros);
        }

        [Route("Pasajero/ListarPorFechaNacimiento/{city}")]
        public IActionResult ListarPorCiudad(string city)
        {
            List<Pasajero> pasajeros = (from p in context.Pasajeros
                                        where p.City == city
                                        select p).ToList();

            return View("Index", pasajeros);
        }
    }
}
