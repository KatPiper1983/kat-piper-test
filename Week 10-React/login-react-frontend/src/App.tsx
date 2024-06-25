import React from 'react';
import LogInComponent, { User } from './Componenents/LogInComponent/LogInComponent';
import { Route, Routes } from 'react-router-dom';
import UserProfileComponent from './Componenents/UserProfileComponent/UserProfileComponent';
import { UserContext } from './context/UserContext';
import { useState } from 'react';


function App() {
 
  const [user, setUser] = useState<User | undefined>(undefined);
  return (
    <div className="App">
      <UserContext.Provider value={user}>
        <UserProfileComponent/>
        {/*Login Component*/}
        <Routes>
          <Route path="/" element={<LogInComponent setUser={setUser}/>}/>
        </Routes>
      </UserContext.Provider>
    </div>
  );
}

export default App;
