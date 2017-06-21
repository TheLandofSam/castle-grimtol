using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    private List<Room> _allRooms = new List<Room>();


    public Room GetRoom(string roomName)
    {
      Room room = _allRooms.Find(r => r.Name == roomName);
      return room;
    }

    public void Reset()
    {
       new Game();
    }
    public void StartGame()
    //my starting info is here \/
    {
      Console.Clear();
      CurrentPlayer = new Player();
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.WriteLine("After having car trouble on the way back from an out of town work meeting you begin walking in the direction of the center of the small town near where you stopped. For some reason this area has no cell service--hard to believe these days. Fortunately the day is sunny, in the low 70s with a light breeze. At least some thing is going right today. After walking for about 45 minutes you come upon a property boundary fence on your left. You begin to follow the fence, and about 20 minutes later a large red brick home comes in to view. The house appears old and is situated back off the road with a well maintained garden in the front. As you walk up the circular driveway you pass an old car. You step up to the front door and ring the door bell. You hear nothing but the rustling of leaves in the light wind. You wonder if the door bell is working, and after a bit you use the door knocker to summon the occupants. While you wait you check your phone again for cell coverage. You still have no bars. You think to yourself that you could never live in such a rural location. Getting a bit anxious about the situation, you reach out and give the front door a good pounding. The front door pushes slightly open. You pause for a moment then call out for the attention of the occupants. No one responds. You know someone must live here with the garden as well tended as it is, and the car behind you in the driveway. The house looks large and the occupants probably didn't hear you. You really need to use their phone, as it is, it will probably take an hour or more for the tow truck to show up. You step inside the small entry, calling out again to the occupants. No one responds. You close the door behind yourself.");
      GetHelp();
    }

    public void GetHelp()
    {
      Console.WriteLine("----------------------------------------------------------------------");
      Console.WriteLine("Recognized commands are help, look, take, use, inventory, north, south, east, west or give up by typing quit.");
    }
    public void Setup()
    //ROOMS AND PATHS \/
    {
      _allRooms = new List<Room>();
      var entry = new Room("Small entry room.", "You are in a small room with old wood paneling which is lit by a chandalier above you.There is a painting of a fluffy white smoosh-faced cat on the west wall. There is a tiny round table below the painting which holds a jade vase with lavendar colored silk flowers. The vase and flowers are dusty. You can see some spider webs on the chandalier. There is nothing else in this room. There is a small hall straight ahead to the north and a large hall to the east.");

      var hallA = new Room("Small hallway.", "You are in a small hallway. The walls are covered with old wood paneling. The light in the hall is out--there is not much light here. The air smells dusty. The hallway continues to the north and south.");

      var hallB = new Room("Hall B", "You have reached the end of the small hallway. There is a closed door on the north wall, and a door to the west. The door to the west is ajar and there is a faint faint light coming from the next room. You feel a slight draft coming from the the open door. The hallway continues to the south");

      var secondFloorLanding = new Room("Second Floor Landing", "You are on the second floor landing. There is a window above your head which is haphazardly covered with cardboard which is blocking most light into this space. There is an end table on the north wall which holds an old black push button phone, a note pad and pen. There is a hallway to the east and left. The hallway to the west is lit unseen ceiling lights, while the hallway to the east is lit by daylight flooding through an open room door. The staircase to the first floor is on the south wall.");

      var hallE = new Room("Hall E", "You are in a large hallway which runs along the front of the home. There is a huge picture window on your right, which covers most of the south wall in this hallway. Through the window you can see the well kept front garden, the circular driveway, and what appears to be a shed or garage on the east side of the property. To the north is a grand staircase. The staircase is unlit. Light coming through the window only lights the way about half way up the staircase. The hallway continues to the east, and there is a doorway to the west.");

      var library = new Room("The Library", "You have entered a library. The room looks like it was abandonded mid use, like the owner went to the store and never returned. There is a desk covered in items in the middle of the room, a credenza against the wall behind the desk, and an over turned trash can next to the credenza. You step toward the desk and see an unorganized mismosh of papers, bills and advertisments. There is a bronze colored key (bronzeKey) poking out from under the paper work. Dispite the air of abandonment, there is a fire buring in the fire place on the north wall. There are bookcases floor to ceiling on either side of the fireplace. The shelves are covered in books that look dated with nic-knacks interspersed here and there. There is a large window on the south wall which looks out over the well kept garden at the front of the house. You are the only person in this room. The exit from this room is on the east wall.");

      var lockedDoorA = new Room("Safe", "You enter the small storage room and see a large gun safe on the west wall. The door to the safe is standing open. You see some items-- riffles, jewlery, and cash -- along with personal papers and a camera inside of the safe. There is a door to the north which is standing open. You see a kitchen on the other side of the door. There is also an door on the south wall.");

      var hallF = new Room("Hall F", "You are in a large hallway which runs along the front of the home. There is a huge picture window on the south wall, which covers most of the wall in this hallway. Through the window you can see the well kept front garden and the circular driveway. A car that appears to be from the 50's or 60's is parked on the west side of the driveway. It is dirty and does not appear to have been recently driven. On the north is a grand staircase. The staircase is unlit and too dark to climb. The hallway continues to the west. There is a large room to the east.");

      var stairs = new Room("Stairs", "The grand staircase between the first and second floors.");

      var livingRoomSW = new Room("Living Room", "You are in what appears to be the living room. The walls are bright white. There is a fireplace in the center of the east wall, with a small window to the left of the fireplace. There is a large window on the south wall which looks out over the well kept front garden. You can clearly see a small garage on the east of the circular driveway. There is a stone statue in the garden directly outside the window. A large crow is sitting a top the statue. You feel as if the crow is watching you through the window. The two windows in this room, offer enough light to see most of the items in this room clearly. There are two antique love seats in the middle of the room, seperated by a coffee table. The couches appear to be covered in light blue velvet. There is a book sitting on one of the loveseats, and a pair of glasses sitting under a lamp on the coffee table to the left of the couch. There is a small bookshelf in the northeast corner of the room, and a small writing desk on the north wall. There appears to be a hallway off an exit from the room to the northwest and the southwest.");

      var livingRoomSE = new Room("Living Room", "You move closer to the fireplace and can see framed portriates on the matel. They are antique photographs of unsmiling people dressed in their finest cloths. The photos are covered in a fine layer of dust. The book sitting on the couch appears to be a book about flowers, and has a blue ribbon tucked between its pages.");

      var livingRoomNW = new Room("Living Room", " There is a hallway on the north wall, and a painted portriate of an older gentleman seated on gold wing chair. His eyes are blue, his hair is gray and his expression is severe. He is dressed in black suite. There is a dog sitting at his side. You think it looks a lot like your friend's Brittany Spaniel, Watson. There is also an exit from this room to the southwest.");

      var livingRoomNE = new Room("Living Room", "You move closer to the bookshelf, and see many volumes on flowers and plants. There are a few books on birds, and several books which appear to be fictional novels. There is a silver key (silverKey) in a small tarnished silver cup sitting on one of the shelves. The cup is engraved with 'Rose'. You can see a well kept garden out of the window on the east wall. You can see bushes of flowers in different colors. You think they are roses. The writing desk on your left appears unused.");

      var hallC = new Room("Small hallway", "You are in a small hallway. The walls are covered with old wood paneling. There is a door to the east, through which you can see a small bathroom. You push the door open a bit more to allow more light in the short hallway. The bathroom looks tidy and clean. On the west is a closed door. The hallway continues to the north and south.");

      var hallD = new Room("Hall D", "You are at the end of a short hallway. There is a painted portriat of a young blond-haired girl wearing a pink dress and holding a fluffy white smoosh-faced cat on the west wall. The child is smiling, the cat looks disgruntled. The name 'Julia' is painted in the bottom corner of the picture. There is a door to the east and a door to the north. The small hallway continues to the south.");

      var bathroom = new Room("Bathroom", "You are in a small bathroom with a sink, toilet and tub. There are cupboards under the sink, but no storage draws. The towels are clean but appear to be a bit dusty. There is a small window on the east wall, in front of you. A small clear bottle holding a withered flower sits on the window sill. There is a gold locket sitting next to the sink. The exit from this room is on the west wall.");

      var closet = new Room("Hall Closet", "You open the door to the find a small closet. You smell a faint hint of cedar. The closet seems to be dual purpose. There are neatly stacked and folded linens on some shelves, first aid and toiletry items on some shelves, and utility items on other shelves. There is not enough light to see what is on the top shelves. You see a flashlight on one of the shelves on the left. There is also a stack of magazines neatly stacked on the closet floor. The exit from this room is on the east wall.");

      var nursery = new Room("Nursery", "The room is lit by a window on the east wall in front of you. You are in a small room with a small bed, small dresser, a toy chest, and a rocking chair. The walls are painted white like the living room, but there are hand painted pink roses dotting the walls. There is a stuffed lamb sitting on the rocking chair. The name Rose is embordered into the pillow case on the small bed. The air in this room smells stale. The exit from this room is on the west wall.");

      var lockedDoorB = new Room("Locked Door", "You are in a child's playroom. The air is stuffy and smells dusty. The curtains are drawn closed over the window on the north wall, but a dull glow eminates from the thin white curtains. You can see toys and dolls on a shelf on the east wall, a small table and chair set to near the window. There is a miniture tea set sitting on top of the small table. There was a bookshelf, chair and door on the west wall.");

      var familyRoomE = new Room("Family Room E", "You are in a large family room at the back of the house. There are couches, end tables, and an old televsion, in this room. There are magazines here and there, and a black telephone on a small end table in southwest the corner. The north wall is covered in large windows over looking a large deck running the length of the house to the west, green grass and trees beyond that as far as the eye can see. There is a small lake at distance to the north. There is a glass door on the north wall of the room that is standing open. You walk over to the open door, step out onto the deck and look around. A black crow which had been perched on the railing takes to flight. You do not see anyone else. You call out greetings a few times and receive no response. You walk back inside. You can move west toward the dining room or east.");

      var familyRoomW = new Room("Family Room W", "You are in a large family room at the back of the house. There are couches, end tables, and an old televsion, in this room. There are magazines here and there, and a black telephone on a small end table in south the corner. The north wall is covered in large windows over looking a large deck running the length of the house to the west, green grass and trees beyond that as far as the eye can see. There is a small lake at distance to the north. You can move west to the dining room or east to the otherside of the family room. \n You can now use the command 'phone' along with all previous commands.");

      var diningRoom = new Room("Dining Room", "You step into the dining room, walking north around the table. You have a breath taking view of the fields, forest and lake. There is a large black crow on the deck railing. You think the crow is watching you, as if it knows you do not belong here. There is an arrangement of silk lavendar flowers in the center of the dining table. The table and flowers are covered in a thin layer of dust. On the south wall hangs a large painting of an older man with gray hair holding a small blond-haired girl. The child is laughing at the older man. The name 'Julia' is painted in the bottom corner of the picture. You can move west to the kitchen or east to the family room.");

      var kitchen = new Room("Kitchen", "You step into a large open kitchen done in white and blue.The space is open to the dining room to the east and the family room further to the east. You are at the back of the house and there are windows all along the north wall. The room is flooded with light. A glass of water sits alone on the kitchen island. There is a door on the south wall, or you can move east to the dining room.");

      var hallG = new Room("West Hall South", "You are at the south end of a short hallway. The walls are painted bright white. There is a door on the west wall. The hall continues to the north, and to the east.");

      var hallI = new Room("West Hall North", "You are at the north end of a short hallway. Something smells off in this hallway. There is a window on the north wall flooding light into the hallway. You can see an clear view of the grounds, lake and forest beyond. There is a door on the west wall which stands slightly ajar and a door on the east wall which is closed. The hallway continues to the south.");

      var room22 = new Room("Bedroom", "You have entered an empty bedroom. The air smells stale in this room. There is a window on the west wall and a closet on the north wall. There is a dresser on the south wall near the door holding a vase of white silk flowers. There is a layer of dust on the dresser and flowers. There is a full size bed in the middle of the room with an end table and lamp to its side. This room has clearly not been used for a long time. There is a door on the east wall.");

      var room23 = new Room("Julia", "You push the door on the west wall open to a room flooded with light from a window which starts on the west wall and curves around to the north wall. You see an old woman laying in a hospital bed directly in front of you. She is surrounded by medical monitors but all of the equipment is quiet. You know immediately upon seeing the woman that she has passed away. You are momentarily shocked, both unable to take in any more of your surroundings and unable to look away. You eventually notice an easy chair placed next to the bed on the north wall. You see reading glasses on top of a newspaper on the floor. You cannot stand to be in this room any longer. The exit is to the east.");

      var room28 = new Room("Gallery", "You are in a large open room. The north wall is floor to ceiling windows. The view over the property is amazing. The room is filled with paintings: hanging, siting on easels, in stacks three deep leening against walls. You begin to wander through the paintings and you can hear your footfalls on the wood floors. You see many portraits of a young blond-haired girl, both alone and with adults. One picture shows her on the lap of middle age woman with the same striking green eyes that the child has. You carefully pick the portrait up from the easel and look at the back. You see a swirling cursive writing which reads 'Lillian and Rose, 2006'. You continue to wander through the gallary looking at pictures of the family, the property, and scenes painted by the ocean. One painting shows a older man standing in the garage with a drink in his hand. He is looking intently at the old car which currently sits in the driveway. In the painting the car is half pulled into a garage, hood up, and surrounded by tools and parts. You carefully pick this portrait up and look at the back. You see the same swirling cursive writing which reads 'Ben in his shop, 2010. \n You can now use the 'garage' command to move to the garage. There is also an exit from this room on the west wall and an exit on the east wall.");

      var room26 = new Room("Bedroom", "You have entered an empty bedroom. The air smells stale in this room. There is a window on the north wall which wraps around to the east wall adding a curved corner to the room. There is a closet on the south wall, and a dresser on the west wall near the door. There is brass sculpture of a running horse on top of the dresser. There is a layer of dust over the dresser and sculpture. There is a full size bed in the middle of the room with an end table and lamp to its side. This room has clearly not been used for a long time. There is a door on the west wall.");

      var room27 = new Room("ManCave", "You step into a daylight lit bedroom that appears to be in use for a craft and television room. The craft happening here is fly tying. You have seen your father tie many a fly in his study over the years. On the north wall over the work desk in this roomare a spattering of hooks from which different feathers and furs in a multitude of colors are hanging. There is a chunk of styrofoam on the desk which dispaly neatly tied fly hooks in different sizes and colors. There is a book laying on the desk open to a picture of a May Fly hook. Open in the chair in front of the desk is a photo album. It is open to a wedding photograph. Below the photograph is written 'Benjamin and Julia, October 8, 1967. In the southeast corner of the room sits a large television. You can see indents in the carpet where a sitting chair use to be placed. There is an exit from this room on the west wall.");

      var hallJ = new Room("East Hall North", "You are at the north end of a short hallway. There is a window on the north wall. It is covered in a shear curtian, but still brings ample light into the hallway. While the curtian mutes the colors of the outdoor world, you can see a view of the grounds, lake and forest beyond through the window. There is a door on the west wall and a door on the east wall, both of which are closed. The hallway continues to the south.");

      var hallH = new Room("East Hall South", "You are at the south end of a short hallway. The walls are painted a bright white. There is a painting of a rider jumping a horse over a hurdle in the on the east wall. Next to the painting is a door to a room standing open. There is a good amount of daylight coming from this room.");

      var garage = new Room("Garage", "You walk back through the house and out the front door. You follow the circular driveway to the east cutting off to the east at the garage. The building is larger than you thought, with the bulk of it hidden by trees and bushes. The garage is an older design with two tall wide doors that open out like giant cupboard doors. As you step up to the door standing ajar, you hear soft sobbing coming from the garage. You pull the door open and see an old man sitting, legs crossed, on the garage floor. He is leaning against a wooden post, hunched over. His left hand loosely is gripping a silver revolver which rests on his left thigh. As you think back to what you've seen in the house, you have a pretty good idea why this man sits here with a loaded gun. You are a bit afraid to speak--unsure of what his reaction will be if he is startled--but also feel a need to say something...anything... \n At this point in the game you can use the commands talk, leave, help, or quit.", "You begin to speak in a slow soft voice. You speak simply, as if the man is known to you and you to him. You tell him he will be okay. You tell him he is strong enough to move forward, for Julia. He slowly looks up at you with tears running down his face and tells you he is 'all alone now, all alone...' His head then droops to his chest once again, and his tears resume their fall to his lap. 'I haven't been alone a single day since marrying her. ...and now there is no one' the man says, through sobs. Part of you wants to run, to seek the cool fresh air and freedom which outside provides. Freedom from the grief which fills this dark opressive space and threatens to suffocate you both. The other part of you wants to say the right thing, the thing that will make it survivable, the words you don't know, and that part is very afraid of saying the wrong thing. /n You can use the command continue or leave.", "You take a slow deep breath of hot heavy air, move over to the man, and sit next to him on the floor. You say 'We are never really alone. Our loved ones are always in our hearts and minds, and things they have touch surround us daily. And people we've never met walk into our lives...at the most unexpected times. The man tilts his head toward you looks at you for a moment, closes his eyes and nods his head. You lightly lay your right on the revolver and take the gun from his hand. The man does not resist. He burries his face in his hands and the tears come again as he greevs for his wife. You sit sit quietly and an rub his back for a long while. When his sobs begin to slow, you tell him your are going to the house to get him a glass of water. You exit the garage, with the intent to call the police to report the death, and absent mindedly pull out your cell phone. There, on the east side of the property, outside a small dark barn full of more grief than you had ever experienced, you find two bars of reception. More than enough to make a call.");

      entry.AddRoom("north", hallA);
      entry.AddRoom("east", hallE);
      hallA.AddRoom("south", entry);
      hallA.AddRoom("north", hallB);
      hallB.AddRoom("south", hallA);
      hallB.AddRoom("west", library);
      //hallB.AddRoom("north", lockedDoorA);//need key
      lockedDoorA.AddRoom("north", kitchen);//lockedDoorA is the safe Room
      lockedDoorA.AddRoom("south", hallB);
      kitchen.AddRoom("east", diningRoom);
      kitchen.AddRoom("south", lockedDoorA);
      library.AddRoom("east", hallB);
      hallE.AddRoom("east", hallF);
      hallE.AddRoom("west", entry);
      // hallE.AddRoom("north", stairs);//need flashlight
      // hallF.AddRoom("north", stairs);//need flashlight
      hallF.AddRoom("west", hallE);
      hallF.AddRoom("east", livingRoomSW);
      livingRoomSW.AddRoom("east", livingRoomSE);
      livingRoomSW.AddRoom("north", livingRoomNW);
      livingRoomSW.AddRoom("west", hallF);
      livingRoomSE.AddRoom("west", livingRoomSW);
      livingRoomSE.AddRoom("north", livingRoomNE);
      livingRoomNE.AddRoom("south", livingRoomSE);
      livingRoomNE.AddRoom("west", livingRoomNW);
      livingRoomNW.AddRoom("south", livingRoomSW);
      livingRoomNW.AddRoom("east", livingRoomNE);
      livingRoomNW.AddRoom("north", hallC);
      hallC.AddRoom("north", hallD);
      hallC.AddRoom("south", livingRoomNW);
      hallC.AddRoom("east", bathroom);
      hallC.AddRoom("west", closet);
      closet.AddRoom("east", hallC);
      bathroom.AddRoom("west", hallC);
      hallD.AddRoom("south", hallC);
      hallD.AddRoom("east", nursery);
      hallD.AddRoom("", lockedDoorB);//need key
      nursery.AddRoom("west", hallD);
      lockedDoorB.AddRoom("west", familyRoomE); //lockedDoorB is playRoom
      lockedDoorB.AddRoom("south", hallD);
      familyRoomE.AddRoom("west", familyRoomW);
      familyRoomE.AddRoom("east", lockedDoorB);
      familyRoomW.AddRoom("east", familyRoomE);
      familyRoomW.AddRoom("west", diningRoom);
      diningRoom.AddRoom("east", familyRoomW);
      diningRoom.AddRoom("west", kitchen);
      stairs.AddRoom("north", secondFloorLanding);
      stairs.AddRoom("south", hallE);
      secondFloorLanding.AddRoom("west", hallG);
      secondFloorLanding.AddRoom("east", hallH);
      secondFloorLanding.AddRoom("south", stairs);
      hallG.AddRoom("north", hallI);
      hallG.AddRoom("west", room22);
      hallG.AddRoom("east", secondFloorLanding);
      hallI.AddRoom("west", room23);
      hallI.AddRoom("east", room28);
      hallI.AddRoom("south", hallG);
      hallH.AddRoom("west", secondFloorLanding);
      hallH.AddRoom("east", room27);
      hallH.AddRoom("north", hallJ);
      hallJ.AddRoom("west", room28);
      hallJ.AddRoom("south", hallH);
      hallJ.AddRoom("east", room26);
      room28.AddRoom("east", hallJ);
      room28.AddRoom("west", hallI);
      room28.AddRoom("garage", garage);

      _allRooms.Add(stairs);//this gives you access to rooms in the if function! Thanks Jake!
      _allRooms.Add(familyRoomW);
      _allRooms.Add(secondFloorLanding);
      _allRooms.Add(lockedDoorA);
      _allRooms.Add(lockedDoorB);
      _allRooms.Add(hallB);
      _allRooms.Add(garage);
      _allRooms.Add(hallD);
      //ITEMS ARE HERE \/

      Item flashlight = new Item("flashlight", "This is a safty-yellow and black flashlight.");
      Item bronzeKey = new Item("bronzeKey", "This key is bronze in color and has a round head. It is clipped to a homemade key chain. The keychain looks like it was made by a child.");
      Item silverKey = new Item("silverKey", "This key is silver in color and has a square head. It is attached to a small plastic rosebud key chain.");
      Item phone = new Item("phone", "This black push button phone has probably been sitting on this table since the late 1970s. The table is covered in a fine layer of dust.");//do a userAction on programs that says this ends the game early with a score of x/y.
      // Item items = new Item("items", "Jewlery, cash and a camera.");//do a userAction on programs to say this ends the game with a loss and a score of 0/x.


      closet.Items.Add(flashlight);
      library.Items.Add(bronzeKey);
      livingRoomNE.Items.Add(silverKey);//I REALLY WANT THIS IN THE DESK. CAN I PUT AN ITEM IN AN ITEM?
      familyRoomW.Items.Add(phone);
      // lockedDoorA.Items.Add(items);//THIS SHOULD BE AN AUTO LOOSE CASE

      //USE ITEMS IS HERE \/

      flashlight.Use.Add(closet, "You flick on the flashlight to test the batteries. The beam is nice and strong and sends a beam of light to the top of the closet. As you look up you see a fluffy white smoosh-faced cat with a disgrunteled look glaring back at you. You are a bit startled at first, then you realize this is a dead cat--a cat that has been stuffed after its passing. As your heart rate returns to normal, you reflect on the oddneeds of stuffing a pet for a keepsake then relegating it to a closet as you would an unworn jacket. You shudder as the creepiness of it all finally hits you.");

      flashlight.Use.Add(stairs, "You flick on the flashlight and begin to climb the stairs to the second floor. It is surprisingly dark up here. As you get to the top of the stairs you realize there is a window over the stairs looking south that has been haphazardly covered with cardboard and duct tape.");

      bronzeKey.Use.Add(lockedDoorA, "You push the bronze key into the door's lock and feel a satisfying turn as you twist the key.");

      silverKey.Use.Add(lockedDoorB, "You fit the silver key into the door's lock and feel a satisfying turn as you twist the key.");

      phone.Use.Add(familyRoomW, "You pull out your auto club card and pick up the phone. You tell the operator what you need and the location of your car. You are put on hold, and transfered to another operator. The new operator requests the same information you already supplied. When she is done, she tells you a tow truck should arrive at the car in about an hour. You let them know you are at least an hour away on foot, and the operator promises to pass this information along to the driver. You hang up the phone, leave the house, and start your walk back to your car.");//THIS SHOULD END THE GAME.

      CurrentRoom = entry;
    }

    public void TakeItem(Item item)
    {
      CurrentPlayer.Inventory.Add(item);
      CurrentRoom.Items.Remove(item);
      Console.WriteLine("You have the " + item.Name);
      GetUserAction();
    }
    public void UseItem(string itemName)
    {
      string flashlight = "flashlight";
      string bronzeKey = "bronzeKey";
      string silverKey = "silverKey";
      string phone = "phone";

      Item result = CurrentPlayer.Inventory.Find(strawberry => strawberry.Name == itemName);

      if (result != null)
      {
        if (itemName == flashlight)
        {
          if (CurrentRoom.Name == "hallE" || CurrentRoom.Name == "hallF")
          {
            CurrentRoom = CurrentRoom.Stairs;
          }

          // var stairs = new Room("Staircase", "You are on the grand staircase between the first and second floor...");//NEED TO ADD AN UNLOCK IF HAVE FLASHLIGHT. NEED TO WRITE 2ND FLOOR
          // stairs.AddRoom("north", secondFloorLanding);

        }
        if (itemName == bronzeKey)
        {
          if (CurrentRoom.Name == "hallB")
          {
            CurrentRoom = CurrentRoom.LockedDoorA;
          }
        }
        if (itemName == silverKey)
        {
          if (CurrentRoom.Name == "hallD")
          {
            CurrentRoom = CurrentRoom.LockedDoorB;
          }
        }
        if (itemName == phone)
        {
          Phone();
         
        }
      }
      else
      {
        Console.WriteLine("You do not have the necessary item.");
      }
      GetUserAction();
    }

    public void Phone()
    {
      Console.WriteLine("You pull out your auto club card and pick up the phone. You tell the operator what you need and the location of your car. You are put on hold, and transfered to another operator. The new operator requests the same information you already supplied. When she is done, she tells you a tow truck should arrive at the car in about an hour. You let her know you are at least an hour away on foot, and the operator promises to pass this information along to the driver. You hang up the phone, leave the house, and start your walk back to your car.");
    }
    public string GetUserAction()
    {
      Console.WriteLine("----------------------------------");
      Console.Write("What do you do: ");
      return Console.ReadLine();
    }

    public void DEBUG()
    {
      CurrentRoom.DEBUG();
    }
  }
}