// See https://aka.ms/new-console-template for more information
using Domain;
using EntityFrameworkDay2;

using var db = new Day2DataContext();

var course = new Course();
course.Name = "Test Course";
//db.Courses.Add(course);
//db.SaveChanges();
var courses = db.Courses;
Console.ReadLine();
