namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using WellDefinedNumerics;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int Abs(this Vector3Int vector)
		{
			return new Vector3Int(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
		}
	}
}