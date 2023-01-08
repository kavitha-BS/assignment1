/*const languages = ['c', 'cpp', 'java', 'python'];
languages.forEach(lang => {
    console.log(lang);
});*/

/*const person = {
    name: 'John Doe' ,
    age: 20
}
// console.log(person);
//person.name = 'new name';
console.log(person.name);
console.log(person['name']);*/

const person = {
    name: 'John Doe' ,
    age: 20,
    experience: [
        {
            company: 'company ABC',
            years: 2
        },
        {
            company: 'company XYZ',
            yeras: 3
        }
    ]
};

// console.log(person.experience[0].company);
person.experience.forEach(exp=>console.log(exp.company));
