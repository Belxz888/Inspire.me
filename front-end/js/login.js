
/*const body = document.body;
const signUpBtn = document.getElementById('signup-btn');
signUpBtn.addEventListener('click', function () {
    const formBox = document.querySelector('.form-box');
    formBox.classList.add('active');
    body.classList.add('active');
    
});
let sig = document.getElementById('signin-btn')
sig.addEventListener('click', function() {
    const formBox = document.querySelector('.form-box');
    formBox.classList.remove('active');
    body.classList.remove('active');
});*/
//показать пароль
function showe(target){
    var input = document.getElementById('password');
    if (input.getAttribute('type') == 'password') {
      target.classList.add('view');
      input.setAttribute('type', 'text');
    } else {
      target.classList.remove('view');
      input.setAttribute('type', 'password');
    }
    return false;
  }
  var pass = document.getElementById('password');
  let showpass = document.getElementById("pas-datas-c")
  console.log(pass.value.length)
if (pass.value.length >=5){
    showpass.style.display = "inline"
    console.log("d")
}
else{
    showpass.style.display = "none"

}
  const checkdata = () =>{
  //проверка логина
  var login = document.getElementById("login")
  var loginvalue =login.value
    if ( loginvalue.length >=5 && loginvalue.includes('.com')) {
     alert("login+")
     //проверка на правильность логина
    }
    else{
        alert("login-")
    }
}