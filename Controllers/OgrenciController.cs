using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DataContext _context;
        public OgrenciController(DataContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var ogrenciler = await _context.Ogrenciler.ToListAsync();
            return View(ogrenciler);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model)
        {
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var ogr = await _context.Ogrenciler.FindAsync(id); // FindAsync => sadece id ye göre bir arama yapılabilir.
            
            // var ogr = await _context.Ogrenciler.FirstOrDefaultAsync(o => o.OgrenciKimlik == id); // o.OgrenciKimlik kısmına örnek olarak Telefon yazılırsa telefon numarası ile de arama yapılabilir.


            if(ogr == null)
            {
                return NotFound();
            }

            return View(ogr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // (Cross Site Attack) form içerisine asp.net'in eklemiş olduğu RequestVerificationToken value'sının kontrolunu yapmasını sağlar. 
        public async Task<IActionResult> Edit(int id, Ogrenci model)
        {
            if(id != model.OgrenciKimlik)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(model); //güncelleme işaretlendi
                    await _context.SaveChangesAsync(); //güncelleme yapıldı.
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!_context.Ogrenciler.Any(o => o.OgrenciKimlik == model.OgrenciKimlik))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }
    
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler.FindAsync(id);

            if(ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        } 

        [HttpPost]
        public async Task<IActionResult> Delete()
        {
            
        }
        
    }    
}