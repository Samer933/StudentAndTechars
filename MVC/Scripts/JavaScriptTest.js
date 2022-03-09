
////const t = document.getElementById("act");

////t.addEventListener("click", function () {

////    document.getElementById("prov").innerHTML = "Hello";

////});


const hambur = document.querySelector('.Hambur');
const bar1 = document.querySelector('.bar1');
const bar2 = document.querySelector('.bar2');
const bar3 = document.querySelector('.bar3');



const nav = document.querySelector('.nav-menu');

   hambur.addEventListener("click", () => {


     /*  hambur.classList.toggle("active");*/
       hambur.classList.toggle("active");

       nav.classList.toggle("active");
    //   bar1.classList.toggle("active");
    ///*   bar2.classList.toggle("active");*/
    //   bar3.classList.toggle("active");
})



hambur.removeEventListener("click", () => {



    nav.classList.toggle("active");

}); 





