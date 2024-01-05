/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Random rand=new Random();
    bool right=true;
     String computer;
    String choice;
    
    while(right==true){
    choice = "";
  computer = "";

    int randomnum=rand.Next(1,4);
       
     
        Console.WriteLine("Enter your choice");
         choice=Console.ReadLine();
         choice=choice.ToUpper();
        switch(randomnum){
            case 1:
            computer="ROCK";
            break;
            case 2:
            computer="PAPER";
            break;
            case 3:
            computer="SCISSOR";
            break;
        
    }
    Console.WriteLine("Player"+choice);
   
    switch (choice){
        case "ROCK":
        if( computer=="ROCK"){
            Console.WriteLine("Computer"+computer);
            Console.WriteLine("DRAW");
        }
        else if (computer=="PAPER"){
            Console.WriteLine("Computer"+computer);
            Console.WriteLine("CPU win");
        }
       else {
           Console.WriteLine("Computer"+computer);
           Console.WriteLine("You win");
       }
       break;
       case "PAPER":
       if( computer=="ROCK"){
           Console.WriteLine("Computer"+computer);
            Console.WriteLine("You win");
        }
        else if (computer=="PAPER"){
            Console.WriteLine("Computer"+computer);
            Console.WriteLine("DRAW");
        }
       else {
           Console.WriteLine("Computer"+computer);
           Console.WriteLine("CPU win");
       }
       break;
       case "SCISSOR":
       if( computer=="ROCK"){
           Console.WriteLine("Computer"+computer);
            Console.WriteLine("CPU win");
        }
        else if (computer=="PAPER"){
            Console.WriteLine("Computer"+computer);
            Console.WriteLine("You win");
        }
       else {
           Console.WriteLine("Computer"+computer);
           Console.WriteLine("DRAW");
       }
       break;
        }
        Console.WriteLine("Would You llike to play again(Y?N)");
        String answer=Console.ReadLine();
        answer=answer.ToUpper();
        if(answer=="Y"){
            right=true;
        }
        else if(answer=="N"){
            right=false;
        }
        
        }
    }
  }
