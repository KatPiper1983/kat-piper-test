import { isVisible } from '@testing-library/user-event/dist/utils';
import  { useState } from 'react';
import  {useEffect} from 'react';
import axios from 'axios';
import { Pokemon } from './Pokemon';
import Immutability from './Immutability';

function Hooks() {

    //useEffect();

    useEffect(() => {
        async function getDitto(){
           // let response = await fetch("https://pokeapi.co/api/v2/pokemon/ditto");
           // let responseBody = await response.json();

           // console.log(responseBody);
           let response = await axios.get("https://pokeapi.co/api/v2/pokemon/ditto");
           console.log(response.data);
           setPokemon(response.data);
        }

        getDitto();
    }, []);

    let [pokemon, setPokemon] = useState<Pokemon | undefined>(undefined);
  
   // let isVisible = true;

   //let [visibility, setVisibility] = useState
   //(false);

   //let counter = 0;
   //let [counter, setCounter] = useState(0);

   let [state, setState] = useState({
    visibility: false,
    counter: 0,
    username: "user1"
   });

    function toggleDiv(){
       // console.log(isVisible);
       console.log(state.visibility);
        //isVisible = !isVisible;
        //setVisibility(!visibility);
        // Spread Operator-...
        // quick way of duplicating object and only chaning values that you need to change
        setState({...state, visibility: !state.visibility});
    }  

    function incrementNum(){
        console.log(state.counter);
        //counter++;
        //setCounter(counter);
        setState({...state, counter: state.counter + 1});
    }
     function decrementNum(){
        //setCounter(--counter);
        setState({...state, counter: state.counter - 1});
     }
  
  
    return (
    <div>
        <button onClick={toggleDiv}>Toggle</button>
        {
            state.visibility ? <h2>Am I visible?</h2> : <></>
        }

        <h1>{state.counter}</h1>
        <button onClick={incrementNum}>Increment</button>
        <button onClick={decrementNum}>Decrement</button>

        {
            <>
           <h2>{ pokemon?.name}</h2>
           <img src={pokemon?.sprites.front_default}></img>
           </>
        }
        <Immutability/>

    </div>
  )
}

export default Hooks