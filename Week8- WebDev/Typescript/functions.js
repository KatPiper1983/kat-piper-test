// functions in TS are similar to JS
// We have the ability now to have typed parameters and return types
//regular function
// function reference(param: type): returnType{}
function addNumbers(x, y) {
    return x + y;
}
var sum = addNumbers(3, 5);
console.log(sum); //8
// Arrow Syntax
// Arrow functions provide a more concise syntax
var multiplyNumbers = function (x, y) {
    return x * y;
};
// Anonymouse Functions
// these are functions without a name, often used as arguments to other functions
// you can pass a function as a parameter
setTimeout(function () {
    console.log("this is an anonymous function");
}, 1000);
setTimeout(function () {
    console.log("this is an arrow anonymous function");
}, 1000);
function concatenate(x, y) {
    return x + y;
}
var stringResult = concatenate("hello", "world"); // hello world
var numberResult = concatenate(5, 10); // 15
// Optional and Default Parameters
// Optional parameters
// these are specified with a ?
function greetPerson(name, greeting) {
    if (greeting) {
        return "".concat(greeting, ", ").concat(name);
    }
    else {
        return "Hello there, ".concat(name);
    }
}
// Default Parameters
// default parameters provide a way to give a default value if nothing is given
function greetDefault(name, greeting) {
    if (greeting === void 0) { greeting = "Hello"; }
    return "".concat(greeting, ", ").concat(name);
}
// Rest Parameters
// This allows a function to accept an indefinite number of arguments as an array
function summing(name) {
    var numbers = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        numbers[_i - 1] = arguments[_i];
    }
    var total = numbers.reduce(function (total, num) { return total + num; }, 0);
    return "".concat(name, ", your total is ").concat(total);
}
console.log(summing("Mike", 3, 4, 5, 6, 7, 8, 10));
