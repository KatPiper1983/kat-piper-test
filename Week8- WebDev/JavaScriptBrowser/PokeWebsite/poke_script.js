const searchContainer = document.querySelector("#search-container");
const displayContainer = document.querySelector("#display-container");

const inputNumber = searchContainer.children[0];
const searchButton = searchContainer.children[1];

console.log(inputNumber);
console.log(searchButton);
// async function to actually communicate with the poke api
// function that takes in the search input for the search container

function getSearchNumber(){
    let pokeId = inputNumber.value;
    getPokemon(pokeId);
}

searchButton.addEventListener('click', getSearchNumber);

// async function to actually talk to the api

async function getPokemon(pokeId){
    const URL = "https://pokeapi.co/api/v2/pokemon/" + pokeId;
    try{
        let response = await fetch(URL);
        let data = await response.json();
        console.log(data.name);
        console.log(data.sprites.front_default);
        displayPokemon(data.name, data.sprites.front_default);
    }catch(error){
        console.error(error);
    }
}

function displayPokemon(name, imgUrl){
    while(displayContainer.firstChild){
        displayContainer.removeChild(displayContainer.firstChild);
    }

    // Next, we create the elements that we want to display to the page
    // We are using a h3 element for the name of the pokeman
    let pokeName = document.createElement("h3");
    pokeName.textContent = name;

    // we are using an image element for the poke image
    let pokeImage = document.createElement("img");
    pokeImage.src = imgUrl;

    // 
    displayContainer.appendChild(pokeName);
    displayContainer.appendChild(pokeImage);

}