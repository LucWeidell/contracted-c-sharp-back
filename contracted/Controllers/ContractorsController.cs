using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class ContractorsController
    {
        private readonly ContractorsService _cs;

        public ContractorsController(ContractorsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contractor>> Get()
        {
            try
            {
                await _cs.Get();
                List<Contractor> contractors = _cs.Get();
                return Ok(ContractorsController);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message)
            }
        }
  }
}