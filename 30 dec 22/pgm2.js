/*const rows = 3;
const cols = 3;
const m = new Array(rows);
const m1 = [
    [1, 2],
    [3, 4]
];

console.log(m1);*/

/*setTimeout(()=>{
    console.log('code worked!');
}, 5000);*/

/*setInterval(()=>{
    console.log('code worked!');
}, 5000);

console.log('compleated');*/

const student = {
    name: 'student 1',
    mark1: 40,
    mark2: 50,
   // total: function () {
       // const extramark = 5;
      //  console.log(this.mark1 + this.mark2  /*extramark*/ );  //extramarkmis declare inside of fun so no need of this 
   // }
};
const copy = Object.assign({}, student); // while copying we can add extra properties Object.assign({age: 5}, student);
copy.name = 'new name';
console.log(student);
console.log(copy);

// student.total();