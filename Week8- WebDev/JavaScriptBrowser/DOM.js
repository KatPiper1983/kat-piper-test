// document Object Model (DOM)
/*
    acts as an object representation of the HTML document so that we can programmatically interact
    w/ the webpage

    this is an interface that lets us interact, manipulate, remove, or add things to the document
    structure, style, and content

    DOM is a tree like structure, where every node represents an element or a piece of content
    in the document
*/

console.log(document);

// Element Selectors
/*
    In order to manipulate the DOM, you need to be able to select items from the DOM

    There are several methods, some follow a new syntax, others follow the CSS syntax
*/

// Select by ID
const header = document.getElementById('header');

console.log(header);

// Select by Class Name
const intro = document.getElementsByClassName('intro');
console.log(intro);

// Select by Tag Name
const paragraphs = document.getElementsByTagName('p');
console.log(paragraphs);

// Select by CSS Selectors
const content = document.querySelector("#content");
const allParagraphs = document.querySelectorAll('p');

// DOM Manipulation
// Once have selected an element, can manipulate it by changing its properties, attributes, and content

// Change Content
header.textContent = 'Hello World!';

// Change Style
header.style.color = 'blue';

// Add a new Class
header.classList.add('highlight');

// Remove an element
const button = document.getElementById('myButton');
button.remove();

//Add elements and append elements
const newButton = document.createElement('button');
newButton.textContent = "New Button!";
document.body.appendChild(newButton);

// Traversing the DOM
const contentDiv = document.getElementById('content');

// parent node
const parent = contentDiv.parentNode;
console.log(parent);

// child nodes
const children = contentDiv.childNodes;
const childrenElements = contentDiv.children; //if just want the elements
console.log(children);
console.log(childrenElements);

const paragraph1 = childrenElements[0];

const parentParagraphNode = paragraph1.parentNode;
const parentParagraphElement = paragraph1.parentElement;

console.log(parentParagraphNode);
console.log(parentParagraphElement);

// First Child
const firstChild = contentDiv.firstChild;

//Last Child
const lastChild = contentDiv.lastChild;

// Sibling nodes
const nextSibling = contentDiv.nextSibling;
const previousSibling = contentDiv.previousSibling;

// Events and Listeners
/*
    JS can respond to user interaction by listening for events and executing functions
    when those events occur
*/

// Because I am getting elementsByTagName, this will be default
// return an array of elements even if there is only one element
// because of that, I will use [0] to grab the first element from that collection
const newButtonSelected = document.getElementsByTagName('button')[0];
console.log(newButtonSelected); // sanity checking

// define a function to run when the button is clicked
function handleClick(){
    alert('Button was clicked!');
}

// Add an event listener to the button
// Syntax of the addEventListener is ('event_name', function_name)
newButtonSelected.addEventListener('click', handleClick);

//Fetch API
// This provides a way to make network requests
// It works with JSON and all the HTTP methods

// Fetching data
/*
    want to get data from an api
    in order to get that data, need the following things:
        - URL
        - HTTP Method
    
    Once we get some kind of response
        - check if response is okay
        - if there is JSON, turn it into a javascript object

    Going to interact w/ Poke API
    the URL is : https://pokeapi.co/api/v2/pokemon/1
*/

// promises approach
/*
    when create a promise, there are 3 states that it can exist in

    Pending- This is in the process of being completed
    Completed Successfully - then
    Completed Unsuccessfully - catch
*/

// we initiate the fetch request, and by default it will do a GET method
fetch('https://pokeapi.co/api/v2/pokemon/1')
    .then(response => response.json()) //when something successful happens--> when get response back,
    // we turn it into a javascript object
    .then(data => {
        console.log(data);// once that is complete, we print it to the console
    })
    .catch(error => console.error('Error', error));  // when something unsuccessful happens--> if at any point
    // something goes wrong, we print this error to the console

// Using Async / Await for fetching data
async function fetchData(){
    try{
        let response = await fetch('https://pokeapi.co/api/v2/pokemon/1');
        let data = await response.json();
        console.log(data);
    }catch(error){
        console.error('Error', error)
    }
}

fetchData();

