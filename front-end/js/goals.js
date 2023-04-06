let count = 0;
//let noteNumber=1
 function made(){
    if(document.querySelector('#super').value.length == 0){//
      alert("Please Enter a Task")
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
    }
        document.querySelector('#tasks').innerHTML += `
            <div class="task">
            <p> ${count} </p>
                <span id="taskname">
                    ${document.querySelector('#super').value}
                </span>
                <button class="delete">
            Delete
                </button>
                <input type="checkbox"  class="check">
                <p class='comp'>...</p>
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
        }
    }
    //COMPLETED/NOT COMPLETED
    const checkinp = document.querySelectorAll(".check");
    const complmes = document.querySelectorAll(".comp");
    const taskplank = document.querySelector(".task");
    for(let i=0; i<checkinp.length; i++)
    {checkinp[i].onclick=function dode (){
           if (checkinp[i].checked){
   complmes[i].innerHTML = 'completed';
   console.log("ssl")
           }
           else{
   complmes[i].innerText = 'not completed';}
         

           }
         }
}
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