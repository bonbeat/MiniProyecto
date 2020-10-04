namespace MiniProyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeds : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Albums (Nombre, Status) Values ('Album 1', 'Disponible')");
            Sql("INSERT INTO Albums (Nombre, Status) Values ('Album 2', 'Disponible')");
            Sql("INSERT INTO Albums (Nombre, Status) Values ('Album 3', 'No Disponible')");
            Sql("INSERT INTO Albums (Nombre, Status) Values ('Album 4', 'Disponible')");

            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/564x/b0/05/5f/b0055f0c7fccd6f360eea09234f39900.jpg', 1)");
            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/236x/3d/1b/4b/3d1b4bc81a7d952b6fd7ba2aef0680bc.jpg', 1)");
            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/564x/b2/07/aa/b207aa6f2981c17f2e668cc63d5b58e6.jpg', 2)");
            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/236x/ae/c8/1d/aec81d34ade3349eb0ef01327a4b27d5.jpg', 2)");
            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/236x/98/1a/09/981a090aec11643e200890ed24c317d0.jpg', 3)");
            Sql("INSERT INTO Photos (Url, Album_Id) Values ('https://i.pinimg.com/236x/81/a3/3e/81a33e1056c77edf16017b87364e8190.jpg', 4)");

            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Me gustó mucho', 1)");
            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Pienso que le faltó creatividad', 2)");
            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Excelente', 3)");
            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Me encantó', 4)");
            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Excelente', 5)");
            Sql("INSERT INTO Comments (Description, Photo_Id) Values ('Me encantó', 6)");

        }
        
        public override void Down()
        {
        }
    }
}
