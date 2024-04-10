using AutoMapper;
using WebAPI.ViewModel;
using Pizzaria.Domain.Models;

public class FuncionarioProfile: Profile
{
    public FuncionarioProfile()
    {
        CreateMap<TbFuncionario, FuncionarioViewModel>();
        CreateMap<FuncionarioViewModel, TbFuncionario>();
    }
}