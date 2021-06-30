using System;
using System.Linq;
using System.Threading.Tasks;
using EventManager.AspMvc.Models.EventManager;
using EventManager.Contracts.Persistence.EventManager;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.AspMvc.Controllers
{
    public class EventController : GenericModelController<IEvent, Event>
    {
        /*
        public async Task<IActionResult> Index()
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entities = await ctrl.GetAllAsync().ConfigureAwait(false);

            return View(entities.Select(e => ToModel(e)));
        }
        */

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.CreateAsync().ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Event model)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();

            await ctrl.InsertAsync(model).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            Console.WriteLine(id);
            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Event model)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.GetByIdAsync(model.Id).ConfigureAwait(false);

            if (entity != null)
            {
                entity.StartingAt = model.StartingAt;
                entity.EndingAt = model.EndingAt;
                entity.Name = model.Name;
                entity.Description = model.Description;

                await ctrl.UpdateAsync(entity).ConfigureAwait(false);
                await ctrl.SaveChangesAsync().ConfigureAwait(false);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        //[HttpDelete]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();

            await ctrl.DeleteAsync(id).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }
    }
}
