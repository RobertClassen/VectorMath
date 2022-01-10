namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class FloatExtensions
	{
		public static float LerpX(this float t, Bounds bounds, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return t.Lerp(bounds.min.x, bounds.max.x, isClamped);
		}

		public static float LerpY(this float t, Bounds bounds, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return t.Lerp(bounds.min.y, bounds.max.y, isClamped);
		}

		public static float LerpZ(this float t, Bounds bounds, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return t.Lerp(bounds.min.z, bounds.max.z, isClamped);
		}
	}
}