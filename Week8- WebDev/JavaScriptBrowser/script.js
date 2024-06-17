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

// Type Coercion
/*
    Javascript will automatically convert values from one type to another when necessary
    Can lead to unexpected results if not carefully handled

*/

console.log("6" + 6); // becomes "66" string
console.log("5" - 2); // 3 (number)
console.log("5" * "2"); //10 (number)
console.log("five" * 2); // Nan (Not a Number)

// typeof
// you can use the typeof operator to check what the datatype of a variable is
console.log(typeof NaN); // this is a number

// Variable Scopes

// Function Scope
    // Variables declared inside a function is scoped to that function

//Block Scope
    // Variables declared with let or const are scoped to the block in which they are defined ()

/*
    3 Ways to declare a variable  in Javascript

    var

    var does variable hoisting
    anything declared w/var, when it is ran, all the declarations will be brought to the top of the page
    but not the inititialization

    variable can be referenced after it has been delcared, but it will be undefined
    this leads to broken code most of the time

    let and const did away with variable hoisting and is the recommended way to declare variables in javascript
*/

var name2 = "John";

/*
    anything delcared with let and const has block scope
    this means you can't reference outside of the scope that it's 
    declared within

*/

    {
        let uniqueName = "Greg";
        const secondName = "Mike";
        var name3 = "Jeff";
    }

    
    console.log(uniqueName);
    console.log(secondName);
    console.log(name3); //doesn't throw error because var does not have block scope

    /*
        let and const have other properties

        let is basically the default declaration for a variable
        it lets anything declared with it be reassigned
        it also lets you declare it w/out initializing a variable with it
        you don't have to assign a value to it

        const
        is used for constants and when a value has been assigned to it
        it can't be reassigned to something else
        anything declared w/ const must also be initialized
        you can't have undefined values for const

    */

    // Arrays
    /*
        used to store multiple values in a single variable
        also provide various methods for adding, removing, and manipulating elements
    */

    let fruits = ["apple", "banana", "orange"];

    //access the values of the array with indexes
    console.log(fruits[0]); //apple

    // if you want to add an element to the end of the array
    // push
    fruits.push(grape);

    // if want to remove the last element of the array
    //pop
    fruits.pop();
    console.log(fruits);

    // for loops
    // 3 ways to loop in a for loop type way in JS

    //default for loop
    for(let i = 0; i < fruits.length; i++){
        console.log(fruits[i]);
    }

    // For Of
    // this loop will go through each value of the array/object

    for (const element of fruits){
        console.log(element)
    }

    // For In
    // this loop will go through each key of the array / object

    for(const key in person){
        console.log(key);
        // use [] and iterating value to access the property value of the object
        console.log(person[key]);
    }

    //functions
    /*
        blocks of code designed to perform a particular task
        they can be defined using the function keyword or as function expressions
    */

    function greetPerson(name){
        return "hello, " + name;
    }

    console.log(greetPerson("Mike"));

    // function expressions
    // because we're declaring a value and then assigning it a function, we can reassign it if we want to

    let greetPersonExpression = function(name){
        return "Hello, " + name;
    }

    greetPersonExpression = function(name){
        return "Hello again, " + name
    }
    console.log(greetPersonExpression("Jim"));

    //OOP
    /*
        supported somewhat in JS
        language already has objects in it, but there are is no in built classes features
        this is what we call syntactic sugar, where we have syntaxes that look like it is doing 
        something but when it is ran through the compiler, it is converted into something else

    */

    class Person{
        constructor(name, age){
            this.name = name;
            this.age = age;
        }
        greet(){
            console.log("Hello, my name is " + this.name);
        }
    }

    const john = new Person("John", 30);

    john.greet();
    console.log(john);

    // this keyword
    /*
        "this" refers to the current context in which a function is executed
        Its value depends on how a function is called

        if function is inside of an object, then this refers to the object that is being called

        if function is outside of an object, then this refers to the global object which is the browser

    */

    function globalGreet(){
        console.log(this);
    }

    globalGreet();

    // Arrow functions
    /*
        Arrow functions provide a shorter syntax for writing functions
        they're especially useful for inline functions
        they also have a unique property, in which, they don't bind their own "this"

    */

    //function expression
    let add = function(param1, param2){
        return param1 + param2;
    };

    add = (param1, param2) => param1 + param2;

    console.log(add(1, 2));

    const Mike = {
        name: "Mike",
        greet: () => {
            console.log("Hello, my name is " + this.name);
        }
    };

    Mike.greet();

