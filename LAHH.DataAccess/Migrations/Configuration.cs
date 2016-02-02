namespace LAHH.DataAccess.Migrations
{
    using LLAH.Model;
    using LLAH.Model.Enum;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LAHH.DataAccess.LAHHDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LAHH.DataAccess.LAHHDataContext context)
        {
            var student1 = new Student() { Id = 1, Name = "Lucas", LastName = "Freitas", Birthday = new DateTime(1993, 7, 11), Genre = GenreType.Man, UserId = 4, CreatedDate = DateTime.Now, Parents = new List<Parent>() };
            var student2 = new Student() { Id = 2, Name = "André", LastName = "Freitas", Birthday = new DateTime(1993, 7, 11), Genre = GenreType.Man, UserId = 6, CreatedDate = DateTime.Now, Parents = new List<Parent>() };
            var parent1 = new Parent() { Id = 1, Name = "Pai", LastName = "Freitas", Birthday = new DateTime(1962, 5, 10), Genre = GenreType.Man, UserId = 3, Cpf = "999.999.999-99", CreatedDate = DateTime.Now, Students = new List<Student>() };

            parent1.Students.Add(student1);
            parent1.Students.Add(student2);

            context.User.AddOrUpdate(
                    new User() { Id = 1, Login = "leonfgama", Email = "leonfgama@hotmail.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Admin,},
                    new User() { Id = 2, Login = "sugama20", Email = "sugama20@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Teacher },
                    new User() { Id = 3, Login = "pai_do_lucas", Email = "pai_do_lucas@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Parent },
                    new User() { Id = 4, Login = "lucas.freitas", Email = "lucas.freitas@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Student },
                    new User() { Id = 5, Login = "Adventista", Email = "adventista@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.School },
                    new User() { Id = 6, Login = "andre.freitas", Email = "andre.freitas@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Student }
                    );

            context.Admin.AddOrUpdate(
                    new Admin() { Id = 1, Name = "Leon", LastName = "Bezerra", Birthday = new DateTime(1994, 11, 7), Genre = GenreType.Man, UserId = 1, CreatedDate = DateTime.Now }
                );

            context.Teacher.AddOrUpdate(
                    new Teacher() { Id = 1, Name = "Sueli", LastName = "Bezerra", Birthday = new DateTime(1962, 10, 3), Genre = GenreType.Woman, UserId = 2, CreatedDate = DateTime.Now }
                );

            context.Student.AddOrUpdate(
                    student1
                );

            context.Parent.AddOrUpdate(
                    parent1
                );

            context.School.AddOrUpdate(
                    new School() { Id = 1, Name = "Escola Adventista LTDA", PhoneNumber = 981244692, Cnpj = "86.931.541/0001-59", UserId = 5, CreatedDate = DateTime.Now, Locationid = 1 }
                );

            context.Location.AddOrUpdate(
                    new Location() { Id = 1, Street = "Rua Américo Falcão", Number = 258, ZipCode = 05786010, CreatedDate = DateTime.Now }
                );
                
        }
    }
}

