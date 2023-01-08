// var i = 5;
// console.log(i);
// var firstName = 'John';
// var lastName = 'Doe';
// console.log(firstName, lastName);
// console.log(typeof firstName);
// var data = "this is a string";
// console.log(data[1]);
// console.log(data.length);
// var res = data.toUpperCase();
// console.log(res);
// data = data.toUpperCase();//to change the original data
// var message = 'JS for web';
// console.log(message.trim());//to cut the spaces before and after the line
// trimstart()-cut space on the beginning trimend()-cut space at end
// console.log(message.split(' '));
// var res = message.replace(' ','_');//replace first occurence of space into undrscore
// var res = message.replaceAll(' ','_');
// console.log(res);


/* var message = '  JS for web   ';
var res = message
        .toUpperCase()
        .trim()
        .replaceAll(' ','_');
console.log(res);*/
// for(let i = 0; i < 5; i++){
 //   console.log("inside for loop",i);
// }
// console.log("outside for loop",i);//let is block level so i is only available in for loop ,for grtting i in outside of for lopp  use 'var'
// const lang = 'js'; constant variable should have a value
// console.log(lang);
/* const num1 = 4;
const num2 = 5;
const res = num1 + ' + ' + num2 + ' = ' + (num1 + num2);
const res2 = `${num1} + ${num2} = ${num1 + num2}`;
console.log(res);
console.log(res2); */
var firstString = 'java';
var lastString = 'script';

var res1 = firstString + ' ' + lastString;
var res2 = firstString.concat(' ', lastString);
var res3 = `${firstString} ${lastString}`;

console.log(res1);
console.log(res2);
console.log(res3);
