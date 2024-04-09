using AutoMapper;
using WebAPI.Models;
using WebAPI.ViewModel;

public class FuncionarioProfile: Profile
{
    public FuncionarioProfile()
    {
        CreateMap<TbFuncionario, FuncionarioViewModel>();
        CreateMap<FuncionarioViewModel, TbFuncionario>();
    }
}