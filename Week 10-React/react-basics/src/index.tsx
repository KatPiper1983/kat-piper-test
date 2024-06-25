import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import { BrowserRouter } from 'react-router-dom';


//the root where all of our components are rendered
// can see the <App /> component being placed within <React.StrictMode>
// whatever is inside app component is now being rendered to the page

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(  
  <BrowserRouter>
    <App /> 
  </BrowserRouter>
);


