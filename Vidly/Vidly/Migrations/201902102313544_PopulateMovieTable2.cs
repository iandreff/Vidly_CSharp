namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId,ReleaseDate, DateAdded, NumberInStock) VALUES (1,'Hangover', 1, 2018-01-01, 2018-02-02, 10)");
            Sql("INSERT INTO Movies (Id, Name, GenreId,ReleaseDate, DateAdded, NumberInStock) VALUES (2,'Die Hard', 2, 2018-12-12, 2018-11-11, 20)");
            Sql("INSERT INTO Movies (Id, Name, GenreId,ReleaseDate, DateAdded, NumberInStock) VALUES (3,'The Terminator', 2, 2018-07-07, 2018-08-08, 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreId,ReleaseDate, DateAdded, NumberInStock) VALUES (4,'Toys story', 3, 2018-06-06, 2018-07-07, 9)");
            Sql("INSERT INTO Movies (Id, Name, GenreId,ReleaseDate, DateAdded, NumberInStock) VALUES (5,'Titanic', 4, 2018-05-05, 2018-04-04, 15)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}