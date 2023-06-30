using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeDemoProject.Models;

namespace EmployeeDemoProject.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> lstEmps = Employee.GetAllEmployees();
            return View(lstEmps);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {         
            Employee emp = Employee.GetSingleEmployee(ViewBag.Id = id);
            return View(emp);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                int count = Employee.InsertEmployee(emp);

                if(count> 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
                
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp = Employee.GetSingleEmployee(ViewBag.Id = id);
            return View(emp);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                int count = Employee.Update(emp);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.alert("Failed to Update");
                    return RedirectToAction(nameof(Edit));
                    
                }
                 
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = Employee.GetSingleEmployee(ViewBag.Id = id);
            return View(emp);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Employee obj)
        {
            try
            {
                int count = Employee.Delete(id);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.alert("Failed to delete");
                    return RedirectToAction(nameof(Delete));
                   
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
