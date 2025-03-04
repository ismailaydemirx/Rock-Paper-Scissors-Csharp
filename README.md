# Rock-Paper-Scissors Console Application

**Rock-Paper-Scissors Console App** is a simple game built to run in the console, allowing users to play the classic Rock-Paper-Scissors game against the computer. The application features multiple difficulty levels, providing a varied experience for the player.

## Features

- **Difficulty Levels**: Three levels of difficulty to choose from, each offering different strategies for the computer’s moves.
- **User Interaction**: Simple console-based interaction where users input their choices and view the game results.
- **Score Tracking**: The game keeps track of the user’s and computer’s scores throughout the game session.

## Getting Started

### Prerequisites

- **.NET Core SDK** (version 3.1 or later)

### Installation

1. Clone the repository to your local machine:
   
   ```bash
   git clone https://github.com/ismailaydemirx/Rock-Paper-Scissors.git
   ```

2. Navigate to the project directory:

   ```bash
   cd Rock-Paper-Scissors
   ```

3. Build and run the application:

   ```bash
   dotnet run
   ```

### Gameplay Instructions

Upon launching the application, follow these steps to play:

1. **Select Difficulty**: The game will prompt you to choose a difficulty level:
   - **Easy (Level 1)**: The computer randomly selects its move.
   - **Medium (Level 2)**: The computer tends to choose the winning move more frequently.
   - **Hard (Level 3)**: The computer predicts and counters your moves based on previous selections.

2. **Make Your Move**: Enter your choice from the following options:
   - `R` for Rock
   - `P` for Paper
   - `S` for Scissors
   - `0` to exit the game

3. **Game Result**: The game will display the result, showing both your choice and the computer's, along with the outcome (Win, Lose, or Draw).
   
4. **Repeat or Exit**: After each round, the game will allow you to either play again or exit by pressing `0`.

### Sample Gameplay

```plaintext
Rock-Paper-Scissors Game
------------------------
Select the difficulty level:
1. Easy
2. Medium
3. Hard
0. Exit
Enter the difficulty level (1-3): 2

R. Rock
P. Paper
S. Scissors
0. Exit
Make your choice (R/P/S): R

Your Choice: Rock
Computer Choice: Scissors
Result: You Win!

Press Enter to continue...

R. Rock
P. Paper
S. Scissors
0. Exit
Make your choice (R/P/S): P

Your Choice: Paper
Computer Choice: Rock
Result: You Win!

Press Enter to continue...

R. Rock
P. Paper
S. Scissors
0. Exit
Make your choice (R/P/S): S

Your Choice: Scissors
Computer Choice: Paper
Result: You Win!

Press Enter to continue...

R. Rock
P. Paper
S. Scissors
0. Exit
Make your choice (R/P/S): 0

Exiting the game...

Final Scores
------------
User Score: 3
Computer Score: 0

Thanks for playing!
```

## Developer

This project was developed by **Ismail Aydemir** as a small, fun project to practice object-oriented design and console application development in C#.

---
