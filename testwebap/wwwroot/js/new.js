let male = document.getElementById("male")
let malek = document.getElementById("malek")
let info = document.querySelector(".info")
let infos = document.querySelector(".infos")
const males = () =>{
/*fetch(`https://api.genderize.io/?name=${male.value}`)
 .then(response => response.json())
 .then(data => { console.log(data.gender)})
 .catch(error => console.error(error));
}*/

fetch(`https://api.ipify.org/?format=json`)
 .then(response => response.json())
 .then(data => { info.innerHTML =data.ip })
 .catch(error => console.error(error));
} 

const maled = () =>{
fetch(`https://ipinfo.io/${malek.value}/geo`)
 .then(response => response.json())
 .then(data => { info.innerHTML =data.city
    infos.innerHTML =data.loc})
 .catch(error => console.error(error));
}
