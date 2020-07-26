using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeDevPortfolio.Models;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace WeDevPortfolio.Controllers
{
    [Route("api/[controller]")]
    //[Authorize(Roles = "Manager")]
    public class ProjectsController : ControllerBase
    {
        private AppDbContext db = null;
        public ProjectsController(AppDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Project> data = await db.Projects.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            Project pj = await db.Projects.FindAsync(id);
            return Ok(pj);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Project pj)
        {
            if (ModelState.IsValid)
            {
                await db.Projects.AddAsync(pj);
                await db.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = pj.ProjectID }, pj);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody]Project pj)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Update(pj);
                await db.SaveChangesAsync();
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Project pj = await db.Projects.FindAsync(id);
            db.Projects.Remove(pj);
            await db.SaveChangesAsync();
            return NoContent();
        }

    }
}