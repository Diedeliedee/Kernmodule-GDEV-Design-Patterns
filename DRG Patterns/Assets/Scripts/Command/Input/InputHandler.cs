using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public partial class InputHandler : MonoBehaviour, IServiceItem
{
    private List<InputRelation> relations = new List<InputRelation>();

    private void Awake()
    {
        ServiceLocator.Instance.Add("Input", this);
    }

    public void AddCommand(InputCondition condition, ICommand command)
    {
        relations.Add(new InputRelation(condition, command));
    }

    public void HandleInput()
    {
        foreach (var relation in relations)
        {
            if (relation.condition()) relation.command.Execute();
        }
    }
}