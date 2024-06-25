import React, { useEffect, useState } from 'react'


function Lists() {
    const [products, setProducts] = useState<any[] | undefined> (undefined);

    useEffect(() => {
        async function getProducts(){
        try{
            let response = await fetch("https://dummyjson.com/products");
            let data = await response.json();
            setProducts(data.products);
        }catch(error){
            console.error(error);
        }
    }
    getProducts();
}, []);
  return (
    <div>
        {
            products?.map((obj, index)=> {
                return (
                    <div key={index}>
                        <h1>{obj.title}</h1>
                        
                    </div>
                );
            })
        }
    </div>
  )
}

export default Lists