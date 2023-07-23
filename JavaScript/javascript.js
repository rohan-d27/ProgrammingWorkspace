
setTimeout(() => {
    console.log("hi after 10s");
}, 1000);
console.log("hi"); setInterval(() => {
    console.log("Interval after 10s");
}, 1000);
console.log("hi");


// var obj = {
// name: 'rohan',
// surname: 'dharurkar',
// job: 'software engineer',
// func: function myFunction(birthyear) {
// return (new Date().getFullYear() - birthyear);
// }
// };
// console.log(obj);
// console.log(obj.name);
// console.log(`${obj.name}'s age is ${obj.func(1998)} `);

// let arr = [10, 20, 30, 40, 50, 60, 70, 80];
// arr.forEach(element => console.log(element));

// "use strict";
// let mobj = {
// myfunction: (number) => {
// console.log("The number is: " + this);
// }
// }
// mobj.myfunction();