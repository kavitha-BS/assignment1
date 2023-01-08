/*const student = {
    name: 'student1',
};

const marks = {
    mark1: 40,
    mark2: 50

};
const copy = Object.assign({}, student, marks);
console.log(copy);*/

const student = {
    fullName: 'student 1',
    mark1: 40,
    mark2: 40
};

// const {fullName, mark1} = student;
// console.log(fullName);
const keys = Object.keys(student);
keys.forEach(key=>{
    console.log(student[key]); //for getting the property console.log(key);
} );   
