using System; // USINGS 

namespace AantekeningenLes1 // NAMESPACE
{
    // DIT ZIJN AANTEKENINGEN VOOR EEN HERHALINGSUITLEG C#.

    // SCOPE: DE SCOPE IS AT ER TUSSEN DE ACCOLADE'S ZIT: {}. SCOPES KUNNEN IN ELKAAR ZITTEN.


    class Program // CLASSES (CONTAINERS)
    {
        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 60);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeeeg = new Rectangle(0, 0, 50);
            Rectangle rechthoekBeeeg = new Rectangle(20, 30);

            vierkantBeeeg.MoveTo(50, 50);
            rechthoekBeeeg.Set(100, 100, 50, 60);
        }

        public class Rectangle
        {
            private float x, y, idth, height;

            // CONSTRUCTORS
            public Rectangle(float x, float y, float idth, float height)
            {
                this.x = x;
                this.y = y;
                this.idth = idth;
                this.height = height;
            }

            public Rectangle(float x, float y, float size)
            {
                this.x = x;
                this.y = y;
                this.idth = size;
                this.height = size;
            }

            public Rectangle(float idth, float height)
            {
                this.idth = idth;
                this.height = height;
            }

            // FUNCTIES 
            public void MoveTo(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public void Set(float x, float y, float idth, float height)
            {
                this.x = x;
                this.y = y;
                this.idth = idth;
                this.height = height;
            }

            public bool isSquare(float idth, float height)
            {
                bool square = false;

                if (this.idth == this.height)
                {
                    square = true;
                }

                return square;
            }

        }

        // JE KAN EXECUTABLES (.EXE) MAKEN VAN EEN C# PROJECT.
        // JE KAN OOK EEN DYNAMIC LINK LIBRARY (.DLL) MAKEN.

        // JE HEBT OOK EEN SOLUTION. DE SOLUTION IS ALLE ONDERDELEN VAN DE APPLICATIE.

        // BIN EN OBJECT DIRECTORY: DE BIN DIRECTORY IS DE OUTPUT DIRECTORY, DAAR HEB JE VAAK DE DEBUG DINGEN.
        // DEZE MOET JE NOOIT OP JE GITHUB ZETTEN! HET ZIJN GROTE, ONBELANGRIJKE FILES.

        // VOORBEELD GITIGNORE;



        // C# IS EEN TYPE LANGUAGE, ALES HEEFT DUS EEN TYPE. 

        // REFERENCE TYPES: CLASS, STRING, INTERFACE, ARRAY. DEZE IJZEN EIGENLIJK NAAR EEN PLEK IN HET GEHEUGEN.
        // ZE KUNNEN OOK NAAR DEZELFDE PLEK IN HET GEHEUGEN IJZEN.

        // VALUE TYPES: BOOL, INT, DOUBLE, FLOAT, BYTE, CHAR, STRUCT, ENUM.
        // DEZE KUNNEN NIET NAAR HETZELFDE GEHEUGEN IJZEN.



        // CLASSES

        // ANNEER GEBRUIK JE CLASSES:
        // BIJV. OM DINGEN TE MODELLEREN, AUTO'S, ENEMIES, ITEMS. (REFERENCE TYPES).

        // INSTANCES MAKEN: DAN MAAK JE EEN INSTANCE VAN EEN CLASS.
        // ANNEER JE DE CONSTRUCTOR VAN EEN CLASS AANROEPT, MAAK JE DUS EEN NIEUE INSTANTIE.
        // BIJV. Auto auto1 = ne Auto();

        // JE KAN OOK ZEGGEN Auto auto;, DAN ORDT DE AARDE NULL. JE KAN ER LATER EEN AARDE AAN TOEVOEGEN.

        // JE KAN FIELDS EN PROPERTIES HEBBEN OM DINGEN BIJ TE HOUDEN, ZOALS MERK EN KLEUR VAN DE AUTO.



        // SYNTAX SUGAR: DAT BETEKENT DAT AT JE SCHRIJFT, EIGENLIJK NIET IS AT ER IN DE COMPILER KOMT. 



        // OEFENING: MAAK EEN RECTANGLE CLASS. GEEF DE VOLGENDE CONSTRUCTORS:

        //(X,IDTH,HEIGHT)
        //(X,SIZE)
        //(IDTH,HEIGHT)
        //(SIZE)

        // DE CLASS HEEFT EEN X,Y, IDTH EN HEIGHT FIELD ELKE PRIVATE IS (ZIE SPECIES VAN BIRD CLASS IN DE PRESENTATIE)
    }
}
