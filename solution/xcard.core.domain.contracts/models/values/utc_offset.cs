﻿using System;
using System.Text.RegularExpressions;

namespace reexjungle.xcard.core.domain.contracts.models.values
{
    public struct UTC_OFFSET : IEquatable<UTC_OFFSET>, IComparable, IComparable<UTC_OFFSET>
    {
        /// <summary>
        /// Gets the offset hours from UTC to local time.
        /// </summary>
        public int HOURS { get; }

        /// <summary>
        /// Gets the offset minutes from UTC to local time.
        /// </summary>
        public int MINUTES { get; }


        /// <summary>
        /// Initialize a new instance of the <see cref="UTC_OFFSET"/> struct with the given offset
        /// hours, minutes, and seconds from UTC to local time.
        /// </summary>
        /// <param name="hours">The offset hours from UTC to local time.</param>
        /// <param name="minutes">The offset minutes form UTC to local time.</param>
        public UTC_OFFSET(int hours, int minutes)
        {
            HOURS = hours;
            MINUTES = minutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UTC_OFFSET"/> struct with a string value.
        /// </summary>
        /// <param name="value">
        /// The string represenatation of a <see cref="UTC_OFFSET"/> to initialize a new <see
        /// cref="UTC_OFFSET"/> instance with.
        /// </param>
        public UTC_OFFSET(string value)
        {
            var hour = 0;
            var minute = 0;
            var second = 0;
            const string pattern = @"^(?<minus>\-|?<plus>\+)(?<hours>\d{1,2})(?<mins>\d{1,2})?$";
            const RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Compiled;

            var regex = new Regex(pattern, options);
            foreach (Match match in regex.Matches(value))
            {
                if (match.Groups["hours"].Success) hour = int.Parse(match.Groups["hours"].Value);
                if (match.Groups["mins"].Success) minute = int.Parse(match.Groups["mins"].Value);
                if (match.Groups["minus"].Success)
                {
                    hour = -hour;
                    minute = -minute;
                    second = -second;
                }
            }

            HOURS = hour;
            MINUTES = minute;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(UTC_OFFSET other) => HOURS == other.HOURS && MINUTES == other.MINUTES;

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value
        /// has the following meanings: Value Meaning Less than zero This object is less than the
        /// <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>.
        /// Greater than zero This object is greater than <paramref name="other"/>.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public int CompareTo(UTC_OFFSET other)
        {
            if (HOURS < other.HOURS) return -1;
            if (HOURS > other.HOURS) return 1;
            if (MINUTES < other.MINUTES) return -1;
            if (MINUTES > other.MINUTES) return 1;
            return 0;
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <returns>
        /// true if <paramref name="obj"/> and this instance are the same type and represent the same
        /// value; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is UTC_OFFSET && Equals((UTC_OFFSET)obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = HOURS;
                hashCode = (hashCode * 397) ^ MINUTES;
                return hashCode;
            }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer
        /// that indicates whether the current instance precedes, follows, or occurs in the same
        /// position in the sort order as the other object.
        /// </summary>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value
        /// has these meanings: Value Meaning Less than zero This instance precedes <paramref
        /// name="obj"/> in the sort order. Zero This instance occurs in the same position in the
        /// sort order as <paramref name="obj"/>. Greater than zero This instance follows <paramref
        /// name="obj"/> in the sort order.
        /// </returns>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="obj"/> is not the same type as this instance.
        /// </exception>
        /// <filterpriority>2</filterpriority>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is UTC_OFFSET) return CompareTo((UTC_OFFSET)obj);
            throw new ArgumentException(nameof(obj) + " is not of type " + nameof(UTC_OFFSET));
        }

        public static bool operator ==(UTC_OFFSET left, UTC_OFFSET right) => left.Equals(right);

        public static bool operator !=(UTC_OFFSET left, UTC_OFFSET right) => !left.Equals(right);

        public static bool operator <(UTC_OFFSET left, UTC_OFFSET right) => left.CompareTo(right) < 0;

        public static bool operator >(UTC_OFFSET left, UTC_OFFSET right) => left.CompareTo(right) > 0;

        public static bool operator <=(UTC_OFFSET left, UTC_OFFSET right) => left.CompareTo(right) <= 0;

        public static bool operator >=(UTC_OFFSET left, UTC_OFFSET right) => left.CompareTo(right) >= 0;

        public override string ToString()
        {
            return HOURS < 0 || MINUTES < 0
                ? $"-{HOURS:D2}{MINUTES:D2}"
                : $"+{HOURS:D2}{MINUTES:D2}";
        }
    }
}
