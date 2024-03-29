using BrainRing.Interfaces;
using BrainRing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace BrainRing.Controllers
{
    public class HomeController(ITeamAnswerService service) : Controller
    {
        public IActionResult Index()
        {
            return View(new TeamAnswerViewModel());
        }

        public async Task<IActionResult> Admin()
        {
            var answerRows = await service.GetAnswerRows();
            return View(answerRows);
        }

        [HttpPost()]
        public async Task<IActionResult> AddTeamAnswer(TeamAnswerViewModel answerViewModel)
        {
            if ((answerViewModel.CommandNumber is < 1 or > 10) || 
                string.IsNullOrEmpty(answerViewModel.Answer) ||
                answerViewModel.QuestionNumber < 1)
            {
                return RedirectToAction("Index");
            }

            var answerModel = await service.AddTeamAnswer(answerViewModel);

            return View("Index", answerModel);
        }
    }
}
