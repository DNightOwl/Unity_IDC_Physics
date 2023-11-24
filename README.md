# Unity Physics Simulation

## Overview

This Unity project showcases the implementation of fundamental physics concepts and joints in Unity. The project includes four scenes: "Physics," "Fixed Joint," "Hinge Joint," and "Spring Joint."

## Features

### Physics Scene

  - **Gravity and Bouncing Balls:** Demonstrates the effects of gravity on bouncing balls with varying physics materials.
  - **Materials and Textures:** Implementation of materials, including transparent glass, and textures for enhanced visual appeal.
  - **3D Models:** Integration of 3D models to create a visually dynamic environment.
  - **Colliders:** Utilization of different colliders such as Mesh Collider, Sphere Collider, and Box Collider.
  - **RigidBody:** Incorporation of RigidBody components for realistic physics interactions.

### Fixed Joint Scene

  - **3D Bridge:** Implementation of a 3D bridge using colliders, Rigidbody, and FixedJoint components.
  - **Collision Interaction:** Showcase of interaction between the falling ball and the bridge when they collide.

### Hinge Joint Scene

  - **3D Door:** Implementation of a 3D door using HingeJoint components, colliders, Rigidbody, material, and textures on the wall.
  - **Automated Movement:** The ball in the scene is scripted to move towards the door to showcase the hinge joint interaction.

### Spring Joint Scene

  - **Invisible String:** Implementation of a 3D scene with an invisible string between a sphere and a cube.
  - **Spring Joint Interaction:** Showcase of interaction between the sphere and the cube using SpringJoint components, colliders, and Rigidbody.

## Getting Started

### Prerequisites

- Unity 2021.3.22 (or later)
- Cinemachine.(if not included in your Unity version)
- Additional assets from the Unity Asset Store (refer to the Asset Store documentation for installation instructions)//TO DO

### Installation

1. Clone the repository to your local machine.<br>
 ```git clone https://github.com/your-username/unity-physics.git```

Open the project in Unity.
Navigate to the desired scene (e.g., Assets/Scenes/PhysicsScene.unity).
Press the play button to experience the physics simulation.

### Usage

Launch the Unity project.
Choose the scene you want to explore (Physics, Fixed Joint, Hinge Joint, or Spring Joint).
Press the play button to initiate the simulation.
Interact with the environment and observe the physics and joint interactions.

## Structure

Assets: Contains project assets, including 3D models, materials, textures, and scenes.
Scripts: Any scripts controlling the physics interactions or joints, if applicable.
Scenes: Scene files for different physics and joint simulations.

### Acknowledgments

- Unity Asset Store contributors for providing assets used in this project.
- [Unity Documentation](https://docs.unity3d.com/Manual/index.html) for reference. //TODO
- This project was developed as part of a virtual reality (VR) training program [The Interactive Digital Center (IDC)](https://eonreality.com/locations/ben-guerir-ma/#:~:text=in%20their%20sector.-,VR%20Innovation%20Academy,-COMPREHENSIVE%20CURRICULUM). The goal of the training was to apply and reinforce various Unity concepts, including 3D environment design, asset integration, scripting and UI integration with VR and AR functionality.
