using System;

/// <summary>
/// Compensation class since delegates are finnicky with pass-by-reference.
/// </summary>
public class EventWrapper
{
    public Action action;
}