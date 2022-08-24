﻿using CINEMATRIX.API.Application.Commands.FoodCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;

namespace CINEMATRIX.API.Application.Validation.Food
{
    public class AddFoodValidator : FoodValidatorBase<AddFoodCommand, long>
    {
        public AddFoodValidator() : base() { }
    }
}