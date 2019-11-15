﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

#nullable enable

namespace osu.Framework.Extensions.IEnumerableExtensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Performs an action on all the items in an IEnumerable collection.
        /// </summary>
        /// <typeparam name="T">The type of the items stored in the collection.</typeparam>
        /// <param name="collection">The collection to iterate on.</param>
        /// <param name="action">The action to be performed.</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            if (collection == null) return;

            foreach (var item in collection)
                action(item);
        }

        /// <summary>
        /// Wraps this object instance into an <see cref="IEnumerable{T}"/>
        /// consisting of a single item.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="item">The instance that will be wrapped.</param>
        /// <returns> An <see cref="IEnumerable{T}"/> consisting of a single item.</returns>
        public static IEnumerable<T> Yield<T>(this T item) => new[] { item };

        /// <summary>
        /// Retrieves the item after a pivot from an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the items stored in the collection.</typeparam>
        /// <param name="collection">The collection to iterate on.</param>
        /// <param name="pivot">The pivot value.</param>
        /// <returns>The item in <paramref name="collection"/> appearing after <paramref name="pivot"/>, or null if no such item exists.</returns>
        [return: MaybeNull]
        public static T GetNext<T>(this IEnumerable<T> collection, T pivot)
        {
            return collection.SkipWhile(i => !EqualityComparer<T>.Default.Equals(i, pivot)).Skip(1).FirstOrDefault()!;
        }

        /// <summary>
        /// Retrieves the item before a pivot from an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the items stored in the collection.</typeparam>
        /// <param name="collection">The collection to iterate on.</param>
        /// <param name="pivot">The pivot value.</param>
        /// <returns>The item in <paramref name="collection"/> appearing before <paramref name="pivot"/>, or null if no such item exists.</returns>
        [return: MaybeNull]
        public static T GetPrevious<T>(this IEnumerable<T> collection, T pivot)
        {
            return collection.TakeWhile(i => !EqualityComparer<T>.Default.Equals(i, pivot)).LastOrDefault()!;
        }

        /// <summary>
        /// Returns the most common prefix of every string in this <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <param name="collection">The string <see cref="IEnumerable{T}"/></param>
        /// <returns>The most common prefix</returns>
        /// <example>
        /// "ab" == { "abc", "abd" }.GetCommonPrefix()
        /// </example>
        public static string GetCommonPrefix(this IEnumerable<string> collection)
        {
            return collection.Aggregate((prefix, str) =>
            {
                if (str.StartsWith(prefix)) return prefix;

                for (int i = prefix.Length - 1; i >= 0; i--)
                {
                    if (str.StartsWith(prefix.Substring(0, i)))
                    {
                        return prefix.Substring(0, i);
                    }
                }

                return "";
            });
        }
    }
}
