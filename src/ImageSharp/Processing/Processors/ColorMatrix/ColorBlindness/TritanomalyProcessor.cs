﻿// <copyright file="TritanomalyProcessor.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Processing.Processors
{
    using System;
    using System.Numerics;

    using ImageSharp.PixelFormats;

    /// <summary>
    /// Converts the colors of the image recreating Tritanomaly (Blue-Weak) color blindness.
    /// </summary>
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    internal class TritanomalyProcessor<TPixel> : ColorMatrixProcessor<TPixel>
        where TPixel : struct, IPixel<TPixel>
    {
        /// <inheritdoc/>
        public override Matrix4x4 Matrix => new Matrix4x4()
        {
            M11 = 0.967F,
            M21 = 0.33F,
            M22 = 0.733F,
            M23 = 0.183F,
            M32 = 0.267F,
            M33 = 0.817F,
            M44 = 1
        };

        /// <inheritdoc/>
        public override bool Compand => false;
    }
}