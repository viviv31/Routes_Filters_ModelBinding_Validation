﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routes_Filters_ModelBinding_Validation.Models;

namespace Routes_Filters_ModelBinding_Validation.Controllers
{
  public class ModelBindingController : Controller
  {
    private IRepository repository;

    public ModelBindingController(IRepository repo)
    {
      repository = repo;
    }

    public ViewResult Index(int id) => View(repository[id]);

    public ViewResult IndexWithAddress(int id) => View(repository[id]);

    public ViewResult IndexNullSafe(int id) => View(repository[id] ?? repository.People.First());

    public ViewResult Create() => View(new Person());
        //create a new person//
   

    [HttpPost]
    public ViewResult Create(Person model) => View("IndexNullSafe", model);
        //to deal with null values, the end user did not entered an id at all//

    public ViewResult CreateWithAddress() => View(new Person());

    [HttpPost]
    public ViewResult CreateWithAddress(Person model) => View("IndexWithAddress", model);

    public ViewResult NamesArray(string[] names) => View(names ?? new string[0]);

    public ViewResult NamesList(IList<string> names) => View(names ?? new List<string>());

    public ViewResult Address(IList<AddressSummary> addresses) => View(addresses ?? new List<AddressSummary>());

    public ViewResult createfavoritefood()
        {
            Food food = new Food();
            return View(food);
        }

    [HttpPost]
    public ViewResult createfavoritefood(Food food)
        {
            return View(food);
        }
  }
}