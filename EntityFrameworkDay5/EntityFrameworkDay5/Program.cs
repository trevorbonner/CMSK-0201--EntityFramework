// See https://aka.ms/new-console-template for more information

using Domain.Entities;
using EntityFrameworkDay5;

var context = new DataContext();
//var parent1 = new Parent();
//context.Parents.Add(parent1);
//var parentID = context.Parents.FirstOrDefault().Id;

//var child1 = new ChildLayerOne();
//child1.ParentId = parentID;

//var newChild = new ChildLayerOne()
//{
//    Parent = new Parent()
//};

//context.ChildLayerOnes.Add(newChild);

//var layerOne = context.ChildLayerOnes.FirstOrDefault();
//var child = new ChildLayerTwo();
//child.ChildLayerOneId = layerOne.Id;

//context.ChildLayerTwos.Add(child);

//context.SaveChanges();

//child = context.ChildLayerTwos.FirstOrDefault();
//Console.WriteLine($"ID: {child.Id}, ParentId: {child.ChildLayerOneId}, GrandParentId: {child.ChildLayerOne.Parent.Id}");
//foreach (var child in context.ChildLayerOnes)
//{
//    Console.WriteLine($"ID: {child.Id}, ParentId: {child.ParentId}");
//}

//foreach(var parent in context.Parents)
//{
//    var layerOne = context.ChildLayerOnes.Where(x => x.ParentId == parent.Id).ToList();
//    Console.WriteLine($"Parent.Id: {parent.Id}");
//    foreach(var layerOneChild in layerOne)
//    {
//        var layerTwo = context.ChildLayerTwos.Where(x => x.ChildLayerOneId == layerOneChild.Id);
//        Console.WriteLine($"Parent.Id: {parent.Id}, ChildLayerOne.Id: {layerOneChild.Id}");

//        foreach(var layerTwoChild in layerTwo)
//        {
//            Console.WriteLine($"Parent.Id: {parent.Id}, ChildLayerOne.Id: {layerOneChild.Id}, ChildLayerTwo.Id: {layerTwoChild.Id}");
//        }
//    }
//}

var parentId = context.Parents.FirstOrDefault().Id;
var layerOneId = context.ChildLayerOnes.FirstOrDefault().Id;

var offShoot = new OffShoot();
offShoot.ParentId = parentId;
offShoot.ChildLayerOneId = layerOneId;

context.OffShoots.Add(offShoot);

context.SaveChanges();

var savedOffshoot = context.OffShoots.FirstOrDefault();
Console.WriteLine($"OffShootID:{savedOffshoot.Id}, ParentFK: {savedOffshoot.ParentId}, ChildLayerOneId:{savedOffshoot.ChildLayerOneId}");

Console.ReadLine();
