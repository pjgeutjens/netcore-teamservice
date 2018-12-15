using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Leap.TeamService.Models;

namespace Leap.TeamService
{
    public class TeamsController
    {
        [HttpGet]
        public IEnumerable<Team> GetAllTeams()
        {
            return new Team[] {new Team("one"), new Team("two") };
        }
    }
}