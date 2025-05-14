using DogsApp.Models;
using DogsApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogsApp.Controllers;

public class DogsController : Controller
{
    static DogService dogService = new();

    [HttpGet("")]
    public IActionResult Index() {
        var dogs = dogService.GetAllDogs();
        return View(dogs);
    }

    [HttpGet("create")]
    public IActionResult Create() {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Dog dog) {
        dogService.AddDog(dog);

        return RedirectToAction(nameof(Index));

    }


    [HttpPost("delete")]
    public IActionResult Delete(int id)
    {
        dogService.DeleteDog(id);

        return RedirectToAction(nameof(Index));

    }

}
