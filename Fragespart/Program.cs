string restart = "a";
while (restart == "a")
{
    int answers = 0;
    Console.WriteLine("What is you name puny mortal?");
    string PunyMortal = Console.ReadLine();
    Console.WriteLine($"Well well well...If it isn't {PunyMortal}.");
    Console.ReadLine();
    Console.WriteLine("I have no idea who you are but a puny mortal like you won't be able to defeat me. lets see if you have what it takes to pass my super duper ultra difficult test of difficultness");
    Console.Write("super duper ultra difficult test of difficultness");
    Console.WriteLine();
    Console.ReadLine();
    Console.WriteLine("Question 1:");
    Console.WriteLine("Im going to start of easy. How many percent of your bones are in you feet?");
    Console.WriteLine("A:25% B:10% C:100%");
    string Q1 = Console.ReadLine().ToLower();
    if (Q1 == "a")
    {
        Console.WriteLine("Beginners luck...Next question.");
        answers ++;
    }
    else
    {
        Console.WriteLine("I knew you couldn't do it. A puny mortal like you oviously has a puny brain.");
        Console.ReadLine();
        Console.WriteLine("Next question.");
    }
    Console.ReadLine();
    Console.WriteLine("Who is the sexiest man on earth?");
    Console.WriteLine("A:That wierd neighbor across the street B:Ryan Reynolds C:You");
    string Q2 = Console.ReadLine().ToLower();
    if (Q2 == "b")
    {
        Console.WriteLine("That one must have been to easy. Time to increase the difficulty a bit");
        Console.ReadLine();
        Console.WriteLine("Next question...Theres no way you get this right.");
        Console.ReadLine();
        answers ++;
    }
    else
    {
        Console.WriteLine("HAH! You think that ugly person is sexy? You really have poor taste.");
        Console.ReadLine();
        Console.WriteLine("NEXT QUESTION!!!. You are definetly going to guess wrong on this one.");
        Console.ReadLine();
    }
    if (answers == 0)
    {
        Console.WriteLine("So far you haven't gotten a single question right although thats to be expected from a puny mortal souch as yourself.");
        Console.ReadLine();
        Console.WriteLine("I hope you're ready because the last question is so difficult even I don't know the answer to it.");
        Console.ReadLine();
        Console.WriteLine("Duck?");
        Console.WriteLine("A:Duck B:Wtf C:DUCK!!!");
        string Q32 = Console.ReadLine().ToLower();
        if (Q32 == "c")
        {
            Console.WriteLine("How...how did you...you just got 1 point anyway so theres no way you won");
            Console.ReadLine();
            answers ++;
        }
        else
        {
            Console.WriteLine("Im going to assume that was the wrong answer since you are simply just a dumb puny mortal with a dumb puny mortal brain.");
            Console.ReadLine();
            
        }
    }
    else if (answers == 1)
    {
        Console.WriteLine("You may have gotten lucky one time puny mortal but theres no way you get this question right.");
        Console.ReadLine();
        Console.WriteLine("I have search through heaven, hell, your mom and google to find the most difficult question ever. Prepare to lose!");
        Console.ReadLine();
        Console.WriteLine("Is there really a Santa Claus?");
        Console.WriteLine("A:No B:Yes C:Maybe");
        string Q31 = Console.ReadLine().ToLower();
        if (Q31 == "b")
        {
            Console.WriteLine("A man of culture i see...or girl...anyway you got this right so im going to give you a special reward.");
            Console.ReadLine();
            answers ++;
        }
        else
        {
            Console.WriteLine("You clearly are dumber than i thought. Of course Santa Claus is real. Who do you thing brings the presents every year? SANTA CLAUS!");
            Console.ReadLine();
        }
    }
    else if (answers == 2)
    {
        Console.WriteLine("Since you are clearly cheating in some way i will ask you a question even google can't help you with...I hope atleast");
        Console.ReadLine();
        Console.WriteLine("Prepare puny mortal for you reign of cheating will end here and now with this question.");
        Console.ReadLine();
        Console.WriteLine("Am i sexy?");
        Console.WriteLine("A:Yes B:No C:All of the above");
        string Q33 = Console.ReadLine().ToLower();
        if (Q33 == "a")
        {
            Console.WriteLine("I didn't think you would get it right...I know im sexy of course but you don't even know what I look like. Im kidding im kidding...You little cheating bastard i know your tricks but don't think I will award a cheater like you with anything special");
            Console.ReadLine();
            answers ++;
        }
        else if (Q33 == "b")
        {
            Console.WriteLine("HOW DARE YOU!!! Im the sexiest person on this earth. Even a puny mortal like you should now it just from being in my presence. I know it would be a hard question but a gremling like you must be punished.");
            Console.ReadLine();
            
        }
        else
        {
            Console.WriteLine("What does that even mean...Im going to assume that you mean im super sexy although maybe you aren't. Since you are a puny ugly dumb mortal im going to assume its a no which means you must be punished for your actions.");
            Console.ReadLine();
        }
    }
    if (answers == 0)
    {
        Console.WriteLine("...I was going to kill you in horrible ways but I think I have a more suitible punishment...SCHOOL!!!");
        Console.ReadLine();
        Console.WriteLine("Stop screaming! It won't do any good since no body can save you. Im going to leave you for a minute until I send you to the worst place on earth.");
    }
    else if (answers == 1)
    {
        Console.WriteLine("A man of such knowledge is to dangerous to be kept alive. I know you failed on the first two but the last question was impossible. The good news are that you are going to die in a suitable way and the bad news are that you are going to get eaten by ducks.");
        Console.ReadLine();
        Console.WriteLine("They haven't eaten in days as you can hear from all the quacking. Better open the door since we don't want to keep our guests waiting.");
    }
    else if (answers == 2)
    {
    Console.WriteLine("*45 min later* I see you have finally woken up. I want to intruduce you to one of my dear friends. His name is Demon God Google Santa Mom...Don't ask about his name. Im going to leave you two and just stay in a corner and narrate.");
    Console.ReadLine();
    Console.WriteLine("Out of the corner of yor eye you see a big shadow and turn your head. There stands a seriously messed up fat Santa Claus with lipstick and make up wearing a google T-shirt.");
    Console.Write("In his hands he has a cloud shaped like a chainsaw and he has horns comming out of his skull.");
    Console.WriteLine();
    Console.ReadLine();
    Console.WriteLine("You scream with fear as Demon God Google Santa Mom comes closer and the rest of the story is just a morbid mess.");
    }
    else if (answers == 3)
    {
    Console.WriteLine("I changed my mind. Im going to give you something very very special.");
    Console.ReadLine();
    Console.WriteLine("I just realised we haven't introduced ourselves. How rude of me. I am the infamous villian OLD LADY PERSON!!! also known as ");
    Console.Write("some random person who kidnapped you and that you suspect is some old lady because of no reason whatsoever.");
    Console.WriteLine();
    Console.ReadLine();
    Console.WriteLine("Im just going to leave you here but know this. I rigged this room with motion sencors connected to bombs so if you move just a little bit you go boom.");
    Console.Write("I hope you have fun now that you can't move for all eternity.");
    Console.WriteLine();
    }
    Console.ReadLine();
    Console.WriteLine($"Score:{answers}/3");
    Console.WriteLine("Do you want to try again? A:Yes B:No");
    restart = Console.ReadLine().ToLower();
}