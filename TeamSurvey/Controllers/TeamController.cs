using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamSurvey.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamSurvey.Controllers
{
    [Route("api/Team")]
    public class TeamController : Controller
    {
        //Create instance of DataAccessLayer
        TeamDataAccessLayer objTeam = new TeamDataAccessLayer();

        // GET: api/<controller> - Get All Teams
        [HttpGet]
        [Route("GetTeamList")]
        public IEnumerable<IplTeams> GetTeamList()
        {
            return objTeam.GetAllTeams();
        }

        //Get Total Votes
        [HttpGet]
        [Route("TotalVotes")]
        public int TotalVotes()
        {
            return objTeam.GetTotalVoteCount();
        }

        //Update Votes count
        [HttpPut]
        [Route("UpdateVoteCount")]
        public int UpdateVoteCount([FromBody] IplTeams team)
        {
            return objTeam.RecordVote(team);
        }
    }
}
