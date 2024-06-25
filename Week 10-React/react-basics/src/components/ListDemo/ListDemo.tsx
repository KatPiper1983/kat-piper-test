import React from 'react'

function ListDemo() {
    let people = [
        {
            firstName: "john",
            lastName: "Doe"
        },
        {
            firstName: "Jane",
            lastName: "Doe",
        },
        {
            firstName: "Mick",
            lastName: "Doe"
        },
    ];
  return (
    // the <> fragment tag lets you not have to use <div> as the parent and have a bunch
    // of nest <div> in your page
    // this helps organize your code and also helps screen readers understand what they are
    // looking at specifically, not a bunch of nested divs

    <>
        {
            people.map((obj, index)=> {
                return (
                    <div className="name-div" key={index}>
                        <h1>{obj.firstName}</h1>
                        {obj.lastName}
                    </div>
                );
            })
        }
    
    </>
  )
}

export default ListDemo