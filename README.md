
# John Lemon's Haunted Jaunt - Atomic Edition

## Overview

This project is based on the **Unity tutorial**: [John Lemon's Haunted Jaunt - 3D Beginner](https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner?uv=2020.3). It introduces basic Unity concepts like 3D environment setup, player movement, and basic interactions.

In this enhanced version, several additional features and modifications have been implemented to extend the original gameplay and improve the overall experience.

## How to Play

- **Movement**: Use the arrow keys or `WASD` to move John Lemon.
- **Running**: Press `Shift` to make John run, if the health is above 50%.
- **Pause Menu**: Press `Esc` to bring up the pause menu.
- **Health System**: John starts with 100 health points. Various in-game elements can cause damage or allow healing. 

## Features and Modifications

### 1. Fixed Movement Glitch
- Resolved an issue with the original movement controls that caused unintended player behavior.

### 2. Enhanced Movement (Running Mechanic)
- Added a **sprint mechanic** where pressing `Shift` allows the player to run. Running is only possible if the player's health is above 50%.

### 3. Main Menu
- A **main menu** was added to allow the player to start a new game or quit the application.

### 4. Pause Menu
- Added a **pause menu** which can be accessed by pressing `Escape`. It includes the option to resume, go to the main menu, or quit the game.
- All background audio is silenced when the game is paused.

### 5. Health System
- Implemented a **dynamic health system** where the player’s health decreases upon taking damage and increases by collecting health items.
- **Multi-colored health bar**: The health bar changes color based on the player’s health:
  - Green (Full health)
  - Yellow (70% or lower health)
  - Red (30% or lower health)
- If the player’s health drops **below 50%**, running is disabled.
- If the health drops **below 30%**, a pulse sound effect plays, indicating critical health.

### 6. Added Mini-map
- Implemented a **mini-map** using Unity’s render texture feature, which helps the player navigate through the level.

## How to Set Up

1. **Clone the Repository**:  
   Use the following command to clone the project:
   ```
   [git clone <repository-url>](https://github.com/Viraj-Mavani/Haunted-Jaunt-Atomic-Edition.git)
   ```

   or You can download the project files and extract them to a local directory.

2. **Open the Project in Unity**:  
   Open the project in Unity Editor (2020.3 or later).

3. **Run the Scene**:  
   Open the main scene and press the play button to start the game.

## Credits

- **Unity Tutorial**: This project is originally based on the Unity 3D beginner tutorial "[John Lemon's Haunted Jaunt](https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner?uv=2020.3)".
- **Modifications**: All enhancements, including the running mechanic, health system, main menu, pause menu, and mini-map, were implemented by Me.
