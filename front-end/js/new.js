let male = document.getElementById("male")
const males = () =>{
fetch(`https://api.genderize.io/?name=${male.value}`)
 .then(response => response.json())
 .then(data => { console.log(data.gender)})
 .catch(error => console.error(error));
}
