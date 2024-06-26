﻿using CookieCookbook2.Recipes.Ingredients;

namespace CookieCookbook2.Recipes;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
{
    new WheatFlour(),
    new SpeltFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder(),
};

    public Ingredient GetById(int id) => 
        All.FirstOrDefault(ingredient => ingredient.Id == id);
}
