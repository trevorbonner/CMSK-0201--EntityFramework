// See https://aka.ms/new-console-template for more information

using Data.Entities;
using Day8;
using Microsoft.EntityFrameworkCore;

var context = new DataContext();

var student = new Student();
student.Name = "Test 1";
student.Age = 33;

var address1 = new Address();
address1.EmailAddress = "Test@test.ca";

var address2 = new Address();
address2.EmailAddress = "Test1@test.ca";
address2.IsActive = true;

student.Addresses.Add(address1);
student.Addresses.Add(address2);

context.Students.Add(student);

//context.SaveChanges();

var studentFound = context.Students.Include(x => x.Addresses).FirstOrDefault();

var addressess = context.Addresses;


Console.ReadLine();
