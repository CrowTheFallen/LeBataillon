using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class AddGameV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('THOMA', 'sHardy@bataillonMail.com', '718-555-5555', 'Thomas', 's Hardy', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARIA', 'arsson@bataillonMail.com', '718-555-5555', 'Maria', 'arsson', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PETER', 'ranken@bataillonMail.com', '201-555-5555', 'Peter', 'ranken', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JOSE', 'rotti@bataillonMail.com', '718-555-5555', 'Jose', 'rotti', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('CARIN', 'Schmitt@bataillonMail.com', '718-555-5555', 'Carine', 'Schmitt', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HELVE', 'etiusNagy@bataillonMail.com', '718-555-5555', 'Helvetius', 'etius Nagy', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ELIZA', 'thLincoln@bataillonMail.com', '201-555-5555', 'Elizabeth', 'th Lincoln', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HANNA', 'aMoos@bataillonMail.com', '718-555-5555', 'Hanna', 'a Moos', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ZBYSZ', 'eniewicz@bataillonMail.com', '718-555-5555', 'Zbyszek', 'eniewicz', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('SERGI', 'tiérrez@bataillonMail.com', '718-555-5555', 'Sergio', 'tiérrez', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PALLE', 'Ibsen@bataillonMail.com', '718-555-5555', 'Palle', ' Ibsen', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MIGUE', 'Paolino@bataillonMail.com', '718-555-5555', 'Miguel', 'Paolino', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('LÚCIA', 'rvalho@bataillonMail.com', '718-555-5555', 'Lúcia', 'rvalho', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PEDRO', 'Afonso@bataillonMail.com', '718-555-5555', 'Pedro', 'Afonso', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PAUL', 'nriot@bataillonMail.com', '718-555-5555', 'Paul', 'nriot', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PIRKK', 'skitalo@bataillonMail.com', '201-555-5555', 'Pirkko', 'skitalo', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANNET', 'eRoulet@bataillonMail.com', '617-555-5555', 'Annette', 'e Roulet', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('CARLO', 'onzález@bataillonMail.com', '718-555-5555', 'Carlos', 'onzález', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('FELIP', 'quierdo@bataillonMail.com', '718-555-5555', 'Felipe', 'quierdo', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HORST', 'Kloss@bataillonMail.com', '718-555-5555', 'Horst', ' Kloss', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JANIN', 'Labrune@bataillonMail.com', '718-555-5555', 'Janine', 'Labrune', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MICHA', 'aelHolz@bataillonMail.com', '718-555-5555', 'Michael', 'ael Holz', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('RENE', 'llips@bataillonMail.com', '201-555-5555', 'Rene', 'llips', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PATRI', 'oSimpson@bataillonMail.com', '718-555-5555', 'Patricio', 'o Simpson', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('KARL', 'onski@bataillonMail.com', '718-555-5555', 'Karl', 'onski', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JYTTE', 'tersen@bataillonMail.com', '718-555-5555', 'Jytte', 'tersen', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANDRÉ', 'onseca@bataillonMail.com', '201-555-5555', 'André', 'onseca', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANN', 'evon@bataillonMail.com', '718-555-5555', 'Ann', 'evon', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('CHRIS', 'aBerglund@bataillonMail.com', '718-555-5555', 'Christina', 'a Berglund', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ALEXA', 'nderFeuer@bataillonMail.com', '201-555-5555', 'Alexander', 'nder Feuer', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ELIZA', 'bethBrown@bataillonMail.com', '718-555-5555', 'Elizabeth', 'beth Brown', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('FRAN', 'ilson@bataillonMail.com', '718-555-5555', 'Fran', 'ilson', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('EDUAR', 'Saavedra@bataillonMail.com', '718-555-5555', 'Eduardo', 'Saavedra', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('DOMIN', 'uePerrier@bataillonMail.com', '718-555-5555', 'Dominique', 'ue Perrier', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ISABE', 'Castro@bataillonMail.com', '203-555-5555', 'Isabel', ' Castro', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('GUILL', 'Fernández@bataillonMail.com', '718-555-5555', 'Guillermo', ' Fernández', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HENRI', 'Pfalzheim@bataillonMail.com', '718-555-5555', 'Henriette', ' Pfalzheim', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('GEORG', 'Pipps@bataillonMail.com', '718-555-5555', 'Georg', ' Pipps', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HOWAR', 'Snyder@bataillonMail.com', '718-555-5555', 'Howard', ' Snyder', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HELEN', 'ennett@bataillonMail.com', '201-555-5555', 'Helen', 'ennett', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('GIOVA', 'iRovelli@bataillonMail.com', '718-555-5555', 'Giovanni', 'i Rovelli', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('FRANC', 'iscoChang@bataillonMail.com', '201-555-5555', 'Francisco', 'isco Chang', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('HARI', 'Kumar@bataillonMail.com', '718-555-5555', 'Hari', 'Kumar', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JANET', 'Limeira@bataillonMail.com', '201-555-5555', 'Janete', 'Limeira', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('FRÉDÉ', 'queCiteaux@bataillonMail.com', '718-555-5555', 'Frédérique', 'que Citeaux', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JAIME', 'Yorres@bataillonMail.com', '212-555-5555', 'Jaime', 'Yorres', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('YOSHI', 'atimer@bataillonMail.com', '203-555-5555', 'Yoshi', 'atimer', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('SVEN', 'tlieb@bataillonMail.com', '201-555-5555', 'Sven', 'tlieb', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('RITA', 'üller@bataillonMail.com', '201-555-5555', 'Rita', 'üller', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PASCA', 'Cartrain@bataillonMail.com', '718-555-5555', 'Pascale', 'Cartrain', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('LIU', 'Wong@bataillonMail.com', '201-555-5555', 'Liu', 'Wong', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('VICTO', 'Ashworth@bataillonMail.com', '203-555-5555', 'Victoria', ' Ashworth', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ROLAN', 'Mendel@bataillonMail.com', '718-555-5555', 'Roland', ' Mendel', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('YANG', 'Wang@bataillonMail.com', '203-555-5555', 'Yang', ' Wang', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('YVONN', 'Moncada@bataillonMail.com', '201-555-5555', 'Yvonne', 'Moncada', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('YOSHI', 'namuri@bataillonMail.com', '718-555-5555', 'Yoshi', 'namuri', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('SIMON', 'owther@bataillonMail.com', '212-555-5555', 'Simon', 'owther', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARTÍ', 'Sommer@bataillonMail.com', '718-555-5555', 'Martín', ' Sommer', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PATRI', 'aMcKenna@bataillonMail.com', '718-555-5555', 'Patricia', 'a McKenna', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARIA', 'Anders@bataillonMail.com', '904-555-5555', 'Maria', 'Anders', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PAOLO', 'ccorti@bataillonMail.com', '718-555-5555', 'Paolo', 'ccorti', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MAURI', 'ioMoroni@bataillonMail.com', '718-555-5555', 'Maurizio', 'io Moroni', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARTI', 'neRancé@bataillonMail.com', '201-555-5555', 'Martine', 'ne Rancé', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MANUE', 'Pereira@bataillonMail.com', '203-555-5555', 'Manuel', 'Pereira', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARIO', 'Pontes@bataillonMail.com', '718-555-5555', 'Mario', 'Pontes', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARIE', 'rtrand@bataillonMail.com', '718-555-5555', 'Marie', 'rtrand', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MATTI', 'ttunen@bataillonMail.com', '718-555-5555', 'Matti', 'ttunen', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('MARY', 'veley@bataillonMail.com', '718-555-5555', 'Mary', 'veley', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PHILI', 'Cramer@bataillonMail.com', '201-555-5555', 'Philip', ' Cramer', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PAULA', 'arente@bataillonMail.com', '201-555-5555', 'Paula', 'arente', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('RENAT', 'Messner@bataillonMail.com', '614-555-5555', 'Renate', 'Messner', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('PAULA', 'Wilson@bataillonMail.com', '718-555-5555', 'Paula', 'Wilson', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('LAURE', 'eLebihan@bataillonMail.com', '201-555-5555', 'Laurence', 'e Lebihan', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('LINO', 'iguez@bataillonMail.com', '201-555-5555', 'Lino', 'iguez', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('LIZ', 'ixon@bataillonMail.com', '201-555-5555', 'Liz', 'ixon', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JEAN', 'nière@bataillonMail.com', '201-555-5555', 'Jean', 'nière', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('KARIN', 'osephs@bataillonMail.com', '203-555-5555', 'Karin', 'osephs', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JOSÉ', 'reyre@bataillonMail.com', '201-555-5555', 'José', 'reyre', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JOHN', 'Steel@bataillonMail.com', '201-555-5555', 'John', 'Steel', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('JONAS', 'ulfsen@bataillonMail.com', '718-555-5555', 'Jonas', 'ulfsen', 3)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANTON', 'oMoreno@bataillonMail.com', '718-555-5555', 'Antonio', 'o Moreno', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ARIA', 'Cruz@bataillonMail.com', '718-555-5555', 'Aria', ' Cruz', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ART', 'iger@bataillonMail.com', '', 'Art', 'iger', 2)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('BERNA', 'oBatista@bataillonMail.com', '201-555-5555', 'Bernardo', 'o Batista', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('CARLO', 'rnández@bataillonMail.com', '718-555-5555', 'Carlos', 'rnández', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('CATHE', 'rineDewey@bataillonMail.com', '203-555-5555', 'Catherine', 'rine Dewey', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('DANIE', 'Tonini@bataillonMail.com', '718-555-5555', 'Daniel', ' Tonini', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('DIEGO', 'oRoel@bataillonMail.com', '212-555-5555', 'Diego', 'o Roel', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ALEJA', 'draCamino@bataillonMail.com', '718-555-5555', 'Alejandra', 'dra Camino', 1)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANA', 'illo@bataillonMail.com', '718-555-5555', 'Ana', 'illo', 0)");
            migrationBuilder.Sql("INSERT INTO Players (NickName, Email, PhoneNumber, FirstName, LastName, Level) VALUES ('ANABE', 'omingues@bataillonMail.com', '201-555-5555', 'Anabela', 'omingues', 3)");
            migrationBuilder.Sql("INSERT INTO Teams (TeamName, CaptainId, JoueurMaximum ) VALUES ('Les Pros', 35, 7)");
            migrationBuilder.Sql("INSERT INTO Teams (TeamName, CaptainId, JoueurMaximum ) VALUES ('Super', 12, 12)");
            migrationBuilder.Sql("INSERT INTO Teams (TeamName, CaptainId, JoueurMaximum ) VALUES ('Winners', 21, 8)");
            migrationBuilder.Sql("INSERT INTO Teams (TeamName, CaptainId, JoueurMaximum ) VALUES ('Flowers', 66, 8)");
            migrationBuilder.Sql("INSERT INTO Teams (TeamName, CaptainId, JoueurMaximum ) VALUES ('Comets', 79, 10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
