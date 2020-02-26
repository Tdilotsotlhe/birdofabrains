var fs = require('fs');

//read file
var text = fs.readFileSync("./fnList.txt").toString('utf-8');

//split by line
var array = text.split("\n");

//remove duplicates
const uniArr = [...(new Set(array))];
var writeString = "";
// split each line
var listOfDto = [];
//loop through each record and write to file
uniArr.forEach(element => {
    abc = element;//.split(',');
    //////////////////////////////
    // console.log(abc);
    splittedSelection = abc.split(/(?<=^\S+)\s/);//.filter(function(value) {


    var returnType = splittedSelection[0];

    var splitter = splittedSelection[1].split(/[()]/);

    var fnName = splitter[0];
    //console.log(splitter);
    var params = splitter[1] === "" ? "//no params" : splitter[1].split(',');
    // console.log("Function Name: " + fnName + " Params : " + params);

    var paramString = "";
    for (let index = 0; index < params.length; index++) {
        if (params == "//no params") {
            // console.log("no params");
        } else {
            paramString += "public " + params[index] + "{get; set;}\n";
            // console.log(params[index]);
        }


    }


    writeData(genModel(1, [returnType, fnName, paramString]), fnName);

    ///findDTOs in string

    const regex = /\w+Dto/g;
    const found = element.match(regex);
    if (found) {
        found.forEach(element => {
            listOfDto.push(element);
        });
    }





});
const listOfDto2 = [...(new Set(listOfDto))];
///check if DTO exists locally in new project
listOfDto2.forEach(element => {

    var path = 'C:\\sandbox\\xlr8\\Application\\Transaction\\Dto\\' + element + ".cs";

    try {
        if (fs.existsSync(path)) {
            //file exists
            // console.log("exists: " + element);
        } else {
            // console.log("nonexistant: " + element);
            ///if they dont, generate new dto
            var exec = require('child_process').exec;
            // console.log("running EXEC");
            exec('node DtoGenerator.js '+element, function callback(error, stdout, stderr) {
                // result
                console.log(stdout);
            });
        }
    } catch (err) {
        console.error(err)
    }
});
///if they dont, generate new dto
// var exec = require('child_process').exec;
// exec('', function callback(error, stdout, stderr) {
//     // result
//     console.log(stdout);
// });


function writeData(theString, filename) {

    fs.writeFile(filename + '.cs', theString, (err) => {
        if (err) throw err;
        console.log('record added');
    })
}






//generates object conforming to model
function genModel(num, details) {
    var fnName = details[1];
    var paramString = details[2];
    var retType = details[0].includes('IQueryable') ? details[0].substr(details[0].indexOf('<') + 1, details[0].indexOf('>') - details[0].indexOf('<') - 1) : details[0];
    // console.log(details[0].lastIndexOf('>') + 1);

    // return writeString += '{\nid: 1,\ntown:\''+town+'\',\nstreet:\''+street+'\',\n province:\''+province+'\'\n},\n';
    // using System;\nusing System.Collections.Generic;\nusing System.Threading;\nusing System.Threading.Tasks;\nusing MediatR;\nusing Xcelerate.DataAccess.DBO.Models;\nusing Xcelerate.DataAccess.DBO;

    var writeString = 'using System;\nusing System.Collections.Generic;\nusing System.Threading;\nusing System.Threading.Tasks;\nusing MediatR;\nusing Xcelerate.DataAccess.DBO.Models;\nusing Xcelerate.DataAccess.DBO;\nusing AutoMapper;\n\nnamespace Xcelerate.Application.Tx \n{ \n public class ' + fnName + ' \n { \n public class Query : IRequest<' + retType + '> \n {\n' + paramString + '\n } \n public class Handler : IRequestHandler<Query, ' + retType + '>\n {\n private readonly DBOContext _context;\n private readonly IMapper _mapper;\n public Handler(DBOContext context, IMapper mapper)\n {\n _context = context;\n_mapper = mapper;\n }\n  public async Task<' + retType + '> Handle(Query request, CancellationToken cancellationToken)\n {\n return _mapper.Map<' + retType + '>();\n }\n}\n}\n}'
    //  console.log(writeString);

    return writeString;
}
