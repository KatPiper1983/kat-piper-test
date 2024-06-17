// Classes
/*
    Classes in TS are a blueprint for creating objects with predefined properties and methods
    TS Classes support things like: 
        - Inheritance
        - Access modifiers
        - constructors
*/

class Animal {
    private name: string;

    constructor(name: string){
        this.name = name;
    }

    public move(distance: number): void {
        console.log(`${this.name} moved ${distance} yards`);
    }
}

class Dog extends Animal {
    constructor(name: string){
        super(name);
    }

    public bark(): void{
        console.log("Woof! Woof!");
    }
}

const dog = new Dog('Buddy');
dog.bark(); // Woof! Woof!
dog.move(10); // Buddy moved 10 meters

// Casting
// Casting is when you tell the compiler to treat a variable as a different type

let someValue: any = "this is a string";
let strLength: number = (someValue as string).length

// Union types
// allow a variable to be one of several types
let unionValue: string | number | boolean;

unionValue = "hello";
unionValue = 42;
unionValue = false;
// unionValue = null;

// interfaces and type aliases

// type aliases
// let you create a new name for a type

type StringOrNumber = string | number;

let value: StringOrNumber;
value = "string";
value = 123;

 // interfaces 
 // let you define the structure of an object

 interface Person {
    firstName: string;
    lastName: string;
    age?: number; //optional property
 }

 function greetPerson(person: Person): string {
    return `Hello, ${person.firstName} ${person.lastName}`;
 }

 let user: Person = {firstName: "Mike", lastName: "Jones"}; // this is fine because age is optional

 // object types
 // This is another way to describe the shape of an object
 // you don't have to make an interface

 type UserObj = {name: string, age: number}

 let userObj: UserObj =  {name: "Alice", age: 33};

 console.log(userObj);

 // Intersection Types
 // These combine multiple types into one

 interface Employee {
    employeeId: number;
 }

 type OfficeWorkder = Person & Employee;

 let worker: OfficeWorkder = {firstName: "John", lastName: "Doe", employeeId: 1123}

 // Literal Types
 // this lets you specify exact values a variable can be

 type Direction = "north" | "south" | "east" | "west";

 let move: Direction;
 move = "north";
 // move = "up"; //error

 // Type Guards
 function isNumber(value: any): boolean{
    return typeof value == "number";

 }

 function printValue(value: string | number){
    if(isNumber(value)){
        console.log((value as number).toFixed(2));
    }
    else{
        console.log((value as string).toUpperCase());
    }
 }

 // Generics
 /*
    way of writing programming to be extremely reusable
    provide a way to create reusable components that work with a variety of types

    these can be functions, classes, methods, etc

 */

// simple example
function identity<T>(arg: T): T {
    return arg;
}    

let output1 = identity<string>("hello");
let output2 = identity<number>(35);

class Box<T> {
    
    private field: T;

    constructor(field: T){
        this.field = field;
    }
}

// Array Generics

function getArray<T>(items: T[]): T[]{

    return new Array<T>().concat(items).sort();
}

let numArray = getArray.Sorted<number>([134, 2342, 32, 124]);
let strArray = getArray.Sorted<string>(["ass", "ber", "casdf"]);

console.log(numArray);
console.log(strArray);


