import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';


//the root where all of our components are rendered
// can see the <App /> component being placed within <React.StrictMode

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(  
    <App /> 
);


