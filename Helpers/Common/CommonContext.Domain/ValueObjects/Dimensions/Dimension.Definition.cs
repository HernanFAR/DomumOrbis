using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace CommonContext.ValueObjects.Dimensions;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract record Dimension;

public sealed record Weight : Dimension;

public sealed record Volumen : Dimension;

public sealed record Count : Dimension;

public sealed record Length : Dimension;
