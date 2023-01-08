function handleSubmit(e){
    e.preventDefault();
    console.log(e);
    //const email = document.forms['login']['email'].value;
    //const password = document.forms['login']['password'].value;
    const email = document.forms.login.email;
    const password = document.forms.login.password;
    const age = document.forms.login.age;

    const emailvalue = email.value;
    const passwordvalue = password.value;
    const agevalue = age.value;

    const passwordErrorDisplay = password.nextElementSibling;
    if(passwordvalue.length < 6){
        password.style.border = '1px solid red';
        //password.nextElementSibling.classList.remove('d-none');
        passwordErrorDisplay.classList.remove('d-none');
        passwordErrorDisplay.innerHTML += '<li>password must be at least 6 characters</li>';
    }
    if(passwordvalue.includes('')){
        password.style.border = '1px solid red';
        password.nextElementSibling.classList.remove('d-none');
        passwordErrorDisplay.innerHTML += '<li>password must not contain spaces</li>';

    }
    
    console.log(password);
}