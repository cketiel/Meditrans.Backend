﻿using Meditrans.Shared.Entities;
using Meditrans.TripsService.Dtos;
using Meditrans.TripsService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Meditrans.TripsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpaceTypesController : ControllerBase
    {
        private readonly SpaceTypeService _service;

        public SpaceTypesController(SpaceTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<SpaceType>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SpaceType>> GetById(int id)
        {
            var spaceType = await _service.GetByIdAsync(id);
            if (spaceType == null) return NotFound();
            return spaceType;
        }

        [HttpPost]
        public async Task<ActionResult<SpaceType>> Create(SpaceTypeDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
