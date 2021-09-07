using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class ContractorsService
    {
        private readonly ContractorsRepository _repo;

    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }

    internal List<Contractor> Get()
    {
        List<Contractor> contractors = _repo.GetAll();
        if(contractors == null)
        {
            throw new BadRequest("Failed getAll");
        }
        return contractors;
    }
  }
}