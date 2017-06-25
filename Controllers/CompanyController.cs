using AutoMapper;
using Insurance.Models;
using Insurance.Persistenece;
using Insurance.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Controllers
{
    public class CompanyController: Controller
    {
        public readonly InsDbContext Context;
        public readonly IMapper mapper;
        public CompanyController(InsDbContext Context , IMapper mapper)
        {
            this.Context = Context;
            this.mapper = mapper;
        }
        [HttpGet("api/company")]
        public async Task<IEnumerable<CompanyResource>> GetCompany()
        {
            var companies = await Context.Companies.Include(T => T.Types).ToListAsync();
            return mapper.Map<List<Company>, List<CompanyResource>>(companies);
        }
    }
}
