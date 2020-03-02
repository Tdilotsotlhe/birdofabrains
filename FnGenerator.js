var fs = require('fs');
var fc = require('./FileCreator');
// var exec = require('child_process').spawn;
var DTG = require("./DtoGenerator");

function sleep(delay) {
	var start = new Date().getTime();
	while (new Date().getTime() < start + delay);
}
sleep(10000);

var dir = "./Transaction/Common"
var listOfDto = [];
//read file
var text = fs.readFileSync("./fnList.txt").toString('utf-8');
var functionsList1 = fs.readFileSync("./functionsList.txt").toString('utf-8').split("\n");
//split by line
// var array = text.split("public");
var array = text.split(/public |private |protected /);
console.log(array);
//remove duplicates
const uniArr = [...(new Set(array))];
var newString = "";
console.log("the Functions");
uniArr.forEach(element => {
	console.log(element);

	element = element.trim();
	if (element === "") {
		return;
	}

	///check if function iis in fnLIST
	functionsList1.forEach(element2 => {

		if (element.includes(element2)) {
			// console.log("its there");
			element = "";
			return;
		} else {
			// console.log("not contained")
		}
	});

	if (element === "") {
		return;
	}

	if (element.includes("virtual")) {
		// console.log("exists: "+element)
		element = "\nstatic" + element.replace("virtual", "");
		// console.log("fixedthing: "+element);

	} else {
		element = "\nstatic " + element;
	}


	newString += element;
});
// console.log(uniArr);
// console.log(newString);



//step 1: 	Splitting by public,private,protected
//step 2: 	Check if it has virtual or not
//Step 3:	Check if position 1 in array contains a record from Original FnList
//step 4: 	Skip anything you dont need to make
//step 5:	Replace publics etc. with INTERNAL
//step 6: 	fetch DTOs

var namespaces = "using System;\nusing System.Collections.Generic;\nusing System.Threading;\nusing System.Threading.Tasks;\nusing MediatR;\nusing Xcelerate.DataAccess.DBO.Models;\nusing Xcelerate.DataAccess.DBO;\nusing AutoMapper;\n\nnamespace Xcelerate.Application.Tx \n{ \n internal class common\n{";
var finalString = namespaces + newString;


fc.WriteData(finalString, "common", "./Transaction");




