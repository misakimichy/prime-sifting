# Prime Sifting

#### _C#, .NET: Prime Sifting, 9/26/2019_

## Description
Create a console application which given a number, write a method that returns all of the prime numbers less than that number.
Prime number is a whole number greater than 1 and that can only be divided by itself.

## About this Application:
I used the Sieve of Eratosthenes to solve this.

Here is how the Sieve of Eratosthenes works to find a number up to a given number:

- Create a list of numbers from 2 through n: 2, 3, 4, ..., `number`.
- Initially, let `prime` equal 2, the first `prime` number.
- Starting from `prime`, remove all multiples of prime from the list.
- Increment `prime` by 1.
- When you reach `number`, all the remaining numbers in the list are primes.

Here is the reference: <br>
YouTube - [Prime Numbers - Sieve of Eratosthenes by 
Region 10 ESC](https://www.youtube.com/watch?v=V08g_lkKj6Q)

## Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Return prime numbers from 2 to input number** | 10 | 2, 3, 5, 7 |
| **Ask number again when user types less than 1** | -5 | "We only accept a number bigger than 2. Please enter a positive whole number bigger than 1." |
| **Ask number again when user gives non-numeric input**| "Hello" | "We only accept a number. Please enter a positive whole number bigger than 1." |
</br>

## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/misakimichy/prime-sifting.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 under the MIT License