# Console Game Checkpoint

### The Setup

As you begin working on a console game the basic requirements of any good console game will allow users to:
  - Move about a set of rooms
  - Get a description of the room they are in
  - Get Help - Shows a list of all available commands
  - Use Items
  - Give Up 
  - Restart
  
To help you out with some of these basic features will notice that you already have some interfaces that have been built. These interfaces are designed to help ensure you implement the basic requirements of a console game. 

### Step 1 -  Satisfy the Interfaces `Total Points: 10`

To satisfy the interfaces you will need to ensure that your classes implement all of the features of the provided interfaces... You cannot remove anything from any of the interfaces. 

Requirements:
- `10 points`: The Basic Features of the game work
  - `2 Go <Direction>` Moves the player from room to room ***DONE***
  - `2 Use <ItemName>` Uses an item in a room or from your inventory ***DONE***
  - `2 Take <ItemName>` Places an item into the player inventory and removes it from the room ***DONE***
  - `2 Help` Shows a list of commands and actions ***DONE***
  - `2 Quit` Quits the Game ***DONE***

### Step 2 - Control the Game Loop `Total Points: 10`

We have provided a basic story and map if you are not creative or simply don't want to spend your time thinking of a story to play your game. Following the provided story is not required however creating some sort of experience is. 

Your Game must implement the following features

Requirements:
- `10 points`: Game Needs
  - `1`: You have at least 4 rooms ***DONE***
  - `1`: You have at least 1 usable item ***DONE***
  - `1`: You have at least 1 item that can be taken ***DONE***
  - `1`: You are rewarded points for your efforts **ITS 2AM AND I DONT CARE ABOUT THIS...**
  - `1`: You can lose the game due to a bad decision ***DONE***
  - `2`: You have at least 1 room that changes based on an item use **DOES THE FLASHLIGHT COUNT?**
  - `1`: When the player enters a room they get the room description ***DONE***
  - `1`: The Player can see the items in their inventory ***DONE***
  - `1`: The Player can win the game***DONE***
  
  
### BONUS - Some enhancing features `Total Points: 5`

Requirements: 
- Typing `go north` all of the time gets laborious accomadate the following shortcuts without having to use the word go
  - n, s, e, w, 
- Try changing the console color or adding some beeps for dramatic effect**DOES THE TEXT COLOR COUNT?**
- Clear the console when appropriate ***DONE***
- The user should know when its their turn try formatting the users input with something like this everytime its the users turn to type
  - What do you do: __________________ // <- Their Answer on the same line ***DONE**

### Finished?
When You are finished please slack the url for your github repo to your mentor in a DM. Be sure you add this project to your gh-pages if you want credit for it.
