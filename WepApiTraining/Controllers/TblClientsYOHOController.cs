using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WepApiTraining.Controllers;

namespace WepApiTraining.Models
{
    [ApiController]
    [Route("[controller]/Clients")]
    public class TblClientsYOHOController : Controller
    {

        STCDataContext _context;

        public TblClientsYOHOController()
        {
            if (DataSingleton.Instance.stcData == null)
                throw new Exception("CONTEXT NULL");

            _context = DataSingleton.Instance.stcData;

        }



        // GET: TblClients
        [HttpGet(Name = "GetClients")]
        public async Task< IEnumerable<TblTcClient>> GetClients()
        {
            if (_context.TblTcClient == null)
                return new List<TblTcClient>();

            return await _context.TblTcClient.Take(5).ToListAsync();
        }











        //// GET: TblClients/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.TblTcClient == null)
        //    {
        //        return NotFound();
        //    }

        //    var tblTcClient = await _context.TblTcClient
        //        .FirstOrDefaultAsync(m => m.Idclient == id);
        //    if (tblTcClient == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tblTcClient);
        //}

        //// GET: TblClients/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: TblClients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Idclient,StrClCodeGescom,StrClCodePmi,BClDesactive,StrClTransfertPmi,BClTransfertOk,DateClMajFiche,StrClLivSociete,StrClRevendeur,StrClLivAdr1,StrClLivAdr2,StrClLivAdr3,StrClLivCodePostal,StrClLivVille,StrClLivPays,StrClTel,StrEmail,LhtClWeb,StrClActivite,StrClMetier,StrClProduits,StrClOrigineContact,StrClInfo,NClPriorite,StrClPriorite,DateClCreationFiche,DateClPremierContact,DateClDernierContact,StrClStatutCommercial,StrClStatutClient,NClKm,StrClFax,LnkIdrevendeur,StrNomCourt,SsmaTimeStamp")] TblTcClient tblTcClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblTcClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblTcClient);
        }

        //// GET: TblClients/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.TblTcClient == null)
        //    {
        //        return NotFound();
        //    }

        //    var tblTcClient = await _context.TblTcClient.FindAsync(id);
        //    if (tblTcClient == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(tblTcClient);
        //}

        //// POST: TblClients/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Idclient,StrClCodeGescom,StrClCodePmi,BClDesactive,StrClTransfertPmi,BClTransfertOk,DateClMajFiche,StrClLivSociete,StrClRevendeur,StrClLivAdr1,StrClLivAdr2,StrClLivAdr3,StrClLivCodePostal,StrClLivVille,StrClLivPays,StrClTel,StrEmail,LhtClWeb,StrClActivite,StrClMetier,StrClProduits,StrClOrigineContact,StrClInfo,NClPriorite,StrClPriorite,DateClCreationFiche,DateClPremierContact,DateClDernierContact,StrClStatutCommercial,StrClStatutClient,NClKm,StrClFax,LnkIdrevendeur,StrNomCourt,SsmaTimeStamp")] TblTcClient tblTcClient)
        //{
        //    if (id != tblTcClient.Idclient)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(tblTcClient);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TblTcClientExists(tblTcClient.Idclient))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(tblTcClient);
        //}

        //// GET: TblClients/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.TblTcClient == null)
        //    {
        //        return NotFound();
        //    }

        //    var tblTcClient = await _context.TblTcClient
        //        .FirstOrDefaultAsync(m => m.Idclient == id);
        //    if (tblTcClient == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tblTcClient);
        //}

        //// POST: TblClients/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.TblTcClient == null)
        //    {
        //        return Problem("Entity set 'STCDataContext.TblTcClient'  is null.");
        //    }
        //    var tblTcClient = await _context.TblTcClient.FindAsync(id);
        //    if (tblTcClient != null)
        //    {
        //        _context.TblTcClient.Remove(tblTcClient);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool TblTcClientExists(int id)
        //{
        //  return (_context.TblTcClient?.Any(e => e.Idclient == id)).GetValueOrDefault();
        //}
    }
}
