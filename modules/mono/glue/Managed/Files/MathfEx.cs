using System;

#if REAL_T_IS_DOUBLE
using real_t = System.Double;
#else
using real_t = System.Single;
#endif

namespace Godot
{
    public static partial class Mathf
    {
        // Define constants with Decimal precision and cast down to double or float.

        public const real_t E = (real_t) 2.7182818284590452353602874714M; // 2.7182817f and 2.718281828459045
        public const real_t Sqrt2 = (real_t) 1.4142135623730950488016887242M; // 1.4142136f and 1.414213562373095

#if REAL_T_IS_DOUBLE
        public const real_t Epsilon = 1e-14; // Epsilon size should depend on the precision used.
#else
        public const real_t Epsilon = 1e-06f;
#endif

        public static Vector2 Min(Vector2 a, Vector2 b)
        {
            return new Vector2(Min(a.x, b.x), Min(a.y, b.y));
        }

        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Min(a.x, b.x), Min(a.y, b.y), Min(a.z, b.z));
        }

        public static Vector2 Max(Vector2 a, Vector2 b)
        {
            return new Vector2(Max(a.x, b.x), Max(a.y, b.y));
        }

        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Max(a.x, b.x), Max(a.y, b.y), Max(a.z, b.z));
        }

        public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)
        {
            return new Vector2(Clamp(value.x, min.x, max.x), Clamp(value.y, min.y, max.y));
        }

        public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            return new Vector3(Clamp(value.x, min.x, max.x), Clamp(value.y, min.y, max.y), Clamp(value.z, min.z, max.z));
        }

        public static int DecimalCount(real_t s)
        {
            return DecimalCount((decimal)s);
        }

        public static int DecimalCount(decimal s)
        {
            return BitConverter.GetBytes(decimal.GetBits(s)[3])[2];
        }

        public static int CeilToInt(real_t s)
        {
            return (int)Math.Ceiling(s);
        }

        public static int FloorToInt(real_t s)
        {
            return (int)Math.Floor(s);
        }

        public static int RoundToInt(real_t s)
        {
            return (int)Math.Round(s);
        }

        public static bool IsEqualApprox(real_t a, real_t b, real_t tolerance)
        {
            return Abs(a - b) < tolerance;
        }
    }
}