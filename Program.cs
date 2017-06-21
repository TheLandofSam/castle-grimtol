using System;
using CastleGrimtol.Game;

namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var game = new Game.Game();//go into game.cs and use game()


      game.Setup();
      game.StartGame();
      var playing = true;

      //ABOVE LINE IS GAME SET UP
      //BELOW LINE IS GAME LOOP


      while (playing)
      {

        var userAction = game.GetUserAction();

        Room nextRoom;//setting place holder
        game.CurrentRoom.Exits.TryGetValue(userAction, out nextRoom);

        if (userAction == "debug")
        {
          game.DEBUG();
        }

        if (nextRoom != null)
        {
          if (nextRoom.IsLocked())
          {
            //I NEED ANOTHER STATEMENT HERE THAT SAYS, IF ITS LOCKED, LOOK AT LIST OF ITEMS AND SEE IF YOU HAVE THE PROPER KEY (HOW DEFINE PROPER KEY?) AND IF SO, THEN, CAN ENTER...OR FLIP BOOL TO LOCKED=FALSE.
            nextRoom.CantEnter();
          }
          else
          {
            game.CurrentRoom = nextRoom;
            game.CurrentRoom.Look();
          }
        }
        else if (userAction == "take")
        {
          Console.WriteLine("What do you want to take?");
          string itemName = Console.ReadLine();
          var thing = game.CurrentRoom.Items.Find(theThing => theThing.Name == itemName);
          if (thing != null)
          {
            game.TakeItem(thing);
            game.CurrentPlayer.Score += 5;
          }
          else
          {
            Console.WriteLine("You cannot take that.");
          }
        }
        else if (userAction == "use")
        {
          Console.WriteLine("What do you want to use?");
          string useItem = Console.ReadLine();
          var kitty = game.CurrentPlayer.Inventory.Find(aThing => aThing.Name == useItem);
          if (kitty != null)
          {
            if (useItem == "bronzeKey" && game.CurrentRoom.Name == "Hall B")
            {
              if (game.CurrentRoom.Exits.ContainsKey("north"))
              {
                game.CurrentRoom = game.CurrentRoom.Exits["north"];
                game.CurrentRoom.Look();
              }
              else
              {
                game.CurrentRoom.AddRoom("north", game.GetRoom("Safe"));
                Console.WriteLine("You push the bronze key into the door's lock and feel a satisfying turn as you twist the key.");
                game.CurrentRoom.Look();
              }
            }
            else if (useItem == "silverKey" && game.CurrentRoom.Name == "Hall D")
            {
              if (game.CurrentRoom.Exits.ContainsKey("north"))
              {
                game.CurrentRoom = game.CurrentRoom.Exits["north"];
                game.CurrentRoom.Look();
              }
              else
              {
                game.CurrentRoom.AddRoom("north", game.GetRoom("Locked Door"));
                Console.WriteLine("You fit the silver key into the door's lock and feel a satisfying turn as you twist the key.");
                game.CurrentRoom.Look();
              }
            }
            else if (useItem == "flashlight" && game.CurrentRoom.Name == "Hall E" || game.CurrentRoom.Name == "Hall F")
            {
              if (game.CurrentRoom.Exits.ContainsKey("north"))
              {
                game.CurrentRoom = game.CurrentRoom.Exits["north"];
                game.CurrentRoom.Look();
              }
              else
              {
                game.CurrentRoom.AddRoom("north", game.GetRoom("Stairs"));
                Console.WriteLine("You flick on the flashlight to test the batteries. The beam is nice and strong and sends a beam of light ahead of you up the stairs.");
                // game.CurrentRoom.Description += " With your flashlight you now clearly see a staircase to the north it seems safe";
                game.CurrentRoom.Look();
              }
            }
            //game.UseItem(aThing.Name);
            // game.Room.locked = false; //I NEED TO SWITCH THE ISLOCKED-LOCKED BOOL TO FALSE SOMEPLACE...HOW?
          }
          else
          {
            Console.WriteLine("You cannot use that here.");
          }
        }
        else if (userAction == "quit")
        {
          playing = false;
        }
        else if (userAction == "look")
        {
          game.CurrentRoom.Look();
        }
        else if (userAction == "inventory")
        {
          game.CurrentPlayer.ShowInventory(game.CurrentPlayer);
        }
        else if (userAction == "help")
        {
          game.GetHelp();
        }
        else if (userAction == "phone")
        {
          Console.Clear();
          game.Phone();
          Console.WriteLine("While getting to a phone is what brought you to this home, there is something wrong in this house. The person who lives here needed your help, and your focus on only your problems has left them in bad situation. You have lost an opportunity to help someone in need and lost this game.");
          playing = false;
        }
        else if (userAction == "garage")
        {
          Console.Clear();
          game.CurrentRoom = game.GetRoom("Garage");
          Console.WriteLine("You walk back through the house and out the front door. You follow the circular driveway to the east cutting off to the east at the garage. The building is larger than you thought, with the bulk of it hidden by trees and bushes. The garage is an older design with two tall wide doors that open out like giant cupboard doors. As you step up to the door standing ajar, you hear soft sobbing coming from the garage. You pull the door open and see an old man sitting, legs crossed, on the garage floor. He is leaning against a wooden post, hunched over. His left hand loosely is gripping a silver revolver which rests on his left thigh. As you think back to what you've seen in the house, you have a pretty good idea why this man sits here with a loaded gun. You are a bit afraid to speak--unsure of what his reaction will be if he is startled--but also feel a need to say something...anything...");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("At this point in the game you can use the commands talk or leave.");
          Console.ForegroundColor = ConsoleColor.Gray;
          game.GetUserAction();
        }
        else if (userAction == "talk")
        {
          Console.WriteLine("You begin to speak in a slow soft voice. You speak simply, as if the man is known to you and you to him. You tell him he will be okay. You tell him he is strong enough to move forward, for Julia. He slowly looks up at you with tears running down his face and tells you he is 'all alone now, all alone...' His head then droops to his chest once again, and his tears resume their fall to his lap. 'I haven't been alone a single day since marrying her. ...and now there is no one' the man says, through sobs. Part of you wants to run, to seek the cool fresh air and freedom which outside provides. Freedom from the grief which fills this dark opressive space and threatens to suffocate both of you. The other part of you wants to say the right thing, the thing that will make it survivable, the words you don't know, and that part is very afraid of saying the wrong thing.");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("You can use the commands continue or leave.");
          Console.ForegroundColor = ConsoleColor.Gray;
          game.GetUserAction();
        }
        else if (userAction == "continue")
        {
          Console.WriteLine("You take a slow deep breath of hot heavy air, move over to the man, and sit next to him on the floor. You say 'We are never really alone. Our loved ones are always in our hearts and minds, and things they have touch surround us daily. And people we've never met walk into our lives...at the most unexpected times. The man tilts his head toward you looks at you for a moment, closes his eyes and nods his head. You lightly lay your right on the revolver and take the gun from his hand. The man does not resist. He burries his face in his hands and the tears come again as he greevs for his wife. You sit quietly and an rub his back for a long while. When his sobs begin to slow, you tell him your are going to the house to get him a glass of water. You exit the garage, with the intent to call the police to report the death, and absent mindedly pull out your cell phone. There, on the east side of the property, outside a small dark barn full of more grief than you had ever experienced, you find two bars of reception. More than enough to make a call.");
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("You have won this game and gained a giant karma bonus.");
          Console.ForegroundColor = ConsoleColor.Gray;
          playing = false;
        }
        else if (userAction == "leave")
        {
          Console.Clear();
          Console.WriteLine("The situation is more than you can handle, and you decided to get Ben professional help. You quietly leave the garage and return to the house to call the police. After making the call, you return to the garage door, but are unable to enter. You stand at the door listening to the old man sob while you wait for the police to arrive.");
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("You have completed this game and helped Ben get the help he needed.");
          Console.ForegroundColor = ConsoleColor.Gray;
          playing = false;
        }
        
        else
        {
          Console.WriteLine("You cannot go that way.");
        }

      }

      Console.WriteLine("Goodbye.");

    }
  }
}

/*use fx: 
-check to see if currentPlayer has the needed item in their inventory
-if they have the item then
    -for keyA toggle locked to false and display movement description/allow movement.
    -for keyB toggle locked to false and display movement description/allow movement.
    -for flashlight toggle locked to false and display movement description/allow movement
    -for phone, display description, end game, kick out a score.*/
