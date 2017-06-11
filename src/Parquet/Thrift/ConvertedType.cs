/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

/// <summary>
/// Common types used by frameworks(e.g. hive, pig) using parquet.  This helps map
/// between types in those frameworks to the base types in parquet.  This is only
/// metadata and not needed to read or write the data.
/// </summary>
public enum ConvertedType
{
  /// <summary>
  /// a BYTE_ARRAY actually contains UTF8 encoded chars
  /// </summary>
  UTF8 = 0,
  /// <summary>
  /// a map is converted as an optional field containing a repeated key/value pair
  /// </summary>
  MAP = 1,
  /// <summary>
  /// a key/value pair is converted into a group of two fields
  /// </summary>
  MAP_KEY_VALUE = 2,
  /// <summary>
  /// a list is converted into an optional field containing a repeated field for its
  /// values
  /// </summary>
  LIST = 3,
  /// <summary>
  /// an enum is converted into a binary field
  /// </summary>
  ENUM = 4,
  /// <summary>
  /// A decimal value.
  /// 
  /// This may be used to annotate binary or fixed primitive types. The
  /// underlying byte array stores the unscaled value encoded as two's
  /// complement using big-endian byte order (the most significant byte is the
  /// zeroth element). The value of the decimal is the value * 10^{-scale}.
  /// 
  /// This must be accompanied by a (maximum) precision and a scale in the
  /// SchemaElement. The precision specifies the number of digits in the decimal
  /// and the scale stores the location of the decimal point. For example 1.23
  /// would have precision 3 (3 total digits) and scale 2 (the decimal point is
  /// 2 digits over).
  /// </summary>
  DECIMAL = 5,
  /// <summary>
  /// A Date
  /// 
  /// Stored as days since Unix epoch, encoded as the INT32 physical type.
  /// 
  /// </summary>
  DATE = 6,
  /// <summary>
  /// A time
  /// 
  /// The total number of milliseconds since midnight.  The value is stored
  /// as an INT32 physical type.
  /// </summary>
  TIME_MILLIS = 7,
  /// <summary>
  /// A date/time combination
  /// 
  /// Date and time recorded as milliseconds since the Unix epoch.  Recorded as
  /// a physical type of INT64.
  /// </summary>
  TIMESTAMP_MILLIS = 9,
  /// <summary>
  /// An unsigned integer value.
  /// 
  /// The number describes the maximum number of meainful data bits in
  /// the stored value. 8, 16 and 32 bit values are stored using the
  /// INT32 physical type.  64 bit values are stored using the INT64
  /// physical type.
  /// 
  /// </summary>
  UINT_8 = 11,
  UINT_16 = 12,
  UINT_32 = 13,
  UINT_64 = 14,
  /// <summary>
  /// A signed integer value.
  /// 
  /// The number describes the maximum number of meainful data bits in
  /// the stored value. 8, 16 and 32 bit values are stored using the
  /// INT32 physical type.  64 bit values are stored using the INT64
  /// physical type.
  /// 
  /// </summary>
  INT_8 = 15,
  INT_16 = 16,
  INT_32 = 17,
  INT_64 = 18,
  /// <summary>
  /// An embedded JSON document
  /// 
  /// A JSON document embedded within a single UTF8 column.
  /// </summary>
  JSON = 19,
  /// <summary>
  /// An embedded BSON document
  /// 
  /// A BSON document embedded within a single BINARY column.
  /// </summary>
  BSON = 20,
  /// <summary>
  /// An interval of time
  /// 
  /// This type annotates data stored as a FIXED_LEN_BYTE_ARRAY of length 12
  /// This data is composed of three separate little endian unsigned
  /// integers.  Each stores a component of a duration of time.  The first
  /// integer identifies the number of months associated with the duration,
  /// the second identifies the number of days associated with the duration
  /// and the third identifies the number of milliseconds associated with
  /// the provided duration.  This duration of time is independent of any
  /// particular timezone or date.
  /// </summary>
  INTERVAL = 21,
}