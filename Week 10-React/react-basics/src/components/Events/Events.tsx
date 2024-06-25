import React from 'react'

function Events() {
    function clickEventTriggered(){
        console.log("button clicked")
    }

    function hoverEventTriggered(){
        console.log("I'm hovering")
    }
    function inputHasChanged(event: any){
        console.log("you changed the input")
        console.log(event.target.value)
    }

  return (
    <div>
        <button onClick={clickEventTriggered}>click event</button>
        <button onMouseOver={hoverEventTriggered}>hover event</button>
        <input type="text" placeholder='username' onChange={inputHasChanged}/>
    </div>
  )
}

export default Events