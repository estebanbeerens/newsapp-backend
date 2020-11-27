using AngularProjectAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjectAPI.Models
{
    public class DBInitializer
    {
        public static void Initialize(NewsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any user.
            if (context.Roles.Any())
            {
                return;   // DB has been seeded
            }

            context.Roles.AddRange(
              new Role { Name = "User" },
              new Role { Name = "Journalist" },
              new Role { Name = "Admin" });
            context.SaveChanges();

            context.Users.AddRange(
                new User { RoleID = 3, Username = "admin", Password = "admin", FirstName = "[Voornaam]", LastName = "[Achternaam]", Email = "admin@thomasmore.be" },
                new User { RoleID = 2, Username = "journalist", Password = "journalist", FirstName = "[Voornaam]", LastName = "[Achternaam]", Email = "journalist@thomasmore.be" },
                new User { RoleID = 1, Username = "user", Password = "user", FirstName = "[Voornaam]", LastName = "[Achternaam]", Email = "user@thomasmore.be" },
                new User { RoleID = 3, Username = "esteban.beerens", Password = "test123", FirstName = "Esteban", LastName = "Beerens", Email = "esteban.beerens@thomasmore.be" },
                new User { RoleID = 2, Username = "justin.michiels", Password = "test123", FirstName = "Justin", LastName = "Michiels", Email = "justin.michiels@thomasmore.be" },
                new User { RoleID = 1, Username = "bert.maes", Password = "test123", FirstName = "Bert", LastName = "Maes", Email = "bert.maes@thomasmore.be" },
                new User { RoleID = 1, Username = "jolien.schellekens", Password = "test123", FirstName = "Jolien", LastName = "Schellekens", Email = "jolien.schellekens@thomasmore.be" },
                new User { RoleID = 1, Username = "tina.taing", Password = "test123", FirstName = "Tina", LastName = "Taing", Email = "tina.taing@thomasmore.be" },
                new User { RoleID = 1, Username = "jeroen.verstraete", Password = "test123", FirstName = "Jeroen", LastName = "Verstraete", Email = "jeroen.verstraete@thomasmore.be" }
                );

            context.Tags.AddRange(
                new Tag { Name = "Sport" },
                new Tag { Name = "Film" },
                new Tag { Name = "Reizen" },
                new Tag { Name = "Games" }
                );

            context.ArticleStatuses.AddRange(
                new ArticleStatus { Name = "Draft" },
                new ArticleStatus { Name = "To review" },
                new ArticleStatus { Name = "Published" }
                );

            /*context.Articles.AddRange(
                new Article { UserID = 1, ArticleStatusID = 3, TagID = 1, Title = "Messi verlaat FC Barçelona", SubTitle = "Messi stuurde een fax met de boodschap dat hij wilt vertrekken.", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus consequat non justo dignissim varius. Morbi finibus magna non neque bibendum efficitur. Aliquam eu auctor sem, ut mollis erat. Donec ornare dolor ex, tincidunt blandit purus sodales id. Phasellus a hendrerit libero. Nunc eu ultrices libero. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer consequat egestas dui sit amet dignissim. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. In sit amet cursus elit, eu dignissim elit. Ut aliquam cursus urna ultricies rhoncus. Proin vitae neque erat. Sed mollis consectetur diam eget vestibulum." }
                );*/

            context.SaveChanges();
        }
    }
}
