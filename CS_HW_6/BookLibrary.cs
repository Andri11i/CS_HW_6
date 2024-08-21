using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_6
{
    class BookLibrary
    {
        private Hashtable books = new Hashtable();

        public void AddBook(int code, string title)
        {
            books.Add(code, title);
        }

        public void RemoveBook(int code)
        {
            books.Remove(code);
        }

        public string GetBook(int code)
        {
            if (books.ContainsKey(code))
            {
                return (string)books[code];
            }
            return "Книгу не знайдено.";
        }

        public void PrintAllBooks()
        {
            Console.WriteLine("Всі книги у бібліотеці:");
            foreach (DictionaryEntry book in books)
            {
                Console.WriteLine($"Код: {book.Key}, Назва: {book.Value}");
            }
        }
    }
}
