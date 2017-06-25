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
    public class FeatureController : Controller
    {
        public readonly InsDbContext context;
        public readonly IMapper mapper;
        public FeatureController(IMapper mapper, InsDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeature()
        {
            var features = await context.Features.ToListAsync();
                return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}
