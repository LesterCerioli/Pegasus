using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.CidadeEvent;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;

namespace Galax.Solution.Domain.Commands.CityCommands
{
    public class CityCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewCityCommand, ValidationResult>,
        IRequestHandler<UpdateCityCommand, ValidationResult>,
        IRequestHandler<RemoveCityCommand, ValidationResult>





    {
        private readonly ICityRepository _cityRepository;

        
        //using MediatoR
        public CityCommandHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewCityCommand message, CancellationToken cancellationToken)
        {
            if(!message.IsValid()) return message.ValidationResult;
            
            var city = new City(Guid.NewGuid(), message.Name, message.Actived);

            if (await _cityRepository.GetByName(city.Name)!= null)
            {
                AddError("O nome da Cidade já foi enviado.");
                return ValidationResult;
            }
            city.AddDomainEvent(new CityRegisteredEvent(city.Id, city.Name, city.Actived));
            _cityRepository.Add(city);
            return await Commit(_cityRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateCityCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var city = new City(message.Id, message.Name, message.Actived);
            var existingCity = await _cityRepository.GetByName(city.Name);

            if (existingCity != null && existingCity.Id != city.Id)
            {
               if (!existingCity.Equals(city))
               {
                   AddError(" O nome da Cidade já foi enviado.");
                   return ValidationResult;
               }
            }

            city.AddDomainEvent(new CityUpdatedEvent(city.Id, city.Name));

            _cityRepository.Update(city);

            return await Commit(_cityRepository.UnitOfWork);
        }     
        
             
        public async Task<ValidationResult> Handle(RemoveCityCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var city = await _cityRepository.GetById(message.Id);

            if (city is null)
            {
                AddError("Essa Cidade não existe.");
                return ValidationResult;
            }

            city.AddDomainEvent(new CityRemovedEvent(message.Id));

            _cityRepository.Remove(city);

            return await Commit(_cityRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _cityRepository.Dispose();
        }
    }
        
}