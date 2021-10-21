namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;
	using WellDefinedNumerics;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Checks if the magnitude of the <c>vector</c> equals <c>1</c>.
		/// </summary>
		public static bool IsNormalized(this Vector3 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < Numeric.MagnitudeDelta;
		}
	}
}