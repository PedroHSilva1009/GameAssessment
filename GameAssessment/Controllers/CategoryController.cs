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
            return NotFound("Nenhuma categoria encontrada");
       }

        Category category = listCategories[0];

        return Ok(
            new ApiResponse<Category>("Categorias:", category)
        );
    }

    [HttpPost]
    public IActionResult registerCategory(Category reqBody){
        Category categoryReq = new(Guid.NewGuid().ToString(), reqBody.categoryName);
        _categoryRepository.add(categoryReq);
        return Ok();
    }

    [HttpPut("{categoryId}")]
    public IActionResult updateCategoryById(Category reqBody){
        string categoryId = HttpContext.Request.RouteValues["categoryId"].ToString();

        var categoryFound = _categoryRepository.get().Where(categoryDb => categoryDb.categoryId == categoryId).ToList();

        if(categoryFound.Count()<=0){
            return NotFound("Category not found");
        }
        Category category = categoryFound[0];

        category.categoryName = reqBody.categoryName;

        _categoryRepository.update(category);

        return Ok(
            new ApiResponse<Category>("Category updated", category)
        );
    }
    [HttpDelete("{categoryId}")]
    public IActionResult deleteCategory(Category reqBody){
        string categoryId = HttpContext.Request.RouteValues["categoryId"].ToString();
        
        var categoryFound = _categoryRepository.get().Where(categoryDb => categoryDb.categoryId == categoryId).ToList();

        if(categoryFound.Count()<=0){
            return NotFound("Category not found");
        }

        Category category = categoryFound[0];

        category.categoryName = reqBody.categoryName;
        _categoryRepository.update(category);

        return Ok(
            new ApiResponse<Category>("Category updated", category)
        );
    }
}