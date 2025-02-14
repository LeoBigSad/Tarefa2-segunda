using AutoMapper;

namespace Tarefa2_Segunda
{
    public class ExemploMapper
    {
        private static readonly IMapper _mapper;

        static ExemploMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Pessoa, PessoaDTO>()
                    .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.Nome))
                    .ForMember(dest => dest.IdadeEmTexto, opt => opt.MapFrom(src => src.Idade.ToString())); // Conversão de tipo
            });

            _mapper = config.CreateMapper();
        }

        public static PessoaDTO MapToDto(Pessoa person)
        {
            return _mapper.Map<PessoaDTO>(person);
        }
    }
}
