using ApiPeepConnect.Domain.Queries.Interfaces;
using ApiPeepConnect.Models.ReadModels;

public interface IQueryFactoryHandler
{
    IQueryHandler<SingelUserMatchProfile, UserMatchProfileEntity> Build(SingelUserMatchProfile query);
}