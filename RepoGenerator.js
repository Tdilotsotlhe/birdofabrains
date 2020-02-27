var fs = require('fs');
var fc = require('./FileCreator');

var dir = "./Transacton"
var listOfDto = [];
//read file
var text = fs.readFileSync("./fnList.txt").toString('utf-8');

//split by line
var array = text.split("\n");

//remove duplicates
const uniArr = [...(new Set(array))];

//loop through each record and write to file
uniArr.forEach(element => {
	abc = element;

	var params = fc.RepoStruct(abc);
	fc.WriteData(genModel(params), params.fnName, dir); 

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
		if (!fs.existsSync(path)) {
			var exec = require('child_process').exec;
			exec('node DtoGenerator.js '+ element, function callback(error, stdout, stderr) {
				console.log(stdout);
			});
		}
	} catch (err) {
		console.error(err)
	}
});



//generates object conforming to model
function genModel(details) {
	var fnName = details.fnName;
	var paramString = details.paramString;
	var retType = details.returnType.includes('IQueryable') ? details.returnType.substr(details.returnType.indexOf('<') + 1, details.returnType.indexOf('>') - details.returnType.indexOf('<') - 1) : details.returnType;
	
	var writeString = 'using System;\nusing System.Collections.Generic;\nusing System.Threading;\nusing System.Threading.Tasks;\nusing MediatR;\nusing Xcelerate.DataAccess.DBO.Models;\nusing Xcelerate.DataAccess.DBO;\nusing AutoMapper;\n\nnamespace Xcelerate.Application.Tx \n{ \n public class ' + fnName + ' \n { \n public class Query : IRequest<' + retType + '> \n {\n' + paramString + '\n } \n public class Handler : IRequestHandler<Query, ' + retType + '>\n {\n private readonly DBOContext _context;\n private readonly IMapper _mapper;\n public Handler(DBOContext context, IMapper mapper)\n {\n _context = context;\n_mapper = mapper;\n }\n  public async Task<' + retType + '> Handle(Query request, CancellationToken cancellationToken)\n {\n return _mapper.Map<' + retType + '>();\n }\n}\n}\n}'

	return writeString;
}