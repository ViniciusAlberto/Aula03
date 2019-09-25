using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookStore.Models;
using System.Collections.Generic;
    public static class DataFake
    {
        enum OrderStatus { Paid = 1, New = 2 , Delivered = 3, Canceled = 4, Approved = 5 , AwaitingPayment= 6 };
        public static List<Book> Books ()
        {
            List<Book> book = new List<Book>();

            var book1 = new Book()
            {
                Id = 1,
                Title = "Livro 1",
                Genre = "Anime",
                DatePublish = DateTime.Now.AddYears(-10),
                Count = 20,
                Price = 9.99
            };
            
            var book2 = new Book()
            {
                Id = 2,
                Title = "Livro 2",
                Genre = "Education",
                DatePublish = DateTime.Now.AddYears(-3),
                Count = 5,
                Price = 49.99
            };
            
            var book3 = new Book()
            {
                Id = 3,
                Title = "Livro 3",
                Genre = "Romantic",
                DatePublish = DateTime.Now.AddYears(-25),
                Count = 2,
                Price = 29.99
            };
            
            var book4 = new Book()
            {
                Id = 4,
                Title = "Livro 4",
                Genre = "Anime",
                DatePublish = DateTime.Now.AddYears(-1),
                Count = 120,
                Price = 19.99
            }; 

            book.Add(book1);
            book.Add(book2);
            book.Add(book3);
            book.Add(book4);

            return book;
        } 

        public static  List<Commentary> Commentarys () 
        {
            List<Commentary> commentary = new List<Commentary>();

            var commentary1 = new Commentary()
            {
                IdBook = 1,
                Description = "Otimo Livro",
                IdUsuario = 1,
                DateCommentary = DateTime.Now.AddDays(-9)                 
            };
            var commentary2 = new Commentary()
            {
                IdBook = 2,
                Description = "Excelente custo beneficios Livro",
                IdUsuario = 1,
                DateCommentary = DateTime.Now.AddDays(-1)                 
            };
            var commentary3 = new Commentary()
            {
                IdBook = 3,
                Description = "Pessimo Livro",
                IdUsuario = 2,
                DateCommentary = DateTime.Now                 
            };
            var commentary4 = new Commentary()
            {
                IdBook = 2,
                Description = "Bom Livro",
                IdUsuario = 3,
                DateCommentary = DateTime.Now.AddDays(-30)                 
            };

            commentary.Add(commentary1);
            commentary.Add(commentary2);
            commentary.Add(commentary3);
            commentary.Add(commentary4);

            return commentary;
        }

        public static List<User> Users()
        {
            List<User> user = new List<User>();

            var user1 = new User()
            {
                Id=1,
                Name = "Vinicius"
            };
            var user2 = new User()
            {
                Id=2,
                Name = "Marco Mendes"
            };
            var user3 = new User()
            {
                Id=3,
                Name = "João"
            };
             var user4 = new User()
            {
                Id=4,
                Name = "Maria"
            };
            
            user.Add(user1);
            user.Add(user2);
            user.Add(user3);
            user.Add(user4);

            return user;
        }

        public static List<Order> Orders()
        {
            List<Order> order = new List<Order>();

            var order1 = new Order()
            {
                Id =1,
                IdClient = 1,
                IdBook = 1,
                Count = 2,
                Price = 19.98,
                IdStatus = (long)OrderStatus.Approved            
            };

             var order2 = new Order()
            {
                Id =2,
                IdClient =1 ,
                IdBook = 3,
                Count = 1,
                Price = 29.99,
                IdStatus = (long)OrderStatus.New            
            };
             var order3 = new Order()
            {
                Id =3,
                IdClient = 2,
                IdBook = 4,
                Count = 2,
                Price = 39.98,
                IdStatus = (long)OrderStatus.Delivered            
            };
             var order4 = new Order()
            {
                Id =4,
                IdClient = 3,
                IdBook = 2,
                Count = 1,
                Price = 49.99,
                IdStatus = (long)OrderStatus.Canceled            
            };

            order.Add(order1);
            order.Add(order2);
            order.Add(order3);
            order.Add(order4);

            return order;
        }
    
}