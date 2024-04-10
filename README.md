# Wall Panel Placing Project POC Readme


## Overview:

This Unity project is designed to demonstrate the implementation of wall panels in a virtual environment using the XR Interaction Toolkit. The project allows users to select wall panels from a carousel and apply them to a 3D plane representing a wall within the scene.

## Features:

Selection of wall panels from a carousel interface.
Dynamic application of selected wall panel textures to the wall plane.
Cost calculation based on the selected wall panel.

## Requirements:

Unity 2022.3,20f1 or later.
XR Interaction Toolkit.
Meta Quest (for deployment).

## Installation:

1. Clone or download the project repository.
2. Open the project in Unity.
3. Ensure that the XR Interaction Toolkit package is imported into the project.
4. Set up the scene with the wall plane and carousel of wall panels as required.

## Usage:

Run the project in Unity.
1. Ensure that your Meta Quest device is connected and configured for deployment.
2. Navigate the scene using the Meta Quest controllers.
3. Point at the desired wall panel using the XR Ray Interactors on the controllers.
4. Press the designated input (configured in the Unity Input System) to select and apply the wall panel to the wall plane.
T5. he cost of the selected wall panel will be displayed in the scene.

## Script Overview:

WallPanelScript.cs: This script handles the interaction logic between the XR Ray Interactors and the wall panels. It applies the selected wall panel's texture to the wall plane and calculates the total cost.

## Customization:

1. Modify the input actions (leftPointAction and rightPointAction) in the WallPanelScript.cs script to change the controller inputs for selecting wall panels.
2. Adjust the tiling properties (tiling) in the SetMaterialToWall method of the WallPanelScript.cs script to customize the tiling of the wall panel texture.

## Additional Notes:

This is a basic example. You can extend it by:
1. Implementing a more complex carousel system with rotation.
2. Adding functionality to change the cost calculation based on selected panel area or other factors.
3. Enhancing the visual design of the wall panels and user interface elements.
4. For further information on XR Interaction Toolkit, refer to the Unity documentation: https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/.

## Credits-
Developed by Garvit Dadheech.
