document.querySelector('#sub').onclick = function made(){
    if(document.querySelector('#super').value.length == 0){//
      console.log("Please Enter a Task")
    }
  
    else{
      //ОТРИСОВКА ТАСКА
        document.querySelector('#tasks').innerHTML += `
            <div class="task">
                <span id="taskname">
                    ${document.querySelector('#super').value}
                </span>
                <button class="delete">
            Delete
                </button>
                <input type="checkbox"  id="check">
                <p  id='comp'></p>
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
    const  checkinp = document.getElementById("check");
    const complmes = document.getElementById("comp");
    const taskplank = document.querySelectorAll(".task")
     complmes.innerHTML = 'not completed';
         checkinp.onchange  = function dode (){
           if (checkinp.checked){
             complmes.style.visibility = 'visible';
   complmes.innerText = 'completed';
           }
           else{
   complmes.innerText  = 'not completed';

           }
         }
}
const taskplank = document.querySelectorAll(".task")
const complmes = document.getElementById("comp");
function completdis (){
    taskplank.style.animation = 'disapear  4s backwards '
    console.log("le")
   }
complmes.addEventListener('change',(e)=>{
console.log(e.target.value)
})
//completdis()
 
 {
    console.log("d")
 }