/*function doThisLongRunningTask(callback){
    setTimeout(() => {
        const name = 'javascript';
        callback(name);
     }, 5000);
}

function showResult(res){
    console.log(res);
}
doThisLongRunningTask(showResult);
console.log('I am done');*/

/*const p = new Promise((resolve, reject) => {
    const name = 'javascript';
    resolve(name);
});

p.then(res=>console.log(res));*/
//document.write('hello');
// fetch('https://reqres.in/api/users')
// .then(Response => Response.json())
// .then(result => {
//     result.data.forEach(user => {
//         console.log(user.email);
//     });
// });

fetch('https://reqres.in/api/users')
.then(Response => Response.json())
.then(result => {
    const users = result.data;
    users.forEach(user=>{
        const row = `
        <tr>
            <td>${user.id}</td>
            <td>
                <img src="${user.avatar}" height="50">
            </td>
            <td>${user.first_name} ${user.last_name}</td>
            <td>${user.email}</td>
        </tr>
        `;
        target.innerHTML += row
    });
});

fetch('https://reqres.in/api/users')
.then(Response => Response.json())
.then(result => {
    console.log(result);
    const users = result.data;
    users.forEach(user=>{
        
    })
})