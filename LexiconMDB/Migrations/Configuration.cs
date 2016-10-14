//using LexiconMDB.DAL;

namespace LexiconMDB.Migrations
{
    using LexiconMDB.DAL;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMDB.DAL.MovieDbContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconMDB.DAL.MovieDbContent context)
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
                    Title = "Return of the killing Tomatoes",
                    Genre = Genre.Horror,
                    AgeLimit = 15,
                    Length = 90,
                    MetaScore = 7
                },
                 new Movie
                 {
                     Title = "Prgrammers comedy",
                     Genre = Genre.Comedy,
                     AgeLimit = 12,
                     Length = 120,
                     MetaScore = 20
                 },
                  new Movie
                  {
                      Title = "Programmers drama",
                      Genre = Genre.DramaComedy,
                      AgeLimit = 10,
                      Length = 110,
                      MetaScore = 25
                  },
                   new Movie
                   {
                       Title = "Programmers Action",
                       Genre = Genre.Action,
                       AgeLimit = 12,
                       Length = 115,
                       MetaScore = 16
                   },
                  new Movie
                  {
                      Title = "Finalizer",
                      Genre = Genre.Drama,
                      AgeLimit = 15,
                      Length = 100,
                      MetaScore = 57
                  });
        }
    }
}
