var fs = require('fs');

function ClassCount(str) {

    return ((str || '').match(/class/g) || []).length
}


function WriteData(theString, filename, directory) {

    if (!fs.existsSync(directory)) {
        console.log("directory does not exist");
        console.log("creating directory: " + directory);
        fs.mkdirSync(directory);
    } 
    fs.writeFile(directory +"\\"+ filename + '.cs', theString, (err) => {
        if (err) throw err;
        console.log('record added: '+filename);
    })
}

function DtoExtract(text) {

    const classCounter = ClassCount(text);
    extraxtedClass = "";

    if (classCounter > 1) {
        extraxtedClass = text.substring(text.indexOf("{") + 1, text.indexOf("class", text.indexOf("class") + 1));
        extraxtedClass = extraxtedClass.substring(0, extraxtedClass.lastIndexOf('}') + 1);
    } else {
        extraxtedClass = text.substring(text.indexOf("{") + 1, text.lastIndexOf('}') - 1);
    }
    extraxtedClass = extraxtedClass.replace("public partial class", "public class");

    return extraxtedClass;
}

function RepoStruct(params) {

    var splittedSelection = params.split(/(?<=^\S+)\s/);
	var returnType = splittedSelection[0];
	var splitter = splittedSelection[1].split(/[()]/);
	var fnName = splitter[0];
	var params = splitter[1] === "" ? "//no params" : splitter[1].split(',');
    var paramString = "";
    
	for (let index = 0; index < params.length; index++) {
		if (params == "//no params") {
			paramString += params;
		} else {
			paramString += "public " + params[index] + " {get; set;}\n";
		}
    }
    return {returnType, fnName, paramString};
}

module.exports = {
    ClassCount,
    WriteData,
    DtoExtract,
    RepoStruct
}