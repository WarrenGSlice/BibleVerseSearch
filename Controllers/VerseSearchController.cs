﻿using BibleVerseSearch.Models;
using BibleVerseSearch.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BibleVerseSearch.Controllers
{
    public class VerseSearchController : Controller
    {
        //set datasourse
        public IBibleVerseDataService repository { get; set; }
        public VerseSearchController(IBibleVerseDataService dataService)
        {
            repository = dataService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllVerses()
        {
            return View(repository.AllVerses());
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult SearchResults(BibleVerse searchVerse)
        {
            return View(repository.SearchVerses(searchVerse));
        }

    }
}
