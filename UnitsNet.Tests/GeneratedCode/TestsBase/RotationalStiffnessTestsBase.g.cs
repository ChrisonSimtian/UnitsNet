﻿//------------------------------------------------------------------------------
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
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of RotationalStiffness.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalStiffnessTestsBase
    {
        protected abstract double KilonewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }
        protected abstract double MeganewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }
        protected abstract double NewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilonewtonMetersPerRadianTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerRadianTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerRadianTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffness((double)0.0, RotationalStiffnessUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RotationalStiffness();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RotationalStiffnessUnit.NewtonMeterPerRadian, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffness(double.PositiveInfinity, RotationalStiffnessUnit.NewtonMeterPerRadian));
            Assert.Throws<ArgumentException>(() => new RotationalStiffness(double.NegativeInfinity, RotationalStiffnessUnit.NewtonMeterPerRadian));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffness(double.NaN, RotationalStiffnessUnit.NewtonMeterPerRadian));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalStiffness(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void RotationalStiffness_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RotationalStiffness(1, RotationalStiffnessUnit.NewtonMeterPerRadian);

            QuantityInfo<RotationalStiffnessUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RotationalStiffness.Zero, quantityInfo.Zero);
            Assert.Equal("RotationalStiffness", quantityInfo.Name);
            Assert.Equal(QuantityType.RotationalStiffness, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<RotationalStiffnessUnit>().Except(new[] {RotationalStiffnessUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void NewtonMeterPerRadianToRotationalStiffnessUnits()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.KilonewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.MeganewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RotationalStiffness.From(1, RotationalStiffnessUnit.KilonewtonMeterPerRadian);
            AssertEx.EqualTolerance(1, quantity00.KilonewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.KilonewtonMeterPerRadian, quantity00.Unit);

            var quantity01 = RotationalStiffness.From(1, RotationalStiffnessUnit.MeganewtonMeterPerRadian);
            AssertEx.EqualTolerance(1, quantity01.MeganewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.MeganewtonMeterPerRadian, quantity01.Unit);

            var quantity02 = RotationalStiffness.From(1, RotationalStiffnessUnit.NewtonMeterPerRadian);
            AssertEx.EqualTolerance(1, quantity02.NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.NewtonMeterPerRadian, quantity02.Unit);

        }

        [Fact]
        public void FromNewtonMetersPerRadian_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffness.FromNewtonMetersPerRadian(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalStiffness.FromNewtonMetersPerRadian(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonMetersPerRadian_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffness.FromNewtonMetersPerRadian(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.KilonewtonMeterPerRadian), KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.MeganewtonMeterPerRadian), MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.NewtonMeterPerRadian), NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);

            var kilonewtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.KilonewtonMeterPerRadian);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)kilonewtonmeterperradianQuantity.Value, KilonewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.KilonewtonMeterPerRadian, kilonewtonmeterperradianQuantity.Unit);

            var meganewtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.MeganewtonMeterPerRadian);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)meganewtonmeterperradianQuantity.Value, MeganewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.MeganewtonMeterPerRadian, meganewtonmeterperradianQuantity.Unit);

            var newtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.NewtonMeterPerRadian);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)newtonmeterperradianQuantity.Value, NewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.NewtonMeterPerRadian, newtonmeterperradianQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromKilonewtonMetersPerRadian(newtonmeterperradian.KilonewtonMetersPerRadian).NewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromMeganewtonMetersPerRadian(newtonmeterperradian.MeganewtonMetersPerRadian).NewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromNewtonMetersPerRadian(newtonmeterperradian.NewtonMetersPerRadian).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalStiffness v = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffness.FromNewtonMetersPerRadian(3)-v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffness.FromNewtonMetersPerRadian(10)/5).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, RotationalStiffness.FromNewtonMetersPerRadian(10)/RotationalStiffness.FromNewtonMetersPerRadian(5), NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalStiffness oneNewtonMeterPerRadian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            RotationalStiffness twoNewtonMetersPerRadian = RotationalStiffness.FromNewtonMetersPerRadian(2);

            Assert.True(oneNewtonMeterPerRadian < twoNewtonMetersPerRadian);
            Assert.True(oneNewtonMeterPerRadian <= twoNewtonMetersPerRadian);
            Assert.True(twoNewtonMetersPerRadian > oneNewtonMeterPerRadian);
            Assert.True(twoNewtonMetersPerRadian >= oneNewtonMeterPerRadian);

            Assert.False(oneNewtonMeterPerRadian > twoNewtonMetersPerRadian);
            Assert.False(oneNewtonMeterPerRadian >= twoNewtonMetersPerRadian);
            Assert.False(twoNewtonMetersPerRadian < oneNewtonMeterPerRadian);
            Assert.False(twoNewtonMetersPerRadian <= oneNewtonMeterPerRadian);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Equal(0, newtonmeterperradian.CompareTo(newtonmeterperradian));
            Assert.True(newtonmeterperradian.CompareTo(RotationalStiffness.Zero) > 0);
            Assert.True(RotationalStiffness.Zero.CompareTo(newtonmeterperradian) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Throws<ArgumentException>(() => newtonmeterperradian.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterperradian.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RotationalStiffness.FromNewtonMetersPerRadian(1);
            var b = RotationalStiffness.FromNewtonMetersPerRadian(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = RotationalStiffness.FromNewtonMetersPerRadian(1);
            var b = RotationalStiffness.FromNewtonMetersPerRadian(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.True(v.Equals(RotationalStiffness.FromNewtonMetersPerRadian(1), NewtonMetersPerRadianTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalStiffness.Zero, NewtonMetersPerRadianTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.False(newtonmeterperradian.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.False(newtonmeterperradian.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalStiffnessUnit.Undefined, RotationalStiffness.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalStiffnessUnit)).Cast<RotationalStiffnessUnit>();
            foreach(var unit in units)
            {
                if(unit == RotationalStiffnessUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalStiffness.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kN·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.KilonewtonMeterPerRadian).ToString());
                Assert.Equal("1 MN·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.MeganewtonMeterPerRadian).ToString());
                Assert.Equal("1 N·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 kN·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.KilonewtonMeterPerRadian).ToString(swedishCulture));
            Assert.Equal("1 MN·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.MeganewtonMeterPerRadian).ToString(swedishCulture));
            Assert.Equal("1 N·m/rad", new RotationalStiffness(1, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s1"));
                Assert.Equal("0.12 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s2"));
                Assert.Equal("0.123 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s3"));
                Assert.Equal("0.1235 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s1", culture));
            Assert.Equal("0.12 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s2", culture));
            Assert.Equal("0.123 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s3", culture));
            Assert.Equal("0.1235 N·m/rad", new RotationalStiffness(0.123456, RotationalStiffnessUnit.NewtonMeterPerRadian).ToString("s4", culture));
        }
    }
}
