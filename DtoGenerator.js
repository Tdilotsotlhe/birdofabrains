var fs = require('fs');
var fc = require('./FileCreator');
var exec = require('child_process').exec;


function DtoGen(theDto, folder = "") {

    var pathDto = "C:\\sandbox\\xcelerate\\DataAccess\\InsureGroup DataAccess\\dtos\\" + theDto + ".cs";
    dir = folder === "" ? "./Dto" : folder + "\\Dto"
    //read file
    if (fs.existsSync(pathDto)) {
        var text = fs.readFileSync(pathDto).toString('utf-8');
        var theMeat = fc.DtoExtract(text);
        var withTheusings = "using System.Collections.Generic;\nusing System;\nusing System.Runtime.Serialization;\nnamespace Xcelerate.Application.Tx.Dto\n{\n" + theMeat + "\n}";


        fc.WriteData(withTheusings, theDto, dir);
        fs.appendFile('DtoList.txt', theDto+"\n", function (err) {
            if (err) throw err;
            console.log('Saved!');
          });
        check4MoreDtos(theMeat, folder);
    }
    else
        console.log("cant find dto in old project");
}

//////////////////////
function check4MoreDtos(withTheusings, folder) {

    const regex = /\w+Dto/g;
    const found = withTheusings.match(regex);
    if (found) {
        found.forEach(element => {
            if (!fs.existsSync(folder + "\\Dto\\" + element + ".cs")) {

                // fs.appendFile('DtoList.txt', element, function (err) {
                //     if (err) throw err;
                //     console.log('Saved!');
                //   });


                DtoGen(element, folder);
            }
        });
    }

}
module.exports = {
    DtoGen
}



