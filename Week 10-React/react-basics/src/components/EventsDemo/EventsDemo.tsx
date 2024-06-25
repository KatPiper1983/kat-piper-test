import React from 'react'

function EventsDemo() {

    function clickEventTriggered(){
        console.log("click button triggered")

    }

    function hoverEventTriggered(){
        console.log("Hover event triggered")

    }

    //traditionally, would have to use DOM selector and reference value property to see value of input
    // however, we don't have access to DOM, React does

    function inputChanged(event: any){
        console.log("Input has changed");
        console.log(event.target.value);
    }

  return (
    <div>
        <button onClick={clickEventTriggered}> Click Event</button>
        <button onMouseOver={hoverEventTriggered}> Hover Event</button>
        <input type="text" placeholder='Username' onChange={inputChanged}/>
    </div>
  )
}

export default EventsDemo