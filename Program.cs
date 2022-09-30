namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix = ChoisirOptionMenu();

            Console.WriteLine("Vous avez choisi l'option " + choix);
        }

        static int ChoisirOptionMenu()
        {
            int choix=0;
            string menu = "Choisir 1 pour Jeu du Pendu, 2 pour un Tic Tac Toe, 3 pour quitter";
            bool valide=false;

            while(!valide)
            {
                Console.Clear();
                Console.WriteLine(menu);
                int.TryParse(Console.ReadLine(), out choix);

                if(choix == 1 || choix == 2 || choix == 3)
                {
                    valide = true;
                }
            }


            return choix;
        }
    }
}