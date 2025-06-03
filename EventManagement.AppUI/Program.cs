using EventManagement.DAL.Models;
using EventManagement.DAL.Repositories;

var repo = new EventRepository();

while (true)
{
    Console.WriteLine("\nMenu:\n1. Add Event\n2. View All\n3. Get by ID\n4. Update\n5. Delete\n6. Exit");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            var evt = new EventDetails {
                EventName = "Tech Conference",
                EventCategory = "Technology",
                EventDate = DateTime.Now.AddDays(10),
                Status = "Active"
            };
            repo.Add(evt);
            Console.WriteLine("Event Added");
            break;
        case "2":
            foreach (var e in repo.GetAll()) Console.WriteLine($"{e.EventId} - {e.EventName}");
            break;
        case "3":
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            var e1 = repo.Get(id);
            Console.WriteLine($"{e1?.EventId} - {e1?.EventName}");
            break;
        case "4":
            Console.Write("Enter ID to Update: ");
            int uid = int.Parse(Console.ReadLine());
            var toUpdate = repo.Get(uid);
            if (toUpdate != null)
            {
                toUpdate.EventName = "Updated Name";
                repo.Update(toUpdate);
                Console.WriteLine("Updated.");
            }
            break;
        case "5":
            Console.Write("Enter ID to Delete: ");
            int did = int.Parse(Console.ReadLine());
            repo.Delete(did);
            Console.WriteLine("Deleted.");
            break;
        case "6":
            return;
    }
}
