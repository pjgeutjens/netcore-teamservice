using System.Collections.Generic;
using Leap.TeamService.Models;
using Xunit;
using System.Linq;
using Microsoft.AspNetCore.

namespace Leap.TeamService
{
    public class TeamsControllerTest
    {
        TeamsController controller = new TeamsController();

        [Fact]
        public void QueryTeamsListReturnsCorrectTeams()
        {
            List<Team> teams = new List<Team>(controller.GetAllTeams());
            Assert.Equal(2, teams.Count);
        }

        [Fact]
        public void CreateTeamAddsTeamToList()
        {
            TeamsController controller = new TeamsController();
            var teams = (IEnumerable<Team>)(controller.GetAllTeams() as ObjectResult).Value;
        
        //When
        
        //Then
        }
    }
}
