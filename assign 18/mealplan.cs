using System;
using System.Collections.Generic;

public interface IMealPlan
{
    string MealType { get; }
}

public class VegetarianMeal : IMealPlan
{
    public string MealType => "Vegetarian";
}

public class VeganMeal : IMealPlan
{
    public string MealType => "Vegan";
}

public class KetoMeal : IMealPlan
{
    public string MealType => "Keto";
}

public class HighProteinMeal : IMealPlan
{
    public string MealType => "High-Protein";
}

public class Meal<T> where T : IMealPlan
{
    public string Name { get; }
    public T MealCategory { get; }

    public Meal(string name, T category)
    {
        Name = name;
        MealCategory = category;
    }

    public override string ToString() => $"{Name} ({MealCategory.MealType})";
}

public class MealPlanGenerator
{
    public void GenerateMealPlan<T>(Meal<T> meal) where T : IMealPlan
    {
        Console.WriteLine($"Meal: {meal} is successfully generated for your chosen diet.");
    }
}

class Program
{
    static void Main()
    {
        var mealPlanGenerator = new MealPlanGenerator();

        var vegetarianMeal = new Meal<VegetarianMeal>("Vegetarian Salad", new VegetarianMeal());
        var veganMeal = new Meal<VeganMeal>("Vegan Bowl", new VeganMeal());
        var ketoMeal = new Meal<KetoMeal>("Keto Chicken", new KetoMeal());
        var highProteinMeal = new Meal<HighProteinMeal>("High-Protein Steak", new HighProteinMeal());

        mealPlanGenerator.GenerateMealPlan(vegetarianMeal);
        mealPlanGenerator.GenerateMealPlan(veganMeal);
        mealPlanGenerator.GenerateMealPlan(ketoMeal);
        mealPlanGenerator.GenerateMealPlan(highProteinMeal);
    }
}
