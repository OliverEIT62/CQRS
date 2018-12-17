using System.Collections.Generic;
using ApiPeepConnect.Domain.Queries.Interfaces;
//using ApiPeepConnect.Domain.Queries.Queries;
using ApiPeepConnect.Models.ReadModels;

public class QueryHandlerFactory: IQueryFactoryHandler
{
    private string _connectionString;
    public QueryHandlerFactory(string connectionString)
    {
        _connectionString = connectionString;
    }
    public IQueryHandler<SingelUserMatchProfile, UserMatchProfileEntity> Build(SingelUserMatchProfile query)
    {
        return new SingelUserMatchProfileHandler(query);
    }
}