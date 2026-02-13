# Zen World VR 🌌🌿

**A relaxing VR exploration experience for Meta Quest 3.**

Zen World is an immersive virtual reality application built in Unity. It features a central "Zen Garden" hub where players can relax, explore, and unlock portals to different atmospheric worlds using a physical key-and-lock mechanic.

## 🎮 Features
* **Immersive Main Menu:** Starts in a calming 360° video environment with floating UI.
* **Physics-Based Interaction:** Realistic grabbing and throwing mechanics for keys and objects.
* **Portal System:** Find specific keys to unlock doors to new worlds:
    * 🗝️ **Northern Lights:** A world under the aurora borealis.
    * 🗝️ **Van Gogh World:** A stylistic artistic environment.
* **Diegetic UI:** Tutorial systems integrated into the world (stone tablets) rather than floating menus.
* **Smooth Locomotion:** Continuous movement and snap turning designed for comfort.

## 🛠️ Technical Stack
* **Engine:** Unity 2022.3.62
* **Platform:** Android (Meta Quest 3)
* **Toolkit:** XR Interaction Toolkit (VR Core Template)
* **Plugin:** OpenXR (Meta Quest Support)
* **Scripting:** C#

## 🚀 Installation & Setup

### Prerequisites
* Unity Hub
* Unity **2022.3.62** (or compatible LTS version)
* Android Build Support modules (OpenJDK, Android SDK/NDK) installed in Unity.
* **Git LFS** (Large File Storage) is required to pull the 360° video assets.

### Getting Started
1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/msukharam963/Zen-world.git](https://github.com/YourUsername/Zen-world.git)
    ```
    *Note: If the video files are missing, run `git lfs pull`.*

2.  **Open in Unity:**
    * Add the folder to Unity Hub.
    * Open the project. It may take a few minutes to import assets.

3.  **Build Settings:**
    * Go to `File > Build Settings`.
    * Ensure Platform is switched to **Android**.
    * Texture Compression: **ASTC**.
    * **Scene Order:**
        1. `MainMenu` (Index 0)
        2. `ZenGarden`
        3. `NorthernLights`
        4. `VanGoghWorld`

4.  **Run on Device**
