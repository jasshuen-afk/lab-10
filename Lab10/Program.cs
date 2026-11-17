// Lab 10
// Student name:
// Student number:

using System;
using System.Collections.Generic;

Console.WriteLine("CPEN223 Lab 10");

//Testing: Write some test cases to test well all methods you are to implement
//         This is to demonstrates what test cases you have considered
//TODO
//end Testing code

//Do not change the program skeleton: keep the record structs, the class name,
//method names, parameters, and return types exactly as given.
//You may add private helper methods.

public readonly record struct Sample(
    string Sensor,
    int Minute,
    double Value);

public static class WindowSelector
{
    /// <summary>
    /// Selects records for one sensor in a half-open time window.
    /// </summary>
    /// <param name="samples">
    /// Non-null. Each Sample.Sensor is non-null and each Value is
    /// finite. Minute is measured in integer minutes since the
    /// beginning of the fictional session.
    /// </param>
    /// <param name="sensor">Non-null, nonempty sensor name.</param>
    /// <param name="startInclusive">Inclusive start (minutes).</param>
    /// <param name="endExclusive">
    /// Exclusive end (minutes); at least startInclusive.
    /// </param>
    /// <returns>
    /// A new list of Sample records with matching Sensor (ordinal,
    /// case-sensitive equality) and Minute in [startInclusive,
    /// endExclusive). Preserve input order and duplicate times.
    /// Return an empty list when none match.
    /// </returns>
    /// <remarks>
    /// Requires: all input conditions above must hold.
    /// Effects: neither the input nor its elements are modified.
    /// No outcome is specified for invalid calls.
    /// </remarks>
    public static IReadOnlyList<Sample> SelectWindow(
        IReadOnlyList<Sample> samples,
        string sensor,
        int startInclusive,
        int endExclusive)
    {
        throw new NotImplementedException();
    }
}
