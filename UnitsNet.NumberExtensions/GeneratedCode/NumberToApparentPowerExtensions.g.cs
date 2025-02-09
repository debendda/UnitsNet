//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToApparentPower
{
    /// <summary>
    /// A number to ApparentPower Extensions
    /// </summary>
    public static class NumberToApparentPowerExtensions
    {
        /// <inheritdoc cref="ApparentPower.FromGigavoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Gigavoltamperes<T>(this T value) =>
            ApparentPower.FromGigavoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentPower.FromKilovoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Kilovoltamperes<T>(this T value) =>
            ApparentPower.FromKilovoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentPower.FromMegavoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Megavoltamperes<T>(this T value) =>
            ApparentPower.FromMegavoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentPower.FromMicrovoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Microvoltamperes<T>(this T value) =>
            ApparentPower.FromMicrovoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentPower.FromMillivoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Millivoltamperes<T>(this T value) =>
            ApparentPower.FromMillivoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentPower.FromVoltamperes(UnitsNet.QuantityValue)" />
        public static ApparentPower Voltamperes<T>(this T value) =>
            ApparentPower.FromVoltamperes(Convert.ToDouble(value));

    }
}
