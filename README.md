[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- Seeds planted UI
	- Let players see a number of seeds they planted
	- Starts at 0
	- increases every time space bar is pressed
- Seeds remaining UI
	- Let players see number of seeds they have left to plant  
	- Stops at 5 
	- Restricts player's ability to plant
- Player 
	- bunny
	- Movement (WASD)
	- Planting
		- Players can plant seeds 
		- Decreases seed count 
		- Planted at player location 
		- Press space to plant
- Seeds
	- Plant sprite 
	- Seeds planted at player location

## Devlog
In the player class, I wrote the code for the player movement, using the transform componenet, in the update method. The update method runs every frame meaning player movement is constantly being checked for. Next I focused on getting the UI working, in the Plant Count UI class I set up the UpdateSeeds method to correspond with the vairables _numSeedLeft and _numSeedPlanted. Back in the player class I set up the start method to intialize _numSeedLeft and _numSeedPlanted to 5 and 0, so the player would start off with 5 seeds. I then moved on to getting the seeds to work. I created a prefab of the plan in unity and hooked it up to the player script. In the player script I added to the update() method to include the code for space bar, so everytime the player pressed space the PlantSeed() method would be called. In the PlantSeed method I worked on creating a plant in the players current location and updating the UI. First I used an if statement to check if the _numSeedsLeft was greater than zero, then I used Instantiate with the parameters original, position, and rotation. For original I used the plant prefab, for position and rotation I got the players position using it's transform component. I finally set up the UI by subtracting and adding from _numSeedsLeft and _numSeedsRemaining and then calling the UpdateSeeds() method again. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
