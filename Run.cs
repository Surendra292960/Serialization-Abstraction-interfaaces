using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization.Serialization
{
    public class Run
    {
        public static void Main()
        {
            Run test = new Run();
            test.SerializeObject("XmlNamespaces.xml");
            Console.Read();
        }
        public void SerializeObject(string filename)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Books));
            TextWriter myWriter = new StreamWriter(filename);
            XmlSerializerNamespaces myNamespaces =
            new XmlSerializerNamespaces();
            myNamespaces.Add("books", "http://www.cpandl.com");
            myNamespaces.Add("money", "http://www.cohowinery.com");
            Book myBook = new Book();
            myBook.TITLE = "A Book Title";
            Price myPrice = new Price();
            myPrice.price = (decimal)9.95;
            myPrice.currency = "US Dollar";
            myBook.PRICE = myPrice;
            Books myBooks = new Books();
            myBooks.Book = myBook;
            mySerializer.Serialize(myWriter, myBooks, myNamespaces);
            myWriter.Close();
        }
    }

    public class Books
    {
        [XmlElement(Namespace = "http://www.cohowinery.com")]
        public Book Book;
    }

    [XmlType(Namespace = "http://www.cpandl.com")]
    public class Book
    {
        [XmlElement(Namespace = "http://www.cpandl.com")]
        public string TITLE;
        [XmlElement(Namespace = "http://www.cohowinery.com")]
        public Price PRICE;
    }
}
