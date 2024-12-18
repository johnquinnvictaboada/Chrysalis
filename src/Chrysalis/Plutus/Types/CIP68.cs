
using Chrysalis.Cbor.Attributes;
using Chrysalis.Cbor.Converters.Primitives;
using Chrysalis.Cbor.Types;
using Chrysalis.Cbor.Types.Collections;
using Chrysalis.Cbor.Types.Primitives;

namespace Chrysalis.Plutus.Types;

[CborConverter(typeof(ConstrConverter))]
[CborIndex(0)]
public record CIP68<T>() : CborBase
{
    [CborProperty(0)]
    public required CborMap<CborBase, CborBase> Metadata { get; init; }

    [CborProperty(1)]
    public required CborInt Version { get; init; }

    [CborProperty(2)]
    public required T Extra { get; init; }
}