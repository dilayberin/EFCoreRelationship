using bilgiSis.Data;
using bilgiSis.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilgiSis.Controllers

//controller:kullanıcının HTTP isteklerini alıp iş mantığını uygulayarak sonuçları uygun bir görünüme ileten bileşendir.
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products;

            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCategoryAsync(int categoryId) {
            var products = await _context.Products
                .Where(x => x.CategoryId == categoryId)
                .Include(x => x.Size)
                .Include(x => x.Colors).ToListAsync();

            return Ok(products);
        }
        //parametre gelen catId bizim ürünümüzün catId eşitse bu ürünün beden ve rengini listeye dönüştürüp döndür
    }
}
