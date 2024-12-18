using Chrysalis.Cbor.Attributes;
using Chrysalis.Cbor.Converters.Primitives;
using Chrysalis.Cbor.Types;

namespace Chrysalis.Cardano.Core.Types.Block.Transaction.Script;

[CborConverter(typeof(UnionConverter))]
public abstract record PlutusData : CborBase;


[CborConverter(typeof(CustomConstrConverter))]
public record PlutusConstr(List<PlutusData> PlutusData) : PlutusData;


[CborConverter(typeof(MapConverter))]
[CborDefinite]
public record PlutusMap(Dictionary<PlutusData, PlutusData> Value) : PlutusData;


[CborConverter(typeof(UnionConverter))]
public abstract record PlutusBigInt : PlutusData;


[CborConverter(typeof(UlongConverter))]
public record PlutusBigUInt(ulong Value) : PlutusBigInt;


[CborConverter(typeof(LongConverter))]
public record PlutusBigNInt(long Value) : PlutusBigInt;


[CborConverter(typeof(UnionConverter))]
public abstract record PlutusBytes : PlutusData;


[CborConverter(typeof(BytesConverter))]
[CborSize(64)]
public record PlutusBoundedBytes(byte[] Value) : PlutusBytes;


[CborConverter(typeof(BytesConverter))]
public record PlutusDefiniteBytes(byte[] Value) : PlutusBytes;


[CborConverter(typeof(BytesConverter))]
[CborTag(2)]
public record PlutusBytesWithTag(byte[] Value) : PlutusBytes;


[CborConverter(typeof(UnionConverter))]
public abstract record PlutusList : PlutusData;


[CborConverter(typeof(ListConverter))]
public record PlutusIndefiniteList(List<PlutusData> Value) : PlutusList;


[CborConverter(typeof(ListConverter))]
[CborDefinite]
public record PlutusDefiniteList(List<PlutusData> Value) : PlutusList;
