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
var isDone = false;
var age = 26;
var firstName = 'John';
var u = undefined;
var n = null;
//can't reassign a value to something that doesn't match its declared datatype
//isDone = "Hello";
// Arrays
// syntax:  type[] or Array<type>
var numberList = [1, 2, 3];
var genericNumberList = [1, 2, 3];
// Tuple
// tuples let you define an array with fixed types and length
var tupleExample;
tupleExample = ["hello", 50];
//tupleExample = [10, 'hello']; //error, incorrect
// Enums
// allow you to define a set of named constants
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var StatusCodes;
(function (StatusCodes) {
    StatusCodes[StatusCodes["Ok"] = 200] = "Ok";
    StatusCodes[StatusCodes["Created"] = 201] = "Created";
    StatusCodes[StatusCodes["NotFound"] = 404] = "NotFound";
})(StatusCodes || (StatusCodes = {}));
var colorExample = Color.Green;
console.log(colorExample); // 1
// String enums
// must define every single value, there's no default
var CardinalDirections;
(function (CardinalDirections) {
    CardinalDirections["North"] = "North";
    CardinalDirections["East"] = "East";
    CardinalDirections["South"] = "South";
    CardinalDirections["West"] = "West";
})(CardinalDirections || (CardinalDirections = {}));
// Any
// any type lets you opt-out of type checking
// this gives you loose typing just like in JavaScript
var notSure = 5;
notSure = "Hello";
notSure = false;
