
# Mystic Quest - Unity Game Setup Guide

## Assets Implementation:
- **Sprites:** Import the provided wizard, creature, and environment sprites into the Unity 'Assets' folder.
- **Setting up the Scene:**
  - Create a 2D Unity project and open a new scene.
  - Drag and drop the environment sprites to create your mystical forest.
  - Add the wizard and creature sprites to the scene.

## Script Attachment and Configuration:
- **PlayerController:** Attach this script to the wizard sprite.
  - Set the 'Speed' and 'Jump Force' in the inspector to tweak movement.
- **EnemyAI:** Attach this to each creature sprite.
  - Set the 'Move Speed' and adjust the 'Ground Detection' transform.
- **ItemCollector:** Attach to the wizard for collecting runes and potions.
- **HealthManager:** Attach to the wizard to manage health points.
- **LevelManager:** Attach to an empty GameObject called 'LevelManager'.

## UI Setup:
- **Creating UI Elements:**
  - Use Unity's UI system to create a health bar and spell indicator.
  - Link these to the respective variables in the 'HealthManager' and 'PlayerController' scripts.

## Gameplay Tips:
- **Level Design:** Carefully place platforms, runes, and enemies to create challenging but fair levels.
- **Balancing:** Playtest and adjust the speed, health, and enemy patterns for an enjoyable experience.

## Final Notes:
- Experiment with the settings and scripts to find what works best for your vision of the game.
- Regularly test the game to ensure everything functions as expected.

Thank you for using these assets and scripts for 'Mystic Quest'. Enjoy building your game!
