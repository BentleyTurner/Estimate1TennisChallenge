# :tennis: Tennis Calculator Coding Challenge :clipboard:
Welcome to my Attempt at the Tennis Calculator Challenge.

## How to Run ⚙️
### Prerequisites :syringe:
Install .Net 7.0 from the following link: https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70

### Commands :hammer:
Open your CLI and navigate to the unzipped folder

``` bash
cd Estimate1TennisChallenge
dotnet run <PATH TO INPUT FILE>
```
You will then have a Console opened for you with further instructions

If you wish to run the tests then run the following (commands are assuming you are still in the /Estimate1TennisChallenge folder from previous command)
``` bash
cd ..
dotnet test
```

## Assumptions :thought_balloon:
I Assumed that the queries detailed in the challenge (Score Match & Games Player) were intended as commands given to the console after the program is run rather than as CLI arguments. I made this assumption because I thought it result in a better user experience (having the avaiable commands given to the user and allowing them to try again if giving an invalid command or send another command if they wish to send multiple).

## Overall Solution details :mag_right: 
### Folder Structure :open_file_folder: (Excluding .NET project files)
```
| Estimate1TennisChallenge
  | Models
      Match.cs
        Handles the Information about the match including: The Players playing, their current points & their set wins
      Player.cs
        Simple class with: Name, Games Won & Games Lost
      Set.cs
        Simple class with: Winner & Loser
  Program.cs
    Entry Point for Program that outputs to user and handles the reading of input
  Utils.cs
    Utility functions for searching for Players and Matches
  
| Esimate1TennisChallengeTest
  Fixtures.cs
    All Mock data used in tests
  MatchTest.cs
    Testing the core logic for how a match will work
  UtilsTest.cs
    Testing search and return functions for players and games
  TestInput.txt
    An example input file for testing
```

