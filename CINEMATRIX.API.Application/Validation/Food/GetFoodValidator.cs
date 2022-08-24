﻿using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Queries.FoodQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Food
{
    public class GetFoodValidator : AbstractValidator<GetFoodQuery>
    {
        private readonly IFoodService _foodService;

        public GetFoodValidator(IFoodService foodService)
        {
            _foodService = foodService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)));

            RuleFor(query => query.Id)
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.FoodNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _foodService.ExistsAsync(id, cancellationToken);
    }
}