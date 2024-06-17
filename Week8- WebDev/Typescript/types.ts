// Simple types
/*
    Basic types with TypeScript
    string
    number
    boolean
    null
    undefined

    The syntax for typing in TS is the following:

    let referenceName : type = value;    * colon is important!!!

*/

let isDone: boolean = false;
let age: number = 26;
let firstName: string = 'John';
let u: undefined = undefined;
let n: null = null;

//can't reassign a value to something that doesn't match its declared datatype

//isDone = "Hello";

// Arrays
// syntax:  type[] or Array<type>

let numberList: number[] = [1, 2, 3];
let genericNumberList: Array<number> = [1, 2, 3];

// Tuple
// tuples let you define an array with fixed types and length

let tupleExample: [string, number];
tupleExample = ["hello", 50]
//tupleExample = [10, 'hello']; //error, incorrect

// Enums
// allow you to define a set of named constants

enum Color {
    Red,
    Green,
    Blue
}

enum StatusCodes{
    Ok = 200,
    Created = 201,
    NotFound = 404
}

let colorExample: Color = Color.Green;
console.log(colorExample); // 1

// String enums
// must define every single value, there's no default

enum CardinalDirections{
    North = "North",
    East = "East",
    South = "South",
    West = "West"
}

// Any
// any type lets you opt-out of type checking
// this gives you loose typing just like in JavaScript

let notSure: any = 5;
notSure = "Hello";
notSure = false;

// void
// the void type is used for functions that don't return a value

function sayHello() : void{
    console.log("hello!");
}

// never
// never represents values that never occur
// It's used for functions that always throw an error or never return

function error(message: string): never {
    throw new Error(message);
}