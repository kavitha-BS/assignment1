/*function greet(){
    console.log("hello world");
}

greet();*/

/*function add(num1,num2) {
    console.log(num1 + num2);
}

add(1,2);*/

/*function add(num1, num2) {
    return num1 + num2;
}

const res = add(1, 2);
console.log(res);*/

function convertCasing(value) {
    return value.toUpperCase();
}

const res = convertCasing('hello');
console.log(res.toLowerCase());

/*function getFirstChar1(value){
    return value[0];
}

const getFirstChar2 = function (value){
    return value[0];
}

/*const getFirstChar3 = (value) => {
    return value[0];
}*/
const getFirstChar3 = value => value[0];

// console.log(getFirstChar1('hello'));
// console.log(getFirstChar2('hello'));
console.log(getFirstChar3('hello'));
