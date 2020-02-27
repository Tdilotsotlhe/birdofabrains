using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Xcelerate.DataAccess.DBO.Models;
using Xcelerate.DataAccess.DBO;
using AutoMapper;

namespace Xcelerate.Application.Tx 
{ 
 public class GetTransactionsByClientImportFileID 
 { 
 public class Query : IRequest<IEnumerable<TransactionDto>> 
 {
public int clientImportFileID {get; set;}

 } 
 public class Handler : IRequestHandler<Query, IEnumerable<TransactionDto>>
 {
 private readonly DBOContext _context;
 private readonly IMapper _mapper;
 public Handler(DBOContext context, IMapper mapper)
 {
 _context = context;
_mapper = mapper;
 }
  public async Task<IEnumerable<TransactionDto>> Handle(Query request, CancellationToken cancellationToken)
 {
 return _mapper.Map<IEnumerable<TransactionDto>>();
 }
}
}
}