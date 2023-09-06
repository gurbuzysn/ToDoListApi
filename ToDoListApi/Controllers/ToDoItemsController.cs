using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListApi.Data;

namespace ToDoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ToDoItemsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<ToDoItem> GetToDoItems()
        {
            return _db.ToDoItems.OrderBy(x => x.Done).ToList();
        }


        //api/ToDoItems/3
        [HttpGet("{id}")]
        public ActionResult<ToDoItem> GetToDoItem(int id)
        {
            var toDoItem = _db.ToDoItems.Find(id);

            if(toDoItem == null)
            {
                return NotFound();
            }

            return toDoItem;
        }


        [HttpPost]
        public ActionResult<ToDoItem> PostToDoItem(ToDoItem toDoItem)
        {
            if (ModelState.IsValid)
            {
                _db.Add(toDoItem);
                _db.SaveChanges();
                return CreatedAtAction(nameof(GetToDoItem),
                    new { id = toDoItem.Id }, toDoItem);
            }

            return BadRequest(ModelState);
        }


        // DELETE: api/ToDoItems/3
        [HttpDelete("{id}")]
        public IActionResult DeleteTodoItem(int id)
        {
            var toDoItem = _db.ToDoItems.Find(id);

            if (toDoItem == null)
                return NotFound();

            _db.Remove(toDoItem);  
            _db.SaveChanges();

            return NoContent();
        }


        [HttpPut("{id}")]
        public IActionResult PutToDoItem(int id, ToDoItem toDoItem)
        {
            if(id != toDoItem.Id)
                return BadRequest();

                
            if(!_db.ToDoItems.Any(x => x.Id == id))
                return NotFound();


            if(ModelState.IsValid)
            {
                _db.Update(toDoItem);
                _db.SaveChanges();
                return NoContent();
            }

            return BadRequest(ModelState);

        }


    }
}
