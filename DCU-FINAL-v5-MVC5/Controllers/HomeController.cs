using DCU_FINAL_v5_MVC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DCU_FINAL_v5_MVC5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        DBEstudiante datosEstudiantes = new DBEstudiante();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EntityEstuditiante _est)
        {


            try
            {
                if (ModelState.IsValid)
                {
                    DBEstudiante dbEst = new DBEstudiante();
                    if (dbEst.AgregarEstudiante(_est))
                    {
                        ViewBag.Message = "Se ha registrado el estudiante: " + _est.nombre;
                        ModelState.Clear();

                    }

                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Error de registro";
                return View();
            }

        }




        public IActionResult ListaEst()
        {
            // trabajando con listado

            IEnumerable<EntityEstuditiante> listatE = datosEstudiantes.ListarEst();

            return View(listatE);
        }




        private List<EntityEstuditiante> convertDTalist(DataTable estudiant)
        {
            List<EntityEstuditiante> UnsoloEst = new List<EntityEstuditiante>();
            foreach(DataRow r in estudiant.Rows)
            {
                EntityEstuditiante est = new EntityEstuditiante();
                est.idEstudiante = Convert.ToInt32(r["ID"]);
                est.nombre = Convert.ToString(r["nombre"]);
                est.correo = Convert.ToString(r["correo"]);
                est.telefono = Convert.ToString(r["telefono"]);
                est.Foto = Convert.ToString(r["Foto"]);

                UnsoloEst.Add(est);
            }

            return UnsoloEst;
        }




        public List<EntityEstuditiante> buscaloR(int i)
        {
            DataTable dte = datosEstudiantes.buscarloTO(i);

            List<EntityEstuditiante> listatEJustOne = convertDTalist(dte);

            return listatEJustOne;
        }
        

        public IActionResult Buscar(int id)
        {
            // trabajando con listado 1 
            try
            {
               IEnumerable<EntityEstuditiante> bus= datosEstudiantes.ListarEstUnRegistro(id);
                return View("ListaEst", bus);
            }
            catch(Exception ex)
            {
                IEnumerable<EntityEstuditiante> bus = new List<EntityEstuditiante> ();
                TempData["Msg_ERROR"] = "ERROR...."+ ex.Message;
                return View("ListaEst", bus);
            }


           
        }

       

        public IActionResult Cursos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
