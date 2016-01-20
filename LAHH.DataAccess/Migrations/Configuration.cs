namespace LAHH.DataAccess.Migrations
{
    using LLAH.Model;
    using LLAH.Model.Enum;
    using System;
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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //            

            context.User.AddOrUpdate(
                    new User() { Id = 1, Login = "leonfgama", Email = "leonfgama@hotmail.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Admin,},
                    new User() { Id = 2, Login = "sugama20", Email = "sugama20@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Teacher },
                    new User() { Id = 3, Login = "pai_do_lucas", Email = "pai_do_lucas@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Parent },
                    new User() { Id = 4, Login = "lucas.freitas", Email = "lucas.freitas@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.Student },
                    new User() { Id = 5, Login = "Adventista", Email = "adventista@yahoo.com", Password = "123", CreatedDate = DateTime.Now, LoginTryNumber = 0, UserType = UserType.School }
                    );

            context.Admin.AddOrUpdate(
                    new Admin() { Id = 1, Name = "Leon", LastName = "Bezerra", Birthday = new DateTime(1994, 11, 7), Genre = GenreType.Man, UserId = 1, CreatedDate = DateTime.Now }
                );

            context.Teacher.AddOrUpdate(
                    new Teacher() { Id = 1, Name = "Sueli", LastName = "Bezerra", Birthday = new DateTime(1962, 10, 3), Genre = GenreType.Woman, UserId = 2, CreatedDate = DateTime.Now }
                );

            context.Parent.AddOrUpdate(
                    new Parent() { Id = 1, Name = "Pai", LastName = "Freitas", Birthday = new DateTime(1962, 5, 10), Genre = GenreType.Man, UserId = 3, Cpf = "999.999.999-99", CreatedDate = DateTime.Now }
                );

            context.Student.AddOrUpdate(
                    new Student() { Id = 1, Name = "Lucas", LastName = "Freitas", Birthday = new DateTime(1993, 7, 11), Genre = GenreType.Man, UserId = 4, CreatedDate = DateTime.Now }
                );

            //context.StudentSchool.AddOrUpdate(
            //        new StudentSchool() { StudentId = 1, SchoolId = 1, CreatedDate = DateTime.Now }
            //    );

            //context.StudentParent.AddOrUpdate(
            //        new StudentParent() { StudentId = 1, ParentId = 1, CreatedDate = DateTime.Now }
            //    );

            context.School.AddOrUpdate(
                    new School() { Id = 1, Name = "Escola Adventista LTDA", PhoneNumber = 981244692, Cnpj = "86.931.541/0001-59", UserId = 5, CreatedDate = DateTime.Now, Locationid = 1 }
                );

            context.Location.AddOrUpdate(
                    new Location() { Id = 1, Street = "Rua Am�rico Falc�o", Number = 258, ZipCode = 05786010, CreatedDate = DateTime.Now }
                );
                
        }
    }
}
