# Week 1 Tasks

## Task 1:

Write a program to calculate the first 20 Fibonacci numbers in sequence.
Print each number as it is calculated.

## Task 2:

Write a program to draw a solid square of # symbols.

The program must use a variable to decide how big the square is.

I.E.
```cs
int size = 5;
```

output:
```bash
#####
#####
#####
#####
#####
```

## Task 3

Write a program to draw a hollow square of any symbol.

The program must use two variable to decide how big the square is, and which symbol to draw.

I.E.
```cs
int size = 5;
char symbol = '%';
```

output:
```bash
%%%%%
%   %
%   %
%   %
%%%%%
```
## Task 4

Write a program that stores a list of names of people and a second list of telephone numbers.

Use a variable to display the name and number of one person.

I.E.
```cs
int num = 3
Console.WriteLine($"{name[num]} - {telephone[num]}");
```
## Task 5

Write a program to randomly draw a card from a deck of cards.

Hint, you could use:

```csharp
Random rnd = new Random();
int card   = rnd.Next(52);     // creates a number between 0 and 51
```

The program should "display" the card.

You could use these...

♠️
♥️
♦️
♣️

with something like this:
![[AxgaNX3.png]]

Bonus:
What about drawing two cards at the same time?