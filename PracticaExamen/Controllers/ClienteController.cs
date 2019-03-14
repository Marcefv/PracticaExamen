using MongoDB.Driver;
using PracticaExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaExamen.Controllers
{
    public class ClienteController : Controller
    {

        private ContextoMongo elContexto = new ContextoMongo();

        public ActionResult Peliculas(string id)
        {
            var pelis = elContexto.Clientes;
           

            var lapeli = pelis.Find<Cliente>(a => a._id == id).FirstOrDefault();
            return View(lapeli.pelis);
        }
        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = elContexto.Clientes;
            var losClientes = clientes.AsQueryable().ToList();
            return View(losClientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente elCliente)
        {
            try
            {
                var clientes = elContexto.Clientes;
                elCliente.pelis = new List<Pelis>();
                
                clientes.InsertOne(elCliente);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // POST: Cliente/CreatePeli
        [HttpPost]
        public ActionResult CreatePeli(Cliente elCliente)
        {
            try
            {
                var clientes = elContexto.Clientes;
                elCliente.pelis = new List<Pelis>();

                clientes.InsertOne(elCliente);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
