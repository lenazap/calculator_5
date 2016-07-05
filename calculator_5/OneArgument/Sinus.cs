﻿using System;

namespace calculator_5.OneArgument
{
    public class Sinus: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}