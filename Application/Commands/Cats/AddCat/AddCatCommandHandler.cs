﻿using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Cats.AddCats
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly ICatRepository _catRepository;
        private readonly ILogger<AddCatCommandHandler> _logger;

        public AddCatCommandHandler(ICatRepository catRepository, ILogger<AddCatCommandHandler> logger)
        {
            _catRepository = catRepository;
            _logger = logger;

        }
        public async Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Starting to handle addcatcommand for cat: {CatName}", request.NewCat.Name);

                Cat CatToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewCat.Name,
                    LikesToPlay = request.NewCat.LikesToPlay,
                    CatBreed = request.NewCat.Breed,
                    CatWeight = request.NewCat.Weight

                };

                await _catRepository.AddAsync(CatToCreate);
                _logger.LogInformation("Cat successfully added with the id: {CatId}", CatToCreate.Id);
                return CatToCreate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while handling AddCatCommand for cat: {CatName}", request.NewCat.Name);
                throw;
            }

        }
    }
}
