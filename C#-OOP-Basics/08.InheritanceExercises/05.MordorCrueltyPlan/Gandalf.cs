using System;
using System.Collections.Generic;

public class Gandalf
{
    private int HappinessPoints;

    public Mood GetConditionOfGandalf()
    {
        return MoodFactory.GetMood(this.HappinessPoints);
    }

    public void Eat(IEnumerable<Food> foods)
    {
        foreach (var food in foods)
        {
            this.HappinessPoints += food.PointsOfHappiness;
        }
    }

    public override string ToString()
    {
        var mood = this.GetConditionOfGandalf();
        return $"{this.HappinessPoints}{Environment.NewLine}{mood.GetType().Name}";
    }
}