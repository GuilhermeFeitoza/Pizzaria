using AutoMapper;
using WebAPI.ViewModel;
using Pizzaria.Domain.Models;
using Pizzaria.WebAPI.ViewModel;
using System.Collections.Generic;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<TbCliente, ClienteViewModel>();
        CreateMap<ClienteViewModel, TbCliente>();
        CreateMap<List<ClienteViewModel>,List<TbCliente>>();
         CreateMap<List<TbCliente>,List<ClienteViewModel>>();
    }
}