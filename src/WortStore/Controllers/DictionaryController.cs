using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WortStore.Models;
using WortStore.Models.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

/*
Контроллер для словаря
* Пока захардкожен немецкий язык по умолчанию
*/

namespace WortStore.Controllers
{
  public class DictionaryController : Controller
  {
    private DictionaryManger manager;

    public DictionaryController(DataContext d)
    {
      manager = new DictionaryManger(d);
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
      List<Word> words = new List<Word>(manager.GetWords());
      return View(words);
    }

    [HttpGet]
    public IActionResult AddWord()
    {
      return View();
    }

    [HttpPost]
    public IActionResult AddWord(Word w)
    {
      manager.AddWord(w);
      return RedirectToAction("Index");
    }

  }
}
