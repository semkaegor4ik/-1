using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Library
    {
        private Fond periodica = new Fond();
        private Fond readingRoom = new Fond();
        private Fond subscription = new Fond();
        private Fond rareLiterature = new Fond();
        private List<Book> list = new List<Book>();

        public List<Book> ShowPeriodicaCatalog()
        {
            list.Clear();
            list.AddRange(periodica.ShowBooks());
            return list;
        }
        public List<Book> ShowReadingRoomCatalog()
        {
            list.Clear();
            list.AddRange(readingRoom.ShowBooks());
            return list;
        }
        public List<Book> ShowSubscriptionCatalog()
        {
            list.Clear();
            list.AddRange(subscription.ShowBooks());
            return list;
        }
        public List<Book> ShowRareLiteratureCatalog()
        {
            list.Clear();
            list.AddRange(rareLiterature.ShowBooks());
            return list;
        }

        public List<Book> ShowAllBooks()
        {
            list.Clear();
            list.AddRange(periodica.ShowBooks());
            list.AddRange(readingRoom.ShowBooks());
            list.AddRange(subscription.ShowBooks());
            list.AddRange(rareLiterature.ShowBooks());
            return list;
        }

        public List<Book> ShowPeriodicaAuthorBooks(String name)
        {
            list.Clear();
            list.AddRange(periodica.ShowAuthorBooks(name));
            return list;
        }
        public List<Book> ShowReadingRoomAuthorBooks(String name)
        {
            list.Clear();
            list.AddRange(readingRoom.ShowAuthorBooks(name));
            return list;
        }
        public List<Book> ShowSubscriptionAuthorBooks(String name)
        {
            list.Clear();
            list.AddRange(subscription.ShowAuthorBooks(name));
            return list;
        }
        public List<Book> ShowRareLiteratureAuthorBooks(String name)
        {
            list.Clear();
            list.AddRange(rareLiterature.ShowAuthorBooks(name));
            return list;
        }

        public List<Book> ShowAllAuthorBooks(String name)
        {
            list.Clear();
            list.AddRange(periodica.ShowAuthorBooks(name));
            list.AddRange(readingRoom.ShowAuthorBooks(name));
            list.AddRange(subscription.ShowAuthorBooks(name));
            list.AddRange(rareLiterature.ShowAuthorBooks(name));
            return list;
        }

        public void AddBookInPeriodica(Book book)
        {
            periodica.AddElem(book);
        }
        public void AddBookInReadingRoom(Book book)
        {
            readingRoom.AddElem(book);
        }
        public void AddBookInSubscription(Book book)
        {
            subscription.AddElem(book);
        }
        public void AddBookInRareLiterature(Book book)
        {
            rareLiterature.AddElem(book);
        }

        public void DeleteInfoInPeriodica()
        {
            periodica.DeleteInfo();
        }
        public void DeleteInfoInReadingRoom()
        {
            readingRoom.DeleteInfo();
        }
        public void DeleteInfoInSubscription()
        {
            subscription.DeleteInfo();
        }
        public void DeleteInfoInRareLiterature()
        {
            rareLiterature.DeleteInfo();
        }

        public void AddInfoInPeriodica(String info)
        {
            periodica.AddInfo(info);
        }
        public void AddInfoInReadingRoom(String info)
        {
            readingRoom.AddInfo(info);
        }
        public void AddInfoInSubscription(String info)
        {
            subscription.AddInfo(info);
        }
        public void AddInfoInRareLiterature(String info)
        {
            rareLiterature.AddInfo(info);
        }

        public bool DeleteBookInPeriodica(Book book)
        {
            return periodica.DeleteElem(book);
        }
        public bool DeleteBookInReadingRoom(Book book)
        {
            return readingRoom.DeleteElem(book);
        }
        public bool DeleteBookInSubscription(Book book)
        {
            return subscription.DeleteElem(book);
        }
        public bool DeleteBookInRareLiterature(Book book)
        {
            return rareLiterature.DeleteElem(book);
        }

        public String GetInfoInPeriodica()
        {
            return periodica.getInfo();
        }
        public String GetInfoInReadingRoom()
        {
            return readingRoom.getInfo();
        }
        public String GetInfoInSubscription()
        {
            return subscription.getInfo();
        }
        public String GetInfoInRareLiterature()
        {
            return rareLiterature.getInfo();
        }
    }
}
