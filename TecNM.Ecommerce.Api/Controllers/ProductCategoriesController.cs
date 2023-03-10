using Microsoft.AspNetCore.Mvc;
using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.Api.Controllers;

[ApiController]
[Route(template: "api/[controller]")]
public class ProductCategoriesController : ControllerBase
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    
    public ProductCategoriesController(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }
    [HttpGet]
    public async Task<ActionResult<Response<List<ProductCategory>>>> GetAll()
    {
        var categories = await _productCategoryRepository.GetAllAsync();
        var response = new Response<List<ProductCategory>>();
        response.Data = categories;

        return Ok(response);
    }
    [HttpPost]
    public async Task<ActionResult<Response<ProductCategory>>> Post([FromBody] ProductCategory category)
    {
        category = await _productCategoryRepository.SaveAsync(category);
        
        var response = new Response<ProductCategory>();
        response.Data = category;
        
        return Created($"/api/[controller]/{category.Id}", category);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<ProductCategory>>> GetById(int id)
    {
        var category = await _productCategoryRepository.GetById(id);
        var response = new Response<ProductCategory>();
        response.Data = category;

        return Ok(response);
   }

    [HttpPut]
    public async Task<ActionResult<Response<ProductCategory>>> Update([FromBody] ProductCategory category)
    {
        var result = await _productCategoryRepository.UpdateAsync(category);
        var response = new Response<ProductCategory>{Data = result };

        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<ProductCategory>>> Delete (int id)
    {
        var result = await _productCategoryRepository.DeleteAsync(id);
        var response = new Response<bool>();
        response.Data = result;

        return Ok(response);
    }
}