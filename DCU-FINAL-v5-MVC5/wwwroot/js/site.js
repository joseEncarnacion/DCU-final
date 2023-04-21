// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Formulario de busqueda
/*
const input = document.querySelector("#searchID");
const btn = document.querySelector("#buronS");

const filtrar = () => {
    console.log(input.value);

    bnt.addEventListener('click',()=> filtrar);

}*/

//Formulario de busqueda


console.log("hola desdee el archivo externo");
const formulario = document.querySelector("#searchID");
const btn = document.querySelector("#buronS");

const filtrar = () => {

    //const id = formulario.value.parseInt();
   // for (let info in Model)

    /*
    console.log(formulario.value);
    console.log("estoy dentro de filtal");
    */
    

    for (let info in @Model) {
        console.log(info.nombre);
    }
   
   
}






btn.addEventListener('click', () => {
    filtrar();
   

});


