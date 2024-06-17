// functions in TS are similar to JS
// We have the ability now to have typed parameters and return types

//regular function
// function reference(param: type): returnType{}
function addNumbers(x: number, y: number): number {
    return x + y;
}

let sum: number = addNumbers(3, 5);
console.log(sum); //8

// Arrow Syntax
// Arrow functions provide a more concise syntax

const multiplyNumbers = (x: number, y: number): number => {
    return x * y;
}

// Anonymouse Functions
// these are functions without a name, often used as arguments to other functions
// you can pass a function as a parameter

setTimeout(function(){
    console.log("this is an anonymous function")
}, 1000);

setTimeout(() => {
    console.log("this is an arrow anonymous function")
}, 1000);

// function overloading
// TS supports function overloading, allowing multiple function signatures for a single function body

function concatenate(x: string, y: string): string;
function concatenate(x: number, y: number): number;
function concatenate(x:any, y: any): any{
    return x + y;
}

let stringResult = concatenate("hello", "world"); // hello world
let numberResult = concatenate(5, 10); // 15

// Optional and Default Parameters
// Optional parameters
// these are specified with a ?

function greetPerson(name: string, greeting?: string): string {
    if(greeting){
        return `${greeting}, ${name}`;
    }else{
        return `Hello there, ${name}`;
    }
}

// Default Parameters
// default parameters provide a way to give a default value if nothing is given

function greetDefault(name: string, greeting: string = "Hello"): string {
    return `${greeting}, ${name}`;
}
// Rest Parameters
// This allows a function to accept an indefinite number of arguments as an array

function summing(name: string, ...numbers: number[]): string {
    let total = numbers.reduce((total, num) => total + num, 0);
    return `${name}, your total is ${total}`;
}
console.log(summing("Mike", 3, 4, 5, 6, 7, 8, 10));
