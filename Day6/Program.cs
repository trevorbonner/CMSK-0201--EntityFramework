//CRUD
//Create - Inserting new rows
//Read - Getting records from database
//Update - Find an existing record and update anything but the ID
//Delete - Removing a record from the database
using Day6;

using Core.Entities;
using Day6.DataAccess;

//var repo = new Repo<Student>();
//var newStudent = new Student();
//newStudent.Age = 25;
//newStudent.Firstname = "John";
//newStudent.Lastname = "Smith";
////repo.Create(newStudent);
//newStudent.Id = 2;
//repo.Update(newStudent);
//var students = repo.Read(2);

//Console.WriteLine($"Firstname: {students.Firstname}, Lastname: {students.Lastname}");
//Delete(1);
//var students = repo.GetAll();
//Console.WriteLine(students.Count);
var studentRepo = new StudentRepo();
var repo = new Repo<Student>();


var accessService = new StudentDataAccessService(repo);

Console.ReadLine();


