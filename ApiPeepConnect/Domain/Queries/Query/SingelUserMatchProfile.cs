using ApiPeepConnect.Domain.Queries.Interfaces;
using ApiPeepConnect.Models.ReadModels;

public class SingelUserMatchProfile : IQuery<UserMatchProfileEntity>
{
    public int ID { get; private set; }
    public SingelUserMatchProfile(int id)
    {
        ID = id;
    }
}