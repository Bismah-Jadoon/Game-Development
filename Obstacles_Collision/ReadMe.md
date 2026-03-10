# Obstacle Collider (Unity Basic Game)

## 🎮 Game Overview

**Obstacle Collider** is a simple beginner game built using the **Unity Engine**.
The player controls a cube and must move through the environment while avoiding obstacles. When the player collides with obstacles, the game counts the number of hits and visually marks the obstacle.

This project demonstrates basic **Unity concepts** such as:

* Player movement
* Collision detection
* Game object interaction
* Script communication
* Basic physics
* Object rotation and timed events

---

## 🛠 Built With

* **Engine:** Unity
* **Language:** C#
* **Core Unity Systems Used:**

  * Rigidbody Physics
  * Collision System
  * Transform System
  * Input System

---

## 🎯 Gameplay

1. The player controls a cube using keyboard input.
2. The goal is to move through the environment while navigating around obstacles.
3. When the player collides with a wall or obstacle:

   * The obstacle changes color to **red**.
   * The collision is counted.
4. Some obstacles rotate or drop after a delay, increasing the challenge.

---

## ⌨ Controls

| Key             | Action        |
| --------------- | ------------- |
| W / Up Arrow    | Move Forward  |
| S / Down Arrow  | Move Backward |
| A / Left Arrow  | Move Left     |
| D / Right Arrow | Move Right    |

---

# 📂 Scripts Explanation

## 1️⃣ Mover.cs

**Purpose:** Controls the player movement.

### Features

* Prints instructions when the game starts.
* Moves the player using keyboard input.
* Uses `Input.GetAxis()` for smooth movement.

### Key Concepts

* Player movement
* Transform translation
* Frame-rate independent movement using `Time.deltaTime`

---

## 2️⃣ Dropper.cs

**Purpose:** Creates a dropping obstacle after a delay.

### How It Works

1. The object starts invisible.
2. Gravity is disabled.
3. After a few seconds (`TimeToWait`), the object appears and falls.

### Key Concepts

* Component referencing
* Rigidbody physics
* Timed events using `Time.time`

---

## 3️⃣ Scorer.cs

**Purpose:** Counts how many times the player hits obstacles.

### How It Works

* Each time the player collides with an object that is **not already hit**, the counter increases.
* The total number of hits is printed in the Unity Console.

### Example Output

You have bumped into the Wall 3 times

### Key Concepts

* Collision detection
* Object tags
* Tracking game events

---

## 4️⃣ Spinner.cs

**Purpose:** Rotates obstacles continuously.

### How It Works

* The object rotates every frame using `transform.Rotate()`.

### Key Concepts

* Transform rotation
* Frame updates using `Update()`

---

## 5️⃣ WallsObstacles.cs

**Purpose:** Changes obstacle color when the player collides with it.

### How It Works

* Detects collision with the player.
* Changes the obstacle color to **red**.
* Tags the object as `"Hit"` so it is not counted again.

### Key Concepts

* Collision detection
* Material color change
* GameObject tagging

---

# ⚙ How the Scripts Work Together

1. **Mover.cs**
   Controls the player's movement.

2. **WallsObstacles.cs**
   Detects collision with the player and marks the obstacle as hit.

3. **Scorer.cs**
   Counts the number of times the player collides with obstacles.

4. **Spinner.cs**
   Adds moving/rotating obstacles to make gameplay more dynamic.

5. **Dropper.cs**
   Adds falling obstacles that appear after a delay.

Together, these scripts create a simple obstacle navigation game.

---

# 🧠 Learning Objectives

This project helps beginners understand:

* Unity script lifecycle (`Start()`, `Update()`)
* Player input handling
* Rigidbody physics
* Collision detection
* GameObject components
* Debugging with `Debug.Log()`

---

# 🚀 Future Improvements

Possible improvements for this game include:

* Adding a **timer or score UI**
* Creating **levels**
* Adding **sound effects**
* Implementing a **win/lose system**
* Adding **animations and better visuals**

---

# 📜 License

This project is for **educational and learning purposes**.

