# Country Trivia Game

## Project Description
**Country Trivia Game** is an interactive, text-based C# Console Application developed as a final project for **ITEC 102** at **Laguna State Polytechnic University – College of Computer Studies**. Designed as an educational tool to test and enhance world geography and history knowledge, the application allows players to choose specific countries and answer randomized multiple-choice questions across three progressive difficulty levels: **Easy**, **Medium**, and **Hard**.

Utilizing core C# programming constructs—such as single and multi-dimensional arrays, conditional logic (`if-else`), nested `while` and `for` loops, and random number generation—the system automates game flow, sanitizes case-insensitive user inputs, computes tiered scores, and displays a final accumulated score summary upon exiting.

---

## Objectives
* **General Objective:** To develop a functional C# Console Application that engages users in an interactive country-based trivia game with progressive difficulty tiers and dynamic score tracking.
* **Specific Objectives:**
  * Manage main menu navigation and country selection modules through a clear text-based console interface.
  * Accept, sanitize, and validate user text inputs for case-insensitive country and answer matching.
  * Implement conditional statements and looping structures to randomize question sets and execute difficulty progression (Easy → Medium → Hard).
  * Compute dynamic scores based on difficulty point weights (**Easy = 1 pt**, **Medium = 2 pts**, **Hard = 3 pts**).
  * Display immediate answer feedback and an organized final accumulated score summary upon session termination.

---

## Group Members
* **Castillo, Christian K.** – Proponent / Student Researcher
* **Monecia, Jeus Derren P.** – Proponent / Student Researcher
* **Bueser, Daniell Aaron N.** – Proponent / Student Researcher

---

## Programming Language & Tools Used
* **Programming Language:** C# (.NET Console Application)
* **Core Concepts Implemented:** Variables, Primitive Data Types, Console I/O, String Manipulation (`.ToLower()`, `.ToUpper()`), Single & Multi-Dimensional Arrays, Conditional Statements (`if-else`), Nested Loops (`while`, `do-while`, `for`), and the `Random` class.

---

## System Features
* **Country Selection & Aliases:** Supports trivia modules for 9 European countries with flexible name and country-code inputs:
  * **United Kingdom** (`united kingdom`, `uk`, `britain`, `gb`, `great britain`)
  * **France** (`france`, `fr`, `fra`)
  * **Germany** (`germany`, `deutschland`, `de`)
  * **Spain** (`spain`, `es`)
  * **Italy** (`italy`, `it`)
  * **Poland** (`poland`, `pl`)
  * **Denmark** (`denmark`, `dnk`, `dk`)
  * **Sweden** (`sweden`, `se`, `swe`)
  * **Russia** (`russia`, `ru`, `rus`)
* **Randomized Question Selection:** Uses a `Random` generator to pick from 3 distinct question sets per country so gameplay stays fresh across sessions.
* **Progressive Difficulty Tiers & Weighted Scoring:** Each round presents three multiple-choice questions (`A`, `B`, or `C`) in ascending difficulty:
  * **Easy Question:** +1 point
  * **Medium Question:** +2 points
  * **Hard Question:** +3 points
* **Real-Time Feedback & Answer Correction:** Immediately notifies the user whether their response is `"Correct!"` or `"Wrong!"` and reveals the right answer if missed.
* **Input Validation & Graceful Exit:** Handles invalid country entries gracefully (`"Not a Valid Country or Coming soon"`) and allows users to exit anytime by entering `X` to view their **Total Accumulated Score**.
