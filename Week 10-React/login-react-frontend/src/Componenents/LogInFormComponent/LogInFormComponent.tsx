import react from 'react'
import { User, UserLoginInput } from '../LogInComponent/LogInComponent';
import React, { useState } from 'react';

function LogInFormComponent(props: any) {
    //const userInput : UserLoginInput = {username: "", password: ""};
    const [userInput, setUserInput] = useState<UserLoginInput>({username: "", password: ""});
    
    function usernameInputChangeHandler(event: any){
        //console.log(event.target.value)
        setUserInput({...userInput, username: event.target.value});
    
      }
      function passwordInputChangeHandler(event: any){
       // console.log(event.target.value)
        //userInput.password = event.target.value;
        setUserInput({...userInput, password: event.target.value});
    
      }
    
      function submitClickHandler(){
        //console.log("Submit button clicked");
        console.log(userInput);
        props.setLoginInput(userInput);
    
      }
  return (
    <div>
        <input onChange= {usernameInputChangeHandler} type="text" placeholder='username'></input>
        <br/>
        <input onChange= {passwordInputChangeHandler} type="password" placeholder='password'></input>
        <br/>
        <input onClick= {submitClickHandler} type="button" value='submit'></input>
    </div>
  )
}

export default LogInFormComponent