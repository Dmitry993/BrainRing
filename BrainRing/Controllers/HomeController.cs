using BrainRing.Interfaces;
using BrainRing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace BrainRing.Controllers
{
    public class HomeController(ITeamAnswerService answerService) : Controller
    {
        public IActionResult Index()
        {
            return View(new TeamAnswerViewModel());
        }

        [HttpPost()]
        public async Task<IActionResult> AddTeamAnswer(TeamAnswerViewModel answerViewModel)
        {
            if ((answerViewModel.CommandNumber is < 1 or > 10) || 
                string.IsNullOrEmpty(answerViewModel.Answer) ||
                (answerViewModel.QuestionNumber is < 1 or > 20))
            {
                throw new ArgumentException();
            }

            var answerModel = await answerService.AddTeamAnswer(answerViewModel);

            return View("Index", answerModel);
        }
    }
}
