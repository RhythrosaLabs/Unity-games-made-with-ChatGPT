
# Space Explorer Game Implementation Guide

## Assets
Place all the provided assets in the 'Assets' folder of your Unity project.

## Scripts
Place the provided scripts in the 'Scripts' folder within your Unity project.

## Setup Instructions
1. **Setting up the Scene**:
   - Create a new 2D Unity project.
   - Drag and drop the space background into the scene to set it as the background.
   - Add the spaceship, asteroids, and stars into the scene.

2. **Attaching Scripts**:
   - Attach the 'PlayerController' script to the spaceship GameObject.
   - Attach the 'AsteroidController' and 'StarController' scripts to the respective prefabs.
   - Create an empty GameObject named 'GameManager' and attach the 'GameManager' script to it.
   - Attach the 'CollisionHandler' script to the spaceship GameObject.

3. **Configuring UI Elements**:
   - Set up UI elements for the score display and game over screen according to your design preference.
   - Link these UI elements to the 'GameManager' script.

4. **Final Steps**:
   - Adjust the speed and other parameters in the scripts as needed.
   - Test the game to ensure everything is working as expected.

Enjoy your game development journey!
