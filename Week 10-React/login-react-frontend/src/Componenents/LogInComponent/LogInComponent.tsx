import React, { useEffect, useState } from 'react'
import LogInFormComponent from '../LogInFormComponent/LogInFormComponent';

export interface UserLoginInput{
  username: string;
  password: string;
}

export interface User {
  userId: number;
  userName: string;
  firstName: string;
  lastName: string;
  email: string;
  age: number;
  isAdmin: boolean;
}

function LogInComponent(props: any) {
  
  //const [user, setUser] = useState<User | undefined>(undefined);

  const [loginInput, setLoginInput] = useState<UserLoginInput | undefined>(undefined);

 
  useEffect(() => {
    if(loginInput?.username === 'user1' && loginInput?.password === 'pass1'){
      console.log("logged in!");
      // We assume we will get back the correct user when we log in
      let loggedInUser : User = {
          userId: 1,
          userName: 'user1',
          firstName: 'John',
          lastName: 'Doe',
          email: 'john.doe@email.com',
          age: 33,
          isAdmin: false
      };
      props.setUser(loggedInUser);
  }else{
      console.log("Not logged in!");
      props.setUser(undefined);
  } 
   
  }, [loginInput]);  

  return (
    <div>
      <LogInFormComponent setLoginInput={setLoginInput}/>
          
    </div>
  )
}

export default LogInComponent


