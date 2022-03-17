﻿using System;
using System.Collections.Generic;

/// <summary>
///   Allows placing individual hexes with data in a layout
/// </summary>
/// <typeparam name="TData">The type of data to hold in hexes</typeparam>
[UseThriveSerializer]
public class IndividualHexLayout<TData> : HexLayout<HexWithData<TData>>
{
    public IndividualHexLayout(Action<HexWithData<TData>> onAdded, Action<HexWithData<TData>>? onRemoved = null) : base(
        onAdded, onRemoved)
    {
    }

    public IndividualHexLayout()
    {
    }

    protected override IEnumerable<Hex> GetHexComponentPositions(HexWithData<TData> hex)
    {
        yield return hex.Position;
    }
}
