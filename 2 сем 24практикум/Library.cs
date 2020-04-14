using System;
using System.Collections.Generic;
using System.Text;

namespace _2_сем_24практикум
{
    class Library
    {
        private Fond periodica = new Fond();
        private Fond readingRoom = new Fond();
        private Fond subscription = new Fond();
        private Fond rareLiterature = new Fond();

        public void ShowPeriodicaCatalog()
        {
            periodica.ShowBooks();
        }
        public void ShowReadingRoomCatalog()
        {
            readingRoom.ShowBooks();
        }
        public void ShowSubscriptionCatalog()
        {
            subscription.ShowBooks();
        }
        public void ShowRareLiteratureCatalog()
        {
            rareLiterature.ShowBooks();
        }

        public void ShowAllBooks()
        {
            periodica.ShowBooks();
            readingRoom.ShowBooks();
            subscription.ShowBooks();
            rareLiterature.ShowBooks();
        }

        public void ShowPeriodicaAuthorBooks(String name)
        {
            periodica.ShowAuthorBooks(name);
        }
        public void ShowReadingRoomAuthorBooks(String name)
        {
            readingRoom.ShowAuthorBooks(name);
        }
        public void ShowSubscriptionAuthorBooks(String name)
        {
            subscription.ShowAuthorBooks(name);
        }
        public void ShowRareLiteratureAuthorBooks(String name)
        {
            rareLiterature.ShowAuthorBooks(name);
        }

        public void ShowAllAuthorBooks(String name)
        {
            periodica.ShowAuthorBooks(name);
            readingRoom.ShowAuthorBooks(name);
            subscription.ShowAuthorBooks(name);
            rareLiterature.ShowAuthorBooks(name);
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
    }
}
