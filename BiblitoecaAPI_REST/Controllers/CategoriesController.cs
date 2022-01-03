using AutoMapper;
using BiblitoecaAPI_REST.DTOs;
using BiblitoecaAPI_REST.Models;
using BiblitoecaAPI_REST.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiblitoecaAPI_REST.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public CategoriesController(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryReadDTO>>> Get()
        {
            var categories = await applicationDbContext.Categories.ToListAsync();

            return mapper.Map<List<CategoryReadDTO>>(categories);

            //Mapeo de Category a CategoryReadDTO manual
            //return categories.Select(c => new CategoryReadDTO
            //{
            //    IdCategory = c.IdCategory,
            //    Name = c.Name
            //}).ToList();
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public async Task<ActionResult<CategoryReadDTO>> GetById(int id)
        {
            var category = await applicationDbContext.Categories.FirstOrDefaultAsync(c => c.IdCategory == id);

            if(category == null)
            {
                return NotFound();
            }

            return mapper.Map<CategoryReadDTO>(category);
            
        }

        [HttpPost]
        public async Task<ActionResult> Post(CategoryCreationDTO categoryCreationDTO)
        {
            var category = mapper.Map<Category>(categoryCreationDTO);

            applicationDbContext.Categories.Add(category);

            await applicationDbContext.SaveChangesAsync();

            // Rest define que debemos devolver el recurso creado con la ruta al cliente

            var dto = mapper.Map<CategoryReadDTO>(category);

            return new CreatedAtRouteResult("GetCategory", new { id = category.IdCategory }, dto);
        }

    }
}
