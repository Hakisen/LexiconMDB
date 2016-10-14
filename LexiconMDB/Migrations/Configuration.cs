
namespace LexiconMDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconMDB.DAL;
    using LexiconMDB.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMDB.DAL.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconMDB.DAL.MovieDBContext context)
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

            context.Movies.AddOrUpdate(
                m => m.Title,
                new Movie
                {
                    Title = "Return of the killing tomatoes",
                    Length = 90,
                    Genre = Genre.Horror,
                    AgeLimit = 15,
                    MetaScore = 7
                },
            new Movie
            {
                Title = "Programmer Academy",
                Length = 110,
                Genre = Genre.Comedy,
                AgeLimit = 12,
                MetaScore = 16
            },
            new Movie
            {
                Title = "Finalizer 7",
                Length = 95,
                Genre = Genre.Action,
                AgeLimit = 15,
                MetaScore = 57
            },
            new Movie
            {
                Title = "The Lord of the Rings",
                Length = 205,
                Genre = Genre.Action,
                AgeLimit = 11,
                MetaScore = 91
            });
        }
    }
}
