using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Initializer.DataFixtures
{


    public static class SampleData
    {


        public static string[] names = new string[]{

"Magen",
"Mariella",
"Tonita",
"Marcella",
"Conrad",
"Antonetta",
"Nicholas",
"Pierre",
"Derick",
"Barbie",
"Debi",
"Rosetta",
"Adrian",
"Marlon",
"Pat",
"Cathryn",
"Ralph",
"Emely",
"Troy",
"Steven",
"Vi",
"Simonne",
"Alejandro",
"Angelina",
"Marcie",
"Sheryl",
"Jane",
"Berniece",
"Dina",
"Sherlene",
"Adell",
"Tyson",
"Bianca",
"Sheridan",
"Leida",
"Johana",
"Ernestine",
"Krissy",
"Eugenie",
"Palmira",
"Jamal",
"Eugenio",
"Arielle",
"Tad",
"Marcell",
"Roma",
"Sherise",
"Jeanetta",
"Liliana",
"Gertie"

}
        ;


        public static string[] zipCodes = new string[]{
"N2Z 6A2, Kincardine, ON"
,"T1V 3L7, High River, AB"
,"E9E 4L4, Red Bank, NB"
,"V3H 0M6, Port Moody, BC"
,"L7E 6N2, Bolton, ON"
,"H7P 4S8, Fabreville, QC"
,"T4V 4P8, Camrose, AB"
,"B3E 2N6, Porters Lake, NS"
,"E5H 1B2, Pennfield, NB"
,"G0R 3R3, Appalaches, QC"
,"H9K 6V8, Senneville, QC"
,"G7P 6A1, Saint-Ambroise, QC"
,"J9V 1P6, Ville-Marie, QC"
,"E7B 9B3, Saint-Jacques, NB"
,"T1M 0J0, Coaldale, AB"
,"H7Y 5E1, Îles-Laval, QC"
,"N8N 9C1, Tecumseh Outskirts, ON"
,"E5B 0A3, St. Andrews, NB"
,"T7A 7Y0, Drayton Valley, AB"
,"G3M 4N7, Donnacona, QC"
,"V8B 6E0, Squamish, BC"
,"K7S 8C9, Arnprior, ON"
,"E6G 3E2, Nackawic, NB"
,"E6G 9J5, Nackawic, NB"
,"V1K 5R6, Merritt, BC"
,"V3A 5K9, Langley City, BC"
,"V8J 0C3, Prince Rupert, BC"
,"B4H 0V9, Amherst, NS"
,"T1P 7N7, Strathmore, AB"
,"E1J 7A1, Coverdale, NB"
,"E5R 8H4, St. Martins, NB"
,"L9H 3C0, Dundas, ON"
,"E4G 1N5, Smiths Creek, NB"
,"E8B 7N9, Kedgwick, NB"
,"N0N 8G8, Lambton, ON"
,"H3J 2L2, Petite-Bourgogne, QC"
,"J1S 5K1, Windsor, QC"
,"G9X 2H4, La Tuque, QC"
,"S2V 1A1, Buena Vista, SK"
,"N3W 2S0, Caledonia, ON"
,"E4B 5G8, Minto, NB"
,"L6A 5H7, Maple, ON"
,"J7M 1G8, La Plaine, QC"
,"H8R 7E0, Saint-Pierre, QC"
,"J5X 3K0, L'Épiphanie, QC"
,"E1B 4B8, Riverview, NB"
,"X0C 9V4, Inner Nunavut, NU"
,"V9K 3H0, Qualicum Beach, BC"
,"T4C 1M1, Cochrane, AB"
,"E5P 3X1, Apohaqui, NB"
,"T1V 2N2, High River, AB"
,"E6G 5P4, Nackawic, NB"
,"E5T 9V1, Norton, NB"
,"S3N 9B2, Yorkton, SK"
,"G6C 2B4, Pintendre, QC"
,"H7R 6L7, Laval-sur-le-Lac, QC"
,"G7B 6H9, La Baie, QC"
,"N0B 6J1, Wellington, ON"
,"L9R 2X9, Alliston, ON"
,"H9W 2L3, Beaconsfield, QC"
,"T4S 3T9, Sylvan Lake, AB"
,"V0L 5K2, Chilcotin, BC"
,"J5A 2L4, Saint-Constant, QC"
,"L4R 4G4, Midland, ON"
,"H9S 1X6, L'Île-Dorval, QC"
,"H3J 9B1, Petite-Bourgogne, QC"
,"B9A 6R1, Port Hawkesbury, NS"
,"S3N 3X1, Yorkton, SK"
,"K6T 6L3, Elizabethtown, ON"
,"H7N 2L5, Laval-des-Rapides, QC"
,"V8A 0N0, Powell River, BC"
,"B3T 7K7, Lakeside, NS"
,"B1X 8S0, Big Bras d'Or, NS"
,"J5V 7V4, Louiseville, QC"
,"B3E 4E8, Porters Lake, NS"
,"E9C 8Y4, Doaktown, NB"
,"H7L 6B9, Sainte-Rose, QC"
,"P5N 1H3, Kapuskasing, ON"
,"J0T 9R5, Laurentides-Nord, QC"
,"B4V 9R3, Bridgewater, NS"
,"H4C 0X1, Saint-Henri, QC"
,"J9E 9C7, Maniwaki, QC"
,"K4P 2M8, Greely, ON"
,"H9R 4R4, Pointe-Claire, QC"
,"E4G 5A0, Smiths Creek, NB"
,"G4X 8P5, Gaspé, QC"
,"A1Y 1R6, Carbonear, LB"
,"V5K 7H8, Vancouver, BC"
,"K7K 6X8, Kingston, ON"
,"B4V 7G7, Bridgewater, NS"
,"V9P 2B0, Parksville, BC"
,"X0C 5X5, Inner Nunavut, NU"
,"K8R 1K4, Belleville, ON"
,"K4C 2T3, Cumberland, ON"
,"J4B 8L3, Boucherville, QC"
,"V9C 7R6, Metchosin, BC"
,"N5C 7V5, Ingersoll, ON"
,"V1A 8B8, Kimberley, BC"
,"B5A 0C4, Yarmouth, NS"
,"K8H 2K5, Petawawa, ON"
,"R6M 4V4, Morden, MB"
,"V9Y 2N8, Port Alberni, BC"
,"E8M 7K9, Saint-Isidore, NB"
,"T4S 3R1, Sylvan Lake, AB"
,"J8A 9B2, Saint-Hippolyte, QC"
,"E8T 4G8, Lamèque, NB"
,"E4W 3B2, Richibucto, NB"
,"T4C 8H1, Cochrane, AB"
,"E3E 0G3, Kingsclear, NB"
,"E4R 0N2, Cocagne, NB"
,"V9X 9V4, Cedar, BC"
,"T9C 9P5, Vegreville, AB"
,"V1K 2S6, Merritt, BC"
,"E4G 6C4, Smiths Creek, NB"
,"E3L 5R9, St. Stephen, NB"
,"L6A 2N0, Maple, ON"
,"S2V 8G7, Buena Vista, SK"
,"P2B 8K7, Sturgeon Falls, ON"
,"P9A 9N0, Fort Frances, ON"
,"G8H 2Y3, Roberval, QC"};

        public static string[] streetNames = new string[]{
"Rosemary Lane"
,"Chantry Close"
,"West Road"
,"Swallow Close"
,"St John's Road"
,"Ashfield Road"
,"Cedar Close"
,"Eastern Avenue"
,"The Pastures"
,"Walton Road"
,"South Drive"
,"The Lane"
,"Elizabeth Close"
,"Shaw Street"
,"Cliff Road"
,"Coronation Avenue"
,"South Close"
,"Adelaide Street"
,"Thomas Street"
,"Cherry Close"
,"Hamilton Road"
,"Poppy Close"
,"Willow Close"
,"Manor Gardens"
,"Grosvenor Road"
,"Rydal Close"
,"Willow Road"
,"Bluebell Close"
,"Birch Avenue"
,"The Poplars"
,"Church Walk"
,"Nelson Street"
,"The Ridgeway"
,"Sutton Road"
,"Woodfield Road"
,"Willow Lane"
,"Willow Drive"
,"The Broadway"
,"Henry Street"
,"Milton Close"
,"Westgate"
,"Market Square"
,"Maple Grove"
,"Cornwall Road"
,"Beech Grove"
,"Brighton Road"
,"Ruskin Avenue"
,"Mansfield Road"
,"The Meadows"
,"Fern Close"};

        public static string[] countries = new string[] { "Canada" };

        public static string[] lastNames = new string[]{

"Albro"
,"Dragstrup"
,"Loktu"
,"Kalvee"
,"Siukoski"
,"Rovanola"
,"Akssandur"
,"Ísafholt"
,"Jaunli"
,"Kulli"
,"Jonkruojis"
,"Lazmerge"
,"Steinstrand"
,"Breksos"
,"Vadtälje"
,"Norrviken"
,"Lystrup"
,"Ulhus"
,"Haapsa"
,"Mõisali"
,"Kalatee"
,"Nittinen"
,"Hókrókur"
,"Ólafsholt"
,"Ketne"
,"Salkile"
,"Kedainkai"
,"Balniai"
,"Brønnøyden"
,"Hammervåg"
,"Kungstuna"
,"Enbo"
,"Clarehurst"
,"Reidcoln"
,"Flatwood"
,"Nuugaatrapaluk"
,"Uummanqaq"
,"Eqalunavik"
,"Ixtatla"
,"Apatcruz"
,"Guasabaro"
,"Mensmere"
,"Boswood"
,"Canding"};

        public static string GeneratePhoneNumber(int seedData)
        {

            var r = new Random(seedData);
            return $"{r.Next(1, 9)}{r.Next(1, 9)}{r.Next(1, 9)}-{r.Next(1, 9)}{r.Next(1, 9)}{r.Next(1, 9)}-{r.Next(1, 9)}{r.Next(1, 9)}{r.Next(1, 9)}{r.Next(1, 9)}";

        }

        public static string GenerateName(int seedData)
        {
            var random = new Random(seedData);
            return names[random.Next(0, names.Length - 1)];

        }

        public static string GenerateLastName(int seedData)
        {
            var random = new Random(seedData);
            return lastNames[random.Next(0, lastNames.Length - 1)];

        }

        public static PlayerLevel GenerateLevel()
        {

            Array values = Enum.GetValues(typeof(PlayerLevel));
            Random random = new Random();
            PlayerLevel randomLevel = (PlayerLevel)values.GetValue(random.Next(values.Length));
            return randomLevel;

        }

        public static decimal GenerateDecimal(int seedData, int minimum = 1, int maximimum = 10000)
        {

            var random = new Random(seedData);
            return (random.Next(minimum * 100, maximimum * 100) / 100.0m);
        }


        public static int GenerateInteger(int seedData, int minimum = 1, int maximimum = 10000)
        {

            var random = new Random(seedData);
            return (random.Next(minimum, maximimum));
        }


        public static string GenerateAddress(int seedData)
        {


            var el = string.Empty;
            var random = new Random(seedData);

            var zipCode = zipCodes[random.Next(0, zipCodes.Length - 1)].Split(',');
            var streetName = streetNames[random.Next(0, streetNames.Length - 1)];
            var streetNumber = random.Next(10, 5000);
            var streetLetter = random.Next(1, 10) % 2 == 0 ? "A" : "";
            var country = countries[random.Next(0, countries.Length - 1)];

            el = $@"{streetNumber}, {streetName}
{zipCode[1].Trim()} ({zipCode[2].Trim()})
{zipCode[0].Trim()} 
{country}
";

            return el;
        }




        public static decimal Round(decimal originalValue, int decimals)
        {
            if ((decimals < -28) || (decimals > 28))
                throw new ArgumentOutOfRangeException("decimals", "decimals : [-28, 28]");

            if (decimals >= 0)
                return decimal.Round(originalValue, decimals);

            decimal n = 10;

            while (decimals < -1) // 10^n. 
            { n = n * 10m; decimals++; }

            //321.12 avec -1, 32,121, round => 32,000 => 320,00 
            return decimal.Round(originalValue / n, 0) * n;
        }

    }






}


