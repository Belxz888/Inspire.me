 function made(){
    if(document.querySelector('#super').value.length == 0){//
      console.log("Please Enter a Task")
    }
  
    else{
      //ОТРИСОВКА ТАСКА
      for (index=0;index>=1;i++){
        const indexs = index;
      }
        document.querySelector('#tasks').innerHTML += `
            <div class="task">
            <h1>${index}</h1>
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
            }
        }
    }
    const  checkinp = document.querySelector(".check");
    const complmes = document.querySelector(".comp");
    const taskplank = document.querySelector(".task")
         checkinp.onclick  = function dode (){
           if (checkinp.checked){
   complmes.innerHTML = 'completed';
   console.log("ssl")
           }
           else{
   complmes.innerText = 'not completed';

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