import React from 'react';
import logo from './logo.svg';
import './App.css';
import ComponentOne from './components/ComponentOne/ComponentOne';
import ComponentKat from './components/ComponentKat/ComponentKat';
import EventsDemo from './components/EventsDemo/EventsDemo';
import ListDemo from './components/ListDemo/ListDemo';
import ParentComponent from './components/Props/ParentComponent/ParentComponent';

// A functional component
// mostly work with functional components in React, but there are also class components
// FC mostly used because being pushed by React and a lot of features with React are built around it
// also faster and more efficient than class components

// what is a component?
//     - snippet of HTML, CSS, and JS (TS)
//     - building blocks for HTML page
//     - two types: class and functional

// can't have both as they are essentially equivalent but implemented differently

function App() : React.JSX.Element{
  // body of the function
  return (
    // return statement contains body of component
    // and what will be displayed to the page

    // whatever is returned has to be a root element, meaning you can't have siblings inside
    // the return--> have to be nested inside a parent
    <div className="App">
       <ComponentKat/>
       <ComponentOne/>
       <ComponentOne/>
       <ComponentKat/>
       <ComponentKat/>
       <EventsDemo/>
       <ListDemo/>
       <ParentComponent/>
    </div>
  );
}

export default App;
