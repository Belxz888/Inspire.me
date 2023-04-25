


const body = document.body;
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
});