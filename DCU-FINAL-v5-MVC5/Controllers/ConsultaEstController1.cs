using DCU_FINAL_v5_MVC5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DCU_FINAL_v5_MVC5.Controllers
{
    public class ConsultaEstController1 : Controller
    {
        DBEstudiante datosEstudiantes = new DBEstudiante();

        public IActionResult Index()
        {
            IEnumerable<EntityEstuditiante> listatE = datosEstudiantes.ListarEst();
            return View();
        }
    }
}
