using ApiPeepConnect.Domain.Queries.Interfaces;
using ApiPeepConnect.Models.ReadModels;
using Npgsql;
using Dapper;
using System.Linq;

public class SingelUserMatchProfileHandler : IQueryHandler<SingelUserMatchProfile, UserMatchProfileEntity> 
{
    private readonly SingelUserMatchProfile _query;
    private string _connectionString;
    public SingelUserMatchProfileHandler(SingelUserMatchProfile query)
    {
        _query = query;   
    }
    public UserMatchProfileEntity Get()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<UserMatchProfileEntity>("").ToList().SingleOrDefault();//MockWidgetDatabase.Widgets.FirstOrDefault(w => w.ID == _query.ID);
        }
    }
}