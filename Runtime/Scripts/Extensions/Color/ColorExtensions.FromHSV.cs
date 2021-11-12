namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class ColorExtensions
	{
		public static Color FromHSV(this Color color, float hue, float saturation, float value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Color.HSVToRGB(hue, saturation, value, !isClamped);
		}
	}
}