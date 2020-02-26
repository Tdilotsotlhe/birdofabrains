var fs = require('fs');
console.log(process.argv[2]);
var theDto = process.argv[2];
var pathDto = "C:\\sandbox\\xcelerate\\DataAccess\\InsureGroup DataAccess\\dtos\\"+theDto+".cs";
//read file

var text = fs.readFileSync(pathDto).toString('utf-8');

const count = (str) => {
    const re = /class/g
    return ((str || '').match(re) || []).length
  }

  console.log("Num Matches : "+count(text));
  var classCounter = count(text);
  if(classCounter > 1){
      console.log("more than 1 Class");
      var theMeat = text.substring(text.indexOf("{")+1, text.indexOf("class", text.indexOf("class") + 1));
      theMeat = theMeat.substring(0,theMeat.lastIndexOf('}')+1);
      console.log(theMeat);
    }else{
        var theMeat = text.substring(text.indexOf("{")+1, text.lastIndexOf('}')-1);
        console.log(theMeat);
        console.log("Only 1 class");
    }
    
theMeat = theMeat.replace("public partial class", "public class");

// console.log(theMeat);

var withTheusings = "using System;\nusing System.Runtime.Serialization;\nnamespace Xcelerate.Application.Tx.Dto\n{\n\n"+theMeat+"\n}";
// console.log(withTheusings);

writeData(withTheusings,theDto);


//////////////////////
const regex = /\w+Dto/g;
const found = withTheusings.match(regex);
if (found) {
    found.forEach(element => {
        var exec = require('child_process').exec;
// console.log("running EXEC");
exec('node DtoGenerator.js '+element, function callback(error, stdout, stderr) {
    // result
    console.log(stdout);
});
    });
}

// var exec = require('child_process').exec;
// // console.log("running EXEC");
// exec('node DtoGenerator.js '+element, function callback(error, stdout, stderr) {
//     // result
//     console.log(stdout);
// });

/////////////////////

function writeData(theString, filename) {

    fs.writeFile('dtofolder\\'+filename+'.cs', theString, (err) => {
        if (err) throw err;
        console.log('record added');
    })
}



