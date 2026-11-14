using System;
using System.Collections.Generic;

// Added a list of verses instead of one
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy."
        ));

        scriptures.Add(new Scripture(
            new Reference("Alma", 41, 10),
            "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickidness never was happiness"));

        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"));

        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 122, 5, 7),
            "If thou art called to pass through tribulation; if thou art in perils among false brethren; if thou art in perils among robbers; if thou art in perils by land or by sea; If thou art accused with all manner of false accusations; if thine enemies fall upon thee; if they tear thee from the society of thy father and mother and brethren and sisters; and if with a drawn sword thine enemies tear thee from the bosom of thy wife, and of thine offspring, and thine elder son, although but six years of age, shall cling to thy garments, and shall say, My father, my father, why can’t you stay with us? O, my father, what are the men going to do with you? and if then he shall be thrust from thee by the sword, and thou be dragged to prison, and thine enemies prowl around thee like wolves for the blood of the lamb; And if thou shouldst be cast into the pit, or into the hands of murderers, and the sentence of death passed upon thee; if thou be cast into the deep; if the billowing surge conspire against thee; if fierce winds become thine enemy; if the heavens gather blackness, and all the elements combine to hedge up the way; and above all, if the very jaws of hell shall gape open the mouth wide after thee, know thou, my son, that all these things shall give thee experience, and shall be for thy good."));

        Random random = new Random();

        int randomIndex = random.Next(scriptures.Count);

        Scripture scripture = scriptures[randomIndex];

        string Input = "";

        while (Input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            Input = Console.ReadLine();

            if (Input == "")
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}