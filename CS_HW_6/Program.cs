using CS_HW_6;


// тест телефонов
Console.WriteLine("=== ContactManager ===");
PhoneNumbers contactManager = new PhoneNumbers();
contactManager.AddContact("Alice", "+380671234567");
contactManager.AddContact("Bob", "+380671234568");
contactManager.PrintAllContacts();
Console.WriteLine(contactManager.GetContact("Bob"));
contactManager.RemoveContact("Alice");
contactManager.PrintAllContacts();

// тест студентов
Console.WriteLine("\n=== StudentManager ===");
Students studentManager = new Students();
studentManager.AddStudent("Alice");
studentManager.AddStudent("Bob");
studentManager.AddStudent("Charlie");
studentManager.SearchStudent("ar");
Console.WriteLine($"Кол-во студентов: {studentManager.GetStudentCount()}");
studentManager.RemoveStudent("Alice");
Console.WriteLine($"Кол-во студентов: {studentManager.GetStudentCount()}");

// тест очереди
Console.WriteLine("\n=== QueueManager ===");
QueueClass queueManager = new QueueClass();
queueManager.AddCustomer("Alice");
queueManager.AddCustomer("Bob");
queueManager.ServeCustomer();
Console.WriteLine($"Размер очереди: {queueManager.GetQueueCount()}");

// тест библиотеки
Console.WriteLine("\n=== LibraryManager ===");
BookLibrary libraryManager = new BookLibrary();
libraryManager.AddBook(1, "Electric State");
libraryManager.AddBook(2, "Tales from the Loop");
libraryManager.PrintAllBooks();
Console.WriteLine(libraryManager.GetBook(2));
libraryManager.RemoveBook(2);
libraryManager.PrintAllBooks();