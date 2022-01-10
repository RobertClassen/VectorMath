namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static float LerpX(this Rect rect, float t, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return rect.xMin.Lerp(rect.xMax, t, isClamped);
		}

		public static float LerpY(this Rect rect, float t, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return rect.yMin.Lerp(rect.yMax, t, isClamped);
		}
	}
}