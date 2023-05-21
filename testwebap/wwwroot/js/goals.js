let count = 0;
//let noteNumber=1
const mainbutton = document.getElementById("sub")
document.querySelector('#super').addEventListener("keydown",(event)=>{

    if (event.keyCode  === 13) {
     made()
    }
});
  function made(){
    if(document.querySelector('#super').value.length <= 3){//
      alert("Побольше")
    }
    else{
      //ОТРИСОВКА ТАСКА
      /*function createNote(){
    count++;
    const note=document.createElement('div');
    note.innerHTML = 'note ${count}';
    document.body.appendChild (note);
    }*/
    /*function addNote(){
        const noteText = document.getElementById("note-text").value;
        const notesList = document.getElementById("notes-list");
        const noteItem = document.createElement("li");
        noteItem.innerText='${noteNumber}. ${noteText}';
        notesList.appendChild(noteItem);
        noteNumber++;*/
        document.querySelector('#tasks').innerHTML += `
        <div class="task">
        <p> ${count++} </p>
            <span id="taskname">
                ${document.querySelector('#super').value}
            </span>
            <button class="delete">
        Delete
            </button>
            <input type="checkbox"  id="check">
            <p class='comp'></p>
        </div>
    `;
    document.querySelector('#super').value = ''
//DELETE BUTTON CODE
    let current_tasks = document.querySelectorAll(".delete");
    for(var index=0; index<current_tasks.length; index++){
        current_tasks[index].onclick = function(){
            this.parentNode.remove();
            count--
        }
    }}
    //COMPLETED/NOT COMPLETED
    const checkinp = document.querySelectorAll("#check");
    const complmes = document.querySelectorAll(".comp");
    const taskplank = document.querySelectorAll(".task");
    for (let index =0;index<checkinp.length ; index++){
    checkinp[index].onclick= () =>{ 
           if (checkinp[index].checked){
   complmes[index].innerHTML = '';
   timerID = setTimeout(function() {
    var element = taskplank[index];
    element.parentNode.removeChild(element);
    }, 2000);
           }
           else if (!checkinp[index].checked){
            complmes[index].innerHTML = '';
            console.log("dc");
            clearTimeout(timerID);

           }


    }

}}

//область видимости функции ограничивает взаимодействие с домом


/*
const taskplank = document.querySelectorAll(".task")
const complmes = document.getElementById("comp");
function completdis (){
    taskplank.style.animation = 'disapear  4s backwards '
    console.log("le")
}if (complmes =="completed"){
    completdis()
}
else{
    console.log("ererer")
}
/*complmes.addEventListener('change',(e)=>{
console.log(e.target.value)
})
//completdis()
 
 {
    console.log("d")
 }*/
 const con =
 document.querySelector('.task');
 const item =
 document.querySelectorAll('#tasks');

 function handleFlexWrap() {
    if (window.innerWidth < 600)
    {
        con.style.flexWrap =
        'wrap';
    } else {
        con.style.flexWrap = 
        'nowrap';
    }
}
 handleFlexWrap();
 
 window.addEventListener('resize', handleFlexWrap);
	