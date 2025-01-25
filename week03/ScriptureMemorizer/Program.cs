using System;

class Program
{
  static void Main(string[] args)
  {

    string line = "enter";


    Reference ref1 = new Reference("1Nephi",3,7);
    Scripture scrip1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    Reference ref2 = new Reference("Proverbs", 3,5,6);
    Scripture scrip2 = new Scripture(ref2,"Trust in the LORD with all your heart and lean not on your own understanding.\n In all your ways submit to him, and he will make your paths straight");
    Reference ref3 = new Reference("Phillipians", 4,13);
    Scripture scrip3 = new Scripture(ref3, "I can do all this through him who gives me strength.");
    Reference ref4 = new Reference("Mosiah", 2,17);
    Scripture scrip4 = new Scripture (ref4,"And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
    Reference ref5 = new Reference("Matthew", 25,21);
    Scripture scrip5 = new Scripture(ref5,"His lord said unto him, Well done, thou good and faithful servant: thou hast been faithful over a few things, I will make thee ruler over many things: enter thou into the joy of thy lord.");

    List<Scripture> scripList = new List<Scripture>();

    scripList.Add(scrip1);
    scripList.Add(scrip2);
    scripList.Add(scrip3);
    scripList.Add(scrip4);
    scripList.Add(scrip5);

    Random Scrip = new Random();
    int num = Scrip.Next(0,scripList.Count());

    Scripture scripchosen = new Scripture(scripList[num].GetReference(), scripList[num].GetReference().GetDisplayText());
    scripchosen = scripList[num];


    bool hidden = scripchosen.IsCompletelyHidden();
      
    while ((line != "quit"))
    {
            
      Console.Clear();
      string reference = scripchosen.GetReference().GetDisplayText();
      string text = scripchosen.GetDisplayText();

      Console.WriteLine($"{reference} - {text}");
        

      Console.WriteLine("Please enter to continue or quit to exit: ");
      line = Console.ReadLine();


      if ((line == "quit") || (hidden == true))
      {
                
        Console.WriteLine("Memorize it!");
        line = "quit";

      }
      else 
      {
        scripchosen.HideRandomWords();
        hidden = scripchosen.IsCompletelyHidden();
      }

    }       

  }
}