var fs = require('fs');
var fc = require('./FileCreator');

console.log(process.argv[2]);
var theDto = process.argv[2];
var pathDto = "C:\\sandbox\\xcelerate\\DataAccess\\InsureGroup DataAccess\\dtos\\" + theDto + ".cs";
var dir = "./Dto"
//read file

var text = fs.readFileSync(pathDto).toString('utf-8');
var theMeat = fc.DtoExtract(text);
var withTheusings = "using System;\nusing System.Runtime.Serialization;\nnamespace Xcelerate.Application.Tx.Dto\n{\n\n" + theMeat + "\n}";


fc.WriteData(withTheusings, theDto, dir);


//////////////////////
const regex = /\w+Dto/g;
const found = withTheusings.match(regex);
if (found) {
    found.forEach(element => {
        var exec = require('child_process').exec;
        // console.log("running EXEC");
        if (!fs.existsSync("Dto\\" +element+".cs")) {
        exec('node DtoGenerator.js ' + element, function callback(error, stdout, stderr) {
            // result
            console.log(stdout);
        });
    }
    });
}





