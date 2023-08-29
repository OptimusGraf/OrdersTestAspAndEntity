using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Models;

namespace Orders.Controllers
{
	public class OrderController : Controller
	{
		OrdersContext db;

		public OrderController(OrdersContext context)
		{
			this.db = context;
		}

		[Route("")]
		public IActionResult Home()
		{
			return View();
		}

		[HttpGet]
		[Route("MakeOrder")]
		public IActionResult NewOrder()
		{
			return View();
		}

		[HttpPost]
		[Route("MakeOrder")]
		public async Task<IActionResult> NewOrder(Order order)
		{
			db.Orders.Add(order);
			await db.SaveChangesAsync();
			return RedirectToAction("OrderReader", new { id = order.Id });
		}

		[Route("AllOrders")]
		public async Task<IActionResult> AllOrders()
		{
			return View(await db.Orders.ToListAsync());
		}
		[Route("Order/{id:int}")]
		public async Task<IActionResult> OrderReader(int id)
		{
			return View(await db.Orders.FirstAsync(o => o.Id == id));
		}

	}
}
