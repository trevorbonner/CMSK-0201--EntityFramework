// See https://aka.ms/new-console-template for more information
using Core.Entities;
using EntityFrameworkDay3;

var course = new Course();
course.CourseTitle = "1234";
course.CourseDescription = "Test";
course.CourseSchedules.Add(new CourseSchedule());

var context =  new DayThreeContext();
context.Courses.Add(course);

context.SaveChanges();


var courses = context.Courses;
var schedules = context.CourseSchedules;

Console.ReadLine();
