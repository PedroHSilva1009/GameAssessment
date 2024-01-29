using GameAssessment.Interfaces;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAssessment.Controllers;

[ApiController]
[Route("category")]
public class CategoryController : Controller{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository){
        _categoryRepository = categoryRepository;
    }
    
    [HttpGet]
    public IActionResult getAllCategories(){

       var listCategories = _categoryRepository.get().ToList();

       if(listCategories.Count()<=0){
            return NotFound();
       }

        Category category = listCategories[0];

        return Ok(
            new ApiResponse<Category>("Categorias:", category)
        );
    }
}