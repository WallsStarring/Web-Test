using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Test.Models.Pachacamac;

namespace Web_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PachacamacController : ControllerBase
    {
        private readonly PachacamacContext _context;

        public PachacamacController(PachacamacContext context)
        {
            _context = context;
        }

        //Get Pedidos
        [HttpGet]
        public async Task<ActionResult<Pedidos>> GetPedidos() {
            var a=_context.Pedidos
                .Include(a=>a.DetPeds)
                .OrderByDescending(x=>x.Id)
                .Take(5)
                .ToList();
            return Ok(a);
        }
        [HttpGet("clientes")]
        public async Task<ActionResult<Clientes>> GetClientes() {
            var a = _context.Clientes
                .OrderByDescending(a => a.Id)
                .Take(5)
                .ToListAsync();
            return Ok(await a);
         }
        [HttpGet("empleados")]
        public async Task<ActionResult<Empleados>> GetEmpleados()
        {
            var a = _context.Empleados
                .OrderByDescending(a => a.Id)
                .Take(5)
                .ToListAsync();
            return Ok(await a);
        }
        [HttpGet("pruductos")]
        public async Task<ActionResult<Productos>> GetProductos()
        {
            var a = _context.Productos
                .ToListAsync();
            return Ok(await a);
        }
    }
}