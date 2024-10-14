using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WepApiTraining.Models;

namespace WepApiTraining.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtalonsController : Controller
    {
        private readonly STCDataContext _context;

        public EtalonsController()
        {
            if (DataSingleton.Instance.stcData == null)
                throw new Exception("CONTEXT NULL");

            _context = DataSingleton.Instance.stcData;
        }



        [HttpGet]
        // GET: Etalons/Details/5
        public async Task<List<TblTcEtalon>> GetEtlons()
        {
            return await _context.TblTcEtalon.ToListAsync();
        }




    }
}
