console.log("Hello World!");

// Datatypes

/*
    in statically typed languages like C#, you must declare the
    data type of the variable first before you can even assign something to it

    string name = "Mike";
*/


let name = "John"; //string
let age = 30; // number
let isStudent = false; // bool
let car = null; //null
let address; // undefined

let uniqueID = Symbol("1"); // used for data types that are the same but want it to be unique in some way
let uniqueID2 = Symbol("1");
console.log(uniqueID == uniqueID2)

// you can reassign variables to any data, it is loosely typed

age = "50";

console.log(name);
console.log(age);
console.log(address);

//Object
//syntax similar to JSON
// begins with {} and properties inside of it follow a key value pair
let person = {
    name: "John",
    age: 30
};

console.log(person);

//Array
// can have any data type within it, it's not restricted
// recommended to stick to one, but if you need multiple, that's cool too

let hobbies = ["reading", "writing"]
console.log(hobbies);

// function
// repeatable bits of code
//don't define what it returns
//just use function, the name of the function, and the parameters
function greet() {
    console.log("Hello");
}

greet(); // invoking/calling the function

