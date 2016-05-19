using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using TestePratico.Models;

namespace TestePratico.Controllers
{
  public class CandidatoController : Controller
  {
    private List<Candidato> listaCandidato = new List<Candidato>();
    
    public ActionResult Index()
    {
      if (TempData["dbCandidato"] != null) {
        TempData.Keep("dbCandidato");
        listaCandidato = (List<Candidato>)TempData["dbCandidato"];
      }      
      return View("Index", listaCandidato);
    }

    public ActionResult Cadastrar()
    {    
      return View("Cadastrar");
    }

    [HttpPost]    
    public ActionResult Cadastrar(Candidato candidato)
    {
      if (ModelState.IsValid)
      {
        if (TempData["dbCandidato"] != null)
        {
          TempData.Keep("dbCandidato");
          listaCandidato = (List<Candidato>)TempData["dbCandidato"];
        }
        candidato.Id = +listaCandidato.Count;
        listaCandidato.Add(candidato);
        TempData["dbCandidato"] = listaCandidato;
        return RedirectToAction("Index");
      }
      return View(candidato);
    }

    public ActionResult Visualizar(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      if (TempData["dbCandidato"] == null)
      {
        return HttpNotFound();
      }
      else
      {
        TempData.Keep("dbCandidato");
        listaCandidato = (List<Candidato>)TempData["dbCandidato"];
      }

      var candidato = listaCandidato.Find(c => c.Id == id.Value);
      
      if (candidato == null)
      {
        return HttpNotFound();
      }

      ViewBag.ClienteId = id;
      return View(candidato);
    }

  }
}