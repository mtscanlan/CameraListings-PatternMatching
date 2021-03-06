﻿using System;
using System.Collections.Generic;

namespace StringPatternMatching {
	public static class ExtensionMethods {

		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
			foreach (var item in enumerable)
				action(item);
		}
	}
}
