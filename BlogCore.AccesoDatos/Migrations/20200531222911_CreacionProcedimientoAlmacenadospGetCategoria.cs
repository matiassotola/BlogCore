using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class CreacionProcedimientoAlmacenadospGetCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string loProcedimiento = @"CREATE PROCEDURE spGetCategorias 
                                    AS
                                    BEGIN	
	                                    SELECT * FROM Categoria
                                    END";
            migrationBuilder.Sql(loProcedimiento);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string loProcedimiento = @"DROP PROCEDURE spGetCategorias";
            migrationBuilder.Sql(loProcedimiento);
        }
    }
}
