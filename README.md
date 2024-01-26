Generic RPG Combat System (henceforth referred to as "the game") is a half-game demonstrating the concept of a "turn-based combat system". Currently the project is in a partially-functional limbo.

The game uses a command line input system to control a set of 3 player characters and an RNG system to control a set of 3 enemy characters. The goal of the game is for the player characters to defeat all the enemy characters. 

The win condition is when there are no computer-controlled enemies remaining. The loss condition is when there are no player-controlled characters remaining. If these conditions are both false, then the game is still in session.

The game RNG consists of a roll to determine attack effectiveness, which is added to the base damage before the damage is affected by attacker and defender stats. 

The game determines the order of who's turn it is via a speed stat. This does not change in the game, it is assumed that speed is determined long before the battle starts.
