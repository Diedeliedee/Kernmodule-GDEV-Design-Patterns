using UnityEngine;

[System.Serializable]
public class InputRelation
{
    public readonly InputCondition condition;
    public readonly ICommand command;

    public InputRelation(InputCondition condition, ICommand command)
    {
        this.condition = condition;
        this.command = command;
    }

}

public delegate bool InputCondition();