using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Models.Entities;
using mvc.Data;
using Microsoft.EntityFrameworkCore;

namespace mvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: Student/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: Student/Add
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            // Create a new Student object from the viewModel
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
            };

            // Add the student to the database
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            // Redirect to the List action method to show the updated list of students
            return RedirectToAction("List");
        }

        // GET: Student/List
        [HttpGet]
        public async Task<IActionResult> List()
        {
            // Retrieve all students from the database
            var students = await dbContext.Students.ToListAsync();

            // Pass the list of students to the view
            return View(students);
        }

        // GET: Student/Edit/Id
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            // Find the student with the specified Id in the database
            var student = await dbContext.Students.FindAsync(Id);

            // Pass the student object to the view for editing
            return View(student);
        }

        // POST: Student/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            // Find the student with the specified Id in the database
            var student = await dbContext.Students.FindAsync(viewModel.Id);
            if (student != null)
            {
                // Update the student's properties with the values from the viewModel
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                await dbContext.SaveChangesAsync();
            }

            // Redirect to the List action method to show the updated list of students
            return RedirectToAction("List");
        }

        // POST: Student/Delete/Id
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            // Find the student with the specified Id in the database
            var student = await dbContext.Students.FindAsync(Id);
            if (student != null)
            {
                // Remove the student from the database
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }

            // Redirect to the List action method to show the updated list of students
            return RedirectToAction("List");
        }
    }
}
