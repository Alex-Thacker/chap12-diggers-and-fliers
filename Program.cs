using System;
using System.Collections.Generic;

namespace diggersandfliers
{
    class Program
    {
        static void Main(string[] args)
        {
           Ant ant = new Ant () ;
           ant.WillWalkOnGround = true;
           ant.LegCount = 2;

           BettaFish bettafish = new BettaFish () ; 
           bettafish.WillSwim = true;
           bettafish.IsCute = true;

           CopperheadSnake copperheadsnake = new CopperheadSnake () ; 
           copperheadsnake.WillWalkOnGround = true ; 
           copperheadsnake.Size = "2"; 

           Earthworm earthworm = new Earthworm () ;
           earthworm.WillDig = true;
           earthworm.SizeInInches = 2 ; 

           Finche finche = new Finche () ;
           finche.WillFly = true ; 
           finche.LastName = "bob";

           Gerbil gerbil = new Gerbil () ;
           gerbil.WillWalkOnGround = true;
           gerbil.FluffLevel = "extreme"; 

           Mice mice = new Mice () ;
           mice.WillWalkOnGround = true ; 
           mice.CuteLevel = "big time"; 

           Parakeet parakeet = new Parakeet () ;
           parakeet.WillFly = true ; 
           parakeet.NumberOfWings = 5 ; 

           Terrapin terrapin = new Terrapin () ;
           terrapin.WillWalkOnGround = true ;
           terrapin.Name = "steve" ;

           TimberRattlesnake timberrattlesnake = new TimberRattlesnake () ;
           timberrattlesnake.WillWalkOnGround = true ; 
           timberrattlesnake.Color = "green? " ;

        ///////////////////////////////////Containers
           FlyContainer flycontainer = new FlyContainer () ; 
           flycontainer.FlyBox.Add(parakeet); 
           flycontainer.FlyBox.Add(finche); 

           SwimContainer swimcontainer = new SwimContainer () ; 
           swimcontainer.SwimBox.Add(bettafish);

           DigContainer digcontainer = new DigContainer () ;
           digcontainer.DigBox.Add(earthworm);

           WalkContainer walkcontainer = new WalkContainer () ; 
           walkcontainer.WalkBox.Add(timberrattlesnake);
           walkcontainer.WalkBox.Add(terrapin);
           walkcontainer.WalkBox.Add(mice); 
           walkcontainer.WalkBox.Add(gerbil);
           walkcontainer.WalkBox.Add(copperheadsnake);
           walkcontainer.WalkBox.Add(ant);
        }
    }
}

// Animals that dig and live in the ground
// Animals that move about on the ground
// Animals that swim in water
// Animals that fly above the ground

// Parakeets - fly
// Earthworms - dig in ground
// Terrapins - walk on ground 
// Timber Rattlesnake - walk on ground 
// Mice - walk on ground 
// Ants - dig in ground 
// Finches - fly
// Betta Fish - swim 
// Copperhead snake - walk on ground 
// Gerbils - walk on ground 