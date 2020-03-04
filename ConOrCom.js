//find references of the functions in the respective controller or common
var fs = require('fs');

///get list of props/funcs/methods etc.
var contents = fs.readFileSync("./controllerornah.txt").toString('UTF-8').split("\n");
console.log(contents);

//getcontents of controller
//read file
var controller = "C:\\sandbox\\xcelerate\\InsureGroup Web Api\\Controllers\\TransactionController.cs";
var wtf = "./wtf.txt";
var text = fs.readFileSync(wtf).toString('UTF-8');//.split('\n');
// console.log("controller: \n" + text);

function sleep(delay) {
	var start = new Date().getTime();
	while (new Date().getTime() < start + delay);
}
sleep(10000);


//collect matches and print to file
contents.forEach(element => {
	console.log(element)
	if (text.includes(element.trim())) {
		console.log("SHO");
	} else {
		console.log("SHIIIIIIIII")
	}
	// theRegex = new RegExp(element, 'g');

	// if (text.includes(element)) {
	// 	console.log('awe')
	// } else {
	// 	console.log('not there')
	// }

	// text.forEach(el => {
	// 	if (el.includes(element)) {
	// 		console.log('Found')
	// 	} else {
	// 		console.log('Not Found')
	// 	}
	// });
	// if (text.find(element2 => element2.includes(element))) {
	// 	console.log("shit");
	// } else {
	// 	console.log('no shit')
	// }


	// var regex = new RegExp(element, "g");
	// if (text.indexOf(element, 1)) {
	// 	console.log(text.indexOf(element, 1));
	// 	// console.log("FOund it " + element);
	// } else {
	// 	// console.log("not found " + element);
	// }
});



var matches = Array();



